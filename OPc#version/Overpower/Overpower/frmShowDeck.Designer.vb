<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShowDeck
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmShowDeck))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.bDP = New System.Windows.Forms.Button()
        Me.bToD = New System.Windows.Forms.Button()
        Me.bPP = New System.Windows.Forms.Button()
        Me.bRiD = New System.Windows.Forms.Button()
        Me.bBoD = New System.Windows.Forms.Button()
        Me.bH = New System.Windows.Forms.Button()
        Me.bRez = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(12, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(440, 532)
        Me.ListBox1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(533, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(262, 344)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(491, 122)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(344, 262)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(533, 390)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(262, 57)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Visible = False
        '
        'bDP
        '
        Me.bDP.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bDP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bDP.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bDP.Location = New System.Drawing.Point(533, 453)
        Me.bDP.Name = "bDP"
        Me.bDP.Size = New System.Drawing.Size(120, 28)
        Me.bDP.TabIndex = 4
        Me.bDP.Text = "Dead Pile"
        Me.bDP.UseVisualStyleBackColor = False
        '
        'bToD
        '
        Me.bToD.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bToD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bToD.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bToD.Location = New System.Drawing.Point(675, 453)
        Me.bToD.Name = "bToD"
        Me.bToD.Size = New System.Drawing.Size(120, 28)
        Me.bToD.TabIndex = 5
        Me.bToD.Text = "Top of Draw"
        Me.bToD.UseVisualStyleBackColor = False
        '
        'bPP
        '
        Me.bPP.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bPP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bPP.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bPP.Location = New System.Drawing.Point(533, 485)
        Me.bPP.Name = "bPP"
        Me.bPP.Size = New System.Drawing.Size(120, 28)
        Me.bPP.TabIndex = 6
        Me.bPP.Text = "Power Pack"
        Me.bPP.UseVisualStyleBackColor = False
        '
        'bRiD
        '
        Me.bRiD.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bRiD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bRiD.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bRiD.Location = New System.Drawing.Point(675, 485)
        Me.bRiD.Name = "bRiD"
        Me.bRiD.Size = New System.Drawing.Size(120, 28)
        Me.bRiD.TabIndex = 7
        Me.bRiD.Text = "Random in Draw"
        Me.bRiD.UseVisualStyleBackColor = False
        '
        'bBoD
        '
        Me.bBoD.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bBoD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBoD.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bBoD.Location = New System.Drawing.Point(675, 517)
        Me.bBoD.Name = "bBoD"
        Me.bBoD.Size = New System.Drawing.Size(120, 28)
        Me.bBoD.TabIndex = 8
        Me.bBoD.Text = "Bottom of Draw"
        Me.bBoD.UseVisualStyleBackColor = False
        '
        'bH
        '
        Me.bH.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bH.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bH.Location = New System.Drawing.Point(533, 517)
        Me.bH.Name = "bH"
        Me.bH.Size = New System.Drawing.Size(120, 28)
        Me.bH.TabIndex = 9
        Me.bH.Text = "Hand"
        Me.bH.UseVisualStyleBackColor = False
        '
        'bRez
        '
        Me.bRez.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bRez.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bRez.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bRez.Location = New System.Drawing.Point(491, 356)
        Me.bRez.Name = "bRez"
        Me.bRez.Size = New System.Drawing.Size(120, 28)
        Me.bRez.TabIndex = 10
        Me.bRez.Text = "Resurrect"
        Me.bRez.UseVisualStyleBackColor = False
        Me.bRez.Visible = False
        '
        'frmShowDeck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 562)
        Me.Controls.Add(Me.bRez)
        Me.Controls.Add(Me.bH)
        Me.Controls.Add(Me.bBoD)
        Me.Controls.Add(Me.bRiD)
        Me.Controls.Add(Me.bPP)
        Me.Controls.Add(Me.bToD)
        Me.Controls.Add(Me.bDP)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(895, 600)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(895, 600)
        Me.Name = "frmShowDeck"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmShowDeck"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents bDP As System.Windows.Forms.Button
    Friend WithEvents bToD As System.Windows.Forms.Button
    Friend WithEvents bPP As System.Windows.Forms.Button
    Friend WithEvents bRiD As System.Windows.Forms.Button
    Friend WithEvents bBoD As System.Windows.Forms.Button
    Friend WithEvents bH As System.Windows.Forms.Button
    Friend WithEvents bRez As System.Windows.Forms.Button
End Class
