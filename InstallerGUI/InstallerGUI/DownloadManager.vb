Imports System.ComponentModel
Imports System.Net
Imports System.Text

Public Class DownloadManager

    Public WithEvents DlWebClient As WebClient
    Public StatusListener As DownloadStatusListener

    Public Sub New()
        Console.WriteLine("Initializing a new download manager...")
        DlWebClient = New WebClient()
        DlWebClient.Encoding = Encoding.UTF8
        Console.WriteLine("Download manager initialized!")
    End Sub

    Private Sub DlWebClient_DownloadFileCompleted(sender As Object, e As AsyncCompletedEventArgs) Handles DlWebClient.DownloadFileCompleted
        StatusListener.OnDownloadCompleted(IsNothing(e.Error), e.Error, e.Cancelled)
        StatusListener = Nothing
    End Sub

    Private Sub DlWebClient_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles DlWebClient.DownloadProgressChanged
        StatusListener.OnProgressChanged(e.ProgressPercentage, e.BytesReceived, e.TotalBytesToReceive)
    End Sub

    Private Sub DlWebClient_DownloadStringCompleted(sender As Object, e As DownloadStringCompletedEventArgs) Handles DlWebClient.DownloadStringCompleted
        StatusListener.OnDownloadCompleted(IsNothing(e.Error), e.Error, e.Cancelled)
        StatusListener.OnDownloadStringCompleted(e.Result)
        StatusListener = Nothing
    End Sub

    Public Function DownloadFile(Url As String, Filename As String,
                                 Optional Listener As DownloadStatusListener = Nothing) As Boolean
        Console.WriteLine("Starting download of """ & Url & """ to """ & Filename & """")
        StatusListener = Listener
        Try
            DlWebClient.DownloadFileAsync(New Uri(Url), FileName)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function DownloadString(Url As String, Listener As DownloadStatusListener) As Boolean
        Console.WriteLine("Starting download of """ & Url & """")
        StatusListener = Listener
        Try
            DlWebClient.DownloadStringAsync(New Uri(Url))
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Interface DownloadStatusListener
        Sub OnDownloadCompleted(Success As Boolean, Exception As Exception, WasCancelled As Boolean)
        Sub OnProgressChanged(Progress As Integer, BytesReceived As Long, BytesToReceive As Long)
        Sub OnDownloadStringCompleted(ReceivedString As String)
    End Interface

End Class
