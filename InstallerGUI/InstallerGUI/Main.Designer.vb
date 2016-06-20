<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.halogenOSTitlePanel = New System.Windows.Forms.Panel()
        Me.SuspendLayout
        '
        'halogenOSTitlePanel
        '
        Me.halogenOSTitlePanel.BackColor = System.Drawing.Color.Transparent
        Me.halogenOSTitlePanel.BackgroundImage = CType(resources.GetObject("halogenOSTitlePanel.BackgroundImage"),System.Drawing.Image)
        Me.halogenOSTitlePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.halogenOSTitlePanel.Location = New System.Drawing.Point(2, 2)
        Me.halogenOSTitlePanel.Name = "halogenOSTitlePanel"
        Me.halogenOSTitlePanel.Size = New System.Drawing.Size(420, 86)
        Me.halogenOSTitlePanel.TabIndex = 3
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(804, 601)
        Me.Controls.Add(Me.halogenOSTitlePanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.Name = "Main"
        Me.Text = "halogenOS"
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents halogenOSTitlePanel As Panel
End Class
