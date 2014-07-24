<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConcede
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.bDeny = New System.Windows.Forms.Button()
        Me.bAllow = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(260, 53)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Text = "Your opponent wants to concede. What shall you do?"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bDeny
        '
        Me.bDeny.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bDeny.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bDeny.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bDeny.Font = New System.Drawing.Font("Futura Md BT", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bDeny.Location = New System.Drawing.Point(151, 71)
        Me.bDeny.Name = "bDeny"
        Me.bDeny.Size = New System.Drawing.Size(121, 45)
        Me.bDeny.TabIndex = 4
        Me.bDeny.Text = "Deny"
        Me.bDeny.UseVisualStyleBackColor = False
        '
        'bAllow
        '
        Me.bAllow.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bAllow.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bAllow.Font = New System.Drawing.Font("Futura Md BT", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAllow.Location = New System.Drawing.Point(12, 71)
        Me.bAllow.Name = "bAllow"
        Me.bAllow.Size = New System.Drawing.Size(121, 45)
        Me.bAllow.TabIndex = 3
        Me.bAllow.Text = "Allow"
        Me.bAllow.UseVisualStyleBackColor = False
        '
        'frmConcede
        '
        Me.AcceptButton = Me.bAllow
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.bDeny
        Me.ClientSize = New System.Drawing.Size(284, 134)
        Me.ControlBox = False
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.bDeny)
        Me.Controls.Add(Me.bAllow)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(300, 172)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(300, 172)
        Me.Name = "frmConcede"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Allow concession?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents bDeny As System.Windows.Forms.Button
    Friend WithEvents bAllow As System.Windows.Forms.Button
End Class
