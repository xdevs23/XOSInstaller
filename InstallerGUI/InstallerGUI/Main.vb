Imports System.Drawing.Text
Imports System.IO
Imports xdevs23.Localization
Imports xdlib.Managing.Configuration.Filesystem
Imports xdui

Public Class Main

    Protected Friend Shared LangManager As LanguageManager
    Private RobotoCondensed, RobotoLight, RobotoThin As PrivateFontCollection
    Private CurrentPage As Integer = 0, CurrentLangIndex As Integer = 0
    Private DM As DownloadManager
    
    Private WasAlreadyInetDetected   As Boolean = False,
            IsToStartInstallation    As Boolean = False,
            DeviceDetectedForInstall As Boolean = False,
            ShouldClose              As Boolean = False,
            IsFinishPage             As Boolean = False

    Private WithEvents _
        AdbDetectDeviceTimer As New Timer(),
        InstallTimer         As New Timer()
    Private _
        AdbDetectDeviceThread, InstallThread As Threading.Thread

    ' 0 = Installation didn't start
    ' 1 = Installation started
    ' 2 = Installation succeeded
    ' 3 = Installation failed
    Private InstallState As Integer = 0

    Friend Shared ReadOnly _
            STRING_EXIT_CONFIRMATION As String = "confirm_exit",
            STRING_EXIT_CONF_TITLE   As String = "confirm_exit_title",
            STRING_DEVICE_DETECTED   As String = "page_detect_device_detected",
            STRING_DEVICE_DETECTING  As String = "page_detect_detecting_device",
            STRING_INET_CHECKING     As String = "page_checkinet_checkinet",
            STRING_NO_INET           As String = "page_checkinet_noinet",
            STRING_DLSTF_DOWNLOADING As String = "page_dlstuff_downloading",
            STRING_DLSTF_DL_FAILED   As String = "page_dlstuff_download_failed",
            STRING_DLSTF_NO_DEV_SUP  As String = "page_dlstuff_device_not_supported"

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        If MessageBox.Show(LangManager.GetString(STRING_EXIT_CONFIRMATION),
                           LangManager.GetString(STRING_EXIT_CONF_TITLE),
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            ShouldClose = True
            Close()
            End
        End If
        ShouldClose = False
    End Sub

    Private Sub BtnRetryDlStuff_Click(sender As Object, e As EventArgs) Handles BtnRetryDlStuff.Click
        HandlePage(PageDlStuffPanel.Name)
    End Sub

    Private Sub BtnRetryDlRom_Click(sender As Object, e As EventArgs) Handles BtnRetryDlRom.Click
        HandlePage(PageDlRomPanel.Name)
    End Sub

    Private Sub ChkPreInstallAgree_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPreInstallAgree.CheckedChanged
        BtnNext.Enabled = ChkPreInstallAgree.Checked
    End Sub

    Private Sub AdbDetectDeviceTimer_Tick(sender As Object, e As EventArgs) Handles AdbDetectDeviceTimer.Tick
        HandlePage(PageDetectDevicePanel.Name, STRING_DEVICE_DETECTED)
    End Sub

    Private Sub HandlePage(PageName As String, Optional Arguments As String = "")
        Select Case PageName
            Case PageDetectDevicePanel.Name
                If Arguments.Equals("") Then
                    LblDetectingDevice.Tag = STRING_DEVICE_DETECTING
                    LangManager.RefreshLanguage(PageDetectDevicePanel)
                    AdbDetectDeviceThread = New Threading.Thread( _
                        New Threading.ThreadStart(AddressOf DoAdbDetect) _
                    )
                    AdbDetectDeviceThread.Start()
                    AdbDetectDeviceTimer.Interval = 2000
                    AdbDetectDeviceTimer.Start()
                    BtnNext.Enabled = False
                    BtnBack.Enabled = False
                Else
                    If AdbDetectDeviceThread.ThreadState = Threading.ThreadState.Stopped Then
                        Dim OldTag As String = LblDetectingDevice.Tag.ToString()
                        LblDetectingDevice.Tag = STRING_DEVICE_DETECTED
                        LangManager.RefreshLanguage(PageDetectDevicePanel)
                        BtnNext.Enabled = True
                        BtnBack.Enabled = True
                        AdbDetectDeviceTimer.Stop()
                        If IsToStartInstallation Then
                            DeviceDetectedForInstall = True
                            ChangePage(CInt(PageInstallPanel.Tag))
                        End If
                    End If
                End If
            Case PageCheckInetPanel.Name
                If WasAlreadyInetDetected Then
                    WasAlreadyInetDetected = False
                    ChangePage(False)
                    Return
                End If
                LblCheckInet.Tag = STRING_INET_CHECKING
                LangManager.RefreshLanguage(PageCheckInetPanel)
                BtnNext.Enabled = False
                BtnRetryInet.Visible = False
                If Not Net.NetUtils.IsInternetAvailable() Then
                    LblCheckInet.Tag = STRING_NO_INET
                    LangManager.RefreshLanguage(PageCheckInetPanel)
                    BtnRetryInet.Visible = True
                    Return
                End If
                WasAlreadyInetDetected = True
                ChangePage(True)
            Case PageDlStuffPanel.Name
                DM.DlWebClient.CancelAsync()
                BtnNext.Enabled = False
                BtnNext.Visible = True
                PrgDlStuff.SetAutoAdvanceLabel(LblDlStuffStatusPrg)
                PrgDlStuffTotal.SetAutoAdvanceLabel(LblDlStuffTotalPrg)
                PanelDownloadStuff.Visible = True
                PrgDlStuff.SetProgress(0)
                PrgDlStuffTotal.SetProgress(0)
                BtnRetryDlStuff.Visible = False
                LblDlStuffStatus.Tag = STRING_DLSTF_DOWNLOADING

                LabelUpdater.UpdateLabel(LblDlStuffStatus, New String() { "==page_dlstuff_dl_necessary_stuff==" })
                ' Get the necessary stuff
                Dim NecStuff As String() = My.Resources.NecessaryDownloadStuff.Split( _
                                            New String() {vbCrLf, vbLf}, StringSplitOptions.RemoveEmptyEntries)
                ' To keep track of the current line of the above array
                Dim CurrentLine As Integer = 0
                ' Stuff to do
                Dim DoCount As Integer = NecStuff.Count * 2
                ' Current line
                Dim Line As String = NecStuff(CurrentLine)
                ' ProgressChanged listener
                Dim did As DownloadManager.DownloadStatusListener.OnProgressChangedDelegate = _ 
                    Sub(Progress As Integer, BytesReceived As Long, BytesToReceive As Long)
                        PrgDlStuff.SetProgress(Progress)
                    End Sub
                ''' Explanation for this mess:
                ''' The downloads are done asynchronously, means on another thread.
                ''' Therefore we need to use these listeners to start the next download after completion
                ''' of the previous download.
                ''' 
                ''' This seems much of a mess, but it actually is pretty simple, just a little bit
                ''' cluttered.
                ' DownloadCompleted listener for device specific stuff
                Dim dcdd As DownloadManager.DownloadStatusListener.OnDownloadCompletedDelegate = _
                    Sub(Success As Boolean, Ex As Exception, WasCancelled As Boolean)
                        If Not Success Then
                            PrgDlStuff.SetProgressColor(Color.Red)
                            Console.WriteLine("Download failed: " & vbNewLine & Ex.StackTrace)
                            LblDlStuffStatus.Tag = STRING_DLSTF_DL_FAILED
                            LabelUpdater.UpdateLabel(LblDlStuffStatus, New String() { NecStuff(CurrentLine) })
                            Return
                        End If
                        PrgDlStuff.AdvanceProgress(100)
                        PrgDlStuffTotal.AdvanceProgress(100)
                        ChangePage(True)
                    End Sub
                ' DownloadCompleted listener for necessary stuff
                Dim dcdn As DownloadManager.DownloadStatusListener.OnDownloadCompletedDelegate = _
                    Sub(Success As Boolean, Ex As Exception, WasCancelled As Boolean)
                        ' Say that it failed
                        If Not Success Then
                            PrgDlStuff.SetProgressColor(Color.Red)
                            Console.WriteLine("Download failed: " & vbNewLine & Ex.StackTrace)
                            LblDlStuffStatus.Tag = STRING_DLSTF_DL_FAILED
                            LabelUpdater.UpdateLabel(LblDlStuffStatus, New String() { NecStuff(CurrentLine) })
                            Return
                        End If
                        CurrentLine += 1
                        ' Update total progress
                        PrgDlStuffTotal.AdvanceProgress(CInt(Math.Round(CurrentLine / DoCount)))
                        PrgDlStuff.AdvanceProgress(100)
                        If CurrentLine < NecStuff.Count Then
                            Line = NecStuff(CurrentLine)
                            DM.DownloadFile(Line, "data" & Line.Substring(Line.LastIndexOf("/")), dcdn, did)
                        End If

                        ' If the last file was downloaded, then download the next one!
                        If CurrentLine = NecStuff.Count Then
                            CurrentLine = 0
                            PrgDlStuffTotal.AdvanceProgress(51)
                            Dim DevIndex As ConfigFile = Utils.ReadConfigFile("data/DeviceRepos.list")
                            Console.WriteLine("Device list: " & String.Join(", ", DevIndex.GetAllKeys()))
                            Console.WriteLine("Device-specific URL for " & _ 
                                              InstallerStorage.TargetDevice & ": """ & DevIndex.GetValue(InstallerStorage.TargetDevice) & """")
                            ' Check if device is supported
                            If IsNothing(DevIndex.GetValue(InstallerStorage.TargetDevice)) _
                                OrElse DevIndex.GetValue(InstallerStorage.TargetDevice).Equals("") Then
                                LblDeviceNotSupported.Visible = True
                                PanelDownloadStuff.Visible = False
                                BtnRetryDlStuff.Visible = True
                                Return
                            End If

                            ' Download device-specific stuff
                            DM.DownloadFile(DevIndex.GetValue(InstallerStorage.TargetDevice),
                                            "data/devices/" & InstallerStorage.TargetDevice & ".list", dcdd, did)
                        End If
                    End Sub
                If CurrentLine < NecStuff.Count Then
                    DM.DownloadFile(Line, "data" & Line.Substring(Line.LastIndexOf("/")), dcdn, did)
                End If
            Case PageDlRomPanel.Name
                DM.DlWebClient.CancelAsync()
                BtnNext.Enabled = False
                BtnNext.Visible = True
                PrgDlRomStatus.ResetProgressColor()
                PrgDlRomStatus.SetAutoAdvanceLabel(LblDlRomStatusPrg)
                PrgDlRomTotal.SetAutoAdvanceLabel(LblDlRomTotalPrg)
                PanelDlRomPrg.Visible = True
                PrgDlRomStatus.SetProgress(0)
                PrgDlRomTotal.SetProgress(0)
                BtnRetryDlRom.Visible = False
                LblDlRomStatus.Tag = STRING_DLSTF_DOWNLOADING

                LabelUpdater.UpdateLabel(LblDlStuffStatus, "")

                Dim RD As New RomDownloader(DM, LangManager, PrgDlRomTotal, PrgDlRomStatus)
                RD.DownloadFull()
            Case PagePreInstallPanel.Name
                BtnNext.Enabled = False
                BtnNext.Visible = True
            Case PageInstallPanel.Name
                BtnBack.Enabled = False
                BtnNext.Enabled = False
                BtnNext.Visible = True
                If Not DeviceDetectedForInstall Then
                    IsToStartInstallation = True
                    ChangePage(CInt(PageDetectDevicePanel.Tag))
                    Return
                End If
                PrgIInstallXOS.SetIntermediate(True)
                InstallTimer.Interval = 2000
                InstallTimer.Start()
                InstallThread = New Threading.Thread( _
                    New Threading.ThreadStart(AddressOf DoInstall) _
                )
                InstallThread.Start()
            Case PageFinishedPanel.Name
                BtnNext.Enabled = True
        End Select
    End Sub

    Private Sub BtnRetryInet_Click(sender As Object, e As EventArgs) Handles BtnRetryInet.Click
        HandlePage(PageCheckInetPanel.Name)
    End Sub

    Protected Friend Sub ChangePage(PageNum As Integer)
        Dim PageCount As Integer = 0, FoundPage As Integer = 0
        Dim FoundPageName As String = ""
        For i As Integer = 0 To Controls.Count - 1 Step 1
            Dim C As Control = Controls(i)
            If isNothing(C.Tag) OrElse C.Tag.ToString().Equals("") Then Continue For
            If TypeOf(C) Is Panel AndAlso C.Name.Contains("Page") AndAlso IsNumeric(C.Tag.ToString())
                If Not C.Name.Contains("Page") Then Continue For
                C.SendToBack()
                C.Visible = False
                PageCount += 1
            End If
        Next
        For i As Integer = 0 To Controls.Count - 1 Step 1
            Dim C As Control = Controls(i)
            If isNothing(C.Tag) OrElse C.Tag.ToString().Equals("") Then Continue For
            If TypeOf(C) Is Panel AndAlso C.Name.Contains("Page") AndAlso IsNumeric(C.Tag.ToString())
                If Integer.Parse(C.Tag.ToString()) = PageNum Then
                    C.Visible = True
                    C.BringToFront()
                    FoundPage = Integer.Parse(C.Tag.ToString())
                    FoundPageName = C.Name
                    LangManager.RefreshLanguage(C)
                End If
            End If
        Next
        CurrentPage = FoundPage
        BtnNext.Text = IIf(Not (CurrentPage = PageCount - 2), 
                           LangManager.GetString("general_next"), LangManager.GetString("general_finish")) _
                           .ToString()
        IsFinishPage = (CurrentPage = PageCount - 2)
        BtnBack.Visible = (CurrentPage > 0)
        HandlePage(FoundPageName)
    End Sub

    Private Sub BtnShowConsole_Click(sender As Object, e As EventArgs) Handles BtnShowConsole.Click
        ConsoleWindow.Show()
    End Sub

    Private Sub DoAdbDetect()
        Console.WriteLine()
        Console.WriteLine("Detecting device...")
        AdbHelper.ExecuteAdbCommand("kill-server")
        AdbHelper.ExecuteAdbCommand("start-server")
        AdbHelper.ExecuteAdbCommand("wait-for-device")
        AdbHelper.ExecuteAdbCommand("devices")
        InstallerStorage.TargetDevice = AdbHelper.ExecuteAdbCommand("shell getprop ro.product.device") _
            .Replace(vbCr, "").Replace(vbLf, "").Replace(" ", "")
        Console.WriteLine("Detected device '" & InstallerStorage.TargetDevice & "'")
        Console.WriteLine()
    End Sub

    Private Sub DoInstall()
        Console.WriteLine()
        Console.WriteLine("Installation is starting...")
        Dim p As New ProcessStartInfo

        p.FileName  = "data/devices/" & InstallerStorage.TargetDevice & "/install.bat"
        Environment.SetEnvironmentVariable("PATH", 
                                           Environment.GetEnvironmentVariable("PATH") _
                                           & ";" & Environment.CurrentDirectory & "\prebuilts" & _
                                           IIf(My.Computer.Info.OSPlatform.ToLower().Contains("unix"), "/linux/adb", "\adb").ToString() _
                                           )
        Console.WriteLine("PATH: " & Environment.GetEnvironmentVariable("PATH"))

        ' Don't show a window!
        p.WindowStyle = ProcessWindowStyle.Hidden
        p.CreateNoWindow = True

        ' Prepare to catch up the output
        p.RedirectStandardOutput = True
        p.UseShellExecute = False

        ' Start the process
        Dim proc As New Process()
        proc.StartInfo = p
        proc.EnableRaisingEvents = True
        Application.DoEvents()
        AddHandler proc.ErrorDataReceived,  AddressOf Console.WriteLine
        AddHandler proc.OutputDataReceived, AddressOf Console.WriteLine
        proc.Start()
        InstallState = 1
        Console.WriteLine("Installation started.")
        proc.WaitForExit()
        Dim result As String = proc.StandardOutput.ReadToEnd()
        InstallState = CInt(IIf(result.Contains("!!!"), 3, 2))
        Console.WriteLine("The final result is: " & vbNewLine & result)
    End Sub

    Protected Friend Sub ChangePage(Forward As Boolean)
        ChangePage(CType(IIf(Forward, CurrentPage + 1, CurrentPage - 1), Integer))
    End Sub

    Private Sub NextBackButton_Click(sender As Object, e As EventArgs) Handles BtnNext.Click, BtnBack.Click
        If CType(sender, FlatButton).Equals(BtnBack) Then
            DM.DlWebClient.CancelAsync()
        Else
            If IsFinishPage Then
                If ChkRebootDevice.Checked Then AdbHelper.ExecuteAdbCommand("reboot")
                ShouldClose = True
                Close()
                End
            End If
        End If
        ChangePage(CType(sender, FlatButton).Equals(BtnNext))
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.WriteLine("Initialization started.")
        Console.WriteLine()
        Dim sw As New StopWatch
        ' Load fonts
        sw.Start()
        Console.WriteLine("Loading fonts...")
        RobotoCondensed = New PrivateFontCollection
        RobotoLight = New PrivateFontCollection
        RobotoThin = New PrivateFontCollection
        For Each FontFile As String
                In Directory.GetFiles("fonts/", "Roboto-*.ttf", SearchOption.AllDirectories)
            Debug.WriteLine("Debug: Loading font file " & FontFile & " for main window")
            If FontFile.Contains("Thin") Then
                RobotoThin.AddFontFile(FontFile)
            ElseIf FontFile.Contains("Light") Then
                RobotoLight.AddFontFile(FontFile)
            End If
        Next
        For Each FontFile As String
                In Directory.GetFiles("fonts/", "RobotoCondensed-*.ttf", SearchOption.AllDirectories)
            RobotoCondensed.AddFontFile(FontFile)
        Next
        Font = New Font(RobotoCondensed.Families(0), 9.25, FontStyle.Regular)
        sw.Stop()
        Console.WriteLine("Fonts loaded. " & sw.ElapsedMilliseconds() & " ms elapsed.")

        Console.WriteLine()

        ' Load languages
        sw.Start()
        Console.WriteLine("Loading languages...")
        LangManager = New LanguageManager()
        LangManager.AutoApplyLanguage(Me)
        Dim length As Byte = 0
        For Each L As Language In LangManager.Loader.GetLanguages()
            CbxLanguageCh.Items.Add(L)
            length = Math.Max(length, CByte(L.ToString().Length))
        Next
        CbxLanguageCh.DropDownWidth = CInt(Math.Round(length * (9.25 * 0.56), 0, MidpointRounding.AwayFromZero))
        CbxLanguageCh.SelectedItem = LangManager.Loader.GetDefaultLanguage()
        CurrentLangIndex = CbxLanguageCh.SelectedIndex
        
        Console.WriteLine("Languages loaded. " & sw.ElapsedMilliseconds() & " ms elapsed.")
        sw.Stop()

        ' Prepare the form
        Try
            Icon = New Icon("xosicon.ico")
        Catch ex As ComponentModel.Win32Exception
            Dim lineToWrite As String = "Warning: Failed to load icon, assuming linux, skipping this step."
            Debug.WriteLine(lineToWrite)
            Console.WriteLine(lineToWrite)
        End Try
 
        Size = New Size(820, 640)
        For Each C As Control In Controls
            If TypeOf (C) Is Panel AndAlso C.Name.Contains("Page") Then
                C.Size = New Size(800, 420) ' Have the same size for all panels
                C.Location = New Point(2, 94)
                For Each Cx As Control In C.Controls
                    If TypeOf (Cx) Is Label Then
                        Cx.MaximumSize = New Size(C.Width, C.Height)
                    ElseIf TypeOf(Cx) Is ComboBox _
                        Or TypeOf(Cx) Is FlatButton _
                        Then
                        Cx.Font = Font
                    End If
                Next
            End If
            If TypeOf (C) Is FlatButton Then
                C.Font = Font
            End If
        Next

        ' Prepare other stuff
        LabelUpdater.SetLangManager(LangManager)

        Directory.CreateDirectory("data")

        DM = New DownloadManager()

        ' Prepare the first panel
        ChangePage(CurrentPage)
    End Sub

    Public Sub Main_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        On Error Resume Next ' Force threads to stop without exception
        Console.WriteLine()
        Console.WriteLine("Shutting down application...")
        ' Abort any running downloads
        DM.DlWebClient.CancelAsync()
        DM.DlWebClient.Dispose()
        ' Stop timers
        AdbDetectDeviceTimer.Stop()
        ' Shut down threads
        AdbDetectDeviceThread.Abort()
        Console.WriteLine("Removing temporary data...")
        If Directory.Exists("data") Then Directory.Delete("data", True)
        Console.WriteLine()
        Console.WriteLine("The installer is now closed." & vbNewLine & 
                          "The console remains open until you manually close it.")
    End Sub

    Private Sub CbxLanguageCh_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CbxLanguageCh.SelectionChangeCommitted
        If Not CbxLanguageCh.SelectedIndex = CurrentLangIndex Then
            LangManager.ApplyLanguage(Me, CType(CbxLanguageCh.SelectedItem, Language).LangName)
            CurrentLangIndex = CbxLanguageCh.SelectedIndex
        End If
    End Sub

    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If (Not e.CloseReason = CloseReason.WindowsShutDown) And (Not e.CloseReason = CloseReason.ApplicationExitCall) _
            AndAlso (Not ShouldClose) Then
            e.Cancel = True
            BtnCancel_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub InstallTimer_Tick(sender As Object, e As EventArgs) Handles InstallTimer.Tick
        Select Case InstallState
            ' Installation didn't start yet, don't do anything.
            Case 0: Return
            ' Installation started, don't do anything as well.
            Case 1: Return
            ' Installation succeeded, switch to finish page with good message
            Case 2:
                Console.WriteLine("Installation succeeded :D")
                LblInstallSucceeded.Visible = True
                LblInstallFailed.Visible = False
            ' Installation failed, switch to finish page with bad message
            Case 3:
                Console.WriteLine("Installation failed :/")
                LblInstallSucceeded.Visible = False
                LblInstallFailed.Visible = True
                LblInstallFailed.Location = LblInstallSucceeded.Location
            ' !? Ignore.
            Case Else: Return
        End Select
        InstallTimer.Interval = Integer.MaxValue
        ChangePage(True)
        InstallTimer.Stop()
    End Sub

End Class
