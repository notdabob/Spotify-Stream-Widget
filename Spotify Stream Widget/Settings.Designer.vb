﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Settings
    Inherits MetroFramework.Forms.MetroForm

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.ViewerLaunchBtn = New System.Windows.Forms.Button()
        Me.ColorSettingToggle = New MetroFramework.Controls.MetroToggle()
        Me.ColorSettingLabel = New MetroFramework.Controls.MetroLabel()
        Me.CreditLink = New MetroFramework.Controls.MetroLink()
        Me.SizeSettingBox = New MetroFramework.Controls.MetroComboBox()
        Me.SizeSettingLabel = New MetroFramework.Controls.MetroLabel()
        Me.ProgressStyleLabel = New MetroFramework.Controls.MetroLabel()
        Me.ProgressStyleBox = New MetroFramework.Controls.MetroComboBox()
        Me.CreditsLink = New MetroFramework.Controls.MetroLink()
        Me.CreditPanel = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CreditsText = New System.Windows.Forms.TextBox()
        Me.ReportLink = New MetroFramework.Controls.MetroLink()
        Me.ColorStyleLabel = New MetroFramework.Controls.MetroLabel()
        Me.ColorStyleBox = New MetroFramework.Controls.MetroComboBox()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.VersionCheck = New System.ComponentModel.BackgroundWorker()
        Me.CreditPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ViewerLaunchBtn
        '
        Me.ViewerLaunchBtn.Location = New System.Drawing.Point(23, 373)
        Me.ViewerLaunchBtn.Name = "ViewerLaunchBtn"
        Me.ViewerLaunchBtn.Size = New System.Drawing.Size(251, 23)
        Me.ViewerLaunchBtn.TabIndex = 0
        Me.ViewerLaunchBtn.Text = "Open Viewer"
        Me.ViewerLaunchBtn.UseVisualStyleBackColor = True
        '
        'ColorSettingToggle
        '
        Me.ColorSettingToggle.AutoSize = True
        Me.ColorSettingToggle.Checked = True
        Me.ColorSettingToggle.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ColorSettingToggle.Location = New System.Drawing.Point(183, 63)
        Me.ColorSettingToggle.Name = "ColorSettingToggle"
        Me.ColorSettingToggle.Size = New System.Drawing.Size(80, 17)
        Me.ColorSettingToggle.Style = MetroFramework.MetroColorStyle.Green
        Me.ColorSettingToggle.TabIndex = 1
        Me.ColorSettingToggle.Text = "An"
        Me.ColorSettingToggle.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ColorSettingToggle.UseSelectable = True
        '
        'ColorSettingLabel
        '
        Me.ColorSettingLabel.AutoSize = True
        Me.ColorSettingLabel.Location = New System.Drawing.Point(13, 61)
        Me.ColorSettingLabel.Name = "ColorSettingLabel"
        Me.ColorSettingLabel.Size = New System.Drawing.Size(75, 19)
        Me.ColorSettingLabel.TabIndex = 2
        Me.ColorSettingLabel.Text = "Dark Mode"
        Me.ColorSettingLabel.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'CreditLink
        '
        Me.CreditLink.Location = New System.Drawing.Point(23, 400)
        Me.CreditLink.Name = "CreditLink"
        Me.CreditLink.Size = New System.Drawing.Size(251, 18)
        Me.CreditLink.TabIndex = 3
        Me.CreditLink.Text = "Made by Marco Sadowski"
        Me.CreditLink.UseCustomBackColor = True
        Me.CreditLink.UseSelectable = True
        Me.CreditLink.UseStyleColors = True
        '
        'SizeSettingBox
        '
        Me.SizeSettingBox.FormattingEnabled = True
        Me.SizeSettingBox.ItemHeight = 23
        Me.SizeSettingBox.Items.AddRange(New Object() {"Small", "Normal", "Big"})
        Me.SizeSettingBox.Location = New System.Drawing.Point(161, 86)
        Me.SizeSettingBox.Name = "SizeSettingBox"
        Me.SizeSettingBox.Size = New System.Drawing.Size(102, 29)
        Me.SizeSettingBox.Style = MetroFramework.MetroColorStyle.Green
        Me.SizeSettingBox.TabIndex = 4
        Me.SizeSettingBox.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.SizeSettingBox.UseSelectable = True
        '
        'SizeSettingLabel
        '
        Me.SizeSettingLabel.AutoSize = True
        Me.SizeSettingLabel.Location = New System.Drawing.Point(13, 96)
        Me.SizeSettingLabel.Name = "SizeSettingLabel"
        Me.SizeSettingLabel.Size = New System.Drawing.Size(75, 19)
        Me.SizeSettingLabel.TabIndex = 5
        Me.SizeSettingLabel.Text = "Viewer Size"
        Me.SizeSettingLabel.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'ProgressStyleLabel
        '
        Me.ProgressStyleLabel.AutoSize = True
        Me.ProgressStyleLabel.Location = New System.Drawing.Point(13, 131)
        Me.ProgressStyleLabel.Name = "ProgressStyleLabel"
        Me.ProgressStyleLabel.Size = New System.Drawing.Size(111, 19)
        Me.ProgressStyleLabel.TabIndex = 7
        Me.ProgressStyleLabel.Text = "ProgressBar Style"
        Me.ProgressStyleLabel.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'ProgressStyleBox
        '
        Me.ProgressStyleBox.FormattingEnabled = True
        Me.ProgressStyleBox.ItemHeight = 23
        Me.ProgressStyleBox.Items.AddRange(New Object() {"Blocks", "Continuous", "Marquee"})
        Me.ProgressStyleBox.Location = New System.Drawing.Point(161, 121)
        Me.ProgressStyleBox.Name = "ProgressStyleBox"
        Me.ProgressStyleBox.Size = New System.Drawing.Size(102, 29)
        Me.ProgressStyleBox.Style = MetroFramework.MetroColorStyle.Green
        Me.ProgressStyleBox.TabIndex = 6
        Me.ProgressStyleBox.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ProgressStyleBox.UseSelectable = True
        '
        'CreditsLink
        '
        Me.CreditsLink.Location = New System.Drawing.Point(183, 424)
        Me.CreditsLink.Name = "CreditsLink"
        Me.CreditsLink.Size = New System.Drawing.Size(115, 18)
        Me.CreditsLink.TabIndex = 8
        Me.CreditsLink.Text = "Credits and License"
        Me.CreditsLink.UseCustomBackColor = True
        Me.CreditsLink.UseSelectable = True
        Me.CreditsLink.UseStyleColors = True
        '
        'CreditPanel
        '
        Me.CreditPanel.Controls.Add(Me.Button1)
        Me.CreditPanel.Controls.Add(Me.CreditsText)
        Me.CreditPanel.Location = New System.Drawing.Point(257, 424)
        Me.CreditPanel.Name = "CreditPanel"
        Me.CreditPanel.Size = New System.Drawing.Size(272, 304)
        Me.CreditPanel.TabIndex = 9
        Me.CreditPanel.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(151, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 24)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CreditsText
        '
        Me.CreditsText.Location = New System.Drawing.Point(3, 0)
        Me.CreditsText.Multiline = True
        Me.CreditsText.Name = "CreditsText"
        Me.CreditsText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.CreditsText.Size = New System.Drawing.Size(269, 304)
        Me.CreditsText.TabIndex = 10
        Me.CreditsText.Text = resources.GetString("CreditsText.Text")
        '
        'ReportLink
        '
        Me.ReportLink.Location = New System.Drawing.Point(0, 424)
        Me.ReportLink.Name = "ReportLink"
        Me.ReportLink.Size = New System.Drawing.Size(88, 18)
        Me.ReportLink.TabIndex = 10
        Me.ReportLink.Text = "Report a bug"
        Me.ReportLink.UseCustomBackColor = True
        Me.ReportLink.UseSelectable = True
        Me.ReportLink.UseStyleColors = True
        '
        'ColorStyleLabel
        '
        Me.ColorStyleLabel.AutoSize = True
        Me.ColorStyleLabel.Location = New System.Drawing.Point(13, 166)
        Me.ColorStyleLabel.Name = "ColorStyleLabel"
        Me.ColorStyleLabel.Size = New System.Drawing.Size(116, 19)
        Me.ColorStyleLabel.TabIndex = 12
        Me.ColorStyleLabel.Text = "Viewer Style Color"
        Me.ColorStyleLabel.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'ColorStyleBox
        '
        Me.ColorStyleBox.FormattingEnabled = True
        Me.ColorStyleBox.ItemHeight = 23
        Me.ColorStyleBox.Items.AddRange(New Object() {"Green", "Black", "White", "Silver", "Blue", "Lime", "Teal", "Orange", "Brown", "Pink", "Magenta", "Purple", "Red", "Yellow"})
        Me.ColorStyleBox.Location = New System.Drawing.Point(161, 156)
        Me.ColorStyleBox.Name = "ColorStyleBox"
        Me.ColorStyleBox.Size = New System.Drawing.Size(102, 29)
        Me.ColorStyleBox.Style = MetroFramework.MetroColorStyle.Green
        Me.ColorStyleBox.TabIndex = 11
        Me.ColorStyleBox.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ColorStyleBox.UseSelectable = True
        '
        'VersionLabel
        '
        Me.VersionLabel.AutoSize = True
        Me.VersionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
        Me.VersionLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.VersionLabel.Location = New System.Drawing.Point(255, 49)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(30, 9)
        Me.VersionLabel.TabIndex = 13
        Me.VersionLabel.Text = "version"
        '
        'VersionCheck
        '
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 441)
        Me.Controls.Add(Me.CreditPanel)
        Me.Controls.Add(Me.VersionLabel)
        Me.Controls.Add(Me.ColorStyleLabel)
        Me.Controls.Add(Me.ColorStyleBox)
        Me.Controls.Add(Me.ReportLink)
        Me.Controls.Add(Me.CreditsLink)
        Me.Controls.Add(Me.ProgressStyleLabel)
        Me.Controls.Add(Me.ProgressStyleBox)
        Me.Controls.Add(Me.SizeSettingLabel)
        Me.Controls.Add(Me.SizeSettingBox)
        Me.Controls.Add(Me.CreditLink)
        Me.Controls.Add(Me.ColorSettingLabel)
        Me.Controls.Add(Me.ColorSettingToggle)
        Me.Controls.Add(Me.ViewerLaunchBtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Settings"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Spotify Widget Settings"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.CreditPanel.ResumeLayout(False)
        Me.CreditPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ViewerLaunchBtn As Button
    Friend WithEvents ColorSettingToggle As MetroFramework.Controls.MetroToggle
    Friend WithEvents ColorSettingLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents CreditLink As MetroFramework.Controls.MetroLink
    Friend WithEvents SizeSettingBox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents SizeSettingLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents ProgressStyleLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents ProgressStyleBox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents CreditsLink As MetroFramework.Controls.MetroLink
    Friend WithEvents CreditPanel As Panel
    Friend WithEvents CreditsText As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ReportLink As MetroFramework.Controls.MetroLink
    Friend WithEvents ColorStyleLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents ColorStyleBox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents VersionLabel As Label
    Friend WithEvents VersionCheck As System.ComponentModel.BackgroundWorker
End Class
