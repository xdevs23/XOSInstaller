Public Class Console

    Public Shared Sub Write(Msg As String)
        ConsoleWindow.WriteOut(Msg)
    End Sub

    Public Shared Sub WriteLine(Msg As String)
        Write(Msg & vbCrLf)
    End Sub

    Public Sub SetOut(newOut As IO.TextWriter)
        System.Console.SetOut(newOut)
    End Sub

End Class
