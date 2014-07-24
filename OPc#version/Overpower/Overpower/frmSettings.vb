Imports System
Imports System.IO
Imports System.Media
Imports System.Net
Imports System.Web

Public Class Settings
    'set path of settings.ini
    Dim path As String = Application.StartupPath + "\settings.ini"

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'if the file exists in .exe folder
        If File.Exists(path) = True Then
            Dim sr As StreamReader = File.OpenText(path)
            'loads the info to fields
            Dim line As String
            line = sr.ReadLine
            UserID.Text = line
            line = sr.ReadLine
            IP.Text = line
            line = sr.ReadLine
            Port.Text = line
            line = sr.ReadLine
            If line = "Female" Then
                RadioButton2.Checked = True
                RadioButton1.Checked = False
            End If
            sr.Close()
        Else
            'load default info and set IP
            'Dim req As HttpWebRequest = WebRequest.Create("http://automation.whatismyip.com/n09230945.asp")
            'Dim res As HttpWebResponse = req.GetResponse()
            'Dim Stream As Stream = res.GetResponseStream()
            'Dim sr As StreamReader = New StreamReader(Stream)
            'IP.Text = sr.ReadLine()
            'sr.Close()
        End If
    End Sub

    Private Sub bClose_Click(sender As Object, e As EventArgs) Handles bClose.Click
        Me.Close()
    End Sub

    Private Sub bSave_Click(sender As Object, e As EventArgs) Handles bSave.Click
        bSave.Enabled = False
        Dim sw As StreamWriter
        'if settings.ini does not exist
        If File.Exists(path) = False Then
            'creates settings.ini in .exe folder
            sw = File.CreateText(path)
        Else
            'writes over the settings.ini file
            sw = New StreamWriter(path)
        End If
        'writes settings to settings.ini
        sw.WriteLine(UserID.Text)
        sw.WriteLine(IP.Text)
        sw.WriteLine(Port.Text)
        If RadioButton1.Checked = True Then
            sw.WriteLine("Male")
            OverPowerOnline.gender = "his"
        ElseIf RadioButton2.Checked Then
            sw.WriteLine("Female")
            OverPowerOnline.gender = "her"
        End If
        sw.Close()
        OverPowerOnline.UID = UserID.Text
        bSave.Enabled = True
        Me.Close()
    End Sub

    Private Sub bGet_Click(sender As Object, e As EventArgs) Handles bGet.Click
        'gets and sets the external (internet) IP address
        'Dim req As HttpWebRequest = WebRequest.Create("http://automation.whatismyip.com/n09230945.asp")
        'Dim res As HttpWebResponse = req.GetResponse()
        'Dim Stream As Stream = res.GetResponseStream()
        'Dim sr As StreamReader = New StreamReader(Stream)
        'IP.Text = sr.ReadLine()
        'sr.Close()
        System.Diagnostics.Process.Start("http://www.lawrencegoetz.com/programs/ipinfo/")
    End Sub
End Class