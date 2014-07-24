Imports System.Media
Imports System.Threading

Public Class frmConcede

    Private Sub bAllow_Click(sender As Object, e As EventArgs) Handles bAllow.Click
        Me.Close()
        Thread.Sleep(100)
        OverPowerOnline.Phase.Text = "MOVE MISSIONS"
        OverPowerOnline.bPhase.Enabled = True
        OverPowerOnline.bPhase.Text = "Done"
        OverPowerOnline.bPhase.Font = New Font(OverPowerOnline.bPhase.Font, FontStyle.Bold)
        OverPowerOnline.bConcede.Visible = False
        OverPowerOnline.bPass.Visible = False
        OverPowerOnline.meFirst = True
        Thread.Sleep(100)
        If OverPowerOnline.Host = True Then
            OverPowerOnline.hSendCommand("concedeyes")
        Else
            OverPowerOnline.cSendCommand("concedeyes")
        End If
        Dim a As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
        Dim s As System.IO.Stream = a.GetManifestResourceStream("OverPower.WinVenture.wav")
        Dim player As SoundPlayer = New SoundPlayer(s)
        player.Play()
        MsgBox("You won the battle! Move your missions to the correct piles.", MsgBoxStyle.Exclamation, "You won the battle!")
    End Sub

    Private Sub bDeny_Click(sender As Object, e As EventArgs) Handles bDeny.Click
        Dim a As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
        Dim s As System.IO.Stream = a.GetManifestResourceStream("OverPower.MyTurn.wav")
        Dim player As SoundPlayer = New SoundPlayer(s)
        player.Play()
        If OverPowerOnline.Host = True Then
            OverPowerOnline.hSendCommand("concedeno")
        Else
            OverPowerOnline.cSendCommand("concedeno")
        End If
        OverPowerOnline.UpdateStatus("It is now your turn.")
        OverPowerOnline.bPhase.Enabled = True
        OverPowerOnline.bPhase.Font = New Font(OverPowerOnline.bPhase.Font, FontStyle.Bold)
        OverPowerOnline.bPass.Enabled = True
        OverPowerOnline.bConcede.Enabled = True
        OverPowerOnline.bPass.Font = OverPowerOnline.bPhase.Font
        OverPowerOnline.bConcede.Font = OverPowerOnline.bPhase.Font
        Me.Close()
    End Sub
End Class