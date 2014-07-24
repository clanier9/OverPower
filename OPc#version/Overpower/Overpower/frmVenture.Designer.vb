<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVenture
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
        Me.components = New System.ComponentModel.Container()
        Me.myV = New System.Windows.Forms.TextBox()
        Me.oppV = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bSend = New System.Windows.Forms.Button()
        Me.bAcceptV = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'myV
        '
        Me.myV.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.myV.Location = New System.Drawing.Point(239, 17)
        Me.myV.MaxLength = 2
        Me.myV.Name = "myV"
        Me.myV.Size = New System.Drawing.Size(35, 30)
        Me.myV.TabIndex = 0
        Me.myV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'oppV
        '
        Me.oppV.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oppV.Location = New System.Drawing.Point(239, 66)
        Me.oppV.MaxLength = 2
        Me.oppV.Name = "oppV"
        Me.oppV.ReadOnly = True
        Me.oppV.Size = New System.Drawing.Size(35, 30)
        Me.oppV.TabIndex = 1
        Me.oppV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Futura Md BT", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "My Venture Total"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Futura Md BT", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Opp Venture Total"
        '
        'bSend
        '
        Me.bSend.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.bSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSend.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSend.Location = New System.Drawing.Point(53, 117)
        Me.bSend.Name = "bSend"
        Me.bSend.Size = New System.Drawing.Size(75, 26)
        Me.bSend.TabIndex = 4
        Me.bSend.Text = "SEND"
        Me.bSend.UseVisualStyleBackColor = False
        '
        'bAcceptV
        '
        Me.bAcceptV.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.bAcceptV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAcceptV.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAcceptV.Location = New System.Drawing.Point(159, 117)
        Me.bAcceptV.Name = "bAcceptV"
        Me.bAcceptV.Size = New System.Drawing.Size(75, 26)
        Me.bAcceptV.TabIndex = 5
        Me.bAcceptV.Text = "ACCEPT"
        Me.bAcceptV.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'frmVenture
        '
        Me.AcceptButton = Me.bSend
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 163)
        Me.ControlBox = False
        Me.Controls.Add(Me.bAcceptV)
        Me.Controls.Add(Me.bSend)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.oppV)
        Me.Controls.Add(Me.myV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(300, 197)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(300, 197)
        Me.Name = "frmVenture"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assess the previous battle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents myV As System.Windows.Forms.TextBox
    Friend WithEvents oppV As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bSend As System.Windows.Forms.Button
    Friend WithEvents bAcceptV As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
