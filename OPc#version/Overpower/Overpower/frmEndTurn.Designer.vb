<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEndTurn
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
        Me.bEnd = New System.Windows.Forms.Button()
        Me.bMore = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'bEnd
        '
        Me.bEnd.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bEnd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bEnd.Font = New System.Drawing.Font("Futura Md BT", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bEnd.Location = New System.Drawing.Point(12, 84)
        Me.bEnd.Name = "bEnd"
        Me.bEnd.Size = New System.Drawing.Size(121, 45)
        Me.bEnd.TabIndex = 0
        Me.bEnd.Text = "End Turn"
        Me.bEnd.UseVisualStyleBackColor = False
        '
        'bMore
        '
        Me.bMore.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bMore.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bMore.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bMore.Font = New System.Drawing.Font("Futura Md BT", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bMore.Location = New System.Drawing.Point(151, 84)
        Me.bMore.Name = "bMore"
        Me.bMore.Size = New System.Drawing.Size(121, 45)
        Me.bMore.TabIndex = 1
        Me.bMore.Text = "More Actions"
        Me.bMore.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(12, 25)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(260, 53)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "End your turn now or perform more actions?"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmEndTurn
        '
        Me.AcceptButton = Me.bEnd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.bMore
        Me.ClientSize = New System.Drawing.Size(284, 152)
        Me.ControlBox = False
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.bMore)
        Me.Controls.Add(Me.bEnd)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(300, 190)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(300, 190)
        Me.Name = "frmEndTurn"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "End Turn?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bEnd As System.Windows.Forms.Button
    Friend WithEvents bMore As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
