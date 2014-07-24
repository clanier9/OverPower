Imports System.Net.Sockets
Imports System.Net
Imports System.Text
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Threading
Imports System.Drawing.Graphics
Imports System.Drawing.Text
Imports System.Configuration
Imports System.Media

Public Class OverPowerOnline
    'create the card collections to work with
    Dim tableCards As New Collection
    Dim charCards As New Collection
    Dim oChars As New Collection
    Dim missionCards As New Collection
    Dim oppMissionCards As New Collection
    Public myDeckCards As New Collection
    Public oppDeckCards As New Collection
    Public myBsDeck As New Collection
    Public OppBsDeck As New Collection
    Public handCards As New Collection
    Public oppHandCards As New Collection
    Public powerP As New Collection
    Public deadP As New Collection
    Public dChars As New Collection
    Public oppPowerP As New Collection
    Public oppDeadP As New Collection
    Public oppDChars As New Collection
    Dim placeCards As New Collection
    Dim placeCards1 As New Collection
    Dim placeCards2 As New Collection
    Dim placeCards3 As New Collection
    Dim placeCards4 As New Collection
    Dim placeCardsH As New Collection
    Dim playCards As New Collection
    Dim playCards1 As New Collection
    Dim playCards2 As New Collection
    Dim playCards3 As New Collection
    Dim playCards4 As New Collection
    Dim playCardsH As New Collection
    Dim hitCards As New Collection
    Dim hitCards1 As New Collection
    Dim hitCards2 As New Collection
    Dim hitCards3 As New Collection
    Dim hitCards4 As New Collection
    Dim hitCardsB As New Collection
    Dim permCards As New Collection
    Dim permCards1 As New Collection
    Dim permCards2 As New Collection
    Dim permCards3 As New Collection
    Dim permCards4 As New Collection
    Dim permCardsB As New Collection
    Dim AttackCards As New Collection
    Dim DefendCards As New Collection
    Dim ReserveCards As New Collection
    Dim CompletedCards As New Collection
    Dim DefeatedCards As New Collection
    Dim vReserveCards As New Collection
    Dim vCompletedCards As New Collection
    Dim oppPlaceCards As New Collection
    Dim oppPlaceCards1 As New Collection
    Dim oppPlaceCards2 As New Collection
    Dim oppPlaceCards3 As New Collection
    Dim oppPlaceCards4 As New Collection
    Dim oppPlaceCardsH As New Collection
    Dim oppPlayCards As New Collection
    Dim oppPlayCards1 As New Collection
    Dim oppPlayCards2 As New Collection
    Dim oppPlayCards3 As New Collection
    Dim oppPlayCards4 As New Collection
    Dim oppPlayCardsH As New Collection
    Dim oppHitCards As New Collection
    Dim oppHitCards1 As New Collection
    Dim oppHitCards2 As New Collection
    Dim oppHitCards3 As New Collection
    Dim oppHitCards4 As New Collection
    Dim oppHitCardsB As New Collection
    Dim oppPermCards As New Collection
    Dim oppPermCards1 As New Collection
    Dim oppPermCards2 As New Collection
    Dim oppPermCards3 As New Collection
    Dim oppPermCards4 As New Collection
    Dim oppPermCardsB As New Collection
    Dim oppReserveCards As New Collection
    Dim oppCompletedCards As New Collection
    Dim oppDefeatedCards As New Collection
    Dim oppVReserveCards As New Collection
    Dim oppVCompletedCards As New Collection
    Dim actUsuables As New Collection

    'other necessary variables
    Dim deck As New DeckCards
    Dim deckFile As String
    Public HandCardSize As Size
    Public HandCardLeft As Integer
    Public HandCardLeftLeft As Integer
    Public HandCardTop As Integer
    Dim SmallCardSize As Size
    Dim PlaceCardsTop As Integer
    Dim PlaceCardsBackTop As Integer
    Dim PlayCardsTop As Integer
    Dim PlayCardsBackTop As Integer
    Dim HitCardsTop As Integer
    Dim HitCardsBackTop As Integer
    Dim PermCardsTop As Integer
    Dim PermCardsBackTop As Integer
    Dim OppPlaceCardsTop As Integer
    Dim OppPlaceCardsBackTop As Integer
    Dim OppPlayCardsTop As Integer
    Dim OppPlayCardsBackTop As Integer
    Dim OppHitCardsTop As Integer
    Dim OppHitCardsBackTop As Integer
    Dim OppPermCardsTop As Integer
    Dim OppPermCardsBackTop As Integer
    Dim gameCount As Integer = 0
    Dim inGame As Boolean = False
    Public inPP As Boolean = False
    Public oppInPP = False
    Dim tempCard As New Object
    Dim tempCharX As New Object
    Dim tempChar As New Object
    Dim tempChar2 As New Object
    Dim clicks As Boolean = False
    Dim doneLoading = False
    Dim HostingIP As String
    Public Host As Boolean
    Dim Connected As Boolean = False
    Public UID As String
    Public OUID As String
    Dim wfc As String = "Waiting for opponent to connect."
    Dim attackTo As String
    Dim attackFrom As String
    Dim myTotalVenture As Integer = 0
    Dim oppTotalVenture As Integer = 0
    Public rotated As Boolean = False
    Public rotatedo As Boolean = False
    Dim cardBacks As Image
    Public done As Boolean = False
    Public meFirst As Boolean = False
    Dim deckReceived As Boolean = False
    Dim deckLoaded As Boolean = False
    Dim WGF As Boolean = False
    Public Pass As Boolean = False
    Dim DrawNum As Integer = 8
    Dim OppDrawNum As Integer = 8
    Dim oppDoneLoadingDeck As Boolean = False
    Public oppWGFopen As Boolean
    Public StifleDraw As Boolean
    Private StifleHits = False
    Public gender As String = "his"
    Public oppGender As String = "his"
    Dim faceDown As Boolean = False
    Dim NumOfKOs As Integer = 0
    Dim remainingDraws = 0
    Dim FollowUp = False

    Dim mcolClients As New Hashtable()
    Dim mobjListener As TcpListener
    Dim mobjThread As Threading.Thread
    Public mobjClient As TcpClient
    Dim arData(3145728) As Byte
    '
    '
    'put invisible table cards into the collections
    Private Sub OverpowerOnline_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'add table cards to collection
        'index 1-12 are character cards
        tableCards.Add(Character1, "Character1")
        tableCards.Add(Character2, "Character2")
        tableCards.Add(Character3, "Character3")
        tableCards.Add(Character4, "Character4")
        tableCards.Add(Battlesite, "Battlesite")
        tableCards.Add(Homebase, "Homebase")
        tableCards.Add(OppCharacter1, "OppCharacter1")
        tableCards.Add(OppCharacter2, "OppCharacter2")
        tableCards.Add(OppCharacter3, "OppCharacter3")
        tableCards.Add(OppCharacter4, "OppCharacter4")
        tableCards.Add(OppBattlesite, "OppBattlesite")
        tableCards.Add(OppHomebase, "OppHomebase")
        'index 13-22 are mission cards
        tableCards.Add(Completed, "Completed")
        tableCards.Add(Reserve, "Reserve")
        tableCards.Add(Defeated, "Defeated")
        tableCards.Add(VentureC, "VentureC")
        tableCards.Add(VentureR, "VentureR")
        tableCards.Add(OppCompleted, "OppCompleted")
        tableCards.Add(OppReserve, "OppReserve")
        tableCards.Add(OppDefeated, "OppDefeated")
        tableCards.Add(OppVentureC, "OppVentureC")
        tableCards.Add(OppVentureR, "OppVentureR")
        'index 23-30 are draws and discards
        tableCards.Add(DrawPile, "Draw Pile")
        tableCards.Add(DeadPile, "DeadPile")
        tableCards.Add(PowerPack, "PowerPack")
        tableCards.Add(DefeatedChars, "DefeatedChars")
        tableCards.Add(OppDrawPile, "OppDraw Pile")
        tableCards.Add(OppDeadPile, "OppDeadPile")
        tableCards.Add(OppPowerPack, "OppPowerPack")
        tableCards.Add(OppDefeatedChars, "OppDefeatedChars")
        'index 31-32 are events
        tableCards.Add(Event1, "Event1")
        tableCards.Add(Event2, "Event2")

        missionCards.Add(Mission1)
        missionCards.Add(Mission2)
        missionCards.Add(Mission3)
        missionCards.Add(Mission4)
        missionCards.Add(Mission5)
        missionCards.Add(Mission6)
        missionCards.Add(Mission7)
        oppMissionCards.Add(Mission14)
        oppMissionCards.Add(Mission13)
        oppMissionCards.Add(Mission12)
        oppMissionCards.Add(Mission11)
        oppMissionCards.Add(Mission10)
        oppMissionCards.Add(Mission9)
        oppMissionCards.Add(Mission8)

        For Each card In missionCards
            ReserveCards.Add(card)
        Next

        placeCards.Add(placeCards1)
        placeCards.Add(placeCards2)
        placeCards.Add(placeCards3)
        placeCards.Add(placeCards4)
        placeCards.Add(placeCardsH)
        playCards.Add(playCards1)
        playCards.Add(playCards2)
        playCards.Add(playCards3)
        playCards.Add(playCards4)
        playCards.Add(playCardsH)
        hitCards.Add(hitCards1)
        hitCards.Add(hitCards2)
        hitCards.Add(hitCards3)
        hitCards.Add(hitCards4)
        hitCards.Add(hitCardsB)
        permCards.Add(permCards1)
        permCards.Add(permCards2)
        permCards.Add(permCards3)
        permCards.Add(permCards4)
        permCards.Add(permCardsB)

        oppPlaceCards.Add(oppPlaceCards1)
        oppPlaceCards.Add(oppPlaceCards2)
        oppPlaceCards.Add(oppPlaceCards3)
        oppPlaceCards.Add(oppPlaceCards4)
        oppPlaceCards.Add(oppPlaceCardsH)
        oppPlayCards.Add(oppPlayCards1)
        oppPlayCards.Add(oppPlayCards2)
        oppPlayCards.Add(oppPlayCards3)
        oppPlayCards.Add(oppPlayCards4)
        oppPlayCards.Add(oppPlayCardsH)
        oppHitCards.Add(oppHitCards1)
        oppHitCards.Add(oppHitCards2)
        oppHitCards.Add(oppHitCards3)
        oppHitCards.Add(oppHitCards4)
        oppHitCards.Add(oppHitCardsB)
        oppPermCards.Add(oppPermCards1)
        oppPermCards.Add(oppPermCards2)
        oppPermCards.Add(oppPermCards3)
        oppPermCards.Add(oppPermCards4)
        oppPermCards.Add(oppPermCardsB)

        Dim HandCardWidth As Decimal = Character1.Width * 0.85
        Dim HandCardHeight As Decimal = HandCardWidth * 7 / 5
        Dim HCardSize As New Size(HandCardWidth, HandCardHeight)

        HandCardSize = HCardSize
        HandCardLeft = Me.Width - HandCardHeight - 25
        HandCardLeftLeft = HandCardLeft - (HandCardSize.Width / 4)
        HandCardTop = OppHomebase.Top
        SmallCardSize = Mission1.Size

        Dim path As String = Application.StartupPath + "\settings.ini"
        If File.Exists(path) = True Then
            Dim sr As StreamReader = File.OpenText(path)
            UID = sr.ReadLine
            Dim line As String
            line = sr.ReadLine
            line = sr.ReadLine
            line = sr.ReadLine
            If line = "Female" Then
                gender = "her"
            End If
        Else
            UID = "Anon"
        End If

        cardBacks = DrawPile.Image
        doneLoading = True
    End Sub
    '
    '
    'close connections
    Private Sub OverPowerOnline_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If Host = True Then
            hSendCommand("disconnect")
            mobjListener.Stop()
        Else
            If Connected = True Then
                'for now do this, since 1 to 1 connection
                cSendCommand("disconnect")
                mobjClient.Close()
            End If
        End If
    End Sub
    '
    '
    'resize
    Private Sub OverpowerOnline_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        On Error Resume Next

        'if minimized, do nothing
        If WindowState = FormWindowState.Minimized Or doneLoading = False Then
            Exit Sub
        End If

        'varibles for resizing and moving cards
        Dim wCenter As Integer = Me.Width / 2
        Dim hCenter As Integer = Me.Height / 2
        Dim CharCardWidth As Decimal = Me.Width * 0.1
        Dim CharCardHeight As Decimal = 5 / 7 * CharCardWidth
        Dim BigCardWidth As Decimal = CharCardWidth * 1.5
        Dim BigCardHeight As Decimal = BigCardWidth * 7 / 5
        Dim HandCardWidth As Decimal = CharCardWidth * 0.85
        Dim HandCardHeight As Decimal = HandCardWidth * 7 / 5

        If CharCardWidth > 168 Then
            CharCardWidth = 168
        End If

        If CharCardHeight > 120 Then
            CharCardHeight = 120
        End If

        Dim BigCardSizeV As New Size(BigCardWidth, BigCardHeight)
        Dim BigCardSizeH As New Size(BigCardHeight, BigCardWidth)
        Dim EventCardSpaceV As Decimal = CharCardHeight * 1.1
        Dim MissCardWidth As Decimal = CharCardWidth / 3
        Dim MissCardHeight As Decimal = 7 / 5 * MissCardWidth
        Dim MissCardSize As New Size(MissCardWidth, MissCardHeight)
        Dim MissCardSpaceHorz As Decimal = MissCardWidth * 0.3
        Dim MissCardSpaceVert As Decimal = MissCardHeight * 1.1
        Dim CharCardSize As New Size(CharCardWidth, CharCardHeight)
        Dim CharCardSpaceHorz As Decimal = CharCardWidth * 0.1
        Dim CharCardSpaceVert As Decimal = CharCardHeight + 20
        Dim DrawCardWidth As Decimal = MissCardWidth * 1.2
        Dim DrawCardHeight As Decimal = DrawCardWidth * 7 / 5
        Dim DrawCardSize As New Size(DrawCardWidth, DrawCardHeight)
        Dim DrawCardSpace As Decimal = DrawCardWidth * 0.2
        Dim PlayCardWidth As Decimal = DrawCardWidth * 1.1
        Dim PlayCardHeight As Decimal = PlayCardWidth * 7 / 5
        Dim HCardSize As New Size(HandCardWidth, HandCardHeight)
        Dim HandCardSpace As Decimal = HandCardHeight * 0.2
        HandCardSize = HCardSize
        HandCardLeft = Me.Width - HandCardHeight - 25
        HandCardLeftLeft = HandCardLeft - (HandCardSize.Width / 4)
        SmallCardSize = MissCardSize

        'resize and move chat and text controls
        TextOutput.Width = wCenter
        TextInput.Width = TextOutput.Width - SUBMIT.Width - 1
        TextOutput.Left = Me.Width * 0.25
        TextInput.Left = Me.Width * 0.25
        SUBMIT.Left = (Me.Width * 0.75) - SUBMIT.Width

        'resize all cards to new size
        'character cards
        For i = 1 To 12
            tableCards(i).Size = CharCardSize
        Next

        'mission cards
        For i = 13 To 22
            tableCards(i).Size = MissCardSize
        Next
        For i = 1 To 7
            missionCards(i).size = MissCardSize
        Next

        For Each card In oppMissionCards
            card.size = MissCardSize
        Next

        'draw cards
        For i = 23 To 30
            tableCards(i).Size = DrawCardSize
        Next

        'big card and events
        BigCardV.Size = BigCardSizeV
        BigCardH.Size = BigCardSizeH
        Event1.Size = CharCardSize
        Event2.Size = CharCardSize
        CurrentPhase.Width = BigCardV.Width
        Phase.Width = CurrentPhase.Width

        'move big card and events to new location
        Event1.Top = (Me.Height * 0.2) - CharCardSpaceVert
        Event2.Top = Event1.Top + EventCardSpaceV
        BigCardV.Top = Event2.Top + EventCardSpaceV
        BigCardH.Top = BigCardV.Top
        Event1.Left = BigCardH.Left
        Event2.Left = Event1.Left


        'move user table cards to new locations
        Character4.Top = TextOutput.Top - CharCardSpaceVert
        Homebase.Top = Character4.Top
        Character1.Top = Character4.Top - CharCardSpaceVert

        Character2.Top = Character1.Top
        Character3.Top = Character1.Top
        Battlesite.Top = Character1.Top

        Character1.Left = wCenter - (3 * CharCardSpaceHorz) - (2 * CharCardWidth)
        Character2.Left = wCenter - CharCardWidth - CharCardSpaceHorz
        Character3.Left = wCenter + CharCardSpaceHorz
        Battlesite.Left = wCenter + (3 * CharCardSpaceHorz) + CharCardWidth
        Character4.Left = Character2.Left
        Homebase.Left = Character3.Left

        Defeated.Top = Character4.Top + CharCardHeight - Defeated.Height
        Reserve.Top = Defeated.Top - MissCardSpaceVert
        VentureR.Top = Reserve.Top
        Completed.Top = Reserve.Top - MissCardSpaceVert
        VentureC.Top = Completed.Top
        Completed.Left = Battlesite.Left + CharCardWidth + MissCardSpaceHorz
        Reserve.Left = Completed.Left
        Defeated.Left = Reserve.Left
        VentureC.Left = Completed.Left + MissCardWidth + MissCardSpaceHorz
        VentureR.Left = VentureC.Left
        Dim j = 0
        Dim z = 0
        For Each card In missionCards
            If card.pile = "Defeated" Then
                card.Location = Defeated.Location
            ElseIf card.pile = "Reserve" Then
                card.Location = Reserve.Location
            ElseIf card.pile = "Completed" Then
                card.Location = Completed.Location
            ElseIf card.pile = "VentureR" Then
                card.Location = New Point(VentureR.Left + (j * card.width / 3), VentureR.Top)
                card.bringtofront()
                j += 1
            ElseIf card.pile = "VentureC" Then
                card.Location = New Point(VentureC.Left + (z * card.width / 3), VentureC.Top)
                card.bringtofront()
                z += 1
            End If
        Next

        DrawPile.Left = Character1.Left - DrawCardWidth - DrawCardSpace
        PowerPack.Left = DrawPile.Left
        DeadPile.Left = PowerPack.Left - DrawCardWidth - DrawCardSpace
        DefeatedChars.Left = DeadPile.Left
        DrawPile.Top = Homebase.Top + CharCardHeight - DrawCardHeight
        DefeatedChars.Top = DrawPile.Top
        DeadPile.Top = DrawPile.Top - DrawCardSpace - DrawCardHeight
        PowerPack.Top = DeadPile.Top

        'move opponent table cards to new locations
        OppCharacter4.Top = MenuStrip.Bottom + 20
        OppHomebase.Top = OppCharacter4.Top

        OppCharacter1.Top = OppCharacter4.Top + CharCardSpaceVert
        OppCharacter2.Top = OppCharacter1.Top
        OppCharacter3.Top = OppCharacter1.Top
        OppBattlesite.Top = OppCharacter1.Top

        OppBattlesite.Left = Character1.Left
        OppCharacter1.Left = Character2.Left
        OppCharacter2.Left = Character3.Left
        OppCharacter3.Left = Battlesite.Left
        OppHomebase.Left = Character2.Left
        OppCharacter4.Left = Character3.Left

        OppCompleted.Top = OppCharacter4.Top
        OppReserve.Top = OppCompleted.Top + MissCardSpaceVert
        OppVentureR.Top = OppReserve.Top
        OppDefeated.Top = OppReserve.Top + MissCardSpaceVert
        OppVentureC.Top = OppCompleted.Top
        OppCompleted.Left = OppBattlesite.Left - MissCardWidth - MissCardSpaceHorz
        OppReserve.Left = OppCompleted.Left
        OppDefeated.Left = OppCompleted.Left
        OppVentureC.Left = OppCompleted.Left - MissCardWidth - MissCardSpaceHorz
        OppVentureR.Left = OppVentureC.Left

        j = 0
        z = 0
        For Each card In oppMissionCards
            If card.pile = "OppReserve" Then
                card.location = OppReserve.Location
            ElseIf card.pile = "OppCompleted" Then
                card.location = OppCompleted.Location
            ElseIf card.pile = "OppDefeated" Then
                card.location = OppDefeated.Location
            ElseIf card.pile = "OppVentureR" Then
                card.location = New Point(OppVentureR.Left - (j * card.width / 3), OppVentureR.Top)
                card.bringtofront()
                j += 1
            ElseIf card.pile = "OppVentureC" Then
                card.location = New Point(OppVentureC.Left - (z * card.width / 3), OppVentureC.Top)
                card.bringtofront()
                z += 1
            End If
        Next

        OppDrawPile.Left = OppCharacter3.Left + CharCardWidth + DrawCardSpace
        OppPowerPack.Left = OppDrawPile.Left
        OppDeadPile.Left = OppPowerPack.Left + DrawCardWidth + DrawCardSpace
        OppDefeatedChars.Left = OppDeadPile.Left
        OppDrawPile.Top = OppHomebase.Top
        OppDefeatedChars.Top = OppDrawPile.Top
        OppDeadPile.Top = OppDrawPile.Top + DrawCardHeight + DrawCardSpace
        OppPowerPack.Top = OppDeadPile.Top

        'resize hand cards
        For Each card In handCards
            If card.wide = True Then
                card.Size = New Size(HandCardHeight, HandCardWidth)
            Else
                card.Size = HandCardSize
            End If
        Next

        'move hand cards to new location
        For Each card As PictureBox In handCards
            card.Left = HandCardLeft
        Next

        HandCardTop = OppCharacter4.Top

        Dim space As Decimal = HandCardTop
        For Each card In handCards
            card.Top = space
            space += Me.Height / handCards.Count / 1.25
        Next

        'resize placed cards
        For Each pp In placeCards
            For Each card In pp
                card.size = SmallCardSize
            Next
        Next

        'resize opponent place cards
        For Each pp In oppPlaceCards
            For Each card In pp
                card.size = SmallCardSize
            Next
        Next

        'move placed cards to new location
        Dim k = 0
        For Each card In placeCards1
            card.location = New Point(Character1.Left + (card.width / 10) + (k * (card.width / 3)), Character1.Top + (Character1.Height / 2))
            k += 1
        Next
        k = 0
        For Each card In placeCards2
            card.location = New Point(Character2.Left + (card.width / 10) + (k * (card.width / 3)), Character2.Top + (Character2.Height / 2))
            k += 1
        Next
        k = 0
        For Each card In placeCards3
            card.location = New Point(Character3.Left + (card.width / 10) + (k * (card.width / 3)), Character3.Top + (Character3.Height / 2))
            k += 1
        Next
        k = 0
        For Each card In placeCards4
            card.location = New Point(Character4.Left + (card.width / 10) + (k * (card.width / 3)), Character4.Top + (Character4.Height / 2))
            k += 1
        Next
        k = 0
        For Each card In placeCardsH
            card.location = New Point(Homebase.Left + (card.width / 10) + (k * (card.width / 3)), Homebase.Top + (Homebase.Height / 2))
            k += 1
        Next
        If placeCards1.Count > 0 Then
            PlaceCardsTop = placeCards1(1).top
        ElseIf placeCards2.Count > 0 Then
            PlaceCardsTop = placeCards2(1).top
        ElseIf placeCards3.Count > 0 Then
            PlaceCardsTop = placeCards3(1).top
        End If
        If placeCards4.Count > 0 Then
            PlaceCardsBackTop = placeCards4(1).top
        ElseIf placeCardsH.Count > 0 Then
            PlaceCardsBackTop = placeCardsH(1).top
        End If

        'move opponent placed cards to new location
        k = 0
        For Each card In oppPlaceCards1
            card.location = New Point(OppCharacter1.Left + (card.Width / 10) + (k * (card.Width / 3)), OppCharacter1.Top - (OppCharacter1.Height / 10))
            k += 1
        Next
        k = 0
        For Each card In oppPlaceCards2
            card.location = New Point(OppCharacter2.Left + (card.Width / 10) + (k * (card.Width / 3)), OppCharacter2.Top - (OppCharacter2.Height / 10))
            k += 1
        Next
        k = 0
        For Each card In oppPlaceCards3
            card.location = New Point(OppCharacter3.Left + (card.Width / 10) + (k * (card.Width / 3)), OppCharacter3.Top - (OppCharacter3.Height / 10))
            k += 1
        Next
        k = 0
        For Each card In oppPlaceCards4
            card.location = New Point(OppCharacter4.Left + (card.Width / 10) + (k * (card.Width / 3)), OppCharacter4.Top - (OppCharacter4.Height / 10))
            k += 1
        Next
        k = 0
        For Each card In oppPlaceCardsH
            card.location = New Point(OppHomebase.Left + (card.Width / 10) + (k * (card.Width / 3)), OppHomebase.Top - (OppHomebase.Height / 10))
            k += 1
        Next
        If oppPlaceCards1.Count > 0 Then
            OppPlaceCardsTop = oppPlaceCards1(1).top
        ElseIf oppPlaceCards2.Count > 0 Then
            OppPlaceCardsTop = oppPlaceCards2(1).top
        ElseIf oppPlaceCards3.Count > 0 Then
            OppPlaceCardsTop = oppPlaceCards3(1).top
        End If
        If oppPlaceCards4.Count > 0 Then
            OppPlaceCardsBackTop = oppPlaceCards4(1).top
        ElseIf oppPlaceCardsH.Count > 0 Then
            OppPlaceCardsBackTop = oppPlaceCardsH(1).top
        End If

        'resize played cards
        For Each pp In playCards
            For Each card In pp
                card.size = SmallCardSize
            Next
        Next

        'resize opponent played cards
        For Each pp In oppPlayCards
            For Each card In pp
                card.size = SmallCardSize
            Next
        Next

        'move played cards
        k = 0
        For Each card In playCards1
            card.location = New Point(Character1.Right - card.width - (card.width / 2) + (k * (card.width / 3)), Character1.Top - (Character1.Height / 10))
            k += 1
        Next
        k = 0
        For Each card In playCards2
            card.location = New Point(Character2.Right - card.width - (card.width / 2) + (k * (card.width / 3)), Character2.Top - (Character2.Height / 10))
            k += 1
        Next
        k = 0
        For Each card In playCards3
            card.location = New Point(Character3.Right - card.width - (card.width / 2) + (k * (card.width / 3)), Character3.Top - (Character3.Height / 10))
            k += 1
        Next
        k = 0
        For Each card In playCards4
            card.location = New Point(Character4.Right - card.width - (card.width / 2) + (k * (card.width / 3)), Character4.Top - (Character4.Height / 10))
            k += 1
        Next
        k = 0
        For Each card In playCardsH
            card.location = New Point(Homebase.Right - card.width - (card.width / 2) + (k * (card.width / 3)), Homebase.Top - (Homebase.Height / 10))
            k += 1
        Next

        If playCards1.Count > 0 Then
            PlayCardsTop = playCards1(1).top
        ElseIf playCards2.Count > 0 Then
            PlayCardsTop = playCards2(1).top
        ElseIf playCards3.Count > 0 Then
            PlayCardsTop = playCards3(1).top
        End If
        If playCards4.Count > 0 Then
            PlayCardsBackTop = playCards4(1).top
        ElseIf playCardsH.Count > 0 Then
            PlayCardsBackTop = playCardsH(1).top
        End If

        'move opponent played cards
        k = 0
        For Each card In oppPlayCards1
            card.location = New Point(OppCharacter1.Right - (card.width * 1.5) + (k * (card.width / 3)), OppCharacter1.Top + (OppCharacter1.Height / 2))
            k += 1
        Next
        k = 0
        For Each card In oppPlayCards2
            card.location = New Point(OppCharacter2.Right - (card.width * 1.5) + (k * (card.width / 3)), OppCharacter2.Top + (OppCharacter2.Height / 2))
            k += 1
        Next
        k = 0
        For Each card In oppPlayCards3
            card.location = New Point(OppCharacter3.Right - (card.width * 1.5) + (k * (card.width / 3)), OppCharacter3.Top + (OppCharacter3.Height / 2))
            k += 1
        Next
        k = 0
        For Each card In oppPlayCards4
            card.location = New Point(OppCharacter4.Right - (card.width * 1.5) + (k * (card.width / 3)), OppCharacter4.Top + (OppCharacter4.Height / 2))
            k += 1
        Next
        k = 0
        For Each card In oppPlayCardsH
            card.location = New Point(OppHomebase.Right - (card.width * 1.5) + (k * (card.width / 3)), OppHomebase.Top + (OppHomebase.Height / 2))
            k += 1
        Next

        If oppPlayCards1.Count > 0 Then
            OppPlayCardsTop = oppPlayCards1(1).top
        ElseIf oppPlayCards2.Count > 0 Then
            OppPlayCardsTop = oppPlayCards2(1).top
        ElseIf oppPlayCards3.Count > 0 Then
            OppPlayCardsTop = oppPlayCards3(1).top
        End If
        If oppPlayCards4.Count > 0 Then
            OppPlayCardsBackTop = oppPlayCards4(1).top
        ElseIf oppPlayCardsH.Count > 0 Then
            OppPlayCardsBackTop = oppPlayCardsH(1).top
        End If

        'resize hits in current battle cards
        For Each pp In hitCards
            For Each card In pp
                card.size = SmallCardSize
            Next
        Next

        'move hits in current battle cards
        k = 0
        For Each card In hitCards1
            card.location = New Point(Character1.Left + (card.width / 10) + (k * (card.width / 3)), Character1.Top - (card.height * 1.3))
            k += 1
        Next
        k = 0
        For Each card In hitCards2
            card.location = New Point(Character2.Left + (card.width / 10) + (k * (card.width / 3)), Character2.Top - (card.height * 1.3))
            k += 1
        Next
        k = 0
        For Each card In hitCards3
            card.location = New Point(Character3.Left + (card.width / 10) + (k * (card.width / 3)), Character3.Top - (card.height * 1.3))
            k += 1
        Next
        k = 0
        For Each card In hitCards4
            card.location = New Point(Character4.Left - (card.width * 1.5) - (k * (card.width / 3)), Character4.Top + (Character4.Height / 2) - (card.height / 2))
            k += 1
        Next
        k = 0
        For Each card In hitCardsB
            card.location = New Point(Battlesite.Left + (card.width / 10) + (k * (card.width / 3)), Battlesite.Top - (card.height * 1.3))
            k += 1
        Next

        If hitCards1.Count > 0 Then
            HitCardsTop = hitCards1(1).top
        ElseIf hitCards2.Count > 0 Then
            HitCardsTop = hitCards2(1).top
        ElseIf hitCards3.Count > 0 Then
            HitCardsTop = hitCards3(1).top
        ElseIf hitCardsB.Count > 0 Then
            HitCardsTop = hitCardsB(1).top
        End If
        If hitCards4.Count > 0 Then
            HitCardsBackTop = hitCards4(1).top
        End If

        'resize opponent hits in current battle cards
        For Each pp In oppHitCards
            For Each card In pp
                card.size = SmallCardSize
            Next
        Next

        'move opponent hits in current battle cards
        k = 0
        For Each card In oppHitCards1
            card.location = New Point(OppCharacter1.Left + (card.width / 10) + (k * (card.width / 3)), OppCharacter1.Bottom + (card.height / 3))
            k += 1
        Next
        k = 0
        For Each card In oppHitCards2
            card.location = New Point(OppCharacter2.Left + (card.width / 10) + (k * (card.width / 3)), OppCharacter2.Bottom + (card.height / 3))
            k += 1
        Next
        k = 0
        For Each card In oppHitCards3
            card.location = New Point(OppCharacter3.Left + (card.width / 10) + (k * (card.width / 3)), OppCharacter3.Bottom + (card.height / 3))
            k += 1
        Next
        k = 0
        For Each card In oppHitCards4
            card.location = New Point(OppCharacter4.Left + (card.width / 10) + (k * (card.width / 3)), OppCharacter4.Top + (OppCharacter4.Height / 2) - (card.height / 2))
            k += 1
        Next
        k = 0
        For Each card In oppHitCardsB
            card.location = New Point(OppBattlesite.Left + (card.width / 10) + (k * (card.width / 3)), OppBattlesite.Bottom + (card.height / 3))
            k += 1
        Next

        If oppHitCards1.Count > 0 Then
            OppHitCardsTop = oppHitCards1(1).top
        ElseIf oppHitCards2.Count > 0 Then
            OppHitCardsTop = oppHitCards2(1).top
        ElseIf oppHitCards3.Count > 0 Then
            OppHitCardsTop = oppHitCards3(1).top
        ElseIf oppHitCardsB.Count > 0 Then
            OppHitCardsTop = oppHitCardsB(1).top
        End If
        If oppHitCards4.Count > 0 Then
            OppHitCardsBackTop = oppHitCards4(1).top
        End If

        'resize permanent record cards
        For Each pp In permCards
            For Each card In pp
                card.size = SmallCardSize
            Next
        Next

        'move permanent record cards
        k = 0
        For Each card In permCards1
            card.location = New Point(Character1.Left + (card.width / 10) + (k * (card.width / 3)), Character1.Top - (card.height / 5))
            k += 1
        Next
        k = 0
        For Each card In permCards2
            card.location = New Point(Character2.Left + (card.width / 10) + (k * (card.width / 3)), Character2.Top - (card.height / 5))
            k += 1
        Next
        k = 0
        For Each card In permCards3
            card.location = New Point(Character3.Left + (card.width / 10) + (k * (card.width / 3)), Character3.Top - (card.height / 5))
            k += 1
        Next
        k = 0
        For Each card In permCards4
            card.location = New Point(Character4.Left - (card.width / 3), Character4.Top + (card.height / 20) + (k * (card.height / 5)))
            k += 1
        Next
        k = 0
        For Each card In permCardsB
            card.location = New Point(Battlesite.Left + (card.width / 10) + (k * (card.width / 3)), Battlesite.Top - (card.height / 5))
            k += 1
        Next

        If permCards1.Count > 0 Then
            PermCardsTop = permCards1(1).top
        ElseIf permCards2.Count > 0 Then
            PermCardsTop = permCards2(1).top
        ElseIf permCards3.Count > 0 Then
            PermCardsTop = permCards3(1).top
        ElseIf permCardsB.Count > 0 Then
            PermCardsTop = permCardsB(1).top
        End If
        If permCards4.Count > 0 Then
            PermCardsBackTop = permCards4(1).top
        End If

        'resize opponent permanent record cards
        For Each pp In oppPermCards
            For Each card In pp
                card.size = SmallCardSize
            Next
        Next

        'move opponent permanent record cards
        k = 0
        For Each card In oppPermCards1
            card.location = New Point(OppCharacter1.Left - (card.width / 3), OppCharacter1.Top + (card.width / 10) + (k * (card.width / 3)))
            k += 1
        Next
        k = 0
        For Each card In oppPermCards2
            card.location = New Point(OppCharacter2.Left - (card.width / 3), OppCharacter2.Top + (card.width / 10) + (k * (card.width / 3)))
            k += 1
        Next
        k = 0
        For Each card In oppPermCards3
            card.location = New Point(OppCharacter3.Left - (card.width / 3), OppCharacter3.Top + (card.width / 10) + (k * (card.width / 3)))
            k += 1
        Next
        k = 0
        For Each card In oppPermCards4
            card.location = New Point(OppCharacter4.Left - (card.width / 3), OppCharacter4.Top + (card.width / 10) + (k * (card.width / 3)))
            k += 1
        Next
        k = 0
        For Each card In oppPermCardsB
            card.location = New Point(OppBattlesite.Left - (card.width / 4), OppBattlesite.Top + (card.width / 10) + (k * (card.width / 3)))
            k += 1
        Next

        If oppPermCards1.Count > 0 Then
            OppPermCardsTop = oppPermCards1(1).top
        ElseIf oppPermCards2.Count > 0 Then
            OppPermCardsTop = oppPermCards2(1).top
        ElseIf oppPermCards3.Count > 0 Then
            OppPermCardsTop = oppPermCards3(1).top
        ElseIf oppPermCardsB.Count > 0 Then
            OppPermCardsTop = oppPermCardsB(1).top
        End If
        If oppPermCards4.Count > 0 Then
            OppPermCardsBackTop = oppPermCards4(1).top
        End If

        'resize attackbox, attackpanel, defendbox and cards in them
        AttackBox.Height = DrawPile.Height + 35
        AttackBox.Location = New Point(OppBattlesite.Left + (OppBattlesite.Width / 2), PlayTextBox.Top - ((AttackBox.Height - PlayTextBox.Height) / 2))
        AttackBox.Width = OppCharacter3.Left + (OppCharacter3.Width / 2) - AttackBox.Left
        AttackPanel.Location = New Point((AttackBox.Left + (AttackBox.Width / 2)) - ((AttackCards.Count * (DrawPile.Width + (DrawPile.Width / 10))) + (DrawPile.Width / 10)), AttackBox.Top + 25)
        If AttackPanel.Panel2Collapsed = True Then
            AttackPanel.Size = New Size((AttackCards.Count * (DrawPile.Width + (DrawPile.Width / 10))) + (DrawPile.Width / 10), AttackBox.Height - 26)
        Else
            AttackPanel.Size = New Size(((AttackCards.Count + DefendCards.Count + 1) * (DrawPile.Width + (DrawPile.Width / 10))) + (2 * DrawPile.Width / 10) + AttackPanel.SplitterWidth, AttackBox.Height - 26)
        End If

        DefendBox.Size = AttackBox.Size
        DefendBox.Location = AttackBox.Location
        AcceptBox.Size = DefendBox.Size
        AcceptBox.Location = DefendBox.Location

        If AttackBox.Visible = True Then
            If AttackFromLine.Visible = True Then
                AttackFromLine.StartPoint = New Point(tempChar.left + (tempChar.width / 2), tempChar.top + (tempChar.height / 2))
                AttackFromLine.EndPoint = New Point(AttackBox.Left + (AttackBox.Width / 2), AttackBox.Top + (AttackBox.Height / 2))
            End If

            If AttackToLine.Visible = True Then
                AttackToLine.StartPoint = New Point(AttackBox.Left + (AttackBox.Width / 2), AttackBox.Top + (AttackBox.Height / 2))
                AttackToLine.EndPoint = New Point(tempChar2.left + (tempChar2.width / 2), tempChar2.top + (tempChar2.height / 2))
            End If

            Dim i = 0
            For Each card In AttackCards
                card.size = DrawPile.Size
                card.Location = New Point(AttackPanel.Left + (DrawPile.Width / 10) + (i * (card.width)) + (i * (DrawPile.Width / 10)), AttackBox.Bottom - card.Height - 5)
                card.visible = True
                i += 1
            Next

            bCancel.Location = New Point(AttackBox.Right - bCancel.Width - 3, AttackBox.Bottom - bCancel.Height - 2)
            cbFacedown.Location = New Point(bCancel.Right - cbFacedown.Width, bCancel.Top - cbFacedown.Height - 2)
            bAttack.Location = New Point(bCancel.Left, cbFacedown.Top - bAttack.Height - 2)
            bMin.Location = New Point(AttackBox.Right - bMin.Width - 2, AttackBox.Top + 2)

            setAttackButtonsVis(True)

        ElseIf DefendBox.Visible = True Then
            If DefendCards.Count > 0 Then
                AttackPanel.Size = New Size(((AttackCards.Count + DefendCards.Count) * (DrawPile.Width + (DrawPile.Width / 10))) + (2 * DrawPile.Width / 10) + AttackPanel.SplitterWidth, AttackBox.Height - 26)
            End If

            Dim i = 0
            For Each card In AttackCards
                card.size = DrawPile.Size
                card.Location = New Point(AttackPanel.Left + (DrawPile.Width / 10) + (i * (card.width)) + (i * (DrawPile.Width / 10)), DefendBox.Bottom - card.Height - 5)
                i += 1
            Next

            i = 0
            For Each card In DefendCards
                card.size = DrawPile.Size
                card.Location = New Point(AttackPanel.Right - DrawPile.Width - (DrawPile.Width / 10) - (i * (card.width)) - (i * (DrawPile.Width / 10)), DefendBox.Bottom - card.Height - 5)
                i += 1
            Next

            bShift.Location = New Point(DefendBox.Right - bShift.Width - 3, DefendBox.Bottom - bShift.Height - 1)
            bHits.Location = New Point(bShift.Left, bShift.Top - bHits.Height - 1)
            bDefend.Location = New Point(bHits.Left, bHits.Top - bDefend.Height - 1)
            bMin.Location = New Point(DefendBox.Right - bMin.Width - 2, DefendBox.Top + 2)

            AttackToLine.StartPoint = New Point(DefendBox.Left + (DefendBox.Width / 2), DefendBox.Top + (DefendBox.Height / 2))
            AttackFromLine.EndPoint = New Point(DefendBox.Left + (DefendBox.Width / 2), DefendBox.Top + (DefendBox.Height / 2))

            If attackTo = "OppCharacter1" Then
                AttackToLine.EndPoint = New Point(Character1.Left + (Character1.Width / 2), Character1.Top + (Character1.Height / 2))
            ElseIf attackTo = "OppCharacter2" Then
                AttackToLine.EndPoint = New Point(Character2.Left + (Character2.Width / 2), Character2.Top + (Character2.Height / 2))
            ElseIf attackTo = "OppCharacter3" Then
                AttackToLine.EndPoint = New Point(Character3.Left + (Character3.Width / 2), Character3.Top + (Character3.Height / 2))
            ElseIf attackTo = "OppCharacter4" Then
                AttackToLine.EndPoint = New Point(Character4.Left + (Character4.Width / 2), Character4.Top + (Character4.Height / 2))
            ElseIf attackTo = "OppBattlesite" Then
                AttackToLine.EndPoint = New Point(Battlesite.Left + (Battlesite.Width / 2), Battlesite.Top + (Battlesite.Height / 2))
            End If

            If attackFrom = "Character1" Then
                AttackFromLine.StartPoint = New Point(OppCharacter1.Left + (OppCharacter1.Width / 2), OppCharacter1.Top + (OppCharacter1.Height / 2))
            ElseIf attackFrom = "Character2" Then
                AttackFromLine.StartPoint = New Point(OppCharacter2.Left + (OppCharacter2.Width / 2), OppCharacter2.Top + (OppCharacter2.Height / 2))
            ElseIf attackFrom = "Character3" Then
                AttackFromLine.StartPoint = New Point(OppCharacter3.Left + (OppCharacter3.Width / 2), OppCharacter3.Top + (OppCharacter3.Height / 2))
            ElseIf attackFrom = "Character4" Then
                AttackFromLine.StartPoint = New Point(OppCharacter4.Left + (OppCharacter4.Width / 2), OppCharacter4.Top + (OppCharacter4.Height / 2))
            ElseIf attackFrom = "Homebase" Then
                AttackFromLine.StartPoint = New Point(OppHomebase.Left + (OppHomebase.Width / 2), OppHomebase.Top + (OppHomebase.Height / 2))
            End If

        ElseIf AcceptBox.Visible = True Then
            AttackPanel.Size = New Size(((AttackCards.Count + DefendCards.Count) * (DrawPile.Width + (DrawPile.Width / 10))) + (2 * DrawPile.Width / 10) + AttackPanel.SplitterWidth, AttackBox.Height - 26)

            Dim i = 0
            For Each card In AttackCards
                card.size = DrawPile.Size
                card.Location = New Point(AttackPanel.Left + (DrawPile.Width / 10) + (i * (card.width)) + (i * (DrawPile.Width / 10)), AcceptBox.Bottom - card.Height - 5)
                i += 1
            Next

            i = 0
            For Each card In DefendCards
                card.size = DrawPile.Size
                card.Location = New Point(AttackPanel.Right - DrawPile.Width - (DrawPile.Width / 10) - (i * (card.width)) - (i * (DrawPile.Width / 10)), AcceptBox.Bottom - card.Height - 5)
                i += 1
            Next

            bChallenge.Location = New Point(AcceptBox.Right - bChallenge.Width - 3, AcceptBox.Bottom - bChallenge.Height - 3)
            bAccept.Location = New Point(bChallenge.Left, bChallenge.Top - bAccept.Height - 3)
            bMin.Location = New Point(AcceptBox.Right - bMin.Width - 2, AcceptBox.Top + 2)

            AttackToLine.StartPoint = New Point(AcceptBox.Left + (AcceptBox.Width / 2), AcceptBox.Top + (AcceptBox.Height / 2))
            AttackFromLine.EndPoint = New Point(AcceptBox.Left + (AcceptBox.Width / 2), AcceptBox.Top + (AcceptBox.Height / 2))

            If attackTo = "OppCharacter1" Then
                AttackToLine.EndPoint = New Point(OppCharacter1.Left + (OppCharacter1.Width / 2), OppCharacter1.Top + (OppCharacter1.Height / 2))
            ElseIf attackTo = "OppCharacter2" Then
                AttackToLine.EndPoint = New Point(OppCharacter2.Left + (OppCharacter2.Width / 2), OppCharacter2.Top + (OppCharacter2.Height / 2))
            ElseIf attackTo = "OppCharacter3" Then
                AttackToLine.EndPoint = New Point(OppCharacter3.Left + (OppCharacter3.Width / 2), OppCharacter3.Top + (OppCharacter3.Height / 2))
            ElseIf attackTo = "OppCharacter4" Then
                AttackToLine.EndPoint = New Point(OppCharacter4.Left + (OppCharacter4.Width / 2), OppCharacter4.Top + (OppCharacter4.Height / 2))
            ElseIf attackTo = "OppBattlesite" Then
                AttackToLine.EndPoint = New Point(OppBattlesite.Left + (OppBattlesite.Width / 2), OppBattlesite.Top + (OppBattlesite.Height / 2))
            End If

            If attackFrom = "Character1" Then
                AttackFromLine.StartPoint = New Point(Character1.Left + (Character1.Width / 2), Character1.Top + (Character1.Height / 2))
            ElseIf attackFrom = "Character2" Then
                AttackFromLine.StartPoint = New Point(Character2.Left + (Character2.Width / 2), Character2.Top + (Character2.Height / 2))
            ElseIf attackFrom = "Character3" Then
                AttackFromLine.StartPoint = New Point(Character3.Left + (Character3.Width / 2), Character3.Top + (Character3.Height / 2))
            ElseIf attackFrom = "Character4" Then
                AttackFromLine.StartPoint = New Point(Character4.Left + (Character4.Width / 2), Character4.Top + (Character4.Height / 2))
            ElseIf attackFrom = "Homebase" Then
                AttackFromLine.StartPoint = New Point(Homebase.Left + (Homebase.Width / 2), Homebase.Top + (Homebase.Height / 2))
            End If

        Else
            bCancel.Visible = False
        End If

        'move current phase text to new location
        CurrentPhase.Left = BigCardV.Left + (BigCardV.Width / 2) - (CurrentPhase.Width / 2)
        Phase.Left = CurrentPhase.Left
        bPhase.Left = Phase.Left + Phase.Width / 2 - bPhase.Width / 2
        PlaceTextBox.Location = New Point((Me.Width / 2) - (PlaceTextBox.Width / 2), (Me.Height / 2) - (PlaceTextBox.Height * 1.25))
        PlayTextBox.Location = New Point((Me.Width / 2) - (PlayTextBox.Width / 2), (Me.Height / 2) - PlayTextBox.Height)
        bConcede.Left = bPhase.Left + (bPhase.Width / 2) - 2 - bConcede.Width
        bPass.Left = bPhase.Left + (bPhase.Width / 2) + 2

        'move venture controls to new locations
        Dim cpc As Integer = CurrentPhase.Width / 2
        bMinusMe.Left = CurrentPhase.Left + cpc - (bMinusMe.Width * 3.5)
        MyVenture.Left = bMinusMe.Right + 5
        bPlusMe.Left = MyVenture.Right + 4
        MyTotalV.Left = bPlusMe.Right + 5
        bMinusOpp.Left = bMinusMe.Left
        OppVenture.Left = MyVenture.Left
        bPlusOpp.Left = bPlusMe.Left
        OppTotalV.Left = MyTotalV.Left

        'hide buttons
        bPlay.Visible = False
        bDiscard.Visible = False
        bPlace.Visible = False
        bP.Visible = False
        bD.Visible = False
        PlaceTextBox.Visible = False
        PlayTextBox.Visible = False

        'clear temps
        BG_Click(sender, e)

        'reset rotates  
        For Each m In oppMissionCards
            If m.rotated = True Then
                m.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
                m.rotated = False
            End If
        Next

        If rotated = True Then
            DefeatedChars.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
            rotated = False
        End If

        If rotatedo = True Then
            OppDefeatedChars.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
            rotatedo = False
        End If
    End Sub
    '
    '
    '
    '
    '
    '
    '
    'moves text from input box to output box and scrolls down if necessary
    Private Sub Enter_Click(sender As Object, e As EventArgs) Handles SUBMIT.Click
        If Connected = True Then
            If Host = False Then
                If TextInput.Text <> "" Then
                    cSendText(UID + ": " + TextInput.Text)
                End If
            Else
                If TextInput.Text <> "" Then
                    hSendText(UID + ": " + TextInput.Text)
                End If
            End If

            If TextInput.Text <> "" Then
                If (TextOutput.Text = "") Then
                    TextOutput.Text += UID + ": " + TextInput.Text
                Else
                    TextOutput.Text += vbNewLine + UID + ": " + TextInput.Text
                End If
            End If

            TextOutput.Focus()
            TextOutput.Select(TextOutput.TextLength, 0)
            TextOutput.ScrollToCaret()
            TextOutput.ScrollToCaret()
        End If

        TextInput.Clear()
        TextInput.Focus()
    End Sub
    '
    '
    'calls BGclick
    Private Sub BG_Click(sender As Object, e As EventArgs) Handles MyBase.MouseClick
        BGclick()
    End Sub
    '
    '
    'removes the big cards and buttons and resets card locations when user clicks any white space on table
    Public Sub BGclick()
        If PlaceTextBox.Visible = False And PlayTextBox.Visible = False Then
            TextBox1.Visible = False
            BigCardH.Visible = False
            BigCardV.Visible = False
            bP.Visible = False
            bD.Visible = False
            bR.Visible = False
            bM.Visible = False
            bDiscard.Visible = False
            bPlay.Visible = False
            bPlace.Visible = False
            b2C.Visible = False
            b2R.Visible = False
            b2D.Visible = False
            bPlusV.Visible = False
            bMinusV.Visible = False
            b2P.Visible = False
            BSlistbox.Visible = False

            'put hand cards back in place, if out of place
            For Each card In handCards
                If card.left <> HandCardLeft Then
                    card.Location = New Point(HandCardLeft, card.Top)
                End If
            Next

            tempCard = vbNull
            tempCharX = vbNull

            For Each pp In placeCards
                For Each card In pp
                    card.bringtofront()
                Next
            Next

        Else
        TextBox1.Visible = False
        BigCardH.Visible = False
        BigCardV.Visible = False
        End If
        TextInput.Focus()
    End Sub
    '
    '
    'gives input back to text input box
    Private Sub TextBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox1.MouseClick
        TextInput.Focus()
    End Sub
    '
    '
    '
    '
    '
    '
    '
    '
    '
    Private Sub bPhase_Click(sender As Object, e As MouseEventArgs) Handles bPhase.MouseClick
        If Phase.Text = "MOVE MISSIONS" Then
            MoveToPerm()
        End If
        bPhaseUpdate()
        BGclick()
        TextInput.Focus()
    End Sub

    Public Sub bPhaseUpdate()
        If Phase.Text = "DISCARD" Then
            If done = True Then
                Dim a As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
                Dim s As System.IO.Stream = a.GetManifestResourceStream("OverPower.NewPhase.wav")
                Dim player As SoundPlayer = New SoundPlayer(s)
                player.Play()

                If meFirst = True Then
                    UpdateStatus("You are now in the " + nextPhase() + " Phase. You should place first.")
                Else
                    UpdateStatus("You are now in the " + nextPhase() + " Phase. " + OUID + " should place first.")
                End If

                Phase.Text = "PLACING"
                bPhase.Enabled = True
                bPhase.Font = New Font(bPhase.Font, FontStyle.Bold)

                If Host = True Then
                    hSendCommand("done")
                Else
                    cSendCommand("done")
                End If

                done = False
            Else
                done = True
                bPhase.Enabled = False
                bPhase.Font = New Font(bPhase.Font, FontStyle.Regular)

                UpdateStatus("Waiting for " + OUID + " to finish discarding.")

                If Host = True Then
                    hSendCommand("done")
                Else
                    cSendCommand("done")
                End If
            End If

        ElseIf Phase.Text = "PLACING" Then
            If done = True Then
                Dim a As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
                Dim s As System.IO.Stream = a.GetManifestResourceStream("OverPower.NewPhase.wav")
                Dim player As SoundPlayer = New SoundPlayer(s)
                player.Play()

                If meFirst = True Then
                    UpdateStatus("You are now in the " + nextPhase() + " Phase. You should venture first.")
                Else
                    UpdateStatus("You are now in the " + nextPhase() + " Phase. " + OUID + " should venture first.")
                End If

                Phase.Text = "VENTURE"
                bPhase.Enabled = True
                bPhase.Font = New Font(bPhase.Font, FontStyle.Bold)

                If Host = True Then
                    hSendCommand("done")
                Else
                    cSendCommand("done")
                End If

                done = False
            Else
                done = True
                bPhase.Enabled = False
                bPhase.Font = New Font(bPhase.Font, FontStyle.Regular)

                UpdateStatus("Waiting for " + OUID + " to finish placing.")

                If Host = True Then
                    hSendCommand("done")
                Else
                    cSendCommand("done")
                End If
            End If

        ElseIf Phase.Text = "VENTURE" Then
            If done = True Then
                Dim a As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
                Dim s As System.IO.Stream = a.GetManifestResourceStream("OverPower.NewPhase.wav")
                Dim player As SoundPlayer = New SoundPlayer(s)
                player.Play()

                Phase.Text = "BATTLE"
                bPhase.Text = "End Turn"
                bConcede.Visible = True
                bPass.Visible = True
                bConcede.Enabled = True
                bPass.Enabled = False
                bPhase.Enabled = False
                bPhase.Font = New Font(bPhase.Font, FontStyle.Regular)
                bConcede.Font = New Font(bPhase.Font, FontStyle.Bold)
                bPass.Font = bPhase.Font
                If Host = True Then
                    hSendCommand("done")
                Else
                    cSendCommand("done")
                End If
                If meFirst = True Then
                    UpdateStatus("You are now in the Battle Phase. You get the first attack.")
                    bPhase.Enabled = True
                    bConcede.Enabled = True
                    bPass.Enabled = True
                    bPhase.Font = New Font(bPhase.Font, FontStyle.Bold)
                    bConcede.Font = bPhase.Font
                    bPass.Font = bPhase.Font
                Else
                    UpdateStatus("You are now in the Battle Phase. " + OUID + " gets the first attack.")
                End If
                done = False
            Else
                done = True
                bPhase.Enabled = False
                bPhase.Font = New Font(bPhase.Font, FontStyle.Regular)

                UpdateStatus("Waiting for " + OUID + " to finish venturing.")

                If Host = True Then
                    hSendCommand("done")
                Else
                    cSendCommand("done")
                End If
            End If

        ElseIf Phase.Text = "BATTLE" Then
            If bPhase.Enabled = False Then
                bPhase.Enabled = True
                bPhase.Font = New Font(bPhase.Font, FontStyle.Bold)

                If Host = True Then
                    hSendCommand("done")
                Else
                    cSendCommand("done")
                End If
            Else
                bPhase.Enabled = False
                bPhase.Font = New Font(bPhase.Font, FontStyle.Regular)
                bConcede.Enabled = False
                bPass.Enabled = False
                bConcede.Font = bPhase.Font
                bPass.Font = bPhase.Font
                Pass = False

                If Host = True Then
                    hSendCommand("done")
                Else
                    cSendCommand("done")
                End If
            End If

        ElseIf Phase.Text = "MOVE MISSIONS" Then
            bPhase.Enabled = False
            bPhase.Font = New Font(bPhase.Font, FontStyle.Regular)

            If CompletedCards.Count = 7 Then
                Dim a As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
                Dim s As System.IO.Stream = a.GetManifestResourceStream("OverPower.WinGame.wav")
                Dim player As SoundPlayer = New SoundPlayer(s)
                player.Play()
                MsgBox("You have completed all your missions and are victorious!", MsgBoxStyle.Exclamation, OUID + " wins!")
                If Host = True Then
                    hSendCommand("win")
                Else
                    cSendCommand("win")
                End If
            End If

            If done = True Then
                Dim a As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
                Dim s As System.IO.Stream = a.GetManifestResourceStream("OverPower.NewPhase.wav")
                Dim player As SoundPlayer = New SoundPlayer(s)
                player.Play()

                bPhase.Enabled = False
                bPhase.Font = New Font(bPhase.Font, FontStyle.Regular)

                myTotalVenture = 0
                oppTotalVenture = 0
                MyTotalV.Text = CType(myTotalVenture, String)
                OppTotalV.Text = CType(oppTotalVenture, String)

                Thread.Sleep(250)

                If Host = True Then
                    hSendCommand("done")
                Else
                    cSendCommand("done")
                End If

                done = False

                DiscardHand()
            Else
                done = True
                bPhase.Enabled = False
                bPhase.Font = New Font(bPhase.Font, FontStyle.Regular)

                UpdateStatus("Waiting for " + OUID + " to finish moving missions.")

                Thread.Sleep(250)

                If Host = True Then
                    hSendCommand("done")
                Else
                    cSendCommand("done")
                End If
            End If
        End If
    End Sub

    Private Function nextPhase()
        If Phase.Text = "DISCARD" Then
            Return "Placing"
        ElseIf Phase.Text = "PLACING" Then
            Return "Venture"
        ElseIf Phase.Text = "VENTURE" Then
            Return "Battle"
        ElseIf Phase.Text = "BATTLE" Then
            Return "Move Missions"
        ElseIf Phase.Text = "MOVE MISSIONS" Then
            Return "Discard"
        End If
        Return "next"
    End Function

    Private Sub bPass_Click(sender As Object, e As MouseEventArgs) Handles bPass.MouseClick
        If Pass = True Then
            If Host = True Then
                hSendCommand("pass")
            Else
                cSendCommand("pass")
            End If

            bPhase.Enabled = False
            bConcede.Visible = False
            bPass.Visible = False
            UpdateStatus("You have both passed. Assess the battle.")
            frmVenture.ShowDialog()
        Else
            UpdateStatus("You have passed your turn and may only defend for the remainder of the battle.")
            bPhase.Enabled = False
            bConcede.Enabled = False
            bPass.Enabled = False
            bPhase.Font = New Font(bPhase.Font, FontStyle.Regular)
            bPass.Font = bPhase.Font
            bConcede.Font = bPhase.Font
            Pass = True
            If Host = True Then
                hSendCommand("pass")
            Else
                cSendCommand("pass")
            End If
        End If

    End Sub

    Private Sub bConcede_Click(sender As Object, e As EventArgs) Handles bConcede.Click
        bConcede.Enabled = False
        bPhase.Enabled = False
        bPass.Enabled = False
        bPhase.Font = New Font(bPhase.Font, FontStyle.Regular)
        bPass.Font = bPhase.Font
        bConcede.Font = bPass.Font
        UpdateStatus("Asking " + OUID + " if you can concede...")

        If Host = True Then
            hSendCommand("concede")
        Else
            cSendCommand("concede")
        End If
    End Sub
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    'clears the table for a new game
    Private Sub ClearAll()
        If handCards.Count > 0 Then
            For Each card In handCards
                Me.Controls.Remove(card)
            Next
            handCards.Clear()
        End If

        oppHandCards.Clear()

        For Each pp In placeCards
            For Each card In pp
                card.placed = False
                card.placedOn = Nothing
                Me.Controls.Remove(card)
            Next
            pp.Clear()
        Next

        For Each pp In oppPlaceCards
            For Each card In pp
                card.placed = False
                card.placedOn = Nothing
                Me.Controls.Remove(card)
            Next
            pp.Clear()
        Next

        For Each pp In playCards
            For Each card In pp
                card.played = False
                card.playedOn = Nothing
                Me.Controls.Remove(card)
            Next
            pp.Clear()
        Next

        For Each pp In oppPlayCards
            For Each card In pp
                card.played = False
                card.playedOn = Nothing
                Me.Controls.Remove(card)
            Next
            pp.Clear()
        Next

        For Each pp In hitCards
            For Each card In pp
                card.hit = False
                card.hitOn = Nothing
                Me.Controls.Remove(card)
            Next
            pp.clear()
        Next

        For Each pp In oppHitCards
            For Each card In pp
                card.hit = False
                card.hitOn = Nothing
                Me.Controls.Remove(card)
            Next
            pp.clear()
        Next

        For Each pp In permCards
            For Each card In pp
                card.perm = False
                Me.Controls.Remove(card)
            Next
            pp.clear()
        Next

        For Each pp In oppPermCards
            For Each card In pp
                card.perm = False
                Me.Controls.Remove(card)
            Next
            pp.clear()
        Next

        If AttackCards.Count > 0 Then
            For Each card In AttackCards
                card.attack = False
                Me.Controls.Remove(card)
            Next
            AttackCards.Clear()
        End If

        If DefendCards.Count > 0 Then
            For Each card In DefendCards
                card.defend = False
                Me.Controls.Remove(card)
            Next
            DefendCards.Clear()
        End If

        inPP = False
        myDeckCards.Clear()
        myBsDeck.Clear()
        deadP.Clear()
        powerP.Clear()
        dChars.Clear()
        DeadPile.Image = Nothing
        PowerPack.Image = Nothing
        DefeatedChars.Image = PowerPack.Image
        Event1.Image = Nothing
        Event2.Image = Nothing
        BigCardH.Visible = False
        BigCardV.Visible = False
        bP.Visible = False
        bD.Visible = False
        bR.Visible = False
        bM.Visible = False
        b2P.Visible = False
        b2C.Visible = False
        b2D.Visible = False
        b2R.Visible = False
        bDiscard.Visible = False
        bPlay.Visible = False
        bPlace.Visible = False
        PlaceTextBox.Visible = False
        PlayTextBox.Visible = False
        AttackBox.Visible = False
        DefendBox.Visible = False
        AttackPanel.Visible = False
        AttackFromLine.Visible = False
        AttackToLine.Visible = False
        attackTo = Nothing
        attackFrom = Nothing
        setAttackButtonsVis(False)
        setDefendButtonsVis(False)
        setAcceptButtonsVis(False)
        myTotalVenture = 0
        MyTotalV.Text = "0"
        oppTotalVenture = 0
        OppTotalV.Text = "0"
        Phase.Text = "DISCARD"
        WGF = False
        done = False
        faceDown = False
        Event1.Visible = False
        Event2.Visible = False
        NumOfKOs = 0
        bConcede.Visible = False
        bPass.Visible = False
        Pass = False
        bPhase.Text = "Done"
        bPhase.Enabled = False
        bPhase.Font = New Font(bPhase.Font, FontStyle.Regular)

        ReserveCards.Clear()
        DefeatedCards.Clear()
        CompletedCards.Clear()
        vReserveCards.Clear()
        vCompletedCards.Clear()
        For Each Mssn In missionCards
            Mssn.pile = "Reserve"
            Mssn.location = Reserve.Location
            ReserveCards.Add(Mssn)
        Next
    End Sub
    '
    '
    'resets connect buttons on disconnect
    Private Sub setEnabled(ByVal b As Boolean)
        If MenuStrip.InvokeRequired Then
            MenuStrip.Invoke(New setEnabledCallBack(AddressOf setEnabled), b)
        Else
            DisconnectToolStripMenuItem.Enabled = b
            If b = False Then
                ConnectToolStripMenuItem.Enabled = True
                LoadDeckToolStripMenuItem.Enabled = True
            Else
                ConnectToolStripMenuItem.Enabled = False
            End If
            Connected = b

            If Host = True Then
                Host = b
                mobjListener.Stop()
            Else
                mobjClient.Close()
            End If
        End If
    End Sub
    '
    '
    'determines who goes first
    Private Sub WhoGoesFirst()
        WGF = True
        If oppDoneLoadingDeck = False Then
            DrawCardToolStripMenuItem.Enabled = False
            ShuffleDeckToolStripMenuItem.Enabled = False
            UpdateStatus("Waiting for " + OUID + " to finish loading your deck...")
        End If
        Timer3.Start()
    End Sub
    '
    '
    'make a card
    Public Function MakeCard(card As Cereal)
        Dim temp As New Object
        If card.cardType = "OverPower.Special" Then
            temp = New Special(card.id)
        ElseIf card.cardType = "OverPower.PowerCard" Then
            temp = New PowerCard(card.id)
        ElseIf card.cardType = "OverPower.Ally" Then
            temp = New Ally(card.id)
        ElseIf card.cardType = "OverPower.Artifact" Then
            temp = New Artifact(card.id)
        ElseIf card.cardType = "OverPower.Aspect" Then
            temp = New Aspect(card.id)
        ElseIf card.cardType = "OverPower.BasicUniverse" Then
            temp = New BasicUniverse(card.id)
        ElseIf card.cardType = "OverPower.Doubleshot" Then
            temp = New Doubleshot(card.id)
        ElseIf card.cardType = "OverPower.MissionEvent" Then
            temp = New MissionEvent(card.id)
        ElseIf card.cardType = "OverPower.Teamwork" Then
            temp = New Teamwork(card.id)
        ElseIf card.cardType = "OverPower.Training" Then
            temp = New Training(card.id)
        ElseIf card.cardType = "OverPower.Character" Then
            temp = New Character(card.id)
        End If

        If card.placed = True Then
            temp.placedOn = card.placedOn
            temp.placed = True
        ElseIf card.played = True Then
            temp.played = True
        ElseIf card.hit = True Then
            temp.hit = True
        ElseIf card.perm = True Then
            temp.perm = True
        End If

        temp.visible = False
        addHandlers(temp)

        Return temp
    End Function
    '
    '
    'add handlers for cards created
    Public Sub addHandlers(ByVal inputObject As Control)
        Try
            RemoveHandler inputObject.MouseClick, AddressOf CardsClick
        Catch ex As Exception

        End Try
        AddHandler inputObject.MouseClick, AddressOf CardsClick
    End Sub
    '
    '
    'reshuffles the powerpack and adds to draw pile
    Private Sub ReshufflePP()
        powerP = deck.ShuffleCards(powerP)
        For Each card In powerP
            myDeckCards.Add(card)
        Next
        PowerPack.Image = Nothing
        PowerPack.Visible = False
        powerP.Clear()

        If inPP = False Then
            MsgBox("You are now drawing from your PowerPack", MsgBoxStyle.Information)
            inPP = True
        End If
    End Sub
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    'place a card
    Private Sub PlaceCard(plOn As String, card As Object)
        card.placed = True
        card.placedOn = plOn
        card.size = SmallCardSize
        card.bringtofront()

        If plOn = "Character1" Then
            card.Location = New Point(Character1.Left + (card.width / 10) + (placeCards1.Count * (card.width / 3)), Character1.Top + (Character1.Height / 2))
            placeCards1.Add(card)
            PlaceCardsTop = card.top
        ElseIf plOn = "Character2" Then
            card.Location = New Point(Character2.Left + (card.width / 10) + (placeCards2.Count * (card.width / 3)), Character2.Top + (Character2.Height / 2))
            placeCards2.Add(card)
            PlaceCardsTop = card.top
        ElseIf plOn = "Character3" Then
            card.Location = New Point(Character3.Left + (card.width / 10) + (placeCards3.Count * (card.width / 3)), Character3.Top + (Character3.Height / 2))
            placeCards3.Add(card)
            PlaceCardsTop = card.top
        ElseIf plOn = "Character4" Then
            card.Location = New Point(Character4.Left + (card.width / 10) + (placeCards4.Count * (card.width / 3)), Character4.Top + (Character4.Height / 2))
            placeCards4.Add(card)
            PlaceCardsBackTop = card.top
        ElseIf plOn = "Homebase" Then
            card.Location = New Point(Homebase.Left + (card.width / 10) + (placeCardsH.Count * (card.width / 3)), Homebase.Top + (Homebase.Height / 2))
            placeCardsH.Add(card)
            PlaceCardsBackTop = card.top
        End If

        Dim c As New Cereal
        c.id = card.id
        c.cardType = card.GetType.ToString
        c.placed = card.placed
        c.placedOn = card.placedOn

        Thread.Sleep(200)

        If Host = True Then
            hSendCard(c)
        Else
            cSendCard(c)
        End If
    End Sub
    '
    '
    'resize the hand
    Public Sub ResizeHand()
        Dim space As Decimal = HandCardTop
        If handCards.Count <= 4 Then
            For Each card In handCards
                card.Top = space
                card.BringToFront()
                space += card.Height + (HandCardSize.Height / 10)
            Next
        Else
            For Each card In handCards
                card.Top = space
                card.BringToFront()
                space += Me.Height / handCards.Count / 1.25
            Next
        End If
    End Sub
    '
    '
    'draw a card
    Private Sub DrawCard()
        For Each ca In handCards
            If ca.left <> HandCardLeft Then
                ca.left = HandCardLeft
            End If
        Next

        If myDeckCards.Count > 1 Then
            handCards.Add(myDeckCards(1))
            handCards(handCards.Count).Location = New Point(HandCardLeft, HandCardTop)

            If handCards(handCards.Count).wide = True Then
                handCards(handCards.Count).Size = New Size(HandCardSize.Height, HandCardSize.Width)
            Else
                handCards(handCards.Count).Size = New Size(HandCardSize)
            End If

            handCards(handCards.Count).Visible = True
            handCards(handCards.Count).BorderStyle = BorderStyle.FixedSingle
            Me.Controls.Add(handCards(handCards.Count))
            addHandlers(handCards(handCards.Count))
            myDeckCards.Remove(1)
            ResizeHand()

            If StifleDraw <> True Then
                Dim a As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
                Dim s As System.IO.Stream = a.GetManifestResourceStream("OverPower.DealCard.wav")
                Dim player As SoundPlayer = New SoundPlayer(s)
                player.Play()
                Thread.Sleep(300)
                If Host = True Then
                    hSendCommand("drawcard")
                Else
                    cSendCommand("drawcard")
                End If
            End If

        ElseIf myDeckCards.Count = 1 Then
            handCards.Add(myDeckCards(1))
            handCards(handCards.Count).Location = New Point(HandCardLeft, HandCardTop)

            If handCards(handCards.Count).wide = True Then
                handCards(handCards.Count).Size = New Size(HandCardSize.Height, HandCardSize.Width)
            Else
                handCards(handCards.Count).Size = New Size(HandCardSize)
            End If

            handCards(handCards.Count).Visible = True
            handCards(handCards.Count).BorderStyle = BorderStyle.FixedSingle
            Me.Controls.Add(handCards(handCards.Count))
            If inPP = False Then
                addHandlers(handCards(handCards.Count))
            End If
            myDeckCards.Remove(1)
            ResizeHand()

            If powerP.Count > 0 Then
                ReshufflePP()
            Else
                DrawPile.Image = Nothing
            End If

            If StifleDraw <> True Then
                Dim a As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
                Dim s As System.IO.Stream = a.GetManifestResourceStream("OverPower.DealCard.wav")
                Dim player As SoundPlayer = New SoundPlayer(s)
                player.Play()
                Thread.Sleep(300)
                If Host = True Then
                    hSendCommand("drawcard")
                Else
                    cSendCommand("drawcard")
                End If
            End If

        ElseIf myDeckCards.Count = 0 Then
            MsgBox("You have no more cards to draw from!", MsgBoxStyle.Critical, "No Cards!")
        End If
    End Sub
    '
    '
    'draw a new hand
    Public Sub DrawHand()
        If myDeckCards.Count > DrawNum Then
            If Host = True Then
                hSendCommand("drawhand")
            Else
                cSendCommand("drawhand")
            End If
            For i = 1 To DrawNum
                DrawCard()
            Next
            StifleDraw = False
        ElseIf myDeckCards.Count = DrawNum Then
            For i = 1 To DrawNum
                DrawCard()
            Next
            If Host = True Then
                hSendCommand("drawhand")
            Else
                cSendCommand("drawhand")
            End If
            StifleDraw = False
        ElseIf myDeckCards.Count < DrawNum Then
            If (myDeckCards.Count + powerP.Count) >= DrawNum Then
                If powerP.Count > 0 Then
                    ReshufflePP()
                End If
                If Host = True Then
                    hSendCommand("drawhand")
                Else
                    cSendCommand("drawhand")
                End If
                StifleDraw = False
            ElseIf (myDeckCards.Count + powerP.Count) > 0 Then
                If powerP.Count > 0 Then
                    ReshufflePP()
                End If
                If Host = True Then
                    hSendCommand("drawhand")
                Else
                    cSendCommand("drawhand")
                End If
                StifleDraw = False
            Else
                MsgBox("You have no more cards to draw from", MsgBoxStyle.Critical, "")
            End If
        End If
    End Sub
    '
    '
    'discard a card
    Private Sub Discard()
        Dim a As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
        Dim s As System.IO.Stream = a.GetManifestResourceStream("OverPower.Discard.wav")
        Dim player As SoundPlayer = New SoundPlayer(s)
        player.Play()

        If tempCard.hit = True Or tempCard.perm = True Then
            If TypeOf tempCard Is PowerCard Then
                If OppPowerPack.Visible = False Then
                    OppPowerPack.Visible = True
                End If
                oppPowerP.Add(tempCard)
                OppPowerPack.Image = tempCard.Image
            Else
                If OppDeadPile.Visible = False Then
                    OppDeadPile.Visible = True
                End If
                oppDeadP.Add(tempCard)
                OppDeadPile.Image = tempCard.Image
            End If
        Else
            If TypeOf tempCard Is PowerCard Then
                If PowerPack.Visible = False Then
                    PowerPack.Visible = True
                End If
                powerP.Add(tempCard)
                PowerPack.Image = tempCard.Image
            ElseIf TypeOf tempCard Is MissionEvent Then
                If DefeatedChars.Visible = False Then
                    DefeatedChars.Visible = True
                End If
                dChars.Add(tempCard)
                DefeatedChars.Image = tempCard.Image
                DefeatedChars.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
                rotated = False
            ElseIf TypeOf tempCard Is Character Then
                'do nothing for now
            Else
                If DeadPile.Visible = False Then
                    DeadPile.Visible = True
                End If
                deadP.Add(tempCard)
                DeadPile.Image = tempCard.Image
            End If
        End If

        If tempCard.placed = True Then
            ReorganizePlaced()
        ElseIf tempCard.played = True Then
            ReorganizePlayed()
        ElseIf tempCard.hit = True Then
            ReorganizeHits()
        ElseIf tempCard.perm = True Then
            ReorganizePerms()
            'if it was a hand card
        Else
            Dim i As Integer = 1
            While tempCard IsNot handCards(i) And i <= handCards.Count
                i += 1
            End While
            handCards.Remove(i)
            ResizeHand()
        End If

        Dim c As New Cereal
        c.discard = True
        c.id = tempCard.id
        c.cardType = tempCard.GetType.ToString
        If tempCard.placed = True Then
            c.placed = True
        ElseIf tempCard.played = True Then
            c.played = True
        ElseIf tempCard.hit = True Then
            c.hit = True
        ElseIf tempCard.perm = True Then
            c.perm = True
        End If

        If Host = True Then
            hSendCard(c)
        Else
            cSendCard(c)
        End If

        Me.Controls.Remove(tempCard)

        tempCard.placed = False
        tempCard.played = False
        tempCard.hit = False
        tempCard.perm = False
        tempCard.attack = False
        tempCard.defend = False
        tempCard.placedOn = Nothing
        tempCard.hitOn = Nothing
    End Sub
    '
    '
    'discards the current hand
    Public Sub DiscardHand()
        For Each card In handCards
            If TypeOf card Is PowerCard Then
                If PowerPack.Visible = False Then
                    PowerPack.Visible = True
                End If
                powerP.Add(card)
                PowerPack.Image = card.Image
            ElseIf TypeOf card Is MissionEvent Then
                If DefeatedChars.Visible = False Then
                    DefeatedChars.Visible = True
                End If
                dChars.Add(card)
                DefeatedChars.Image = card.Image
                DefeatedChars.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
                rotated = False
            ElseIf TypeOf card Is Character Then
                'do nothing for now
            Else
                If DeadPile.Visible = False Then
                    DeadPile.Visible = True
                End If
                deadP.Add(card)
                DeadPile.Image = card.Image
            End If

            Me.Controls.Remove(card)
        Next

        handCards.Clear()

        If oppHandCards.Count = 0 Then
            UpdateStatus(OUID + " had no cards left in hand. The next battle has begun, and you are now in the Discard Phase. Play your events at this time.")
            If Host = True Then
                hSendCommand("doneshowingdiscards")
            Else
                cSendCommand("doneshowingdiscards")
            End If

            If Event1.ID > 0 Then
                Event1.Image = Nothing
                Event1.Visible = False
                Dim t As New MissionEvent(Event1.ID)
                If DefeatedChars.Visible = False Then
                    DefeatedChars.Visible = True
                End If
                dChars.Add(t)
                DefeatedChars.Image = t.Image
                DefeatedChars.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
            End If

            If Event2.ID > 0 Then
                Event2.Image = Nothing
                Event2.Visible = False
                Dim x As New MissionEvent(Event2.ID)
                If OppDefeatedChars.Visible = False Then
                    OppDefeatedChars.Visible = True
                End If
                oppDChars.Add(x)
                OppDefeatedChars.Image = x.Image
                OppDefeatedChars.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
            End If

            done = False
            Phase.Text = "DISCARD"
            bPhase.Enabled = True
            bPhase.Font = New Font(bPhase.Font, FontStyle.Bold)
        Else
            frmShowDiscards.sz = New Size(Homebase.Height, Homebase.Width)
            frmShowDiscards.ShowDialog()
        End If
    End Sub
    '
    '
    'add a card to hand from draw pile
    Public Sub ToHand(card As Object)
        handCards.Add(card)
        handCards(handCards.Count).Location = New Point(HandCardLeft, HandCardTop)

        If handCards(handCards.Count).wide = True Then
            handCards(handCards.Count).Size = New Size(HandCardSize.Height, HandCardSize.Width)
        Else
            handCards(handCards.Count).Size = New Size(HandCardSize)
        End If

        handCards(handCards.Count).Visible = True
        handCards(handCards.Count).BorderStyle = BorderStyle.FixedSingle
        Me.Controls.Add(handCards(handCards.Count))
        ResizeHand()

        Dim c As New Cereal
        c.id = card.id
        c.cardType = card.GetType.ToString
        c.backToHand = True

        If Host = True Then
            hSendCard(c)
        Else
            cSendCard(c)
        End If

        Dim a As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
        Dim s As System.IO.Stream = a.GetManifestResourceStream("OverPower.DealCard.wav")
        Dim player As SoundPlayer = New SoundPlayer(s)
        player.Play()
    End Sub
    '
    '
    'removes a card
    Private Sub RemoveCard(card As Object)
        Me.Controls.Remove(card)
        If DeadPile.Visible = False Then
            DeadPile.Visible = True
        End If
        deadP.Add(card)
        DeadPile.Image = card.Image

        Dim a As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
        Dim s As System.IO.Stream = a.GetManifestResourceStream("OverPower.Discard.wav")
        Dim player As SoundPlayer = New SoundPlayer(s)
        player.Play()
    End Sub
    '
    '
    'removes an opponent's card
    Private Sub RemoveOppCard(card As Object)
        Me.Controls.Remove(card)
        If OppDeadPile.Visible = False Then
            OppDeadPile.Visible = True
        End If
        oppDeadP.Add(card)
        OppDeadPile.Image = card.Image
        Dim a As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
        Dim s As System.IO.Stream = a.GetManifestResourceStream("OverPower.Discarded.wav")
        Dim player As SoundPlayer = New SoundPlayer(s)
        player.Play()
    End Sub
    '
    '
    'remove a card from opponent's hand
    Private Sub RemoveFromOppHand(temp As Object)
        Dim i = 1
        While temp.GetType.ToString <> oppHandCards(i).GetType.ToString Or temp.id <> oppHandCards(i).id
            i += 1
        End While
        oppHandCards.Remove(i)
        lblOHS.Text = OUID + " Hand Size = " + oppHandCards.Count.ToString

        If frmShowHand.Visible = True Then
            frmShowHand.UpdateHand()
        End If
    End Sub
    '
    '
    'remove from one pile
    Private Sub RemoveFromPile(crl As Cereal)
        Dim fromPile As New Collection
        Dim fPile As New PictureBox
        If crl.fromPile = "MyDraw" Then
            AddToPile(crl)
            Exit Sub
        ElseIf crl.fromPile = "OppDraw" Then
            fromPile = myDeckCards
            fPile = DrawPile
        ElseIf crl.fromPile = "MyPP" Then
            fromPile = oppPowerP
            fPile = OppPowerPack
        ElseIf crl.fromPile = "MyDP" Then
            fromPile = oppDeadP
            fPile = OppDeadPile
        ElseIf crl.fromPile = "MyDChars" Then
            fromPile = oppDChars
            fPile = OppDefeatedChars
        ElseIf crl.fromPile = "OppPP" Then
            fromPile = powerP
            fPile = PowerPack
        ElseIf crl.fromPile = "OppDP" Then
            fromPile = deadP
            fPile = DeadPile
        ElseIf crl.fromPile = "OppDChars" Then
            fromPile = dChars
            fPile = DefeatedChars
        End If

        Dim i = 1
        For Each card In fromPile
            If card.id = crl.id And card.GetType.ToString = crl.cardType Then
                If crl.fromPile <> "OppDraw" Then
                    If fromPile.Count = 1 Then
                        fPile.Image = Nothing
                        fPile.Visible = False
                    ElseIf fromPile.Count = i Then
                        fPile.Image = fromPile(i - 1).image
                    End If
                End If
                fromPile.Remove(i)
                Exit For
            Else
                i += 1
            End If
        Next

        AddToPile(crl)
    End Sub
    '
    '
    'put in a pile
    Private Sub AddToPile(crl As Cereal)
        Dim toPile As Collection
        Dim Pile As PictureBox
        If crl.toPile = "MyDraw" Then
            Exit Sub
        ElseIf crl.toPile = "MyPP" Then
            toPile = oppPowerP
            Pile = OppPowerPack
        ElseIf crl.toPile = "MyDP" Then
            toPile = oppDeadP
            Pile = OppDeadPile
        ElseIf crl.toPile = "MyDChars" Then
            toPile = oppDChars
            Pile = OppDefeatedChars
        ElseIf crl.toPile = "OppDraw" Then
            toPile = myDeckCards
            Pile = DrawPile
        ElseIf crl.toPile = "OppPP" Then
            toPile = powerP
            Pile = PowerPack
        ElseIf crl.toPile = "OppDP" Then
            toPile = deadP
            Pile = DeadPile
        ElseIf crl.toPile = "OppDChars" Then
            toPile = dChars
            Pile = DefeatedChars
        Else
            Exit Sub
        End If

        Dim t = MakeCard(crl)
        If Pile.Visible = False Then
            Pile.Visible = True
        End If
        toPile.Add(t)
        Pile.Image = t.image

        Dim a As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
        Dim s As System.IO.Stream = a.GetManifestResourceStream("OverPower.Discard.wav")
        Dim player As SoundPlayer = New SoundPlayer(s)
        player.Play()
    End Sub
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    'show the activator's usable cards
    Private Sub ShowBSlistbox(activator As Object)
        Dim index = 1
        BSlistbox.Items.Clear()
        actUsuables.Clear()
        BSlistbox.BeginUpdate()
        For Each card In myBsDeck
            If card.cID = activator.cID Then
                actUsuables.Add(index)
                BSlistbox.Items.Add(card.cName + ": " + card.effect)
            End If
            index += 1
        Next
        BSlistbox.EndUpdate()
        BSlistbox.Top = activator.top
        BSlistbox.Left = activator.left - BSlistbox.Width
        BSlistbox.Visible = True
    End Sub
    '
    '
    'show move instruction box
    Private Sub ShowMoveBox()
        MoveBox.Location = DefendBox.Location
        MoveBox.Visible = True
        bM.Visible = False
        bR.Visible = False
        b2P.Visible = False
    End Sub
    '
    '
    'shows the attack box with buttons
    Private Sub ShowAttackBox()
        PlayTextBox.Visible = False
        AttackBox.BringToFront()
        bCancel.Location = New Point(AttackBox.Right - bCancel.Width - 3, AttackBox.Bottom - bCancel.Height - 2)
        bCancel.Enabled = True
        bCancel.Font = New Font(bCancel.Font, FontStyle.Bold)
        bMin.Location = New Point(AttackBox.Right - bMin.Width - 2, AttackBox.Top + 2)
        bMin.Visible = True
        bMin.BringToFront()
        cbFacedown.Location = New Point(bCancel.Right - cbFacedown.Width, bCancel.Top - cbFacedown.Height - 2)
        cbFacedown.Enabled = True
        cbFacedown.Visible = True
        cbFacedown.Checked = False
        bAttack.Location = New Point(bCancel.Left, cbFacedown.Top - bAttack.Height - 2)
        bAttack.Visible = True
        bAttack.BringToFront()
        bCancel.BringToFront()
        cbFacedown.BringToFront()
        AttackBox.Visible = True
    End Sub
    '
    '
    'shows the defend box with buttons
    Private Sub ShowDefendBox()
        Dim a As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
        Dim s As System.IO.Stream = a.GetManifestResourceStream("OverPower.Attacked.wav")
        Dim player As SoundPlayer = New SoundPlayer(s)
        player.Play()

        DefendBox.BringToFront()
        bShift.Location = New Point(DefendBox.Right - bShift.Width - 3, DefendBox.Bottom - bShift.Height - 2)
        bShift.Visible = True
        bShift.Font = New Font(bHits.Font, FontStyle.Bold)
        bShift.Enabled = True
        bShift.BringToFront()
        bHits.Location = New Point(bShift.Left, bShift.Top - bHits.Height - 1)
        bHits.Visible = True
        bHits.Font = bShift.Font
        bHits.Enabled = True
        bHits.BringToFront()
        bMin.Location = New Point(DefendBox.Right - bMin.Width - 2, DefendBox.Top + 2)
        bMin.Visible = True
        bMin.BringToFront()
        bDefend.Location = New Point(bHits.Left, bHits.Top - bDefend.Height - 1)
        bDefend.Visible = True
        bDefend.Font = bHits.Font
        bDefend.Enabled = True
        bDefend.BringToFront()
        DefendBox.Visible = True
    End Sub
    '
    '
    'shows the accept box with buttons
    Private Sub ShowAcceptBox()
        AcceptBox.BringToFront()
        bChallenge.Location = New Point(AcceptBox.Right - bChallenge.Width - 3, AcceptBox.Bottom - bChallenge.Height - 3)
        bChallenge.Visible = True
        bChallenge.Font = New Font(bChallenge.Font, FontStyle.Bold)
        bChallenge.Enabled = True
        bChallenge.BringToFront()
        bMin.Location = New Point(AcceptBox.Right - bMin.Width - 2, AcceptBox.Top + 2)
        bMin.Visible = True
        bMin.BringToFront()
        bAccept.Location = New Point(bChallenge.Left, bChallenge.Top - bAccept.Height - 3)
        bAccept.Visible = True
        bAccept.Font = bChallenge.Font
        bAccept.Enabled = True
        bAccept.BringToFront()
        AcceptBox.Visible = True
        AttackBox.Visible = False
        bCancel.Visible = False
        bAttack.Visible = False
        cbFacedown.Visible = False

        Dim a As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
        Dim s As System.IO.Stream = a.GetManifestResourceStream("OverPower.Defended.wav")
        Dim player As SoundPlayer = New SoundPlayer(s)
        player.Play()
    End Sub
    '
    '
    'shows the attack panel
    Private Sub ShowAttackPanel()
        If AttackBox.Visible = True Then
            AttackPanel.BringToFront()
            AttackPanel.Left = (AttackBox.Left + AttackBox.Width / 2) - ((AttackCards.Count + 1) * (DrawPile.Width + (DrawPile.Width / 10))) - (DrawPile.Width / 10)
            AttackPanel.Width = (AttackCards.Count + 1) * (DrawPile.Width + (DrawPile.Width / 10)) + (DrawPile.Width / 10)
            AttackPanel.Visible = True
        Else
            AttackPanel.BringToFront()
            AttackPanel.Left = (DefendBox.Left + (DefendBox.Width / 2)) - (AttackCards.Count * (DrawPile.Width + (DrawPile.Width / 10))) - (DrawPile.Width / 10)

            If AttackPanel.Panel2Collapsed = True Then
                AttackPanel.Panel2Collapsed = False
            End If

            AttackPanel.Width = (AttackCards.Count * (DrawPile.Width + (DrawPile.Width / 10))) + (DrawPile.Width / 10) + AttackPanel.SplitterWidth + ((DefendCards.Count + 1) * (DrawPile.Width + (DrawPile.Width / 10)) + (DrawPile.Width / 10))
            AttackPanel.SplitterDistance = AttackCards.Count * (DrawPile.Width + (DrawPile.Width / 10)) + (DrawPile.Width / 10)
            AttackPanel.Visible = True
        End If
    End Sub
    '
    '
    'sets attack buttons' visibility
    Private Sub setAttackButtonsVis(b As Boolean)
        bCancel.Visible = b
        bAttack.Visible = b
        cbFacedown.Visible = b
    End Sub
    '
    '
    'sets defend buttons' visibility
    Private Sub setDefendButtonsVis(b As Boolean)
        bHits.Visible = b
        bDefend.Visible = b
        bShift.Visible = b
    End Sub
    '
    '
    'sets accept buttons' visibility
    Private Sub setAcceptButtonsVis(b As Boolean)
        bChallenge.Visible = b
        bAccept.Visible = b
    End Sub
    '
    '
    'reorganize placed cards
    Private Sub ReorganizePlaced()
        Dim i As Integer
        For Each pp In placeCards
            i = 1
            While i <= pp.Count
                If tempCard IsNot pp(i) Then
                    i += 1
                Else
                    pp.remove(i)
                    If pp Is placeCards4 Or pp Is placeCardsH Then
                        While i <= pp.count
                            pp(i).location = New Point(pp(i).left - (pp(i).width / 3), PlaceCardsBackTop)
                            i += 1
                        End While
                        Exit For
                    Else
                        While i <= pp.count
                            pp(i).location = New Point(pp(i).left - (pp(i).width / 3), PlaceCardsTop)
                            i += 1
                        End While
                        Exit For
                    End If
                End If
            End While
        Next
    End Sub
    '
    '
    'reorganize played cards
    Private Sub ReorganizePlayed()
        Dim i As Integer
        For Each pp In playCards
            i = 1
            While i <= pp.Count
                If tempCard IsNot pp(i) Then
                    i += 1
                Else
                    pp.remove(i)
                    If pp Is playCards4 Or pp Is playCardsH Then
                        While i <= pp.count
                            pp(i).location = New Point(pp(i).left - (pp(i).width / 3), PlayCardsBackTop)
                            i += 1
                        End While
                        Exit For
                    Else
                        While i <= pp.count
                            pp(i).location = New Point(pp(i).left - (pp(i).width / 3), PlayCardsTop)
                            i += 1
                        End While
                        Exit For
                    End If
                End If
            End While
        Next
    End Sub
    '
    '
    'reorganize hits from current battle cards
    Private Sub ReorganizeHits()
        Dim i = 1
        If tempCard.HitOn = "Character1" Then
            For Each hc In hitCards1
                If tempCard.GetType.ToString = hc.GetType.ToString And tempCard.id = hc.id Then
                    If StifleHits = False Then
                        Me.Controls.Remove(hc)
                    End If
                    hitCards1.Remove(i)
                    While i <= hitCards1.Count
                        hitCards1(i).left -= (hc.Width / 3)
                        i += 1
                    End While
                    Exit For
                Else
                    i += 1
                End If
            Next
        ElseIf tempCard.HitOn = "Character2" Then
            For Each hc In hitCards2
                If tempCard.GetType.ToString = hc.GetType.ToString And tempCard.id = hc.id Then
                    If StifleHits = False Then
                        Me.Controls.Remove(hc)
                    End If
                    hitCards2.Remove(i)
                    While i <= hitCards2.Count
                        hitCards2(i).left -= (hc.Width / 3)
                        i += 1
                    End While
                    Exit For
                Else
                    i += 1
                End If
            Next
        ElseIf tempCard.HitOn = "Character3" Then
            For Each hc In hitCards3
                If tempCard.GetType.ToString = hc.GetType.ToString And tempCard.id = hc.id Then
                    If StifleHits = False Then
                        Me.Controls.Remove(hc)
                    End If
                    hitCards3.Remove(i)
                    While i <= hitCards3.Count
                        hitCards3(i).left -= (hc.Width / 3)
                        i += 1
                    End While
                    Exit For
                Else
                    i += 1
                End If
            Next
        ElseIf tempCard.HitOn = "Battlesite" Then
            For Each hc In hitCardsB
                If tempCard.GetType.ToString = hc.GetType.ToString And tempCard.id = hc.id Then
                    If StifleHits = False Then
                        Me.Controls.Remove(hc)
                    End If
                    hitCardsB.Remove(i)
                    While i <= hitCardsB.Count
                        hitCardsB(i).left -= (hc.Width / 3)
                        i += 1
                    End While
                    Exit For
                Else
                    i += 1
                End If
            Next
        ElseIf tempCard.HitOn = "Character4" Then
            For Each hc In hitCards4
                If tempCard.GetType.ToString = hc.GetType.ToString And tempCard.id = hc.id Then
                    If StifleHits = False Then
                        Me.Controls.Remove(hc)
                    End If
                    hitCards4.Remove(i)
                    While i <= hitCards4.Count
                        hitCards4(i).left += (hc.Width / 3)
                        i += 1
                    End While
                    Exit For
                Else
                    i += 1
                End If
            Next
        End If
    End Sub
    '
    '
    'reorganize permanent record cards
    Private Sub ReorganizePerms()
        Dim i As Integer
        For Each pp In permCards
            i = 1
            While i <= pp.Count
                If tempCard IsNot pp(i) Then
                    i += 1
                Else
                    pp.remove(i)
                    If pp Is permCards4 Then
                        i = 1
                        While i <= pp.count
                            pp(i).location = New Point(Character4.Left - (pp(i).width / 3), Character4.Top + (pp(i).height / 20) + (i * (pp(i).height / 5)))
                            i += 1
                        End While
                        Exit For
                    Else
                        While i <= pp.count
                            pp(i).location = New Point(pp(i).left - (pp(i).width / 3), PermCardsTop)
                            i += 1
                        End While
                        Exit For
                    End If
                End If
            End While
        Next
    End Sub
    '
    '
    'reorganize opponent placed cards
    Private Sub OppReorganizePlaced(temp As Object)
        Dim i = 1
        If temp.placedOn = "Character1" Then
            For Each pc In oppPlaceCards1
                If temp.GetType.ToString = pc.GetType.ToString And temp.id = pc.id Then
                    Me.Controls.Remove(pc)
                    oppPlaceCards1.Remove(i)
                    While i <= oppPlaceCards1.Count
                        oppPlaceCards1(i).left -= (pc.Width / 3)
                        i += 1
                    End While
                    Exit For
                Else
                    i += 1
                End If
            Next
        ElseIf temp.placedOn = "Character2" Then
            For Each pc In oppPlaceCards2
                If temp.GetType.ToString = pc.GetType.ToString And temp.id = pc.id Then
                    Me.Controls.Remove(pc)
                    oppPlaceCards2.Remove(i)
                    While i <= oppPlaceCards2.Count
                        oppPlaceCards2(i).left -= (pc.Width / 3)
                        i += 1
                    End While
                    Exit For
                Else
                    i += 1
                End If
            Next
        ElseIf temp.placedOn = "Character3" Then
            For Each pc In oppPlaceCards3
                If temp.GetType.ToString = pc.GetType.ToString And temp.id = pc.id Then
                    Me.Controls.Remove(pc)
                    oppPlaceCards3.Remove(i)
                    While i <= oppPlaceCards3.Count
                        oppPlaceCards3(i).left -= (pc.Width / 3)
                        i += 1
                    End While
                    Exit For
                Else
                    i += 1
                End If
            Next
        ElseIf temp.placedOn = "Character4" Then
            For Each pc In oppPlaceCards4
                If temp.GetType.ToString = pc.GetType.ToString And temp.id = pc.id Then
                    Me.Controls.Remove(pc)
                    oppPlaceCards4.Remove(i)
                    While i <= oppPlaceCards4.Count
                        oppPlaceCards4(i).left -= (pc.Width / 3)
                        i += 1
                    End While
                    Exit For
                Else
                    i += 1
                End If
            Next
        ElseIf temp.placedOn = "Homebase" Then
            For Each pc In oppPlaceCardsH
                If temp.GetType.ToString = pc.GetType.ToString And temp.id = pc.id Then
                    Me.Controls.Remove(pc)
                    oppPlaceCardsH.Remove(i)
                    While i <= oppPlaceCardsH.Count
                        oppPlaceCardsH(i).left -= (pc.Width / 3)
                        i += 1
                    End While
                    Exit For
                Else
                    i += 1
                End If
            Next
        End If
    End Sub
    '
    '
    'reorganize opponent played cards
    Private Sub OppReorganizePlayed(temp As Object)
        Dim i As Integer
        For Each pp In oppPlayCards
            i = 1
            While i <= pp.Count
                If temp.GetType = pp(i).GetType And temp.id = pp(i).id Then
                    Me.Controls.Remove(pp(i))
                    pp.remove(i)
                    If pp Is oppPlayCards4 Or pp Is oppPlayCardsH Then
                        While i <= pp.count
                            pp(i).location = New Point(pp(i).left - (pp(i).width / 3), OppPlayCardsBackTop)
                            i += 1
                        End While
                        Exit For
                    Else
                        While i <= pp.count
                            pp(i).location = New Point(pp(i).left - (pp(i).width / 3), OppPlayCardsTop)
                            i += 1
                        End While
                        Exit For
                    End If
                Else
                    i += 1
                End If
            End While
        Next
    End Sub
    '
    '
    'reorganize opponent hits in current battle cards
    Private Sub OppReorganizeHits(temp As Object)
        Dim i = 1
        If temp.HitOn = "Character1" Then
            For Each hc In oppHitCards1
                If temp.GetType.ToString = hc.GetType.ToString And temp.id = hc.id Then
                    If StifleHits = False Then
                        Me.Controls.Remove(hc)
                    End If
                    tempCard = hc
                    oppHitCards1.Remove(i)
                    While i <= oppHitCards1.Count
                        oppHitCards1(i).left -= (hc.Width / 3)
                        i += 1
                    End While
                    Exit For
                Else
                    i += 1
                End If
            Next
        ElseIf temp.HitOn = "Character2" Then
            For Each hc In oppHitCards2
                If temp.GetType.ToString = hc.GetType.ToString And temp.id = hc.id Then
                    If StifleHits = False Then
                        Me.Controls.Remove(hc)
                    End If
                    tempCard = hc
                    oppHitCards2.Remove(i)
                    While i <= oppHitCards2.Count
                        oppHitCards2(i).left -= (hc.Width / 3)
                        i += 1
                    End While
                    Exit For
                Else
                    i += 1
                End If
            Next
        ElseIf temp.HitOn = "Character3" Then
            For Each hc In oppHitCards3
                If temp.GetType.ToString = hc.GetType.ToString And temp.id = hc.id Then
                    If StifleHits = False Then
                        Me.Controls.Remove(hc)
                    End If
                    tempCard = hc
                    oppHitCards3.Remove(i)
                    While i <= oppHitCards3.Count
                        oppHitCards3(i).left -= (hc.Width / 3)
                        i += 1
                    End While
                    Exit For
                Else
                    i += 1
                End If
            Next
        ElseIf temp.HitOn = "Battlesite" Then
            For Each hc In oppHitCardsB
                If temp.GetType.ToString = hc.GetType.ToString And temp.id = hc.id Then
                    If StifleHits = False Then
                        Me.Controls.Remove(hc)
                    End If
                    tempCard = hc
                    oppHitCardsB.Remove(i)
                    While i <= oppHitCardsB.Count
                        oppHitCardsB(i).left -= (hc.Width / 3)
                        i += 1
                    End While
                    Exit For
                Else
                    i += 1
                End If
            Next
        ElseIf temp.HitOn = "Character4" Then
            For Each hc In oppHitCards4
                If temp.GetType.ToString = hc.GetType.ToString And temp.id = hc.id Then
                    If StifleHits = False Then
                        Me.Controls.Remove(hc)
                    End If
                    tempCard = hc
                    oppHitCards4.Remove(i)
                    While i <= oppHitCards4.Count
                        oppHitCards4(i).left += (hc.Width / 3)
                        i += 1
                    End While
                    Exit For
                Else
                    i += 1
                End If
            Next
        End If
    End Sub
    '
    '
    'reorganize opponent permanent record cards
    Private Sub OppReorganizePerms(temp As Object)
        Dim i As Integer
        For Each pp In oppPermCards
            i = 1
            While i <= pp.Count
                If temp.GetType = pp(i).GetType And temp.id = pp(i).id Then
                    Me.Controls.Remove(pp(i))
                    pp.remove(i)
                    While i <= pp.count
                        pp(i).location = New Point(pp(i).left, pp(i).top + (pp(i).height / 3))
                        i += 1
                    End While
                Else
                    i += 1
                End If
            End While
        Next
    End Sub
    '
    '
    'moves cards from hits in current battle to permanent records
    Public Sub MoveToPerm()
        For Each hit In hitCards1
            If TypeOf hit Is Special Then
                If hit.vv > 0 Or hit.meta = "NU" Or hit.meta = "GD" Or hit.meta = "BA" Then
                    hit.location = New Point(Character1.Left + (hit.width / 10) + (permCards1.Count * (hit.width / 3)), Character1.Top - (hit.height / 5))
                    hit.hit = False
                    hit.perm = True
                    permCards1.Add(hit)
                    PermCardsTop = hit.top
                Else
                    RemoveOppCard(hit)
                End If
            Else
                hit.location = New Point(Character1.Left + (hit.width / 10) + (permCards1.Count * (hit.width / 3)), Character1.Top - (hit.height / 5))
                hit.hit = False
                hit.perm = True
                permCards1.Add(hit)
                PermCardsTop = hit.top
            End If
        Next
        For Each hit In hitCards2
            If TypeOf hit Is Special Then
                If hit.vv > 0 Or hit.meta = "NU" Or hit.meta = "GD" Or hit.meta = "BA" Then
                    hit.location = New Point(Character2.Left + (hit.width / 10) + (permCards2.Count * (hit.width / 3)), Character2.Top - (hit.height / 5))
                    hit.hit = False
                    hit.perm = True
                    permCards2.Add(hit)
                    PermCardsTop = hit.top
                Else
                    RemoveOppCard(hit)
                End If
            Else
                hit.location = New Point(Character2.Left + (hit.width / 10) + (permCards2.Count * (hit.width / 3)), Character2.Top - (hit.height / 5))
                hit.hit = False
                hit.perm = True
                permCards2.Add(hit)
                PermCardsTop = hit.top
            End If
        Next
        For Each hit In hitCards3
            If TypeOf hit Is Special Then
                If hit.vv > 0 Or hit.meta = "NU" Or hit.meta = "GD" Or hit.meta = "BA" Then
                    hit.location = New Point(Character3.Left + (hit.width / 10) + (permCards3.Count * (hit.width / 3)), Character3.Top - (hit.height / 5))
                    hit.hit = False
                    hit.perm = True
                    permCards3.Add(hit)
                    PermCardsTop = hit.top
                Else
                    RemoveOppCard(hit)
                End If
            Else
                hit.location = New Point(Character3.Left + (hit.width / 10) + (permCards3.Count * (hit.width / 3)), Character3.Top - (hit.height / 5))
                hit.hit = False
                hit.perm = True
                permCards3.Add(hit)
                PermCardsTop = hit.top
            End If
        Next
        For Each hit In hitCards4
            If TypeOf hit Is Special Then
                If hit.vv > 0 Or hit.meta = "NU" Or hit.meta = "GD" Or hit.meta = "BA" Then
                    hit.location = New Point(Character4.Left - (hit.width / 3), Character4.Top + (hit.height / 20) + (permCards4.Count * (hit.height / 5)))
                    hit.hit = False
                    hit.perm = True
                    permCards4.Add(hit)
                    PermCardsBackTop = hit.top
                Else
                    RemoveOppCard(hit)
                End If
            Else
                hit.location = New Point(Character4.Left - (hit.width / 3), Character4.Top + (hit.height / 20) + (permCards4.Count * (hit.height / 5)))
                hit.hit = False
                hit.perm = True
                permCards4.Add(hit)
                PermCardsBackTop = hit.top
            End If
        Next
        For Each hit In hitCardsB
            If TypeOf hit Is Special Then
                If hit.vv > 0 Or hit.meta = "NU" Or hit.meta = "GD" Or hit.meta = "BA" Then
                    hit.location = New Point(Battlesite.Left + (hit.width / 10) + (permCardsB.Count * (hit.width / 3)), Battlesite.Top - (hit.height / 5))
                    hit.hit = False
                    hit.perm = True
                    permCardsB.Add(hit)
                    PermCardsTop = hit.top
                Else
                    RemoveOppCard(hit)
                End If
            Else
                hit.location = New Point(Battlesite.Left + (hit.width / 10) + (permCardsB.Count * (hit.width / 3)), Battlesite.Top - (hit.height / 5))
                hit.hit = False
                hit.perm = True
                permCardsB.Add(hit)
                PermCardsTop = hit.top
            End If
        Next

        For Each pp In hitCards
            pp.clear()
        Next

        For Each pp In permCards
            Dim i = pp.count
            While i > 0
                pp(i).sendtoback()
                i -= 1
            End While
        Next

        For Each hit In oppHitCards1
            If TypeOf hit Is Special Then
                If hit.vv > 0 Or hit.meta = "NU" Or hit.meta = "GD" Or hit.meta = "BA" Then
                    hit.location = New Point(OppCharacter1.Left - (hit.width / 3), OppCharacter1.Top + (hit.height / 10) + (oppPermCards1.Count * (hit.width / 3)))
                    oppPermCards1.Add(hit)
                    OppPermCardsTop = hit.top
                Else
                    RemoveCard(hit)
                End If
            Else
                hit.location = New Point(OppCharacter1.Left - (hit.width / 3), OppCharacter1.Top + (hit.height / 10) + (oppPermCards1.Count * (hit.width / 3)))
                oppPermCards1.Add(hit)
                OppPermCardsTop = hit.top
            End If
        Next
        For Each hit In oppHitCards2
            If TypeOf hit Is Special Then
                If hit.vv > 0 Or hit.meta = "NU" Or hit.meta = "GD" Or hit.meta = "BA" Then
                    hit.location = New Point(OppCharacter2.Left - (hit.width / 3), OppCharacter2.Top + (hit.height / 10) + (oppPermCards2.Count * (hit.width / 3)))
                    oppPermCards2.Add(hit)
                    OppPermCardsTop = hit.top
                Else
                    RemoveCard(hit)
                End If
            Else
                hit.location = New Point(OppCharacter2.Left - (hit.width / 3), OppCharacter2.Top + (hit.height / 10) + (oppPermCards2.Count * (hit.width / 3)))
                oppPermCards2.Add(hit)
                OppPermCardsTop = hit.top
            End If
        Next
        For Each hit In oppHitCards3
            If TypeOf hit Is Special Then
                If hit.vv > 0 Or hit.meta = "NU" Or hit.meta = "GD" Or hit.meta = "BA" Then
                    hit.location = New Point(OppCharacter3.Left - (hit.width / 3), OppCharacter3.Top + (hit.height / 10) + (oppPermCards3.Count * (hit.width / 3)))
                    oppPermCards3.Add(hit)
                    OppPermCardsTop = hit.top
                Else
                    RemoveCard(hit)
                End If
            Else
                hit.location = New Point(OppCharacter3.Left - (hit.width / 3), OppCharacter3.Top + (hit.height / 10) + (oppPermCards3.Count * (hit.width / 3)))
                oppPermCards3.Add(hit)
                OppPermCardsTop = hit.top
            End If
        Next
        For Each hit In oppHitCards4
            If TypeOf hit Is Special Then
                If hit.vv > 0 Or hit.meta = "NU" Or hit.meta = "GD" Or hit.meta = "BA" Then
                    hit.location = New Point(OppCharacter4.Left - (hit.width / 3), OppCharacter4.Top + (hit.height / 10) + (oppPermCards4.Count * (hit.width / 3)))
                    oppPermCards4.Add(hit)
                    OppPermCardsBackTop = hit.top
                Else
                    RemoveCard(hit)
                End If
            Else
                hit.location = New Point(OppCharacter4.Left - (hit.width / 3), OppCharacter4.Top + (hit.height / 10) + (oppPermCards4.Count * (hit.width / 3)))
                oppPermCards4.Add(hit)
                OppPermCardsBackTop = hit.top
            End If
        Next
        For Each hit In oppHitCardsB
            If TypeOf hit Is Special Then
                If hit.vv > 0 Or hit.meta = "NU" Or hit.meta = "GD" Or hit.meta = "BA" Then
                    hit.location = New Point(OppBattlesite.Left - (hit.width / 4), OppBattlesite.Top + (hit.height / 10) + (oppPermCardsB.Count * (hit.width / 3)))
                    oppPermCardsB.Add(hit)
                    OppPermCardsTop = hit.top
                Else
                    RemoveCard(hit)
                End If
            Else
                hit.location = New Point(OppBattlesite.Left - (hit.width / 3), OppBattlesite.Top + (hit.height / 10) + (oppPermCardsB.Count * (hit.width / 3)))
                oppPermCardsB.Add(hit)
                OppPermCardsTop = hit.top
            End If
        Next

        For Each pp In oppHitCards
            pp.clear()
        Next

        For Each pp In oppPermCards
            Dim i = pp.count
            While i > 0
                pp(i).sendtoback()
                i -= 1
            End While
        Next

        For i = 1 To 4
            If tableCards(i).KO = True Then
                Dim t = New Character(tableCards(i).ID)
                t.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
                dChars.Add(t)
                If DefeatedChars.Visible = False Then
                    DefeatedChars.Visible = True
                End If
                DefeatedChars.Image = t.Image
                rotated = False
                If Character4.Visible = True And tableCards(i) IsNot Character4 Then
                    tableCards(i).Parse(Character4.ID)
                    Character4.Visible = False
                Else
                    tableCards(i).visible = False
                End If
                tableCards(i).KO = False
            End If
        Next

        For i = 7 To 10
            If tableCards(i).KO = True Then
                Dim t = New Character(tableCards(i).ID)
                t.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
                oppDChars.Add(t)
                If OppDefeatedChars.Visible = False Then
                    OppDefeatedChars.Visible = True
                End If
                OppDefeatedChars.Image = t.Image
                rotatedo = False
                If OppCharacter4.Visible = True And tableCards(i) IsNot OppCharacter4 Then
                    tableCards(i).Parse(OppCharacter4.ID)
                    OppCharacter4.Visible = False
                Else
                    tableCards(i).visible = False
                End If
                tableCards(i).KO = False
            End If
        Next

        BGclick()
    End Sub
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    'mouse events
    '
    '
    'shows cards from dead and power pack piles in big card places
    Private Sub Piles_Click(sender As Object, e As EventArgs) Handles PowerPack.MouseClick, OppPowerPack.MouseClick, OppDeadPile.MouseClick, DeadPile.MouseClick
        If PlaceTextBox.Visible = False And PlayTextBox.Visible = False Then
            BG_Click(sender, e)
            BigCardH.Visible = False
            BigCardV.Image = sender.Image
            BigCardV.Visible = True
        End If
    End Sub
    '
    '
    'shows card count in piles
    Private Sub Piles_MouseEnter(sender As Object, e As EventArgs) Handles PowerPack.MouseEnter, DrawPile.MouseEnter, DefeatedChars.MouseEnter, DeadPile.MouseEnter, OppPowerPack.MouseEnter, OppDrawPile.MouseEnter, OppDefeatedChars.MouseEnter, OppDeadPile.MouseEnter
        If sender Is PowerPack Then
            Label1.Text = powerP.Count.ToString
        ElseIf sender Is DrawPile Then
            Label1.Text = myDeckCards.Count.ToString
        ElseIf sender Is DefeatedChars Then
            Label1.Text = dChars.Count.ToString
        ElseIf sender Is DeadPile Then
            Label1.Text = deadP.Count.ToString
        ElseIf sender Is OppPowerPack Then
            Label1.Text = oppPowerP.Count.ToString
        ElseIf sender Is OppDrawPile Then
            Label1.Text = oppDeckCards.Count.ToString
        ElseIf sender Is OppDefeatedChars Then
            Label1.Text = oppDChars.Count.ToString
        ElseIf sender Is OppDeadPile Then
            Label1.Text = oppDeadP.Count.ToString
        End If
        Label1.Location = sender.Location
        Label1.Visible = True
        Label1.BringToFront()
    End Sub
    '
    '
    'hides card count in piles
    Private Sub Piles_MouseLeave(sender As Object, e As EventArgs) Handles PowerPack.MouseLeave, DrawPile.MouseLeave, DefeatedChars.MouseLeave, DeadPile.MouseLeave, OppPowerPack.MouseLeave, OppDrawPile.MouseLeave, OppDefeatedChars.MouseLeave, OppDeadPile.MouseLeave
        Label1.Visible = False
    End Sub
    '
    '
    'shows other cards in big card places
    Private Sub Wides_Click(sender As Object, e As MouseEventArgs) Handles Battlesite.MouseClick, Event1.MouseClick, Event2.MouseClick, OppHomebase.MouseClick, OppDefeatedChars.MouseClick, DefeatedChars.MouseClick
        If PlaceTextBox.Visible = False And PlayTextBox.Visible = False Then
            bP.Visible = False
            bD.Visible = False
            bR.Visible = False
            bDiscard.Visible = False
            bPlay.Visible = False
            bPlace.Visible = False
            b2C.Visible = False
            b2R.Visible = False
            b2D.Visible = False
            bPlusV.Visible = False
            bMinusV.Visible = False
            b2P.Visible = False

            'put hand cards back in place, if out of place
            For Each card In handCards
                If card.left <> HandCardLeft Then
                    card.Location = New Point(HandCardLeft, card.Top)
                End If
            Next

            tempCard = vbNull
            tempCharX = vbNull

            For Each pp In placeCards
                For Each card In pp
                    card.bringtofront()
                Next
            Next
            If sender Is DefeatedChars Or sender Is OppDefeatedChars Then
                BigCardV.Visible = False
                BigCardH.Image = sender.image
                BigCardH.Visible = True
                If sender Is DefeatedChars And rotated = False Then
                    BigCardH.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
                    rotated = True
                ElseIf sender Is OppDefeatedChars And rotatedo = False Then
                    BigCardH.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
                    rotatedo = True
                End If
            ElseIf sender Is Event1 Or sender Is Event2 Then
                BigCardV.Visible = False
                BigCardH.Image = sender.Image
                BigCardH.Visible = True
                TextBox1.Top = BigCardH.Bottom + 5
                TextBox1.Width = BigCardH.Width
                TextBox1.Visible = True
                TextBox1.Text = sender.effect
            ElseIf sender Is Battlesite Then
                BigCardV.Visible = False
                BigCardH.Image = sender.Image
                BigCardH.Visible = True
            ElseIf sender Is OppHomebase Then
                BigCardV.Visible = False
                BigCardH.Image = sender.Image
                BigCardH.Visible = True
                If sender.inherent <> "" Then
                    TextBox1.Top = BigCardH.Bottom + 5
                    TextBox1.Width = BigCardH.Width
                    TextBox1.Visible = True
                    TextBox1.Text = sender.inherent
                End If
            End If
            'ElseIf sender Is Battlesite Then
            '    BigCardV.Visible = False
            '    BigCardH.Image = sender.Image
            '    BigCardH.Visible = True
            'ElseIf sender Is Event1 Or sender Is Event2 Then
            '    BigCardV.Visible = False
            '    BigCardH.Image = sender.Image
            '    BigCardH.Visible = True
            'ElseIf sender Is OppHomebase Then
            '    BigCardV.Visible = False
            '    BigCardH.Image = sender.Image
            '    If sender.rotated = False Then
            '        BigCardH.Image.RotateFlip(RotateFlipType.Rotate180FlipNone)
            '        sender.rotated = True
            '    End If
            '    BigCardH.Visible = True
            '    If sender.inherent <> "" Then
            '        TextBox1.Top = BigCardH.Bottom + 5
            '        TextBox1.Width = BigCardH.Width
            '        TextBox1.Visible = True
            '        TextBox1.Text = sender.inherent
            '    End If
        End If
    End Sub
    '
    '
    'shows mission cards in big card places
    Private Sub Missions_Click(sender As Object, e As MouseEventArgs) Handles Mission1.MouseClick, Mission2.MouseClick, Mission3.MouseClick, Mission4.MouseClick, Mission5.MouseClick, Mission6.MouseClick, Mission7.MouseClick
        b2P.Visible = False
        bR.Visible = False
        bD.Visible = False
        bP.Visible = False

        For Each pp In placeCards
            For Each card In pp
                card.bringtofront()
            Next
        Next

        'puts hand cards back in place if out of place
        For Each card In handCards
            If card.left <> HandCardLeft And card IsNot sender Then
                bPlay.Visible = False
                bDiscard.Visible = False
                bPlace.Visible = False
                card.Location = New Point(HandCardLeft, card.Top)
                PlaceTextBox.Visible = False
            End If
        Next

        If Phase.Text = "VENTURE" Then
            If sender.pile = "Reserve" Then
                sender.left = VentureR.Left + (vReserveCards.Count * (sender.width / 3))
                sender.bringtofront()
                Dim i = 1
                While i <= ReserveCards.Count
                    If ReserveCards(i).orderNumber = sender.orderNumber Then
                        Exit While
                    Else
                        i += 1
                    End If
                End While
                ReserveCards.Remove(i)
                sender.pile = "VentureR"
                vReserveCards.Add(sender)

                If Host = True Then
                    hSendCommand("vfromreserve")
                Else
                    cSendCommand("vfromreserve")
                End If
            ElseIf sender.pile = "Completed" Then
                If DefeatedCards.Count > 0 Then
                    sender.left = VentureC.Left + (vCompletedCards.Count * (sender.width / 3))
                    sender.bringtofront()
                    Dim i = 1
                    While i <= CompletedCards.Count
                        If CompletedCards(i).orderNumber = sender.orderNumber Then
                            Exit While
                        Else
                            i += 1
                        End If
                    End While
                    CompletedCards.Remove(i)
                    sender.pile = "VentureC"
                    vCompletedCards.Add(sender)

                    If Host = True Then
                        hSendCommand("vfromcompleted")
                    Else
                        cSendCommand("vfromcompleted")
                    End If
                Else
                    MsgBox("You cannot venture from completed unless you have defeated missions.", MsgBoxStyle.Information, "")
                End If
            ElseIf sender.pile = "VentureR" Then
                Dim i = 1
                While i <= vReserveCards.Count
                    If vReserveCards(i).orderNumber = sender.orderNumber Then
                        Exit While
                    Else
                        i += 1
                    End If
                End While
                vReserveCards.Remove(i)

                For j = 1 To vReserveCards.Count
                    vReserveCards(j).left = VentureR.Left + ((j - 1) * (sender.width / 3))
                Next

                sender.left = Reserve.Left
                sender.bringtofront()
                sender.pile = "Reserve"
                ReserveCards.Add(sender)

                If Host = True Then
                    hSendCommand("vrtor")
                Else
                    cSendCommand("vrtor")
                End If
            ElseIf sender.pile = "VentureC" Then
                Dim i = 1
                While i <= vCompletedCards.Count
                    If vCompletedCards(i).orderNumber = sender.orderNumber Then
                        Exit While
                    Else
                        i += 1
                    End If
                End While
                vCompletedCards.Remove(i)

                For j = 1 To vCompletedCards.Count
                    vCompletedCards(j).left = VentureC.Left + ((j - 1) * (sender.width / 3))
                Next

                sender.left = Completed.Left
                sender.bringtofront()
                sender.pile = "Completed"
                CompletedCards.Add(sender)

                If Host = True Then
                    hSendCommand("vctoc")
                Else
                    cSendCommand("vctoc")
                End If
            End If

        ElseIf Phase.Text = "MOVE MISSIONS" Then
            b2D.Visible = False
            b2R.Visible = False
            b2C.Visible = False
            If sender.pile = "VentureC" Then
                b2R.Location = New Point(sender.left + 2, sender.bottom - b2R.Height - 2)
                b2R.Visible = True
                b2C.Location = New Point(b2R.Left, b2R.Top - b2C.Height - 2)
                b2C.Visible = True
                b2R.BringToFront()
                b2C.BringToFront()
                tempCard = sender
            ElseIf sender.pile = "VentureR" Then
                b2D.Location = New Point(sender.left + 2, sender.bottom - b2D.Height - 2)
                b2D.Visible = True
                b2R.Location = New Point(b2D.Left, b2D.Top - b2R.Height - 2)
                b2R.Visible = True
                b2C.Location = New Point(b2R.Left, b2R.Top - b2C.Height - 2)
                b2C.Visible = True
                b2R.BringToFront()
                b2C.BringToFront()
                b2D.BringToFront()
                tempCard = sender
            ElseIf sender.pile = "Defeated" Then
                b2R.Location = New Point(sender.left + 2, sender.bottom - b2R.Height - 2)
                b2R.Visible = True
                b2C.Location = New Point(b2R.Left, b2R.Top - b2C.Height - 2)
                b2C.Visible = True
                b2R.BringToFront()
                b2C.BringToFront()
                tempCard = sender
            End If

        ElseIf Phase.Text = "BATTLE" Then
            bPlusV.Visible = False
            bMinusV.Visible = False
            b2R.Visible = False
            If sender.pile = "Defeated" Or sender.pile = "Completed" Then
                b2R.Location = New Point(sender.left + 2, sender.bottom - b2R.Height - 2)
                b2R.Visible = True
                b2R.BringToFront()
                tempCard = sender
                If sender.pile = "Completed" Then
                    bPlusV.Location = New Point(b2R.Left, b2R.Top - bPlusV.Height - 2)
                    bPlusV.Visible = True
                    bPlusV.BringToFront()
                End If
            ElseIf sender.pile = "Reserve" Then
                bPlusV.Location = New Point(sender.left + 2, sender.bottom - bPlusV.Height - 2)
                bPlusV.Visible = True
                bPlusV.BringToFront()
                tempCard = sender
            ElseIf sender.pile = "VentureR" Or sender.pile = "VentureC" Then
                bMinusV.Location = New Point(sender.left + 2, sender.bottom - bMinusV.Height - 2)
                bMinusV.Visible = True
                bMinusV.BringToFront()
                tempCard = sender
            End If

        ElseIf PlaceTextBox.Visible = False And PlayTextBox.Visible = False Then
            TextBox1.Visible = False
            BigCardH.Visible = False
            BigCardV.Image = sender.image
            BigCardV.Visible = True
        End If
    End Sub
    '
    '
    'shows opponent's missions in big card places
    Private Sub OppMissions_Click(sender As Object, e As MouseEventArgs) Handles Mission8.MouseClick, Mission9.MouseClick, Mission10.MouseClick, Mission11.MouseClick, Mission12.MouseClick, Mission13.MouseClick, Mission14.MouseClick
        b2P.Visible = False
        bR.Visible = False
        bD.Visible = False
        bP.Visible = False

        If PlaceTextBox.Visible = False And PlayTextBox.Visible = False Then
            TextBox1.Visible = False
            BigCardH.Visible = False
            BigCardV.Image = sender.image
            BigCardV.Visible = True
        End If
    End Sub
    '
    '
    'shows card count in each missions pile
    Private Sub Missions_MouseEnter(sender As Object, e As EventArgs) Handles Mission7.MouseEnter, Mission6.MouseEnter, Mission5.MouseEnter, Mission4.MouseEnter, Mission3.MouseEnter, Mission2.MouseEnter, Mission1.MouseEnter
        Dim count As Integer = 0
        Dim p As String
        p = sender.pile

        For Each card In missionCards
            If card.pile = p Then
                count += 1
            End If
        Next

        Label1.Text = count.ToString
        Label1.Location = sender.Location
        Label1.Visible = True
        Label1.BringToFront()
    End Sub
    '
    '
    'shows card count in each opp missions pile
    Private Sub OppMissions_MouseEnter(sender As Object, e As EventArgs) Handles Mission8.MouseEnter, Mission9.MouseEnter, Mission10.MouseEnter, Mission11.MouseEnter, Mission12.MouseEnter, Mission13.MouseEnter, Mission14.MouseEnter
        Dim count As Integer = 0
        Dim p As String
        p = sender.pile

        For Each card In oppMissionCards
            If card.pile = p Then
                count += 1
            End If
        Next

        Label1.Text = count.ToString
        Label1.Location = New Point(sender.right - Label1.Width, sender.top)
        Label1.Visible = True
        Label1.BringToFront()
    End Sub
    '
    '
    'hides card count in each missions pile
    Private Sub Missions_MouseLeave(sender As Object, e As EventArgs) Handles Mission7.MouseLeave, Mission6.MouseLeave, Mission5.MouseLeave, Mission4.MouseLeave, Mission3.MouseLeave, Mission2.MouseLeave, Mission1.MouseLeave, Mission8.MouseLeave, Mission9.MouseLeave, Mission10.MouseLeave, Mission11.MouseLeave, Mission12.MouseLeave, Mission13.MouseLeave, Mission14.MouseLeave
        Label1.Visible = False
    End Sub
    '
    '
    'shows the cards in the pile double clicked
    Private Sub Piles_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles DrawPile.MouseDoubleClick, OppDrawPile.MouseDoubleClick, PowerPack.MouseDoubleClick, OppPowerPack.MouseDoubleClick, OppDefeatedChars.MouseDoubleClick, OppDeadPile.MouseDoubleClick, DefeatedChars.MouseDoubleClick, DeadPile.MouseDoubleClick
        If inGame = True Then
            BigCardH.Visible = False
            BigCardV.Visible = False
            TextBox1.Visible = False

            If sender Is DrawPile Then
                If myDeckCards.Count > 0 Then
                    frmShowDeck.bPP.Enabled = True
                    frmShowDeck.bDP.Enabled = True
                    frmShowDeck.bH.Enabled = True
                    frmShowDeck.bBoD.Enabled = False
                    frmShowDeck.bRiD.Enabled = False
                    frmShowDeck.bToD.Enabled = True
                    frmShowDeck.bPP.Font = New Font(frmShowDeck.bPP.Font, FontStyle.Bold)
                    frmShowDeck.bDP.Font = frmShowDeck.bPP.Font
                    frmShowDeck.bH.Font = frmShowDeck.bPP.Font
                    frmShowDeck.bBoD.Font = New Font(frmShowDeck.bPP.Font, FontStyle.Regular)
                    frmShowDeck.bRiD.Font = frmShowDeck.bBoD.Font
                    frmShowDeck.bToD.Font = frmShowDeck.bPP.Font
                    frmShowDeck.bPP.Visible = True
                    frmShowDeck.bDP.Visible = True
                    frmShowDeck.bH.Visible = True
                    frmShowDeck.bBoD.Visible = True
                    frmShowDeck.bRiD.Visible = True
                    frmShowDeck.bToD.Visible = True
                    For Each card In myDeckCards
                        frmShowDeck.cards.Add(card)
                    Next
                    frmShowDeck.Text = "Your Draw Pile"
                    frmShowDeck.deck = "MyDraw"
                    frmShowDeck.opp = False
                    If Host = True Then
                        hSendText(UID + " is viewing " + gender + " Draw Pile.")
                    Else
                        cSendText(UID + " is viewing " + gender + " Draw Pile.")
                    End If
                    frmShowDeck.ShowDialog()
                End If
            ElseIf sender Is OppDrawPile Then
                If oppDeckCards.Count > 0 Then
                    frmShowDeck.bPP.Enabled = True
                    frmShowDeck.bDP.Enabled = True
                    frmShowDeck.bH.Enabled = False
                    frmShowDeck.bBoD.Enabled = False
                    frmShowDeck.bRiD.Enabled = False
                    frmShowDeck.bToD.Enabled = False
                    frmShowDeck.bPP.Font = New Font(frmShowDeck.bPP.Font, FontStyle.Bold)
                    frmShowDeck.bDP.Font = frmShowDeck.bPP.Font
                    frmShowDeck.bH.Font = New Font(frmShowDeck.bPP.Font, FontStyle.Regular)
                    frmShowDeck.bBoD.Font = frmShowDeck.bH.Font
                    frmShowDeck.bRiD.Font = frmShowDeck.bH.Font
                    frmShowDeck.bToD.Font = frmShowDeck.bH.Font
                    frmShowDeck.bPP.Visible = True
                    frmShowDeck.bDP.Visible = True
                    frmShowDeck.bH.Visible = True
                    frmShowDeck.bBoD.Visible = True
                    frmShowDeck.bRiD.Visible = True
                    frmShowDeck.bToD.Visible = True
                    For Each card In oppDeckCards
                        frmShowDeck.cards.Add(card)
                    Next
                    frmShowDeck.Text = OUID + "'s Draw Pile"
                    frmShowDeck.deck = "OppDraw"
                    frmShowDeck.opp = True
                    If Host = True Then
                        hSendText(UID + " is viewing your Draw Pile.")
                    Else
                        cSendText(UID + " is viewing your Draw Pile.")
                    End If
                    frmShowDeck.ShowDialog()
                End If
            ElseIf sender Is PowerPack Then
                frmShowDeck.bPP.Enabled = False
                frmShowDeck.bDP.Enabled = True
                frmShowDeck.bH.Enabled = True
                frmShowDeck.bBoD.Enabled = True
                frmShowDeck.bRiD.Enabled = True
                frmShowDeck.bToD.Enabled = True
                frmShowDeck.bPP.Font = New Font(frmShowDeck.bPP.Font, FontStyle.Regular)
                frmShowDeck.bDP.Font = New Font(frmShowDeck.bPP.Font, FontStyle.Bold)
                frmShowDeck.bH.Font = frmShowDeck.bDP.Font
                frmShowDeck.bBoD.Font = frmShowDeck.bDP.Font
                frmShowDeck.bRiD.Font = frmShowDeck.bDP.Font
                frmShowDeck.bToD.Font = frmShowDeck.bDP.Font
                frmShowDeck.bPP.Visible = True
                frmShowDeck.bDP.Visible = True
                frmShowDeck.bH.Visible = True
                frmShowDeck.bBoD.Visible = True
                frmShowDeck.bRiD.Visible = True
                frmShowDeck.bToD.Visible = True
                For Each card In powerP
                    frmShowDeck.cards.Add(card)
                Next
                frmShowDeck.Text = "Your Power Pack"
                frmShowDeck.deck = "MyPP"
                frmShowDeck.opp = False
                If Host = True Then
                    hSendText(UID + " is viewing " + gender + " Power Pack.")
                Else
                    cSendText(UID + " is viewing " + gender + " Power Pack.")
                End If
                frmShowDeck.ShowDialog()
            ElseIf sender Is OppPowerPack Then
                frmShowDeck.bPP.Enabled = False
                frmShowDeck.bDP.Enabled = False
                frmShowDeck.bH.Enabled = False
                frmShowDeck.bBoD.Enabled = False
                frmShowDeck.bRiD.Enabled = False
                frmShowDeck.bToD.Enabled = False
                frmShowDeck.bPP.Font = New Font(frmShowDeck.bPP.Font, FontStyle.Regular)
                frmShowDeck.bDP.Font = frmShowDeck.bPP.Font
                frmShowDeck.bH.Font = frmShowDeck.bPP.Font
                frmShowDeck.bBoD.Font = frmShowDeck.bPP.Font
                frmShowDeck.bRiD.Font = frmShowDeck.bPP.Font
                frmShowDeck.bToD.Font = frmShowDeck.bPP.Font
                frmShowDeck.bPP.Visible = False
                frmShowDeck.bDP.Visible = False
                frmShowDeck.bH.Visible = False
                frmShowDeck.bBoD.Visible = False
                frmShowDeck.bRiD.Visible = False
                frmShowDeck.bToD.Visible = False
                For Each card In oppPowerP
                    frmShowDeck.cards.Add(card)
                Next
                frmShowDeck.Text = OUID + "'s Power Pack"
                frmShowDeck.deck = "OppPP"
                frmShowDeck.opp = True
                If Host = True Then
                    hSendText(UID + " is viewing your Power Pack.")
                Else
                    cSendText(UID + " is viewing your Power Pack.")
                End If
                frmShowDeck.ShowDialog()
            ElseIf sender Is DefeatedChars Then
                frmShowDeck.bPP.Enabled = False
                frmShowDeck.bDP.Enabled = False
                frmShowDeck.bH.Enabled = False
                frmShowDeck.bBoD.Enabled = False
                frmShowDeck.bRiD.Enabled = False
                frmShowDeck.bToD.Enabled = False
                frmShowDeck.bPP.Font = New Font(frmShowDeck.bPP.Font, FontStyle.Regular)
                frmShowDeck.bDP.Font = frmShowDeck.bPP.Font
                frmShowDeck.bH.Font = frmShowDeck.bPP.Font
                frmShowDeck.bBoD.Font = frmShowDeck.bPP.Font
                frmShowDeck.bRiD.Font = frmShowDeck.bPP.Font
                frmShowDeck.bToD.Font = frmShowDeck.bPP.Font
                frmShowDeck.bPP.Visible = False
                frmShowDeck.bDP.Visible = False
                frmShowDeck.bH.Visible = False
                frmShowDeck.bBoD.Visible = False
                frmShowDeck.bRiD.Visible = False
                frmShowDeck.bToD.Visible = False
                For Each card In dChars
                    frmShowDeck.cards.Add(card)
                Next
                frmShowDeck.Text = "Your Defeated Characters Pile"
                frmShowDeck.deck = "MyDChars"
                frmShowDeck.opp = False
                If Host = True Then
                    hSendText(UID + " is viewing " + gender + " Defeated Characters Pile.")
                Else
                    cSendText(UID + " is viewing " + gender + " Defeated Characters Pile.")
                End If
                frmShowDeck.ShowDialog()
            ElseIf sender Is OppDefeatedChars Then
                frmShowDeck.bPP.Enabled = False
                frmShowDeck.bDP.Enabled = False
                frmShowDeck.bH.Enabled = False
                frmShowDeck.bBoD.Enabled = False
                frmShowDeck.bRiD.Enabled = False
                frmShowDeck.bToD.Enabled = False
                frmShowDeck.bPP.Font = New Font(frmShowDeck.bPP.Font, FontStyle.Regular)
                frmShowDeck.bDP.Font = frmShowDeck.bPP.Font
                frmShowDeck.bH.Font = frmShowDeck.bPP.Font
                frmShowDeck.bBoD.Font = frmShowDeck.bPP.Font
                frmShowDeck.bRiD.Font = frmShowDeck.bPP.Font
                frmShowDeck.bToD.Font = frmShowDeck.bPP.Font
                frmShowDeck.bPP.Visible = False
                frmShowDeck.bDP.Visible = False
                frmShowDeck.bH.Visible = False
                frmShowDeck.bBoD.Visible = False
                frmShowDeck.bRiD.Visible = False
                frmShowDeck.bToD.Visible = False
                For Each card In oppDChars
                    frmShowDeck.cards.Add(card)
                Next
                frmShowDeck.Text = OUID + "'s Defeated Characters Pile"
                frmShowDeck.deck = "OppDChars"
                frmShowDeck.opp = True
                If Host = True Then
                    hSendText(UID + " is viewing your Defeated Characters Pile.")
                Else
                    cSendText(UID + " is viewing your Defeated Characters Pile.")
                End If
                frmShowDeck.ShowDialog()
            ElseIf sender Is DeadPile Then
                frmShowDeck.bPP.Enabled = True
                frmShowDeck.bDP.Enabled = False
                frmShowDeck.bH.Enabled = True
                frmShowDeck.bBoD.Enabled = True
                frmShowDeck.bRiD.Enabled = True
                frmShowDeck.bToD.Enabled = True
                frmShowDeck.bPP.Font = New Font(frmShowDeck.bPP.Font, FontStyle.Bold)
                frmShowDeck.bDP.Font = New Font(frmShowDeck.bPP.Font, FontStyle.Regular)
                frmShowDeck.bH.Font = frmShowDeck.bPP.Font
                frmShowDeck.bBoD.Font = frmShowDeck.bPP.Font
                frmShowDeck.bRiD.Font = frmShowDeck.bPP.Font
                frmShowDeck.bToD.Font = frmShowDeck.bPP.Font
                frmShowDeck.bPP.Visible = True
                frmShowDeck.bDP.Visible = True
                frmShowDeck.bH.Visible = True
                frmShowDeck.bBoD.Visible = True
                frmShowDeck.bRiD.Visible = True
                frmShowDeck.bToD.Visible = True
                For Each card In deadP
                    frmShowDeck.cards.Add(card)
                Next
                frmShowDeck.Text = "Your Dead Pile"
                frmShowDeck.deck = "MyDP"
                frmShowDeck.opp = False
                If Host = True Then
                    hSendText(UID + " is viewing " + gender + " Dead Pile.")
                Else
                    cSendText(UID + " is viewing " + gender + " Dead Pile.")
                End If
                frmShowDeck.ShowDialog()
            ElseIf sender Is OppDeadPile Then
                frmShowDeck.bPP.Enabled = False
                frmShowDeck.bDP.Enabled = False
                frmShowDeck.bH.Enabled = False
                frmShowDeck.bBoD.Enabled = False
                frmShowDeck.bRiD.Enabled = False
                frmShowDeck.bToD.Enabled = False
                frmShowDeck.bPP.Font = New Font(frmShowDeck.bPP.Font, FontStyle.Regular)
                frmShowDeck.bDP.Font = frmShowDeck.bPP.Font
                frmShowDeck.bH.Font = frmShowDeck.bPP.Font
                frmShowDeck.bBoD.Font = frmShowDeck.bPP.Font
                frmShowDeck.bRiD.Font = frmShowDeck.bPP.Font
                frmShowDeck.bToD.Font = frmShowDeck.bPP.Font
                frmShowDeck.bPP.Visible = False
                frmShowDeck.bDP.Visible = False
                frmShowDeck.bH.Visible = False
                frmShowDeck.bBoD.Visible = False
                frmShowDeck.bRiD.Visible = False
                frmShowDeck.bToD.Visible = False
                For Each card In oppDeadP
                    frmShowDeck.cards.Add(card)
                Next
                frmShowDeck.Text = OUID + "'s Dead Pile"
                frmShowDeck.deck = "OppDP"
                frmShowDeck.opp = True
                If Host = True Then
                    hSendText(UID + " is viewing your Dead Pile.")
                Else
                    cSendText(UID + " is viewing your Dead Pile.")
                End If
                frmShowDeck.ShowDialog()
            End If
        End If
    End Sub
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    'plays cards or sets up the playing of cards
    Private Sub bPlay_Click(sender As Object, e As EventArgs) Handles bPlay.MouseClick
        bPlay.Visible = False
        bDiscard.Visible = False
        bPlace.Visible = False

        'if it was a event played
        If Phase.Text = "DISCARD" And TypeOf tempCard Is MissionEvent Then
            If Event1.Image Is Nothing Then
                Dim i As Integer = 1
                While tempCard IsNot handCards(i) And i <= handCards.Count
                    i += 1
                End While
                Event1.Parse(handCards(i))
                Event1.Visible = True
                Me.Controls.Remove(handCards(i))
                handCards.Remove(i)
                ResizeHand()

                Dim c As New Cereal
                c.id = tempCard.id
                c.cardType = tempCard.GetType.ToString

                If Host = True Then
                    hSendCard(c)
                Else
                    cSendCard(c)
                End If

                tempCard = vbNull
                StifleDraw = True
                DrawCard()
                StifleDraw = False
                BG_Click(sender, e)
            Else
                tempCard.left = HandCardLeft
                MsgBox("You cannot play more than one Event per Battle!", MsgBoxStyle.Exclamation, "Event already played!")
            End If

            'if it was any other card played
        ElseIf Phase.Text = "BATTLE" Then
            If TypeOf tempCard Is Character Or TypeOf tempCard Is MissionEvent Then
                'for now dont do anything with char and event cards when played during battle phase
                tempCard.left = HandCardLeft
                tempCard = vbNull
            ElseIf AttackBox.Visible = True And bCancel.Enabled = True Then
                'find card in hand
                Dim i As Integer = 1
                While tempCard IsNot handCards(i) And i <= handCards.Count
                    i += 1
                End While

                handCards(i).size = DrawPile.Size

                'add to attack box as attack
                AttackPanel.Left = AttackPanel.Right - ((AttackCards.Count + 1) * (DrawPile.Width + (DrawPile.Width / 10))) - (DrawPile.Width / 10)
                AttackPanel.Width = (AttackCards.Count + 1) * (DrawPile.Width + (DrawPile.Width / 10)) + (DrawPile.Width / 10)
                handCards(i).Location = New Point(AttackPanel.Left + (DrawPile.Width / 10), AttackBox.Bottom - handCards(i).Height - 5)
                handCards(i).attack = True
                handCards(i).bringtofront()
                AttackCards.Add(handCards(i))

                Dim c As New Cereal
                c.id = tempCard.id
                c.cardType = tempCard.GetType.ToString
                c.remove = True
                c.fromHand = True

                If Host = True Then
                    hSendCard(c)
                Else
                    cSendCard(c)
                End If


                'remove from hand and resize
                handCards.Remove(i)
                ResizeHand()
                tempCard = vbNull
            Else
                If DefendBox.Visible = False And bPhase.Enabled = True Then
                    bCancel.Location = New Point(PlayTextBox.Right - bCancel.Width - 3, PlayTextBox.Top + 3)
                    PlayTextBox.Visible = True
                    PlayTextBox.BringToFront()
                    bCancel.Font = New Font(bCancel.Font, FontStyle.Bold)
                    bCancel.Visible = True
                    bCancel.BringToFront()
                ElseIf DefendBox.Visible = True Then
                    Dim i As Integer = 1
                    While tempCard IsNot handCards(i) And i <= handCards.Count
                        i += 1
                    End While

                    handCards(i).size = DrawPile.Size

                    'add to defend box as defense
                    AttackPanel.Width = (AttackCards.Count * (DrawPile.Width + (DrawPile.Width / 10))) + (DrawPile.Width / 10) + AttackPanel.SplitterWidth + ((DefendCards.Count + 1) * (DrawPile.Width + (DrawPile.Width / 10)) + (DrawPile.Width / 10))
                    AttackPanel.SplitterDistance = AttackCards.Count * (DrawPile.Width + (DrawPile.Width / 10)) + (DrawPile.Width / 10)

                    handCards(i).Location = New Point(AttackPanel.Right - DrawPile.Width - (DrawPile.Width / 10), AttackBox.Bottom - handCards(i).Height - 5)
                    handCards(i).defend = True
                    handCards(i).bringtofront()
                    DefendCards.Add(handCards(i))

                    Dim c As New Cereal
                    c.id = tempCard.id
                    c.cardType = tempCard.GetType.ToString
                    c.remove = True
                    c.fromHand = True

                    If Host = True Then
                        hSendCard(c)
                    Else
                        cSendCard(c)
                    End If

                    'remove from hand and resize
                    handCards.Remove(i)
                    ResizeHand()
                    tempCard = vbNull
                Else
                    BG_Click(sender, e)
                    MsgBox("It is not your turn!", MsgBoxStyle.Exclamation)
                End If
            End If
        End If
    End Sub
    '
    '
    'discards the card
    Private Sub bDiscard_Click(sender As Object, e As MouseEventArgs) Handles bDiscard.MouseClick, bD.MouseClick
        bPlay.Visible = False
        bDiscard.Visible = False
        bPlace.Visible = False
        If Phase.Text = "DISCARD" Or tempCard.played = True Or tempCard.placed = True Then
            Discard()
            BG_Click(sender, e)
        Else
            If MsgBox("Are you sure you want to discard this card?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Discard?") = DialogResult.Yes Then
                Discard()
                BG_Click(sender, e)
            End If
        End If
    End Sub
    '
    '
    'displays place instructions and waits for user click
    Private Sub bPlace_Click(sender As Object, e As EventArgs) Handles bPlace.MouseClick
        bPlay.Visible = False
        bDiscard.Visible = False
        bPlace.Visible = False
        bCancel.Location = New Point(PlaceTextBox.Right - bCancel.Width - 3, PlaceTextBox.Top + 3)
        bCancel.Font = New Font(bCancel.Font, FontStyle.Bold)
        PlaceTextBox.Visible = True
        PlaceTextBox.BringToFront()
        bCancel.Visible = True
        bCancel.BringToFront()
    End Sub
    '
    '
    '
    '
    '
    '
    'cancel button actions when clicked
    Private Sub bCancel_Click(sender As Object, e As EventArgs) Handles bCancel.MouseClick
        PlaceTextBox.Visible = False
        PlayTextBox.Visible = False
        'hide attackbox and put cards back into hand
        If AttackBox.Visible = True Then
            attackFrom = vbNull
            For Each card In AttackCards
                If card.placedOn IsNot Nothing Then
                    If card.placedOn = "Character1" Then
                        PlaceCard("Character1", card)
                    ElseIf card.placedOn = "Character2" Then
                        PlaceCard("Character2", card)
                    ElseIf card.placedOn = "Character3" Then
                        PlaceCard("Character3", card)
                    ElseIf card.placedOn = "Character4" Then
                        PlaceCard("Character4", card)
                    ElseIf card.placedOn = "Homebase" Then
                        PlaceCard("Homebase", card)
                    End If
                Else
                    handCards.Add(card)
                    card.size = HandCardSize
                    card.attack = False

                    Dim c As New Cereal
                    c.id = handCards(handCards.Count).id
                    c.cardType = handCards(handCards.Count).GetType.ToString
                    c.backToHand = True

                    Thread.Sleep(300)
                    If Host = True Then
                        hSendCard(c)
                    Else
                        cSendCard(c)
                    End If
                End If
            Next
            ResizeHand()
            AttackBox.Visible = False
            AttackPanel.Visible = False
            AttackCards.Clear()
            AttackFromLine.Visible = False
            AttackToLine.Visible = False
            bAttack.Visible = False
            cbFacedown.Visible = False
        End If
        bCancel.Visible = False
        bAttack.Visible = False
        bAttack.Enabled = False
        bMin.Visible = False
        bAttack.Font = New Font(bAttack.Font, FontStyle.Regular)
        BG_Click(sender, e)
    End Sub
    '
    '
    'attack button actions
    Private Sub bAttack_Click(sender As Object, e As EventArgs) Handles bAttack.MouseClick
        Dim a As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
        Dim s As System.IO.Stream = a.GetManifestResourceStream("OverPower.Attack.wav")
        Dim player As SoundPlayer = New SoundPlayer(s)
        player.Play()

        bAttack.Enabled = False
        bAttack.Font = New Font(bAttack.Font, FontStyle.Regular)
        bCancel.Enabled = False
        bCancel.Font = New Font(bCancel.Font, FontStyle.Regular)
        cbFacedown.Enabled = False
        TextInput.Focus()

        For Each card In AttackCards
            Dim c As New Cereal
            c.attack = True
            c.id = card.id
            c.cardType = card.GetType.ToString
            c.attacker = attackFrom
            c.defender = attackTo
            If cbFacedown.Checked = True Then
                c.faceDown = True
            End If

            Thread.Sleep(200)

            If Host = True Then
                hSendCard(c)
            Else
                cSendCard(c)
            End If
        Next

        Thread.Sleep(250)
        If Host = True Then
            hSendCommand("attack")
        Else
            cSendCommand("attack")
        End If
    End Sub
    '
    '
    'defends the attack
    Private Sub bDefend_Click(sender As Object, e As MouseEventArgs) Handles bDefend.MouseClick
        UpdateStatus("Waiting for opponent to accept defense...")
        bHits.Enabled = False
        bHits.Font = New Font(bHits.Font, FontStyle.Regular)
        bDefend.Enabled = False
        bDefend.Font = bHits.Font
        bShift.Font = bHits.Font
        bShift.Enabled = False
        'send defense
        For Each card In DefendCards
            Dim c As New Cereal
            c.defend = True
            c.id = card.id
            c.cardType = card.GetType.ToString

            Thread.Sleep(200)

            If Host = True Then
                hSendCard(c)
            Else
                cSendCard(c)
            End If
        Next

        Thread.Sleep(250)
        If Host = True Then
            hSendCommand("defend")
        Else
            cSendCommand("defend")
        End If
    End Sub
    '
    '
    'adds hits to current record
    Private Sub bHits_Click(sender As Object, e As EventArgs) Handles bHits.MouseClick
        Dim a As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
        Dim s As System.IO.Stream = a.GetManifestResourceStream("OverPower.HitMe.wav")
        Dim player As SoundPlayer = New SoundPlayer(s)
        player.Play()

        For Each card In AttackCards
            card.attack = False
            If faceDown = True Then
                card.image = card.ImageFront
            End If
            If TypeOf card Is BasicUniverse Or TypeOf card Is Training Then
                Me.Controls.Remove(card)
                If OppDeadPile.Visible = False Then
                    OppDeadPile.Visible = True
                End If
                oppDeadP.Add(card)
                OppDeadPile.Image = card.Image
            Else
                card.size = SmallCardSize
                card.hit = True
                If attackTo = "OppCharacter1" Then
                    card.location = New Point(Character1.Left + (card.width / 10) + (hitCards1.Count * (card.width / 3)), Character1.Top - (card.height * 1.3))
                    hitCards1.Add(card)
                    HitCardsTop = card.top
                    card.hitOn = "Character1"
                ElseIf attackTo = "OppCharacter2" Then
                    card.location = New Point(Character2.Left + (card.width / 10) + (hitCards2.Count * (card.width / 3)), Character2.Top - (card.height * 1.3))
                    hitCards2.Add(card)
                    HitCardsTop = card.top
                    card.hitOn = "Character2"
                ElseIf attackTo = "OppCharacter3" Then
                    card.location = New Point(Character3.Left + (card.width / 10) + (hitCards3.Count * (card.width / 3)), Character3.Top - (card.height * 1.3))
                    hitCards3.Add(card)
                    HitCardsTop = card.top
                    card.hitOn = "Character3"
                ElseIf attackTo = "OppCharacter4" Then
                    card.location = New Point(Character4.Left - (card.width * 1.5) - (hitCards4.Count * (card.width / 3)), Character4.Top + (Character4.Height / 2) - (card.height / 2))
                    hitCards4.Add(card)
                    HitCardsBackTop = card.top
                    card.hitOn = "Character4"
                ElseIf attackTo = "OppBattlesite" Then
                    card.location = New Point(Battlesite.Left + (card.width / 10) + (hitCardsB.Count * (card.width / 3)), Battlesite.Top - (card.height * 1.3))
                    hitCardsB.Add(card)
                    HitCardsTop = card.top
                    card.hitOn = "Battlesite"
                End If
                card.bringtofront()
            End If
        Next

        For Each card In DefendCards
            card.defend = False
            If card.placedOn IsNot Nothing Then
                If tempCard.placedOn = "Character1" Then
                    PlaceCard("Character1", tempCard)
                ElseIf tempCard.placedOn = "Character2" Then
                    PlaceCard("Character2", tempCard)
                ElseIf tempCard.placedOn = "Character3" Then
                    PlaceCard("Character3", tempCard)
                ElseIf tempCard.placedOn = "Character4" Then
                    PlaceCard("Character4", tempCard)
                ElseIf tempCard.placedOn = "Homebase" Then
                    PlaceCard("Homebase", tempCard)
                End If
            Else
                card.size = HandCardSize
                card.left = HandCardLeft
                handCards.Add(card)
            End If
        Next

        For Each hit In hitCards4
            hit.sendtoback()
        Next

        ResizeHand()
        AttackCards.Clear()
        DefendCards.Clear()
        DefendBox.Visible = False
        AttackPanel.Visible = False
        bHits.Visible = False
        bDefend.Visible = False
        bShift.Visible = False
        AttackFromLine.Visible = False
        AttackToLine.Visible = False
        attackTo = Nothing
        attackFrom = Nothing
        bMin.Visible = False
        AttackPanel.Panel2Collapsed = True
        faceDown = False

        Thread.Sleep(250)
        If Host = True Then
            hSendCommand("hits")
        Else
            cSendCommand("hits")
        End If

        BGclick()
    End Sub
    '
    '
    'shifts the attack
    Private Sub bShift_Click(sender As Object, e As EventArgs) Handles bShift.MouseClick
        DefendBox.Text = "Click the character you want to shift to"
        bShift.Font = New Font(bShift.Font, FontStyle.Regular)
        bHits.Font = bShift.Font
        bDefend.Font = bHits.Font
        bShift.Enabled = False
        bHits.Enabled = False
        bDefend.Enabled = False
    End Sub
    '
    '
    'accepts the defense
    Private Sub bAccept_Click(sender As Object, e As EventArgs) Handles bAccept.MouseClick
        For Each card In AttackCards
            card.attack = False
            Me.Controls.Remove(card)
            If TypeOf card Is PowerCard Then
                If PowerPack.Visible = False Then
                    PowerPack.Visible = True
                End If
                powerP.Add(card)
                PowerPack.Image = card.image
            Else
                If DeadPile.Visible = False Then
                    DeadPile.Visible = True
                End If
                deadP.Add(card)
                DeadPile.Image = card.Image
            End If
        Next

        For Each card In DefendCards
            card.defend = False
            Me.Controls.Remove(card)
            If TypeOf card Is PowerCard Then
                If OppPowerPack.Visible = False Then
                    OppPowerPack.Visible = True
                End If
                oppPowerP.Add(card)
                OppPowerPack.Image = card.image
            Else
                If OppDeadPile.Visible = False Then
                    OppDeadPile.Visible = True
                End If
                oppDeadP.Add(card)
                OppDeadPile.Image = card.Image
            End If
        Next

        AttackCards.Clear()
        DefendCards.Clear()
        AcceptBox.Visible = False
        AttackPanel.Visible = False
        bChallenge.Visible = False
        bAccept.Visible = False
        AttackFromLine.Visible = False
        AttackToLine.Visible = False
        attackTo = Nothing
        attackFrom = Nothing
        bMin.Visible = False
        AttackPanel.Panel2Collapsed = True
        bCancel.Enabled = True

        Thread.Sleep(250)
        If Host = True Then
            hSendCommand("accept")
        Else
            cSendCommand("accept")
        End If

        If FollowUp = False Then
            frmEndTurn.ShowDialog()
        End If
    End Sub
    '
    '
    'challenges the defense
    Private Sub bChallenge_Click(sender As Object, e As EventArgs) Handles bChallenge.MouseClick
        For Each card In DefendCards
            Me.Controls.Remove(card)
        Next

        DefendCards.Clear()
        AttackPanel.Width = ((AttackCards.Count + 1) * (DrawPile.Width + (DrawPile.Width / 10))) + AttackPanel.SplitterWidth + (2 * DrawPile.Width / 10)
        AttackPanel.SplitterDistance = (AttackCards.Count * (DrawPile.Width + (DrawPile.Width / 10))) + (DrawPile.Width / 10)

        AcceptBox.Visible = False
        bAccept.Visible = False
        bChallenge.Visible = False
        AttackBox.Visible = True
        bAttack.Visible = True
        bCancel.Visible = True
        bMin.BringToFront()
        bCancel.BringToFront()
        bAttack.BringToFront()
        AttackPanel.Visible = True
        AttackPanel.BringToFront()

        For Each card In AttackCards
            card.bringtofront()
        Next

        Thread.Sleep(250)
        If Host = True Then
            hSendCommand("challenge")
        Else
            cSendCommand("challenge")
        End If
    End Sub
    '
    '
    'minimizes attack box
    Private Sub bMin_Click(sender As Object, e As MouseEventArgs) Handles bMin.MouseClick
        If AttackBox.Visible = True Then
            If AttackBox.Height = DrawPile.Height + 35 Then
                AttackBox.Height = 26
                For Each card In AttackCards
                    card.visible = False
                Next
                setAttackButtonsVis(False)
                AttackPanel.Visible = False
            Else
                AttackBox.Height = DrawPile.Height + 35
                For Each card In AttackCards
                    card.visible = True
                Next
                setAttackButtonsVis(True)
                AttackPanel.Visible = True
            End If
        ElseIf DefendBox.Visible = True Then
            If DefendBox.Height = DrawPile.Height + 35 Then
                DefendBox.Height = 26
                For Each card In AttackCards
                    card.visible = False
                Next
                For Each card In DefendCards
                    card.visible = False
                Next
                setDefendButtonsVis(False)
                AttackPanel.Visible = False
            Else
                DefendBox.Height = DrawPile.Height + 35
                For Each card In AttackCards
                    card.visible = True
                Next
                For Each card In DefendCards
                    card.visible = True
                Next
                setDefendButtonsVis(True)
                AttackPanel.Visible = True
            End If
        ElseIf AcceptBox.Visible = True Then
            If AcceptBox.Height = DrawPile.Height + 35 Then
                AcceptBox.Height = 26
                For Each card In AttackCards
                    card.visible = False
                Next
                For Each card In DefendCards
                    card.visible = False
                Next
                setAcceptButtonsVis(False)
                AttackPanel.Visible = False
            Else
                AcceptBox.Height = DrawPile.Height + 35
                For Each card In AttackCards
                    card.visible = True
                Next
                For Each card In DefendCards
                    card.visible = True
                Next
                setAcceptButtonsVis(True)
                AttackPanel.Visible = True
            End If
        End If
        TextInput.Focus()
    End Sub
    '
    '
    '
    '
    '
    '
    '
    '
    'removes a hit or card in attack/defend box
    Private Sub bR_Click(sender As Object, e As MouseEventArgs) Handles bR.MouseClick
        If tempCard.attack = True Then
            Dim i As Integer = 1
            While i <= AttackCards.Count
                If tempCard IsNot AttackCards(i) Then
                    i += 1
                Else
                    AttackCards.Remove(i)
                    Exit While
                End If
            End While

            If AttackCards.Count = 0 Then
                AttackPanel.Location = New Point((AttackBox.Left + (AttackBox.Width / 2)) - ((1 * (DrawPile.Width + (DrawPile.Width / 10))) + (DrawPile.Width / 10)), AttackBox.Top + 25)
                AttackPanel.Size = New Size((1 * (DrawPile.Width + (DrawPile.Width / 10))) + (DrawPile.Width / 10), AttackBox.Height - 26)
            Else
                AttackPanel.Location = New Point((AttackBox.Left + (AttackBox.Width / 2)) - ((AttackCards.Count * (DrawPile.Width + (DrawPile.Width / 10))) + (DrawPile.Width / 10)), AttackBox.Top + 25)
                AttackPanel.Size = New Size((AttackCards.Count * (DrawPile.Width + (DrawPile.Width / 10))) + (DrawPile.Width / 10), AttackBox.Height - 26)
            End If

            i = 0
            For Each card In AttackCards
                card.Location = New Point(AttackPanel.Left + (DrawPile.Width / 10) + (i * (card.width)) + (i * (DrawPile.Width / 10)), AttackBox.Bottom - card.Height - 5)
                i += 1
            Next

            If tempCard.placedOn IsNot Nothing Then
                If tempCard.placedOn = "Character1" Then
                    PlaceCard("Character1", tempCard)
                ElseIf tempCard.placedOn = "Character2" Then
                    PlaceCard("Character2", tempCard)
                ElseIf tempCard.placedOn = "Character3" Then
                    PlaceCard("Character3", tempCard)
                ElseIf tempCard.placedOn = "Character4" Then
                    PlaceCard("Character4", tempCard)
                ElseIf tempCard.placedOn = "Homebase" Then
                    PlaceCard("Homebase", tempCard)
                End If
            Else
                tempCard.left = HandCardLeft
                tempCard.size = HandCardSize
                handCards.Add(tempCard)
                ResizeHand()
            End If

            tempCard.attack = False

        ElseIf tempCard.defend = True Then
            Dim i As Integer = 1
            While i <= DefendCards.Count
                If tempCard IsNot DefendCards(i) Then
                    i += 1
                Else
                    DefendCards.Remove(i)
                    Exit While
                End If
            End While

            If DefendCards.Count > 0 Then
                AttackPanel.Location = New Point((AttackBox.Left + (AttackBox.Width / 2)) - ((AttackCards.Count * (DrawPile.Width + (DrawPile.Width / 10))) + (DrawPile.Width / 10)), AttackBox.Top + 25)
                AttackPanel.Size = New Size(((AttackCards.Count + DefendCards.Count) * (DrawPile.Width + (DrawPile.Width / 10))) + (2 * DrawPile.Width / 10) + AttackPanel.SplitterWidth, AttackBox.Height - 26)
                AttackPanel.SplitterDistance = (AttackCards.Count * (DrawPile.Width + (DrawPile.Width / 10))) + (DrawPile.Width / 10)
            End If

            i = 0
            For Each card In DefendCards
                card.Location = New Point(AttackPanel.Left + AttackPanel.SplitterDistance + AttackPanel.SplitterWidth + (DrawPile.Width / 10) + (i * (card.width)) + (i * (DrawPile.Width / 10)), AttackBox.Bottom - card.Height - 5)
                i += 1
            Next

            i = 0
            For Each card In AttackCards
                card.Location = New Point(AttackPanel.Left + (DrawPile.Width / 10) + (i * (card.width)) + (i * (DrawPile.Width / 10)), AttackBox.Bottom - card.Height - 5)
                i += 1
            Next

            If tempCard.placedOn IsNot Nothing Then
                If tempCard.placedOn = "Character1" Then
                    PlaceCard("Character1", tempCard)
                ElseIf tempCard.placedOn = "Character2" Then
                    PlaceCard("Character2", tempCard)
                ElseIf tempCard.placedOn = "Character3" Then
                    PlaceCard("Character3", tempCard)
                ElseIf tempCard.placedOn = "Character4" Then
                    PlaceCard("Character4", tempCard)
                ElseIf tempCard.placedOn = "Homebase" Then
                    PlaceCard("Homebase", tempCard)
                End If
            Else
                tempCard.left = HandCardLeft
                tempCard.size = HandCardSize
                handCards.Add(tempCard)
                ResizeHand()
            End If

            tempCard.defend = False

        ElseIf tempCard.hit = True Or tempCard.perm = True Then
            Discard()
        End If

        BG_Click(sender, e)
    End Sub
    '
    '
    'attack with placed card
    Private Sub bP_Click(sender As Object, e As EventArgs) Handles bP.MouseClick
        If AttackBox.Visible = True Then
            tempCard.size = DrawPile.Size
            AttackPanel.Left = AttackPanel.Right - ((AttackCards.Count + 1) * (DrawPile.Width + (DrawPile.Width / 10))) - (DrawPile.Width / 10)
            AttackPanel.Width = (AttackCards.Count + 1) * (DrawPile.Width + (DrawPile.Width / 10)) + (DrawPile.Width / 10)
            AttackPanel.Visible = True
            tempCard.Location = New Point(AttackPanel.Left + (DrawPile.Width / 10), AttackBox.Bottom - tempCard.Height - 5)
            tempCard.attack = True
            AttackCards.Add(tempCard)
            tempCard.bringtofront()

            tempCard.placed = False
            ReorganizePlaced()

            Dim c As New Cereal
            c.id = tempCard.id
            c.cardType = tempCard.GetType.ToString
            c.remove = True
            c.fromPlaced = True
            c.placedOn = tempCard.placedOn

            If Host = True Then
                hSendCard(c)
            Else
                cSendCard(c)
            End If

            BG_Click(sender, e)

        ElseIf Phase.Text = "BATTLE" Then
            'show the playtextbox
            If DefendBox.Visible = False And bPhase.Enabled = True Then
                bD.Visible = False
                bP.Visible = False
                PlayTextBox.Visible = True
                PlayTextBox.BringToFront()
                bCancel.Location = New Point(PlayTextBox.Right - bCancel.Width - 3, PlayTextBox.Top + 3)
                bCancel.Visible = True
                bCancel.BringToFront()
            ElseIf DefendBox.Visible = True Then
                'add to defend box as defense
                If AttackPanel.Panel2Collapsed = True Then
                    AttackPanel.Panel2Collapsed = False
                End If

                AttackPanel.Width = (AttackCards.Count * (DrawPile.Width + (DrawPile.Width / 10))) + (DrawPile.Width / 10) + AttackPanel.SplitterWidth + ((DefendCards.Count + 1) * (DrawPile.Width + (DrawPile.Width / 10)) + (DrawPile.Width / 10))
                AttackPanel.SplitterDistance = AttackCards.Count * (DrawPile.Width + (DrawPile.Width / 10)) + (DrawPile.Width / 10)
                tempCard.size = DrawPile.Size
                tempCard.Location = New Point(AttackPanel.Right - DrawPile.Width - (DrawPile.Width / 10), AttackBox.Bottom - tempCard.Height - 5)
                tempCard.defend = True
                tempCard.bringtofront()
                DefendCards.Add(tempCard)

                tempCard.placed = False
                ReorganizePlaced()

                Dim c As New Cereal
                c.id = tempCard.id
                c.cardType = tempCard.GetType.ToString
                c.remove = True
                c.fromPlaced = True
                c.placedOn = tempCard.placedOn

                If Host = True Then
                    hSendCard(c)
                Else
                    cSendCard(c)
                End If

                BG_Click(sender, e)
            End If
        Else
            BG_Click(sender, e)
        End If
    End Sub
    '
    '
    'move hit to permanent record
    Private Sub b2P_Click(sender As Object, e As EventArgs) Handles b2P.Click
        b2P.Visible = False
        bR.Visible = False
        bM.Visible = False

        Dim c As New Cereal
        c.toPerm = True
        c.hitOn = tempCard.hitOn
        c.cardType = tempCard.GetType.ToString
        c.id = tempCard.id

        If Host = True Then
            hSendCard(c)
        Else
            cSendCard(c)
        End If

        If tempCard.hitOn = "Character1" Then
            Dim i = 1
            For Each card In hitCards1
                If tempCard IsNot card Then
                    i += 1
                Else
                    Exit For
                End If
            Next

            If hitCards1.Count > 1 And i <> hitCards1.Count Then
                For k = i + 1 To hitCards1.Count
                    hitCards1(k).left = hitCards1(k - 1).left
                Next
            End If

            tempCard.location = New Point(Character1.Left + (tempCard.width / 10) + (permCards1.Count * (tempCard.width / 3)), Character1.Top - (tempCard.height / 5))
            tempCard.hit = False
            tempCard.hitOn = Nothing
            tempCard.perm = True
            permCards1.Add(tempCard)
            PermCardsTop = tempCard.top
            hitCards1.Remove(i)

            Dim j = permCards1.Count
            While j >= 1
                permCards1(j).sendtoback()
                j -= 1
            End While
        ElseIf tempCard.hitOn = "Character2" Then
            Dim i = 1
            For Each card In hitCards2
                If tempCard IsNot card Then
                    i += 1
                Else
                    Exit For
                End If
            Next

            If hitCards2.Count > 1 And i <> hitCards2.Count Then
                For k = i + 1 To hitCards2.Count
                    hitCards2(k).left = hitCards2(k - 1).left
                Next
            End If

            tempCard.location = New Point(Character2.Left + (tempCard.width / 10) + (permCards2.Count * (tempCard.width / 3)), Character2.Top - (tempCard.height / 5))
            tempCard.hit = False
            tempCard.hitOn = Nothing
            tempCard.perm = True
            permCards2.Add(tempCard)
            PermCardsTop = tempCard.top
            hitCards2.Remove(i)

            Dim j = permCards2.Count
            While j >= 1
                permCards2(j).sendtoback()
                j -= 1
            End While
        ElseIf tempCard.hitOn = "Character3" Then
            Dim i = 1
            For Each card In hitCards3
                If tempCard IsNot card Then
                    i += 1
                Else
                    Exit For
                End If
            Next

            If hitCards3.Count > 1 And i <> hitCards3.Count Then
                For k = i + 1 To hitCards3.Count
                    hitCards3(k).left = hitCards3(k - 1).left
                Next
            End If

            tempCard.location = New Point(Character3.Left + (tempCard.width / 10) + (permCards3.Count * (tempCard.width / 3)), Character3.Top - (tempCard.height / 5))
            tempCard.hit = False
            tempCard.hitOn = Nothing
            tempCard.perm = True
            permCards3.Add(tempCard)
            PermCardsTop = tempCard.top
            hitCards3.Remove(i)

            Dim j = permCards3.Count
            While j >= 1
                permCards3(j).sendtoback()
                j -= 1
            End While
        ElseIf tempCard.hitOn = "Battlesite" Then
            Dim i = 1
            For Each card In hitCardsB
                If tempCard IsNot card Then
                    i += 1
                Else
                    Exit For
                End If
            Next

            If hitCardsB.Count > 1 And i <> hitCardsB.Count Then
                For k = i + 1 To hitCardsB.Count
                    hitCardsB(k).left = hitCardsB(k - 1).left
                Next
            End If

            tempCard.location = New Point(Battlesite.Left + (tempCard.width / 10) + (permCardsB.Count * (tempCard.width / 3)), Battlesite.Top - (tempCard.height / 5))
            tempCard.hit = False
            tempCard.hitOn = Nothing
            tempCard.perm = True
            permCardsB.Add(tempCard)
            PermCardsTop = tempCard.top
            hitCardsB.Remove(i)

            Dim j = permCardsB.Count
            While j >= 1
                permCardsB(j).sendtoback()
                j -= 1
            End While
        ElseIf tempCard.hitOn = "Character4" Then
            Dim i = 1
            For Each card In hitCards4
                If tempCard IsNot card Then
                    i += 1
                Else
                    Exit For
                End If
            Next

            If hitCards4.Count > 1 And i <> hitCards4.Count Then
                For k = i + 1 To hitCards4.Count
                    hitCards4(k).top = hitCards4(k - 1).top
                Next
            End If

            tempCard.location = New Point(Character4.Left - (tempCard.width / 3), Character4.Top + (tempCard.height / 20) + (permCards4.Count * (tempCard.height / 5)))
            tempCard.hit = False
            tempCard.hitOn = Nothing
            tempCard.perm = True
            permCards4.Add(tempCard)
            PermCardsBackTop = tempCard.top
            hitCardsB.Remove(i)

            Dim j = permCards4.Count
            While j >= 1
                permCards4(j).sendtoback()
                j -= 1
            End While
        End If
    End Sub
    '
    '
    'move hit to another character
    Private Sub bM_Click(sender As Object, e As EventArgs) Handles bM.Click
        ShowMoveBox()
    End Sub
    '
    '
    '
    '
    '
    '
    '
    '
    '
    'missions' venture/button actions
    '
    '
    Private Sub bMinusMe_Click(sender As Object, e As EventArgs) Handles bMinusMe.Click
        myTotalVenture -= 1
        MyTotalV.Text = CType(myTotalVenture, String)
        TextInput.Focus()
    End Sub

    Private Sub bPlusMe_Click(sender As Object, e As EventArgs) Handles bPlusMe.Click
        myTotalVenture += 1
        MyTotalV.Text = CType(myTotalVenture, String)
        TextInput.Focus()
    End Sub

    Private Sub bMinusOpp_Click(sender As Object, e As EventArgs) Handles bMinusOpp.Click
        oppTotalVenture -= 1
        OppTotalV.Text = CType(oppTotalVenture, String)
        TextInput.Focus()
    End Sub

    Private Sub bPlusOpp_Click(sender As Object, e As EventArgs) Handles bPlusOpp.Click
        oppTotalVenture += 1
        OppTotalV.Text = CType(oppTotalVenture, String)
        TextInput.Focus()
    End Sub

    Private Sub bPlusV_Click(sender As Object, e As MouseEventArgs) Handles bPlusV.MouseClick
        If tempCard.pile = "Reserve" Then
            tempCard.left = VentureR.Left + (vReserveCards.Count * (tempCard.width / 3))
            tempCard.bringtofront()
            Dim i = 1
            While i <= ReserveCards.Count
                If ReserveCards(i).orderNumber = tempCard.orderNumber Then
                    Exit While
                Else
                    i += 1
                End If
            End While
            ReserveCards.Remove(i)
            tempCard.pile = "VentureR"
            vReserveCards.Add(tempCard)

            If Host = True Then
                hSendCommand("vfromreserve")
            Else
                cSendCommand("vfromreserve")
            End If
        ElseIf tempCard.pile = "Completed" Then
            If DefeatedCards.Count > 0 Then
                tempCard.left = VentureC.Left + (vCompletedCards.Count * (tempCard.width / 3))
                tempCard.bringtofront()
                Dim i = 1
                While i <= CompletedCards.Count
                    If CompletedCards(i).orderNumber = tempCard.orderNumber Then
                        Exit While
                    Else
                        i += 1
                    End If
                End While
                CompletedCards.Remove(i)
                tempCard.pile = "VentureC"
                vCompletedCards.Add(tempCard)

                If Host = True Then
                    hSendCommand("vfromcompleted")
                Else
                    cSendCommand("vfromcompleted")
                End If
            Else
                MsgBox("You cannot venture from completed unless you have defeated missions.", MsgBoxStyle.Information, "")
            End If
        End If
        b2D.Visible = False
        b2R.Visible = False
        b2C.Visible = False
        bPlusV.Visible = False
        bMinusV.Visible = False
    End Sub

    Private Sub bMinusV_Click(sender As Object, e As MouseEventArgs) Handles bMinusV.MouseClick
        If tempCard.pile = "VentureR" Then
            Dim i = 1
            While i <= vReserveCards.Count
                If vReserveCards(i).orderNumber = tempCard.orderNumber Then
                    Exit While
                Else
                    i += 1
                End If
            End While
            vReserveCards.Remove(i)

            For j = 1 To vReserveCards.Count
                vReserveCards(j).left = VentureR.Left + ((j - 1) * (tempCard.width / 3))
            Next

            tempCard.left = Reserve.Left
            tempCard.bringtofront()
            tempCard.pile = "Reserve"
            ReserveCards.Add(tempCard)

            If Host = True Then
                hSendCommand("vrtor")
            Else
                cSendCommand("vrtor")
            End If

        ElseIf tempCard.pile = "VentureC" Then
            Dim i = 1
            While i <= vCompletedCards.Count
                If vCompletedCards(i).orderNumber = tempCard.orderNumber Then
                    Exit While
                Else
                    i += 1
                End If
            End While
            vCompletedCards.Remove(i)

            For j = 1 To vCompletedCards.Count
                vCompletedCards(j).left = VentureC.Left + ((j - 1) * (tempCard.width / 3))
            Next

            tempCard.left = Completed.Left
            tempCard.bringtofront()
            tempCard.pile = "Completed"
            CompletedCards.Add(tempCard)

            If Host = True Then
                hSendCommand("vctoc")
            Else
                cSendCommand("vctoc")
            End If

        End If
        b2D.Visible = False
        b2R.Visible = False
        b2C.Visible = False
        bPlusV.Visible = False
        bMinusV.Visible = False
    End Sub

    Private Sub b2R_Click(sender As Object, e As MouseEventArgs) Handles b2R.MouseClick
        If tempCard.pile = "Defeated" Then
            Dim i = 1
            While i <= DefeatedCards.Count
                If DefeatedCards(i).orderNumber = tempCard.orderNumber Then
                    Exit While
                Else
                    i += 1
                End If
            End While
            DefeatedCards.Remove(i)
            tempCard.location = Reserve.Location
            tempCard.image = tempCard.imageFront
            tempCard.bringtofront()
            tempCard.pile = "Reserve"
            ReserveCards.Add(tempCard)

            If Host = True Then
                hSendCommand("dtor")
            Else
                cSendCommand("dtor")
            End If

        ElseIf tempCard.pile = "Completed" Then
            Dim i = 1
            While i <= CompletedCards.Count
                If CompletedCards(i).orderNumber = tempCard.orderNumber Then
                    Exit While
                Else
                    i += 1
                End If
            End While
            CompletedCards.Remove(i)
            tempCard.location = Reserve.Location
            tempCard.bringtofront()
            tempCard.pile = "Reserve"
            ReserveCards.Add(tempCard)

            If Host = True Then
                hSendCommand("ctor")
            Else
                cSendCommand("ctor")
            End If

        ElseIf tempCard.pile = "VentureC" Then
            Dim i = 1
            While i <= vCompletedCards.Count
                If vCompletedCards(i).orderNumber = tempCard.orderNumber Then
                    Exit While
                Else
                    i += 1
                End If
            End While
            vCompletedCards.Remove(i)

            For j = 1 To vCompletedCards.Count
                vCompletedCards(j).left = VentureC.Left + ((j - 1) * (tempCard.width / 3))
            Next

            tempCard.location = Reserve.Location
            tempCard.bringtofront()
            tempCard.pile = "Reserve"
            ReserveCards.Add(tempCard)

            If Host = True Then
                hSendCommand("vctor")
            Else
                cSendCommand("vctor")
            End If

        ElseIf tempCard.pile = "VentureR" Then
            Dim i = 1
            While i <= vReserveCards.Count
                If vReserveCards(i).orderNumber = tempCard.orderNumber Then
                    Exit While
                Else
                    i += 1
                End If
            End While
            vReserveCards.Remove(i)

            For j = 1 To vReserveCards.Count
                vReserveCards(j).left = VentureR.Left + ((j - 1) * (tempCard.width / 3))
            Next

            tempCard.location = Reserve.Location
            tempCard.bringtofront()
            tempCard.pile = "Reserve"
            ReserveCards.Add(tempCard)

            If Host = True Then
                hSendCommand("vrtor")
            Else
                cSendCommand("vrtor")
            End If

        End If
        b2D.Visible = False
        b2R.Visible = False
        b2C.Visible = False
        bPlusV.Visible = False
        bMinusV.Visible = False
    End Sub

    Private Sub b2C_Click(sender As Object, e As MouseEventArgs) Handles b2C.MouseClick
        If tempCard.pile = "Defeated" Then
            Dim i = 1
            While i <= DefeatedCards.Count
                If DefeatedCards(i).orderNumber = tempCard.orderNumber Then
                    Exit While
                Else
                    i += 1
                End If
            End While
            DefeatedCards.Remove(i)
            tempCard.location = Completed.Location
            tempCard.image = tempCard.imageFront
            tempCard.bringtofront()
            tempCard.pile = "Completed"
            CompletedCards.Add(tempCard)

            If Host = True Then
                hSendCommand("dtoc")
            Else
                cSendCommand("dtoc")
            End If

        ElseIf tempCard.pile = "VentureR" Then
            Dim i = 1
            While i <= vReserveCards.Count
                If vReserveCards(i).orderNumber = tempCard.orderNumber Then
                    Exit While
                Else
                    i += 1
                End If
            End While
            vReserveCards.Remove(i)

            For j = 1 To vReserveCards.Count
                vReserveCards(j).left = VentureR.Left + ((j - 1) * (tempCard.width / 3))
            Next

            tempCard.location = Completed.Location
            tempCard.bringtofront()
            tempCard.pile = "Completed"
            CompletedCards.Add(tempCard)

            If Host = True Then
                hSendCommand("vrtoc")
            Else
                cSendCommand("vrtoc")
            End If

        ElseIf tempCard.pile = "VentureC" Then
            Dim i = 1
            While i <= vCompletedCards.Count
                If vCompletedCards(i).orderNumber = tempCard.orderNumber Then
                    Exit While
                Else
                    i += 1
                End If
            End While
            vCompletedCards.Remove(i)

            For j = 1 To vCompletedCards.Count
                vCompletedCards(j).left = VentureC.Left + ((j - 1) * (tempCard.width / 3))
            Next

            tempCard.location = Completed.Location
            tempCard.bringtofront()
            tempCard.pile = "Completed"
            CompletedCards.Add(tempCard)

            If Host = True Then
                hSendCommand("vctoc")
            Else
                cSendCommand("vctoc")
            End If

        End If
        b2D.Visible = False
        b2R.Visible = False
        b2C.Visible = False
        bPlusV.Visible = False
        bMinusV.Visible = False
    End Sub

    Private Sub b2D_Click(sender As Object, e As EventArgs) Handles b2D.Click
        If tempCard.pile = "VentureR" Then
            Dim i = 1
            While i <= vReserveCards.Count
                If vReserveCards(i).orderNumber = tempCard.orderNumber Then
                    Exit While
                Else
                    i += 1
                End If
            End While
            vReserveCards.Remove(i)
            For j = 1 To vReserveCards.Count
                vReserveCards(j).left = VentureR.Left + ((j - 1) * (tempCard.width / 3))
            Next
            tempCard.location = Defeated.Location
            tempCard.image = tempCard.imageBack
            tempCard.bringtofront()
            tempCard.pile = "Defeated"
            DefeatedCards.Add(tempCard)

            If Host = True Then
                hSendCommand("vrtod")
            Else
                cSendCommand("vrtod")
            End If

        End If
        b2D.Visible = False
        b2R.Visible = False
        b2C.Visible = False
        bPlusV.Visible = False
        bMinusV.Visible = False
    End Sub
    '
    '
    '
    '
    '
    '
    '
    '
    'playable card clicked once
    Private Sub CardsClick(sender As Object, e As EventArgs)
        For Each pp In placeCards
            For Each card In pp
                card.bringtofront()
            Next
        Next

        If PlaceTextBox.Visible = False And PlayTextBox.Visible = False And MoveBox.Visible = False Then
            'show as big card
            TextBox1.Visible = False
            If sender.wide = True Then
                BigCardV.Visible = False
                BigCardH.Image = sender.image
                BigCardH.Visible = True
                If TypeOf sender Is MissionEvent Then
                    TextBox1.Top = BigCardH.Bottom + 5
                    TextBox1.Width = BigCardH.Width
                    TextBox1.Visible = True
                    TextBox1.Text = sender.effect
                End If
            Else
                BigCardH.Visible = False
                BigCardV.Image = sender.image
                BigCardV.Visible = True
                If TypeOf sender Is Aspect Or TypeOf sender Is Artifact Or TypeOf sender Is Special Then
                    TextBox1.Top = BigCardV.Bottom + 5
                    TextBox1.Width = BigCardV.Width
                    TextBox1.Visible = True
                    TextBox1.Text = sender.effect
                End If
            End If

            'puts other cards back in place if out of place
            For Each card In handCards
                If card.left <> HandCardLeft And card IsNot sender Then
                    bPlay.Visible = False
                    bDiscard.Visible = False
                    bPlace.Visible = False
                    card.Location = New Point(HandCardLeft, card.Top)
                    PlaceTextBox.Visible = False
                End If
            Next

            bP.Visible = False
            bD.Visible = False
            bR.Visible = False
            b2P.Visible = False
            b2D.Visible = False
            b2C.Visible = False
            b2R.Visible = False
            bPlusV.Visible = False
            bMinusV.Visible = False
            BSlistbox.Visible = False

            'if it was a placed card clicked
            If sender.placed = True Then
                bR.Visible = False
                tempCard = sender
                'shows buttons
                If sender.top = PlaceCardsTop Or sender.top = PlaceCardsBackTop Then
                    If Phase.Text = "DISCARD" Then
                        tempCard.bringtofront()
                        bD.Location = New Point(sender.left + 2, sender.bottom - bD.Height - 2)
                        bD.BringToFront()
                        bD.Visible = True
                    ElseIf Phase.Text = "BATTLE" Then
                        tempCard.bringtofront()
                        bD.Location = New Point(sender.left + 2, sender.bottom - bD.Height - 2)
                        bD.BringToFront()
                        bD.Visible = True
                        If DefendBox.Visible = True Then
                            If TypeOf tempCard Is PowerCard Or TypeOf tempCard Is Special Or TypeOf tempCard Is BasicUniverse Or TypeOf tempCard Is Doubleshot Or TypeOf tempCard Is Training Then
                                bP.Location = New Point(bD.Left, bD.Top - bP.Height - 2)
                                bP.Visible = True
                                bP.BringToFront()
                            End If
                        ElseIf AttackBox.Visible = True Or bPhase.Enabled = True Then
                            bP.Location = New Point(bD.Left, bD.Top - bP.Height - 2)
                            bP.Visible = True
                            bP.BringToFront()
                        End If
                    End If
                End If

                'if it was a played card clicked
            ElseIf sender.played = True Then
                If sender.top = PlayCardsTop Or sender.top = PlayCardsBackTop Then
                    If AttackToLine.Visible = False Then
                        If bD.Visible = False Then
                            tempCard = sender
                            bD.Location = New Point(sender.left + 2, sender.bottom - bD.Height - 2)
                            bD.Visible = True
                            bD.BringToFront()
                        Else
                            If bD.Left = sender.left + 2 Then
                                bD.Visible = False
                                tempCard = vbNull
                            Else
                                tempCard = sender
                                bD.Location = New Point(sender.left + 2, sender.bottom - bD.Height - 2)
                                bD.BringToFront()
                            End If
                        End If
                    End If
                End If

                'if it was a hits in current battle card clicked
            ElseIf sender.hit = True Then
                If AttackToLine.Visible = False Then
                    If bR.Visible = False Then
                        tempCard = sender
                        b2P.Location = New Point(sender.left + 1, sender.bottom - b2P.Height - 1)
                        b2P.Visible = True
                        b2P.BringToFront()
                        bM.Location = New Point(b2P.Left, b2P.Top - bM.Height - 1)
                        bM.Visible = True
                        bM.BringToFront()
                        bR.Location = New Point(bM.Left, bM.Top - bR.Height - 1)
                        bR.Visible = True
                        bR.BringToFront()
                    Else
                        If b2P.Left = sender.left + 1 Then
                            b2P.Visible = False
                            bR.Visible = False
                            bM.Visible = False
                            tempCard = vbNull
                        Else
                            tempCard = sender
                            b2P.Location = New Point(sender.left + 1, sender.bottom - b2P.Height - 1)
                            b2P.BringToFront()
                            bM.Location = New Point(b2P.Left, b2P.Top - bM.Height - 1)
                            bM.BringToFront()
                            bR.Location = New Point(bM.Left, bM.Top - bR.Height - 1)
                            bR.BringToFront()
                        End If
                    End If
                End If


                'if it was a permanent record card clicked
            ElseIf sender.perm = True Then
                If AttackToLine.Visible = False Then
                    bD.Visible = False
                    bP.Visible = False
                    If bR.Visible = False Then
                        tempCard = sender
                        bR.Location = New Point(sender.left + 2, sender.top + 2)
                        bR.Visible = True
                        bR.BringToFront()
                    Else
                        bR.Visible = False
                        tempCard = vbNull
                    End If
                End If

                'if it was a card in the attackbox clicked
            ElseIf sender.attack = True And DefendBox.Visible = False Then
                If bCancel.Enabled = True Then
                    If bR.Visible = False Then
                        tempCard = sender
                        bR.Location = New Point(sender.left + 3, sender.bottom - bR.Height - 3)
                        bR.Visible = True
                        bR.BringToFront()
                    Else
                        If bR.Left = sender.left + 3 Then
                            bR.Visible = False
                            tempCard = vbNull
                        Else
                            bR.Location = New Point(sender.left + 3, sender.bottom - bR.Height - 3)
                            bR.BringToFront()
                        End If
                    End If
                End If

                'hand card was clicked
            ElseIf sender.left = HandCardLeft Or sender.left = HandCardLeftLeft Then
                If bCancel.Enabled = True Then
                    'moves card to left and puts buttons in correct places
                    bR.Visible = False
                    bD.Visible = False
                    bP.Visible = False
                    If sender.Left = HandCardLeft Then
                        If TypeOf sender Is MissionEvent Then
                            If Phase.Text = "DISCARD" Then
                                sender.Location = New Point(HandCardLeftLeft, sender.top)
                                tempCard = sender
                                bPlay.Location = New Point(sender.left + 5, sender.top + (sender.height / 5))
                                bDiscard.Location = New Point(bPlay.Left, bPlay.Top + bPlay.Height + 1)
                                bPlay.Visible = True
                                bDiscard.Visible = True
                                bPlay.BringToFront()
                                bDiscard.BringToFront()
                            Else
                                sender.Location = New Point(HandCardLeftLeft, sender.top)
                                tempCard = sender
                                bDiscard.Location = New Point(sender.left + 5, sender.top + (sender.height / 5))
                                bDiscard.Visible = True
                                bDiscard.BringToFront()
                            End If

                        ElseIf TypeOf sender Is Character Then
                            If Phase.Text = "BATTLE" Then
                                sender.Location = New Point(HandCardLeftLeft, sender.top)
                                tempCard = sender
                                bPlay.Location = New Point(sender.left + 5, sender.top + (sender.height / 5))
                                bDiscard.Location = New Point(bPlay.Left, bPlay.Top + bPlay.Height + 1)
                                bPlay.Visible = True
                                bDiscard.Visible = True
                                bPlay.BringToFront()
                                bDiscard.BringToFront()
                                ShowBSlistbox(sender)
                            Else
                                sender.Location = New Point(HandCardLeftLeft, sender.top)
                                tempCard = sender
                                bDiscard.Location = New Point(sender.left + 5, sender.top + (sender.height / 5))
                                bDiscard.Visible = True
                                bDiscard.BringToFront()
                            End If

                        Else
                            If Phase.Text = "DISCARD" Then
                                sender.Location = New Point(HandCardLeftLeft, sender.top)
                                tempCard = sender
                                bDiscard.Location = New Point(sender.left + 5, sender.top + (sender.height / 5))
                                bDiscard.Visible = True
                                bDiscard.BringToFront()
                            ElseIf Phase.Text = "PLACING" Then
                                sender.Location = New Point(HandCardLeftLeft, sender.top)
                                tempCard = sender
                                bPlace.Location = New Point(sender.left + 5, sender.top + (sender.height / 5))
                                bDiscard.Location = New Point(bPlace.Left, bPlace.Top + bPlace.Height + 1)
                                bPlace.Visible = True
                                bDiscard.Visible = True
                                bPlace.BringToFront()
                                bDiscard.BringToFront()
                            ElseIf Phase.Text = "VENTURE" Then
                                'do nothing
                            ElseIf Phase.Text = "BATTLE" Then
                                sender.Location = New Point(HandCardLeftLeft, sender.top)
                                tempCard = sender
                                If DefendBox.Visible = True Then
                                    If TypeOf tempCard Is PowerCard Or TypeOf tempCard Is Special Or TypeOf tempCard Is BasicUniverse Or TypeOf tempCard Is Doubleshot Or TypeOf tempCard Is Training Then
                                        bPlay.Location = New Point(sender.left + 5, sender.top + (sender.height / 5))
                                        bDiscard.Location = New Point(bPlay.Left, bPlay.Top + bPlay.Height + 1)
                                        bPlay.Visible = True
                                        bDiscard.Visible = True
                                        bPlay.BringToFront()
                                        bDiscard.BringToFront()
                                    Else
                                        bDiscard.Location = New Point(sender.left + 5, sender.top + (sender.height / 5))
                                        bDiscard.Visible = True
                                        bDiscard.BringToFront()
                                    End If
                                Else
                                    bPlay.Location = New Point(sender.left + 5, sender.top + (sender.height / 5))
                                    bDiscard.Location = New Point(bPlay.Left, bPlay.Top + bPlay.Height + 1)
                                    bPlay.Visible = True
                                    bDiscard.Visible = True
                                    bPlay.BringToFront()
                                    bDiscard.BringToFront()
                                End If
                            End If
                        End If

                        'returns the hand card to its regular location and hides buttons
                    ElseIf PlaceTextBox.Visible = False Then
                        bPlay.Visible = False
                        bDiscard.Visible = False
                        bPlace.Visible = False
                        tempCard = vbNull
                        sender.Location = New Point(HandCardLeft, sender.Top)
                    End If
                End If

                'if it was a card in the defendbox clicked
            ElseIf sender.defend = True And AcceptBox.Visible = False Then
                If bR.Visible = False Then
                    tempCard = sender
                    bR.Location = New Point(sender.left + 3, sender.bottom - bR.Height - 3)
                    bR.Visible = True
                    bR.BringToFront()
                Else
                    If bR.Left = sender.left + 3 Then
                        bR.Visible = False
                        tempCard = vbNull
                    Else
                        bR.Location = New Point(sender.left + 3, sender.bottom - bR.Height - 3)
                        bR.BringToFront()
                    End If
                End If
            End If
        End If
    End Sub
    '
    '
    'places a card if place button was clicked or choose character to attack with
    Private Sub CharClicked(sender As Object, e As EventArgs) Handles Character1.Click, Homebase.Click, Character4.Click, Character3.Click, Character2.Click, OppBattlesite.Click, OppCharacter4.Click, OppCharacter3.Click, OppCharacter2.Click, OppCharacter1.Click
        bP.Visible = False
        bD.Visible = False
        bR.Visible = False
        bDiscard.Visible = False
        bPlay.Visible = False
        bPlace.Visible = False
        b2C.Visible = False
        b2R.Visible = False
        b2D.Visible = False
        bPlusV.Visible = False
        bMinusV.Visible = False
        b2P.Visible = False

        'put hand cards back in place, if out of place
        If PlayTextBox.Visible = False And PlaceTextBox.Visible = False Then
            For Each card In handCards
                If card.left <> HandCardLeft Then
                    card.Location = New Point(HandCardLeft, card.Top)
                End If
            Next

            For Each pp In placeCards
                For Each card In pp
                    card.bringtofront()
                Next
            Next
        End If

        clicks = True
        tempCharX = sender
        Timer1.Start()
    End Sub
    '
    '
    'plays a card to own character if double-click was performed
    Private Sub Character_DoubleClick(sender As Object, e As EventArgs) Handles Character1.DoubleClick, Homebase.DoubleClick, Character4.DoubleClick, Character3.DoubleClick, Character2.DoubleClick
        clicks = False

        If PlayTextBox.Visible = True And tempCard.placed = False Then
            PlayTextBox.Visible = False
            bCancel.Visible = False

            Dim i As Integer = 1
            While i <= handCards.Count
                If tempCard IsNot handCards(i) Then
                    i += 1
                Else
                    Exit While
                End If
            End While

            handCards(i).size = SmallCardSize

            If sender Is Character1 Then
                handCards(i).played = True
                handCards(i).Location = New Point(sender.left + sender.width - handCards(i).width - (handCards(i).width / 2) + (playCards1.Count * (handCards(i).width / 3)), sender.top - (sender.height / 10))
                playCards1.Add(handCards(i))
                PlayCardsTop = handCards(i).top
            ElseIf sender Is Character2 Then
                handCards(i).played = True
                handCards(i).Location = New Point(sender.left + sender.width - handCards(i).width - (handCards(i).width / 2) + (playCards2.Count * (handCards(i).width / 3)), sender.top - (sender.height / 10))
                playCards2.Add(handCards(i))
                PlayCardsTop = handCards(i).top
            ElseIf sender Is Character3 Then
                handCards(i).played = True
                handCards(i).Location = New Point(sender.left + sender.width - handCards(i).width - (handCards(i).width / 2) + (playCards3.Count * (handCards(i).width / 3)), sender.top - (sender.height / 10))
                playCards3.Add(handCards(i))
                PlayCardsTop = handCards(i).top
            ElseIf sender Is Character4 Then
                handCards(i).played = True
                handCards(i).Location = New Point(sender.left + sender.width - handCards(i).width - (handCards(i).width / 2) + (playCards4.Count * (handCards(i).width / 3)), sender.top - (sender.height / 10))
                playCards4.Add(handCards(i))
                PlayCardsBackTop = handCards(i).top
            ElseIf sender Is Homebase Then
                handCards(i).played = True
                handCards(i).Location = New Point(sender.left + sender.width - handCards(i).width - (handCards(i).width / 2) + (playCardsH.Count * (handCards(i).width / 3)), sender.top - (sender.height / 10))
                playCardsH.Add(handCards(i))
                PlayCardsBackTop = handCards(i).top
            End If

            handCards.Remove(i)
            ResizeHand()

            Dim c As New Cereal
            c.played = True
            c.cardType = tempCard.GetType.ToString
            c.playedOn = sender.Name.ToString
            c.id = tempCard.id
            If Host = True Then
                hSendCard(c)
            Else
                cSendCard(c)
            End If

            Dim a As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
            Dim s As System.IO.Stream = a.GetManifestResourceStream("OverPower.PlacePlay.wav")
            Dim player As SoundPlayer = New SoundPlayer(s)
            player.Play()

            BG_Click(sender, e)
            tempChar = vbNull

            frmEndTurn.ShowDialog()

        ElseIf PlayTextBox.Visible = True And tempCard.placed = True Then
            PlayTextBox.Visible = False
            bCancel.Visible = False
            tempCard.played = True

            If sender Is Character1 Then
                tempCard.Location = New Point(sender.left + sender.width - tempCard.width - (tempCard.width / 2) + (playCards1.Count * (tempCard.width / 3)), sender.top - (sender.height / 10))
                playCards1.Add(tempCard)
                PlayCardsTop = tempCard.top
            ElseIf sender Is Character2 Then
                tempCard.Location = New Point(sender.left + sender.width - tempCard.width - (tempCard.width / 2) + (playCards2.Count * (tempCard.width / 3)), sender.top - (sender.height / 10))
                playCards2.Add(tempCard)
                PlayCardsTop = tempCard.top
            ElseIf sender Is Character3 Then
                tempCard.Location = New Point(sender.left + sender.width - tempCard.width - (tempCard.width / 2) + (playCards3.Count * (tempCard.width / 3)), sender.top - (sender.height / 10))
                playCards3.Add(tempCard)
                PlayCardsTop = tempCard.top
            ElseIf sender Is Character4 Then
                tempCard.Location = New Point(sender.left + sender.width - tempCard.width - (tempCard.width / 2) + (playCards4.Count * (tempCard.width / 3)), sender.top - (sender.height / 10))
                playCards4.Add(tempCard)
                PlayCardsTop = tempCard.top
            ElseIf sender Is Homebase Then
                tempCard.Location = New Point(sender.left + sender.width - tempCard.width - (tempCard.width / 2) + (playCardsH.Count * (tempCard.width / 3)), sender.top - (sender.height / 10))
                playCardsH.Add(tempCard)
                PlayCardsTop = tempCard.top
            End If

            ReorganizePlaced()
            tempCard.placed = False

            Dim c As New Cereal
            c.played = True
            c.cardType = tempCard.GetType.ToString
            c.playedOn = tempChar.Name.ToString
            c.id = tempCard.id
            If Host = True Then
                hSendCard(c)
            Else
                cSendCard(c)
            End If

            Dim a As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
            Dim s As System.IO.Stream = a.GetManifestResourceStream("OverPower.PlacePlay.wav")
            Dim player As SoundPlayer = New SoundPlayer(s)
            player.Play()

            BG_Click(sender, e)
            tempChar = vbNull

            frmEndTurn.ShowDialog()
        End If
    End Sub
    '
    '
    'performs these actions when only one click was determined
    Private Sub CharClicked2(sender As Object, e As EventArgs)
        If clicks = True Then
            'if in placing mode
            If PlaceTextBox.Visible = True And sender.top > AttackBox.Top Then
                Dim a As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
                Dim s As System.IO.Stream = a.GetManifestResourceStream("OverPower.PlacePlay.wav")
                Dim player As SoundPlayer = New SoundPlayer(s)
                player.Play()

                tempChar = tempCharX
                PlaceTextBox.Visible = False
                bCancel.Visible = False
                'find card in hand
                Dim i As Integer = 1
                While tempCard IsNot handCards(i) And i <= handCards.Count
                    i += 1
                End While

                'resize card
                handCards(i).size = SmallCardSize
                'place card to correct location
                PlaceCard(sender.name, tempCard)
                'remove from hand
                handCards.Remove(i)
                ResizeHand()

                tempCard = vbNull

            ElseIf MoveBox.Visible = True And sender.top > AttackBox.Top Then
                tempChar = tempCharX
                MoveBox.Visible = False

                Dim c As New Cereal
                c.move = True
                c.id = tempCard.id
                c.cardType = tempCard.GetType.ToString
                c.moveFrom = tempCard.hitOn
                c.moveTo = tempChar.Name

                If Host = True Then
                    hSendCard(c)
                Else
                    cSendCard(c)
                End If

                StifleHits = True
                ReorganizeHits()
                If tempChar.name = "Character1" Then
                    tempCard.location = New Point(Character1.Left + (tempCard.width / 10) + (hitCards1.Count * (tempCard.width / 3)), Character1.Top - (tempCard.height * 1.3))
                    hitCards1.Add(tempCard)
                    HitCardsTop = tempCard.top
                    tempCard.hitOn = "Character1"
                ElseIf tempChar.name = "Character2" Then
                    tempCard.location = New Point(Character2.Left + (tempCard.width / 10) + (hitCards2.Count * (tempCard.width / 3)), Character2.Top - (tempCard.height * 1.3))
                    hitCards2.Add(tempCard)
                    HitCardsTop = tempCard.top
                    tempCard.hitOn = "Character2"
                ElseIf tempChar.name = "Character3" Then
                    tempCard.location = New Point(Character3.Left + (tempCard.width / 10) + (hitCards3.Count * (tempCard.width / 3)), Character3.Top - (tempCard.height * 1.3))
                    hitCards3.Add(tempCard)
                    HitCardsTop = tempCard.top
                    tempCard.hitOn = "Character3"
                ElseIf tempChar.name = "Character4" Then
                    tempCard.location = New Point(Character4.Left - (tempCard.width * 1.5) - (hitCards4.Count * (tempCard.width / 3)), Character4.Top + (Character4.Height / 2) - (tempCard.height / 2))
                    hitCards4.Add(tempCard)
                    HitCardsBackTop = tempCard.top
                    tempCard.hitOn = "Character4"
                ElseIf tempChar.name = "Battlesite" Then
                    tempCard.location = New Point(Battlesite.Left + (tempCard.width / 10) + (hitCardsB.Count * (tempCard.width / 3)), Battlesite.Top - (tempCard.height * 1.3))
                    hitCardsB.Add(tempCard)
                    HitCardsTop = tempCard.top
                    tempCard.hitOn = "Battlesite"
                End If
                StifleHits = False
                tempCard.bringtofront()

                'if in battle phase
            ElseIf PlayTextBox.Visible = True And sender.top > AttackBox.Top Then
                tempChar = tempCharX
                attackFrom = tempChar.Name
                If tempCard.placed = True Then
                    'open attack box and play the placed card
                    ShowAttackBox()
                    ShowAttackPanel()

                    AttackFromLine.StartPoint = New Point(tempChar.left + (tempChar.width / 2), tempChar.top + (tempChar.height / 2))
                    AttackFromLine.EndPoint = New Point(AttackBox.Left + (AttackBox.Width / 2), AttackBox.Top + (AttackBox.Height / 2))
                    AttackFromLine.Visible = True
                    AttackFromLine.BringToFront()
                    bP_Click(sender, e)

                ElseIf tempChar.bottom > Completed.Top Then
                    'find card in hand
                    Dim i As Integer = 1
                    While tempCard IsNot handCards(i) And i <= handCards.Count
                        i += 1
                    End While

                    ShowAttackBox()
                    ShowAttackPanel()

                    handCards(i).size = DrawPile.Size
                    handCards(i).Location = New Point(AttackPanel.Right - ((AttackCards.Count + 1) * (DrawPile.Width + (DrawPile.Width / 10))), AttackBox.Bottom - handCards(i).Height - 5)
                    handCards(i).attack = True
                    handCards(i).bringtofront()
                    AttackCards.Add(handCards(i))
                    handCards.Remove(i)

                    Dim c As New Cereal
                    c.id = tempCard.id
                    c.cardType = tempCard.GetType.ToString
                    c.remove = True
                    c.fromHand = True

                    If Host = True Then
                        hSendCard(c)
                    Else
                        cSendCard(c)
                    End If

                    ResizeHand()
                    tempCard = vbNull
                    tempCharX = vbNull

                    AttackFromLine.StartPoint = New Point(tempChar.left + (tempChar.width / 2), tempChar.top + (tempChar.height / 2))
                    AttackFromLine.EndPoint = New Point(AttackBox.Left + (AttackBox.Width / 2), AttackBox.Top + (AttackBox.Height / 2))
                    AttackFromLine.Visible = True
                    AttackFromLine.BringToFront()
                End If

            ElseIf DefendBox.Visible = True And bShift.Enabled = False Then
                tempChar2 = tempCharX
                attackTo = "Opp" + tempChar2.Name
                AttackToLine.EndPoint = New Point(tempChar2.left + (tempChar2.width / 2), tempChar2.top + (tempChar2.height / 2))

                Dim c As New Cereal
                c.shifted = True
                c.defender = attackTo
                If Host = True Then
                    hSendCard(c)
                Else
                    cSendCard(c)
                End If

                DefendBox.Text = "Play cards to defend"
                bShift.Font = New Font(bShift.Font, FontStyle.Bold)
                bHits.Font = bShift.Font
                bDefend.Font = bHits.Font
                bShift.Enabled = True
                bHits.Enabled = True
                bDefend.Enabled = True

                'if clicked opponent to attack
            ElseIf AttackFromLine.Visible = True And AttackBox.Visible = True And bCancel.Enabled = True Then
                If sender.bottom < Completed.Top Then
                    tempChar2 = tempCharX
                    AttackToLine.StartPoint = New Point(AttackBox.Left + (AttackBox.Width / 2), AttackBox.Top + (AttackBox.Height / 2))
                    AttackToLine.EndPoint = New Point(tempChar2.left + (tempChar2.width / 2), tempChar2.top + (tempChar2.height / 2))
                    AttackToLine.Visible = True
                    AttackToLine.BringToFront()
                    bAttack.Enabled = True
                    bAttack.Font = New Font(bAttack.Font, FontStyle.Bold)
                    attackTo = sender.Name
                    'show as big card
                    BigCardV.Visible = False
                    BigCardH.Image = sender.Image
                    BigCardH.Visible = True
                    If sender IsNot OppBattlesite Then
                        If sender.inherent <> "" Then
                            TextBox1.Top = BigCardH.Bottom + 5
                            TextBox1.Width = BigCardH.Width
                            TextBox1.Visible = True
                            TextBox1.Text = sender.inherent
                        End If
                    End If
                Else
                    'show as big card
                    BigCardV.Visible = False
                    BigCardH.Image = sender.Image
                    BigCardH.Visible = True
                    If sender IsNot Battlesite Then
                        If sender.inherent <> "" Then
                            TextBox1.Top = BigCardH.Bottom + 5
                            TextBox1.Width = BigCardH.Width
                            TextBox1.Visible = True
                            TextBox1.Text = sender.inherent
                        End If
                    End If
                End If
            Else
                If sender.bottom < Completed.Top Then
                    BigCardV.Visible = False
                    BigCardH.Image = sender.Image
                    BigCardH.Visible = True
                    If sender IsNot OppBattlesite Then
                        If sender.inherent <> "" Then
                            TextBox1.Top = BigCardH.Bottom + 5
                            TextBox1.Width = BigCardH.Width
                            TextBox1.Visible = True
                            TextBox1.Text = sender.inherent
                        Else
                            TextBox1.Visible = False
                        End If
                    End If
                Else
                    If sender.inherent <> "" And sender IsNot Battlesite Then
                        TextBox1.Top = BigCardH.Bottom + 5
                        TextBox1.Width = BigCardH.Width
                        TextBox1.Visible = True
                        TextBox1.Text = sender.inherent
                    Else
                        TextBox1.Visible = False
                    End If
                    BigCardV.Visible = False
                    BigCardH.Image = sender.Image
                    BigCardH.Visible = True
                End If
            End If

            clicks = False
        End If
    End Sub
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    'timers
    '
    '
    'timer helps determine if click of double-click was performed during play mode
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        CharClicked2(tempCharX, e)
    End Sub
    '
    '
    'waiting for connection timer
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Stop()

        If Connected = True Then
            Exit Sub
        Else
            If wfc.Length <= 36 Then
                wfc = wfc + "."
            Else
                wfc = "Waiting for opponent to connect."
            End If
            TextOutput.Text = wfc
            Timer2.Start()
        End If
    End Sub
    '
    '
    'who goes first open on opponent's screen timer
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Timer3.Stop()
        If oppDoneLoadingDeck = True Then
            DrawCardToolStripMenuItem.Enabled = True
            ShuffleDeckToolStripMenuItem.Enabled = True

            hSendCommand("whogoesfirst")
            MsgBox("You will now draw cards to see who goes first", MsgBoxStyle.Information Or MsgBoxStyle.ApplicationModal Or MsgBoxStyle.OkOnly, "")
            frmWGF.ShowDialog()
        Else
            Timer3.Start()
        End If
    End Sub
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    'hosting actions
    '
    '
    Public Sub HostGame(ip As String)
        Host = True
        ConnectToolStripMenuItem.Enabled = False
        DisconnectToolStripMenuItem.Enabled = True
        HostingIP = ip
        mobjThread = New Threading.Thread(AddressOf DoListen)
        mobjThread.Start()
        UpdateStatus(wfc)
        Timer2.Start()
    End Sub

    Public Delegate Sub StatusInvoker(ByVal t As String)

    Private Delegate Sub UpdateStatusCallBack(ByVal t As String)

    Private Delegate Sub setEnabledCallBack(ByVal b As Boolean)

    Private Delegate Sub OnConnectedCallBack(ByVal id As String, ByVal sex As String)

    Private Delegate Sub CardReceivedCallBack(ByVal card As Cereal)

    Private Delegate Sub DeckReceivedCallBack(ByVal d As Cereal)

    Private Delegate Sub DiscardReceivedCallBack(ByVal card As Cereal)

    Private Delegate Sub CommandReceivedCallBack(ByVal cmd As Cereal)

    'listens for connections, endless loop
    Private Sub DoListen()
        Try
            Dim serverInfo As IPHostEntry
            Dim ipAddy As IPAddress = IPAddress.Parse(HostingIP)
            serverInfo = Dns.GetHostEntry(Dns.GetHostName)
            For Each ip As IPAddress In serverInfo.AddressList
                If ip.AddressFamily.ToString = "InterNetwork" Then
                    ipAddy = ip
                End If
            Next

            mobjListener = New TcpListener(ipAddy, Int32.Parse(Settings.Port.Text))
            mobjListener.Start()
            'Do
            Dim x As New Client(mobjListener.AcceptTcpClient)
            AddHandler x.Disconnected, AddressOf OnDisconnected
            AddHandler x.LineReceived, AddressOf OnLineReceived
            AddHandler x.CardReceived, AddressOf OnCardReceived
            AddHandler x.DeckReceived, AddressOf OnDeckReceived
            AddHandler x.DiscardReceived, AddressOf OnDiscard
            AddHandler x.CommandReceived, AddressOf OnCommandReceived
            AddHandler x.Connected, AddressOf OnConnected
            mcolClients.Add(x.ID, x)
            hSendConnect(UID, gender)
            Connected = True
            'Loop Until False
        Catch

        End Try
    End Sub

    Private Sub OnDisconnected(ByVal sender As Client)
        mcolClients.Remove(sender.ID)

        If mcolClients.Count = 0 Then
            setEnabled(False)
        End If
    End Sub

    Private Sub OnConnected(id As String, sex As String)
        If Me.InvokeRequired Then
            Me.Invoke(New OnConnectedCallBack(AddressOf OnConnected), id, sex)
        Else
            OUID = id
            oppGender = sex
            If Host = True Then
                UpdateStatus("You are connected to " + OUID + ".")
            Else
                DisplayText("You are connected to " + OUID + ".")
            End If
            Thread.Sleep(1000)

            If deckLoaded = False Then
                LoadDeckToolStripMenuItem.PerformClick()
            Else
                If Host = True Then
                    Thread.Sleep(500)
                End If
                SendAllDeckCards()
            End If
        End If
    End Sub

    'sends text to client streams (h1)
    Public Sub hSendText(ByVal Data As String)
        Dim objClient As Client
        Dim d As DictionaryEntry

        For Each d In mcolClients
            objClient = d.Value
            objClient.SendText(Data & vbCrLf)
        Next
    End Sub

    'sends command to client streams (h1)
    Public Sub hSendCommand(ByVal cmd As String)
        Dim objClient As Client
        Dim d As DictionaryEntry

        For Each d In mcolClients
            objClient = d.Value
            objClient.SendCommand(cmd)
        Next
    End Sub

    'sends a card to client streams (h1)
    Public Sub hSendCard(c As Cereal)
        Dim objClient As Client
        Dim d As DictionaryEntry

        For Each d In mcolClients
            objClient = d.Value
            objClient.SendCard(c)
        Next
    End Sub

    'sends deck(s) to client streams (h1)
    Private Sub hSendDeck(c As Cereal)
        Dim objClient As Client
        Dim d As DictionaryEntry

        For Each d In mcolClients
            objClient = d.Value
            objClient.SendDeck(c)
        Next
    End Sub

    'send a connect
    Private Sub hSendConnect(id As String, sex As String)
        Dim objClient As Client
        Dim d As DictionaryEntry

        For Each d In mcolClients
            objClient = d.Value
            objClient.SendConnect(id, sex)
        Next
    End Sub

    'displays text on host from client(c3)
    Private Sub OnLineReceived(ByVal sender As Client, ByVal Data As String)
        UpdateStatus(Data)

        'Dim objClient As Client
        'Dim d As DictionaryEntry

        'For Each d In mcolClients
        'objClient = d.Value
        'objClient.Send(Data & vbCrLf)
        'Next
    End Sub

    'updates host text displayed (c4)
    Public Sub UpdateStatus(ByVal t As String)
        If TextOutput.InvokeRequired Then
            TextOutput.Invoke(New UpdateStatusCallBack(AddressOf UpdateStatus), t)
        Else
            If (TextOutput.Text = "") Then
                TextOutput.Text += t
                TextInput.Focus()
            Else
                TextOutput.Text += vbNewLine + t
                TextOutput.Focus()
                TextOutput.Select(TextOutput.TextLength, 0)
                TextOutput.ScrollToCaret()
                TextOutput.ScrollToCaret()
                TextInput.Focus()
            End If
        End If
    End Sub
    '
    '
    'connecting actions
    '
    Public Sub ConnectToHost(ip As String, port As Int16)
        Host = False
        TextOutput.Text = "Connecting to opponent..."
        Try
            mobjClient = New TcpClient(ip, port)
            'listens for data to send to doRead
            mobjClient.GetStream.BeginRead(arData, 0, 3145728, AddressOf DoRead, Nothing)
            cSendConnect(UID, gender)
            Connected = True
            ConnectToolStripMenuItem.Enabled = False
            DisconnectToolStripMenuItem.Enabled = True
        Catch
            UpdateStatus("Could not connect to host.")
            ConnectToolStripMenuItem.Enabled = True
        End Try
    End Sub

    Public Delegate Sub DisplayInvoker(ByVal t As String)

    Private Delegate Sub DisplayTextCallBack(ByVal t As String)

    'sends text to host stream from client (c1)
    Public Sub cSendText(ByVal Data As String)
        Dim bf As New BinaryFormatter
        Dim ms As New MemoryStream
        Dim c As New Cereal
        Dim b() As Byte

        c.text = Data
        bf.Serialize(ms, c)
        b = ms.ToArray()
        ms.Close()

        SyncLock mobjClient.GetStream
            mobjClient.GetStream.Write(b, 0, b.Length)
        End SyncLock
    End Sub

    'sends command to host stream from client (c1)
    Public Sub cSendCommand(ByVal cmd As String)
        Dim bf As New BinaryFormatter
        Dim ms As New MemoryStream
        Dim c As New Cereal
        Dim b() As Byte

        c.command = cmd
        bf.Serialize(ms, c)
        b = ms.ToArray()
        ms.Close()

        SyncLock mobjClient.GetStream
            mobjClient.GetStream.Write(b, 0, b.Length)
        End SyncLock
    End Sub

    'sends card to host stream from client (c1)
    Public Sub cSendCard(c As Cereal)
        Dim bf As New BinaryFormatter
        Dim ms As New MemoryStream
        Dim b() As Byte

        bf.Serialize(ms, c)
        b = ms.ToArray()
        ms.Close()

        SyncLock mobjClient.GetStream
            mobjClient.GetStream.Write(b, 0, b.Length)
        End SyncLock
    End Sub

    'sends deck(s) to host stream from client (c1)
    Private Sub cSendDeck(c As Cereal)
        Dim bf As New BinaryFormatter
        Dim ms As New MemoryStream
        Dim b() As Byte

        bf.Serialize(ms, c)
        b = ms.ToArray()
        ms.Close()

        SyncLock mobjClient.GetStream
            mobjClient.GetStream.Write(b, 0, b.Length)
        End SyncLock
    End Sub

    Private Sub cSendConnect(id As String, sex As String)
        Dim bf As New BinaryFormatter
        Dim ms As New MemoryStream
        Dim c As New Cereal
        Dim b() As Byte

        c.OppUserID = id
        c.OppGender = sex
        bf.Serialize(ms, c)
        b = ms.ToArray()
        ms.Close()

        SyncLock mobjClient.GetStream
            mobjClient.GetStream.Write(b, 0, b.Length)
        End SyncLock
    End Sub

    'when data arrives on client stream from host (h3)
    Private Sub DoRead(ByVal ar As IAsyncResult)
        Dim intCount As Integer

        'Try
        SyncLock mobjClient.GetStream
            'returns the number of bytes to know how many to read
            intCount = mobjClient.GetStream.EndRead(ar)
        End SyncLock
        'if no bytes then we are disconnected
        If intCount < 1 Then
            MarkAsDisconnected()
            Exit Sub
        End If

        Dim bf As New BinaryFormatter
        Dim c As New Cereal
        Dim ms As New MemoryStream(arData)

        ms.SetLength(intCount)
        c = bf.Deserialize(ms)
        ms.Close()

        'starts the listener again
        mobjClient.GetStream.BeginRead(arData, 0, 3145728, AddressOf DoRead, Nothing)

        If c.text IsNot Nothing Then
            Dim a As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
            Dim s As System.IO.Stream = a.GetManifestResourceStream("OverPower.Message.wav")
            Dim player As SoundPlayer = New SoundPlayer(s)
            player.Play()

            DisplayText(c.text)
        ElseIf c.OppUserID IsNot Nothing Then
            OnConnected(c.OppUserID, c.OppGender)
        ElseIf c.command IsNot Nothing Then
            OnCommandReceived(c)
        ElseIf c.hasDeck = True Or c.hasBsDeck = True Or c.hasHand = True Then
            OnDeckReceived(c)
        ElseIf c.discard = True Then
            OnDiscard(c)
        Else
            OnCardReceived(c)
        End If

        'Catch e As Exception
        'MarkAsDisconnected()
        'End Try
    End Sub

    'displays the text on client (h4)
    Private Sub DisplayText(t As String)
        If TextOutput.InvokeRequired Then
            TextOutput.Invoke(New DisplayTextCallBack(AddressOf DisplayText), t)
        Else
            Dim tt As String = Replace(t, vbCrLf, " ")
            tt = Replace(tt, vbCr, " ")
            tt = Replace(tt, vbLf, " ")

            If (TextOutput.Text = "") Then
                TextOutput.AppendText(tt)
            Else
                TextOutput.AppendText(vbNewLine + tt)
                TextOutput.Focus()
                TextOutput.Select(TextOutput.TextLength, 0)
                TextOutput.ScrollToCaret()
                TextOutput.ScrollToCaret()
            End If
            TextInput.Focus()
        End If
    End Sub

    Private Sub MarkAsDisconnected()
        setEnabled(False)
    End Sub



    'discards card
    Private Sub OnDiscard(card As Cereal)
        If Me.InvokeRequired Then
            Me.Invoke(New DiscardReceivedCallBack(AddressOf OnDiscard), card)
        Else
            Dim a As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
            Dim s As System.IO.Stream = a.GetManifestResourceStream("OverPower.Discarded.wav")
            Dim player As SoundPlayer = New SoundPlayer(s)
            player.Play()

            Dim temp As Object = MakeCard(card)
            If temp.hit = True Or temp.perm = True Then
                If TypeOf temp Is PowerCard Then
                    If PowerPack.Visible = False Then
                        PowerPack.Visible = True
                    End If
                    powerP.Add(temp)
                    PowerPack.Image = temp.Image
                Else
                    If DeadPile.Visible = False Then
                        DeadPile.Visible = True
                    End If
                    deadP.Add(temp)
                    DeadPile.Image = temp.Image
                End If

                If temp.hit = True Then
                    OppReorganizeHits(temp)
                ElseIf temp.perm = True Then
                    OppReorganizePerms(temp)
                End If

                UpdateStatus(OUID + " removed the " + temp.commonname + " hit.")
            Else
                'discard to correct pile
                If TypeOf temp Is PowerCard Then
                    If OppPowerPack.Visible = False Then
                        OppPowerPack.Visible = True
                    End If
                    oppPowerP.Add(temp)
                    OppPowerPack.Image = temp.Image
                ElseIf TypeOf temp Is MissionEvent Then
                    If OppDefeatedChars.Visible = False Then
                        OppDefeatedChars.Visible = True
                    End If
                    oppDChars.Add(temp)
                    OppDefeatedChars.Image = temp.Image
                    OppDefeatedChars.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
                    rotatedo = False
                ElseIf TypeOf temp Is Character Then
                    'do nothing for now
                Else
                    If OppDeadPile.Visible = False Then
                        OppDeadPile.Visible = True
                    End If
                    oppDeadP.Add(temp)
                    OppDeadPile.Image = temp.Image
                End If

                If temp.placed = True Then
                    OppReorganizePlaced(temp)
                ElseIf temp.played = True Then
                    OppReorganizePlayed(temp)
                Else
                    Dim i As Integer = 1
                    While temp.GetType.ToString <> oppHandCards(i).GetType.ToString Or temp.id <> oppHandCards(i).id
                        i += 1
                    End While
                    oppHandCards.Remove(i)
                    lblOHS.Text = OUID + " Hand Size = " + oppHandCards.Count.ToString

                    If frmShowHand.Visible = True Then
                        frmShowHand.UpdateHand()
                    End If
                End If
                UpdateStatus(OUID + " discarded the " + temp.commonname + ".")
            End If
        End If
    End Sub

    'displays card
    Private Sub OnCardReceived(ByVal card As Cereal)
        If Me.InvokeRequired Then
            Me.Invoke(New CardReceivedCallBack(AddressOf OnCardReceived), card)
        Else
            If card.hasImage1 = True Or card.hasImage2 = True Then
                If card.hasImage1 = True Then
                    If card.wide1 = True Then
                        frmWGF.MyCard.Visible = False
                        frmWGF.MyWideCard.Visible = True
                        frmWGF.MyWideCard.Image = oppDeckCards(card.Image1).Image
                    Else
                        frmWGF.MyCard.Visible = True
                        frmWGF.MyWideCard.Visible = False
                        frmWGF.MyCard.Image = oppDeckCards(card.Image1).Image
                    End If
                End If
                If card.hasImage2 = True Then
                    If card.wide2 = True Then
                        frmWGF.OppCard.Visible = False
                        frmWGF.OppWideCard.Visible = True
                        frmWGF.OppWideCard.Image = myDeckCards(card.Image2).Image
                    Else
                        frmWGF.OppCard.Visible = True
                        frmWGF.OppWideCard.Visible = False
                        frmWGF.OppCard.Image = myDeckCards(card.Image2).Image
                    End If
                End If
                cSendCommand("cardsloaded")
                Exit Sub
            End If

            If card.ko = True Then
                Dim a As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
                Dim s As System.IO.Stream = a.GetManifestResourceStream("OverPower.KOd.wav")
                Dim player As SoundPlayer = New SoundPlayer(s)
                player.Play()
                If card.charKOd = "Character1" Then
                    OppCharacter1.KO = True
                    OppCharacter1.Refresh()
                ElseIf card.charKOd = "Character2" Then
                    OppCharacter2.KO = True
                    OppCharacter2.Refresh()
                ElseIf card.charKOd = "Character3" Then
                    OppCharacter3.KO = True
                    OppCharacter3.Refresh()
                ElseIf card.charKOd = "Character4" Then
                    OppCharacter4.KO = True
                    OppCharacter4.Refresh()
                ElseIf card.charKOd = "Battlesite" Then
                    OppBattlesite.KO = True
                    OppBattlesite.Refresh()
                End If
                Exit Sub
            End If

            If card.rez = True Then
                Dim a As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
                Dim s As System.IO.Stream = a.GetManifestResourceStream("OverPower.PlacedPlayed.wav")
                Dim player As SoundPlayer = New SoundPlayer(s)
                player.Play()
                If OppCharacter1.Visible = False Then
                    OppCharacter1.Parse(card.id)
                ElseIf OppCharacter2.Visible = False Then
                    OppCharacter2.Parse(card.id)
                ElseIf OppCharacter3.Visible = False Then
                    OppCharacter3.Parse(card.id)
                ElseIf OppCharacter4.Visible = False Then
                    OppCharacter4.Parse(card.id)
                End If
                Exit Sub
            End If

            If card.hasVenture = True Then
                frmVenture.doneV = False
                frmVenture.oppV.Text = card.Venture
                frmVenture.bAcceptV.Focus()
                If frmVenture.doneS = True Then
                    frmVenture.Text = "Waiting for you to accept total..."
                    frmVenture.bAcceptV.Enabled = True
                    frmVenture.bAcceptV.Font = New Font(frmVenture.bAcceptV.Font, FontStyle.Bold)
                Else
                    frmVenture.Text = "Waiting for you to send total..."
                    frmVenture.doneS = True
                End If
                Exit Sub
            End If

            If card.shifted = True Then
                UpdateStatus(OUID + " has shifted the attack.")
                attackTo = card.defender
                If attackTo = "Character1" Then
                    AttackToLine.EndPoint = New Point(OppCharacter1.Left + (OppCharacter1.Width / 2), OppCharacter1.Top + (OppCharacter1.Height / 2))
                    attackTo = "OppCharacter1"
                ElseIf attackTo = "Character2" Then
                    AttackToLine.EndPoint = New Point(OppCharacter2.Left + (OppCharacter2.Width / 2), OppCharacter2.Top + (OppCharacter2.Height / 2))
                    attackTo = "OppCharacter2"
                ElseIf attackTo = "Character3" Then
                    AttackToLine.EndPoint = New Point(OppCharacter3.Left + (OppCharacter3.Width / 2), OppCharacter3.Top + (OppCharacter3.Height / 2))
                    attackTo = "OppCharacter3"
                ElseIf attackTo = "Character4" Then
                    AttackToLine.EndPoint = New Point(OppCharacter4.Left + (OppCharacter4.Width / 2), OppCharacter4.Top + (OppCharacter4.Height / 2))
                    attackTo = "OppCharacter4"
                ElseIf attackTo = "Battlesite" Then
                    AttackToLine.EndPoint = New Point(OppBattlesite.Left + (OppBattlesite.Width / 2), OppBattlesite.Top + (OppBattlesite.Height / 2))
                    attackTo = "OppBattlesite"
                End If
                Exit Sub
            End If

            Dim temp As New Object
            If card.toPerm <> True Then
                temp = MakeCard(card)
            End If

            If card.move = True Then
                StifleHits = True
                temp.hitOn = card.moveFrom
                OppReorganizeHits(temp)

                If card.moveTo = "Character1" Then
                    tempCard.location = New Point(OppCharacter1.Left + (tempCard.width / 10) + (oppHitCards1.Count * (tempCard.width / 3)), OppCharacter1.Bottom + (tempCard.height / 3))
                    oppHitCards1.Add(tempCard)
                    OppHitCardsTop = tempCard.top
                    tempCard.hitOn = "OppCharacter1"
                ElseIf card.moveTo = "Character2" Then
                    tempCard.location = New Point(OppCharacter2.Left + (tempCard.width / 10) + (oppHitCards2.Count * (tempCard.width / 3)), OppCharacter2.Bottom + (tempCard.height / 3))
                    oppHitCards2.Add(tempCard)
                    OppHitCardsTop = tempCard.top
                    tempCard.hitOn = "OppCharacter2"
                ElseIf card.moveTo = "Character3" Then
                    tempCard.location = New Point(OppCharacter3.Left + (tempCard.width / 10) + (oppHitCards3.Count * (tempCard.width / 3)), OppCharacter3.Bottom + (tempCard.height / 3))
                    oppHitCards3.Add(tempCard)
                    OppHitCardsTop = tempCard.top
                    tempCard.hitOn = "OppCharacter3"
                ElseIf card.moveTo = "Character4" Then
                    tempCard.location = New Point(OppCharacter4.Right + (tempCard.width / 2) + (oppHitCards4.Count * (tempCard.width / 3)), OppCharacter4.Top + (OppCharacter4.Height / 2) - (tempCard.height / 2))
                    oppHitCards4.Add(tempCard)
                    OppHitCardsBackTop = tempCard.top
                    tempCard.hitOn = "OppCharacter4"
                ElseIf card.moveTo = "Battlesite" Then
                    tempCard.location = New Point(OppBattlesite.Left + (tempCard.width / 10) + (oppHitCardsB.Count * (tempCard.width / 3)), OppBattlesite.Bottom + (tempCard.height / 3))
                    oppHitCardsB.Add(tempCard)
                    OppHitCardsTop = tempCard.top
                    tempCard.hitOn = "OppBattlesite"
                End If

                StifleHits = False
                Exit Sub
                tempCard = vbNull
            End If

            If card.cardType = "OverPower.MissionEvent" Then
                Dim a As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
                Dim s As System.IO.Stream = a.GetManifestResourceStream("OverPower.PlacedPlayed.wav")
                Dim player As SoundPlayer = New SoundPlayer(s)
                player.Play()
                UpdateStatus(OUID + " has played an event.")
                RemoveFromOppHand(temp)
                Event2.Parse(temp)

                If oppDeckCards.Count > 1 Then
                    oppHandCards.Add(oppDeckCards(1))
                    oppDeckCards.Remove(1)
                    lblOHS.Text = OUID + " Hand Size = " + oppHandCards.Count.ToString
                    If frmShowHand.Visible = True Then
                        frmShowHand.UpdateHand()
                    End If
                ElseIf oppDeckCards.Count = 1 Then
                    oppHandCards.Add(oppDeckCards(1))
                    oppDeckCards.Remove(1)
                    lblOHS.Text = OUID + " Hand Size = " + oppHandCards.Count.ToString
                    If frmShowHand.Visible = True Then
                        frmShowHand.UpdateHand()
                    End If
                    If oppPowerP.Count > 0 Then
                        UpdateStatus(OUID + "'s deck is out of cards. Waiting for new deck...")
                        OppPowerPack.Image = Nothing
                        OppPowerPack.Visible = False
                        oppPowerP.Clear()
                        If oppInPP = False Then
                            UpdateStatus(OUID + " is now drawing from powerpack.")
                            oppInPP = True
                        End If
                        If Host = True Then
                            hSendCommand("sendppdeck")
                        Else
                            cSendCommand("sendppdeck")
                        End If
                    Else
                        OppDrawPile.Image = Nothing
                    End If
                End If
                Exit Sub
            End If

            If card.remove = True Then
                If card.fromPlaced = True Then
                    temp.placedOn = card.placedOn
                    OppReorganizePlaced(temp)
                ElseIf card.fromHand = True Then
                    RemoveFromOppHand(temp)
                Else
                    RemoveFromPile(card)
                End If
                Exit Sub
            End If

            If card.backToHand = True Then
                oppHandCards.Add(temp)
                lblOHS.Text = OUID + " Hand Size = " + oppHandCards.Count.ToString
                If frmShowHand.Visible = True Then
                    frmShowHand.UpdateHand()
                End If
                Exit Sub
            End If

            If card.toPerm <> True Then
                Me.Controls.Add(temp)
            End If

            If card.attack = True Then
                temp.attack = True
                If DefendBox.Visible = False Then
                    attackFrom = card.attacker
                    attackTo = card.defender
                    If card.faceDown = True Then
                        faceDown = True
                    End If
                End If
                AttackCards.Add(temp)

            ElseIf card.defend = True Then
                temp.defend = True
                DefendCards.Add(temp)

            ElseIf card.placed = True Then
                Try
                    RemoveFromOppHand(temp)
                    Dim a As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
                    Dim s As System.IO.Stream = a.GetManifestResourceStream("OverPower.PlacedPlayed.wav")
                    Dim player As SoundPlayer = New SoundPlayer(s)
                    player.Play()
                Catch
                End Try

                temp.placed = True
                temp.size = SmallCardSize

                If card.placedOn = "Character1" Then
                    Dim sender As Object = OppCharacter1
                    temp.Location = New Point(sender.left + (temp.Width / 10) + (oppPlaceCards1.Count * (temp.Width / 3)), sender.Top - (sender.Height / 10))
                    oppPlaceCards1.Add(temp)
                    OppPlaceCardsTop = temp.top
                ElseIf card.placedOn = "Character2" Then
                    Dim sender As Object = OppCharacter2
                    temp.Location = New Point(sender.left + (temp.Width / 10) + (oppPlaceCards2.Count * (temp.Width / 3)), sender.Top - (sender.Height / 10))
                    oppPlaceCards2.Add(temp)
                    OppPlaceCardsTop = temp.top
                ElseIf card.placedOn = "Character3" Then
                    Dim sender As Object = OppCharacter3
                    temp.Location = New Point(sender.left + (temp.Width / 10) + (oppPlaceCards3.Count * (temp.Width / 3)), sender.Top - (sender.Height / 10))
                    oppPlaceCards3.Add(temp)
                    OppPlaceCardsTop = temp.top
                ElseIf card.placedOn = "Character4" Then
                    Dim sender As Object = OppCharacter4
                    temp.Location = New Point(sender.left + (temp.Width / 10) + (oppPlaceCards4.Count * (temp.Width / 3)), sender.Top - (sender.Height / 10))
                    oppPlaceCards4.Add(temp)
                    OppPlaceCardsBackTop = temp.top
                ElseIf card.placedOn = "Homebase" Then
                    Dim sender As Object = OppHomebase
                    temp.Location = New Point(sender.left + (temp.Width / 10) + (oppPlaceCardsH.Count * (temp.Width / 3)), sender.Top - (sender.Height / 10))
                    oppPlaceCardsH.Add(temp)
                    OppPlaceCardsBackTop = temp.top
                End If

            ElseIf card.played = True Then
                Dim a As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
                Dim s As System.IO.Stream = a.GetManifestResourceStream("OverPower.PlacedPlayed.wav")
                Dim player As SoundPlayer = New SoundPlayer(s)
                player.Play()

                RemoveFromOppHand(temp)
                temp.played = True
                temp.size = SmallCardSize

                If card.playedOn = "Character1" Then
                    Dim sender As Object = OppCharacter1
                    temp.Location = New Point(sender.right - (temp.width * 1.5) + (oppPlayCards1.Count * (temp.width / 3)), sender.top + (sender.height / 2))
                    oppPlayCards1.Add(temp)
                    OppPlayCardsTop = temp.top
                ElseIf card.playedOn = "Character2" Then
                    Dim sender As Object = OppCharacter2
                    temp.Location = New Point(sender.right - (temp.width * 1.5) + (oppPlayCards2.Count * (temp.width / 3)), sender.top + (sender.height / 2))
                    oppPlayCards2.Add(temp)
                    OppPlayCardsTop = temp.top
                ElseIf card.playedOn = "Character3" Then
                    Dim sender As Object = OppCharacter3
                    temp.Location = New Point(sender.right - (temp.width * 1.5) + (oppPlayCards3.Count * (temp.width / 3)), sender.top + (sender.height / 2))
                    oppPlayCards3.Add(temp)
                    OppPlayCardsTop = temp.top
                ElseIf card.playedOn = "Character4" Then
                    Dim sender As Object = OppCharacter4
                    temp.Location = New Point(sender.right - (temp.width * 1.5) + (oppPlayCards4.Count * (temp.width / 3)), sender.top + (sender.height / 2))
                    oppPlayCards4.Add(temp)
                    OppPlayCardsBackTop = temp.top
                ElseIf card.playedOn = "Homebase" Then
                    Dim sender As Object = OppHomebase
                    temp.Location = New Point(sender.right - (temp.width * 1.5) + (oppPlayCardsH.Count * (temp.width / 3)), sender.top + (sender.height / 2))
                    oppPlayCardsH.Add(temp)
                    OppPlayCardsBackTop = temp.top
                End If

            ElseIf card.toPerm = True Then
                If card.hitOn = "Character1" Then
                    Dim i = 1
                    For Each hit In oppHitCards1
                        If card.cardType = hit.GetType.ToString And card.id = hit.id Then
                            If oppHitCards1.Count > 1 And i <> oppHitCards1.Count Then
                                For j = i + 1 To oppHitCards1.Count
                                    oppHitCards1(j).left = oppHitCards1(j - 1).left
                                Next
                            End If
                            hit.location = New Point(OppCharacter1.Left - (hit.width / 3), OppCharacter1.Top + (hit.height / 10) + (oppPermCards1.Count * (hit.width / 3)))
                            hit.hit = False
                            hit.hitOn = Nothing
                            oppPermCards1.Add(hit)
                            OppPermCardsTop = hit.top
                            oppHitCards1.Remove(i)
                            Exit For
                        Else
                            i += 1
                        End If
                    Next

                    For Each hit In oppPermCards1
                        hit.sendtoback()
                    Next

                ElseIf card.hitOn = "Character2" Then
                    Dim i = 1
                    For Each hit In oppHitCards2
                        If card.cardType = hit.GetType.ToString And card.id = hit.id Then
                            If oppHitCards2.Count > 1 And i <> oppHitCards2.Count Then
                                For j = i + 1 To oppHitCards2.Count
                                    oppHitCards2(j).left = oppHitCards2(j - 1).left
                                Next
                            End If
                            hit.location = New Point(OppCharacter2.Left - (hit.width / 3), OppCharacter2.Top + (hit.height / 10) + (oppPermCards2.Count * (hit.width / 3)))
                            hit.hit = False
                            hit.hitOn = Nothing
                            oppPermCards2.Add(hit)
                            OppPermCardsTop = hit.top
                            oppHitCards2.Remove(i)
                            Exit For
                        Else
                            i += 1
                        End If
                    Next

                    For Each hit In oppPermCards2
                        hit.sendtoback()
                    Next

                ElseIf card.hitOn = "Character3" Then
                    Dim i = 1
                    For Each hit In oppHitCards3
                        If card.cardType = hit.GetType.ToString And card.id = hit.id Then
                            If oppHitCards3.Count > 1 And i <> oppHitCards3.Count Then
                                For j = i + 1 To oppHitCards3.Count
                                    oppHitCards3(j).left = oppHitCards3(j - 1).left
                                Next
                            End If
                            hit.location = New Point(OppCharacter3.Left - (hit.width / 3), OppCharacter3.Top + (hit.height / 10) + (oppPermCards3.Count * (hit.width / 3)))
                            hit.hit = False
                            hit.hitOn = Nothing
                            oppPermCards3.Add(hit)
                            OppPermCardsTop = hit.top
                            oppHitCards3.Remove(i)
                            Exit For
                        Else
                            i += 1
                        End If
                    Next

                    For Each hit In oppPermCards3
                        hit.sendtoback()
                    Next

                ElseIf card.hitOn = "Battlesite" Then
                    Dim i = 1
                    For Each hit In oppHitCardsB
                        If card.cardType = hit.GetType.ToString And card.id = hit.id Then
                            If oppHitCardsB.Count > 1 And i <> oppHitCardsB.Count Then
                                For j = i + 1 To oppHitCardsB.Count
                                    oppHitCardsB(j).left = oppHitCardsB(j - 1).left
                                Next
                            End If
                            hit.location = New Point(OppBattlesite.Left - (hit.width / 4), OppBattlesite.Top + (hit.height / 10) + (oppPermCardsB.Count * (hit.width / 3)))
                            hit.hit = False
                            hit.hitOn = Nothing
                            oppPermCardsB.Add(hit)
                            OppPermCardsTop = hit.top
                            oppHitCardsB.Remove(i)
                            Exit For
                        Else
                            i += 1
                        End If
                    Next

                    For Each hit In oppPermCardsB
                        hit.sendtoback()
                    Next

                ElseIf card.hitOn = "Character4" Then
                    Dim i = 1
                    For Each hit In oppHitCards4
                        If card.cardType = hit.GetType.ToString And card.id = hit.id Then
                            If oppHitCards4.Count > 1 And i <> oppHitCards4.Count Then
                                For j = i + 1 To oppHitCards4.Count
                                    oppHitCards4(j).top = oppHitCards4(j - 1).top
                                Next
                            End If
                            hit.location = New Point(OppCharacter4.Left - (hit.width / 3), OppCharacter4.Top + (hit.height / 10) + (oppPermCards4.Count * (hit.width / 3)))
                            hit.hit = False
                            hit.hitOn = Nothing
                            oppPermCards4.Add(hit)
                            OppPermCardsBackTop = hit.top
                            oppHitCards4.Remove(i)
                            Exit For
                        Else
                            i += 1
                        End If
                    Next

                    For Each hit In oppPermCards4
                        hit.sendtoback()
                    Next
                End If
                Exit Sub
            End If

            If card.attack = False Then
                temp.bringtofront()
                temp.Visible = True
            End If
        End If
    End Sub

    'assigns decks
    Private Sub OnDeckReceived(ByVal d As Cereal)
        If Me.InvokeRequired = True Then
            Me.Invoke(New DeckReceivedCallBack(AddressOf OnDeckReceived), d)
        Else
            If d.hasDeck = True Or d.hasBsDeck = True Then
                If frmLoading.Visible = False Then
                    frmLoading.Show()
                End If

                frmLoading.Text = "Deck received from " + OUID
                Thread.Sleep(500)

                Dim c As New Cereal
                Dim count As Integer = 0
                If d.hasDeck = True And d.hasBsDeck = True And d.hasChars = True Then
                    count = 336 / (d.deck.Count + d.bsDeck.Count + d.chars.Count + 7)
                ElseIf d.hasDeck = True And d.hasBsDeck = True Then
                    count = 336 / (d.deck.Count + d.bsDeck.Count)
                ElseIf d.hasDeck = True Then
                    count = 336 / d.deck.Count
                ElseIf d.hasBsDeck = True Then
                    count = 336 / d.bsDeck.Count
                End If

                If d.hasDeck = True Then
                    oppDeckCards.Clear()
                    frmLoading.Text = "Loading " + OUID + "'s deck..."

                    For i = 1 To d.deck.Count
                        c.id = d.deck.Item(i).id
                        c.cardType = d.deck.Item(i).cardType
                        oppDeckCards.Add(MakeCard(c))
                        If frmLoading.SplitContainer1.SplitterDistance < 320 Then
                            frmLoading.SplitContainer1.SplitterDistance += count
                        End If
                    Next

                    OppDrawPile.Visible = True

                    If remainingDraws > 0 Then
                        If remainingDraws < OppDrawNum Then
                            OppDrawPile.Image = Nothing
                        End If
                        For i = 1 To remainingDraws
                            oppHandCards.Add(oppDeckCards(1))
                            oppDeckCards.Remove(1)
                        Next
                        lblOHS.Text = OUID + " Hand Size = " + oppHandCards.Count.ToString
                        remainingDraws = 0
                    End If
                End If

                If d.hasBsDeck = True Then
                    OppBsDeck.Clear()
                    frmLoading.Text = "Loading " + OUID + "'s battlesite deck..."

                    For Each cc In d.bsDeck
                        OppBsDeck.Add(New Special(cc.id))
                        If frmLoading.SplitContainer1.SplitterDistance < 320 Then
                            frmLoading.SplitContainer1.SplitterDistance += count
                        End If
                    Next
                End If

                If d.hasChars = True Then
                    oChars.Clear()
                    oppReserveCards.Clear()
                    frmLoading.Text = "Loading " + OUID + "'s characters..."
                    oChars.Add(OppCharacter1)
                    oChars.Add(OppCharacter2)
                    oChars.Add(OppCharacter3)
                    oChars.Add(OppCharacter4)
                    Dim i = 1

                    For i = 1 To 4
                        oChars(i).parse(d.chars(i).ID)
                        If frmLoading.SplitContainer1.SplitterDistance < 320 Then
                            frmLoading.SplitContainer1.SplitterDistance += count
                        End If
                    Next

                    Try
                        OppHomebase.Parse(d.chars("Homebase").id)
                        If OppHomebase.locName = "ONSLAUGHT'S CITADEL" Then
                            OppDrawNum = 7
                        End If
                    Catch

                    End Try
                    If frmLoading.SplitContainer1.SplitterDistance < 320 Then
                        frmLoading.SplitContainer1.SplitterDistance += count
                    End If

                    Try
                        OppBattlesite.Parse(d.chars("Battlesite").id)
                    Catch

                    End Try
                    If frmLoading.SplitContainer1.SplitterDistance < 320 Then
                        frmLoading.SplitContainer1.SplitterDistance += count
                    End If

                    For i = 1 To 7
                        oppMissionCards(i).location = OppReserve.Location
                        oppMissionCards(i).parse(d.mID, i)
                        oppMissionCards(i).pile = "OppReserve"
                        oppReserveCards.Add(oppMissionCards(i))
                        If frmLoading.SplitContainer1.SplitterDistance < 320 Then
                            frmLoading.SplitContainer1.SplitterDistance += count
                        End If
                    Next
                End If

                frmLoading.SplitContainer1.SplitterDistance = 335

                frmLoading.Text = "Done loading " + OUID + "'s deck..."
                If deckReceived <> True Then
                    deckReceived = True
                    OppCompleted.Visible = True
                    OppReserve.Visible = True
                    OppDefeated.Visible = True
                End If
                Thread.Sleep(500)

                If deckLoaded = True Then
                    frmLoading.Close()
                    inGame = True
                    RematchToolStripMenuItem.Enabled = True
                    LoadDeckToolStripMenuItem.Enabled = False
                Else
                    frmLoading.Text = "Waiting for you to load a deck..."
                    frmLoading.SplitContainer1.SplitterDistance = 0
                End If

                If Host = True Then
                    hSendCommand("doneloadingdeck")
                Else
                    cSendCommand("doneloadingdeck")
                End If

                If Host = True And deckLoaded = True And WGF = False Then
                    WhoGoesFirst()
                End If
            End If
        End If
    End Sub

    'initiate command
    Private Sub OnCommandReceived(ByVal cmd As Cereal)
        If Me.InvokeRequired Then
            Me.Invoke(New CommandReceivedCallBack(AddressOf OnCommandReceived), cmd)
        Else
            If cmd.command = "disconnect" Then
                UpdateStatus(OUID + " disconnected.")
                setEnabled(False)

            ElseIf cmd.command = "cardsloaded" Then
                frmWGF.setEnabled(True)

            ElseIf cmd.command = "attack" Then
                ShowDefendBox()
                ShowAttackPanel()
                AttackToLine.StartPoint = New Point(DefendBox.Left + (DefendBox.Width / 2), DefendBox.Top + (DefendBox.Height / 2))
                AttackFromLine.EndPoint = New Point(DefendBox.Left + (DefendBox.Width / 2), DefendBox.Top + (DefendBox.Height / 2))

                If attackTo = "OppCharacter1" Then
                    AttackToLine.EndPoint = New Point(Character1.Left + (Character1.Width / 2), Character1.Top + (Character1.Height / 2))
                ElseIf attackTo = "OppCharacter2" Then
                    AttackToLine.EndPoint = New Point(Character2.Left + (Character2.Width / 2), Character2.Top + (Character2.Height / 2))
                ElseIf attackTo = "OppCharacter3" Then
                    AttackToLine.EndPoint = New Point(Character3.Left + (Character3.Width / 2), Character3.Top + (Character3.Height / 2))
                ElseIf attackTo = "OppCharacter4" Then
                    AttackToLine.EndPoint = New Point(Character4.Left + (Character4.Width / 2), Character4.Top + (Character4.Height / 2))
                ElseIf attackTo = "OppBattlesite" Then
                    AttackToLine.EndPoint = New Point(Battlesite.Left + (Battlesite.Width / 2), Battlesite.Top + (Battlesite.Height / 2))
                End If

                If attackFrom = "Character1" Then
                    AttackFromLine.StartPoint = New Point(OppCharacter1.Left + (OppCharacter1.Width / 2), OppCharacter1.Top + (OppCharacter1.Height / 2))
                ElseIf attackFrom = "Character2" Then
                    AttackFromLine.StartPoint = New Point(OppCharacter2.Left + (OppCharacter2.Width / 2), OppCharacter2.Top + (OppCharacter2.Height / 2))
                ElseIf attackFrom = "Character3" Then
                    AttackFromLine.StartPoint = New Point(OppCharacter3.Left + (OppCharacter3.Width / 2), OppCharacter3.Top + (OppCharacter3.Height / 2))
                ElseIf attackFrom = "Character4" Then
                    AttackFromLine.StartPoint = New Point(OppCharacter4.Left + (OppCharacter4.Width / 2), OppCharacter4.Top + (OppCharacter4.Height / 2))
                ElseIf attackFrom = "Homebase" Then
                    AttackFromLine.StartPoint = New Point(OppHomebase.Left + (OppHomebase.Width / 2), OppHomebase.Top + (OppHomebase.Height / 2))
                End If

                AttackFromLine.Visible = True
                AttackToLine.Visible = True

                Dim i = 0
                For Each card In AttackCards
                    If faceDown = True Then
                        card.image = cardBacks
                    End If
                    card.size = DrawPile.Size
                    card.Location = New Point(AttackPanel.Left + (DrawPile.Width / 10) + (i * (card.width)) + (i * (DrawPile.Width / 10)), DefendBox.Bottom - card.Height - 5)
                    card.visible = True
                    card.bringtofront()
                    i += 1
                Next

            ElseIf cmd.command = "hits" Then
                Dim a As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
                Dim s As System.IO.Stream = a.GetManifestResourceStream("OverPower.HitEm.wav")
                Dim player As SoundPlayer = New SoundPlayer(s)
                player.Play()

                For Each card In AttackCards
                    If TypeOf card Is BasicUniverse Or TypeOf card Is Training Then
                        Me.Controls.Remove(card)
                        If DeadPile.Visible = False Then
                            DeadPile.Visible = True
                        End If
                        deadP.Add(card)
                        DeadPile.Image = card.image
                    Else
                        card.size = SmallCardSize
                        card.attack = False
                        If attackTo = "OppCharacter1" Then
                            card.location = New Point(OppCharacter1.Left + (card.width / 10) + (oppHitCards1.Count * (card.width / 3)), OppCharacter1.Bottom + (card.height / 3))
                            oppHitCards1.Add(card)
                            OppHitCardsTop = card.top
                            card.hitOn = "OppCharacter1"
                        ElseIf attackTo = "OppCharacter2" Then
                            card.location = New Point(OppCharacter2.Left + (card.width / 10) + (oppHitCards2.Count * (card.width / 3)), OppCharacter2.Bottom + (card.height / 3))
                            oppHitCards2.Add(card)
                            OppHitCardsTop = card.top
                            card.hitOn = "OppCharacter2"
                        ElseIf attackTo = "OppCharacter3" Then
                            card.location = New Point(OppCharacter3.Left + (card.width / 10) + (oppHitCards3.Count * (card.width / 3)), OppCharacter3.Bottom + (card.height / 3))
                            oppHitCards3.Add(card)
                            OppHitCardsTop = card.top
                            card.hitOn = "OppCharacter3"
                        ElseIf attackTo = "OppCharacter4" Then
                            card.location = New Point(OppCharacter4.Right + (card.width / 2) + (oppHitCards4.Count * (card.width / 3)), OppCharacter4.Top + (OppCharacter4.Height / 2) - (card.height / 2))
                            oppHitCards4.Add(card)
                            OppHitCardsBackTop = card.top
                            card.hitOn = "OppCharacter4"
                        ElseIf attackTo = "OppBattlesite" Then
                            card.location = New Point(OppBattlesite.Left + (card.width / 10) + (oppHitCardsB.Count * (card.width / 3)), OppBattlesite.Bottom + (card.height / 3))
                            oppHitCardsB.Add(card)
                            OppHitCardsTop = card.top
                            card.hitOn = "OppBattlesite"
                        End If
                        card.bringtofront()
                    End If
                Next

                AttackCards.Clear()
                AttackBox.Visible = False
                AttackPanel.Visible = False
                bCancel.Visible = False
                bCancel.Enabled = True
                bAttack.Visible = False
                cbFacedown.Visible = False
                AttackFromLine.Visible = False
                AttackToLine.Visible = False
                attackTo = Nothing
                attackFrom = Nothing
                bMin.Visible = False

                If FollowUp = False Then
                    frmEndTurn.ShowDialog()
                End If

            ElseIf cmd.command = "defend" Then
                ShowAcceptBox()
                AttackPanel.Panel2Collapsed = False
                AttackPanel.Width = ((AttackCards.Count + DefendCards.Count) * (DrawPile.Width + (DrawPile.Width / 10))) + AttackPanel.SplitterWidth + (2 * DrawPile.Width / 10)
                AttackPanel.SplitterDistance = (AttackCards.Count * (DrawPile.Width + (DrawPile.Width / 10))) + (DrawPile.Width / 10)
                AttackPanel.Left = AcceptBox.Left + (AcceptBox.Width / 2) - (AttackCards.Count * (DrawPile.Width + (DrawPile.Width / 10))) - (DrawPile.Width / 10)
                AttackPanel.BringToFront()
                For Each card In AttackCards
                    card.bringtofront()
                Next
                Dim i = 0
                For Each card In DefendCards
                    card.size = DrawPile.Size
                    card.Location = New Point(AttackPanel.Left + AttackPanel.SplitterDistance + AttackPanel.SplitterWidth + (DrawPile.Width / 10) + (i * (card.width)) + (i * (DrawPile.Width / 10)), AcceptBox.Bottom - card.Height - 5)
                    card.visible = True
                    card.bringtofront()
                    i += 1
                Next

            ElseIf cmd.command = "accept" Then
                UpdateStatus(OUID + " has accepted your defense.")
                For Each card In AttackCards
                    If faceDown = True Then
                        card.image = card.ImageFront
                    End If
                    card.attack = False
                    Me.Controls.Remove(card)
                    If TypeOf card Is PowerCard Then
                        If OppPowerPack.Visible = False Then
                            OppPowerPack.Visible = True
                        End If
                        oppPowerP.Add(card)
                        OppPowerPack.Image = card.image
                    Else
                        If OppDeadPile.Visible = False Then
                            OppDeadPile.Visible = True
                        End If
                        oppDeadP.Add(card)
                        OppDeadPile.Image = card.Image
                    End If
                Next

                For Each card In DefendCards
                    card.defend = False
                    Me.Controls.Remove(card)
                    If TypeOf card Is PowerCard Then
                        If PowerPack.Visible = False Then
                            PowerPack.Visible = True
                        End If
                        powerP.Add(card)
                        PowerPack.Image = card.image
                    Else
                        If DeadPile.Visible = False Then
                            DeadPile.Visible = True
                        End If
                        deadP.Add(card)
                        DeadPile.Image = card.Image
                    End If
                Next

                AttackCards.Clear()
                DefendCards.Clear()
                DefendBox.Visible = False
                AttackPanel.Visible = False
                bHits.Visible = False
                bDefend.Visible = False
                bShift.Visible = False
                AttackFromLine.Visible = False
                AttackToLine.Visible = False
                attackTo = Nothing
                attackFrom = Nothing
                bMin.Visible = False
                AttackPanel.Panel2Collapsed = True
                bCancel.Enabled = True
                faceDown = False

            ElseIf cmd.command = "challenge" Then
                Dim a As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
                Dim s As System.IO.Stream = a.GetManifestResourceStream("OverPower.Challenged.wav")
                Dim player As SoundPlayer = New SoundPlayer(s)
                player.Play()

                MsgBox("Your defense has been challenged", MsgBoxStyle.Information)
                bDefend.Enabled = True
                bHits.Enabled = True
                bShift.Enabled = True
                bDefend.Font = New Font(bDefend.Font, FontStyle.Bold)
                bHits.Font = bDefend.Font
                bShift.Font = bDefend.Font

            ElseIf cmd.command = "drawcard" Then
                Dim a As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
                Dim s As System.IO.Stream = a.GetManifestResourceStream("OverPower.DealCard.wav")
                Dim player As SoundPlayer = New SoundPlayer(s)
                player.Play()

                UpdateStatus(OUID + " drew a card.")
                If oppDeckCards.Count > 1 Then
                    oppHandCards.Add(oppDeckCards(1))
                    oppDeckCards.Remove(1)
                    lblOHS.Text = OUID + " Hand Size = " + oppHandCards.Count.ToString
                    If frmShowHand.Visible = True Then
                        frmShowHand.UpdateHand()
                    End If
                ElseIf oppDeckCards.Count = 1 Then
                    oppHandCards.Add(oppDeckCards(1))
                    oppDeckCards.Remove(1)
                    lblOHS.Text = OUID + " Hand Size = " + oppHandCards.Count.ToString
                    If frmShowHand.Visible = True Then
                        frmShowHand.UpdateHand()
                    End If
                    If oppPowerP.Count > 0 Then
                        UpdateStatus(OUID + "'s deck is out of cards. Waiting for new deck...")
                        OppPowerPack.Image = Nothing
                        OppPowerPack.Visible = False
                        oppPowerP.Clear()
                        If oppInPP = False Then
                            UpdateStatus(OUID + " is now drawing from powerpack.")
                            oppInPP = True
                        End If
                        If Host = True Then
                            hSendCommand("sendppdeck")
                        Else
                            cSendCommand("sendppdeck")
                        End If
                    Else
                        OppDrawPile.Image = Nothing
                    End If
                End If
            ElseIf cmd.command = "drawhand" Then
                If oppDeckCards.Count > OppDrawNum Then
                    For i = 1 To OppDrawNum
                        oppHandCards.Add(oppDeckCards.Item(1))
                        oppDeckCards.Remove(1)
                    Next
                    lblOHS.Text = OUID + " Hand Size = " + oppHandCards.Count.ToString
                ElseIf oppDeckCards.Count = OppDrawNum Then
                    For i = 1 To OppDrawNum
                        oppHandCards.Add(oppDeckCards.Item(1))
                        oppDeckCards.Remove(1)
                    Next
                    If oppPowerP.Count > 0 Then
                        UpdateStatus(OUID + "'s deck is out of cards. Waiting for new deck...")
                        OppPowerPack.Image = Nothing
                        OppPowerPack.Visible = False
                        oppPowerP.Clear()
                        If oppInPP = False Then
                            UpdateStatus(OUID + " is now drawing from powerpack.")
                            oppInPP = True
                        End If
                        If Host = True Then
                            hSendCommand("sendppdeck")
                        Else
                            cSendCommand("sendppdeck")
                        End If
                    Else
                        MsgBox(OUID + " has no more cards to draw from", MsgBoxStyle.Critical, "")
                    End If

                ElseIf oppDeckCards.Count < OppDrawNum Then
                    UpdateStatus(OUID + "'s deck is out of cards. Waiting for new deck...")
                    If oppInPP = False Then
                        UpdateStatus(OUID + " is now drawing from powerpack.")
                        oppInPP = True
                    End If
                    If (oppDeckCards.Count + oppPowerP.Count) >= OppDrawNum Then
                        remainingDraws = OppDrawNum
                        If Host = True Then
                            hSendCommand("sendppdeck")
                        Else
                            cSendCommand("sendppdeck")
                        End If
                    ElseIf (oppDeckCards.Count + oppPowerP.Count) > 0 Then
                        remainingDraws = (oppDeckCards.Count + oppPowerP.Count)
                        If Host = True Then
                            hSendCommand("sendppdeck")
                        Else
                            cSendCommand("sendppdeck")
                        End If
                    Else
                        MsgBox(OUID + " has no more cards to draw from", MsgBoxStyle.Critical, "")
                    End If
                    OppPowerPack.Image = Nothing
                    OppPowerPack.Visible = False
                    oppPowerP.Clear()
                End If

            ElseIf cmd.command = "sendppdeck" Then
                SendDeck(myDeckCards)

                If handCards.Count = 0 Then
                    StifleDraw = True
                    If myDeckCards.Count >= DrawNum Then
                        For i = 1 To DrawNum
                            DrawCard()
                        Next
                    Else
                        For i = 1 To (myDeckCards.Count + powerP.Count)
                            DrawCard()
                        Next
                    End If
                    StifleDraw = False
                End If

            ElseIf cmd.command = "done" Then
                If Phase.Text = "BATTLE" And bPhase.Enabled = False Then
                    Dim a As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
                    Dim s As System.IO.Stream = a.GetManifestResourceStream("OverPower.MyTurn.wav")
                    Dim player As SoundPlayer = New SoundPlayer(s)
                    player.Play()

                    UpdateStatus("It is now your turn.")
                    Pass = False
                    bPhase.Enabled = True
                    bConcede.Enabled = True
                    bPass.Enabled = True
                    bPhase.Font = New Font(bPhase.Font, FontStyle.Bold)
                    bConcede.Font = bPhase.Font
                    bPass.Font = bPhase.Font
                    Exit Sub
                End If

                If done = False Then
                    Dim a As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
                    Dim s As System.IO.Stream = a.GetManifestResourceStream("OverPower.Message.wav")
                    Dim player As SoundPlayer = New SoundPlayer(s)
                    player.Play()

                    If Phase.Text = "DISCARD" Then
                        UpdateStatus(OUID + " is finished discarding.")
                    ElseIf Phase.Text = "PLACING" Then
                        UpdateStatus(OUID + " is finished placing.")
                    ElseIf Phase.Text = "VENTURE" Then
                        Dim count As Integer = (oppVCompletedCards.Count + oppVReserveCards.Count)
                        If count = 0 Then
                            'do nothing
                        ElseIf count = 1 Then
                            UpdateStatus(OUID + " is finished venturing. " + OUID + " has ventured " + count.ToString + " mission.")
                        Else
                            UpdateStatus(OUID + " is finished venturing. " + OUID + " has ventured " + count.ToString + " missions.")
                        End If
                    ElseIf Phase.Text = "MOVE MISSIONS" Then
                        UpdateStatus(OUID + " is done moving missions to correct piles.")
                    End If
                    done = True
                Else
                    Dim a As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
                    Dim s As System.IO.Stream = a.GetManifestResourceStream("OverPower.NewPhase.wav")
                    Dim player As SoundPlayer = New SoundPlayer(s)
                    player.Play()

                    bPhase.Enabled = True
                    bPhase.Font = New Font(bPhase.Font, FontStyle.Bold)
                    If Phase.Text = "DISCARD" Then
                        If meFirst = True Then
                            UpdateStatus("You are now in the " + nextPhase() + " Phase. You should place first.")
                        Else
                            UpdateStatus("You are now in the " + nextPhase() + " Phase. " + OUID + " should place first.")
                        End If
                        Phase.Text = "PLACING"
                    ElseIf Phase.Text = "PLACING" Then
                        If meFirst = True Then
                            UpdateStatus("You are now in the " + nextPhase() + " Phase. You should venture first.")
                        Else
                            UpdateStatus("You are now in the " + nextPhase() + " Phase. " + OUID + " should venture first.")
                        End If
                        Phase.Text = "VENTURE"
                    ElseIf Phase.Text = "VENTURE" Then
                        Dim count As Integer = (oppVCompletedCards.Count + oppVReserveCards.Count)
                        If count = 0 Then
                            'do nothing
                        ElseIf count = 1 Then
                            UpdateStatus(OUID + " has ventured " + count.ToString + " mission.")
                        Else
                            UpdateStatus(OUID + " has ventured " + count.ToString + " missions.")
                        End If
                        If meFirst = True Then
                            UpdateStatus("You are now in the " + nextPhase() + " Phase. You attack first.")
                            bPhase.Text = "End Turn"
                            bConcede.Visible = True
                            bPass.Visible = True
                            bPhase.Enabled = True
                            bConcede.Enabled = True
                            bPass.Enabled = True
                            bPhase.Font = New Font(bPhase.Font, FontStyle.Bold)
                            bConcede.Font = bPhase.Font
                            bPass.Font = bPhase.Font
                        Else
                            UpdateStatus("You are now in the " + nextPhase() + " Phase. " + OUID + " attacks first.")
                            bPhase.Text = "End Turn"
                            bConcede.Visible = True
                            bPass.Visible = True
                            bPhase.Enabled = False
                            bConcede.Enabled = True
                            bPass.Enabled = False
                            bPhase.Font = New Font(bPhase.Font, FontStyle.Regular)
                            bConcede.Font = New Font(bPhase.Font, FontStyle.Bold)
                            bPass.Font = bPhase.Font
                        End If
                        Phase.Text = "BATTLE"
                    ElseIf Phase.Text = "MOVE MISSIONS" Then
                        DiscardHand()
                    End If
                    done = False
                    BGclick()
                End If

            ElseIf cmd.command = "vfromreserve" Then
                oppReserveCards(oppReserveCards.Count).location = New Point(OppVentureR.Left - (oppVReserveCards.Count * (oppReserveCards(oppReserveCards.Count).width / 3)), OppVentureR.Top)
                oppVReserveCards.Add(oppReserveCards(oppReserveCards.Count))
                oppVReserveCards(oppVReserveCards.Count).pile = "OppVentureR"
                oppReserveCards.Remove(oppReserveCards.Count)
                oppVReserveCards(oppVReserveCards.Count).bringtofront()

            ElseIf cmd.command = "vfromcompleted" Then
                oppCompletedCards(oppCompletedCards.Count).location = New Point(OppVentureC.Left - (oppVCompletedCards.Count * (oppCompletedCards(oppCompletedCards.Count).width / 3)), OppVentureC.Top)
                oppVCompletedCards.Add(oppCompletedCards(oppCompletedCards.Count))
                oppVCompletedCards(oppVCompletedCards.Count).pile = "OppVentureC"
                oppCompletedCards.Remove(oppCompletedCards.Count)
                oppVCompletedCards(oppVCompletedCards.Count).bringtofront()

            ElseIf cmd.command = "vrtor" Then
                oppVReserveCards(oppVReserveCards.Count).location = OppReserve.Location
                oppReserveCards.Add(oppVReserveCards(oppVReserveCards.Count))
                oppReserveCards(oppReserveCards.Count).pile = "OppReserve"
                oppVReserveCards.Remove(oppVReserveCards.Count)
                oppReserveCards(oppReserveCards.Count).bringtofront()

            ElseIf cmd.command = "vctoc" Then
                oppVCompletedCards(oppVCompletedCards.Count).location = OppCompleted.Location
                oppCompletedCards.Add(oppVCompletedCards(oppVCompletedCards.Count))
                oppCompletedCards(oppCompletedCards.Count).pile = "OppCompleted"
                oppVCompletedCards.Remove(oppVCompletedCards.Count)
                oppCompletedCards(oppCompletedCards.Count).bringtofront()

            ElseIf cmd.command = "vctor" Then
                oppVCompletedCards(oppVCompletedCards.Count).location = OppReserve.Location
                oppReserveCards.Add(oppVCompletedCards(oppVCompletedCards.Count))
                oppReserveCards(oppReserveCards.Count).pile = "OppReserve"
                oppVCompletedCards.Remove(oppVCompletedCards.Count)
                oppReserveCards(oppReserveCards.Count).bringtofront()

            ElseIf cmd.command = "vrtod" Then
                oppVReserveCards(oppVReserveCards.Count).location = OppDefeated.Location
                oppDefeatedCards.Add(oppVReserveCards(oppVReserveCards.Count))
                oppDefeatedCards(oppDefeatedCards.Count).pile = "OppDefeated"
                oppVReserveCards.Remove(oppVReserveCards.Count)
                oppDefeatedCards(oppDefeatedCards.Count).bringtofront()
                oppDefeatedCards(oppDefeatedCards.Count).image = oppDefeatedCards(oppDefeatedCards.Count).imageBack

            ElseIf cmd.command = "vrtoc" Then
                oppVReserveCards(oppVReserveCards.Count).location = OppCompleted.Location
                oppCompletedCards.Add(oppVReserveCards(oppVReserveCards.Count))
                oppCompletedCards(oppCompletedCards.Count).pile = "OppCompleted"
                oppVReserveCards.Remove(oppVReserveCards.Count)
                oppCompletedCards(oppCompletedCards.Count).bringtofront()

            ElseIf cmd.command = "ctor" Then
                oppCompletedCards(oppCompletedCards.Count).location = OppReserve.Location
                oppReserveCards.Add(oppCompletedCards(oppCompletedCards.Count))
                oppReserveCards(oppReserveCards.Count).pile = "OppReserve"
                oppCompletedCards.Remove(oppCompletedCards.Count)
                oppReserveCards(oppReserveCards.Count).bringtofront()

            ElseIf cmd.command = "dtor" Then
                oppDefeatedCards(oppDefeatedCards.Count).location = OppReserve.Location
                oppReserveCards.Add(oppDefeatedCards(oppDefeatedCards.Count))
                oppReserveCards(oppReserveCards.Count).pile = "OppReserve"
                oppDefeatedCards.Remove(oppDefeatedCards.Count)
                oppReserveCards(oppReserveCards.Count).bringtofront()
                oppReserveCards(oppReserveCards.Count).image = oppReserveCards(oppReserveCards.Count).imageFront

            ElseIf cmd.command = "dtoc" Then
                oppDefeatedCards(oppDefeatedCards.Count).location = OppCompleted.Location
                oppCompletedCards.Add(oppDefeatedCards(oppDefeatedCards.Count))
                oppCompletedCards(oppCompletedCards.Count).pile = "OppCompleted"
                oppDefeatedCards.Remove(oppDefeatedCards.Count)
                oppCompletedCards(oppCompletedCards.Count).bringtofront()
                oppCompletedCards(oppCompletedCards.Count).image = oppCompletedCards(oppCompletedCards.Count).imageFront

            ElseIf cmd.command = "pass" Then
                If Pass = True Then
                    UpdateStatus(OUID + " has also passed. Assess the battle.")
                    bPhase.Enabled = False
                    bConcede.Visible = False
                    bPass.Visible = False
                    frmVenture.ShowDialog()
                Else
                    Dim a As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
                    Dim s As System.IO.Stream = a.GetManifestResourceStream("OverPower.MyTurn.wav")
                    Dim player As SoundPlayer = New SoundPlayer(s)
                    player.Play()

                    UpdateStatus(OUID + " has passed. It is now your turn.")
                    Pass = True
                    bPhase.Enabled = True
                    bConcede.Enabled = True
                    bPass.Enabled = True
                    bPhase.Font = New Font(bPhase.Font, FontStyle.Bold)
                    bConcede.Font = bPhase.Font
                    bPass.Font = bPhase.Font
                End If

            ElseIf cmd.command = "showventurebox" Then
                bPhase.Enabled = False
                bConcede.Visible = False
                bPass.Visible = False
                Pass = False
                MsgBox("You have defeated all of " + OUID + "'s characters!", MsgBoxStyle.Exclamation, "")
                frmVenture.ShowDialog()

            ElseIf cmd.command = "concedeno" Then
                Dim a As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
                Dim s As System.IO.Stream = a.GetManifestResourceStream("OverPower.Message.wav")
                Dim player As SoundPlayer = New SoundPlayer(s)
                player.Play()

                UpdateStatus(OUID + " will not let you concede at this moment.")
                bPhase.Enabled = False
                bPhase.Font = New Font(bPhase.Font, FontStyle.Regular)
                bPass.Enabled = False
                bConcede.Enabled = False
                bPass.Font = bPhase.Font
                bConcede.Font = bPhase.Font

            ElseIf cmd.command = "concedeyes" Then
                Dim a As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
                Dim s As System.IO.Stream = a.GetManifestResourceStream("OverPower.LostVenture.wav")
                Dim player As SoundPlayer = New SoundPlayer(s)
                player.Play()

                Phase.Text = "MOVE MISSIONS"
                bPhase.Enabled = True
                bPhase.Text = "Done"
                bPhase.Font = New Font(bPhase.Font, FontStyle.Bold)
                bPass.Visible = False
                bConcede.Visible = False
                meFirst = False
                Pass = False

                MsgBox(OUID + " accepts your concession. Move your missions to the correct piles.", MsgBoxStyle.Information, "You have retreated!")

            ElseIf cmd.command = "concedeyesno" Then
                Phase.Text = "MOVE MISSIONS"
                bPhase.Enabled = True
                bPhase.Text = "Done"
                bPhase.Font = New Font(bPhase.Font, FontStyle.Bold)
                bPass.Visible = False
                bConcede.Visible = False
                meFirst = False
                Pass = False

                Dim a As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
                Dim s As System.IO.Stream = a.GetManifestResourceStream("OverPower.LostVenture.wav")
                Dim player As SoundPlayer = New SoundPlayer(s)
                player.Play()

                MsgBox("You have conceded. Move your missions to the correct piles.", MsgBoxStyle.Information, "You have retreated!")

            ElseIf cmd.command = "concede" Then
                If bConcede.Enabled = True Then
                    Dim a As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
                    Dim s As System.IO.Stream = a.GetManifestResourceStream("OverPower.WinVenture.wav")
                    Dim player As SoundPlayer = New SoundPlayer(s)
                    player.Play()

                    MsgBox(OUID + " conceded and you won the battle! Move your missions to the correct piles.", MsgBoxStyle.Exclamation, "You won the battle!")
                    If Host = True Then
                        hSendCommand("concedeyesno")
                    Else
                        cSendCommand("concedeyesno")
                    End If
                    Phase.Text = "MOVE MISSIONS"
                    bPhase.Enabled = True
                    bPhase.Text = "Done"
                    bPhase.Font = New Font(bPhase.Font, FontStyle.Bold)
                    bConcede.Visible = False
                    bPass.Visible = False
                    meFirst = True
                Else
                    frmConcede.TextBox1.Text = OUID + " wants to concede. What shall you do?"
                    frmConcede.ShowDialog()
                End If

            ElseIf cmd.command = "clear" Then
                oppDeadP.Clear()
                oppPowerP.Clear()
                oppDChars.Clear()
                OppDeadPile.Image = Nothing
                OppPowerPack.Image = Nothing
                OppDefeatedChars.Image = PowerPack.Image
                oppDefeatedCards.Clear()
                oppCompletedCards.Clear()
                oppVReserveCards.Clear()
                oppVCompletedCards.Clear()
                Event2.Image = Nothing
                Event2.Visible = False

            ElseIf cmd.command = "shuffledraw" Then
                Dim d As New DeckCards
                myDeckCards = d.ShuffleCards(myDeckCards)
                SendDeck(myDeckCards)

            ElseIf cmd.command = "newgame?" Then
                Dim r = MsgBox(OUID + " wishes to play a new game. Do you want to?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Play new game?")
                If r = vbYes Then
                    If Host = True Then
                        hSendCommand("yesnewgame")
                    Else
                        cSendCommand("yesnewgame")
                    End If
                    inGame = False
                    deckReceived = False
                    deckLoaded = False
                    LoadDeckToolStripMenuItem.Enabled = True
                    LoadDeckToolStripMenuItem.PerformClick()
                Else
                    If Host = True Then
                        hSendCommand("nogame")
                    Else
                        cSendCommand("nogame")
                    End If
                End If

            ElseIf cmd.command = "yesnewgame" Then
                inGame = False
                deckReceived = False
                deckLoaded = False
                LoadDeckToolStripMenuItem.Enabled = True
                LoadDeckToolStripMenuItem.PerformClick()

            ElseIf cmd.command = "rematch?" Then
                Dim r = MsgBox(OUID + " wishes to play a rematch game. Do you want to?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Play rematch?")
                If r = vbYes Then
                    If Host = True Then
                        hSendCommand("yesrematch")
                    Else
                        cSendCommand("yesrematch")
                    End If
                Else
                    If Host = True Then
                        hSendCommand("nogame")
                    Else
                        cSendCommand("nogame")
                    End If
                End If

            ElseIf cmd.command = "yesrematch" Then
                inGame = False
                deckReceived = False
                If deckFile IsNot Nothing Then
                    Dim newDeck As New DeckCards

                    ClearAll()

                    charCards = newDeck.LoadTableCards(deckFile)
                    myDeckCards = newDeck.LoadDeck(deckFile)
                    myBsDeck = newDeck.LoadBSdeck(deckFile)
                    Dim mID As Integer = newDeck.LoadMissionCards(deckFile)

                    Character1.Parse(charCards(1))
                    Character2.Parse(charCards(2))
                    Character3.Parse(charCards(3))
                    Character4.Parse(charCards(4))
                    Try
                        Battlesite.Parse(charCards("Battlesite"))
                    Catch
                    End Try
                    Try
                        Homebase.Parse(charCards("Homebase"))
                    Catch
                    End Try
                    For i = 1 To 7
                        missionCards(i).Parse(mID, i)
                    Next

                    If Homebase.locName = "ONSLAUGHT'S CITADEL" Then
                        DrawNum = 7
                    End If

                    SendAllDeckCards()
                Else
                    MsgBox("Cannot retrieve the deck file. Please reload it.")
                    LoadDeckToolStripMenuItem.Enabled = True
                    LoadDeckToolStripMenuItem.PerformClick()
                End If

            ElseIf cmd.command = "nogame" Then
                MsgBox(OUID + " is done playing for now.", MsgBoxStyle.Information)

            ElseIf cmd.command = "win" Then
                Dim a As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
                Dim s As System.IO.Stream = a.GetManifestResourceStream("OverPower.LostGame.wav")
                Dim player As SoundPlayer = New SoundPlayer(s)
                player.Play()
                MsgBox(OUID + " has completed all their missions!", MsgBoxStyle.Exclamation)

            ElseIf cmd.command = "youfirst" Then
                meFirst = True
                frmWGF.Close()

            ElseIf cmd.command = "oppfirst" Then
                meFirst = False
                frmWGF.Close()

            ElseIf cmd.command = "acceptv" Then
                If frmVenture.doneV = True Then
                    frmVenture.Close()
                Else
                    frmVenture.doneV = True
                    frmVenture.Text = OUID + " has accepted your total"
                    frmVenture.bAcceptV.Enabled = True
                    frmVenture.bSend.Enabled = True
                    frmVenture.bSend.Font = New Font(frmVenture.bSend.Font, FontStyle.Bold)
                    frmVenture.bAcceptV.Font = frmVenture.bSend.Font
                End If

            ElseIf cmd.command = "whogoesfirst" Then
                Dim mb = MsgBox(OUID + " will now draw cards to see who goes first", MsgBoxStyle.Information Or MsgBoxStyle.ApplicationModal Or MsgBoxStyle.OkOnly, "")
                frmWGF.MeFirst.Text = OUID
                frmWGF.OppFirst.Text = UID
                frmWGF.MeFirst.Enabled = False
                frmWGF.OppFirst.Enabled = False
                frmWGF.Button1.Visible = False
                frmWGF.Button2.Visible = False
                frmWGF.Button3.Visible = False
                frmWGF.ShowDialog()

            ElseIf cmd.command = "doneloadingdeck" Then
                oppDoneLoadingDeck = True
                UpdateStatus(OUID + " is finished loading your deck.")

            ElseIf cmd.command = "doneshowingdiscards" Then
                UpdateStatus(OUID + " is finished viewing your discards.")
                bPhase.Font = New Font(bPhase.Font, FontStyle.Bold)
                bPhase.Enabled = True
                DrawCardToolStripMenuItem.Enabled = True
                ShuffleDeckToolStripMenuItem.Enabled = True
                If frmShowDiscards.Visible = False Then
                    StifleDraw = True
                    DrawHand()
                    UpdateStatus("The next battle has begun! You are now in the Discard Phase. If you have an event, play it now.")
                End If

            ElseIf cmd.command = "wgfopen" Then
                If frmWGF.Visible = True Then
                    Dim a As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
                    Dim s As System.IO.Stream = a.GetManifestResourceStream("OverPower.Message.wav")
                    Dim player As SoundPlayer = New SoundPlayer(s)
                    player.Play()
                End If

                oppWGFopen = True
                UpdateStatus(OUID + " now has the who goes first box open.")

            ElseIf cmd.command = "showhand?" Then
                Dim rst = MsgBox(OUID + " would like to view your hand. Is this okay?", MsgBoxStyle.ApplicationModal Or MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "")
                If rst = vbYes Then
                    If Host = True Then
                        hSendCommand("yesshowhand")
                    Else
                        cSendCommand("yesshowhand")
                    End If
                Else
                    If Host = True Then
                        hSendCommand("noshow")
                    Else
                        cSendCommand("noshow")
                    End If
                End If

            ElseIf cmd.command = "yesshowhand" Then
                UpdateStatus(OUID + " said okay and is showing you " + oppGender + " hand.")
                frmShowHand.sz = New Size(Homebase.Height, Homebase.Width)
                frmShowHand.Show()

            ElseIf cmd.command = "noshow" Then
                Dim a As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
                Dim s As System.IO.Stream = a.GetManifestResourceStream("OverPower.Message.wav")
                Dim player As SoundPlayer = New SoundPlayer(s)
                player.Play()
                UpdateStatus(OUID + " denied your request.")
            End If
        End If
    End Sub

    Private Sub SendAllDeckCards()
        If Host = True Then
            hSendCommand("clear")
        Else
            cSendCommand("clear")
        End If

        Dim deckCol As New Collection
        Dim bsCol As New Collection
        Dim cCol As New Collection
        Dim c As New Cereal
        c.hasDeck = True
        c.hasBsDeck = True
        c.hasChars = True
        c.mID = missionCards(1).id

        For i = 1 To myDeckCards.Count
            Dim cc As New CardContainer
            cc.id = myDeckCards.Item(i).id
            cc.cardType = myDeckCards.Item(i).GetType.ToString
            deckCol.Add(cc)
        Next

        For Each card In myBsDeck
            Dim cc As New CardContainer
            cc.id = card.id
            bsCol.Add(cc)
        Next

        For i = 1 To 4
            Dim cc As New CardContainer
            cc.id = charCards(i)
            cCol.Add(cc)
        Next

        Try
            Dim cc As New CardContainer
            cc.id = charCards("Battlesite")
            cCol.Add(cc, "Battlesite")
        Catch

        End Try

        Try
            Dim cc As New CardContainer
            cc.id = charCards("Homebase")
            cCol.Add(cc, "Homebase")
        Catch

        End Try

        c.deck = deckCol
        c.bsDeck = bsCol
        c.chars = cCol

        If Host = True Then
            hSendDeck(c)
        Else
            cSendDeck(c)
        End If
    End Sub

    Public Sub SendDeck(dck As Collection)
        UpdateStatus("Please wait while " + OUID + " loads your updated deck...")

        Dim d As New Cereal
        Dim dk As New Collection
        d.hasDeck = True

        For Each card In dck
            Dim cc As New CardContainer
            cc.id = card.id
            cc.cardType = card.GetType.ToString
            dk.Add(cc)
        Next

        d.deck = dk

        If Host = True Then
            hSendDeck(d)
        Else
            cSendDeck(d)
        End If

        Thread.Sleep(1000)
    End Sub
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    'file menu actions
    '
    '
    'new game
    Private Sub NewGame_Click(sender As Object, e As EventArgs) Handles NewGameToolStripMenuItem.Click
        If inGame = True Then
            Dim mb = MsgBox("Are you sure you want to end the current game?", MsgBoxStyle.Question Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.ApplicationModal Or MsgBoxStyle.YesNoCancel, "")
            If mb = vbYes Then
                UpdateStatus("Asking " + OUID + " to play a new game. Awaiting response...")
                If Host = True Then
                    hSendCommand("newgame?")
                Else
                    cSendCommand("newgame?")
                End If
            End If
        Else
            UpdateStatus("Asking " + OUID + " to play a new game. Awaiting response...")
            If Host = True Then
                hSendCommand("newgame?")
            Else
                cSendCommand("newgame?")
            End If
        End If
    End Sub
    '
    '
    'rematch
    Private Sub RematchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RematchToolStripMenuItem.Click
        If inGame = True Then
            Dim mb = MsgBox("This will end the current game." + (Chr(10)) + "Are you sure you want to start a new game with the same teams?", MsgBoxStyle.Question Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.ApplicationModal Or MsgBoxStyle.YesNoCancel, "")
            If mb = vbYes Then
                UpdateStatus("Asking " + OUID + " to play a rematch game. Awaiting response...")
                If Host = True Then
                    hSendCommand("rematch?")
                Else
                    cSendCommand("rematch?")
                End If
            End If
        Else
            UpdateStatus("Asking " + OUID + " to play a rematch game. Awaiting response...")
            If Host = True Then
                hSendCommand("rematch?")
            Else
                cSendCommand("rematch?")
            End If
        End If
    End Sub
    '
    '
    'exit
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    '
    '
    '
    '
    '
    '
    '
    '
    'edit menu actions
    '
    '
    'cut
    Private Sub Cut_Click(sender As Object, e As EventArgs) Handles Cut.Click
        TextInput.Cut()
    End Sub
    '
    '
    'copy
    Private Sub Copy_Click(sender As Object, e As EventArgs) Handles Copy.Click
        If TextOutput.ContainsFocus Then
            TextOutput.Copy()
        End If
        If TextInput.ContainsFocus Then
            TextInput.Copy()
        End If
    End Sub
    '
    '
    'paste
    Private Sub Paste_Click(sender As Object, e As EventArgs) Handles Paste.Click
        TextInput.Paste()
    End Sub
    '
    '
    '
    '
    '
    '
    '
    '
    '
    'my deck menu actions
    '
    '
    'load deck
    Private Sub LoadDeckToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadDeckToolStripMenuItem.Click
        If inGame = True Then
            Dim mb = MsgBox("This will end the current game." + (Chr(10)) + "Are you sure you want to load a different deck?", MsgBoxStyle.Question Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.ApplicationModal Or MsgBoxStyle.YesNoCancel, "")
            If mb = vbYes Then
                'continue
            Else
                Exit Sub
            End If
        End If

        'open deck selection window
        'create the load deck dialog box and the LoadDeck object
        Dim LoadDeckDialog As New OpenFileDialog
        Dim newDeck As New DeckCards

        'set up the properties of the load deck dialog box
        LoadDeckDialog.Filter = "Deck Files (*.deck)|*.deck"
        LoadDeckDialog.Title = "Select a Deck"

        'set the default location to look for decks in
        Dim defaultLocation As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        LoadDeckDialog.InitialDirectory = defaultLocation + "\OverPower Decks"

        'opens to the last place a deck was loaded from instead of default location
        LoadDeckDialog.RestoreDirectory = True

        'passes the user selected deck to the LoadDeck method and stores the cards in the associated collections when user clicks OK
        If LoadDeckDialog.ShowDialog() = DialogResult.OK Then
            frmLoading.Show()

            ClearAll()

            frmLoading.Text = "Loading file..."
            deckFile = LoadDeckDialog.FileName
            While frmLoading.SplitContainer1.SplitterDistance < 15
                frmLoading.SplitContainer1.SplitterDistance += 1
            End While
            frmLoading.Text = "Loading characters..."
            charCards = newDeck.LoadTableCards(deckFile)
            While frmLoading.SplitContainer1.SplitterDistance < 33
                frmLoading.SplitContainer1.SplitterDistance += 1
            End While

            frmLoading.Text = "Loading draw pile cards..."
            myDeckCards = newDeck.LoadDeck(deckFile)
            While frmLoading.SplitContainer1.SplitterDistance < 120
                frmLoading.SplitContainer1.SplitterDistance += 1
            End While

            frmLoading.Text = "Loading battlesite cards..."
            myBsDeck = newDeck.LoadBSdeck(deckFile)
            While frmLoading.SplitContainer1.SplitterDistance < 160
                frmLoading.SplitContainer1.SplitterDistance += 1
            End While

            frmLoading.Text = "Loading missions..."
            Dim mID As Integer = newDeck.LoadMissionCards(deckFile)

            While frmLoading.SplitContainer1.SplitterDistance < 202
                frmLoading.SplitContainer1.SplitterDistance += 1
            End While

            frmLoading.Text = "Displaying team..."
            DrawPile.Visible = True
            Character1.Parse(charCards(1))
            Character2.Parse(charCards(2))
            Character3.Parse(charCards(3))
            While frmLoading.SplitContainer1.SplitterDistance < 230
                frmLoading.SplitContainer1.SplitterDistance += 1
            End While
            Character4.Parse(charCards(4))
            Try
                Battlesite.Parse(charCards("Battlesite"))
            Catch

            End Try

            Try
                Homebase.Parse(charCards("Homebase"))
            Catch

            End Try

            While frmLoading.SplitContainer1.SplitterDistance < 260
                frmLoading.SplitContainer1.SplitterDistance += 1
            End While

            frmLoading.Text = "Displaying missions..."
            For i = 1 To 4
                missionCards(i).Parse(mID, i)
            Next
            While frmLoading.SplitContainer1.SplitterDistance < 290
                frmLoading.SplitContainer1.SplitterDistance += 1
            End While
            For i = 5 To 7
                missionCards(i).Parse(mID, i)
            Next
            While frmLoading.SplitContainer1.SplitterDistance < 310
                frmLoading.SplitContainer1.SplitterDistance += 1
            End While

            Completed.Visible = True
            Defeated.Visible = True
            Reserve.Visible = True
            DrawPile.Visible = True

            'fix loading percentage
            While frmLoading.SplitContainer1.SplitterDistance < 335
                frmLoading.SplitContainer1.SplitterDistance += 1
            End While

            frmLoading.Text = "Done loading"
            deckLoaded = True

            If Connected = True Then
                SendAllDeckCards()
            End If

            If deckReceived = False And Connected = True Then
                frmLoading.Text = "Waiting to receive a deck from " + OUID + "..."
                frmLoading.SplitContainer1.SplitterDistance = 0
            Else
                frmLoading.Close()
            End If

            If Homebase.locName = "ONSLAUGHT'S CITADEL" Then
                DrawNum = 7
            End If

            If Host = True And deckReceived = True Then
                WhoGoesFirst()
            End If

            If deckReceived = True Then
                inGame = True
                RematchToolStripMenuItem.Enabled = True
                LoadDeckToolStripMenuItem.Enabled = False
            End If
        End If
    End Sub
    '
    '
    'draw a card
    Private Sub DrawCardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DrawCardToolStripMenuItem.Click
        DrawCard()
    End Sub
    '
    '
    'shuffle deck
    Private Sub ShuffleDeckToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShuffleDeckToolStripMenuItem.Click
        myDeckCards = deck.ShuffleCards(myDeckCards)

        Dim c As New Cereal
        c.hasDeck = True
        Dim deckCol As New Collection

        For Each card In myDeckCards
            Dim cc As New CardContainer
            cc.id = card.id
            cc.cardType = card.GetType.ToString
            deckCol.Add(cc)
        Next

        c.deck = deckCol

        If Host = True Then
            hSendDeck(c)
        Else
            cSendDeck(c)
        End If
    End Sub
    '
    '
    '
    '
    'opp deck menu actions
    '
    '
    'show opponent's hand
    Private Sub ShowHandToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowHandToolStripMenuItem.Click
        UpdateStatus("Asking for permission to view " + OUID + "'s hand, please wait...")
        If Host = True Then
            hSendCommand("showhand?")
        Else
            cSendCommand("showhand?")
        End If
    End Sub
    '
    '
    '
    '
    '
    '
    'connections menu actions
    '
    '
    'show connect window
    Private Sub ConnectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConnectToolStripMenuItem.Click
        If deckLoaded = True Then
            Connect.ShowDialog()
        Else
            LoadDeckToolStripMenuItem.PerformClick()
            If deckLoaded = True Then
                ConnectToolStripMenuItem.PerformClick()
            End If
        End If
    End Sub
    '
    '
    'disconnect
    Private Sub DisconnectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisconnectToolStripMenuItem.Click
        Timer2.Stop()

        If Host = True Then
            hSendCommand("disconnect")
        Else
            cSendCommand("disconnect")
        End If

        UpdateStatus("You have been disconnected")
        setEnabled(False)
    End Sub
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    'tools menu actions
    '
    '
    'show settings window
    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Settings.ShowDialog()
    End Sub
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    'help menu stuff
    Private Sub ForumsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ForumsToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://www.beenhereandthere.com/SMF/index.php")
    End Sub

    Private Sub OverPowercaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OverPowercaToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://overpower.ca/index.php")
    End Sub

    Private Sub WikiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WikiToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://overpower.ca/wiki/Main_Page")
    End Sub

    Private Sub FacebookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacebookToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://www.facebook.com/OPonline")
    End Sub

    Private Sub TwitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TwitterToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://twitter.com/OverPower")
    End Sub

    Private Sub YouTubeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YouTubeToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://www.youtube.com/OverPowerOnline")
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub

   
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    '
    'text context menu actions
    '
    '
    'copy from output
    Private Sub TextOutputCopy_Click(sender As Object, e As EventArgs) Handles TextOutputCopy.Click
        TextOutput.Copy()
    End Sub
    '
    '
    'cut
    Private Sub TextInputCut_Click(sender As Object, e As EventArgs) Handles TextInputCut.Click
        TextInput.Cut()
    End Sub
    '
    '
    'copy from input
    Private Sub TextInputCopy_Click(sender As Object, e As EventArgs) Handles TextInputCopy.Click
        TextInput.Copy()
    End Sub
    '
    '
    'paste
    Private Sub TextInputPaste_Click(sender As Object, e As EventArgs) Handles TextInputPaste.Click
        TextInput.Paste()
    End Sub
    '
    '
    '
    '
    'character cards context menu actions
    '
    '
    'KO character
    Private Sub KOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KOToolStripMenuItem.Click
        Dim a As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
        Dim s As System.IO.Stream = a.GetManifestResourceStream("OverPower.KO.wav")
        Dim player As SoundPlayer = New SoundPlayer(s)
        player.Play()

        Dim myItem As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        Dim cms As ContextMenuStrip = CType(myItem.Owner, ContextMenuStrip)

        Dim name As String = cms.SourceControl.Name

        If name = "Character1" Then
            sender = Character1
        ElseIf name = "Character2" Then
            sender = Character2
        ElseIf name = "Character3" Then
            sender = Character3
        ElseIf name = "Character4" Then
            sender = Character4
        ElseIf name = "Battlesite" Then
            sender = Battlesite
        End If

        sender.ko = True
        sender.Refresh()

        Dim c As New Cereal
        c.ko = True
        c.charKOd = sender.name

        If Host = True Then
            hSendCard(c)
        Else
            cSendCard(c)
        End If

        If sender IsNot Battlesite Then
            NumOfKOs += 1
            If NumOfKOs = 4 Then
                bPhase.Enabled = False
                bConcede.Visible = False
                bPass.Visible = False
                Pass = False
                Thread.Sleep(300)
                If Host = True Then
                    hSendCommand("showventurebox")
                Else
                    cSendCommand("showventurebox")
                End If
                MsgBox("All of your characters have been defeated!", MsgBoxStyle.Exclamation, "")
                frmVenture.ShowDialog()
            End If
        End If

        BGclick()
    End Sub
    '
    '
    'repaint KOd characters
    Private Sub Characters_Paint(sender As Object, e As PaintEventArgs) Handles Character4.Paint, Character3.Paint, Character2.Paint, Character1.Paint, Battlesite.Paint, OppCharacter1.Paint, OppCharacter2.Paint, OppCharacter3.Paint, OppCharacter4.Paint, OppBattlesite.Paint
        If sender.KO = True Then
            Dim KOfont As New Font("Death From Above", CType(Homebase.Height * 0.7, Single), FontStyle.Regular)
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
            Dim textSize As SizeF = e.Graphics.MeasureString("KO", KOfont)
            Dim locationToDraw As New PointF
            locationToDraw.X = (sender.Width / 2) - (textSize.Width / 2) + 1
            locationToDraw.Y = (sender.Height / 2) - (textSize.Height / 2) + (sender.height / 20)
            e.Graphics.DrawString("KO", KOfont, Brushes.IndianRed, locationToDraw)
        End If
    End Sub
    '
    '
    'move character to reserve
    Private Sub ToReserveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToReserveToolStripMenuItem.Click
        Dim myItem As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        Dim cms As ContextMenuStrip = CType(myItem.Owner, ContextMenuStrip)

        Dim name As String = cms.SourceControl.Name

        If name = "Character1" Then
            sender = Character1
        ElseIf name = "Character2" Then
            sender = Character2
        ElseIf name = "Character3" Then
            sender = Character3
        ElseIf name = "Character4" Then
            sender = Character4
        End If

        If Character4.Visible = True Then
            Dim rID As Integer = Character4.ID
            Character4.Parse(sender.id)
            sender.parse(rID)
        Else
            Character4.Parse(sender.id)
            sender.visible = False
        End If
    End Sub
End Class