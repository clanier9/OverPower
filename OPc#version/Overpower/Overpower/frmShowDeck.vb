Imports System.Threading

Public Class frmShowDeck
    Public cards As New Collection
    Dim card As Object
    Public opp As Boolean
    Public deck As String
    Dim index As Integer
    Dim TopCards As Collection

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex < 0 Then
            Exit Sub
        End If

        index = ListBox1.SelectedIndex + 1
        card = cards(index)

        If card.wide = True Then
            PictureBox1.Visible = False
            PictureBox2.Image = card.Image
            PictureBox2.Visible = True
            If deck = "MyDChars" And TypeOf card Is Character Then
                bRez.Location = New Point(PictureBox2.Left + 2, PictureBox2.Bottom - 2 - bRez.Height)
                bRez.Visible = True
                bRez.BringToFront()
            Else
                bRez.Visible = False
            End If
        Else
            PictureBox2.Visible = False
            PictureBox1.Image = card.Image
            PictureBox1.Visible = True
        End If
        If TypeOf card Is Aspect Or TypeOf card Is Artifact Or TypeOf card Is Special Or TypeOf card Is MissionEvent Then
            If TypeOf card Is MissionEvent Then
                TextBox1.Width = PictureBox2.Width
                TextBox1.Left = PictureBox2.Left
            Else
                TextBox1.Width = PictureBox1.Width
                TextBox1.Left = PictureBox1.Left
            End If
            TextBox1.Visible = True
            TextBox1.Text = card.effect
        Else
            TextBox1.Visible = False
        End If
    End Sub

    Private Sub frmShowDeck_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TopCards = New Collection
        bRez.Visible = False
        ListBox1.Items.Clear()
        ListBox1.BeginUpdate()
        For i = 1 To cards.Count
            ListBox1.Items.Add(cards(i).commonname)
        Next
        ListBox1.EndUpdate()

        ListBox1.SelectedIndex = 0
        index = 1
        card = cards(index)
        If card.wide = True Then
            PictureBox1.Visible = False
            PictureBox2.Image = card.Image
            PictureBox2.Visible = True
            If deck = "MyDChars" And TypeOf card Is Character Then
                bRez.Location = New Point(PictureBox2.Left + 2, PictureBox2.Bottom - 2 - bRez.Height)
                bRez.Visible = True
                bRez.BringToFront()
            Else
                bRez.Visible = False
            End If
        Else
            PictureBox2.Visible = False
            PictureBox1.Image = card.Image
            PictureBox1.Visible = True
        End If
        If TypeOf card Is Aspect Or TypeOf card Is Artifact Or TypeOf card Is Special Or TypeOf card Is MissionEvent Then
            If TypeOf card Is MissionEvent Then
                TextBox1.Width = PictureBox2.Width
                TextBox1.Left = PictureBox2.Left
            Else
                TextBox1.Width = PictureBox1.Width
                TextBox1.Left = PictureBox1.Left
            End If
            TextBox1.Visible = True
            TextBox1.Text = card.effect
        Else
            TextBox1.Visible = False
        End If

        If deck = "MyDChars" Then
            For i = 1 To cards.Count - 1
                If TypeOf cards(i) Is Character Then
                    If cards(i).rotated = False Then
                        cards(i).Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
                        cards(i).rotated = True
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub frmShowDeck_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If opp = True Then
            If OverPowerOnline.Host = True Then
                OverPowerOnline.hSendText(OverPowerOnline.UID + " is finished viewing your cards.")
            Else
                OverPowerOnline.cSendText(OverPowerOnline.UID + " is finished viewing your cards.")
            End If
        Else
            If OverPowerOnline.Host = True Then
                OverPowerOnline.hSendText(OverPowerOnline.UID + " is finished viewing " + OverPowerOnline.gender + " cards.")
            Else
                OverPowerOnline.cSendText(OverPowerOnline.UID + " is finished viewing " + OverPowerOnline.gender + " cards.")
            End If
        End If

        Thread.Sleep(300)
        If deck = "MyDraw" Then
            'if deck empty, if pp > 0
            Dim d As New DeckCards
            For Each tc In TopCards
                Dim i = 1
                For Each cd In cards
                    If tc.id = cd.id And tc.GetType.ToString = cd.GetType.ToString Then
                        cards.Remove(i)
                        Exit For
                    Else
                        i += 1
                    End If
                Next
            Next
            cards = d.ShuffleCards(cards)
            For Each tc In TopCards
                cards.Add(tc, , 1)
            Next
            OverPowerOnline.myDeckCards.Clear()
            For Each x In cards
                OverPowerOnline.myDeckCards.Add(x)
            Next
            OverPowerOnline.SendDeck(OverPowerOnline.myDeckCards)
        ElseIf deck = "OppDraw" Then
            'if deck empty, if pp > 0, sendppdeck
            If OverPowerOnline.Host = True Then
                OverPowerOnline.hSendCommand("shuffledraw")
            Else
                OverPowerOnline.cSendCommand("shuffledraw")
            End If
        ElseIf deck = "MyDP" Then
            OverPowerOnline.deadP.Clear()
            For Each x In cards
                OverPowerOnline.deadP.Add(x)
            Next
            If OverPowerOnline.deadP.Count > 0 Then
                OverPowerOnline.DeadPile.Image = OverPowerOnline.deadP(OverPowerOnline.deadP.Count).image
            Else
                OverPowerOnline.DeadPile.Image = Nothing
                OverPowerOnline.DeadPile.Visible = False
            End If
        ElseIf deck = "MyPP" Then
            OverPowerOnline.powerP.Clear()
            For Each x In cards
                OverPowerOnline.powerP.Add(x)
            Next
            If OverPowerOnline.powerP.Count > 0 Then
                OverPowerOnline.PowerPack.Image = OverPowerOnline.powerP(OverPowerOnline.powerP.Count).image
            Else
                OverPowerOnline.PowerPack.Image = Nothing
                OverPowerOnline.PowerPack.Visible = False
            End If
        ElseIf deck = "MyDChars" Then
            OverPowerOnline.dChars.Clear()
            For Each x In cards
                OverPowerOnline.dChars.Add(x)
            Next
            If OverPowerOnline.dChars.Count > 0 Then
                OverPowerOnline.DefeatedChars.Image = OverPowerOnline.dChars(OverPowerOnline.dChars.Count).image
                OverPowerOnline.DefeatedChars.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
                OverPowerOnline.rotated = False
            Else
                OverPowerOnline.DefeatedChars.Image = Nothing
                OverPowerOnline.DefeatedChars.Visible = False
            End If
        End If

        cards.Clear()
        OverPowerOnline.BGclick()
    End Sub

    Private Sub bDP_Click(sender As Object, e As EventArgs) Handles bDP.Click
        If opp = True Then
            If OverPowerOnline.OppDeadPile.Visible = False Then
                OverPowerOnline.OppDeadPile.Visible = True
            End If
            OverPowerOnline.oppDeadP.Add(card)
            OverPowerOnline.OppDeadPile.Image = card.image
        Else
            If OverPowerOnline.DeadPile.Visible = False Then
                OverPowerOnline.DeadPile.Visible = True
            End If
            OverPowerOnline.deadP.Add(card)
            OverPowerOnline.DeadPile.Image = card.image
        End If

        Dim c As New Cereal
        c.id = card.id
        c.cardType = card.GetType.ToString
        If opp = False Then
            c.toPile = "MyDP"
        Else
            c.toPile = "OppDeadP"
        End If
        c.fromPile = deck
        c.remove = True

        If OverPowerOnline.Host = True Then
            OverPowerOnline.hSendCard(c)
        Else
            OverPowerOnline.cSendCard(c)
        End If

        cards.Remove(index)
        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        If ListBox1.Items.Count = 0 Then
            Me.Close()
        ElseIf ListBox1.Items.Count < index Then
            ListBox1.SelectedIndex = index - 2
        Else
            ListBox1.SelectedIndex = index - 1
        End If
    End Sub

    Private Sub bPP_Click(sender As Object, e As EventArgs) Handles bPP.Click
        If opp = True Then
            If OverPowerOnline.OppPowerPack.Visible = False Then
                OverPowerOnline.OppPowerPack.Visible = True
            End If
            OverPowerOnline.oppPowerP.Add(card)
            OverPowerOnline.OppPowerPack.Image = card.image
        Else
            If OverPowerOnline.PowerPack.Visible = False Then
                OverPowerOnline.PowerPack.Visible = True
            End If
            OverPowerOnline.powerP.Add(card)
            OverPowerOnline.PowerPack.Image = card.image
        End If

        Dim c As New Cereal
        c.id = card.id
        c.cardType = card.GetType.ToString
        If opp = False Then
            c.toPile = "MyPP"
        Else
            c.toPile = "OppPP"
        End If
        c.fromPile = deck
        c.remove = True

        If OverPowerOnline.Host = True Then
            OverPowerOnline.hSendCard(c)
        Else
            OverPowerOnline.cSendCard(c)
        End If

        cards.Remove(index)
        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        If ListBox1.Items.Count = 0 Then
            Me.Close()
        ElseIf ListBox1.Items.Count < index Then
            ListBox1.SelectedIndex = index - 2
        Else
            ListBox1.SelectedIndex = index - 1
        End If
    End Sub

    Private Sub bH_Click(sender As Object, e As EventArgs) Handles bH.Click
        If deck = "MyDraw" And OverPowerOnline.inPP = False Then
            OverPowerOnline.addHandlers(card)
        End If

        If deck <> "MyDeck" Then
            Dim c As New Cereal
            c.id = card.id
            c.cardType = card.GetType.ToString
            c.fromPile = deck
            c.remove = True

            If OverPowerOnline.Host = True Then
                OverPowerOnline.hSendCard(c)
            Else
                OverPowerOnline.cSendCard(c)
            End If
        End If

        Thread.Sleep(500)
        OverPowerOnline.ToHand(card)
        cards.Remove(index)
        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        If ListBox1.Items.Count = 0 Then
            Me.Close()
        ElseIf ListBox1.Items.Count < index Then
            ListBox1.SelectedIndex = index - 2
        Else
            ListBox1.SelectedIndex = index - 1
        End If
    End Sub

    Private Sub bToD_Click(sender As Object, e As EventArgs) Handles bToD.Click
        If deck <> "MyDraw" Then
            Dim c As New Cereal
            c.id = card.id
            c.cardType = card.GetType.ToString
            c.toPile = "MyDraw"
            c.fromPile = deck
            c.remove = True

            If OverPowerOnline.Host = True Then
                OverPowerOnline.hSendCard(c)
            Else
                OverPowerOnline.cSendCard(c)
            End If
        End If

        If deck = "MyDraw" Then
            TopCards.Add(cards(index))
            cards.Add(cards(index), , 1)
            cards.Remove(index + 1)
        Else
            OverPowerOnline.myDeckCards.Add(cards(index), , 1)
            cards.Remove(index)
        End If

        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        If deck = "MyDraw" Then
            ListBox1.Items.Clear()
            ListBox1.BeginUpdate()
            For i = 1 To cards.Count
                ListBox1.Items.Add(cards(i).commonname)
            Next
            ListBox1.EndUpdate()
            If ListBox1.Items.Count = 0 Then
                Me.Close()
            Else
                ListBox1.SelectedIndex = 0
            End If
        Else
            If ListBox1.Items.Count = 0 Then
                Me.Close()
            ElseIf ListBox1.Items.Count < index Then
                ListBox1.SelectedIndex = index - 2
            Else
                ListBox1.SelectedIndex = index - 1
            End If
        End If
    End Sub

    Private Sub bBoD_Click(sender As Object, e As EventArgs) Handles bBoD.Click
        If deck <> "MyDraw" Then
            Dim c As New Cereal
            c.id = card.id
            c.cardType = card.GetType.ToString
            c.toPile = "MyDraw"
            c.fromPile = deck
            c.remove = True

            If OverPowerOnline.Host = True Then
                OverPowerOnline.hSendCard(c)
            Else
                OverPowerOnline.cSendCard(c)
            End If
        End If

        If deck = "MyDraw" Then
            cards.Add(cards(index))
        Else
            OverPowerOnline.myDeckCards.Add(cards(index))
        End If

        cards.Remove(index)
        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        If deck = "MyDraw" Then
            ListBox1.Items.Clear()
            ListBox1.BeginUpdate()
            For i = 1 To cards.Count
                ListBox1.Items.Add(cards(i).commonname)
            Next
            ListBox1.EndUpdate()
            If ListBox1.Items.Count = 0 Then
                Me.Close()
            Else
                ListBox1.SelectedIndex = ListBox1.Items.Count - 1
            End If
        Else
            If ListBox1.Items.Count = 0 Then
                Me.Close()
            ElseIf ListBox1.Items.Count < index Then
                ListBox1.SelectedIndex = index - 2
            Else
                ListBox1.SelectedIndex = index - 1
            End If
        End If
    End Sub

    Private Sub bRiD_Click(sender As Object, e As EventArgs) Handles bRiD.Click
        Randomize()
        Dim randomvalue = CInt(Int(((OverPowerOnline.myDeckCards.Count + 1) - 1 + 1) * Rnd() + 1))

        If deck <> "MyDraw" Then
            Dim c As New Cereal
            c.id = card.id
            c.cardType = card.GetType.ToString
            c.toPile = "MyDraw"
            c.fromPile = deck
            c.remove = True

            If OverPowerOnline.Host = True Then
                OverPowerOnline.hSendCard(c)
            Else
                OverPowerOnline.cSendCard(c)
            End If
        End If

        If randomvalue = OverPowerOnline.myDeckCards.Count + 1 Then
            OverPowerOnline.myDeckCards.Add(cards(index))
        Else
            OverPowerOnline.myDeckCards.Add(cards(index), , randomvalue)
        End If
        cards.Remove(index)

        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        If deck = "MyDraw" Then
            ListBox1.Items.Clear()
            ListBox1.BeginUpdate()
            For i = 1 To cards.Count
                ListBox1.Items.Add(cards(i).commonname)
            Next
            ListBox1.EndUpdate()
        End If
        If ListBox1.Items.Count = 0 Then
            Me.Close()
        ElseIf ListBox1.Items.Count < index Then
            ListBox1.SelectedIndex = index - 2
        Else
            ListBox1.SelectedIndex = index - 1
        End If
    End Sub

    Private Sub bRez_Click(sender As Object, e As EventArgs) Handles bRez.Click
        If OverPowerOnline.Character1.Visible = False Then
            OverPowerOnline.Character1.Parse(card.id)
        ElseIf OverPowerOnline.Character2.Visible = False Then
            OverPowerOnline.Character2.Parse(card.id)
        ElseIf OverPowerOnline.Character3.Visible = False Then
            OverPowerOnline.Character3.Parse(card.id)
        ElseIf OverPowerOnline.Character4.Visible = False Then
            OverPowerOnline.Character4.Parse(card.id)
        End If

        Dim c As New Cereal
        c.id = card.id
        c.rez = True

        If OverPowerOnline.Host = True Then
            OverPowerOnline.hSendCard(c)
        Else
            OverPowerOnline.cSendCard(c)
        End If

        cards.Remove(index)
        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        If ListBox1.Items.Count = 0 Then
            Me.Close()
        ElseIf ListBox1.Items.Count < index Then
            ListBox1.SelectedIndex = index - 2
        Else
            ListBox1.SelectedIndex = index - 1
        End If
    End Sub
End Class