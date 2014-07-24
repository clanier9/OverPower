Imports System.Threading

Public Class frmShowDiscards
    Public sz As Size
    Dim pboxes As New Collection
    Dim count As Integer

    Private Sub frmShowDiscards_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If frmShowHand.Visible = True Then
            frmShowHand.Close()
        End If

        OverPowerOnline.DrawCardToolStripMenuItem.Enabled = False
        OverPowerOnline.ShuffleDeckToolStripMenuItem.Enabled = False
        OverPowerOnline.bPhase.Enabled = False
        OverPowerOnline.bPhase.Font = New Font(OverPowerOnline.bPhase.Font, FontStyle.Regular)

        Me.Text = OverPowerOnline.OUID + "'s hand prior to discarding"
        count = OverPowerOnline.oppHandCards.Count

        OverPowerOnline.done = False
        OverPowerOnline.Phase.Text = "DISCARD"

        If OverPowerOnline.Event1.ID > 0 Then
            OverPowerOnline.Event1.Image = Nothing
            OverPowerOnline.Event1.Visible = False
            Dim t As New MissionEvent(OverPowerOnline.Event1.ID)
            If OverPowerOnline.dChars.Count = 0 Then
                OverPowerOnline.DefeatedChars.Visible = True
            End If
            OverPowerOnline.dChars.Add(t)
            OverPowerOnline.DefeatedChars.Image = t.Image
            OverPowerOnline.DefeatedChars.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
        End If

        If OverPowerOnline.Event2.ID > 0 Then
            OverPowerOnline.Event2.Image = Nothing
            OverPowerOnline.Event2.Visible = False
            Dim x As New MissionEvent(OverPowerOnline.Event2.ID)
            If OverPowerOnline.oppDChars.Count = 0 Then
                OverPowerOnline.OppDefeatedChars.Visible = True
            End If
            OverPowerOnline.oppDChars.Add(x)
            OverPowerOnline.OppDefeatedChars.Image = x.Image
            OverPowerOnline.OppDefeatedChars.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
        End If

        For Each pbox As PictureBox In Me.Controls
            pboxes.Add(pbox)
        Next

        For i = 1 To count
            If OverPowerOnline.oppHandCards(i).wide = True Then
                pboxes(i).Image = OverPowerOnline.oppHandCards(i).image
                pboxes(i).Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
            Else
                pboxes(i).Image = OverPowerOnline.oppHandCards(i).image
            End If

            If i = 1 Then
                pboxes(i).Location = New Point(PictureBox1.Left, PictureBox1.Top)
            Else
                pboxes(i).Location = New Point(pboxes(i - 1).Right + (sz.Width / 10), pboxes(i - 1).top)
            End If
            pboxes(i).Size = sz
            pboxes(i).Visible = True
            pboxes(i).BringToFront()
        Next

        Dim w As Integer = pboxes(count).right - pboxes(1).left + 35
        Me.Size = New Size(w, sz.Height + 55)
        Me.Location = New Point(OverPowerOnline.Left + (OverPowerOnline.Width / 2) - (Me.Width / 2), OverPowerOnline.Top + (OverPowerOnline.Height / 2) - (Me.Height / 2))
    End Sub

    Private Sub frmShowDiscards_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        pboxes.Clear()
        OverPowerOnline.BigCardV.Visible = False

        If OverPowerOnline.Host = True Then
            OverPowerOnline.hSendCommand("doneshowingdiscards")
        Else
            OverPowerOnline.cSendCommand("doneshowingdiscards")
        End If

        For i = 1 To OverPowerOnline.oppHandCards.Count
            If TypeOf OverPowerOnline.oppHandCards(1) Is PowerCard Then
                If OverPowerOnline.oppPowerP.Count = 0 Then
                    OverPowerOnline.OppPowerPack.Visible = True
                End If
                OverPowerOnline.oppPowerP.Add(OverPowerOnline.oppHandCards(1))
                OverPowerOnline.OppPowerPack.Image = OverPowerOnline.oppHandCards(1).Image
            ElseIf TypeOf OverPowerOnline.oppHandCards(1) Is MissionEvent Then
                If OverPowerOnline.oppDChars.Count = 0 Then
                    OverPowerOnline.OppDefeatedChars.Visible = True
                End If
                OverPowerOnline.oppDChars.Add(OverPowerOnline.oppHandCards(1))
                OverPowerOnline.OppDefeatedChars.Image = OverPowerOnline.oppHandCards(1).Image
                OverPowerOnline.rotatedo = False
            ElseIf TypeOf OverPowerOnline.oppHandCards(1) Is Character Then
                'do nothing for now
            Else
                If OverPowerOnline.oppDeadP.Count = 0 Then
                    OverPowerOnline.OppDeadPile.Visible = True
                End If
                OverPowerOnline.oppDeadP.Add(OverPowerOnline.oppHandCards(1))
                OverPowerOnline.OppDeadPile.Image = OverPowerOnline.oppHandCards(1).Image
            End If
            OverPowerOnline.oppHandCards.Remove(1)
        Next
        OverPowerOnline.lblOHS.Text = OverPowerOnline.OUID + " Hand Size = 0"

        If OverPowerOnline.DrawCardToolStripMenuItem.Enabled = True Then
            OverPowerOnline.StifleDraw = True
            OverPowerOnline.DrawHand()
            OverPowerOnline.UpdateStatus("The next battle has begun! You are now in the Discard Phase. If you have an event, play it now.")
        End If
    End Sub

    Private Sub PictureBox_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox9.MouseClick, PictureBox8.MouseClick, PictureBox7.MouseClick, PictureBox6.MouseClick, PictureBox5.MouseClick, PictureBox4.MouseClick, PictureBox3.MouseClick, PictureBox2.MouseClick, PictureBox12.MouseClick, PictureBox11.MouseClick, PictureBox10.MouseClick, PictureBox1.MouseClick
        OverPowerOnline.BigCardH.Visible = False
        OverPowerOnline.BigCardV.Image = sender.image
        OverPowerOnline.BigCardV.Visible = True
    End Sub
End Class