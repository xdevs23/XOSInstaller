Imports xdevs23.Localization
Imports xdlib.Managing.Configuration.Filesystem
Imports xdui

Public Class RomDownloader

    Public DeviceDir As String = "data/devices/" & InstallerStorage.TargetDevice

    Private DM As DownloadManager
    Private LM As LanguageManager
    Private PrgTotal, PrgStatus As FlatProgressBar

    Private TotalSteps As Integer  = 4
    Private CurrentStep As Integer = 0

    Private BeginBDlText As String = "0 / 0 MiB"

    Private DeviceRepo As ConfigFile

    Public Sub New(ByRef DlMgr As DownloadManager, ByRef LangMgr As LanguageManager,
                   ByRef PrgTotal As FlatProgressBar, ByRef PrgStatus As FlatProgressBar)
        DM = DlMgr
        LM = LangMgr
        Me.PrgTotal = PrgTotal
        Me.PrgStatus = PrgStatus
        DeviceRepo = Utils.ReadConfigFile("data/devices/" & InstallerStorage.TargetDevice & ".list")
    End Sub

    Private Sub UpdateTotalProgress(ProgressStep As Integer)
        CurrentStep = ProgressStep
        PrgTotal.AdvanceProgress(CInt(Math.Round(Math.Min(PrgStatus.GetProgress() / 4 + CurrentStep * 25, 100))))
        Dim part As String = ""
        Select Case CurrentStep
            Case 0: part = "fw"
            Case 1: part = "recov"
            Case 2: part = "rom"
            Case 3: part = "misc"
        End Select
        LabelUpdater.UpdateLabel(Main.LblDlRomStatus, New String() { "==page_dlrom_part_" & part & "==" })
    End Sub

    Private Sub UpdateSubProgress(Progress As Integer, Optional ProgressStep As Integer = -1)
        PrgStatus.SetProgress(Progress)
        UpdateTotalProgress(CInt(IIf(ProgressStep >= 0, ProgressStep, CurrentStep)))
    End Sub

    Private Sub ProgressFailed(What As String, Ex As Exception)
        PrgStatus.SetProgressColor(Color.Red)
        Console.WriteLine("Download failed: " & vbNewLine & Ex.StackTrace)
        Main.LblDlRomStatus.Tag = Main.STRING_DLSTF_DL_FAILED
        LabelUpdater.UpdateLabel(Main.LblDlRomStatus, New String() { "==" & What & "==" })
        Main.BtnRetryDlRom.Visible = True
    End Sub

    Public Sub DownloadRom()
        Console.WriteLine()
        Console.WriteLine("Downloading ROM...")
        UpdateSubProgress(0, 2)
        Main.LblDlRomStatusBPrg.Text = BeginBDlText
        Dim romzip As String = DeviceRepo.GetValue("fullrom")
        DM.SetDownloadFile(romzip, DeviceDir & "/XOS-ROM.zip")
        DM.SetListeners( _
            Sub(Success As Boolean, Ex As Exception, WasCancelled As Boolean) ' OnDownloadCompleted
                If Success Then
                    Main.LblDlRomStatusBPrg.Text = BeginBDlText
                    DownloadOtherStuff
                Else
                    ProgressFailed("page_dlrom_part_rom", Ex)
                End If
            End Sub,
            Sub(Progress As Integer, BytesReceived As Long, BytesToReceive As Long) ' OnProgressChange
                UpdateSubProgress(Progress)
                Main.LblDlRomStatusBPrg.Text = Math.Round(BytesReceived / 1024 / 1024, 1).ToString() & _
                                                " / " & Math.Round(BytesToReceive / 1024 / 1024, 1).ToString & _
                                                " MiB"
            End Sub _
        )
        DM.StartDownload()
    End Sub

    Public Function DownloadFirmware() As Boolean
        Console.WriteLine()
        Console.WriteLine("Downloading firmware...")
        UpdateSubProgress(0, 0)
        Main.LblDlRomStatusBPrg.Text = BeginBDlText
        Dim fwzip As String = DeviceRepo.GetValue("fwzip")
        If fwzip.Equals("") Then
            DownloadRecovery()
            Return False
        End If
        DM.SetDownloadFile(fwzip, DeviceDir & "/fwzip.zip")
        DM.SetListeners( _
            Sub(Success As Boolean, Ex As Exception, WasCancelled As Boolean) ' OnDownloadCompleted
                If Success Then
                    If Not DownloadRecovery() Then
                        Main.LblDlRomStatusBPrg.Text = BeginBDlText
                        DownloadRom()
                    End If
                Else
                    ProgressFailed("page_dlrom_part_fw", Ex)
                End If
            End Sub,
            Sub(Progress As Integer, BytesReceived As Long, BytesToReceive As Long) ' OnProgressChange
                UpdateSubProgress(Progress)
                Main.LblDlRomStatusBPrg.Text = Math.Round(BytesReceived / 1024 / 1024, 1).ToString() & _
                                                " / " & Math.Round(BytesToReceive / 1024 / 1024, 1).ToString & _
                                                " MiB"
            End Sub _
        )
        DM.StartDownload()
        Return True
    End Function

    Public Function DownloadRecovery() As Boolean
        Console.WriteLine()
        Console.WriteLine("Downloading recovery...")
        UpdateSubProgress(0, 1)
        Main.LblDlRomStatusBPrg.Text = BeginBDlText
        Dim recovimg As String = DeviceRepo.GetValue("recovimg")
        If recovimg.Equals("") Then
            DownloadRom()
            Return False
        End If
        DM.SetDownloadFile(recovimg, DeviceDir & "/recov.img")
        DM.SetListeners( _
            Sub(Success As Boolean, Ex As Exception, WasCancelled As Boolean) ' OnDownloadCompleted
                If Success Then
                    Main.LblDlRomStatusBPrg.Text = BeginBDlText
                    DownloadRom()
                Else
                    ProgressFailed("page_dlrom_part_recov", Ex)
                End If
            End Sub,
            Sub(Progress As Integer, BytesReceived As Long, BytesToReceive As Long) ' OnProgressChange
                UpdateSubProgress(Progress)
                Main.LblDlRomStatusBPrg.Text = Math.Round(BytesReceived / 1024 / 1024, 1).ToString() & _
                                                " / " & Math.Round(BytesToReceive / 1024 / 1024, 1).ToString & _
                                                " MiB"
            End Sub _
        )
        DM.StartDownload()
        Return True
    End Function

    Public Sub DownloadOtherStuff()
        Console.WriteLine()
        Console.WriteLine("Downloading other stuff...")
        UpdateSubProgress(0, 3)
        Main.LblDlRomStatusBPrg.Text = BeginBDlText
        UpdateSubProgress(100)
        Main.ChangePage(True)
    End Sub

    Public Sub DownloadFull()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("Starting full download!")
        DownloadFirmware()
    End Sub

End Class
