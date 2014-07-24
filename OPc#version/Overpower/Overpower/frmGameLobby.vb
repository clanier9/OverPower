Imports System.Net.Sockets
Imports System.Text

Public Class GameLobby
    Dim connected As Boolean = False
    Public mobjClient As TcpClient
    Dim arData(1024) As Byte
    Dim tcpText As New StringBuilder

    Public Delegate Sub DisplayInvoker(ByVal t As String)

    Private Sub frmGameRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "CONNECT" Then
            Try
                'need some form of providing "connecting to server..." feedback to user
                'need to have it read IP from a saved setting
                mobjClient = New TcpClient("108.207.250.96", 1554)
                'need to make these next 2 steps happen only when successfully connected
                ToolStripStatusLabel1.Text = "Connected"
                Button1.Text = "NEW GAME"
                mobjClient.GetStream.BeginRead(arData, 0, 1024, AddressOf DoRead, Nothing)
            Catch
                'need a retry or cancel message box here
            End Try
        ElseIf Button1.Text = "NEW GAME" Then
            'opens a new game form
        End If
    End Sub

    Private Sub SendText(ByVal Data As String)
        Dim w As New IO.StreamWriter(mobjClient.GetStream)
        w.Write(Data & vbCr)
        w.Flush()
    End Sub

    Private Sub DisplayText(ByVal t As String)
        TextOutput.AppendText(t)
    End Sub

    Private Sub MarkAsDisconnected()
        DisplayText("You are not connected to the Server")
    End Sub

    Private Sub BuildString(ByVal Bytes() As Byte, ByVal offset As Integer, ByVal count As Integer)
        Dim intIndex As Integer

        For intIndex = offset To offset + count - 1
            If Bytes(intIndex) = 10 Then
                tcpText.Append(vbLf)

                Dim params() As Object = {tcpText.ToString}
                Me.Invoke(New DisplayInvoker(AddressOf Me.DisplayText), params)

                tcpText = New StringBuilder()
            Else
                tcpText.Append(ChrW(Bytes(intIndex)))
            End If
        Next
    End Sub

    Private Sub DoRead(ByVal ar As IAsyncResult)
        Dim intCount As Integer

        Try
            intCount = mobjClient.GetStream.EndRead(ar)
            If intCount < 1 Then
                MarkAsDisconnected()
                Exit Sub
            End If

            BuildString(arData, 0, intCount)

            mobjClient.GetStream.BeginRead(arData, 0, 1024, AddressOf DoRead, Nothing)
        Catch e As Exception
            MarkAsDisconnected()
        End Try
    End Sub

    'moves text from input box to output box and scrolls down if necessary
    Private Sub Enter_Click(sender As Object, e As EventArgs) Handles SUBMIT.Click
        SendText(TextInput.Text)
        'If TextInput.Text <> "" Then
        '    If (TextOutput.Text = "") Then
        '        TextOutput.Text += TextInput.Text
        'TextInput.Clear()
        '    Else
        'TextOutput.Text += vbNewLine + TextInput.Text
        TextOutput.Focus()
        TextOutput.Select(TextOutput.TextLength, 0)
        TextOutput.ScrollToCaret()
        TextOutput.ScrollToCaret()
        TextInput.Clear()
        TextInput.Focus()
        '    End If
        'End If
    End Sub


    'edit menu actions
    Private Sub Cut_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        TextInput.Cut()
    End Sub

    Private Sub Copy_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        If TextOutput.ContainsFocus Then
            TextOutput.Copy()
        End If
        If TextInput.ContainsFocus Then
            TextInput.Copy()
        End If
    End Sub

    Private Sub Paste_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        TextInput.Paste()
    End Sub


    'context menu actions
    Private Sub TextOutputCopy_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem1.Click
        TextOutput.Copy()
    End Sub

    Private Sub TextInputCut_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem1.Click
        TextInput.Cut()
    End Sub

    Private Sub TextInputCopy_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem2.Click
        TextInput.Copy()
    End Sub

    Private Sub TextInputPaste_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem1.Click
        TextInput.Paste()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class