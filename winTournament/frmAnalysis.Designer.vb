<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnalysis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnalysis))
        Me.lstIndEveResults = New System.Windows.Forms.ListBox()
        Me.btnSortIndEveRes = New System.Windows.Forms.Button()
        Me.cboIndEveResults = New System.Windows.Forms.ComboBox()
        Me.btnFinish = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.lstTeamEveRes = New System.Windows.Forms.ListBox()
        Me.btnSortTeamEveRes = New System.Windows.Forms.Button()
        Me.lstIndRes = New System.Windows.Forms.ListBox()
        Me.btnSortIndRes = New System.Windows.Forms.Button()
        Me.cboTeamEveRes = New System.Windows.Forms.ComboBox()
        Me.lstTeamRes = New System.Windows.Forms.ListBox()
        Me.btnSortTeamRes = New System.Windows.Forms.Button()
        Me.TabPage4.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstIndEveResults
        '
        Me.lstIndEveResults.BackColor = System.Drawing.Color.White
        Me.lstIndEveResults.FormattingEnabled = True
        Me.lstIndEveResults.ItemHeight = 15
        Me.lstIndEveResults.Location = New System.Drawing.Point(143, 86)
        Me.lstIndEveResults.Name = "lstIndEveResults"
        Me.lstIndEveResults.Size = New System.Drawing.Size(218, 454)
        Me.lstIndEveResults.TabIndex = 5
        '
        'btnSortIndEveRes
        '
        Me.btnSortIndEveRes.Location = New System.Drawing.Point(143, 551)
        Me.btnSortIndEveRes.Name = "btnSortIndEveRes"
        Me.btnSortIndEveRes.Size = New System.Drawing.Size(218, 44)
        Me.btnSortIndEveRes.TabIndex = 7
        Me.btnSortIndEveRes.Text = "Sort"
        Me.btnSortIndEveRes.UseVisualStyleBackColor = True
        '
        'cboIndEveResults
        '
        Me.cboIndEveResults.FormattingEnabled = True
        Me.cboIndEveResults.Location = New System.Drawing.Point(240, 32)
        Me.cboIndEveResults.Name = "cboIndEveResults"
        Me.cboIndEveResults.Size = New System.Drawing.Size(121, 23)
        Me.cboIndEveResults.TabIndex = 8
        '
        'btnFinish
        '
        Me.btnFinish.Location = New System.Drawing.Point(639, 618)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(94, 38)
        Me.btnFinish.TabIndex = 9
        Me.btnFinish.Text = "Finish"
        Me.btnFinish.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TabPage4.Controls.Add(Me.btnSortTeamRes)
        Me.TabPage4.Controls.Add(Me.lstTeamRes)
        Me.TabPage4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(601, 601)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Overall Team Results"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.btnSortIndRes)
        Me.TabPage3.Controls.Add(Me.lstIndRes)
        Me.TabPage3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(601, 601)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Overall Individual Results"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.cboTeamEveRes)
        Me.TabPage2.Controls.Add(Me.btnSortTeamEveRes)
        Me.TabPage2.Controls.Add(Me.lstTeamEveRes)
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(601, 601)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Team Results by Event"
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.lstIndEveResults)
        Me.TabPage1.Controls.Add(Me.cboIndEveResults)
        Me.TabPage1.Controls.Add(Me.btnSortIndEveRes)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(601, 601)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Individual Results by Event"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(24, 17)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(609, 627)
        Me.TabControl1.TabIndex = 10
        '
        'lstTeamEveRes
        '
        Me.lstTeamEveRes.BackColor = System.Drawing.Color.White
        Me.lstTeamEveRes.FormattingEnabled = True
        Me.lstTeamEveRes.ItemHeight = 15
        Me.lstTeamEveRes.Location = New System.Drawing.Point(144, 91)
        Me.lstTeamEveRes.Name = "lstTeamEveRes"
        Me.lstTeamEveRes.Size = New System.Drawing.Size(218, 454)
        Me.lstTeamEveRes.TabIndex = 6
        '
        'btnSortTeamEveRes
        '
        Me.btnSortTeamEveRes.Location = New System.Drawing.Point(144, 551)
        Me.btnSortTeamEveRes.Name = "btnSortTeamEveRes"
        Me.btnSortTeamEveRes.Size = New System.Drawing.Size(218, 44)
        Me.btnSortTeamEveRes.TabIndex = 8
        Me.btnSortTeamEveRes.Text = "Sort"
        Me.btnSortTeamEveRes.UseVisualStyleBackColor = True
        '
        'lstIndRes
        '
        Me.lstIndRes.BackColor = System.Drawing.Color.White
        Me.lstIndRes.FormattingEnabled = True
        Me.lstIndRes.ItemHeight = 15
        Me.lstIndRes.Location = New System.Drawing.Point(144, 90)
        Me.lstIndRes.Name = "lstIndRes"
        Me.lstIndRes.Size = New System.Drawing.Size(218, 454)
        Me.lstIndRes.TabIndex = 7
        '
        'btnSortIndRes
        '
        Me.btnSortIndRes.Location = New System.Drawing.Point(144, 550)
        Me.btnSortIndRes.Name = "btnSortIndRes"
        Me.btnSortIndRes.Size = New System.Drawing.Size(218, 44)
        Me.btnSortIndRes.TabIndex = 9
        Me.btnSortIndRes.Text = "Sort"
        Me.btnSortIndRes.UseVisualStyleBackColor = True
        '
        'cboTeamEveRes
        '
        Me.cboTeamEveRes.FormattingEnabled = True
        Me.cboTeamEveRes.Location = New System.Drawing.Point(241, 37)
        Me.cboTeamEveRes.Name = "cboTeamEveRes"
        Me.cboTeamEveRes.Size = New System.Drawing.Size(121, 23)
        Me.cboTeamEveRes.TabIndex = 9
        '
        'lstTeamRes
        '
        Me.lstTeamRes.BackColor = System.Drawing.Color.White
        Me.lstTeamRes.FormattingEnabled = True
        Me.lstTeamRes.ItemHeight = 15
        Me.lstTeamRes.Location = New System.Drawing.Point(149, 91)
        Me.lstTeamRes.Name = "lstTeamRes"
        Me.lstTeamRes.Size = New System.Drawing.Size(218, 454)
        Me.lstTeamRes.TabIndex = 8
        '
        'btnSortTeamRes
        '
        Me.btnSortTeamRes.Location = New System.Drawing.Point(149, 551)
        Me.btnSortTeamRes.Name = "btnSortTeamRes"
        Me.btnSortTeamRes.Size = New System.Drawing.Size(218, 44)
        Me.btnSortTeamRes.TabIndex = 10
        Me.btnSortTeamRes.Text = "Sort"
        Me.btnSortTeamRes.UseVisualStyleBackColor = True
        '
        'frmAnalysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 656)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnFinish)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAnalysis"
        Me.Text = "Result Analysis"
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstIndEveResults As ListBox
    Friend WithEvents btnSortIndEveRes As Button
    Friend WithEvents cboIndEveResults As ComboBox
    Friend WithEvents btnFinish As Button
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents btnSortTeamEveRes As Button
    Friend WithEvents lstTeamEveRes As ListBox
    Friend WithEvents btnSortIndRes As Button
    Friend WithEvents lstIndRes As ListBox
    Friend WithEvents cboTeamEveRes As ComboBox
    Friend WithEvents btnSortTeamRes As Button
    Friend WithEvents lstTeamRes As ListBox
End Class
