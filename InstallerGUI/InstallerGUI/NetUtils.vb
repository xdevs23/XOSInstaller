Namespace Net

    Public Class NetUtils

        Public Shared Function IsInternetAvailable() As Boolean
            Try
                Return My.Computer.Network.IsAvailable And My.Computer.Network.Ping("google.com")
            Catch ex As Exception
                Return False
            End Try
        End Function

    End Class

End Namespace
