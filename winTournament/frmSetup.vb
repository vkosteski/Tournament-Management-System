Public Class frmSetup
    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        'Checks if correct number of events and participants are present
        If TEventCount <> 5 Or IEventCount <> 5 Or indCount <> 20 Or teamCount <> 4 Then
            MsgBox("Please check that you have entered 5 individual events, 5 team events, 20 individual participants and 4 teams just before clicking Finish!")
        Else
            Me.Close()
            frmMenu.Show()
        End If
    End Sub

    Private Sub lblDisplayEvent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listDisplayEvent.SelectedIndexChanged

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Checks for the option individual selected
        If rdoInd.Checked = True Then
            'Checks if there is enough room in the listbox for another event
            If IEventCount < 5 Then
                IEvent(IEventCount).EName = txtName.Text
                'input for event name
                IEvent(IEventCount).EDesc = txtDescription.Text
                'input for description 
                IEventCount += 1
                'adds 1
                lblIndEventsNum.Text = IEventCount
                'adds 1
                If selectedcheckbox.Checked Then
                    listDisplayEvent.Items.Add(eventscombo.Text & " Ind")
                End If
                If customcheckbox.Checked Then
                    listDisplayEvent.Items.Add(txtName.Text & " Ind")
                End If
                'Adds the item to the listbox

            Else
                'Makes the user aware there are too many events added
                MsgBox("There are already 5 individual events.")
            End If
        End If
        'Checks for the option team selected
        If rdoTeam.Checked = True Then
            'Checks if there is enough room in the listbox for another event
            If TEventCount < 5 Then
                TEvent(TEventCount).EName = txtName.Text
                'input for event name
                TEvent(TEventCount).EDesc = txtDescription.Text
                'input for description 
                TEventCount += 1
                'adds 1
                lblTeamEventsNum.Text = TEventCount
                'Adds the item to the listbox
                If selectedcheckbox.Checked Then
                    listDisplayEvent.Items.Add(eventscombo.Text & " Team")
                End If
                If customcheckbox.Checked Then
                    listDisplayEvent.Items.Add(txtName.Text & " Team")
                End If
                'Makes the user aware there are too many events added
            Else
                MsgBox("There are already 5 Team events.")
            End If
        End If
        'Resets text boxesf
        txtName.Text = ""
        txtDescription.Text = ""
    End Sub

    Private Sub KeyIsDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Checks for the option individual selected
            If rdoInd.Checked = True Then
                'Checks if there is enough room in the listbox for another event
                If IEventCount < 5 Then
                    IEvent(IEventCount).EName = txtName.Text
                    'input for event name
                    IEvent(IEventCount).EDesc = txtDescription.Text
                    'input for description 
                    IEventCount += 1
                    'adds 1
                    lblIndEventsNum.Text = IEventCount
                    'adds 1
                    listDisplayEvent.Items.Add(txtName.Text & " Ind")
                    'Adds the item to the listbox

                Else
                    'Makes the user aware there are too many events added
                    MsgBox("There are already 5 individual events.")
                End If
            End If
            'Checks for the option team selected
            If rdoTeam.Checked = True Then
                'Checks if there is enough room in the listbox for another event
                If TEventCount < 5 Then
                    TEvent(TEventCount).EName = txtName.Text
                    'input for event name
                    TEvent(TEventCount).EDesc = txtDescription.Text
                    'input for description 
                    TEventCount += 1
                    'adds 1
                    lblTeamEventsNum.Text = TEventCount
                    'Adds the item to the listbox
                    listDisplayEvent.Items.Add(txtName.Text & " Team")
                    'Makes the user aware there are too many events added
                Else
                    MsgBox("There are already 5 Team events.")
                End If
            End If
        End If
        'Checks that the details are correctly completed
        If txtParName.Text <> "" Then

            If rdoIndPar.Checked = True Then
                If indCount < 20 Then
                    ind(indCount).iName = txtParName.Text
                    ind(indCount).iResult = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
                    indCount += 1
                    lblIndSoFarNum.Text = indCount
                    ListDisplayPar.Items.Add(txtParName.Text & " Ind")
                Else

                    MsgBox("Max number of individual players has been reached.")
                End If
            End If
            'checks the radio button for Team selected
            If rdoTeamPar.Checked = True Then
                'Asks for 5 names
                If txtTeamMem1.Text = "" Or txtTeamMem2.Text = "" Or txtTeamMem3.Text = "" Or txtTeamMem4.Text = "" Or txtTeamMem5.Text = "" Then
                    MsgBox("Please enter 5 names for the team")
                Else
                    'Checks that there are less than 4 teams
                    If teamCount < 4 Then
                        'Team name
                        team(teamCount).TName = txtParName.Text
                        'Team members
                        team(teamCount).TPlayerName = {txtTeamMem1.Text, txtTeamMem2.Text, txtTeamMem3.Text, txtTeamMem4.Text, txtTeamMem5.Text}
                        'Increases the team count since a team has been added.
                        team(teamCount).TResult = {0, 0, 0, 0, 0}
                        teamCount += 1
                        lblTeamSoFarNum.Text = teamCount
                        'Adds the team to the listbox
                        ListDisplayPar.Items.Add(txtParName.Text & " Team")

                    Else
                        'Personalised message for when max num teams been added
                        MsgBox("Max number of teams has been reached.")
                    End If

                End If
            End If
        Else
            MsgBox("Please enter the name of the individual")
        End If
        'Clears textbox for teamn/player name
        txtParName.Text = ""
        'Clear textboxes for player names
        txtTeamMem1.Text = ""
        txtTeamMem2.Text = ""
        txtTeamMem3.Text = ""
        txtTeamMem4.Text = ""
        txtTeamMem5.Text = ""
    End Sub

    Private Sub frmSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblIndEventsNum.Text = IEventCount
        lblTeamEventsNum.Text = TEventCount
        lblIndSoFarNum.Text = indCount
        lblTeamSoFarNum.Text = teamCount
        'Clears text boxes
        txtName.Text = ""
        txtDescription.Text = ""
        ' txtPartName.Text = ""
        'Clears list box
        listDisplayEvent.Items.Clear()
        '   lstPartAdded.Items.Clear()

        'Check if any events have been added
        If IEventCount <> 0 Then
            'Adds events to listbox
            For i = 0 To IEventCount - 1
                listDisplayEvent.Items.Add(IEvent(i).EName & " Ind")
            Next
        End If
        If TEventCount <> 0 Then
            For i = 0 To TEventCount - 1
                listDisplayEvent.Items.Add(TEvent(i).EName & " Team")
            Next
        End If
        If indCount <> 0 Then
            'Adds participants to listbox
            For i = 0 To indCount - 1
                ListDisplayPar.Items.Add(ind(i).iName & " Ind")
            Next
        End If
        If teamCount <> 0 Then
            For i = 0 To teamCount - 1
                ListDisplayPar.Items.Add(team(i).TName & " Team")
            Next
        End If

    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub lblDisplayResult_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub rdoInd_CheckedChanged(sender As Object, e As EventArgs) Handles rdoInd.CheckedChanged

    End Sub

    Private Sub rdoIndPar_CheckedChanged(sender As Object, e As EventArgs) Handles rdoIndPar.CheckedChanged
        'If individual participant selected, hide the following
        If rdoIndPar.Checked = True Then
            txtTeamMem1.Visible = False
            txtTeamMem2.Visible = False
            txtTeamMem3.Visible = False
            txtTeamMem4.Visible = False
            txtTeamMem5.Visible = False
            lblTeamMembers.Visible = False
            'If Team selected, show the following
        Else
            txtTeamMem1.Visible = True
            txtTeamMem2.Visible = True
            txtTeamMem3.Visible = True
            txtTeamMem4.Visible = True
            txtTeamMem5.Visible = True
            lblTeamMembers.Visible = True
        End If
    End Sub

    Private Sub btnAddPar_Click(sender As Object, e As EventArgs) Handles btnAddPar.Click
        'Checks that the details are correctly completed
        If txtParName.Text <> "" Then

            If rdoIndPar.Checked = True Then
                If indCount < 20 Then
                    ind(indCount).iName = txtParName.Text
                    ind(indCount).iResult = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
                    indCount += 1
                    lblIndSoFarNum.Text = indCount
                    ListDisplayPar.Items.Add(txtParName.Text & " Ind")
                Else

                    MsgBox("Max number of individual players has been reached.")
                End If
            End If
            'checks the radio button for Team selected
            If rdoTeamPar.Checked = True Then
                'Asks for 5 names
                If txtTeamMem1.Text = "" Or txtTeamMem2.Text = "" Or txtTeamMem3.Text = "" Or txtTeamMem4.Text = "" Or txtTeamMem5.Text = "" Then
                    MsgBox("Please enter 5 names for the team")
                Else
                    'Checks that there are less than 4 teams
                    If teamCount < 4 Then
                        'Team name
                        team(teamCount).TName = txtParName.Text
                        'Team members
                        team(teamCount).TPlayerName = {txtTeamMem1.Text, txtTeamMem2.Text, txtTeamMem3.Text, txtTeamMem4.Text, txtTeamMem5.Text}
                        'Increases the team count since a team has been added.
                        team(teamCount).TResult = {0, 0, 0, 0, 0}
                        teamCount += 1
                        lblTeamSoFarNum.Text = teamCount
                        'Adds the team to the listbox
                        ListDisplayPar.Items.Add(txtParName.Text & " Team")

                    Else
                        'Personalised message for when max num teams been added
                        MsgBox("Max number of teams has been reached.")
                    End If

                End If
            End If
        Else
            MsgBox("Please enter the name of the individual")
        End If
        'Clears textbox for teamn/player name
        txtParName.Text = ""
        'Clear textboxes for player names
        txtTeamMem1.Text = ""
        txtTeamMem2.Text = ""
        txtTeamMem3.Text = ""
        txtTeamMem4.Text = ""
        txtTeamMem5.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub rdoTeam_CheckedChanged(sender As Object, e As EventArgs) Handles rdoTeam.CheckedChanged

    End Sub

    Private Sub rdoTeamPar_CheckedChanged(sender As Object, e As EventArgs) Handles rdoTeamPar.CheckedChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles selectedcheckbox.CheckedChanged
        If selectedcheckbox.Checked Then
            eventscombo.Visible = True
            lblSelectiveEvents.Visible = True
            'If Team selected, show the following
        Else
            eventscombo.Visible = False
            lblSelectiveEvents.Visible = False
        End If
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub customcheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles customcheckbox.CheckedChanged
        If customcheckbox.Checked = True Then
            eventscombo.Visible = False
            lblSelectiveEvents.Visible = False
            'If Team selected, show the following
        Else
            eventscombo.Visible = True
            lblSelectiveEvents.Visible = True
        End If
    End Sub
End Class
