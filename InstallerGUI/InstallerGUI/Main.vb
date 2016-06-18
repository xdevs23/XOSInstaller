Imports xdevs23.Localization

Public Class Main

    Private LangManager As LanguageManager

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LangManager = New LanguageManager()
        LangManager.AutoApplyLanguage(Me)
    End Sub

End Class
