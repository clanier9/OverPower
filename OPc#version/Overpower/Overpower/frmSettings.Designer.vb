<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblIP = New System.Windows.Forms.Label()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.UserID = New System.Windows.Forms.TextBox()
        Me.IP = New System.Windows.Forms.TextBox()
        Me.Port = New System.Windows.Forms.TextBox()
        Me.bSave = New System.Windows.Forms.Button()
        Me.bClose = New System.Windows.Forms.Button()
        Me.bGet = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(31, 36)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(139, 13)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "User ID (10 characters max)"
        '
        'lblIP
        '
        Me.lblIP.AutoSize = True
        Me.lblIP.Location = New System.Drawing.Point(31, 98)
        Me.lblIP.Name = "lblIP"
        Me.lblIP.Size = New System.Drawing.Size(97, 13)
        Me.lblIP.TabIndex = 1
        Me.lblIP.Text = "Hosting IP Address"
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.Location = New System.Drawing.Point(31, 157)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(26, 13)
        Me.lblPort.TabIndex = 2
        Me.lblPort.Text = "Port"
        '
        'UserID
        '
        Me.UserID.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserID.Location = New System.Drawing.Point(34, 52)
        Me.UserID.MaxLength = 10
        Me.UserID.Name = "UserID"
        Me.UserID.Size = New System.Drawing.Size(142, 23)
        Me.UserID.TabIndex = 3
        Me.UserID.Text = "Anon"
        '
        'IP
        '
        Me.IP.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IP.Location = New System.Drawing.Point(34, 114)
        Me.IP.MaxLength = 15
        Me.IP.Name = "IP"
        Me.IP.Size = New System.Drawing.Size(142, 23)
        Me.IP.TabIndex = 4
        '
        'Port
        '
        Me.Port.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Port.Location = New System.Drawing.Point(34, 173)
        Me.Port.MaxLength = 4
        Me.Port.Name = "Port"
        Me.Port.Size = New System.Drawing.Size(63, 23)
        Me.Port.TabIndex = 5
        Me.Port.Text = "1544"
        '
        'bSave
        '
        Me.bSave.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bSave.Location = New System.Drawing.Point(34, 219)
        Me.bSave.Name = "bSave"
        Me.bSave.Size = New System.Drawing.Size(63, 23)
        Me.bSave.TabIndex = 6
        Me.bSave.Text = "Save"
        Me.bSave.UseVisualStyleBackColor = False
        '
        'bClose
        '
        Me.bClose.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bClose.Location = New System.Drawing.Point(34, 262)
        Me.bClose.Name = "bClose"
        Me.bClose.Size = New System.Drawing.Size(63, 23)
        Me.bClose.TabIndex = 7
        Me.bClose.Text = "Close"
        Me.bClose.UseVisualStyleBackColor = False
        '
        'bGet
        '
        Me.bGet.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bGet.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bGet.Location = New System.Drawing.Point(182, 114)
        Me.bGet.Name = "bGet"
        Me.bGet.Size = New System.Drawing.Size(41, 23)
        Me.bGet.TabIndex = 8
        Me.bGet.Text = "Get"
        Me.bGet.UseVisualStyleBackColor = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(182, 36)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(48, 17)
        Me.RadioButton1.TabIndex = 11
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Male"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(182, 59)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(59, 17)
        Me.RadioButton2.TabIndex = 12
        Me.RadioButton2.Text = "Female"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 309)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.bGet)
        Me.Controls.Add(Me.bClose)
        Me.Controls.Add(Me.bSave)
        Me.Controls.Add(Me.Port)
        Me.Controls.Add(Me.IP)
        Me.Controls.Add(Me.UserID)
        Me.Controls.Add(Me.lblPort)
        Me.Controls.Add(Me.lblIP)
        Me.Controls.Add(Me.lblID)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(300, 347)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(300, 347)
        Me.Name = "Settings"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblIP As System.Windows.Forms.Label
    Friend WithEvents lblPort As System.Windows.Forms.Label
    Friend WithEvents UserID As System.Windows.Forms.TextBox
    Friend WithEvents IP As System.Windows.Forms.TextBox
    Friend WithEvents Port As System.Windows.Forms.TextBox
    Friend WithEvents bSave As System.Windows.Forms.Button
    Friend WithEvents bClose As System.Windows.Forms.Button
    Friend WithEvents bGet As System.Windows.Forms.Button
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
End Class
