﻿Module Globals
    Structure IndividualPlayerType
        Dim iName As String
        Dim iEvent() As String
        Dim iResult() As Integer
        Dim iOneEventer As Boolean
    End Structure
    Structure TeamPlayerType
        Dim TName As String
        Dim TPlayerName() As String
        Dim TEvent() As String
        Dim TResult() As Integer
        Dim TOneEventer As Boolean
    End Structure
    Structure TournamentEventsType
        Dim EName As String
        Dim EDesc As String
    End Structure

    Public ind(19) As IndividualPlayerType
    Public team(3) As TeamPlayerType
    Public TEvent(5) As TournamentEventsType
    Public IEvent(5) As TournamentEventsType
    Public TEventCount As Byte = 0
    Public IEventCount As Byte = 0
    Public indCount As Byte = 0
    Public teamCount As Byte = 0
End Module