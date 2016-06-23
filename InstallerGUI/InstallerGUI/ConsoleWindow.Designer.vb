<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsoleWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ConsoleBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout
        '
        'ConsoleBox
        '
        Me.ConsoleBox.BackColor = System.Drawing.Color.Black
        Me.ConsoleBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ConsoleBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ConsoleBox.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.ConsoleBox.Location = New System.Drawing.Point(0, 0)
        Me.ConsoleBox.Multiline = true
        Me.ConsoleBox.Name = "ConsoleBox"
        Me.ConsoleBox.ReadOnly = true
        Me.ConsoleBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ConsoleBox.Size = New System.Drawing.Size(728, 509)
        Me.ConsoleBox.TabIndex = 0
        Me.ConsoleBox.TabStop = false
        Me.ConsoleBox.WordWrap = false
        '
        'ConsoleWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 15!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(728, 509)
        Me.Controls.Add(Me.ConsoleBox)
        Me.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Name = "ConsoleWindow"
        Me.Tag = "conwin_title"
        Me.Text = "ConsoleWindow"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents ConsoleBox As TextBox
End Class
