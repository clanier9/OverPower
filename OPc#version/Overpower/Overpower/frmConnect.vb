Imports System.Web
Imports System.Net
Imports System.IO
Imports System.Net.Sockets
Imports System.Threading

Public Class Connect
    Private Sub Connect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim path As String = Application.StartupPath + "\settings.ini"
        'find correct port number
        If File.Exists(path) = True Then
            Dim sr As StreamReader = File.OpenText(path)
            'loads the port number
            sr.ReadLine()
            myIP.Text = sr.ReadLine()
            tbPort.Text = sr.ReadLine()
        Else
            'set IP
            Dim req As HttpWebRequest = WebRequest.Create("http://automation.whatismyip.com/n09230945.asp")
            Dim res As HttpWebResponse = req.GetResponse()
            Dim Stream As Stream = res.GetResponseStream()
            Dim sr As StreamReader = New StreamReader(Stream)
            myIP.Text = sr.ReadLine()
            sr.Close()
            'set port to 1544
            tbPort.Text = "1544"
        End If

        path = Application.StartupPath + "\IPlist.ini"
        'if the file exists in .exe folder
        If File.Exists(path) = True Then
            cbIPs.Items.Clear()
            Dim sr As StreamReader = File.OpenText(path)
            'loads the info to fields
            Dim line As String
            Dim i = 0
            While sr.Peek > 0
                line = sr.ReadLine
                cbIPs.Items.Insert(i, line)
                i += 1
            End While
            sr.Close()
        Else
            'leave blank
        End If
    End Sub

    Private Sub bCC_Click(sender As Object, e As EventArgs) Handles bCC.Click
        Me.Close()
    End Sub

    Private Sub cbIPs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbIPs.SelectedIndexChanged, cbIPs.TextUpdate
        rbConnect.Checked = True
    End Sub

    Private Sub myIP_Click(sender As Object, e As EventArgs) Handles myIP.Click
        rbHost.Checked = True
    End Sub

    Private Sub bConnect_Click(sender As Object, e As EventArgs) Handles bConnect.Click
        If rbConnect.Checked = True Then
            'stores the IP in IPlist is not already there and adds it to the combo box
            Dim CurrentIP As String = cbIPs.Text
            Dim path As String = Application.StartupPath + "\IPlist.ini"
            Dim sw As StreamWriter
            'if IPlist.ini does not exist
            If File.Exists(path) = False Then
                'creates IPlist.ini in .exe folder
                sw = File.CreateText(path)
                'writes IPs to IPlist.ini
                Dim i = 0
                While i < cbIPs.Items.Count
                    sw.WriteLine(cbIPs.Items(i))
                    i += 1
                End While
                sw.Close()
            Else
                Dim line As String
                Using reader As StreamReader = New StreamReader(path)
                    Do
                        line = reader.ReadLine
                    Loop Until line Is Nothing Or line = CurrentIP
                End Using
                If line = CurrentIP Then
                    'do nothing
                Else
                    cbIPs.Items.Insert(cbIPs.Items.Count, CurrentIP)
                    'writes the new IP to the IPlist.ini
                    Using sw2 As StreamWriter = New StreamWriter(path, True)
                        sw2.WriteLine(CurrentIP)
                        sw2.Close()
                    End Using
                End If
            End If

            'connect to the host
            Me.Close()
            Thread.Sleep(1000)
            OverPowerOnline.ConnectToHost(cbIPs.Text, Int32.Parse(tbPort.Text))

        Else
            Me.Close()
            OverPowerOnline.HostGame(myIP.Text)
        End If
    End Sub

    Private Sub bGetIP_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bGetIP.Click
        'set IP
        Dim req As HttpWebRequest = WebRequest.Create("http://automation.whatismyip.com/n09230945.asp")
        Dim res As HttpWebResponse = req.GetResponse()
        Dim Stream As Stream = res.GetResponseStream()
        Dim sr As StreamReader = New StreamReader(Stream)
        myIP.Text = sr.ReadLine()
        sr.Close()
    End Sub
End Class