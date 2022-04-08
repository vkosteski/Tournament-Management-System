
Public Class frmMenu
    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStartNewTournament.Click
        Me.Hide()
        frmSetup.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnResultAnalysis.Click
        Me.Hide()
        frmAnalysis.Show()
    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btnLoadEventData.Click
        Dim i As Byte

        'populate team events

        TEvent(0).EName = "Dancing"
        TEvent(1).EName = "Acrobatics"
        TEvent(2).EName = "Bridge"
        TEvent(3).EName = "Scrabble"
        TEvent(4).EName = "Volleyball"
        'populate individual events
        IEvent(0).EName = "Solo Dancing"
        IEvent(1).EName = "Solo Acrobatics"
        IEvent(2).EName = "Tiddlywinks"
        IEvent(3).EName = "Space invaders"
        IEvent(4).EName = "Spelling"

        TEventCount = 5
        IEventCount = 5
        indCount = 20
        teamCount = 4

        'populate individuals
        For i = 0 To 19
            ind(i).iName = "Player" & i + 1
            ind(i).iEvent = {IEvent(0).EName, IEvent(1).EName, IEvent(2).EName, IEvent(3).EName, IEvent(4).EName}
            ind(i).iResult = {0, 0, 0, 0, 0}
        Next i

        'populate teams
        For i = 0 To 3
            team(i).TName = "Team " & Chr(65 + i)
            team(i).TPlayerName = {"Team " & Chr(65 + i) & " - Player1",
                                   "Team " & Chr(65 + i) & " - Player2",
                                   "Team " & Chr(65 + i) & " - Player3",
                                   "Team " & Chr(65 + i) & " - Player4",
                                   "Team " & Chr(65 + i) & " - Player5"}
            team(i).TEvent = {TEvent(0).EName, TEvent(1).EName, TEvent(2).EName, TEvent(3).EName, TEvent(4).EName}
            team(i).TResult = {0, 0, 0, 0, 0}
        Next i
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnTeamRankings_Click(sender As Object, e As EventArgs) Handles btnTeamRankings.Click
        Me.Hide()
        frmRankings.Show()
    End Sub
End Class


