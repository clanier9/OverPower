Imports System.Threading

Public Class frmWGF
    Dim m As Integer
    Dim o As Integer

    Private Sub MeFirst_Click(sender As Object, e As EventArgs) Handles MeFirst.Click
        If OverPowerOnline.oppWGFopen = False Then
            MsgBox("Waiting for " + OverPowerOnline.OUID + " to have this window open." + vbNewLine + vbNewLine + "The chat window will tell you when " + OverPowerOnline.OUID + " has it open.", MsgBoxStyle.Information, "Cannot complete action right now")
            Exit Sub
        End If
        OverPowerOnline.meFirst = True
        Me.Close()
    End Sub

    Private Sub OppFirst_Click(sender As Object, e As EventArgs) Handles OppFirst.Click
        If OverPowerOnline.oppWGFopen = False Then
            MsgBox("Waiting for " + OverPowerOnline.OUID + " to have this window open." + vbNewLine + vbNewLine + "The chat window will tell you when " + OverPowerOnline.OUID + " has it open.", MsgBoxStyle.Information, "Cannot complete action right now")
            Exit Sub
        End If
        OverPowerOnline.meFirst = False
        Me.Close()
    End Sub

    Private Sub frmWGF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If OverPowerOnline.Host = True Then
            setEnabled(True)
            MeFirst.Text = OverPowerOnline.UID + " Goes First"
            OppFirst.Text = OverPowerOnline.OUID + " Goes First"
            Randomize()
            m = CInt(Int((OverPowerOnline.myDeckCards.Count - 1 + 1) * Rnd() + 1))
            o = CInt(Int((OverPowerOnline.oppDeckCards.Count - 1 + 1) * Rnd() + 1))
            Dim c As New Cereal

            If OverPowerOnline.myDeckCards(m).wide = True Then
                MyCard.Visible = False
                MyWideCard.Image = OverPowerOnline.myDeckCards(m).image
                MyWideCard.Visible = True
                c.wide1 = True
                c.Image1 = m
            Else
                MyWideCard.Visible = False
                MyCard.Image = OverPowerOnline.myDeckCards(m).image
                MyCard.Visible = True
                c.Image1 = m
            End If

            If OverPowerOnline.oppDeckCards(o).wide = True Then
                OppCard.Visible = False
                OppWideCard.Image = OverPowerOnline.oppDeckCards(o).image
                OppWideCard.Visible = True
                c.wide2 = True
                c.Image2 = o
            Else
                OppWideCard.Visible = False
                OppCard.Image = OverPowerOnline.oppDeckCards(o).image
                OppCard.Visible = True
                c.Image2 = o
            End If

            c.hasImage1 = True
            c.hasImage2 = True
            OverPowerOnline.hSendCard(c)
        Else
            OverPowerOnline.cSendCommand("wgfopen")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If OverPowerOnline.oppWGFopen = False Then
            MsgBox("Waiting for " + OverPowerOnline.OUID + " to have this window open." + vbNewLine + vbNewLine + "The chat window will tell you when " + OverPowerOnline.OUID + " has it open.", MsgBoxStyle.Information, "Cannot complete action right now")
            Exit Sub
        End If

        Randomize()
        m = CInt(Int((OverPowerOnline.myDeckCards.Count - 1 + 1) * Rnd() + 1))
        Dim c As New Cereal

        If OverPowerOnline.myDeckCards(m).wide = True Then
            MyCard.Visible = False
            MyWideCard.Image = OverPowerOnline.myDeckCards(m).image
            MyWideCard.Visible = True
            c.wide1 = True
            c.Image1 = m
        Else
            MyWideCard.Visible = False
            MyCard.Image = OverPowerOnline.myDeckCards(m).image
            MyCard.Visible = True
            c.Image1 = o
        End If

        c.hasImage1 = True
        OverPowerOnline.hSendCard(c)
        setEnabled(False)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If OverPowerOnline.oppWGFopen = False Then
            MsgBox("Waiting for " + OverPowerOnline.OUID + " to have this window open." + vbNewLine + vbNewLine + "The chat window will tell you when " + OverPowerOnline.OUID + " has it open.", MsgBoxStyle.Information, "Cannot complete action right now")
            Exit Sub
        End If

        Randomize()
        o = CInt(Int((OverPowerOnline.oppDeckCards.Count - 1 + 1) * Rnd() + 1))
        Dim c As New Cereal

        If OverPowerOnline.oppDeckCards(o).wide = True Then
            OppCard.Visible = False
            OppWideCard.Image = OverPowerOnline.oppDeckCards(o).image
            OppWideCard.Visible = True
            c.wide2 = True
            c.Image2 = o
        Else
            OppWideCard.Visible = False
            OppCard.Image = OverPowerOnline.oppDeckCards(o).image
            OppCard.Visible = True
            c.Image2 = o
        End If

        c.hasImage2 = True
        OverPowerOnline.hSendCard(c)
        setEnabled(False)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If OverPowerOnline.oppWGFopen = False Then
            MsgBox("Waiting for " + OverPowerOnline.OUID + " to have this window open." + vbNewLine + vbNewLine + "The chat window will tell you when " + OverPowerOnline.OUID + " has it open.", MsgBoxStyle.Information, "Cannot complete action right now")
            Exit Sub
        End If
        Randomize()
        m = CInt(Int((OverPowerOnline.myDeckCards.Count - 1 + 1) * Rnd() + 1))
        o = CInt(Int((OverPowerOnline.oppDeckCards.Count - 1 + 1) * Rnd() + 1))
        Dim c As New Cereal

        If OverPowerOnline.myDeckCards(m).wide = True Then
            MyCard.Visible = False
            MyWideCard.Image = OverPowerOnline.myDeckCards(m).image
            MyWideCard.Visible = True
            c.wide1 = True
            c.Image1 = m
        Else
            MyWideCard.Visible = False
            MyCard.Image = OverPowerOnline.myDeckCards(m).image
            MyCard.Visible = True
            c.Image1 = m
        End If

        If OverPowerOnline.oppDeckCards(o).wide = True Then
            OppCard.Visible = False
            OppWideCard.Image = OverPowerOnline.oppDeckCards(o).image
            OppWideCard.Visible = True
            c.wide2 = True
            c.Image2 = o
        Else
            OppWideCard.Visible = False
            OppCard.Image = OverPowerOnline.oppDeckCards(o).image
            OppCard.Visible = True
            c.Image2 = o
        End If

        c.hasImage1 = True
        c.hasImage2 = True
        OverPowerOnline.hSendCard(c)
        setEnabled(False)
    End Sub

    Private Sub frmWGF_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If OverPowerOnline.meFirst = True Then
            OverPowerOnline.UpdateStatus("You get to go first. It is now the Discard Phase. If you have an event, play it now.")
            OverPowerOnline.hSendCommand("oppfirst")
        Else
            OverPowerOnline.UpdateStatus(OverPowerOnline.OUID + " gets to go first. It is now the Discard Phase. If you have an event, play it now.")
            OverPowerOnline.hSendCommand("youfirst")
        End If
        OverPowerOnline.lblOHS.Visible = True
        OverPowerOnline.lblOHS.Text = OverPowerOnline.OUID + " Hand Size = 0"
        OverPowerOnline.bPhase.Enabled = True
        OverPowerOnline.bPhase.Font = New Font(OverPowerOnline.bPhase.Font, FontStyle.Bold)
        OverPowerOnline.ShowHandToolStripMenuItem.Enabled = True
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        OverPowerOnline.StifleDraw = True
        OverPowerOnline.DrawHand()
    End Sub

    Public Sub setEnabled(tf As Boolean)
        MeFirst.Enabled = tf
        OppFirst.Enabled = tf
        Button1.Visible = tf
        Button2.Visible = tf
        Button3.Visible = tf
    End Sub
End Class