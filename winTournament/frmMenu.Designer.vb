<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer  
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))

        ' ======= FORM SETTINGS =======
        Me.SuspendLayout()
        Me.Text = "Tournament Manager"
        Me.ClientSize = New System.Drawing.Size(900, 500)
        Me.BackColor = Color.Black ' Deep black background
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False

        Try
            Me.Icon = New Icon("C:\Users\jacka\Downloads\icon.ico")
            Me.BackgroundImage = My.Resources.background3 ' Use the name you gave in Resources
            Me.BackgroundImageLayout = ImageLayout.Stretch ' Stretch to fit window
        Catch ex As Exception
            MessageBox.Show("Error loading background image: " & ex.Message, "Image Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' ======= BUTTONS =======
        ' Common button settings
        Dim buttonWidth As Integer = 260
        Dim buttonHeight As Integer = 65
        Dim startX As Integer = (Me.ClientSize.Width - buttonWidth) \ 2 ' Centering horizontally
        Dim startY As Integer = 70
        Dim spacing As Integer = 25

        ' Start New Tournament
        Me.btnStartNewTournament = New Button()
        StyleButton(Me.btnStartNewTournament, "🏆 Start Tournament", startX, startY)

        ' Load Event Data
        Me.btnLoadEventData = New Button()
        StyleButton(Me.btnLoadEventData, "📂 Load Data", startX, startY + (buttonHeight + spacing))

        ' Result Analysis
        Me.btnResultAnalysis = New Button()
        StyleButton(Me.btnResultAnalysis, "📊 Analyze Results", startX, startY + 2 * (buttonHeight + spacing))

        ' Team Rankings
        Me.btnTeamRankings = New Button()
        StyleButton(Me.btnTeamRankings, "📈 Team Rankings", startX, startY + 3 * (buttonHeight + spacing))

        ' Settings Button
        Me.btnSettings = New Button()
        StyleButton(Me.btnSettings, "⚙ Settings", Me.ClientSize.Width - 140, Me.ClientSize.Height - 55, 110, 35)

        ' Exit Button
        Me.btnExit = New Button()
        StyleButton(Me.btnExit, "❌ Exit", Me.ClientSize.Width - 260, Me.ClientSize.Height - 55, 110, 35)

        ' ======= ADD CONTROLS TO FORM =======
        Me.Controls.Add(Me.btnStartNewTournament)
        Me.Controls.Add(Me.btnLoadEventData)
        Me.Controls.Add(Me.btnResultAnalysis)
        Me.Controls.Add(Me.btnTeamRankings)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.btnExit)

        Me.ResumeLayout(False)
    End Sub

    ' ======= BUTTON STYLING FUNCTION (Tesla SpaceX Glow) =======
    Private Sub StyleButton(btn As Button, text As String, x As Integer, y As Integer, Optional width As Integer = 250, Optional height As Integer = 60)
        btn.Text = text
        btn.Font = New Font("Segoe UI", 12, FontStyle.Bold)
        btn.BackColor = Color.FromArgb(45, 45, 45) ' Dark gray buttons
        btn.ForeColor = Color.White
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 130, 180) ' Hover effect
        btn.Size = New Size(width, height)
        btn.TextAlign = ContentAlignment.MiddleCenter
        btn.Location = New Point(x, y)
    End Sub

    ' ======= BUTTON DECLARATIONS =======
    Friend WithEvents btnStartNewTournament As Button
    Friend WithEvents btnLoadEventData As Button
    Friend WithEvents btnResultAnalysis As Button
    Friend WithEvents btnTeamRankings As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnSettings As Button

End Class
