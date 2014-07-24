Imports System.Net.Sockets
Imports System.Text
Imports System.Net

Public Class OPOServer

    Dim mcolClients As New Hashtable()
    Dim mobjListener As TcpListener
    Dim mobjThread As Threading.Thread

    Public Delegate Sub StatusInvoker(ByVal t As String)

    Private Sub OPOServer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mobjThread = New Threading.Thread(AddressOf DoListen)
        mobjThread.Start()
        UpdateStatus("Listener started")
    End Sub

    Private Delegate Sub UpdateStatusCallBack(ByVal t As String)

    Private Sub UpdateStatus(ByVal t As String)
        If lstStatus.InvokeRequired Then
            lstStatus.Invoke(New UpdateStatusCallBack(AddressOf UpdateStatus), t)
        Else
            lstStatus.Items.Add(t)
            lstStatus.SetSelected(lstStatus.Items.Count - 1, True)
        End If
    End Sub

    Private Sub DoListen()
        Try
            Dim serverInfo As IPHostEntry
            Dim ipAddress As IPAddress = ipAddress.Parse("192.168.1.161")
            serverInfo = Dns.GetHostEntry(Dns.GetHostName)
            For Each ip As IPAddress In serverInfo.AddressList
                If ip.AddressFamily.ToString = "InterNetwork" Then
                    ipAddress = ip
                End If
            Next

            mobjListener = New TcpListener(ipAddress, 1554)
            mobjListener.Start()
            Do
                Dim x As New Client(mobjListener.AcceptTcpClient)

                AddHandler x.Connected, AddressOf OnConnected
                AddHandler x.Disconnected, AddressOf OnDisconnected
                AddHandler x.LineReceived, AddressOf OnLineReceived
                mcolClients.Add(x.ID, x)

                Dim params() As Object = {"New connection"}
                Me.Invoke(New StatusInvoker(AddressOf Me.UpdateStatus), params)
            Loop Until False
        Catch
        End Try
    End Sub

    Private Sub OnConnected(ByVal sender As Client)
        UpdateStatus("Connected")
    End Sub

    Private Sub OnDisconnected(ByVal sender As Client)
        UpdateStatus("Disconnected")
        mcolClients.Remove(sender.ID)
    End Sub

    Private Sub OnLineReceived(ByVal sender As Client, ByVal Data As String)
        UpdateStatus("Line:" & Data)

        Dim objClient As Client
        Dim d As DictionaryEntry

        For Each d In mcolClients
            objClient = d.Value
            objClient.Send(Data & vbCrLf)
        Next
    End Sub

    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        mobjListener.Stop()
    End Sub

End Class
