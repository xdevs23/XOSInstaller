﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.LblDeviceNotSupported = New System.Windows.Forms.Label()
        Me.BtnRetryDlStuff = New xdui.FlatButton()
        Me.PanelDownloadStuff = New System.Windows.Forms.Panel()
        Me.LblDlStuffTotalPrg = New System.Windows.Forms.Label()
        Me.LblDlStuffStatusPrg = New System.Windows.Forms.Label()
        Me.LblDlStuffStatus = New System.Windows.Forms.Label()
        Me.LblDlStuffTotal = New System.Windows.Forms.Label()
        Me.PrgDlStuff = New xdui.FlatProgressBar()
        Me.PrgDlStuffTotal = New xdui.FlatProgressBar()
        Me.PageDlRomPanel = New System.Windows.Forms.Panel()
        Me.BtnRetryDlRom = New xdui.FlatButton()
        Me.PanelDlRomPrg = New System.Windows.Forms.Panel()
        Me.LblDlRomStatusBPrg = New System.Windows.Forms.Label()
        Me.LblDlRomTotalPrg = New System.Windows.Forms.Label()
        Me.LblDlRomStatusPrg = New System.Windows.Forms.Label()
        Me.LblDlRomStatus = New System.Windows.Forms.Label()
        Me.LblDlRomTotal = New System.Windows.Forms.Label()
        Me.PrgDlRomStatus = New xdui.FlatProgressBar()
        Me.PrgDlRomTotal = New xdui.FlatProgressBar()
        Me.PagePreInstallPanel = New System.Windows.Forms.Panel()
        Me.ChkPreInstallAgree = New System.Windows.Forms.CheckBox()
        Me.LblPreInstallNotice = New System.Windows.Forms.Label()
        Me.PageInstallPanel = New System.Windows.Forms.Panel()
        Me.PrgIInstallXOS = New xdui.FlatProgressBar()
        Me.LblInstallInstallingXOS = New System.Windows.Forms.Label()
        Me.LblInstallNotice = New System.Windows.Forms.Label()
        Me.BtnShowConsole = New xdui.FlatButton()
        Me.BtnCancel = New xdui.FlatButton()
        Me.BtnBack = New xdui.FlatButton()
        Me.BtnNext = New xdui.FlatButton()
        Me.PageFinishedPanel = New System.Windows.Forms.Panel()
        Me.LblInstallSucceeded = New System.Windows.Forms.Label()
        Me.LblInstallFailed = New System.Windows.Forms.Label()
        Me.ChkRebootDevice = New System.Windows.Forms.CheckBox()
        Me.PageWelcomePanel.SuspendLayout
        Me.PageDetectDevicePanel.SuspendLayout
        Me.PageCheckInetPanel.SuspendLayout
        Me.PageDlStuffPanel.SuspendLayout
        Me.PanelDownloadStuff.SuspendLayout
        Me.PageDlRomPanel.SuspendLayout
        Me.PanelDlRomPrg.SuspendLayout
        Me.PagePreInstallPanel.SuspendLayout
        Me.PageInstallPanel.SuspendLayout
        Me.PageFinishedPanel.SuspendLayout
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
        Me.PageDlStuffPanel.Location = New System.Drawing.Point(294, 95)
        Me.PageDlStuffPanel.Name = "PageDlStuffPanel"
        Me.PageDlStuffPanel.Size = New System.Drawing.Size(86, 52)
        Me.PageDlStuffPanel.TabIndex = 12
        Me.PageDlStuffPanel.Tag = "3"
        Me.PageDlStuffPanel.Visible = false
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
        Me.BtnRetryDlStuff.Location = New System.Drawing.Point(3, 26)
        Me.BtnRetryDlStuff.Name = "BtnRetryDlStuff"
        Me.BtnRetryDlStuff.Size = New System.Drawing.Size(75, 23)
        Me.BtnRetryDlStuff.TabIndex = 5
        Me.BtnRetryDlStuff.Tag = "general_retry"
        Me.BtnRetryDlStuff.Text = "Retry"
        Me.BtnRetryDlStuff.UseVisualStyleBackColor = false
        Me.BtnRetryDlStuff.Visible = false
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
        Me.PanelDownloadStuff.Size = New System.Drawing.Size(80, 100)
        Me.PanelDownloadStuff.TabIndex = 4
        '
        'LblDlStuffTotalPrg
        '
        Me.LblDlStuffTotalPrg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.LblDlStuffTotalPrg.AutoSize = true
        Me.LblDlStuffTotalPrg.Location = New System.Drawing.Point(41, 45)
        Me.LblDlStuffTotalPrg.Name = "LblDlStuffTotalPrg"
        Me.LblDlStuffTotalPrg.Size = New System.Drawing.Size(36, 13)
        Me.LblDlStuffTotalPrg.TabIndex = 5
        Me.LblDlStuffTotalPrg.Text = "100 %"
        Me.LblDlStuffTotalPrg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDlStuffStatusPrg
        '
        Me.LblDlStuffStatusPrg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.LblDlStuffStatusPrg.AutoSize = true
        Me.LblDlStuffStatusPrg.Location = New System.Drawing.Point(41, 1)
        Me.LblDlStuffStatusPrg.Name = "LblDlStuffStatusPrg"
        Me.LblDlStuffStatusPrg.Size = New System.Drawing.Size(36, 13)
        Me.LblDlStuffStatusPrg.TabIndex = 4
        Me.LblDlStuffStatusPrg.Text = "100 %"
        Me.LblDlStuffStatusPrg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'PrgDlStuff
        '
        Me.PrgDlStuff.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PrgDlStuff.BackColor = System.Drawing.Color.Transparent
        Me.PrgDlStuff.IsIntermediate = false
        Me.PrgDlStuff.Location = New System.Drawing.Point(6, 17)
        Me.PrgDlStuff.Name = "PrgDlStuff"
        Me.PrgDlStuff.Size = New System.Drawing.Size(71, 14)
        Me.PrgDlStuff.TabIndex = 1
        '
        'PrgDlStuffTotal
        '
        Me.PrgDlStuffTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PrgDlStuffTotal.BackColor = System.Drawing.Color.Transparent
        Me.PrgDlStuffTotal.IsIntermediate = false
        Me.PrgDlStuffTotal.Location = New System.Drawing.Point(6, 61)
        Me.PrgDlStuffTotal.Name = "PrgDlStuffTotal"
        Me.PrgDlStuffTotal.Size = New System.Drawing.Size(71, 14)
        Me.PrgDlStuffTotal.TabIndex = 2
        '
        'PageDlRomPanel
        '
        Me.PageDlRomPanel.Controls.Add(Me.BtnRetryDlRom)
        Me.PageDlRomPanel.Controls.Add(Me.PanelDlRomPrg)
        Me.PageDlRomPanel.Location = New System.Drawing.Point(2, 153)
        Me.PageDlRomPanel.Name = "PageDlRomPanel"
        Me.PageDlRomPanel.Size = New System.Drawing.Size(79, 48)
        Me.PageDlRomPanel.TabIndex = 13
        Me.PageDlRomPanel.Tag = "4"
        Me.PageDlRomPanel.Visible = false
        '
        'BtnRetryDlRom
        '
        Me.BtnRetryDlRom.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.BtnRetryDlRom.BackColor = System.Drawing.Color.FromArgb(CType(CType(30,Byte),Integer), CType(CType(139,Byte),Integer), CType(CType(229,Byte),Integer))
        Me.BtnRetryDlRom.FlatAppearance.BorderSize = 0
        Me.BtnRetryDlRom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128,Byte),Integer), CType(CType(30,Byte),Integer), CType(CType(139,Byte),Integer), CType(CType(229,Byte),Integer))
        Me.BtnRetryDlRom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(30,Byte),Integer), CType(CType(139,Byte),Integer), CType(CType(229,Byte),Integer))
        Me.BtnRetryDlRom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRetryDlRom.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.BtnRetryDlRom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.BtnRetryDlRom.Location = New System.Drawing.Point(3, 22)
        Me.BtnRetryDlRom.Name = "BtnRetryDlRom"
        Me.BtnRetryDlRom.Size = New System.Drawing.Size(75, 23)
        Me.BtnRetryDlRom.TabIndex = 5
        Me.BtnRetryDlRom.Tag = "general_retry"
        Me.BtnRetryDlRom.Text = "Retry"
        Me.BtnRetryDlRom.UseVisualStyleBackColor = false
        Me.BtnRetryDlRom.Visible = false
        '
        'PanelDlRomPrg
        '
        Me.PanelDlRomPrg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PanelDlRomPrg.BackColor = System.Drawing.Color.Transparent
        Me.PanelDlRomPrg.Controls.Add(Me.LblDlRomStatusBPrg)
        Me.PanelDlRomPrg.Controls.Add(Me.LblDlRomTotalPrg)
        Me.PanelDlRomPrg.Controls.Add(Me.LblDlRomStatusPrg)
        Me.PanelDlRomPrg.Controls.Add(Me.LblDlRomStatus)
        Me.PanelDlRomPrg.Controls.Add(Me.LblDlRomTotal)
        Me.PanelDlRomPrg.Controls.Add(Me.PrgDlRomStatus)
        Me.PanelDlRomPrg.Controls.Add(Me.PrgDlRomTotal)
        Me.PanelDlRomPrg.Location = New System.Drawing.Point(3, 75)
        Me.PanelDlRomPrg.Name = "PanelDlRomPrg"
        Me.PanelDlRomPrg.Size = New System.Drawing.Size(73, 100)
        Me.PanelDlRomPrg.TabIndex = 4
        '
        'LblDlRomStatusBPrg
        '
        Me.LblDlRomStatusBPrg.AutoSize = true
        Me.LblDlRomStatusBPrg.Location = New System.Drawing.Point(576, 1)
        Me.LblDlRomStatusBPrg.Name = "LblDlRomStatusBPrg"
        Me.LblDlRomStatusBPrg.Size = New System.Drawing.Size(51, 13)
        Me.LblDlRomStatusBPrg.TabIndex = 6
        Me.LblDlRomStatusBPrg.Text = "0 / 0 MiB"
        '
        'LblDlRomTotalPrg
        '
        Me.LblDlRomTotalPrg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.LblDlRomTotalPrg.AutoSize = true
        Me.LblDlRomTotalPrg.Location = New System.Drawing.Point(34, 45)
        Me.LblDlRomTotalPrg.Name = "LblDlRomTotalPrg"
        Me.LblDlRomTotalPrg.Size = New System.Drawing.Size(36, 13)
        Me.LblDlRomTotalPrg.TabIndex = 5
        Me.LblDlRomTotalPrg.Text = "100 %"
        Me.LblDlRomTotalPrg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDlRomStatusPrg
        '
        Me.LblDlRomStatusPrg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.LblDlRomStatusPrg.AutoSize = true
        Me.LblDlRomStatusPrg.Location = New System.Drawing.Point(34, 1)
        Me.LblDlRomStatusPrg.Name = "LblDlRomStatusPrg"
        Me.LblDlRomStatusPrg.Size = New System.Drawing.Size(36, 13)
        Me.LblDlRomStatusPrg.TabIndex = 4
        Me.LblDlRomStatusPrg.Text = "100 %"
        Me.LblDlRomStatusPrg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblDlRomStatus
        '
        Me.LblDlRomStatus.AutoSize = true
        Me.LblDlRomStatus.Location = New System.Drawing.Point(3, 0)
        Me.LblDlRomStatus.Name = "LblDlRomStatus"
        Me.LblDlRomStatus.Size = New System.Drawing.Size(78, 13)
        Me.LblDlRomStatus.TabIndex = 0
        Me.LblDlRomStatus.Tag = "page_dlstuff_downloading"
        Me.LblDlRomStatus.Text = "Downloading..."
        '
        'LblDlRomTotal
        '
        Me.LblDlRomTotal.AutoSize = true
        Me.LblDlRomTotal.Location = New System.Drawing.Point(3, 45)
        Me.LblDlRomTotal.Name = "LblDlRomTotal"
        Me.LblDlRomTotal.Size = New System.Drawing.Size(74, 13)
        Me.LblDlRomTotal.TabIndex = 3
        Me.LblDlRomTotal.Tag = "page_dlstuff_total"
        Me.LblDlRomTotal.Text = "Total progress"
        '
        'PrgDlRomStatus
        '
        Me.PrgDlRomStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PrgDlRomStatus.BackColor = System.Drawing.Color.Transparent
        Me.PrgDlRomStatus.IsIntermediate = false
        Me.PrgDlRomStatus.Location = New System.Drawing.Point(6, 17)
        Me.PrgDlRomStatus.Name = "PrgDlRomStatus"
        Me.PrgDlRomStatus.Size = New System.Drawing.Size(64, 14)
        Me.PrgDlRomStatus.TabIndex = 1
        '
        'PrgDlRomTotal
        '
        Me.PrgDlRomTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.PrgDlRomTotal.BackColor = System.Drawing.Color.Transparent
        Me.PrgDlRomTotal.IsIntermediate = false
        Me.PrgDlRomTotal.Location = New System.Drawing.Point(6, 61)
        Me.PrgDlRomTotal.Name = "PrgDlRomTotal"
        Me.PrgDlRomTotal.Size = New System.Drawing.Size(64, 14)
        Me.PrgDlRomTotal.TabIndex = 2
        '
        'PagePreInstallPanel
        '
        Me.PagePreInstallPanel.Controls.Add(Me.ChkPreInstallAgree)
        Me.PagePreInstallPanel.Controls.Add(Me.LblPreInstallNotice)
        Me.PagePreInstallPanel.Location = New System.Drawing.Point(87, 153)
        Me.PagePreInstallPanel.Name = "PagePreInstallPanel"
        Me.PagePreInstallPanel.Size = New System.Drawing.Size(109, 48)
        Me.PagePreInstallPanel.TabIndex = 14
        Me.PagePreInstallPanel.Tag = "5"
        Me.PagePreInstallPanel.Visible = false
        '
        'ChkPreInstallAgree
        '
        Me.ChkPreInstallAgree.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.ChkPreInstallAgree.AutoSize = true
        Me.ChkPreInstallAgree.Location = New System.Drawing.Point(3, 25)
        Me.ChkPreInstallAgree.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.ChkPreInstallAgree.Name = "ChkPreInstallAgree"
        Me.ChkPreInstallAgree.Size = New System.Drawing.Size(59, 17)
        Me.ChkPreInstallAgree.TabIndex = 1
        Me.ChkPreInstallAgree.Tag = "page_preinstall_agree_chk"
        Me.ChkPreInstallAgree.Text = "I agree"
        Me.ChkPreInstallAgree.UseVisualStyleBackColor = true
        '
        'LblPreInstallNotice
        '
        Me.LblPreInstallNotice.AutoSize = true
        Me.LblPreInstallNotice.Location = New System.Drawing.Point(3, 4)
        Me.LblPreInstallNotice.Name = "LblPreInstallNotice"
        Me.LblPreInstallNotice.Size = New System.Drawing.Size(84, 13)
        Me.LblPreInstallNotice.TabIndex = 0
        Me.LblPreInstallNotice.Tag = "page_preinstall_notice"
        Me.LblPreInstallNotice.Text = "Pre-install notice"
        '
        'PageInstallPanel
        '
        Me.PageInstallPanel.Controls.Add(Me.PrgIInstallXOS)
        Me.PageInstallPanel.Controls.Add(Me.LblInstallInstallingXOS)
        Me.PageInstallPanel.Controls.Add(Me.LblInstallNotice)
        Me.PageInstallPanel.Location = New System.Drawing.Point(203, 153)
        Me.PageInstallPanel.Name = "PageInstallPanel"
        Me.PageInstallPanel.Size = New System.Drawing.Size(85, 48)
        Me.PageInstallPanel.TabIndex = 15
        Me.PageInstallPanel.Tag = "6"
        Me.PageInstallPanel.Visible = false
        '
        'PrgIInstallXOS
        '
        Me.PrgIInstallXOS.BackColor = System.Drawing.Color.Transparent
        Me.PrgIInstallXOS.IsIntermediate = false
        Me.PrgIInstallXOS.Location = New System.Drawing.Point(10, 34)
        Me.PrgIInstallXOS.Name = "PrgIInstallXOS"
        Me.PrgIInstallXOS.Size = New System.Drawing.Size(576, 14)
        Me.PrgIInstallXOS.TabIndex = 2
        '
        'LblInstallInstallingXOS
        '
        Me.LblInstallInstallingXOS.AutoSize = true
        Me.LblInstallInstallingXOS.Location = New System.Drawing.Point(7, 17)
        Me.LblInstallInstallingXOS.Name = "LblInstallInstallingXOS"
        Me.LblInstallInstallingXOS.Size = New System.Drawing.Size(113, 13)
        Me.LblInstallInstallingXOS.TabIndex = 1
        Me.LblInstallInstallingXOS.Tag = "page_install_installing"
        Me.LblInstallInstallingXOS.Text = "Installing halogenOS..."
        '
        'LblInstallNotice
        '
        Me.LblInstallNotice.AutoSize = true
        Me.LblInstallNotice.Location = New System.Drawing.Point(7, 236)
        Me.LblInstallNotice.Name = "LblInstallNotice"
        Me.LblInstallNotice.Size = New System.Drawing.Size(66, 13)
        Me.LblInstallNotice.TabIndex = 0
        Me.LblInstallNotice.Tag = "page_install_notice"
        Me.LblInstallNotice.Text = "Install notice"
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
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
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
        'PageFinishedPanel
        '
        Me.PageFinishedPanel.Controls.Add(Me.ChkRebootDevice)
        Me.PageFinishedPanel.Controls.Add(Me.LblInstallFailed)
        Me.PageFinishedPanel.Controls.Add(Me.LblInstallSucceeded)
        Me.PageFinishedPanel.Location = New System.Drawing.Point(294, 153)
        Me.PageFinishedPanel.Name = "PageFinishedPanel"
        Me.PageFinishedPanel.Size = New System.Drawing.Size(498, 407)
        Me.PageFinishedPanel.TabIndex = 16
        Me.PageFinishedPanel.Tag = "7"
        Me.PageFinishedPanel.Visible = false
        '
        'LblInstallSucceeded
        '
        Me.LblInstallSucceeded.AutoSize = true
        Me.LblInstallSucceeded.Location = New System.Drawing.Point(7, 4)
        Me.LblInstallSucceeded.Name = "LblInstallSucceeded"
        Me.LblInstallSucceeded.Size = New System.Drawing.Size(48, 13)
        Me.LblInstallSucceeded.TabIndex = 0
        Me.LblInstallSucceeded.Tag = "page_finish_success"
        Me.LblInstallSucceeded.Text = "Success"
        '
        'LblInstallFailed
        '
        Me.LblInstallFailed.AutoSize = true
        Me.LblInstallFailed.Location = New System.Drawing.Point(9, 178)
        Me.LblInstallFailed.Name = "LblInstallFailed"
        Me.LblInstallFailed.Size = New System.Drawing.Size(35, 13)
        Me.LblInstallFailed.TabIndex = 1
        Me.LblInstallFailed.Tag = "page_finish_failed"
        Me.LblInstallFailed.Text = "Failed"
        '
        'ChkRebootDevice
        '
        Me.ChkRebootDevice.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.ChkRebootDevice.AutoSize = true
        Me.ChkRebootDevice.Location = New System.Drawing.Point(4, 387)
        Me.ChkRebootDevice.Name = "ChkRebootDevice"
        Me.ChkRebootDevice.Size = New System.Drawing.Size(61, 17)
        Me.ChkRebootDevice.TabIndex = 2
        Me.ChkRebootDevice.Tag = "page_finish_reboot_device"
        Me.ChkRebootDevice.Text = "Reboot"
        Me.ChkRebootDevice.UseVisualStyleBackColor = true
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(804, 601)
        Me.Controls.Add(Me.PageFinishedPanel)
        Me.Controls.Add(Me.PageInstallPanel)
        Me.Controls.Add(Me.PagePreInstallPanel)
        Me.Controls.Add(Me.PageDlRomPanel)
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
        Me.PageDlRomPanel.ResumeLayout(false)
        Me.PanelDlRomPrg.ResumeLayout(false)
        Me.PanelDlRomPrg.PerformLayout
        Me.PagePreInstallPanel.ResumeLayout(false)
        Me.PagePreInstallPanel.PerformLayout
        Me.PageInstallPanel.ResumeLayout(false)
        Me.PageInstallPanel.PerformLayout
        Me.PageFinishedPanel.ResumeLayout(false)
        Me.PageFinishedPanel.PerformLayout
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
    Friend WithEvents PageDlRomPanel As Panel
    Friend WithEvents BtnRetryDlRom As xdui.FlatButton
    Friend WithEvents PanelDlRomPrg As Panel
    Friend WithEvents LblDlRomTotalPrg As Label
    Friend WithEvents LblDlRomStatusPrg As Label
    Friend WithEvents LblDlRomStatus As Label
    Friend WithEvents LblDlRomTotal As Label
    Friend WithEvents PrgDlRomStatus As xdui.FlatProgressBar
    Friend WithEvents PrgDlRomTotal As xdui.FlatProgressBar
    Friend WithEvents LblDlRomStatusBPrg As Label
    Friend WithEvents PagePreInstallPanel As Panel
    Friend WithEvents LblPreInstallNotice As Label
    Friend WithEvents ChkPreInstallAgree As CheckBox
    Friend WithEvents PageInstallPanel As Panel
    Friend WithEvents LblInstallNotice As Label
    Friend WithEvents LblInstallInstallingXOS As Label
    Friend WithEvents PrgIInstallXOS As xdui.FlatProgressBar
    Friend WithEvents PageFinishedPanel As Panel
    Friend WithEvents LblInstallFailed As Label
    Friend WithEvents LblInstallSucceeded As Label
    Friend WithEvents ChkRebootDevice As CheckBox
End Class
