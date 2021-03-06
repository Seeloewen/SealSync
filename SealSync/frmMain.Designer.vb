<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblSourceFolder = New System.Windows.Forms.Label()
        Me.lblTargetFolder = New System.Windows.Forms.Label()
        Me.tbSourceFolder = New System.Windows.Forms.TextBox()
        Me.tbTargetFolder = New System.Windows.Forms.TextBox()
        Me.btnBrowseTargetFolder = New System.Windows.Forms.Button()
        Me.btnBrowseSourceFolder = New System.Windows.Forms.Button()
        Me.btnSync = New System.Windows.Forms.Button()
        Me.fbdSourceFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.fbdTargetFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.cbxDefaultProfile = New System.Windows.Forms.ComboBox()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnSaveProfile = New System.Windows.Forms.Button()
        Me.btnLoadProfile = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(13, 13)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(111, 25)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "SealSync"
        '
        'lblSourceFolder
        '
        Me.lblSourceFolder.AutoSize = True
        Me.lblSourceFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSourceFolder.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSourceFolder.Location = New System.Drawing.Point(15, 60)
        Me.lblSourceFolder.Name = "lblSourceFolder"
        Me.lblSourceFolder.Size = New System.Drawing.Size(90, 16)
        Me.lblSourceFolder.TabIndex = 1
        Me.lblSourceFolder.Text = "Source folder:"
        '
        'lblTargetFolder
        '
        Me.lblTargetFolder.AutoSize = True
        Me.lblTargetFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTargetFolder.Location = New System.Drawing.Point(15, 118)
        Me.lblTargetFolder.Name = "lblTargetFolder"
        Me.lblTargetFolder.Size = New System.Drawing.Size(87, 16)
        Me.lblTargetFolder.TabIndex = 2
        Me.lblTargetFolder.Text = "Target folder:"
        '
        'tbSourceFolder
        '
        Me.tbSourceFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSourceFolder.Location = New System.Drawing.Point(18, 79)
        Me.tbSourceFolder.Name = "tbSourceFolder"
        Me.tbSourceFolder.Size = New System.Drawing.Size(362, 22)
        Me.tbSourceFolder.TabIndex = 3
        '
        'tbTargetFolder
        '
        Me.tbTargetFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTargetFolder.Location = New System.Drawing.Point(18, 137)
        Me.tbTargetFolder.Name = "tbTargetFolder"
        Me.tbTargetFolder.Size = New System.Drawing.Size(362, 22)
        Me.tbTargetFolder.TabIndex = 4
        '
        'btnBrowseTargetFolder
        '
        Me.btnBrowseTargetFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowseTargetFolder.Location = New System.Drawing.Point(386, 137)
        Me.btnBrowseTargetFolder.Name = "btnBrowseTargetFolder"
        Me.btnBrowseTargetFolder.Size = New System.Drawing.Size(97, 23)
        Me.btnBrowseTargetFolder.TabIndex = 5
        Me.btnBrowseTargetFolder.Text = "Browse"
        Me.btnBrowseTargetFolder.UseVisualStyleBackColor = True
        '
        'btnBrowseSourceFolder
        '
        Me.btnBrowseSourceFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowseSourceFolder.Location = New System.Drawing.Point(386, 79)
        Me.btnBrowseSourceFolder.Name = "btnBrowseSourceFolder"
        Me.btnBrowseSourceFolder.Size = New System.Drawing.Size(97, 23)
        Me.btnBrowseSourceFolder.TabIndex = 6
        Me.btnBrowseSourceFolder.Text = "Browse"
        Me.btnBrowseSourceFolder.UseVisualStyleBackColor = True
        '
        'btnSync
        '
        Me.btnSync.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSync.Location = New System.Drawing.Point(18, 209)
        Me.btnSync.Name = "btnSync"
        Me.btnSync.Size = New System.Drawing.Size(362, 35)
        Me.btnSync.TabIndex = 7
        Me.btnSync.Text = "Sync now"
        Me.btnSync.UseVisualStyleBackColor = True
        '
        'fbdSourceFolder
        '
        Me.fbdSourceFolder.Description = "Select the folder where the files should be synchronized from."
        '
        'fbdTargetFolder
        '
        Me.fbdTargetFolder.Description = "Select the folder where the files should be synchronized to."
        '
        'btnSettings
        '
        Me.btnSettings.BackgroundImage = Global.SealSync.My.Resources.Resources.btnSettings
        Me.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.Location = New System.Drawing.Point(388, 209)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(45, 35)
        Me.btnSettings.TabIndex = 9
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'cbxDefaultProfile
        '
        Me.cbxDefaultProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxDefaultProfile.FormattingEnabled = True
        Me.cbxDefaultProfile.Location = New System.Drawing.Point(18, 258)
        Me.cbxDefaultProfile.Name = "cbxDefaultProfile"
        Me.cbxDefaultProfile.Size = New System.Drawing.Size(121, 21)
        Me.cbxDefaultProfile.TabIndex = 10
        '
        'btnAbout
        '
        Me.btnAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.Location = New System.Drawing.Point(439, 209)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(45, 35)
        Me.btnAbout.TabIndex = 8
        Me.btnAbout.Text = "?"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'btnSaveProfile
        '
        Me.btnSaveProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveProfile.Location = New System.Drawing.Point(386, 17)
        Me.btnSaveProfile.Name = "btnSaveProfile"
        Me.btnSaveProfile.Size = New System.Drawing.Size(97, 23)
        Me.btnSaveProfile.TabIndex = 11
        Me.btnSaveProfile.Text = "Save profile"
        Me.btnSaveProfile.UseVisualStyleBackColor = True
        '
        'btnLoadProfile
        '
        Me.btnLoadProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadProfile.Location = New System.Drawing.Point(282, 17)
        Me.btnLoadProfile.Name = "btnLoadProfile"
        Me.btnLoadProfile.Size = New System.Drawing.Size(98, 23)
        Me.btnLoadProfile.TabIndex = 12
        Me.btnLoadProfile.Text = "Load profile"
        Me.btnLoadProfile.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(496, 256)
        Me.Controls.Add(Me.btnLoadProfile)
        Me.Controls.Add(Me.btnSaveProfile)
        Me.Controls.Add(Me.cbxDefaultProfile)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnSync)
        Me.Controls.Add(Me.btnBrowseSourceFolder)
        Me.Controls.Add(Me.btnBrowseTargetFolder)
        Me.Controls.Add(Me.tbTargetFolder)
        Me.Controls.Add(Me.tbSourceFolder)
        Me.Controls.Add(Me.lblTargetFolder)
        Me.Controls.Add(Me.lblSourceFolder)
        Me.Controls.Add(Me.lblHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SealSync"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents lblSourceFolder As Label
    Friend WithEvents lblTargetFolder As Label
    Friend WithEvents tbSourceFolder As TextBox
    Friend WithEvents tbTargetFolder As TextBox
    Friend WithEvents btnBrowseTargetFolder As Button
    Friend WithEvents btnBrowseSourceFolder As Button
    Friend WithEvents btnSync As Button
    Friend WithEvents fbdSourceFolder As FolderBrowserDialog
    Friend WithEvents fbdTargetFolder As FolderBrowserDialog
    Friend WithEvents btnSettings As Button
    Friend WithEvents cbxDefaultProfile As ComboBox
    Friend WithEvents btnAbout As Button
    Friend WithEvents btnSaveProfile As Button
    Friend WithEvents btnLoadProfile As Button
End Class
