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
            RefreshLanguage(WantedForm)
        End Sub

        Public Sub RefreshLanguage(Cl As Control)
            For Each C As Control In Cl.Controls
                If _
                    TypeOf (C) Is Button Or _
                    TypeOf (C) Is Label  Then
                    If IsNothing(C.Tag.ToString()) OrElse C.Tag.Equals("") Then Continue For
                    Dim t As String = Loader.GetDefaultLanguage().GetValue(C.Tag.ToString())
                    If t.Equals("") Then t = Loader.GetLanguage("en").GetValue(C.Tag.ToString())
                    If t.Equals("") Then Continue For
                    C.Text = t
                ElseIf TypeOf (C) Is Panel Then
                    RefreshLanguage(C)
                End If
            Next
        End Sub

        Public Sub AutoApplyLanguage(WantedForm As Form)
            ApplyLanguage(WantedForm, CultureInfo.CurrentCulture.TwoLetterISOLanguageName)
        End Sub

        Public Function GetString(Key As String) As String
            Dim s As String = Loader.GetDefaultLanguage().GetValue(Key)
            Return IIf(s.Equals(""), Loader.GetLanguage("en").GetValue(Key), s).ToString()
        End Function

    End Class

End Namespace