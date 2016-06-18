Imports System.Globalization
Imports System.Windows.Forms

Namespace Localization

    Public Class LanguageManager

        Public Loader As LanguageLoader

        Public Sub New()

        End Sub

        Public Sub ApplyLanguage(WantedForm As Form, LocalName As String)
            Loader = New LanguageLoader()
            Loader.LoadLanguages()
            Loader.SetDefaultLanguage(LocalName)
            WantedForm.Text = Loader.GetDefaultLanguage().GetValue("mainform_title")
            For Each C As Control In WantedForm.Controls
                If _
                    TypeOf (C) Is Button Or _
                    TypeOf (C) Is Label  Then
                    C.Text = Loader.GetDefaultLanguage().GetValue(C.Tag)
                End If
            Next
        End Sub

        Public Sub AutoApplyLanguage(WantedForm As Form)
            ApplyLanguage(WantedForm, CultureInfo.CurrentCulture.TwoLetterISOLanguageName)
        End Sub

    End Class

End Namespace