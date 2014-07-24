<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWGF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWGF))
        Me.OppFirst = New System.Windows.Forms.Button()
        Me.OppCard = New System.Windows.Forms.PictureBox()
        Me.MyCard = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MeFirst = New System.Windows.Forms.Button()
        Me.MyWideCard = New System.Windows.Forms.PictureBox()
        Me.OppWideCard = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.OppCard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyCard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyWideCard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OppWideCard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OppFirst
        '
        Me.OppFirst.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.OppFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OppFirst.Font = New System.Drawing.Font("Futura Md BT", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OppFirst.Location = New System.Drawing.Point(362, 43)
        Me.OppFirst.Name = "OppFirst"
        Me.OppFirst.Size = New System.Drawing.Size(224, 35)
        Me.OppFirst.TabIndex = 13
        Me.OppFirst.Text = "Opp Goes First"
        Me.OppFirst.UseVisualStyleBackColor = False
        '
        'OppCard
        '
        Me.OppCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OppCard.Location = New System.Drawing.Point(362, 84)
        Me.OppCard.Name = "OppCard"
        Me.OppCard.Size = New System.Drawing.Size(224, 300)
        Me.OppCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.OppCard.TabIndex = 12
        Me.OppCard.TabStop = False
        Me.OppCard.Visible = False
        '
        'MyCard
        '
        Me.MyCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MyCard.Location = New System.Drawing.Point(50, 84)
        Me.MyCard.Name = "MyCard"
        Me.MyCard.Size = New System.Drawing.Size(226, 300)
        Me.MyCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MyCard.TabIndex = 11
        Me.MyCard.TabStop = False
        Me.MyCard.Visible = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(253, 415)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(132, 27)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Both Redraw"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(498, 415)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 27)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Redraw"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(50, 415)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 27)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Redraw"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MeFirst
        '
        Me.MeFirst.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.MeFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MeFirst.Font = New System.Drawing.Font("Futura Md BT", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MeFirst.Location = New System.Drawing.Point(50, 43)
        Me.MeFirst.Name = "MeFirst"
        Me.MeFirst.Size = New System.Drawing.Size(226, 35)
        Me.MeFirst.TabIndex = 15
        Me.MeFirst.Text = "I Go First"
        Me.MeFirst.UseVisualStyleBackColor = False
        '
        'MyWideCard
        '
        Me.MyWideCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MyWideCard.Location = New System.Drawing.Point(14, 117)
        Me.MyWideCard.Name = "MyWideCard"
        Me.MyWideCard.Size = New System.Drawing.Size(303, 224)
        Me.MyWideCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MyWideCard.TabIndex = 16
        Me.MyWideCard.TabStop = False
        Me.MyWideCard.Visible = False
        '
        'OppWideCard
        '
        Me.OppWideCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OppWideCard.Location = New System.Drawing.Point(324, 117)
        Me.OppWideCard.Name = "OppWideCard"
        Me.OppWideCard.Size = New System.Drawing.Size(303, 224)
        Me.OppWideCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.OppWideCard.TabIndex = 17
        Me.OppWideCard.TabStop = False
        Me.OppWideCard.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'frmWGF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(642, 466)
        Me.ControlBox = False
        Me.Controls.Add(Me.OppWideCard)
        Me.Controls.Add(Me.MyWideCard)
        Me.Controls.Add(Me.MeFirst)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.OppFirst)
        Me.Controls.Add(Me.OppCard)
        Me.Controls.Add(Me.MyCard)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(648, 472)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(648, 472)
        Me.Name = "frmWGF"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.OppCard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyCard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyWideCard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OppWideCard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OppFirst As System.Windows.Forms.Button
    Friend WithEvents OppCard As System.Windows.Forms.PictureBox
    Friend WithEvents MyCard As System.Windows.Forms.PictureBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MeFirst As System.Windows.Forms.Button
    Friend WithEvents MyWideCard As System.Windows.Forms.PictureBox
    Friend WithEvents OppWideCard As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
