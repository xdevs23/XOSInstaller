Namespace Localization

    Public Class Language

        Friend StringKeys, StringValues As String()
        Public LangName, LangLongName   As String

        Public Sub New(LocalName As String)
            LangName = LocalName
        End Sub

        Public Function GetValue(Key As String) As String
            For i As Integer = 0 To StringValues.Length - 1 Step 1
                If Key = StringKeys(i) Then Return StringValues(i)
            Next
            Return ""
        End Function

        Public Function GetKeyForValue(Value As String) As String
            For i As Integer = 0 To StringKeys.Length - 1 Step 1
                If Value = StringValues(i) Then Return StringKeys(i)
            Next
            Return ""
        End Function

        Public Overrides Function ToString() As String
            Return LangLongName & " (" & LangName.ToUpper() & ")"
        End Function

    End Class
        
End Namespace