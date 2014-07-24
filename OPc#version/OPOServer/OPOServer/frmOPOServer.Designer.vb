<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OPOServer
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
        Me.lstStatus = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lstStatus
        '
        Me.lstStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstStatus.FormattingEnabled = True
        Me.lstStatus.Location = New System.Drawing.Point(0, 0)
        Me.lstStatus.Name = "lstStatus"
        Me.lstStatus.Size = New System.Drawing.Size(584, 762)
        Me.lstStatus.TabIndex = 0
        '
        'OPOServer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.OPOServer.My.Resources.Resources.Logo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(584, 762)
        Me.Controls.Add(Me.lstStatus)
        Me.Name = "OPOServer"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Overpower Online Server"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstStatus As System.Windows.Forms.ListBox

End Class
