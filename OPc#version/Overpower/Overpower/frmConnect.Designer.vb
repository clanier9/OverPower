<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Connect
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.bConnect = New System.Windows.Forms.Button()
        Me.rbHost = New System.Windows.Forms.RadioButton()
        Me.rbConnect = New System.Windows.Forms.RadioButton()
        Me.cbIPs = New System.Windows.Forms.ComboBox()
        Me.myIP = New System.Windows.Forms.TextBox()
        Me.bCC = New System.Windows.Forms.Button()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.tbPort = New System.Windows.Forms.TextBox()
        Me.bGetIP = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bConnect
        '
        Me.bConnect.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bConnect.Location = New System.Drawing.Point(34, 128)
        Me.bConnect.Name = "bConnect"
        Me.bConnect.Size = New System.Drawing.Size(63, 23)
        Me.bConnect.TabIndex = 7
        Me.bConnect.Text = "Connect"
        Me.bConnect.UseVisualStyleBackColor = False
        '
        'rbHost
        '
        Me.rbHost.AutoSize = True
        Me.rbHost.Checked = True
        Me.rbHost.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbHost.Location = New System.Drawing.Point(34, 25)
        Me.rbHost.Name = "rbHost"
        Me.rbHost.Size = New System.Drawing.Size(92, 19)
        Me.rbHost.TabIndex = 8
        Me.rbHost.TabStop = True
        Me.rbHost.Text = "Host a game"
        Me.rbHost.UseVisualStyleBackColor = True
        '
        'rbConnect
        '
        Me.rbConnect.AutoSize = True
        Me.rbConnect.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbConnect.Location = New System.Drawing.Point(34, 76)
        Me.rbConnect.Name = "rbConnect"
        Me.rbConnect.Size = New System.Drawing.Size(125, 19)
        Me.rbConnect.TabIndex = 9
        Me.rbConnect.Text = "Connect to a game"
        Me.rbConnect.UseVisualStyleBackColor = True
        '
        'cbIPs
        '
        Me.cbIPs.FormattingEnabled = True
        Me.cbIPs.Location = New System.Drawing.Point(34, 101)
        Me.cbIPs.MaxDropDownItems = 10
        Me.cbIPs.Name = "cbIPs"
        Me.cbIPs.Size = New System.Drawing.Size(157, 21)
        Me.cbIPs.TabIndex = 11
        Me.cbIPs.Text = "Select or type an IP address"
        '
        'myIP
        '
        Me.myIP.Location = New System.Drawing.Point(34, 50)
        Me.myIP.Name = "myIP"
        Me.myIP.Size = New System.Drawing.Size(157, 20)
        Me.myIP.TabIndex = 12
        '
        'bCC
        '
        Me.bCC.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bCC.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bCC.Location = New System.Drawing.Point(34, 157)
        Me.bCC.Name = "bCC"
        Me.bCC.Size = New System.Drawing.Size(63, 23)
        Me.bCC.TabIndex = 13
        Me.bCC.Text = "Cancel"
        Me.bCC.UseVisualStyleBackColor = False
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPort.Location = New System.Drawing.Point(161, 128)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(30, 15)
        Me.lblPort.TabIndex = 14
        Me.lblPort.Text = "Port"
        '
        'tbPort
        '
        Me.tbPort.Location = New System.Drawing.Point(153, 146)
        Me.tbPort.Name = "tbPort"
        Me.tbPort.Size = New System.Drawing.Size(38, 20)
        Me.tbPort.TabIndex = 15
        Me.tbPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'bGetIP
        '
        Me.bGetIP.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bGetIP.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bGetIP.Location = New System.Drawing.Point(143, 25)
        Me.bGetIP.Name = "bGetIP"
        Me.bGetIP.Size = New System.Drawing.Size(48, 23)
        Me.bGetIP.TabIndex = 16
        Me.bGetIP.Text = "Get IP"
        Me.bGetIP.UseVisualStyleBackColor = False
        '
        'Connect
        '
        Me.AcceptButton = Me.bConnect
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(225, 203)
        Me.Controls.Add(Me.bGetIP)
        Me.Controls.Add(Me.tbPort)
        Me.Controls.Add(Me.lblPort)
        Me.Controls.Add(Me.bCC)
        Me.Controls.Add(Me.myIP)
        Me.Controls.Add(Me.cbIPs)
        Me.Controls.Add(Me.rbConnect)
        Me.Controls.Add(Me.rbHost)
        Me.Controls.Add(Me.bConnect)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(241, 241)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(241, 241)
        Me.Name = "Connect"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Connect"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bConnect As System.Windows.Forms.Button
    Friend WithEvents rbHost As System.Windows.Forms.RadioButton
    Friend WithEvents rbConnect As System.Windows.Forms.RadioButton
    Friend WithEvents cbIPs As System.Windows.Forms.ComboBox
    Friend WithEvents myIP As System.Windows.Forms.TextBox
    Friend WithEvents bCC As System.Windows.Forms.Button
    Friend WithEvents lblPort As System.Windows.Forms.Label
    Friend WithEvents tbPort As System.Windows.Forms.TextBox
    Friend WithEvents bGetIP As System.Windows.Forms.Button
End Class
