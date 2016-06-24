Imports System.Globalization
Imports Microsoft.VisualBasic.ApplicationServices
Imports xdevs23.Localization

Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        Private Sub MyApplication_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs) Handles Me.UnhandledException
            Dim lm As LanguageManager
            lm = New LanguageManager()
            lm.Loader = New LanguageLoader()
            lm.Loader.LoadLanguages()
            lm.Loader.SetDefaultLanguage(CultureInfo.CurrentCulture.TwoLetterISOLanguageName)
            Try
                EmergencyForm.Show()
                InstallerGUI.Main.Close()
                Console.WriteLine(vbCrLf & "Unhandled exception occured: " & e.Exception.Message & vbCrLf _
                                  & e.Exception.StackTrace)

                Dim result As DialogResult = MessageBox.Show(lm.GetString("unhandled_exception_message"),
                                                             lm.GetString("unhandled_exception_title"),
                                                             MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error)
               
                e.ExitApplication = (result = DialogResult.Cancel)
                If result = DialogResult.Yes Then ConsoleWindow.Show()
            Catch Ex As Exception
                Console.WriteLine("An exception occured while handling an unhandled exception: " & Ex.Message & vbCrLf &
                                  Ex.StackTrace)
                e.ExitApplication = False
            End Try
            If e.ExitApplication Then
                InstallerGUI.Main.Main_FormClosed(sender, Nothing)
            Else
                InstallerGUI.Main.Show()
                EmergencyForm.Close()
                MessageBox.Show(lm.GetString("mainform_resumed_from_ex"), "", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Sub
    End Class
End Namespace
