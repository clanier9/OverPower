Public Class frmEndTurn

    Private Sub bEnd_Click(sender As Object, e As EventArgs) Handles bEnd.Click
        Me.Close()
        OverPowerOnline.bPhaseUpdate()
        OverPowerOnline.BGclick()
        OverPowerOnline.TextInput.Focus()
    End Sub

    Private Sub bMore_Click(sender As Object, e As EventArgs) Handles bMore.Click
        Me.Close()
    End Sub
End Class