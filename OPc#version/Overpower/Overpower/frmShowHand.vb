Public Class frmShowHand
    Public sz As Size
    Dim pboxes As New Collection
    Dim count As Integer

    Private Sub frmShowHand_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = OverPowerOnline.OUID + "'s hand"
        count = OverPowerOnline.oppHandCards.Count

        For Each pbox As PictureBox In Me.Controls
            pboxes.Add(pbox)
        Next

        For i = 1 To count
            If OverPowerOnline.oppHandCards(i).wide = True Then
                pboxes(i).Image = OverPowerOnline.oppHandCards(i).image
                If OverPowerOnline.oppHandCards(i).rotated = False Then
                    pboxes(i).Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
                    OverPowerOnline.oppHandCards(i).rotated = True
                End If
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

    Public Sub UpdateHand()
        count = OverPowerOnline.oppHandCards.Count
        For i = 1 To count
            pboxes(i).Image = OverPowerOnline.oppHandCards(i).image

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

    Private Sub frmShowHand_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If OverPowerOnline.Host = True Then
            OverPowerOnline.hSendText(OverPowerOnline.UID + " is finished viewing your hand.")
        Else
            OverPowerOnline.cSendText(OverPowerOnline.UID + " is finished viewing your hand.")
        End If
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
    End Sub
End Class