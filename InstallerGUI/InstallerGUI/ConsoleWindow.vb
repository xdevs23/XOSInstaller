Imports System.Runtime.InteropServices

Public Class ConsoleWindow

    <DllImport("user32")> _
    Private Shared Sub HideCaret(ByVal hWnd As IntPtr)
    End Sub

    Private Shared PreEnteredConsoleText As String
    Private Shared ConsoleBoxStatic As TextBox

    Private Sub ConsoleWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main.LangManager.AutoApplyLanguage(Me)
        ConsoleBox.Text = "halogenOS Installer Console" & vbCrLf & _
            "Copyright (C) 2016 Simao Gomes Viana (xdevs23)" & vbCrLf & _
            "Copyright (C) 2016 halogenOS" & vbCrLf & vbCrLf & PreEnteredConsoleText
        ConsoleBoxStatic = ConsoleBox
    End Sub

    Private Sub ConsoleBox_TextChanged(sender As Object, e As EventArgs) Handles ConsoleBox.TextChanged, ConsoleBox.LostFocus
        ConsoleBox.SelectionLength = 0
        ConsoleBox.ScrollToCaret()
        HideCaret(ConsoleBox.Handle)
    End Sub

    Private Sub ConsoleBox_SelectionEnd(sender As Object, e As EventArgs) Handles ConsoleBox.Leave, ConsoleBox.MouseLeave
        HideCaret(ConsoleBox.Handle)
    End Sub

    Private Delegate Sub AppendTextBoxDelegate(ByVal TB As TextBox, ByVal txt As String)

    Private Shared Sub AppendTextBox(ByVal TB As TextBox, ByVal txt As String)
        If TB.InvokeRequired Then
            TB.Invoke(New AppendTextBoxDelegate(AddressOf AppendTextBox), New Object() {TB, txt})
        Else
            TB.AppendText(txt)
        End If
    End Sub

    Public Shared Sub WriteOut(Msg As String)
        If Not IsNothing(ConsoleBoxStatic) Then AppendTextBox(ConsoleBoxStatic, Msg) _
        Else : PreEnteredConsoleText &= Msg
    End Sub

End Class