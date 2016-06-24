Imports System.Drawing.Text
Imports System.IO
Imports xdevs23.Localization
Imports xdlib.Net
Imports xdui

Public Class Main

    Protected Friend Shared LangManager As LanguageManager
    Private RobotoCondensed, RobotoLight, RobotoThin As PrivateFontCollection
    Private CurrentPage As Integer = 0, CurrentLangIndex As Integer = 0

    Private WithEvents _
        AdbDetectDeviceTimer As New Timer()
    Private _
        AdbDetectDeviceThread As Threading.Thread

    Private Shared ReadOnly _
            STRING_EXIT_CONFIRMATION As String = "confirm_exit",
            STRING_EXIT_CONF_TITLE   As String = "confirm_exit_title",
            STRING_DEVICE_DETECTED   As String = "page_detect_device_detected",
            STRING_DEVICE_DETECTING  As String = "page_detect_detecting_device",
            STRING_INET_CHECKING     As String = "page_checkinet_checkinet",
            STRING_NO_INET           As String = "page_checkinet_noinet"

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        If MessageBox.Show(LangManager.GetString(STRING_EXIT_CONFIRMATION),
                           LangManager.GetString(STRING_EXIT_CONF_TITLE),
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Close()
            End
        End If
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
                    End If
                End If
            Case PageCheckInetPanel.Name
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
                ChangePage(True)
        End Select
    End Sub

    Private Sub BtnRetryInet_Click(sender As Object, e As EventArgs) Handles BtnRetryInet.Click
        HandlePage(PageCheckInetPanel.Name)
    End Sub

    Private Sub ChangePage(PageNum As Integer)
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
        BtnNext.Visible = Not (CurrentPage = PageCount - 2)
        BtnBack.Visible = (CurrentPage > 0)
        HandlePage(FoundPageName)
    End Sub

    Private Sub BtnShowConsole_Click(sender As Object, e As EventArgs) Handles BtnShowConsole.Click
        ConsoleWindow.Show()
    End Sub

    Private Sub DoAdbDetect()
        Console.WriteLine("Detecting device...")
        AdbHelper.ExecuteAdbCommand("kill-server")
        AdbHelper.ExecuteAdbCommand("start-server")
        AdbHelper.ExecuteAdbCommand("wait-for-device")
        AdbHelper.ExecuteAdbCommand("devices")
        AdbHelper.ExecuteAdbCommand("shell getprop ro.product.device")
    End Sub

    Private Sub ChangePage(Forward As Boolean)
        ChangePage(CType(IIf(Forward, CurrentPage + 1, CurrentPage - 1), Integer))
    End Sub

    Private Sub NextBackButton_Click(sender As Object, e As EventArgs) Handles BtnNext.Click, BtnBack.Click
        ChangePage(CType(sender, FlatButton).Equals(BtnNext))
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.WriteLine("Initialization started.")
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
                    ElseIf TypeOf(Cx) _
                        Is ComboBox _
                        Then
                        Cx.Font = Font
                    End If
                Next
            End If
            If TypeOf (C) Is FlatButton Then
                C.Font = Font
            End If
        Next

        ' Prepare the first panel
        ChangePage(CurrentPage)
    End Sub

    Public Sub Main_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        On Error Resume Next ' Force threads to stop without exception
        ' Stop timers
        AdbDetectDeviceTimer.Stop()
        ' Shut down threads
        AdbDetectDeviceThread.Abort()
    End Sub

    Private Sub CbxLanguageCh_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CbxLanguageCh.SelectionChangeCommitted
        If Not CbxLanguageCh.SelectedIndex = CurrentLangIndex Then
            LangManager.ApplyLanguage(Me, CType(CbxLanguageCh.SelectedItem, Language).LangName)
            CurrentLangIndex = CbxLanguageCh.SelectedIndex
        End If
    End Sub
End Class
