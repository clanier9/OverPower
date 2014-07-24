Imports System.Net.Sockets
Imports System.Net
Imports System.Text
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Xml.Serialization
Imports System.Media

Public Class Client
    Public Event Disconnected(ByVal sender As Client)
    Public Event LineReceived(ByVal sender As Client, ByVal Data As String)
    Public Event CardReceived(ByVal card As Cereal)
    Public Event DeckReceived(ByVal d As Cereal)
    Public Event DiscardReceived(ByVal card As Cereal)
    Public Event CommandReceived(ByVal cmd As Cereal)
    Public Event Connected(ByVal id As String, ByVal sex As String)

    Dim gID As Guid = Guid.NewGuid
    Dim mobjClient As TcpClient
    Dim arData(3145728) As Byte
    Dim mobjText As New StringBuilder

    Public ReadOnly Property ID() As String
        Get
            Return gID.ToString
        End Get
    End Property

    Public Sub New(ByVal client As TcpClient)
        mobjClient = client
        'listens to the client stream
        mobjClient.GetStream.BeginRead(arData, 0, 3145728, AddressOf DoReceive, Nothing)
    End Sub

    'accepts data on host stream from client (c2)
    Private Sub DoReceive(ByVal ar As IAsyncResult)
        Dim intCount As Integer

        'Try
        'find how many byte is data
        SyncLock mobjClient.GetStream
            intCount = mobjClient.GetStream.EndRead(ar)
        End SyncLock
        'if none, we are disconnected
        If intCount < 1 Then
            RaiseEvent Disconnected(Me)
            Exit Sub
        End If

        Dim bf As New BinaryFormatter
        Dim c As New Cereal
        Dim ms As New MemoryStream(arData)

        ms.SetLength(intCount)
        c = bf.Deserialize(ms)
        ms.Close()

        mobjClient.GetStream.BeginRead(arData, 0, 3145728, AddressOf DoReceive, Nothing)

        If c.text IsNot Nothing Then
            Dim a As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
            Dim s As System.IO.Stream = a.GetManifestResourceStream("OverPower.Message.wav")
            Dim player As SoundPlayer = New SoundPlayer(s)
            player.Play()
            RaiseEvent LineReceived(Me, c.text)
        ElseIf c.OppUserID IsNot Nothing Then
            RaiseEvent Connected(c.OppUserID, c.OppGender)
        ElseIf c.command IsNot Nothing Then
            RaiseEvent CommandReceived(c)
        ElseIf c.hasDeck = True Or c.hasBsDeck = True Or c.hasHand = True Then
            RaiseEvent DeckReceived(c)
        ElseIf c.discard = True Then
            RaiseEvent DiscardReceived(c)
        Else
            RaiseEvent CardReceived(c)
        End If

        'Catch e As Exception
        'RaiseEvent Disconnected(Me)
        'End Try
    End Sub

    'sends text to the client's stream (h2)
    Public Sub SendText(ByVal Data As String)
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

    'sends a card to the client's stream (h2)
    Public Sub SendCard(ByVal c As Cereal)
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

    'sends deck(s) to the client's stream (h2)
    Public Sub SendDeck(ByVal c As Cereal)
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

    'sends a command to the client's stream (h2)
    Public Sub SendCommand(ByVal cmd As String)
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

    Public Sub SendConnect(ByVal id As String, ByVal sex As String)
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
End Class
