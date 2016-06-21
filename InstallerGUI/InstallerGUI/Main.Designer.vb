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
        Me.PageWelcomePanel = New System.Windows.Forms.Panel()
        Me.LblWelcText = New System.Windows.Forms.Label()
        Me.BtnNext = New xdui.FlatButton()
        Me.BtnBack = New xdui.FlatButton()
        Me.BtnCancel = New xdui.FlatButton()
        Me.halogenOSTitlePanel = New System.Windows.Forms.Panel()
        Me.PageWelcomePanel.SuspendLayout
        Me.SuspendLayout
        '
        'PageWelcomePanel
        '
        Me.PageWelcomePanel.BackColor = System.Drawing.Color.Transparent
        Me.PageWelcomePanel.Controls.Add(Me.LblWelcText)
        Me.PageWelcomePanel.Location = New System.Drawing.Point(2, 95)
        Me.PageWelcomePanel.Name = "PageWelcomePanel"
        Me.PageWelcomePanel.Size = New System.Drawing.Size(800, 420)
        Me.PageWelcomePanel.TabIndex = 4
        Me.PageWelcomePanel.Tag = "0"
        Me.PageWelcomePanel.Visible = false
        '
        'LblWelcText
        '
        Me.LblWelcText.AutoSize = true
        Me.LblWelcText.Location = New System.Drawing.Point(10, 0)
        Me.LblWelcText.Name = "LblWelcText"
        Me.LblWelcText.Size = New System.Drawing.Size(67, 13)
        Me.LblWelcText.TabIndex = 0
        Me.LblWelcText.Tag = "page_welcome_welcometext"
        Me.LblWelcText.Text = "LblWelcText"
        '
        'BtnNext
        '
        Me.BtnNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.BtnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(30,Byte),Integer), CType(CType(139,Byte),Integer), CType(CType(229,Byte),Integer))
        Me.BtnNext.FlatAppearance.BorderSize = 0
        Me.BtnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128,Byte),Integer), CType(CType(30,Byte),Integer), CType(CType(139,Byte),Integer), CType(CType(229,Byte),Integer))
        Me.BtnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(30,Byte),Integer), CType(CType(139,Byte),Integer), CType(CType(229,Byte),Integer))
        Me.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNext.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.BtnNext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.BtnNext.Location = New System.Drawing.Point(717, 566)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(75, 23)
        Me.BtnNext.TabIndex = 5
        Me.BtnNext.Tag = "general_next"
        Me.BtnNext.Text = "Next"
        Me.BtnNext.UseVisualStyleBackColor = false
        '
        'BtnBack
        '
        Me.BtnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.BtnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(30,Byte),Integer), CType(CType(139,Byte),Integer), CType(CType(229,Byte),Integer))
        Me.BtnBack.FlatAppearance.BorderSize = 0
        Me.BtnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128,Byte),Integer), CType(CType(30,Byte),Integer), CType(CType(139,Byte),Integer), CType(CType(229,Byte),Integer))
        Me.BtnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(30,Byte),Integer), CType(CType(139,Byte),Integer), CType(CType(229,Byte),Integer))
        Me.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBack.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.BtnBack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.BtnBack.Location = New System.Drawing.Point(636, 566)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(75, 23)
        Me.BtnBack.TabIndex = 6
        Me.BtnBack.Tag = "general_back"
        Me.BtnBack.Text = "Back"
        Me.BtnBack.UseVisualStyleBackColor = false
        '
        'BtnCancel
        '
        Me.BtnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.BtnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(30,Byte),Integer), CType(CType(139,Byte),Integer), CType(CType(229,Byte),Integer))
        Me.BtnCancel.FlatAppearance.BorderSize = 0
        Me.BtnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128,Byte),Integer), CType(CType(30,Byte),Integer), CType(CType(139,Byte),Integer), CType(CType(229,Byte),Integer))
        Me.BtnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(30,Byte),Integer), CType(CType(139,Byte),Integer), CType(CType(229,Byte),Integer))
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.BtnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.BtnCancel.Location = New System.Drawing.Point(555, 566)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.TabIndex = 7
        Me.BtnCancel.Tag = "general_cancel"
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = false
        '
        'halogenOSTitlePanel
        '
        Me.halogenOSTitlePanel.BackColor = System.Drawing.Color.Transparent
        Me.halogenOSTitlePanel.BackgroundImage = Global.InstallerGUI.My.Resources.Resources.installer_title_xosi_final
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
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.PageWelcomePanel)
        Me.Controls.Add(Me.halogenOSTitlePanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
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
    Friend WithEvents BtnNext As xdui.FlatButton
    Friend WithEvents BtnBack As xdui.FlatButton
    Friend WithEvents BtnCancel As xdui.FlatButton
End Class
