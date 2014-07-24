Imports System.Threading

Public Class frmVenture
    Public doneV As Boolean
    Public doneS As Boolean
    Dim m As Integer
    Dim o As Integer

    Private Sub bSend_Click(sender As Object, e As EventArgs) Handles bSend.Click
        Dim c As New Cereal
        c.hasVenture = True
        c.Venture = myV.Text
        bSend.Enabled = False
        bSend.Font = New Font(bSend.Font, FontStyle.Regular)

        If doneS = True Then
            Me.Text = "Waiting for " + OverPowerOnline.OUID + " to accept total..."
            bAcceptV.Enabled = True
            bAcceptV.Font = New Font(bAcceptV.Font, FontStyle.Bold)
        Else
            Me.Text = "Waiting for " + OverPowerOnline.OUID + " to send total..."
            doneS = True
        End If

        If OverPowerOnline.Host = True Then
            OverPowerOnline.hSendCard(c)
        Else
            OverPowerOnline.cSendCard(c)
        End If
    End Sub

    Private Sub bAcceptV_Click(sender As Object, e As EventArgs) Handles bAcceptV.Click
        bAcceptV.Enabled = False
        bSend.Enabled = False
        bAcceptV.Font = New Font(bAcceptV.Font, FontStyle.Regular)
        bSend.Font = bAcceptV.Font

        If doneV = True Then
            Thread.Sleep(500)
            If OverPowerOnline.Host = True Then
                OverPowerOnline.hSendCommand("acceptv")
            Else
                OverPowerOnline.cSendCommand("acceptv")
            End If
            Me.Close()
        Else
            Me.Text = "Waiting for " + OverPowerOnline.OUID + " to accept total..."
            doneV = True
            myV.ReadOnly = True
            Thread.Sleep(500)
            If OverPowerOnline.Host = True Then
                OverPowerOnline.hSendCommand("acceptv")
            Else
                OverPowerOnline.cSendCommand("acceptv")
            End If
        End If
    End Sub

    Private Sub frmVenture_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        doneV = False
        doneS = False
        m = 0
        o = 0
        bAcceptV.Enabled = False
        bAcceptV.Font = New Font(bAcceptV.Font, FontStyle.Regular)
        bSend.Enabled = True
        bSend.Font = New Font(bSend.Font, FontStyle.Bold)
        Me.Text = "Waiting for you to send total..."
        OverPowerOnline.Pass = False

        myV.Text = OverPowerOnline.MyTotalV.Text
        oppV.Text = OverPowerOnline.OppTotalV.Text
    End Sub

    Private Sub frmVenture_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()

        m = CType(myV.Text, Integer)
        o = CType(oppV.Text, Integer)
        If m > o Then
            OverPowerOnline.meFirst = True
            OverPowerOnline.UpdateStatus("You won the last battle!")
            OverPowerOnline.UpdateStatus("You are now in the Move Missions Phase. Move your missions to the correct piles.")
            OverPowerOnline.Phase.Text = "MOVE MISSIONS"
        ElseIf m < o Then
            OverPowerOnline.meFirst = False
            OverPowerOnline.UpdateStatus(OverPowerOnline.OUID + " won the last battle.")
            OverPowerOnline.UpdateStatus("You are now in the Move Missions Phase. Move your missions to the correct piles.")
            OverPowerOnline.Phase.Text = "MOVE MISSIONS"
        Else
            OverPowerOnline.UpdateStatus("The last battle was a tie. Do not move your missions.")
            OverPowerOnline.Phase.Text = "DISCARD"
            OverPowerOnline.MoveToPerm()
            OverPowerOnline.DiscardHand()
        End If
        OverPowerOnline.bPhase.Enabled = True
        OverPowerOnline.bPhase.Text = "Done"
        OverPowerOnline.bPhase.Font = New Font(OverPowerOnline.bPhase.Font, FontStyle.Bold)
    End Sub

End Class