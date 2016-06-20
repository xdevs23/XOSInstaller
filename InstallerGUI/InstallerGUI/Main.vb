Imports System.Drawing.Text
Imports System.IO
Imports xdevs23.Localization

Public Class Main

    Private LangManager As LanguageManager
    Private RobotoCondensed, RobotoLight, RobotoThin As PrivateFontCollection

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load fonts
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

        ' Load languages
        LangManager = New LanguageManager()
        LangManager.AutoApplyLanguage(Me)

        ' Prepare the form
        Size = New Size(820, 640)
        For Each C As Control In Controls
            If TypeOf(C) Is Panel AndAlso C.Name.Contains("Page") Then
                C.Size = New Size(800, 420) ' Have the same size for all panels
            End If
        Next

        ' Prepare the first panel
        PageWelcomePanel.Visible = True
    End Sub

End Class
