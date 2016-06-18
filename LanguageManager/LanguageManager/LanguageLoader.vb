Imports System.IO
Imports xdlib.Managing.Configuration.Filesystem

Namespace Localization

    Public Class LanguageLoader

        Public Shared ReadOnly _
            LangExtension As String = "*.lang",
            LangFolder    As String =   "lang/",
            KeyLangName   As String = "lang_name",
            KeyLangLocale As String = "lang_locale"     

        Friend Languages As New List(Of Language)
    
        Private DefaultLang As Integer = 0

        Public Sub New()

        End Sub

        Public Sub LoadLanguages()
            For Each File As String
                In Directory.GetFiles(LangFolder, LangExtension, SearchOption.AllDirectories)
                Debug.WriteLine("Debug: Loading language file " & File)
                Dim langFile As ConfigFile = Utils.ReadConfigFile(File)
                Dim lang As New Language(langFile.GetValue(KeyLangLocale))
                lang.LangLongName = langFile.GetValue(KeyLangName)
                lang.StringKeys   = langFile.GetAllKeys()
                lang.StringValues = langFile.GetAllValues()
                Languages.Add(lang)
            Next
            If Languages.Count <= 0 Then Debug.WriteLine("Warning: No language files found!")
        End Sub

        Public Function GetLanguages() As List(Of Language)
            Return Languages
        End Function

        Public Function GetLanguage(LocalName As String) As Language
            For Each Lang As Language In Languages
                If Lang.LangName.ToLower() = LocalName.ToLower() Then Return Lang
            Next
            Return Nothing
        End Function

        Public Function SetDefaultLanguage(LocalName As String) As Language
            For Each Lang As Language In Languages
                If Lang.LangName.ToLower() = LocalName.ToLower() Then
                    DefaultLang = Languages.IndexOf(Lang)
                    Return Lang
                End If
            Next
            DefaultLang = 0
            Return Nothing
        End Function

        Public Function GetDefaultLanguage() As Language
            Return Languages(DefaultLang)
        End Function

    End Class
        
End Namespace