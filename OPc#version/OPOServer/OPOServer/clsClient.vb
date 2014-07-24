Imports System.Net.Sockets
Imports System.Text

Public Class Client

    Public Event Connected(ByVal sender As Client)
    Public Event Disconnected(ByVal sender As Client)
    Public Event LineReceived(ByVal sender As Client, ByVal Data As String)

    Dim gID As Guid = Guid.NewGuid
    Dim mobjClient As TcpClient
    Dim arData(1024) As Byte
    Dim mobjText As New StringBuilder

    Public ReadOnly Property ID() As String
        Get
            Return gID.ToString
        End Get
    End Property

    Public Sub New(ByVal client As TcpClient)
        mobjClient = client
        RaiseEvent Connected(Me)
        mobjClient.GetStream.BeginRead(arData, 0, 1024, AddressOf DoReceive, Nothing)
    End Sub

    Private Sub DoReceive(ByVal ar As IAsyncResult)
        Dim intCount As Integer

        Try
            SyncLock mobjClient.GetStream
                intCount = mobjClient.GetStream.EndRead(ar)
            End SyncLock
            If intCount < 1 Then
                RaiseEvent Disconnected(Me)
                Exit Sub
            End If

            BuildString(arData, 0, intCount)

            SyncLock mobjClient.GetStream
                mobjClient.GetStream.BeginRead(arData, 0, 1024, AddressOf DoReceive, Nothing)
            End SyncLock
        Catch e As Exception
            RaiseEvent Disconnected(Me)
        End Try
    End Sub

    Private Sub BuildString(ByVal Bytes() As Byte, _
      ByVal offset As Integer, ByVal count As Integer)
        Dim intIndex As Integer

        For intIndex = offset To offset + count - 1
            If Bytes(intIndex) = 13 Then
                RaiseEvent LineReceived(Me, mobjText.ToString)
                mobjText = New StringBuilder()
            Else
                mobjText.Append(ChrW(Bytes(intIndex)))
            End If
        Next
    End Sub

    Public Sub Send(ByVal Data As String)
        SyncLock mobjClient.GetStream
            Dim w As New IO.StreamWriter(mobjClient.GetStream)
            w.Write(Data)
            w.Flush()
        End SyncLock
    End Sub

End Class
