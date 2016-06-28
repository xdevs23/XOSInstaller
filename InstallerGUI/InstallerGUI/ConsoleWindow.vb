Imports System.Runtime.InteropServices

Public Class ConsoleWindow

    <DllImport("user32")> _
    Private Shared Sub HideCaret(ByVal hWnd As IntPtr)
    End Sub

    Private Shared Sub HideCaret(ByRef TB As TextBox)
        If Not My.Computer.Info.OSPlatform.Contains("unix") Then _
            HideCaret(TB.Handle)
    End Sub

    Private Shared PreEnteredConsoleText As String
    Private Shared ConsoleBoxStatic As TextBox

    ' The stuff to print in console before anything else
    Private ReadOnly ConsolePrePrint As String() = {
        "halogenOS Installer Console",
        "Copyright (C) 2016 Simao Gomes Viana (xdevs23)",
        "Copyright (C) 2016 halogenOS",
        "Licensed under the GPLv3 license, for more information,",
        "visit https://github.com/xdevs23/XOSInstaller/tree/XOS-6.0/LICENSE",
        "This program comes with ABSOLUTELY NO WARRANTY.",
        "This is free software, and you are welcome to redistribute it under certain conditions.",
        ""
    }

    Private Sub ConsoleWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main.LangManager.AutoApplyLanguage(Me)
        Dim FinalPrePrint As String = ""
        For Each S As String In ConsolePrePrint
            FinalPrePrint &= S & vbCrLf
        Next
        ConsoleBox.Text = FinalPrePrint & PreEnteredConsoleText
        ConsoleBoxStatic = ConsoleBox
    End Sub

    Private Sub ConsoleBox_TextChanged(sender As Object, e As EventArgs) Handles ConsoleBox.TextChanged, ConsoleBox.LostFocus
        ConsoleBox.SelectionLength = 0
        ConsoleBox.ScrollToCaret()
        HideCaret(ConsoleBox)
    End Sub

    Private Sub ConsoleBox_SelectionEnd(sender As Object, e As EventArgs) Handles ConsoleBox.Leave, ConsoleBox.MouseLeave
        HideCaret(ConsoleBox)
    End Sub

    Private Delegate Sub AppendTextBoxDelegate(ByVal TB As TextBox, ByVal txt As String)

    Private Shared Sub AppendTextBox(ByVal TB As TextBox, ByVal txt As String)
        On Error Resume Next
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