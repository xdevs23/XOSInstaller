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
        Me.PageWelcomePanel = New System.Windows.Forms.Panel()
        Me.LblWelcText = New System.Windows.Forms.Label()
        Me.FlatButton1 = New xdui.FlatButton()
        Me.FlatButton2 = New xdui.FlatButton()
        Me.FlatButton3 = New xdui.FlatButton()
        Me.PageWelcomePanel.SuspendLayout
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
        'PageWelcomePanel
        '
        Me.PageWelcomePanel.BackColor = System.Drawing.Color.Transparent
        Me.PageWelcomePanel.Controls.Add(Me.LblWelcText)
        Me.PageWelcomePanel.Location = New System.Drawing.Point(2, 95)
        Me.PageWelcomePanel.Name = "PageWelcomePanel"
        Me.PageWelcomePanel.Size = New System.Drawing.Size(800, 420)
        Me.PageWelcomePanel.TabIndex = 4
        Me.PageWelcomePanel.Visible = false
        '
        'LblWelcText
        '
        Me.LblWelcText.AutoSize = true
        Me.LblWelcText.Location = New System.Drawing.Point(11, 4)
        Me.LblWelcText.Name = "LblWelcText"
        Me.LblWelcText.Size = New System.Drawing.Size(67, 13)
        Me.LblWelcText.TabIndex = 0
        Me.LblWelcText.Tag = "page_welcome_welcometext"
        Me.LblWelcText.Text = "LblWelcText"
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30,Byte),Integer), CType(CType(139,Byte),Integer), CType(CType(229,Byte),Integer))
        Me.FlatButton1.FlatAppearance.BorderSize = 0
        Me.FlatButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128,Byte),Integer), CType(CType(30,Byte),Integer), CType(CType(139,Byte),Integer), CType(CType(229,Byte),Integer))
        Me.FlatButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(30,Byte),Integer), CType(CType(139,Byte),Integer), CType(CType(229,Byte),Integer))
        Me.FlatButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.FlatButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.FlatButton1.Location = New System.Drawing.Point(717, 566)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Size = New System.Drawing.Size(75, 23)
        Me.FlatButton1.TabIndex = 5
        Me.FlatButton1.Tag = "general_next"
        Me.FlatButton1.Text = "Next"
        Me.FlatButton1.UseVisualStyleBackColor = false
        '
        'FlatButton2
        '
        Me.FlatButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30,Byte),Integer), CType(CType(139,Byte),Integer), CType(CType(229,Byte),Integer))
        Me.FlatButton2.FlatAppearance.BorderSize = 0
        Me.FlatButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128,Byte),Integer), CType(CType(30,Byte),Integer), CType(CType(139,Byte),Integer), CType(CType(229,Byte),Integer))
        Me.FlatButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(30,Byte),Integer), CType(CType(139,Byte),Integer), CType(CType(229,Byte),Integer))
        Me.FlatButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FlatButton2.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.FlatButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.FlatButton2.Location = New System.Drawing.Point(636, 566)
        Me.FlatButton2.Name = "FlatButton2"
        Me.FlatButton2.Size = New System.Drawing.Size(75, 23)
        Me.FlatButton2.TabIndex = 6
        Me.FlatButton2.Tag = "general_back"
        Me.FlatButton2.Text = "Back"
        Me.FlatButton2.UseVisualStyleBackColor = false
        '
        'FlatButton3
        '
        Me.FlatButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30,Byte),Integer), CType(CType(139,Byte),Integer), CType(CType(229,Byte),Integer))
        Me.FlatButton3.FlatAppearance.BorderSize = 0
        Me.FlatButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128,Byte),Integer), CType(CType(30,Byte),Integer), CType(CType(139,Byte),Integer), CType(CType(229,Byte),Integer))
        Me.FlatButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(30,Byte),Integer), CType(CType(139,Byte),Integer), CType(CType(229,Byte),Integer))
        Me.FlatButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FlatButton3.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.FlatButton3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.FlatButton3.Location = New System.Drawing.Point(555, 566)
        Me.FlatButton3.Name = "FlatButton3"
        Me.FlatButton3.Size = New System.Drawing.Size(75, 23)
        Me.FlatButton3.TabIndex = 7
        Me.FlatButton3.Tag = "general_cancel"
        Me.FlatButton3.Text = "Cancel"
        Me.FlatButton3.UseVisualStyleBackColor = false
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(804, 601)
        Me.Controls.Add(Me.FlatButton3)
        Me.Controls.Add(Me.FlatButton2)
        Me.Controls.Add(Me.FlatButton1)
        Me.Controls.Add(Me.PageWelcomePanel)
        Me.Controls.Add(Me.halogenOSTitlePanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "halogenOS"
        Me.PageWelcomePanel.ResumeLayout(false)
        Me.PageWelcomePanel.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents halogenOSTitlePanel As Panel
    Friend WithEvents PageWelcomePanel As Panel
    Friend WithEvents LblWelcText As Label
    Friend WithEvents FlatButton1 As xdui.FlatButton
    Friend WithEvents FlatButton2 As xdui.FlatButton
    Friend WithEvents FlatButton3 As xdui.FlatButton
End Class
