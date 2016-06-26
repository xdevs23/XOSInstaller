Imports System.ComponentModel
Imports System.Net
Imports System.Text

Public Class DownloadManager

    Public WithEvents DlWebClient As WebClient
    Public _
        CompletedListener As DownloadStatusListener.OnDownloadCompletedDelegate,
        ProgressChangeListener As DownloadStatusListener.OnProgressChangedDelegate,
        StringCompletedListener As DownloadStatusListener.OnDownloadStringCompletedDelegate

    Public Sub New()
        Console.WriteLine("Initializing a new download manager...")
        DlWebClient = New WebClient()
        DlWebClient.Encoding = Encoding.UTF8
        Console.WriteLine("Download manager initialized!")
    End Sub

    Private Sub DlWebClient_DownloadFileCompleted(sender As Object, e As AsyncCompletedEventArgs) Handles DlWebClient.DownloadFileCompleted
        If Not IsNothing(CompletedListener) Then CompletedListener.Invoke(IsNothing(e.Error), e.Error, e.Cancelled)
        CompletedListener = Nothing
    End Sub

    Private Sub DlWebClient_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles DlWebClient.DownloadProgressChanged
        If Not IsNothing(ProgressChangeListener) Then ProgressChangeListener.Invoke(e.ProgressPercentage, e.BytesReceived, e.TotalBytesToReceive)
    End Sub

    Private Sub DlWebClient_DownloadStringCompleted(sender As Object, e As DownloadStringCompletedEventArgs) Handles DlWebClient.DownloadStringCompleted
        If Not IsNothing(CompletedListener) Then CompletedListener.Invoke(IsNothing(e.Error), e.Error, e.Cancelled)
        If Not IsNothing(StringCompletedListener) Then StringCompletedListener.Invoke(e.Result)
        CompletedListener = Nothing
        StringCompletedListener = Nothing
    End Sub

    Public Function DownloadFile(Url As String, Filename As String,
                                 Optional OnCompletedListener As DownloadStatusListener.OnDownloadCompletedDelegate = Nothing,
                                 Optional OnProgressChangeListener As DownloadStatusListener.OnProgressChangedDelegate = Nothing) As Boolean
        Console.WriteLine("Starting download of """ & Url & """ to """ & Filename & """")
        CompletedListener = OnCompletedListener
        OnProgressChangeListener = OnProgressChangeListener
        Try
            DlWebClient.DownloadFileAsync(New Uri(Url), FileName)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function DownloadString(Url As String, 
                                            OnReceiveListener As DownloadStatusListener.OnDownloadStringCompletedDelegate,
                                   Optional OnProgressChangeListener As DownloadStatusListener.OnProgressChangedDelegate = Nothing,
                                   Optional OnCompletedListener As DownloadStatusListener.OnDownloadCompletedDelegate = Nothing) As Boolean
        Console.WriteLine("Starting download of """ & Url & """")
        StringCompletedListener = OnReceiveListener
        ProgressChangeListener  = OnProgressChangeListener
        CompletedListener       = OnCompletedListener
        Try
            DlWebClient.DownloadStringAsync(New Uri(Url))
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Class DownloadStatusListener
        Public Delegate Sub OnDownloadCompletedDelegate(Success As Boolean, Ex As Exception, WasCancelled As Boolean)
        Public Delegate Sub OnProgressChangedDelegate(Progress As Integer, BytesReceived As Long, BytesToReceive As Long)
        Public Delegate Sub OnDownloadStringCompletedDelegate(ReceivedString As String)
    End Class

End Class
