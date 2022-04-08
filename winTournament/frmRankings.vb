Public Class frmRankings
    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles txtPlayer7.TextChanged

    End Sub

    Private Sub frmRankings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Setup labels as an array
        Dim playLabels As New List(Of Control)() From {
                lblPlayer1,
                lblPlayer2,
                lblPlayer3,
                lblPlayer4,
                lblPlayer5,
                lblPlayer6,
                lblPlayer7,
                lblPlayer8,
                lblPlayer9,
                lblPlayer10,
                lblPlayer11,
                lblPlayer12,
                lblPlayer13,
                lblPlayer14,
                lblPlayer15,
                lblPlayer16,
                lblPlayer17,
                lblPlayer18,
                lblPlayer19,
                lblPlayer20}

        'Setup textboxes as an array
        Dim textBoxes As New List(Of Control)() From {
        txtPlayer1,
        txtPlayer2,
        txtPlayer3,
        txtPlayer4,
        txtPlayer5,
        txtPlayer6,
        txtPlayer7,
        txtPlayer8,
        txtPlayer9,
        txtPlayer10,
        txtPlayer11,
        txtPlayer12,
        txtPlayer13,
        txtPlayer14,
        txtPlayer15,
        txtPlayer16,
        txtPlayer17,
        txtPlayer18,
        txtPlayer19,
        txtPlayer20}




        'Adds labels with names of individual participants

        For i As Integer = 0 To playLabels.Count - 1
            playLabels(i).Text = ind(i).iName
        Next i


        'Adds individual events combobox
        For i = 0 To 4
            cboIndEvents.Items.Add(IEvent(i).EName)
        Next i

        'Adds team names to labels
        lblTeam.Text = team(0).TName
        lblTeam2.Text = team(1).TName
        lblTeam3.Text = team(2).TName
        lblTeam4.Text = team(3).TName

        'Adds team events to combo box
        For i = 0 To 4
            cboTeamEvents.Items.Add(TEvent(i).EName)
        Next i

    End Sub

    Private Sub btnSaveInd_Click(sender As Object, e As EventArgs) Handles btnSaveInd.Click
        'Setup arrays
        Dim playLabels As New List(Of Control)() From {
                lblPlayer1,
                lblPlayer2,
                lblPlayer3,
                lblPlayer4,
                lblPlayer5,
                lblPlayer6,
                lblPlayer7,
                lblPlayer8,
                lblPlayer9,
                lblPlayer10,
                lblPlayer11,
                lblPlayer12,
                lblPlayer13,
                lblPlayer14,
                lblPlayer15,
                lblPlayer16,
                lblPlayer17,
                lblPlayer18,
                lblPlayer19,
                lblPlayer20
        }

        'Setup arrays
        Dim textBoxes As New List(Of Control)() From {
        txtPlayer1,
        txtPlayer2,
        txtPlayer3,
        txtPlayer4,
        txtPlayer5,
        txtPlayer6,
        txtPlayer7,
        txtPlayer8,
        txtPlayer9,
        txtPlayer10,
        txtPlayer11,
        txtPlayer12,
        txtPlayer13,
        txtPlayer14,
        txtPlayer15,
        txtPlayer16,
        txtPlayer17,
        txtPlayer18,
        txtPlayer19,
        txtPlayer20}

        'Declare the variables
        'i is a counter for the text boxes
        Dim i As Integer
        'Bool value to decide (currently false) until invalid number input
        Dim xInvalid As Boolean
        'Used to store each number as it is checked
        Dim test As Integer


        i = 0
        xInvalid = False
        'Loop the textbox values to check they are between 1 & 20
        While i < textBoxes.Count And xInvalid = False

            test = CInt(textBoxes(i).Text)
            If test < 1 Or test > 20 Then
                MsgBox("Please enter a number between 1 and 20" &
                       playLabels(i).Text & " is invalid",
                       MsgBoxStyle.Critical, "Error!")
                xInvalid = True

            End If
            i += 1
        End While
        'Select case dependant what is visible in the combo box
        'For loops to store results from textbox
        If xInvalid = False Then
            Select Case cboIndEvents.SelectedIndex
                Case 0
                    For i = 0 To textBoxes.Count - 1
                        ind(i).iResult(0) = CInt(textBoxes(i).Text)
                    Next
                Case 1
                    For i = 0 To textBoxes.Count - 1
                        ind(i).iResult(1) = CInt(textBoxes(i).Text)
                    Next
                Case 2
                    For i = 0 To textBoxes.Count - 1
                        ind(i).iResult(2) = CInt(textBoxes(i).Text)
                    Next
                Case 3
                    For i = 0 To textBoxes.Count - 1
                        ind(i).iResult(3) = CInt(textBoxes(i).Text)
                    Next
                Case 4
                    For i = 0 To textBoxes.Count - 1
                        ind(i).iResult(4) = CInt(textBoxes(i).Text)
                    Next
            End Select
        End If

        'Once results are saved, the text-boxes will go blank again to show they have saved.
        For i = 0 To textBoxes.Count - 1
            textBoxes(i).Text = ""
        Next
    End Sub

    Private Sub btnSaveTeam_Click(sender As Object, e As EventArgs) Handles btnSaveTeam.Click
        'Setup arrays
        Dim playLabels As New List(Of Control)() From {
      lblTeam,
      lblTeam2,
      lblTeam3,
      lblTeam4}


        Dim textBoxes As New List(Of Control)() From {
        txtTeam,
        txtTeam2,
        txtTeam3,
        txtTeam4}

        'Declare the variables
        'i is a counter for the text boxes
        Dim i As Integer
        'Bool value to decide (currently false) until invalid number input
        Dim xInvalid As Boolean
        'Used to store each number as it is checked
        Dim test As Integer

        i = 0
        xInvalid = False
        'Loop the textbox values to check they are between 1 & 4
        While i < textBoxes.Count And xInvalid = False

            test = CInt(textBoxes(i).Text)
            If test < 1 Or test > 4 Then
                MsgBox("Please enter a number between 1 and 4" &
                       playLabels(i).Text & " is invalid",
                       MsgBoxStyle.Critical, "Error!")
                xInvalid = True

            End If
            i += 1
        End While



        If xInvalid = False Then
            'Select case dependant what is visible in the combo box
            'For loops to store results from textbox
            Select Case cboTeamEvents.SelectedIndex
                Case 0
                    For i = 0 To textBoxes.Count - 1
                        team(i).TResult(0) = CInt(textBoxes(i).Text)
                    Next
                Case 1
                    For i = 0 To textBoxes.Count - 1
                        team(i).TResult(1) = CInt(textBoxes(i).Text)
                    Next
                Case 2
                    For i = 0 To textBoxes.Count - 1
                        team(i).TResult(2) = CInt(textBoxes(i).Text)
                    Next
                Case 3
                    For i = 0 To textBoxes.Count - 1
                        team(i).TResult(3) = CInt(textBoxes(i).Text)
                    Next
                Case 4
                    For i = 0 To textBoxes.Count - 1
                        team(i).TResult(4) = CInt(textBoxes(i).Text)
                    Next
            End Select
        End If

        'Once results are saved, the text-boxes will go blank again to show they have saved.
        For i = 0 To textBoxes.Count - 1
            textBoxes(i).Text = ""
        Next
    End Sub

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        Me.Hide()
        frmMenu.Show()
    End Sub

    Private Sub cboIndEvents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboIndEvents.SelectedIndexChanged

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub
End Class