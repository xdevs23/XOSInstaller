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
        Me.halogenOSTitlePanel = New System.Windows.Forms.Panel()
        Me.PageDetectDevicePanel = New System.Windows.Forms.Panel()
        Me.LblDetectingDevice = New System.Windows.Forms.Label()
        Me.CbxLanguageCh = New System.Windows.Forms.ComboBox()
        Me.PageCheckInetPanel = New System.Windows.Forms.Panel()
        Me.BtnRetryInet = New xdui.FlatButton()
        Me.LblCheckInet = New System.Windows.Forms.Label()
        Me.PageDlStuffPanel = New System.Windows.Forms.Panel()
        Me.LblDlStuffTotal = New System.Windows.Forms.Label()
        Me.PrgDlStuffTotal = New xdui.FlatProgressBar()
        Me.PrgDlStuff = New xdui.FlatProgressBar()
        Me.LblDlStuffStatus = New System.Windows.Forms.Label()
        Me.BtnShowConsole = New xdui.FlatButton()
        Me.BtnCancel = New xdui.FlatButton()
        Me.BtnBack = New xdui.FlatButton()
        Me.BtnNext = New xdui.FlatButton()
        Me.PanelDownloadStuff = New System.Windows.Forms.Panel()
        Me.BtnRetryDlStuff = New xdui.FlatButton()
        Me.LblDeviceNotSupported = New System.Windows.Forms.Label()
        Me.LblDlStuffStatusPrg = New System.Windows.Forms.Label()
        Me.LblDlStuffTotalPrg = New System.Windows.Forms.Label()
        Me.PageWelcomePanel.SuspendLayout
        Me.PageDetectDevicePanel.SuspendLayout
        Me.PageCheckInetPanel.SuspendLayout
        Me.PageDlStuffPanel.SuspendLayout
        Me.PanelDownloadStuff.SuspendLayout
        Me.SuspendLayout
        '
        'PageWelcomePanel
        '
        Me.PageWelcomePanel.BackColor = System.Drawing.Color.Transparent
        Me.PageWelcomePanel.Controls.Add(Me.LblWelcText)
        Me.PageWelcomePanel.Location = New System.Drawing.Point(2, 95)
        Me.PageWelcomePanel.Name = "PageWelcomePanel"
        Me.PageWelcomePanel.Size = New System.Drawing.Size(79, 52)
        Me.PageWelcomePanel.TabIndex = 4
        Me.PageWelcomePanel.Tag = "0"
        Me.PageWelcomePanel.Visible = false
        '
        'LblWelcText
        '
        Me.LblWelcText.AutoSize = true
        Me.LblWelcText.Location = New System.Drawing.Point(3, 4)
        Me.LblWelcText.Name = "LblWelcText"
        Me.LblWelcText.Size = New System.Drawing.Size(67, 13)
        Me.LblWelcText.TabIndex = 0
        Me.LblWelcText.Tag = "page_welcome_welcometext"
        Me.LblWelcText.Text = "LblWelcText"
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
        'PageDetectDevicePanel
        '
        Me.PageDetectDevicePanel.Controls.Add(Me.LblDetectingDevice)
        Me.PageDetectDevicePanel.Location = New System.Drawing.Point(87, 95)
        Me.PageDetectDevicePanel.Name = "PageDetectDevicePanel"
        Me.PageDetectDevicePanel.Size = New System.Drawing.Size(109, 52)
        Me.PageDetectDevicePanel.TabIndex = 8
        Me.PageDetectDevicePanel.Tag = "1"
        Me.PageDetectDevicePanel.Visible = false
        '
        'LblDetectingDevice
        '
        Me.LblDetectingDevice.AutoSize = true
        Me.LblDetectingDevice.Location = New System.Drawing.Point(4, 4)
        Me.LblDetectingDevice.Name = "LblDetectingDevice"
        Me.LblDetectingDevice.Size = New System.Drawing.Size(101, 13)
        Me.LblDetectingDevice.TabIndex = 0
        Me.LblDetectingDevice.Tag = "page_detect_detecting_device"
        Me.LblDetectingDevice.Text = "LblDetectingDevice"
        '
        'CbxLanguageCh
        '
        Me.CbxLanguageCh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.CbxLanguageCh.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.CbxLanguageCh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxLanguageCh.DropDownWidth = 128
        Me.CbxLanguageCh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CbxLanguageCh.FormattingEnabled = true
        Me.CbxLanguageCh.Location = New System.Drawing.Point(566, 12)
        Me.CbxLanguageCh.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CbxLanguageCh.MaxDropDownItems = 100
        Me.CbxLanguageCh.Name = "CbxLanguageCh"
        Me.CbxLanguageCh.Size = New System.Drawing.Size(121, 21)
        Me.CbxLanguageCh.TabIndex = 10
        '
        'PageCheckInetPanel
        '
        Me.PageCheckInetPanel.Controls.Add(Me.BtnRetryInet)
        Me.PageCheckInetPanel.Controls.Add(Me.LblCheckInet)
        Me.PageCheckInetPanel.Location = New System.Drawing.Point(203, 95)
        Me.PageCheckInetPanel.Name = "PageCheckInetPanel"
        Me.PageCheckInetPanel.Size = New System.Drawing.Size(85, 52)
        Me.PageCheckInetPanel.TabIndex = 11
        Me.PageCheckInetPanel.Tag = "2"
        Me.PageCheckInetPanel.Visible = false
        '
        'BtnRetryInet
        '
        Me.BtnRetryInet.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.BtnRetryInet.BackColor = System.Drawing.Color.FromArgb(CType(CType(30,Byte),Integer), CType(CType(139,Byte),Integer), CType(CType(229,Byte),Integer))
        Me.BtnRetryInet.FlatAppearance.BorderSize = 0
        Me.BtnRetryInet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128,Byte),Integer), CType(CType(30,Byte),Integer), CType(CType(139,Byte),Integer), CType(CType(229,Byte),Integer))
        Me.BtnRetryInet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(30,Byte),Integer), CType(CType(139,Byte),Integer), CType(CType(229,Byte),Integer))
        Me.BtnRetryInet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRetryInet.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.BtnRetryInet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.BtnRetryInet.Location = New System.Drawing.Point(3, 26)
        Me.BtnRetryInet.Name = "BtnRetryInet"
        Me.BtnRetryInet.Size = New System.Drawing.Size(75, 23)
        Me.BtnRetryInet.TabIndex = 1
        Me.BtnRetryInet.Tag = "general_retry"
        Me.BtnRetryInet.Text = "Retry"
        Me.BtnRetryInet.UseVisualStyleBackColor = false
        '
        'LblCheckInet
        '
        Me.LblCheckInet.AutoSize = true
        Me.LblCheckInet.Location = New System.Drawing.Point(4, 4)
        Me.LblCheckInet.Name = "LblCheckInet"
        Me.LblCheckInet.Size = New System.Drawing.Size(70, 13)
        Me.LblCheckInet.TabIndex = 0
        Me.LblCheckInet.Tag = "page_checkinet_checkinet"
        Me.LblCheckInet.Text = "LblCheckInet"
        '
        'PageDlStuffPanel
        '
        Me.PageDlStuffPanel.Controls.Add(Me.LblDeviceNotSupported)
        Me.PageDlStuffPanel.Controls.Add(Me.BtnRetryDlStuff)
        Me.PageDlStuffPanel.Controls.Add(Me.PanelDownloadStuff)
        Me.PageDlStuffPanel.Location = New System.Drawing.Point(295, 95)
        Me.PageDlStuffPanel.Name = "PageDlStuffPanel"
        Me.PageDlStuffPanel.Size = New System.Drawing.Size(497, 465)
        Me.PageDlStuffPanel.TabIndex = 12
        Me.PageDlStuffPanel.Tag = "3"
        Me.PageDlStuffPanel.Visible = false
        '
        'LblDlStuffTotal
        '
        Me.LblDlStuffTotal.AutoSize = true
        Me.LblDlStuffTotal.Location = New System.Drawing.Point(3, 45)
        Me.LblDlStuffTotal.Name = "LblDlStuffTotal"
        Me.LblDlStuffTotal.Size = New System.Drawing.Size(74, 13)
        Me.LblDlStuffTotal.TabIndex = 3
        Me.LblDlStuffTotal.Tag = "page_dlstuff_total"
        Me.LblDlStuffTotal.Text = "Total progress"
        '
        'PrgDlStuffTotal
        '
        Me.PrgDlStuffTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PrgDlStuffTotal.BackColor = System.Drawing.Color.Transparent
        Me.PrgDlStuffTotal.Location = New System.Drawing.Point(6, 61)
        Me.PrgDlStuffTotal.Name = "PrgDlStuffTotal"
        Me.PrgDlStuffTotal.Size = New System.Drawing.Size(482, 14)
        Me.PrgDlStuffTotal.TabIndex = 2
        '
        'PrgDlStuff
        '
        Me.PrgDlStuff.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PrgDlStuff.BackColor = System.Drawing.Color.Transparent
        Me.PrgDlStuff.Location = New System.Drawing.Point(6, 17)
        Me.PrgDlStuff.Name = "PrgDlStuff"
        Me.PrgDlStuff.Size = New System.Drawing.Size(482, 14)
        Me.PrgDlStuff.TabIndex = 1
        '
        'LblDlStuffStatus
        '
        Me.LblDlStuffStatus.AutoSize = true
        Me.LblDlStuffStatus.Location = New System.Drawing.Point(3, 0)
        Me.LblDlStuffStatus.Name = "LblDlStuffStatus"
        Me.LblDlStuffStatus.Size = New System.Drawing.Size(78, 13)
        Me.LblDlStuffStatus.TabIndex = 0
        Me.LblDlStuffStatus.Tag = "page_dlstuff_downloading"
        Me.LblDlStuffStatus.Text = "Downloading..."
        '
        'BtnShowConsole
        '
        Me.BtnShowConsole.BackColor = System.Drawing.Color.FromArgb(CType(CType(30,Byte),Integer), CType(CType(139,Byte),Integer), CType(CType(229,Byte),Integer))
        Me.BtnShowConsole.FlatAppearance.BorderSize = 0
        Me.BtnShowConsole.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128,Byte),Integer), CType(CType(30,Byte),Integer), CType(CType(139,Byte),Integer), CType(CType(229,Byte),Integer))
        Me.BtnShowConsole.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(30,Byte),Integer), CType(CType(139,Byte),Integer), CType(CType(229,Byte),Integer))
        Me.BtnShowConsole.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnShowConsole.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.BtnShowConsole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.BtnShowConsole.Location = New System.Drawing.Point(693, 12)
        Me.BtnShowConsole.Name = "BtnShowConsole"
        Me.BtnShowConsole.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnShowConsole.Size = New System.Drawing.Size(99, 23)
        Me.BtnShowConsole.TabIndex = 9
        Me.BtnShowConsole.Tag = "mainform_showconsole"
        Me.BtnShowConsole.Text = "Console"
        Me.BtnShowConsole.UseVisualStyleBackColor = false
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
        'PanelDownloadStuff
        '
        Me.PanelDownloadStuff.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PanelDownloadStuff.BackColor = System.Drawing.Color.Transparent
        Me.PanelDownloadStuff.Controls.Add(Me.LblDlStuffTotalPrg)
        Me.PanelDownloadStuff.Controls.Add(Me.LblDlStuffStatusPrg)
        Me.PanelDownloadStuff.Controls.Add(Me.LblDlStuffStatus)
        Me.PanelDownloadStuff.Controls.Add(Me.LblDlStuffTotal)
        Me.PanelDownloadStuff.Controls.Add(Me.PrgDlStuff)
        Me.PanelDownloadStuff.Controls.Add(Me.PrgDlStuffTotal)
        Me.PanelDownloadStuff.Location = New System.Drawing.Point(3, 75)
        Me.PanelDownloadStuff.Name = "PanelDownloadStuff"
        Me.PanelDownloadStuff.Size = New System.Drawing.Size(491, 100)
        Me.PanelDownloadStuff.TabIndex = 4
        '
        'BtnRetryDlStuff
        '
        Me.BtnRetryDlStuff.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.BtnRetryDlStuff.BackColor = System.Drawing.Color.FromArgb(CType(CType(30,Byte),Integer), CType(CType(139,Byte),Integer), CType(CType(229,Byte),Integer))
        Me.BtnRetryDlStuff.FlatAppearance.BorderSize = 0
        Me.BtnRetryDlStuff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128,Byte),Integer), CType(CType(30,Byte),Integer), CType(CType(139,Byte),Integer), CType(CType(229,Byte),Integer))
        Me.BtnRetryDlStuff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(30,Byte),Integer), CType(CType(139,Byte),Integer), CType(CType(229,Byte),Integer))
        Me.BtnRetryDlStuff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRetryDlStuff.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.BtnRetryDlStuff.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.BtnRetryDlStuff.Location = New System.Drawing.Point(3, 439)
        Me.BtnRetryDlStuff.Name = "BtnRetryDlStuff"
        Me.BtnRetryDlStuff.Size = New System.Drawing.Size(75, 23)
        Me.BtnRetryDlStuff.TabIndex = 5
        Me.BtnRetryDlStuff.Tag = "general_retry"
        Me.BtnRetryDlStuff.Text = "Retry"
        Me.BtnRetryDlStuff.UseVisualStyleBackColor = false
        Me.BtnRetryDlStuff.Visible = false
        '
        'LblDeviceNotSupported
        '
        Me.LblDeviceNotSupported.AutoSize = true
        Me.LblDeviceNotSupported.Location = New System.Drawing.Point(9, 26)
        Me.LblDeviceNotSupported.Name = "LblDeviceNotSupported"
        Me.LblDeviceNotSupported.Size = New System.Drawing.Size(109, 13)
        Me.LblDeviceNotSupported.TabIndex = 6
        Me.LblDeviceNotSupported.Tag = "page_dlstuff_device_not_supported"
        Me.LblDeviceNotSupported.Text = "Device not supported"
        Me.LblDeviceNotSupported.Visible = false
        '
        'LblDlStuffStatusPrg
        '
        Me.LblDlStuffStatusPrg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.LblDlStuffStatusPrg.AutoSize = true
        Me.LblDlStuffStatusPrg.Location = New System.Drawing.Point(452, 1)
        Me.LblDlStuffStatusPrg.Name = "LblDlStuffStatusPrg"
        Me.LblDlStuffStatusPrg.Size = New System.Drawing.Size(36, 13)
        Me.LblDlStuffStatusPrg.TabIndex = 4
        Me.LblDlStuffStatusPrg.Text = "100 %"
        Me.LblDlStuffStatusPrg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDlStuffTotalPrg
        '
        Me.LblDlStuffTotalPrg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.LblDlStuffTotalPrg.AutoSize = true
        Me.LblDlStuffTotalPrg.Location = New System.Drawing.Point(452, 45)
        Me.LblDlStuffTotalPrg.Name = "LblDlStuffTotalPrg"
        Me.LblDlStuffTotalPrg.Size = New System.Drawing.Size(36, 13)
        Me.LblDlStuffTotalPrg.TabIndex = 5
        Me.LblDlStuffTotalPrg.Text = "100 %"
        Me.LblDlStuffTotalPrg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(804, 601)
        Me.Controls.Add(Me.PageDlStuffPanel)
        Me.Controls.Add(Me.PageCheckInetPanel)
        Me.Controls.Add(Me.CbxLanguageCh)
        Me.Controls.Add(Me.BtnShowConsole)
        Me.Controls.Add(Me.PageDetectDevicePanel)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.PageWelcomePanel)
        Me.Controls.Add(Me.halogenOSTitlePanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = false
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "mainform_title"
        Me.Text = "halogenOS"
        Me.PageWelcomePanel.ResumeLayout(false)
        Me.PageWelcomePanel.PerformLayout
        Me.PageDetectDevicePanel.ResumeLayout(false)
        Me.PageDetectDevicePanel.PerformLayout
        Me.PageCheckInetPanel.ResumeLayout(false)
        Me.PageCheckInetPanel.PerformLayout
        Me.PageDlStuffPanel.ResumeLayout(false)
        Me.PageDlStuffPanel.PerformLayout
        Me.PanelDownloadStuff.ResumeLayout(false)
        Me.PanelDownloadStuff.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents halogenOSTitlePanel As Panel
    Friend WithEvents PageWelcomePanel As Panel
    Friend WithEvents LblWelcText As Label
    Friend WithEvents BtnNext As xdui.FlatButton
    Friend WithEvents BtnBack As xdui.FlatButton
    Friend WithEvents BtnCancel As xdui.FlatButton
    Friend WithEvents PageDetectDevicePanel As Panel
    Friend WithEvents LblDetectingDevice As Label
    Friend WithEvents BtnShowConsole As xdui.FlatButton
    Friend WithEvents CbxLanguageCh As ComboBox
    Friend WithEvents PageCheckInetPanel As Panel
    Friend WithEvents LblCheckInet As Label
    Friend WithEvents BtnRetryInet As xdui.FlatButton
    Friend WithEvents PageDlStuffPanel As Panel
    Friend WithEvents LblDlStuffStatus As Label
    Friend WithEvents PrgDlStuff As xdui.FlatProgressBar
    Friend WithEvents LblDlStuffTotal As Label
    Friend WithEvents PrgDlStuffTotal As xdui.FlatProgressBar
    Friend WithEvents BtnRetryDlStuff As xdui.FlatButton
    Friend WithEvents PanelDownloadStuff As Panel
    Friend WithEvents LblDeviceNotSupported As Label
    Friend WithEvents LblDlStuffTotalPrg As Label
    Friend WithEvents LblDlStuffStatusPrg As Label
End Class
