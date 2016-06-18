Imports System.Drawing.Text
Imports System.IO
Imports xdevs23.Localization

Public Class Main

    Private LangManager As LanguageManager
    Private Roboto, RobotoCondensed As New PrivateFontCollection()

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load fonts
        For Each FontFile As String 
                In Directory.GetFiles("fonts/", "Roboto-*.ttf", SearchOption.AllDirectories)
            Roboto.AddFontFile(FontFile)
        Next
        For Each FontFile As String
                In Directory.GetFiles("fonts/", "RobotoCondensed-*.ttf", SearchOption.AllDirectories)
            RobotoCondensed.AddFontFile(FontFile)
        Next
        Font = New Font(Roboto.Families(0), 9.25, FontStyle.Regular)

        ' Load languages
        LangManager = New LanguageManager()
        LangManager.AutoApplyLanguage(Me)
    End Sub

End Class
