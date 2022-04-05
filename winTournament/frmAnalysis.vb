Public Class frmAnalysis
    Private Sub Button1_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub cboIndEveResults_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboIndEveResults.SelectedIndexChanged

        lstIndEveResults.Items.Clear()
        'Selects correct case to add results to listbox
        Select Case cboIndEveResults.SelectedIndex
            Case 0
                For i = 0 To 19
                    lstIndEveResults.Items.Add(Format(ind(i).iResult(0), "00") & " " & ind(i).iName)
                Next i
            Case 1
                For i = 0 To 19
                    lstIndEveResults.Items.Add(Format(ind(i).iResult(1), "00") & " " & ind(i).iName)
                Next i
            Case 2
                For i = 0 To 19
                    lstIndEveResults.Items.Add(Format(ind(i).iResult(2), "00") & " " & ind(i).iName)
                Next i
            Case 3
                For i = 0 To 19
                    lstIndEveResults.Items.Add(Format(ind(i).iResult(3), "00") & " " & ind(i).iName)
                Next i
            Case 4
                For i = 0 To 19
                    lstIndEveResults.Items.Add(Format(ind(i).iResult(4), "00") & " " & ind(i).iName)
                Next i
        End Select
    End Sub

    Private Sub btnSortIndEveRes_Click(sender As Object, e As EventArgs) Handles btnSortIndEveRes.Click
        Dim xResults() As String = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        Dim xTemp As String
        Dim i, swaps As Integer

        'Sorts array of results by comparing what it has already sorted
        For i = 0 To lstIndEveResults.Items.Count - 1
            xResults(i) = lstIndEveResults.Items.Item(i)
        Next
        swaps = 1
        While swaps > 0
            'Swaps is set to zero, it is the counter for this loop. When the results are swapped, 1 is added meaning the while loop is > 0 and then loops again, until nothing was swapped and the while is not > 0
            swaps = 0
            For i = 0 To xResults.Count - 2
                If xResults(i) < xResults(i + 1) Then
                    xTemp = xResults(i)
                    xResults(i) = xResults(i + 1)
                    xResults(i + 1) = xTemp
                    swaps += 1
                End If
            Next

        End While

        lstIndEveResults.Items.Clear()
        For i = 0 To xResults.Count - 1
            lstIndEveResults.Items.Add(xResults(i))
        Next
    End Sub

    Private Sub frmAnalysis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Setup combo boxes
        Dim i As Byte
        ' Adds Individual events to Combo box
        For i = 0 To 4
            cboIndEveResults.Items.Add(IEvent(i).EName)
        Next i

        'Setup combo boxes
        Dim j As Byte
        ' Adds team events to Combo box
        For j = 0 To 4
            cboTeamEveRes.Items.Add(TEvent(j).EName)
        Next j

        'Clears list if there are any old results
        lstIndRes.Items.Clear()

        For x = 0 To 19
            'Setup listboxes with results
            Dim tempiresult As Integer
            tempiresult = ind(x).iResult(0) + ind(x).iResult(1) + ind(x).iResult(2) + ind(x).iResult(3) + ind(x).iResult(4)
            lstIndRes.Items.Add(Format(tempiresult, "00") & " " & ind(x).iName)
        Next x

        'Clears list if there are any old results
        lstTeamRes.Items.Clear()

        For y = 0 To 3
            'Setup listbox with adding team results
            Dim temptresult As Integer
            temptresult = team(y).TResult(0) + team(y).TResult(1) + team(y).TResult(2) + team(y).TResult(3) + team(y).TResult(4)
            lstTeamRes.Items.Add(Format(temptresult, "00") & " " & team(y).TName)
        Next y
    End Sub

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        Me.Hide()
        frmMenu.Show()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTeamRes.SelectedIndexChanged

    End Sub

    Private Sub cboTeamEveRes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTeamEveRes.SelectedIndexChanged
        lstTeamEveRes.Items.Clear()
        'Selects correct case to add results to listbox

        Select Case cboTeamEveRes.SelectedIndex
            Case 0
                For i = 0 To 3
                    lstTeamEveRes.Items.Add(Format(team(i).TResult(0), "00") & " " & team(i).TName)
                Next i
            Case 1
                For i = 0 To 3
                    lstTeamEveRes.Items.Add(Format(team(i).TResult(1), "00") & " " & team(i).TName)
                Next i
            Case 2
                For i = 0 To 3
                    lstTeamEveRes.Items.Add(Format(team(i).TResult(2), "00") & " " & team(i).TName)
                Next i
            Case 3
                For i = 0 To 3
                    lstTeamEveRes.Items.Add(Format(team(i).TResult(3), "00") & " " & team(i).TName)
                Next i
            Case 4
                For i = 0 To 3
                    lstTeamEveRes.Items.Add(Format(team(i).TResult(4), "00") & " " & team(i).TName)
                Next i
        End Select
    End Sub

    Private Sub btnSortTeamEveRes_Click(sender As Object, e As EventArgs) Handles btnSortTeamEveRes.Click
        Dim xResults() As String = {0, 0, 0, 0}
        Dim xTemp As String
        Dim i, swaps As Integer

        'Sorts array of results by comparing what it has already sorted
        For i = 0 To lstTeamEveRes.Items.Count - 1
            xResults(i) = lstTeamEveRes.Items.Item(i)
        Next
        swaps = 1
        While swaps > 0
            'Swaps is set to zero, it is the counter for this loop. When the results are swapped, 1 is added meaning the while loop is > 0 and then loops again, until nothing was swapped and the while is not > 0
            swaps = 0
            For i = 0 To xResults.Count - 2
                If xResults(i) < xResults(i + 1) Then
                    xTemp = xResults(i)
                    xResults(i) = xResults(i + 1)
                    xResults(i + 1) = xTemp
                    swaps += 1
                End If
            Next

        End While

        lstTeamEveRes.Items.Clear()
        For i = 0 To xResults.Count - 1
            lstTeamEveRes.Items.Add(xResults(i))
        Next
    End Sub

    Private Sub btnSortIndRes_Click(sender As Object, e As EventArgs) Handles btnSortIndRes.Click
        Dim xResults() As String = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        Dim xTemp As String
        Dim i, swaps As Integer

        For i = 0 To lstIndRes.Items.Count - 1
            xResults(i) = lstIndRes.Items.Item(i)
        Next
        swaps = 1
        While swaps > 0
            swaps = 0
            For i = 0 To xResults.Count - 2
                If xResults(i) < xResults(i + 1) Then
                    xTemp = xResults(i)
                    xResults(i) = xResults(i + 1)
                    xResults(i + 1) = xTemp
                    swaps += 1
                End If
            Next

        End While

        lstIndRes.Items.Clear()
        For i = 0 To xResults.Count - 1
            lstIndRes.Items.Add(xResults(i))
        Next
    End Sub

    Private Sub btnSortTeamRes_Click(sender As Object, e As EventArgs) Handles btnSortTeamRes.Click
        Dim xResults() As String = {0, 0, 0, 0}
        Dim xTemp As String
        Dim i, swaps As Integer

        For i = 0 To lstTeamRes.Items.Count - 1
            xResults(i) = lstTeamRes.Items.Item(i)
        Next
        swaps = 1
        While swaps > 0
            swaps = 0
            For i = 0 To xResults.Count - 2
                If xResults(i) < xResults(i + 1) Then
                    xTemp = xResults(i)
                    xResults(i) = xResults(i + 1)
                    xResults(i + 1) = xTemp
                    swaps += 1
                End If
            Next

        End While

        lstTeamRes.Items.Clear()
        For i = 0 To xResults.Count - 1
            lstTeamRes.Items.Add(xResults(i))
        Next
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub
End Class