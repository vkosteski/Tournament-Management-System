<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.btnStartNewTournament = New System.Windows.Forms.Button()
        Me.btnLoadEventData = New System.Windows.Forms.Button()
        Me.btnResultAnalysis = New System.Windows.Forms.Button()
        Me.btnTeamRankings = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnStartNewTournament
        '
        Me.btnStartNewTournament.BackColor = System.Drawing.Color.Azure
        Me.btnStartNewTournament.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartNewTournament.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnStartNewTournament.Location = New System.Drawing.Point(357, 35)
        Me.btnStartNewTournament.Name = "btnStartNewTournament"
        Me.btnStartNewTournament.Size = New System.Drawing.Size(143, 85)
        Me.btnStartNewTournament.TabIndex = 0
        Me.btnStartNewTournament.Text = "Start New Tournament"
        Me.btnStartNewTournament.UseVisualStyleBackColor = False
        '
        'btnLoadEventData
        '
        Me.btnLoadEventData.BackColor = System.Drawing.Color.Azure
        Me.btnLoadEventData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadEventData.Location = New System.Drawing.Point(357, 147)
        Me.btnLoadEventData.Name = "btnLoadEventData"
        Me.btnLoadEventData.Size = New System.Drawing.Size(143, 82)
        Me.btnLoadEventData.TabIndex = 1
        Me.btnLoadEventData.Text = "Load Event Data"
        Me.btnLoadEventData.UseVisualStyleBackColor = False
        '
        'btnResultAnalysis
        '
        Me.btnResultAnalysis.BackColor = System.Drawing.Color.Azure
        Me.btnResultAnalysis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResultAnalysis.Location = New System.Drawing.Point(357, 250)
        Me.btnResultAnalysis.Name = "btnResultAnalysis"
        Me.btnResultAnalysis.Size = New System.Drawing.Size(143, 83)
        Me.btnResultAnalysis.TabIndex = 2
        Me.btnResultAnalysis.Text = "Result Analysis"
        Me.btnResultAnalysis.UseVisualStyleBackColor = False
        '
        'btnTeamRankings
        '
        Me.btnTeamRankings.BackColor = System.Drawing.Color.Azure
        Me.btnTeamRankings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTeamRankings.Location = New System.Drawing.Point(357, 358)
        Me.btnTeamRankings.Name = "btnTeamRankings"
        Me.btnTeamRankings.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnTeamRankings.Size = New System.Drawing.Size(143, 85)
        Me.btnTeamRankings.TabIndex = 3
        Me.btnTeamRankings.Text = "Team Rankings"
        Me.btnTeamRankings.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Azure
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(773, 460)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 31)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.Color.Azure
        Me.btnSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.Location = New System.Drawing.Point(673, 460)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(94, 31)
        Me.btnSettings.TabIndex = 5
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.UseVisualStyleBackColor = False
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.winTournament.My.Resources.Resources._360_F_462211610_9MfpUZkIXZ45tx7LBDwyaVcsHNa0Iplq
        Me.ClientSize = New System.Drawing.Size(868, 491)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnTeamRankings)
        Me.Controls.Add(Me.btnResultAnalysis)
        Me.Controls.Add(Me.btnLoadEventData)
        Me.Controls.Add(Me.btnStartNewTournament)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMenu"
        Me.Text = "Tournament"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnStartNewTournament As Button
    Friend WithEvents btnLoadEventData As Button
    Friend WithEvents btnResultAnalysis As Button
    Friend WithEvents btnTeamRankings As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnSettings As Button
End Class
