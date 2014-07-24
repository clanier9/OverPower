Imports System
Imports System.IO
Imports System.Media

Public Class DeckCards

    Public Function LoadTableCards(deckFile As String)
        Dim sr As New StreamReader(deckFile)
        Dim line As String
        Dim cardsByID As New Collection

        line = sr.ReadLine
        If line = "[CHARACTERS]" Then
            line = sr.ReadLine
            Do Until line = "[HOMEBASE]"
                cardsByID.Add(CType(line, Integer))
                line = sr.ReadLine
            Loop
        End If

        If line = "[HOMEBASE]" Then
            line = sr.ReadLine
            Do Until line = "[BATTLESITE]"
                Try
                    cardsByID.Add(CType(line, Integer), "Homebase")
                Catch

                End Try
                line = sr.ReadLine
            Loop
        End If

        If line = "[BATTLESITE]" Then
            line = sr.ReadLine
            Do Until line = "[MISSIONS]"
                Try
                    cardsByID.Add(CType(line, Integer), "Battlesite")
                Catch

                End Try
                line = sr.ReadLine
            Loop
        End If

        Return cardsByID
    End Function

    Public Function LoadMissionCards(deckFile As String)
        Dim sr As New StreamReader(deckFile)
        Dim line As String
        Dim mID As New Integer

        line = sr.ReadLine
        Do Until line = "[MISSIONS]"
            line = sr.ReadLine
        Loop

        If line = "[MISSIONS]" Then
            line = sr.ReadLine
            Do Until line = "[ASPECTS]"
                mID = (CType(line, Integer))
                line = sr.ReadLine
            Loop
        End If

        Return mID
    End Function

    Public Function LoadDeck(deckFile As String)
        frmLoading.Text = "Reading deck file..."

        Dim sr As New StreamReader(deckFile)
        Dim line As String
        Dim cards As New Collection

        Dim asp As Aspect
        Dim sp As Special
        Dim pc As PowerCard
        Dim bu As BasicUniverse
        Dim tr As Training
        Dim tw As Teamwork
        Dim ally As Ally
        Dim dblshot As Doubleshot
        Dim art As Artifact
        Dim ev As MissionEvent
        Dim character As Character

        Dim id As Integer

        line = sr.ReadLine
        Do Until line = "[ASPECTS]"
            line = sr.ReadLine
        Loop

        While frmLoading.SplitContainer1.SplitterDistance < 45
            frmLoading.SplitContainer1.SplitterDistance += 1
        End While
        frmLoading.Text = "Loading aspects..."

        If line = "[ASPECTS]" Then
            line = sr.ReadLine
            Do Until line = "[SPECIALS]"
                id = CType(line, Integer)
                asp = New Aspect(id)
                cards.Add(asp)
                line = sr.ReadLine
            Loop
        End If

        While frmLoading.SplitContainer1.SplitterDistance < 50
            frmLoading.SplitContainer1.SplitterDistance += 1
        End While
        frmLoading.Text = "Loading specials..."

        If line = "[SPECIALS]" Then
            line = sr.ReadLine
            Do Until line = "[POWER CARDS]"
                id = CType(line, Integer)
                sp = New Special(id)
                cards.Add(sp)
                line = sr.ReadLine
            Loop
        End If

        While frmLoading.SplitContainer1.SplitterDistance < 65
            frmLoading.SplitContainer1.SplitterDistance += 1
        End While
        frmLoading.Text = "Loading power cards..."

        If line = "[POWER CARDS]" Then
            line = sr.ReadLine
            Do Until line = "[BASIC UNIVERSE]"
                id = CType(line, Integer)
                pc = New PowerCard(id)
                cards.Add(pc)
                line = sr.ReadLine
            Loop
        End If

        While frmLoading.SplitContainer1.SplitterDistance < 80
            frmLoading.SplitContainer1.SplitterDistance += 1
        End While
        frmLoading.Text = "Loading universe cards..."

        If line = "[BASIC UNIVERSE]" Then
            line = sr.ReadLine
            Do Until line = "[TRAINING]"
                id = CType(line, Integer)
                bu = New BasicUniverse(id)
                cards.Add(bu)
                line = sr.ReadLine
            Loop
        End If

        If line = "[TRAINING]" Then
            line = sr.ReadLine
            Do Until line = "[TEAMWORK]"
                id = CType(line, Integer)
                tr = New Training(id)
                cards.Add(tr)
                line = sr.ReadLine
            Loop
        End If

        If line = "[TEAMWORK]" Then
            line = sr.ReadLine
            Do Until line = "[ALLY CARDS]"
                id = CType(line, Integer)
                tw = New Teamwork(id)
                cards.Add(tw)
                line = sr.ReadLine
            Loop
        End If

        If line = "[ALLY CARDS]" Then
            line = sr.ReadLine
            Do Until line = "[DOUBLE SHOTS]"
                id = CType(line, Integer)
                ally = New Ally(id)
                cards.Add(ally)
                line = sr.ReadLine
            Loop
        End If

        While frmLoading.SplitContainer1.SplitterDistance < 95
            frmLoading.SplitContainer1.SplitterDistance += 1
        End While
        frmLoading.Text = "Loading tactic and artifact cards..."

        If line = "[DOUBLE SHOTS]" Then
            line = sr.ReadLine
            Do Until line = "[ARTIFACTS]"
                id = CType(line, Integer)
                dblshot = New Doubleshot(id)
                cards.Add(dblshot)
                line = sr.ReadLine
            Loop
        End If

        If line = "[ARTIFACTS]" Then
            line = sr.ReadLine
            Do Until line = "[EVENTS]"
                id = CType(line, Integer)
                art = New Artifact(id)
                cards.Add(art)
                line = sr.ReadLine
            Loop
        End If

        While frmLoading.SplitContainer1.SplitterDistance < 100
            frmLoading.SplitContainer1.SplitterDistance += 1
        End While
        frmLoading.Text = "Loading events and activators cards..."

        If line = "[EVENTS]" Then
            line = sr.ReadLine
            Do Until line = "[ACTIVATORS]"
                id = CType(line, Integer)
                ev = New MissionEvent(id)
                cards.Add(ev)
                line = sr.ReadLine
            Loop
        End If

        If line = "[ACTIVATORS]" Then
            line = sr.ReadLine
            Do Until line = "[BATTLESITE DECK]"
                id = CType(line, Integer)
                character = New Character(id)
                cards.Add(character)
                line = sr.ReadLine
            Loop
        End If

        While frmLoading.SplitContainer1.SplitterDistance < 110
            frmLoading.SplitContainer1.SplitterDistance += 1
        End While
        frmLoading.Text = "Finished loading deck..."

        cards = ShuffleCards(cards)

        Return cards

        'Catch ex As Exception
        '    ' Let the user know what went wrong.
        '    Console.WriteLine("The file could not be read:")
        '    Console.WriteLine(ex.Message)
        'End Try

    End Function

    Public Function LoadBSdeck(deckFile As String)

        Dim sr As New StreamReader(deckFile)
        Dim line As String
        Dim bsDeck As New Collection

        Dim sp As Special

        Dim id As Integer

        line = sr.ReadLine
        Do Until line = "[BATTLESITE DECK]"
            line = sr.ReadLine
        Loop

        While frmLoading.SplitContainer1.SplitterDistance < 135
            frmLoading.SplitContainer1.SplitterDistance += 2
        End While

        If line = "[BATTLESITE DECK]" Then
            line = sr.ReadLine
            Do Until line = ""
                id = CType(line, Integer)
                sp = New Special(id)
                bsDeck.Add(sp)
                line = sr.ReadLine
            Loop
        End If

        Return bsDeck
    End Function

    Public Function ShuffleCards(tempDeck As Collection)
        'Dim tempDeck As Collection = cards
        Dim count As Integer
        Dim lastCard As New Object
        Dim moveCard As Integer

        'stuff for sound
        Dim a As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
        Dim s As System.IO.Stream = a.GetManifestResourceStream("OverPower.shuffle.wav")
        Dim player As SoundPlayer = New SoundPlayer(s)
        player.Play()

        Randomize()
        For shuffleCount = 1 To 3
            count = tempDeck.Count
            For i = 1 To tempDeck.Count
                moveCard = CInt(Int(((count - 1 + 1) * Rnd()) + 1))
                tempDeck.Add(tempDeck(moveCard))
                tempDeck.Remove(moveCard)
                count -= 1
            Next
        Next

        Return tempDeck
    End Function
End Class
