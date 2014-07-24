<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OverPowerOnline
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OverPowerOnline))
        Me.SUBMIT = New System.Windows.Forms.Button()
        Me.TextOutput = New System.Windows.Forms.RichTextBox()
        Me.TextOutputMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TextOutputCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextInput = New System.Windows.Forms.RichTextBox()
        Me.TextInputMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TextInputCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextInputCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextInputPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenDeckToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Undo = New System.Windows.Forms.ToolStripMenuItem()
        Me.Redo = New System.Windows.Forms.ToolStripMenuItem()
        Me.Cut = New System.Windows.Forms.ToolStripMenuItem()
        Me.Copy = New System.Windows.Forms.ToolStripMenuItem()
        Me.Paste = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawPile = New System.Windows.Forms.PictureBox()
        Me.PowerPack = New System.Windows.Forms.PictureBox()
        Me.DeadPile = New System.Windows.Forms.PictureBox()
        Me.BigCardV = New System.Windows.Forms.PictureBox()
        Me.OppPowerPack = New System.Windows.Forms.PictureBox()
        Me.OppDeadPile = New System.Windows.Forms.PictureBox()
        Me.OppDrawPile = New System.Windows.Forms.PictureBox()
        Me.CurrentPhase = New System.Windows.Forms.Label()
        Me.DefeatedChars = New System.Windows.Forms.PictureBox()
        Me.OppDefeatedChars = New System.Windows.Forms.PictureBox()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RematchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenGameToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MyDeckToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadDeckToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.DrawCardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ShuffleDeckToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpponentDeckToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowHandToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConnectionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConnectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisconnectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LinksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OverPowercaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ForumsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WikiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacebookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TwitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YouTubeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DonateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BigCardH = New System.Windows.Forms.PictureBox()
        Me.Phase = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bPhase = New System.Windows.Forms.Button()
        Me.bDiscard = New System.Windows.Forms.Button()
        Me.bPlace = New System.Windows.Forms.Button()
        Me.bPlay = New System.Windows.Forms.Button()
        Me.bD = New System.Windows.Forms.Button()
        Me.bP = New System.Windows.Forms.Button()
        Me.PlaceTextBox = New System.Windows.Forms.TextBox()
        Me.PlayTextBox = New System.Windows.Forms.TextBox()
        Me.bCancel = New System.Windows.Forms.Button()
        Me.bAccept = New System.Windows.Forms.Button()
        Me.bChallenge = New System.Windows.Forms.Button()
        Me.AttackBox = New System.Windows.Forms.TextBox()
        Me.bR = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.bAttack = New System.Windows.Forms.Button()
        Me.bHits = New System.Windows.Forms.Button()
        Me.bDefend = New System.Windows.Forms.Button()
        Me.bMin = New System.Windows.Forms.Button()
        Me.AttackPanel = New System.Windows.Forms.SplitContainer()
        Me.DefendBox = New System.Windows.Forms.TextBox()
        Me.AcceptBox = New System.Windows.Forms.TextBox()
        Me.bMinusMe = New System.Windows.Forms.Button()
        Me.bMinusOpp = New System.Windows.Forms.Button()
        Me.bPlusMe = New System.Windows.Forms.Button()
        Me.bPlusOpp = New System.Windows.Forms.Button()
        Me.MyVenture = New System.Windows.Forms.Label()
        Me.OppVenture = New System.Windows.Forms.Label()
        Me.MyTotalV = New System.Windows.Forms.Label()
        Me.OppTotalV = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.b2C = New System.Windows.Forms.Button()
        Me.b2R = New System.Windows.Forms.Button()
        Me.bShift = New System.Windows.Forms.Button()
        Me.bPlusV = New System.Windows.Forms.Button()
        Me.bMinusV = New System.Windows.Forms.Button()
        Me.b2D = New System.Windows.Forms.Button()
        Me.b2P = New System.Windows.Forms.Button()
        Me.bPass = New System.Windows.Forms.Button()
        Me.bConcede = New System.Windows.Forms.Button()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.lblOHS = New System.Windows.Forms.Label()
        Me.cbFacedown = New System.Windows.Forms.CheckBox()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.AttackToLine = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.AttackFromLine = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.CharMenu2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CharMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.KOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToReserveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.bM = New System.Windows.Forms.Button()
        Me.MoveBox = New System.Windows.Forms.TextBox()
        Me.BSlistbox = New System.Windows.Forms.ListBox()
        Me.Mission8 = New OverPower.Mission()
        Me.Mission9 = New OverPower.Mission()
        Me.Mission10 = New OverPower.Mission()
        Me.Mission11 = New OverPower.Mission()
        Me.Mission12 = New OverPower.Mission()
        Me.Mission13 = New OverPower.Mission()
        Me.Mission14 = New OverPower.Mission()
        Me.OppReserve = New OverPower.Mission()
        Me.Mission1 = New OverPower.Mission()
        Me.Mission2 = New OverPower.Mission()
        Me.Mission3 = New OverPower.Mission()
        Me.Mission4 = New OverPower.Mission()
        Me.Mission5 = New OverPower.Mission()
        Me.Mission6 = New OverPower.Mission()
        Me.Mission7 = New OverPower.Mission()
        Me.Event1 = New OverPower.MissionEvent()
        Me.Event2 = New OverPower.MissionEvent()
        Me.OppVentureR = New OverPower.Mission()
        Me.OppVentureC = New OverPower.Mission()
        Me.OppCompleted = New OverPower.Mission()
        Me.OppDefeated = New OverPower.Mission()
        Me.Battlesite = New OverPower.Location()
        Me.Homebase = New OverPower.Location()
        Me.Character4 = New OverPower.Character()
        Me.Character3 = New OverPower.Character()
        Me.Character2 = New OverPower.Character()
        Me.OppCharacter4 = New OverPower.Character()
        Me.Character1 = New OverPower.Character()
        Me.OppBattlesite = New OverPower.Location()
        Me.OppHomebase = New OverPower.Location()
        Me.OppCharacter3 = New OverPower.Character()
        Me.OppCharacter2 = New OverPower.Character()
        Me.OppCharacter1 = New OverPower.Character()
        Me.VentureR = New OverPower.Mission()
        Me.VentureC = New OverPower.Mission()
        Me.Defeated = New OverPower.Mission()
        Me.Completed = New OverPower.Mission()
        Me.Reserve = New OverPower.Mission()
        Me.TextOutputMenu.SuspendLayout()
        Me.TextInputMenu.SuspendLayout()
        CType(Me.DrawPile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PowerPack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeadPile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BigCardV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OppPowerPack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OppDeadPile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OppDrawPile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DefeatedChars, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OppDefeatedChars, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        CType(Me.BigCardH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttackPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AttackPanel.SuspendLayout()
        Me.CharMenu2.SuspendLayout()
        Me.CharMenu.SuspendLayout()
        CType(Me.Mission8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mission9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mission10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mission11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mission12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mission13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mission14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OppReserve, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mission1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mission2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mission3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mission4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mission5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mission6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mission7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Event1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Event2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OppVentureR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OppVentureC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OppCompleted, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OppDefeated, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Battlesite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Homebase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Character4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Character3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Character2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OppCharacter4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Character1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OppBattlesite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OppHomebase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OppCharacter3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OppCharacter2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OppCharacter1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentureR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentureC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Defeated, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Completed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reserve, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SUBMIT
        '
        Me.SUBMIT.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.SUBMIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SUBMIT.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SUBMIT.Location = New System.Drawing.Point(785, 651)
        Me.SUBMIT.Name = "SUBMIT"
        Me.SUBMIT.Size = New System.Drawing.Size(75, 25)
        Me.SUBMIT.TabIndex = 2
        Me.SUBMIT.Text = "SUBMIT"
        Me.SUBMIT.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.SUBMIT.UseVisualStyleBackColor = True
        '
        'TextOutput
        '
        Me.TextOutput.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TextOutput.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TextOutput.ContextMenuStrip = Me.TextOutputMenu
        Me.TextOutput.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextOutput.Location = New System.Drawing.Point(220, 573)
        Me.TextOutput.Name = "TextOutput"
        Me.TextOutput.ReadOnly = True
        Me.TextOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.TextOutput.Size = New System.Drawing.Size(640, 77)
        Me.TextOutput.TabIndex = 17
        Me.TextOutput.TabStop = False
        Me.TextOutput.Text = ""
        '
        'TextOutputMenu
        '
        Me.TextOutputMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TextOutputCopy})
        Me.TextOutputMenu.Name = "TextOutputContextMenu"
        Me.TextOutputMenu.ShowImageMargin = False
        Me.TextOutputMenu.Size = New System.Drawing.Size(71, 26)
        '
        'TextOutputCopy
        '
        Me.TextOutputCopy.Name = "TextOutputCopy"
        Me.TextOutputCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.TextOutputCopy.ShowShortcutKeys = False
        Me.TextOutputCopy.Size = New System.Drawing.Size(70, 22)
        Me.TextOutputCopy.Text = "Copy"
        '
        'TextInput
        '
        Me.TextInput.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TextInput.ContextMenuStrip = Me.TextInputMenu
        Me.TextInput.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextInput.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TextInput.Location = New System.Drawing.Point(220, 651)
        Me.TextInput.MaxLength = 280
        Me.TextInput.Multiline = False
        Me.TextInput.Name = "TextInput"
        Me.TextInput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.TextInput.Size = New System.Drawing.Size(564, 26)
        Me.TextInput.TabIndex = 1
        Me.TextInput.Text = ""
        '
        'TextInputMenu
        '
        Me.TextInputMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TextInputCut, Me.TextInputCopy, Me.TextInputPaste})
        Me.TextInputMenu.Name = "TextInputContextMenu"
        Me.TextInputMenu.ShowImageMargin = False
        Me.TextInputMenu.Size = New System.Drawing.Size(71, 70)
        '
        'TextInputCut
        '
        Me.TextInputCut.Name = "TextInputCut"
        Me.TextInputCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.TextInputCut.ShowShortcutKeys = False
        Me.TextInputCut.Size = New System.Drawing.Size(70, 22)
        Me.TextInputCut.Text = "Cut"
        '
        'TextInputCopy
        '
        Me.TextInputCopy.Name = "TextInputCopy"
        Me.TextInputCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.TextInputCopy.ShowShortcutKeys = False
        Me.TextInputCopy.Size = New System.Drawing.Size(70, 22)
        Me.TextInputCopy.Text = "Copy"
        '
        'TextInputPaste
        '
        Me.TextInputPaste.Name = "TextInputPaste"
        Me.TextInputPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.TextInputPaste.ShowShortcutKeys = False
        Me.TextInputPaste.Size = New System.Drawing.Size(70, 22)
        Me.TextInputPaste.Text = "Paste"
        '
        'OpenDeckToolStripMenuItem
        '
        Me.OpenDeckToolStripMenuItem.Name = "OpenDeckToolStripMenuItem"
        Me.OpenDeckToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.OpenDeckToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OpenDeckToolStripMenuItem.Text = "Load &Deck"
        '
        'Undo
        '
        Me.Undo.Name = "Undo"
        Me.Undo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.Undo.Size = New System.Drawing.Size(144, 22)
        Me.Undo.Text = "&Undo"
        '
        'Redo
        '
        Me.Redo.Name = "Redo"
        Me.Redo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.Redo.Size = New System.Drawing.Size(144, 22)
        Me.Redo.Text = "&Redo"
        '
        'Cut
        '
        Me.Cut.Image = CType(resources.GetObject("Cut.Image"), System.Drawing.Image)
        Me.Cut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Cut.Name = "Cut"
        Me.Cut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.Cut.Size = New System.Drawing.Size(144, 22)
        Me.Cut.Text = "Cu&t"
        '
        'Copy
        '
        Me.Copy.Image = CType(resources.GetObject("Copy.Image"), System.Drawing.Image)
        Me.Copy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Copy.Name = "Copy"
        Me.Copy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.Copy.Size = New System.Drawing.Size(144, 22)
        Me.Copy.Text = "&Copy"
        '
        'Paste
        '
        Me.Paste.Image = CType(resources.GetObject("Paste.Image"), System.Drawing.Image)
        Me.Paste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Paste.Name = "Paste"
        Me.Paste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.Paste.Size = New System.Drawing.Size(144, 22)
        Me.Paste.Text = "&Paste"
        '
        'SelectAll
        '
        Me.SelectAll.Name = "SelectAll"
        Me.SelectAll.Size = New System.Drawing.Size(144, 22)
        Me.SelectAll.Text = "Select &All"
        '
        'DrawPile
        '
        Me.DrawPile.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DrawPile.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.DrawPile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DrawPile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DrawPile.Image = Global.OverPower.My.Resources.Resources.op_back
        Me.DrawPile.Location = New System.Drawing.Point(240, 491)
        Me.DrawPile.Name = "DrawPile"
        Me.DrawPile.Size = New System.Drawing.Size(43, 60)
        Me.DrawPile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DrawPile.TabIndex = 50
        Me.DrawPile.TabStop = False
        Me.DrawPile.Visible = False
        '
        'PowerPack
        '
        Me.PowerPack.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PowerPack.BackColor = System.Drawing.SystemColors.Control
        Me.PowerPack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PowerPack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PowerPack.Location = New System.Drawing.Point(240, 422)
        Me.PowerPack.Name = "PowerPack"
        Me.PowerPack.Size = New System.Drawing.Size(43, 60)
        Me.PowerPack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PowerPack.TabIndex = 51
        Me.PowerPack.TabStop = False
        Me.PowerPack.Visible = False
        '
        'DeadPile
        '
        Me.DeadPile.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DeadPile.BackColor = System.Drawing.SystemColors.Control
        Me.DeadPile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DeadPile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DeadPile.Location = New System.Drawing.Point(188, 422)
        Me.DeadPile.Name = "DeadPile"
        Me.DeadPile.Size = New System.Drawing.Size(43, 60)
        Me.DeadPile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DeadPile.TabIndex = 52
        Me.DeadPile.TabStop = False
        Me.DeadPile.Visible = False
        '
        'BigCardV
        '
        Me.BigCardV.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BigCardV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BigCardV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BigCardV.Location = New System.Drawing.Point(20, 214)
        Me.BigCardV.Name = "BigCardV"
        Me.BigCardV.Size = New System.Drawing.Size(162, 227)
        Me.BigCardV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BigCardV.TabIndex = 53
        Me.BigCardV.TabStop = False
        Me.BigCardV.Visible = False
        '
        'OppPowerPack
        '
        Me.OppPowerPack.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OppPowerPack.BackColor = System.Drawing.SystemColors.Control
        Me.OppPowerPack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OppPowerPack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OppPowerPack.Location = New System.Drawing.Point(797, 113)
        Me.OppPowerPack.Name = "OppPowerPack"
        Me.OppPowerPack.Size = New System.Drawing.Size(43, 60)
        Me.OppPowerPack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.OppPowerPack.TabIndex = 57
        Me.OppPowerPack.TabStop = False
        Me.OppPowerPack.Visible = False
        '
        'OppDeadPile
        '
        Me.OppDeadPile.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OppDeadPile.BackColor = System.Drawing.SystemColors.Control
        Me.OppDeadPile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OppDeadPile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OppDeadPile.Location = New System.Drawing.Point(849, 113)
        Me.OppDeadPile.Name = "OppDeadPile"
        Me.OppDeadPile.Size = New System.Drawing.Size(43, 60)
        Me.OppDeadPile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.OppDeadPile.TabIndex = 56
        Me.OppDeadPile.TabStop = False
        Me.OppDeadPile.Visible = False
        '
        'OppDrawPile
        '
        Me.OppDrawPile.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OppDrawPile.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.OppDrawPile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OppDrawPile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OppDrawPile.Image = Global.OverPower.My.Resources.Resources.op_back
        Me.OppDrawPile.Location = New System.Drawing.Point(797, 44)
        Me.OppDrawPile.Name = "OppDrawPile"
        Me.OppDrawPile.Size = New System.Drawing.Size(43, 60)
        Me.OppDrawPile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.OppDrawPile.TabIndex = 55
        Me.OppDrawPile.TabStop = False
        Me.OppDrawPile.Visible = False
        '
        'CurrentPhase
        '
        Me.CurrentPhase.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.CurrentPhase.BackColor = System.Drawing.Color.Transparent
        Me.CurrentPhase.Font = New System.Drawing.Font("Heather BTN", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentPhase.Location = New System.Drawing.Point(13, 560)
        Me.CurrentPhase.Name = "CurrentPhase"
        Me.CurrentPhase.Size = New System.Drawing.Size(176, 27)
        Me.CurrentPhase.TabIndex = 58
        Me.CurrentPhase.Text = "CURRENT  PHASE"
        Me.CurrentPhase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DefeatedChars
        '
        Me.DefeatedChars.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DefeatedChars.BackColor = System.Drawing.SystemColors.Control
        Me.DefeatedChars.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DefeatedChars.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DefeatedChars.Location = New System.Drawing.Point(188, 491)
        Me.DefeatedChars.Name = "DefeatedChars"
        Me.DefeatedChars.Size = New System.Drawing.Size(43, 60)
        Me.DefeatedChars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DefeatedChars.TabIndex = 102
        Me.DefeatedChars.TabStop = False
        Me.DefeatedChars.Visible = False
        '
        'OppDefeatedChars
        '
        Me.OppDefeatedChars.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OppDefeatedChars.BackColor = System.Drawing.SystemColors.Control
        Me.OppDefeatedChars.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OppDefeatedChars.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OppDefeatedChars.Location = New System.Drawing.Point(849, 44)
        Me.OppDefeatedChars.Name = "OppDefeatedChars"
        Me.OppDefeatedChars.Size = New System.Drawing.Size(43, 60)
        Me.OppDefeatedChars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.OppDefeatedChars.TabIndex = 103
        Me.OppDefeatedChars.TabStop = False
        Me.OppDefeatedChars.Visible = False
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.MyDeckToolStripMenuItem, Me.OpponentDeckToolStripMenuItem, Me.ConnectionsToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1064, 24)
        Me.MenuStrip.TabIndex = 104
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewGameToolStripMenuItem, Me.RematchToolStripMenuItem, Me.OpenGameToolStripMenuItem1, Me.toolStripSeparator1, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.toolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewGameToolStripMenuItem
        '
        Me.NewGameToolStripMenuItem.Image = CType(resources.GetObject("NewGameToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewGameToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem"
        Me.NewGameToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.NewGameToolStripMenuItem.Text = "&New Game"
        '
        'RematchToolStripMenuItem
        '
        Me.RematchToolStripMenuItem.Enabled = False
        Me.RematchToolStripMenuItem.Name = "RematchToolStripMenuItem"
        Me.RematchToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.RematchToolStripMenuItem.Text = "&Rematch"
        '
        'OpenGameToolStripMenuItem1
        '
        Me.OpenGameToolStripMenuItem1.Image = CType(resources.GetObject("OpenGameToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.OpenGameToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenGameToolStripMenuItem1.Name = "OpenGameToolStripMenuItem1"
        Me.OpenGameToolStripMenuItem1.Size = New System.Drawing.Size(137, 22)
        Me.OpenGameToolStripMenuItem1.Text = "&Open Game"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(134, 6)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save &As"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(134, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripSeparator3, Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.toolStripSeparator4, Me.SelectAllToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(119, 6)
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Image = CType(resources.GetObject("CutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.CutToolStripMenuItem.Text = "Cu&t"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Image = CType(resources.GetObject("CopyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.CopyToolStripMenuItem.Text = "&Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Image = CType(resources.GetObject("PasteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.PasteToolStripMenuItem.Text = "&Paste"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(119, 6)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select &All"
        '
        'MyDeckToolStripMenuItem
        '
        Me.MyDeckToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadDeckToolStripMenuItem, Me.ToolStripSeparator5, Me.DrawCardToolStripMenuItem, Me.ToolStripSeparator6, Me.ShuffleDeckToolStripMenuItem})
        Me.MyDeckToolStripMenuItem.Name = "MyDeckToolStripMenuItem"
        Me.MyDeckToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.MyDeckToolStripMenuItem.Text = "&My Deck"
        '
        'LoadDeckToolStripMenuItem
        '
        Me.LoadDeckToolStripMenuItem.Name = "LoadDeckToolStripMenuItem"
        Me.LoadDeckToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LoadDeckToolStripMenuItem.Text = "&Load Deck"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(177, 6)
        '
        'DrawCardToolStripMenuItem
        '
        Me.DrawCardToolStripMenuItem.Enabled = False
        Me.DrawCardToolStripMenuItem.Name = "DrawCardToolStripMenuItem"
        Me.DrawCardToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DrawCardToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DrawCardToolStripMenuItem.Text = "&Draw Card"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(177, 6)
        '
        'ShuffleDeckToolStripMenuItem
        '
        Me.ShuffleDeckToolStripMenuItem.Enabled = False
        Me.ShuffleDeckToolStripMenuItem.Name = "ShuffleDeckToolStripMenuItem"
        Me.ShuffleDeckToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.ShuffleDeckToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ShuffleDeckToolStripMenuItem.Text = "&Shuffle Deck"
        '
        'OpponentDeckToolStripMenuItem
        '
        Me.OpponentDeckToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowHandToolStripMenuItem})
        Me.OpponentDeckToolStripMenuItem.Name = "OpponentDeckToolStripMenuItem"
        Me.OpponentDeckToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.OpponentDeckToolStripMenuItem.Text = "&Opp Deck"
        '
        'ShowHandToolStripMenuItem
        '
        Me.ShowHandToolStripMenuItem.Enabled = False
        Me.ShowHandToolStripMenuItem.Name = "ShowHandToolStripMenuItem"
        Me.ShowHandToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.ShowHandToolStripMenuItem.Text = "&Show Hand"
        '
        'ConnectionsToolStripMenuItem
        '
        Me.ConnectionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConnectToolStripMenuItem, Me.DisconnectToolStripMenuItem})
        Me.ConnectionsToolStripMenuItem.Name = "ConnectionsToolStripMenuItem"
        Me.ConnectionsToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.ConnectionsToolStripMenuItem.Text = "&Connections"
        '
        'ConnectToolStripMenuItem
        '
        Me.ConnectToolStripMenuItem.Name = "ConnectToolStripMenuItem"
        Me.ConnectToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.ConnectToolStripMenuItem.Text = "&Connect"
        '
        'DisconnectToolStripMenuItem
        '
        Me.DisconnectToolStripMenuItem.Enabled = False
        Me.DisconnectToolStripMenuItem.Name = "DisconnectToolStripMenuItem"
        Me.DisconnectToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.DisconnectToolStripMenuItem.Text = "&Disconnect"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.SettingsToolStripMenuItem.Text = "&Settings"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LinksToolStripMenuItem, Me.SearchToolStripMenuItem, Me.toolStripSeparator7, Me.AboutToolStripMenuItem, Me.DonateToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'LinksToolStripMenuItem
        '
        Me.LinksToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OverPowercaToolStripMenuItem, Me.ForumsToolStripMenuItem, Me.WikiToolStripMenuItem, Me.FacebookToolStripMenuItem, Me.TwitterToolStripMenuItem, Me.YouTubeToolStripMenuItem})
        Me.LinksToolStripMenuItem.Name = "LinksToolStripMenuItem"
        Me.LinksToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.LinksToolStripMenuItem.Text = "&Links"
        '
        'OverPowercaToolStripMenuItem
        '
        Me.OverPowercaToolStripMenuItem.Name = "OverPowercaToolStripMenuItem"
        Me.OverPowercaToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.OverPowercaToolStripMenuItem.Text = "&OverPower.ca"
        '
        'ForumsToolStripMenuItem
        '
        Me.ForumsToolStripMenuItem.Name = "ForumsToolStripMenuItem"
        Me.ForumsToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.ForumsToolStripMenuItem.Text = "&Forums"
        '
        'WikiToolStripMenuItem
        '
        Me.WikiToolStripMenuItem.Name = "WikiToolStripMenuItem"
        Me.WikiToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.WikiToolStripMenuItem.Text = "&Wiki"
        '
        'FacebookToolStripMenuItem
        '
        Me.FacebookToolStripMenuItem.Name = "FacebookToolStripMenuItem"
        Me.FacebookToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.FacebookToolStripMenuItem.Text = "Face&book"
        '
        'TwitterToolStripMenuItem
        '
        Me.TwitterToolStripMenuItem.Name = "TwitterToolStripMenuItem"
        Me.TwitterToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.TwitterToolStripMenuItem.Text = "&Twitter"
        '
        'YouTubeToolStripMenuItem
        '
        Me.YouTubeToolStripMenuItem.Name = "YouTubeToolStripMenuItem"
        Me.YouTubeToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.YouTubeToolStripMenuItem.Text = "&YouTube"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.SearchToolStripMenuItem.Text = "&Search Codes"
        '
        'toolStripSeparator7
        '
        Me.toolStripSeparator7.Name = "toolStripSeparator7"
        Me.toolStripSeparator7.Size = New System.Drawing.Size(142, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.AboutToolStripMenuItem.Text = "&About..."
        '
        'DonateToolStripMenuItem
        '
        Me.DonateToolStripMenuItem.Name = "DonateToolStripMenuItem"
        Me.DonateToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.DonateToolStripMenuItem.Text = "&Donate"
        '
        'BigCardH
        '
        Me.BigCardH.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BigCardH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BigCardH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BigCardH.Location = New System.Drawing.Point(20, 214)
        Me.BigCardH.Name = "BigCardH"
        Me.BigCardH.Size = New System.Drawing.Size(227, 162)
        Me.BigCardH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BigCardH.TabIndex = 105
        Me.BigCardH.TabStop = False
        Me.BigCardH.Visible = False
        '
        'Phase
        '
        Me.Phase.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Phase.BackColor = System.Drawing.Color.Transparent
        Me.Phase.Font = New System.Drawing.Font("Heather BTN", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Phase.Location = New System.Drawing.Point(13, 585)
        Me.Phase.Name = "Phase"
        Me.Phase.Size = New System.Drawing.Size(176, 27)
        Me.Phase.TabIndex = 106
        Me.Phase.Text = "DISCARD"
        Me.Phase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1078, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 15)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'bPhase
        '
        Me.bPhase.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bPhase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.bPhase.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bPhase.Enabled = False
        Me.bPhase.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bPhase.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bPhase.Location = New System.Drawing.Point(64, 627)
        Me.bPhase.Name = "bPhase"
        Me.bPhase.Size = New System.Drawing.Size(75, 23)
        Me.bPhase.TabIndex = 108
        Me.bPhase.Text = "Done"
        Me.bPhase.UseVisualStyleBackColor = False
        '
        'bDiscard
        '
        Me.bDiscard.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bDiscard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.bDiscard.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bDiscard.FlatAppearance.BorderSize = 0
        Me.bDiscard.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bDiscard.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bDiscard.Location = New System.Drawing.Point(993, 130)
        Me.bDiscard.Name = "bDiscard"
        Me.bDiscard.Size = New System.Drawing.Size(55, 22)
        Me.bDiscard.TabIndex = 109
        Me.bDiscard.Text = "Discard"
        Me.bDiscard.UseVisualStyleBackColor = False
        Me.bDiscard.Visible = False
        '
        'bPlace
        '
        Me.bPlace.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bPlace.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.bPlace.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bPlace.FlatAppearance.BorderSize = 0
        Me.bPlace.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bPlace.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bPlace.Location = New System.Drawing.Point(993, 182)
        Me.bPlace.Name = "bPlace"
        Me.bPlace.Size = New System.Drawing.Size(55, 22)
        Me.bPlace.TabIndex = 110
        Me.bPlace.Text = "Place"
        Me.bPlace.UseVisualStyleBackColor = False
        Me.bPlace.Visible = False
        '
        'bPlay
        '
        Me.bPlay.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bPlay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.bPlay.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bPlay.FlatAppearance.BorderSize = 0
        Me.bPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bPlay.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bPlay.Location = New System.Drawing.Point(993, 228)
        Me.bPlay.Name = "bPlay"
        Me.bPlay.Size = New System.Drawing.Size(55, 22)
        Me.bPlay.TabIndex = 111
        Me.bPlay.Text = "Play"
        Me.bPlay.UseVisualStyleBackColor = False
        Me.bPlay.Visible = False
        '
        'bD
        '
        Me.bD.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bD.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.bD.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bD.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bD.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bD.Location = New System.Drawing.Point(993, 321)
        Me.bD.Name = "bD"
        Me.bD.Size = New System.Drawing.Size(13, 22)
        Me.bD.TabIndex = 112
        Me.bD.Text = "D"
        Me.bD.UseVisualStyleBackColor = False
        Me.bD.Visible = False
        '
        'bP
        '
        Me.bP.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.bP.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bP.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bP.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bP.Location = New System.Drawing.Point(993, 293)
        Me.bP.Name = "bP"
        Me.bP.Size = New System.Drawing.Size(13, 22)
        Me.bP.TabIndex = 113
        Me.bP.Text = "P"
        Me.bP.UseVisualStyleBackColor = False
        Me.bP.Visible = False
        '
        'PlaceTextBox
        '
        Me.PlaceTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PlaceTextBox.BackColor = System.Drawing.Color.LightGray
        Me.PlaceTextBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.PlaceTextBox.Enabled = False
        Me.PlaceTextBox.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlaceTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.PlaceTextBox.Location = New System.Drawing.Point(292, 272)
        Me.PlaceTextBox.Multiline = True
        Me.PlaceTextBox.Name = "PlaceTextBox"
        Me.PlaceTextBox.ReadOnly = True
        Me.PlaceTextBox.Size = New System.Drawing.Size(496, 70)
        Me.PlaceTextBox.TabIndex = 115
        Me.PlaceTextBox.Text = "Place Card:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click the character you want to place it to"
        Me.PlaceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PlaceTextBox.Visible = False
        '
        'PlayTextBox
        '
        Me.PlayTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PlayTextBox.BackColor = System.Drawing.Color.LightGray
        Me.PlayTextBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.PlayTextBox.Enabled = False
        Me.PlayTextBox.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.PlayTextBox.Location = New System.Drawing.Point(292, 255)
        Me.PlayTextBox.Multiline = True
        Me.PlayTextBox.Name = "PlayTextBox"
        Me.PlayTextBox.ReadOnly = True
        Me.PlayTextBox.Size = New System.Drawing.Size(496, 105)
        Me.PlayTextBox.TabIndex = 116
        Me.PlayTextBox.Text = "To Play Card as an Attack:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click the attacker that will play the card" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "To Play C" & _
    "ard:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Double-click the character or base you want to play it on"
        Me.PlayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PlayTextBox.Visible = False
        '
        'bCancel
        '
        Me.bCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.bCancel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bCancel.FlatAppearance.BorderSize = 0
        Me.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bCancel.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bCancel.Location = New System.Drawing.Point(993, 449)
        Me.bCancel.Name = "bCancel"
        Me.bCancel.Size = New System.Drawing.Size(75, 23)
        Me.bCancel.TabIndex = 117
        Me.bCancel.Text = "Cancel"
        Me.bCancel.UseVisualStyleBackColor = False
        Me.bCancel.Visible = False
        '
        'bAccept
        '
        Me.bAccept.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bAccept.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.bAccept.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bAccept.FlatAppearance.BorderSize = 0
        Me.bAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAccept.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAccept.Location = New System.Drawing.Point(993, 391)
        Me.bAccept.Name = "bAccept"
        Me.bAccept.Size = New System.Drawing.Size(75, 23)
        Me.bAccept.TabIndex = 119
        Me.bAccept.Text = "Accept"
        Me.bAccept.UseVisualStyleBackColor = False
        Me.bAccept.Visible = False
        '
        'bChallenge
        '
        Me.bChallenge.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bChallenge.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.bChallenge.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bChallenge.FlatAppearance.BorderSize = 0
        Me.bChallenge.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bChallenge.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bChallenge.Location = New System.Drawing.Point(993, 420)
        Me.bChallenge.Name = "bChallenge"
        Me.bChallenge.Size = New System.Drawing.Size(75, 23)
        Me.bChallenge.TabIndex = 120
        Me.bChallenge.Text = "Challenge"
        Me.bChallenge.UseVisualStyleBackColor = False
        Me.bChallenge.Visible = False
        '
        'AttackBox
        '
        Me.AttackBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AttackBox.BackColor = System.Drawing.Color.LightGray
        Me.AttackBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.AttackBox.Enabled = False
        Me.AttackBox.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AttackBox.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.AttackBox.Location = New System.Drawing.Point(346, 247)
        Me.AttackBox.Multiline = True
        Me.AttackBox.Name = "AttackBox"
        Me.AttackBox.ReadOnly = True
        Me.AttackBox.Size = New System.Drawing.Size(388, 95)
        Me.AttackBox.TabIndex = 124
        Me.AttackBox.Text = "Add more cards or click target to attack"
        Me.AttackBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.AttackBox.Visible = False
        '
        'bR
        '
        Me.bR.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bR.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.bR.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bR.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bR.Location = New System.Drawing.Point(993, 351)
        Me.bR.Name = "bR"
        Me.bR.Size = New System.Drawing.Size(13, 20)
        Me.bR.TabIndex = 125
        Me.bR.Text = "R"
        Me.bR.UseVisualStyleBackColor = False
        Me.bR.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 300
        '
        'Timer2
        '
        Me.Timer2.Interval = 800
        '
        'bAttack
        '
        Me.bAttack.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bAttack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.bAttack.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bAttack.Enabled = False
        Me.bAttack.FlatAppearance.BorderSize = 0
        Me.bAttack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAttack.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAttack.Location = New System.Drawing.Point(993, 482)
        Me.bAttack.Name = "bAttack"
        Me.bAttack.Size = New System.Drawing.Size(75, 23)
        Me.bAttack.TabIndex = 126
        Me.bAttack.Text = "Attack"
        Me.bAttack.UseVisualStyleBackColor = False
        Me.bAttack.Visible = False
        '
        'bHits
        '
        Me.bHits.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bHits.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.bHits.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bHits.FlatAppearance.BorderSize = 0
        Me.bHits.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bHits.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bHits.Location = New System.Drawing.Point(993, 512)
        Me.bHits.Name = "bHits"
        Me.bHits.Size = New System.Drawing.Size(75, 22)
        Me.bHits.TabIndex = 127
        Me.bHits.Text = "Hits"
        Me.bHits.UseVisualStyleBackColor = False
        Me.bHits.Visible = False
        '
        'bDefend
        '
        Me.bDefend.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bDefend.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.bDefend.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bDefend.FlatAppearance.BorderSize = 0
        Me.bDefend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bDefend.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bDefend.Location = New System.Drawing.Point(993, 542)
        Me.bDefend.Name = "bDefend"
        Me.bDefend.Size = New System.Drawing.Size(75, 22)
        Me.bDefend.TabIndex = 128
        Me.bDefend.Text = "Defend"
        Me.bDefend.UseVisualStyleBackColor = False
        Me.bDefend.Visible = False
        '
        'bMin
        '
        Me.bMin.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bMin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.bMin.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bMin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bMin.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bMin.Location = New System.Drawing.Point(993, 263)
        Me.bMin.Name = "bMin"
        Me.bMin.Size = New System.Drawing.Size(20, 22)
        Me.bMin.TabIndex = 129
        Me.bMin.Text = "-"
        Me.bMin.UseVisualStyleBackColor = False
        Me.bMin.Visible = False
        '
        'AttackPanel
        '
        Me.AttackPanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AttackPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AttackPanel.IsSplitterFixed = True
        Me.AttackPanel.Location = New System.Drawing.Point(346, 271)
        Me.AttackPanel.Name = "AttackPanel"
        '
        'AttackPanel.Panel1
        '
        Me.AttackPanel.Panel1.BackColor = System.Drawing.Color.MistyRose
        '
        'AttackPanel.Panel2
        '
        Me.AttackPanel.Panel2.BackColor = System.Drawing.Color.Honeydew
        Me.AttackPanel.Panel2Collapsed = True
        Me.AttackPanel.Size = New System.Drawing.Size(307, 70)
        Me.AttackPanel.SplitterDistance = 153
        Me.AttackPanel.TabIndex = 130
        Me.AttackPanel.Visible = False
        '
        'DefendBox
        '
        Me.DefendBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DefendBox.BackColor = System.Drawing.Color.LightGray
        Me.DefendBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.DefendBox.Enabled = False
        Me.DefendBox.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DefendBox.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.DefendBox.Location = New System.Drawing.Point(346, 247)
        Me.DefendBox.Multiline = True
        Me.DefendBox.Name = "DefendBox"
        Me.DefendBox.ReadOnly = True
        Me.DefendBox.Size = New System.Drawing.Size(388, 95)
        Me.DefendBox.TabIndex = 131
        Me.DefendBox.Text = "Play cards to defend"
        Me.DefendBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DefendBox.Visible = False
        '
        'AcceptBox
        '
        Me.AcceptBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AcceptBox.BackColor = System.Drawing.Color.LightGray
        Me.AcceptBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.AcceptBox.Enabled = False
        Me.AcceptBox.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AcceptBox.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.AcceptBox.Location = New System.Drawing.Point(346, 247)
        Me.AcceptBox.Multiline = True
        Me.AcceptBox.Name = "AcceptBox"
        Me.AcceptBox.ReadOnly = True
        Me.AcceptBox.Size = New System.Drawing.Size(388, 95)
        Me.AcceptBox.TabIndex = 132
        Me.AcceptBox.Text = "Accept or challenge the defense"
        Me.AcceptBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.AcceptBox.Visible = False
        '
        'bMinusMe
        '
        Me.bMinusMe.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bMinusMe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.bMinusMe.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bMinusMe.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bMinusMe.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bMinusMe.Location = New System.Drawing.Point(20, 495)
        Me.bMinusMe.MaximumSize = New System.Drawing.Size(20, 22)
        Me.bMinusMe.MinimumSize = New System.Drawing.Size(20, 22)
        Me.bMinusMe.Name = "bMinusMe"
        Me.bMinusMe.Size = New System.Drawing.Size(20, 22)
        Me.bMinusMe.TabIndex = 133
        Me.bMinusMe.Text = "-"
        Me.bMinusMe.UseVisualStyleBackColor = False
        '
        'bMinusOpp
        '
        Me.bMinusOpp.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bMinusOpp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.bMinusOpp.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bMinusOpp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bMinusOpp.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bMinusOpp.Location = New System.Drawing.Point(20, 525)
        Me.bMinusOpp.MaximumSize = New System.Drawing.Size(20, 22)
        Me.bMinusOpp.MinimumSize = New System.Drawing.Size(20, 22)
        Me.bMinusOpp.Name = "bMinusOpp"
        Me.bMinusOpp.Size = New System.Drawing.Size(20, 22)
        Me.bMinusOpp.TabIndex = 134
        Me.bMinusOpp.Text = "-"
        Me.bMinusOpp.UseVisualStyleBackColor = False
        '
        'bPlusMe
        '
        Me.bPlusMe.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bPlusMe.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.bPlusMe.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bPlusMe.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bPlusMe.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bPlusMe.Location = New System.Drawing.Point(120, 495)
        Me.bPlusMe.MaximumSize = New System.Drawing.Size(20, 22)
        Me.bPlusMe.MinimumSize = New System.Drawing.Size(20, 22)
        Me.bPlusMe.Name = "bPlusMe"
        Me.bPlusMe.Size = New System.Drawing.Size(20, 22)
        Me.bPlusMe.TabIndex = 135
        Me.bPlusMe.Text = "+"
        Me.bPlusMe.UseVisualStyleBackColor = False
        '
        'bPlusOpp
        '
        Me.bPlusOpp.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bPlusOpp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.bPlusOpp.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bPlusOpp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bPlusOpp.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bPlusOpp.Location = New System.Drawing.Point(120, 525)
        Me.bPlusOpp.MaximumSize = New System.Drawing.Size(20, 22)
        Me.bPlusOpp.MinimumSize = New System.Drawing.Size(20, 22)
        Me.bPlusOpp.Name = "bPlusOpp"
        Me.bPlusOpp.Size = New System.Drawing.Size(20, 22)
        Me.bPlusOpp.TabIndex = 136
        Me.bPlusOpp.Text = "+"
        Me.bPlusOpp.UseVisualStyleBackColor = False
        '
        'MyVenture
        '
        Me.MyVenture.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.MyVenture.BackColor = System.Drawing.Color.Transparent
        Me.MyVenture.Font = New System.Drawing.Font("Heather BTN", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyVenture.Location = New System.Drawing.Point(43, 495)
        Me.MyVenture.MaximumSize = New System.Drawing.Size(74, 22)
        Me.MyVenture.MinimumSize = New System.Drawing.Size(70, 22)
        Me.MyVenture.Name = "MyVenture"
        Me.MyVenture.Size = New System.Drawing.Size(74, 22)
        Me.MyVenture.TabIndex = 137
        Me.MyVenture.Text = "MY VENTURE"
        Me.MyVenture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OppVenture
        '
        Me.OppVenture.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.OppVenture.BackColor = System.Drawing.Color.Transparent
        Me.OppVenture.Font = New System.Drawing.Font("Heather BTN", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OppVenture.Location = New System.Drawing.Point(43, 525)
        Me.OppVenture.MaximumSize = New System.Drawing.Size(74, 22)
        Me.OppVenture.MinimumSize = New System.Drawing.Size(74, 22)
        Me.OppVenture.Name = "OppVenture"
        Me.OppVenture.Size = New System.Drawing.Size(74, 22)
        Me.OppVenture.TabIndex = 138
        Me.OppVenture.Text = "OPP VENTURE"
        Me.OppVenture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MyTotalV
        '
        Me.MyTotalV.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.MyTotalV.BackColor = System.Drawing.Color.Transparent
        Me.MyTotalV.Font = New System.Drawing.Font("Heather BTN", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyTotalV.Location = New System.Drawing.Point(144, 495)
        Me.MyTotalV.MaximumSize = New System.Drawing.Size(28, 22)
        Me.MyTotalV.MinimumSize = New System.Drawing.Size(28, 22)
        Me.MyTotalV.Name = "MyTotalV"
        Me.MyTotalV.Size = New System.Drawing.Size(28, 22)
        Me.MyTotalV.TabIndex = 139
        Me.MyTotalV.Text = "0"
        Me.MyTotalV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OppTotalV
        '
        Me.OppTotalV.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.OppTotalV.BackColor = System.Drawing.Color.Transparent
        Me.OppTotalV.Font = New System.Drawing.Font("Heather BTN", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OppTotalV.Location = New System.Drawing.Point(144, 525)
        Me.OppTotalV.MaximumSize = New System.Drawing.Size(28, 22)
        Me.OppTotalV.MinimumSize = New System.Drawing.Size(28, 22)
        Me.OppTotalV.Name = "OppTotalV"
        Me.OppTotalV.Size = New System.Drawing.Size(28, 22)
        Me.OppTotalV.TabIndex = 140
        Me.OppTotalV.Text = "0"
        Me.OppTotalV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(20, 446)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(162, 38)
        Me.TextBox1.TabIndex = 141
        Me.TextBox1.Visible = False
        '
        'b2C
        '
        Me.b2C.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.b2C.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.b2C.BackColor = System.Drawing.Color.WhiteSmoke
        Me.b2C.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.b2C.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b2C.Location = New System.Drawing.Point(1015, 321)
        Me.b2C.Name = "b2C"
        Me.b2C.Size = New System.Drawing.Size(13, 22)
        Me.b2C.TabIndex = 142
        Me.b2C.Text = "C"
        Me.b2C.UseVisualStyleBackColor = False
        Me.b2C.Visible = False
        '
        'b2R
        '
        Me.b2R.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.b2R.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.b2R.BackColor = System.Drawing.Color.WhiteSmoke
        Me.b2R.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.b2R.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b2R.Location = New System.Drawing.Point(1015, 351)
        Me.b2R.Name = "b2R"
        Me.b2R.Size = New System.Drawing.Size(13, 22)
        Me.b2R.TabIndex = 143
        Me.b2R.Text = "R"
        Me.b2R.UseVisualStyleBackColor = False
        Me.b2R.Visible = False
        '
        'bShift
        '
        Me.bShift.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bShift.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.bShift.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bShift.FlatAppearance.BorderSize = 0
        Me.bShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bShift.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bShift.Location = New System.Drawing.Point(993, 572)
        Me.bShift.Name = "bShift"
        Me.bShift.Size = New System.Drawing.Size(75, 22)
        Me.bShift.TabIndex = 144
        Me.bShift.Text = "Shift"
        Me.bShift.UseVisualStyleBackColor = False
        Me.bShift.Visible = False
        '
        'bPlusV
        '
        Me.bPlusV.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bPlusV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.bPlusV.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bPlusV.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bPlusV.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bPlusV.Location = New System.Drawing.Point(1035, 293)
        Me.bPlusV.Name = "bPlusV"
        Me.bPlusV.Size = New System.Drawing.Size(13, 22)
        Me.bPlusV.TabIndex = 145
        Me.bPlusV.Text = ">"
        Me.bPlusV.UseVisualStyleBackColor = False
        Me.bPlusV.Visible = False
        '
        'bMinusV
        '
        Me.bMinusV.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bMinusV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.bMinusV.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bMinusV.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bMinusV.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bMinusV.Location = New System.Drawing.Point(1015, 293)
        Me.bMinusV.Name = "bMinusV"
        Me.bMinusV.Size = New System.Drawing.Size(13, 22)
        Me.bMinusV.TabIndex = 146
        Me.bMinusV.Text = "<"
        Me.bMinusV.UseVisualStyleBackColor = False
        Me.bMinusV.Visible = False
        '
        'b2D
        '
        Me.b2D.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.b2D.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.b2D.BackColor = System.Drawing.Color.WhiteSmoke
        Me.b2D.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.b2D.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b2D.Location = New System.Drawing.Point(1035, 321)
        Me.b2D.Name = "b2D"
        Me.b2D.Size = New System.Drawing.Size(13, 22)
        Me.b2D.TabIndex = 147
        Me.b2D.Text = "D"
        Me.b2D.UseVisualStyleBackColor = False
        Me.b2D.Visible = False
        '
        'b2P
        '
        Me.b2P.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.b2P.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.b2P.BackColor = System.Drawing.Color.WhiteSmoke
        Me.b2P.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.b2P.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b2P.Location = New System.Drawing.Point(1035, 351)
        Me.b2P.Name = "b2P"
        Me.b2P.Size = New System.Drawing.Size(13, 19)
        Me.b2P.TabIndex = 148
        Me.b2P.Text = "↓"
        Me.b2P.UseVisualStyleBackColor = False
        Me.b2P.Visible = False
        '
        'bPass
        '
        Me.bPass.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bPass.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.bPass.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bPass.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bPass.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bPass.Location = New System.Drawing.Point(103, 655)
        Me.bPass.MaximumSize = New System.Drawing.Size(60, 23)
        Me.bPass.MinimumSize = New System.Drawing.Size(60, 23)
        Me.bPass.Name = "bPass"
        Me.bPass.Size = New System.Drawing.Size(60, 23)
        Me.bPass.TabIndex = 150
        Me.bPass.Text = "Pass"
        Me.bPass.UseVisualStyleBackColor = False
        Me.bPass.Visible = False
        '
        'bConcede
        '
        Me.bConcede.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bConcede.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.bConcede.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bConcede.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bConcede.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bConcede.Location = New System.Drawing.Point(39, 655)
        Me.bConcede.MaximumSize = New System.Drawing.Size(60, 23)
        Me.bConcede.MinimumSize = New System.Drawing.Size(60, 23)
        Me.bConcede.Name = "bConcede"
        Me.bConcede.Size = New System.Drawing.Size(60, 23)
        Me.bConcede.TabIndex = 151
        Me.bConcede.Text = "Concede"
        Me.bConcede.UseVisualStyleBackColor = False
        Me.bConcede.Visible = False
        '
        'Timer3
        '
        Me.Timer3.Interval = 500
        '
        'lblOHS
        '
        Me.lblOHS.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOHS.BackColor = System.Drawing.Color.Transparent
        Me.lblOHS.Font = New System.Drawing.Font("Futura LT", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOHS.Location = New System.Drawing.Point(846, 3)
        Me.lblOHS.Name = "lblOHS"
        Me.lblOHS.Size = New System.Drawing.Size(214, 16)
        Me.lblOHS.TabIndex = 153
        Me.lblOHS.Text = "Opponent Hand Size = 0"
        Me.lblOHS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblOHS.Visible = False
        '
        'cbFacedown
        '
        Me.cbFacedown.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cbFacedown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbFacedown.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFacedown.Location = New System.Drawing.Point(972, 99)
        Me.cbFacedown.Name = "cbFacedown"
        Me.cbFacedown.Size = New System.Drawing.Size(75, 18)
        Me.cbFacedown.TabIndex = 161
        Me.cbFacedown.Text = "Facedown"
        Me.cbFacedown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cbFacedown.UseVisualStyleBackColor = False
        Me.cbFacedown.Visible = False
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.AttackToLine, Me.AttackFromLine})
        Me.ShapeContainer2.Size = New System.Drawing.Size(1064, 682)
        Me.ShapeContainer2.TabIndex = 164
        Me.ShapeContainer2.TabStop = False
        '
        'AttackToLine
        '
        Me.AttackToLine.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.AttackToLine.BorderWidth = 4
        Me.AttackToLine.Name = "AttackToLine"
        Me.AttackToLine.Visible = False
        Me.AttackToLine.X1 = 830
        Me.AttackToLine.X2 = 900
        Me.AttackToLine.Y1 = 330
        Me.AttackToLine.Y2 = 353
        '
        'AttackFromLine
        '
        Me.AttackFromLine.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.AttackFromLine.BorderWidth = 4
        Me.AttackFromLine.Name = "AttackFromLine"
        Me.AttackFromLine.Visible = False
        Me.AttackFromLine.X1 = 830
        Me.AttackFromLine.X2 = 900
        Me.AttackFromLine.Y1 = 246
        Me.AttackFromLine.Y2 = 269
        '
        'CharMenu2
        '
        Me.CharMenu2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.CharMenu2.Name = "CharMenu"
        Me.CharMenu2.ShowImageMargin = False
        Me.CharMenu2.Size = New System.Drawing.Size(66, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(65, 22)
        Me.ToolStripMenuItem1.Text = "KO"
        '
        'CharMenu
        '
        Me.CharMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KOToolStripMenuItem, Me.ToReserveToolStripMenuItem})
        Me.CharMenu.Name = "CharMenu"
        Me.CharMenu.ShowImageMargin = False
        Me.CharMenu.Size = New System.Drawing.Size(107, 48)
        '
        'KOToolStripMenuItem
        '
        Me.KOToolStripMenuItem.Name = "KOToolStripMenuItem"
        Me.KOToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.KOToolStripMenuItem.Text = "KO"
        '
        'ToReserveToolStripMenuItem
        '
        Me.ToReserveToolStripMenuItem.Name = "ToReserveToolStripMenuItem"
        Me.ToReserveToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.ToReserveToolStripMenuItem.Text = "To Reserve"
        '
        'bM
        '
        Me.bM.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.bM.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bM.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bM.Font = New System.Drawing.Font("Comic Sans MS", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bM.Location = New System.Drawing.Point(1035, 263)
        Me.bM.Name = "bM"
        Me.bM.Size = New System.Drawing.Size(13, 19)
        Me.bM.TabIndex = 165
        Me.bM.Text = "M"
        Me.bM.UseVisualStyleBackColor = False
        Me.bM.Visible = False
        '
        'MoveBox
        '
        Me.MoveBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MoveBox.BackColor = System.Drawing.Color.LightGray
        Me.MoveBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.MoveBox.Enabled = False
        Me.MoveBox.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MoveBox.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.MoveBox.Location = New System.Drawing.Point(338, 294)
        Me.MoveBox.Multiline = True
        Me.MoveBox.Name = "MoveBox"
        Me.MoveBox.ReadOnly = True
        Me.MoveBox.Size = New System.Drawing.Size(388, 30)
        Me.MoveBox.TabIndex = 166
        Me.MoveBox.Text = "Click a character to move the hit to"
        Me.MoveBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MoveBox.Visible = False
        '
        'BSlistbox
        '
        Me.BSlistbox.FormattingEnabled = True
        Me.BSlistbox.Location = New System.Drawing.Point(292, 250)
        Me.BSlistbox.Name = "BSlistbox"
        Me.BSlistbox.Size = New System.Drawing.Size(300, 69)
        Me.BSlistbox.TabIndex = 167
        Me.BSlistbox.Visible = False
        '
        'Mission8
        '
        Me.Mission8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Mission8.BackColor = System.Drawing.SystemColors.Control
        Me.Mission8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Mission8.InitialImage = Nothing
        Me.Mission8.Location = New System.Drawing.Point(245, 99)
        Me.Mission8.Name = "Mission8"
        Me.Mission8.Size = New System.Drawing.Size(36, 50)
        Me.Mission8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Mission8.TabIndex = 154
        Me.Mission8.TabStop = False
        Me.Mission8.Visible = False
        '
        'Mission9
        '
        Me.Mission9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Mission9.BackColor = System.Drawing.SystemColors.Control
        Me.Mission9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Mission9.InitialImage = Nothing
        Me.Mission9.Location = New System.Drawing.Point(245, 99)
        Me.Mission9.Name = "Mission9"
        Me.Mission9.Size = New System.Drawing.Size(36, 50)
        Me.Mission9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Mission9.TabIndex = 155
        Me.Mission9.TabStop = False
        Me.Mission9.Visible = False
        '
        'Mission10
        '
        Me.Mission10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Mission10.BackColor = System.Drawing.SystemColors.Control
        Me.Mission10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Mission10.InitialImage = Nothing
        Me.Mission10.Location = New System.Drawing.Point(245, 99)
        Me.Mission10.Name = "Mission10"
        Me.Mission10.Size = New System.Drawing.Size(36, 50)
        Me.Mission10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Mission10.TabIndex = 156
        Me.Mission10.TabStop = False
        Me.Mission10.Visible = False
        '
        'Mission11
        '
        Me.Mission11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Mission11.BackColor = System.Drawing.SystemColors.Control
        Me.Mission11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Mission11.InitialImage = Nothing
        Me.Mission11.Location = New System.Drawing.Point(245, 99)
        Me.Mission11.Name = "Mission11"
        Me.Mission11.Size = New System.Drawing.Size(36, 50)
        Me.Mission11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Mission11.TabIndex = 157
        Me.Mission11.TabStop = False
        Me.Mission11.Visible = False
        '
        'Mission12
        '
        Me.Mission12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Mission12.BackColor = System.Drawing.SystemColors.Control
        Me.Mission12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Mission12.InitialImage = Nothing
        Me.Mission12.Location = New System.Drawing.Point(245, 99)
        Me.Mission12.Name = "Mission12"
        Me.Mission12.Size = New System.Drawing.Size(36, 50)
        Me.Mission12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Mission12.TabIndex = 158
        Me.Mission12.TabStop = False
        Me.Mission12.Visible = False
        '
        'Mission13
        '
        Me.Mission13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Mission13.BackColor = System.Drawing.SystemColors.Control
        Me.Mission13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Mission13.InitialImage = Nothing
        Me.Mission13.Location = New System.Drawing.Point(245, 99)
        Me.Mission13.Name = "Mission13"
        Me.Mission13.Size = New System.Drawing.Size(36, 50)
        Me.Mission13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Mission13.TabIndex = 159
        Me.Mission13.TabStop = False
        Me.Mission13.Visible = False
        '
        'Mission14
        '
        Me.Mission14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Mission14.BackColor = System.Drawing.SystemColors.Control
        Me.Mission14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Mission14.InitialImage = Nothing
        Me.Mission14.Location = New System.Drawing.Point(245, 99)
        Me.Mission14.Name = "Mission14"
        Me.Mission14.Size = New System.Drawing.Size(36, 50)
        Me.Mission14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Mission14.TabIndex = 160
        Me.Mission14.TabStop = False
        Me.Mission14.Visible = False
        '
        'OppReserve
        '
        Me.OppReserve.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OppReserve.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.OppReserve.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OppReserve.InitialImage = Nothing
        Me.OppReserve.Location = New System.Drawing.Point(245, 99)
        Me.OppReserve.Name = "OppReserve"
        Me.OppReserve.Size = New System.Drawing.Size(36, 50)
        Me.OppReserve.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.OppReserve.TabIndex = 83
        Me.OppReserve.TabStop = False
        Me.OppReserve.Visible = False
        '
        'Mission1
        '
        Me.Mission1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Mission1.BackColor = System.Drawing.SystemColors.Control
        Me.Mission1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Mission1.InitialImage = Nothing
        Me.Mission1.Location = New System.Drawing.Point(799, 446)
        Me.Mission1.Name = "Mission1"
        Me.Mission1.Size = New System.Drawing.Size(36, 50)
        Me.Mission1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Mission1.TabIndex = 94
        Me.Mission1.TabStop = False
        Me.Mission1.Visible = False
        '
        'Mission2
        '
        Me.Mission2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Mission2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Mission2.Location = New System.Drawing.Point(799, 446)
        Me.Mission2.Name = "Mission2"
        Me.Mission2.Size = New System.Drawing.Size(36, 50)
        Me.Mission2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Mission2.TabIndex = 95
        Me.Mission2.TabStop = False
        Me.Mission2.Visible = False
        '
        'Mission3
        '
        Me.Mission3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Mission3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Mission3.Location = New System.Drawing.Point(799, 446)
        Me.Mission3.Name = "Mission3"
        Me.Mission3.Size = New System.Drawing.Size(36, 50)
        Me.Mission3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Mission3.TabIndex = 96
        Me.Mission3.TabStop = False
        Me.Mission3.Visible = False
        '
        'Mission4
        '
        Me.Mission4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Mission4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Mission4.Location = New System.Drawing.Point(799, 446)
        Me.Mission4.Name = "Mission4"
        Me.Mission4.Size = New System.Drawing.Size(36, 50)
        Me.Mission4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Mission4.TabIndex = 97
        Me.Mission4.TabStop = False
        Me.Mission4.Visible = False
        '
        'Mission5
        '
        Me.Mission5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Mission5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Mission5.Location = New System.Drawing.Point(799, 446)
        Me.Mission5.Name = "Mission5"
        Me.Mission5.Size = New System.Drawing.Size(36, 50)
        Me.Mission5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Mission5.TabIndex = 98
        Me.Mission5.TabStop = False
        Me.Mission5.Visible = False
        '
        'Mission6
        '
        Me.Mission6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Mission6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Mission6.Location = New System.Drawing.Point(799, 446)
        Me.Mission6.Name = "Mission6"
        Me.Mission6.Size = New System.Drawing.Size(36, 50)
        Me.Mission6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Mission6.TabIndex = 99
        Me.Mission6.TabStop = False
        Me.Mission6.Visible = False
        '
        'Mission7
        '
        Me.Mission7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Mission7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Mission7.Location = New System.Drawing.Point(799, 446)
        Me.Mission7.Name = "Mission7"
        Me.Mission7.Size = New System.Drawing.Size(36, 50)
        Me.Mission7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Mission7.TabIndex = 100
        Me.Mission7.TabStop = False
        Me.Mission7.Visible = False
        '
        'Event1
        '
        Me.Event1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Event1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Event1.Location = New System.Drawing.Point(20, 44)
        Me.Event1.Name = "Event1"
        Me.Event1.Size = New System.Drawing.Size(108, 77)
        Me.Event1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Event1.TabIndex = 93
        Me.Event1.TabStop = False
        Me.Event1.Visible = False
        '
        'Event2
        '
        Me.Event2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Event2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Event2.Location = New System.Drawing.Point(20, 129)
        Me.Event2.Name = "Event2"
        Me.Event2.Size = New System.Drawing.Size(108, 77)
        Me.Event2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Event2.TabIndex = 92
        Me.Event2.TabStop = False
        Me.Event2.Visible = False
        '
        'OppVentureR
        '
        Me.OppVentureR.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OppVentureR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OppVentureR.InitialImage = Nothing
        Me.OppVentureR.Location = New System.Drawing.Point(198, 99)
        Me.OppVentureR.Name = "OppVentureR"
        Me.OppVentureR.Size = New System.Drawing.Size(36, 50)
        Me.OppVentureR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.OppVentureR.TabIndex = 86
        Me.OppVentureR.TabStop = False
        Me.OppVentureR.Visible = False
        '
        'OppVentureC
        '
        Me.OppVentureC.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OppVentureC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OppVentureC.InitialImage = Nothing
        Me.OppVentureC.Location = New System.Drawing.Point(198, 44)
        Me.OppVentureC.Name = "OppVentureC"
        Me.OppVentureC.Size = New System.Drawing.Size(36, 50)
        Me.OppVentureC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.OppVentureC.TabIndex = 85
        Me.OppVentureC.TabStop = False
        Me.OppVentureC.Visible = False
        '
        'OppCompleted
        '
        Me.OppCompleted.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OppCompleted.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.OppCompleted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OppCompleted.InitialImage = Nothing
        Me.OppCompleted.Location = New System.Drawing.Point(245, 44)
        Me.OppCompleted.Name = "OppCompleted"
        Me.OppCompleted.Size = New System.Drawing.Size(36, 50)
        Me.OppCompleted.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.OppCompleted.TabIndex = 84
        Me.OppCompleted.TabStop = False
        Me.OppCompleted.Visible = False
        '
        'OppDefeated
        '
        Me.OppDefeated.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OppDefeated.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.OppDefeated.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OppDefeated.InitialImage = Nothing
        Me.OppDefeated.Location = New System.Drawing.Point(245, 154)
        Me.OppDefeated.Name = "OppDefeated"
        Me.OppDefeated.Size = New System.Drawing.Size(36, 50)
        Me.OppDefeated.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.OppDefeated.TabIndex = 82
        Me.OppDefeated.TabStop = False
        Me.OppDefeated.Visible = False
        '
        'Battlesite
        '
        Me.Battlesite.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Battlesite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Battlesite.ContextMenuStrip = Me.CharMenu2
        Me.Battlesite.InitialImage = Nothing
        Me.Battlesite.Location = New System.Drawing.Point(680, 374)
        Me.Battlesite.MaximumSize = New System.Drawing.Size(168, 120)
        Me.Battlesite.Name = "Battlesite"
        Me.Battlesite.Size = New System.Drawing.Size(108, 77)
        Me.Battlesite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Battlesite.TabIndex = 81
        Me.Battlesite.TabStop = False
        Me.Battlesite.Visible = False
        '
        'Homebase
        '
        Me.Homebase.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Homebase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Homebase.InitialImage = Nothing
        Me.Homebase.Location = New System.Drawing.Point(551, 474)
        Me.Homebase.MaximumSize = New System.Drawing.Size(168, 120)
        Me.Homebase.Name = "Homebase"
        Me.Homebase.Size = New System.Drawing.Size(108, 77)
        Me.Homebase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Homebase.TabIndex = 80
        Me.Homebase.TabStop = False
        Me.Homebase.Visible = False
        '
        'Character4
        '
        Me.Character4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Character4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Character4.ContextMenuStrip = Me.CharMenu2
        Me.Character4.InitialImage = Nothing
        Me.Character4.Location = New System.Drawing.Point(421, 474)
        Me.Character4.MaximumSize = New System.Drawing.Size(168, 120)
        Me.Character4.Name = "Character4"
        Me.Character4.Size = New System.Drawing.Size(108, 77)
        Me.Character4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Character4.TabIndex = 79
        Me.Character4.TabStop = False
        Me.Character4.Visible = False
        '
        'Character3
        '
        Me.Character3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Character3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Character3.ContextMenuStrip = Me.CharMenu
        Me.Character3.InitialImage = Nothing
        Me.Character3.Location = New System.Drawing.Point(551, 374)
        Me.Character3.MaximumSize = New System.Drawing.Size(168, 120)
        Me.Character3.Name = "Character3"
        Me.Character3.Size = New System.Drawing.Size(108, 77)
        Me.Character3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Character3.TabIndex = 78
        Me.Character3.TabStop = False
        Me.Character3.Visible = False
        '
        'Character2
        '
        Me.Character2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Character2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Character2.ContextMenuStrip = Me.CharMenu
        Me.Character2.InitialImage = Nothing
        Me.Character2.Location = New System.Drawing.Point(421, 374)
        Me.Character2.MaximumSize = New System.Drawing.Size(168, 120)
        Me.Character2.Name = "Character2"
        Me.Character2.Size = New System.Drawing.Size(108, 77)
        Me.Character2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Character2.TabIndex = 77
        Me.Character2.TabStop = False
        Me.Character2.Visible = False
        '
        'OppCharacter4
        '
        Me.OppCharacter4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OppCharacter4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OppCharacter4.InitialImage = Nothing
        Me.OppCharacter4.Location = New System.Drawing.Point(551, 44)
        Me.OppCharacter4.MaximumSize = New System.Drawing.Size(168, 120)
        Me.OppCharacter4.Name = "OppCharacter4"
        Me.OppCharacter4.Size = New System.Drawing.Size(108, 77)
        Me.OppCharacter4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.OppCharacter4.TabIndex = 76
        Me.OppCharacter4.TabStop = False
        Me.OppCharacter4.Visible = False
        '
        'Character1
        '
        Me.Character1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Character1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Character1.ContextMenuStrip = Me.CharMenu
        Me.Character1.InitialImage = Nothing
        Me.Character1.Location = New System.Drawing.Point(292, 374)
        Me.Character1.MaximumSize = New System.Drawing.Size(168, 120)
        Me.Character1.Name = "Character1"
        Me.Character1.Size = New System.Drawing.Size(108, 77)
        Me.Character1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Character1.TabIndex = 75
        Me.Character1.TabStop = False
        Me.Character1.Visible = False
        '
        'OppBattlesite
        '
        Me.OppBattlesite.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OppBattlesite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OppBattlesite.InitialImage = Nothing
        Me.OppBattlesite.Location = New System.Drawing.Point(292, 144)
        Me.OppBattlesite.MaximumSize = New System.Drawing.Size(168, 120)
        Me.OppBattlesite.Name = "OppBattlesite"
        Me.OppBattlesite.Size = New System.Drawing.Size(108, 77)
        Me.OppBattlesite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.OppBattlesite.TabIndex = 74
        Me.OppBattlesite.TabStop = False
        Me.OppBattlesite.Visible = False
        '
        'OppHomebase
        '
        Me.OppHomebase.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OppHomebase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OppHomebase.InitialImage = Nothing
        Me.OppHomebase.Location = New System.Drawing.Point(421, 44)
        Me.OppHomebase.MaximumSize = New System.Drawing.Size(168, 120)
        Me.OppHomebase.Name = "OppHomebase"
        Me.OppHomebase.Size = New System.Drawing.Size(108, 77)
        Me.OppHomebase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.OppHomebase.TabIndex = 73
        Me.OppHomebase.TabStop = False
        Me.OppHomebase.Visible = False
        '
        'OppCharacter3
        '
        Me.OppCharacter3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OppCharacter3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OppCharacter3.InitialImage = Nothing
        Me.OppCharacter3.Location = New System.Drawing.Point(680, 144)
        Me.OppCharacter3.MaximumSize = New System.Drawing.Size(168, 120)
        Me.OppCharacter3.Name = "OppCharacter3"
        Me.OppCharacter3.Size = New System.Drawing.Size(108, 77)
        Me.OppCharacter3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.OppCharacter3.TabIndex = 72
        Me.OppCharacter3.TabStop = False
        Me.OppCharacter3.Visible = False
        '
        'OppCharacter2
        '
        Me.OppCharacter2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OppCharacter2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OppCharacter2.InitialImage = Nothing
        Me.OppCharacter2.Location = New System.Drawing.Point(551, 144)
        Me.OppCharacter2.MaximumSize = New System.Drawing.Size(168, 120)
        Me.OppCharacter2.Name = "OppCharacter2"
        Me.OppCharacter2.Size = New System.Drawing.Size(108, 77)
        Me.OppCharacter2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.OppCharacter2.TabIndex = 71
        Me.OppCharacter2.TabStop = False
        Me.OppCharacter2.Visible = False
        '
        'OppCharacter1
        '
        Me.OppCharacter1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OppCharacter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OppCharacter1.InitialImage = Nothing
        Me.OppCharacter1.Location = New System.Drawing.Point(421, 144)
        Me.OppCharacter1.MaximumSize = New System.Drawing.Size(168, 120)
        Me.OppCharacter1.Name = "OppCharacter1"
        Me.OppCharacter1.Size = New System.Drawing.Size(108, 77)
        Me.OppCharacter1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.OppCharacter1.TabIndex = 70
        Me.OppCharacter1.TabStop = False
        Me.OppCharacter1.Visible = False
        '
        'VentureR
        '
        Me.VentureR.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.VentureR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VentureR.InitialImage = Nothing
        Me.VentureR.Location = New System.Drawing.Point(846, 446)
        Me.VentureR.Name = "VentureR"
        Me.VentureR.Size = New System.Drawing.Size(36, 50)
        Me.VentureR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.VentureR.TabIndex = 91
        Me.VentureR.TabStop = False
        Me.VentureR.Visible = False
        '
        'VentureC
        '
        Me.VentureC.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.VentureC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VentureC.InitialImage = Nothing
        Me.VentureC.Location = New System.Drawing.Point(846, 391)
        Me.VentureC.Name = "VentureC"
        Me.VentureC.Size = New System.Drawing.Size(36, 50)
        Me.VentureC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.VentureC.TabIndex = 90
        Me.VentureC.TabStop = False
        Me.VentureC.Visible = False
        '
        'Defeated
        '
        Me.Defeated.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Defeated.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Defeated.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Defeated.InitialImage = Nothing
        Me.Defeated.Location = New System.Drawing.Point(799, 501)
        Me.Defeated.Name = "Defeated"
        Me.Defeated.Size = New System.Drawing.Size(36, 50)
        Me.Defeated.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Defeated.TabIndex = 89
        Me.Defeated.TabStop = False
        Me.Defeated.Visible = False
        '
        'Completed
        '
        Me.Completed.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Completed.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Completed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Completed.InitialImage = Nothing
        Me.Completed.Location = New System.Drawing.Point(799, 391)
        Me.Completed.Name = "Completed"
        Me.Completed.Size = New System.Drawing.Size(36, 50)
        Me.Completed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Completed.TabIndex = 87
        Me.Completed.TabStop = False
        Me.Completed.Visible = False
        '
        'Reserve
        '
        Me.Reserve.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Reserve.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Reserve.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Reserve.Location = New System.Drawing.Point(799, 446)
        Me.Reserve.Name = "Reserve"
        Me.Reserve.Size = New System.Drawing.Size(36, 50)
        Me.Reserve.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Reserve.TabIndex = 88
        Me.Reserve.TabStop = False
        Me.Reserve.Visible = False
        '
        'OverPowerOnline
        '
        Me.AcceptButton = Me.SUBMIT
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1064, 682)
        Me.Controls.Add(Me.BSlistbox)
        Me.Controls.Add(Me.MoveBox)
        Me.Controls.Add(Me.bM)
        Me.Controls.Add(Me.cbFacedown)
        Me.Controls.Add(Me.Mission8)
        Me.Controls.Add(Me.Mission9)
        Me.Controls.Add(Me.Mission10)
        Me.Controls.Add(Me.Mission11)
        Me.Controls.Add(Me.Mission12)
        Me.Controls.Add(Me.Mission13)
        Me.Controls.Add(Me.Mission14)
        Me.Controls.Add(Me.OppReserve)
        Me.Controls.Add(Me.lblOHS)
        Me.Controls.Add(Me.bConcede)
        Me.Controls.Add(Me.bPass)
        Me.Controls.Add(Me.b2P)
        Me.Controls.Add(Me.b2D)
        Me.Controls.Add(Me.bMinusV)
        Me.Controls.Add(Me.bPlusV)
        Me.Controls.Add(Me.bShift)
        Me.Controls.Add(Me.b2R)
        Me.Controls.Add(Me.b2C)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.OppTotalV)
        Me.Controls.Add(Me.MyTotalV)
        Me.Controls.Add(Me.OppVenture)
        Me.Controls.Add(Me.MyVenture)
        Me.Controls.Add(Me.bPlusOpp)
        Me.Controls.Add(Me.bPlusMe)
        Me.Controls.Add(Me.bMinusOpp)
        Me.Controls.Add(Me.bMinusMe)
        Me.Controls.Add(Me.AcceptBox)
        Me.Controls.Add(Me.DefendBox)
        Me.Controls.Add(Me.AttackPanel)
        Me.Controls.Add(Me.AttackBox)
        Me.Controls.Add(Me.bMin)
        Me.Controls.Add(Me.bDefend)
        Me.Controls.Add(Me.bHits)
        Me.Controls.Add(Me.bAttack)
        Me.Controls.Add(Me.bR)
        Me.Controls.Add(Me.bCancel)
        Me.Controls.Add(Me.bChallenge)
        Me.Controls.Add(Me.bAccept)
        Me.Controls.Add(Me.PlaceTextBox)
        Me.Controls.Add(Me.bP)
        Me.Controls.Add(Me.bD)
        Me.Controls.Add(Me.bPlay)
        Me.Controls.Add(Me.bPlace)
        Me.Controls.Add(Me.bDiscard)
        Me.Controls.Add(Me.bPhase)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Phase)
        Me.Controls.Add(Me.BigCardH)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.OppDefeatedChars)
        Me.Controls.Add(Me.DefeatedChars)
        Me.Controls.Add(Me.Mission1)
        Me.Controls.Add(Me.Mission2)
        Me.Controls.Add(Me.Mission3)
        Me.Controls.Add(Me.Mission4)
        Me.Controls.Add(Me.Mission5)
        Me.Controls.Add(Me.Mission6)
        Me.Controls.Add(Me.Mission7)
        Me.Controls.Add(Me.Event1)
        Me.Controls.Add(Me.Event2)
        Me.Controls.Add(Me.OppVentureR)
        Me.Controls.Add(Me.OppVentureC)
        Me.Controls.Add(Me.OppCompleted)
        Me.Controls.Add(Me.OppDefeated)
        Me.Controls.Add(Me.Battlesite)
        Me.Controls.Add(Me.Homebase)
        Me.Controls.Add(Me.Character4)
        Me.Controls.Add(Me.Character3)
        Me.Controls.Add(Me.Character2)
        Me.Controls.Add(Me.OppCharacter4)
        Me.Controls.Add(Me.Character1)
        Me.Controls.Add(Me.OppBattlesite)
        Me.Controls.Add(Me.OppHomebase)
        Me.Controls.Add(Me.OppCharacter3)
        Me.Controls.Add(Me.OppCharacter2)
        Me.Controls.Add(Me.OppCharacter1)
        Me.Controls.Add(Me.CurrentPhase)
        Me.Controls.Add(Me.OppPowerPack)
        Me.Controls.Add(Me.OppDeadPile)
        Me.Controls.Add(Me.OppDrawPile)
        Me.Controls.Add(Me.BigCardV)
        Me.Controls.Add(Me.DeadPile)
        Me.Controls.Add(Me.PowerPack)
        Me.Controls.Add(Me.DrawPile)
        Me.Controls.Add(Me.SUBMIT)
        Me.Controls.Add(Me.TextInput)
        Me.Controls.Add(Me.TextOutput)
        Me.Controls.Add(Me.VentureR)
        Me.Controls.Add(Me.VentureC)
        Me.Controls.Add(Me.Defeated)
        Me.Controls.Add(Me.Completed)
        Me.Controls.Add(Me.Reserve)
        Me.Controls.Add(Me.PlayTextBox)
        Me.Controls.Add(Me.ShapeContainer2)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.MinimumSize = New System.Drawing.Size(1080, 720)
        Me.Name = "OverPowerOnline"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OverPower Online"
        Me.TextOutputMenu.ResumeLayout(False)
        Me.TextInputMenu.ResumeLayout(False)
        CType(Me.DrawPile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PowerPack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeadPile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BigCardV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OppPowerPack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OppDeadPile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OppDrawPile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DefeatedChars, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OppDefeatedChars, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.BigCardH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttackPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AttackPanel.ResumeLayout(False)
        Me.CharMenu2.ResumeLayout(False)
        Me.CharMenu.ResumeLayout(False)
        CType(Me.Mission8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mission9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mission10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mission11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mission12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mission13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mission14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OppReserve, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mission1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mission2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mission3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mission4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mission5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mission6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mission7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Event1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Event2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OppVentureR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OppVentureC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OppCompleted, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OppDefeated, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Battlesite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Homebase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Character4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Character3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Character2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OppCharacter4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Character1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OppBattlesite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OppHomebase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OppCharacter3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OppCharacter2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OppCharacter1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentureR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentureC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Defeated, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Completed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reserve, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SUBMIT As System.Windows.Forms.Button
    Friend WithEvents TextOutput As System.Windows.Forms.RichTextBox
    Friend WithEvents TextInput As System.Windows.Forms.RichTextBox
    Friend WithEvents Undo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Redo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Cut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Copy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Paste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextOutputMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TextOutputCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextInputMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TextInputCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextInputPaste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextInputCut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DrawPile As System.Windows.Forms.PictureBox
    Friend WithEvents PowerPack As System.Windows.Forms.PictureBox
    Friend WithEvents DeadPile As System.Windows.Forms.PictureBox
    Friend WithEvents BigCardV As System.Windows.Forms.PictureBox
    Friend WithEvents OppPowerPack As System.Windows.Forms.PictureBox
    Friend WithEvents OppDeadPile As System.Windows.Forms.PictureBox
    Friend WithEvents OppDrawPile As System.Windows.Forms.PictureBox
    Friend WithEvents CurrentPhase As System.Windows.Forms.Label
    Friend WithEvents OpenDeckToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OppCharacter1 As OverPower.Character
    Friend WithEvents OppCharacter2 As OverPower.Character
    Friend WithEvents OppCharacter3 As OverPower.Character
    Friend WithEvents OppHomebase As OverPower.Location
    Friend WithEvents OppBattlesite As OverPower.Location
    Friend WithEvents Character1 As OverPower.Character
    Friend WithEvents OppCharacter4 As OverPower.Character
    Friend WithEvents Character2 As OverPower.Character
    Friend WithEvents Character3 As OverPower.Character
    Friend WithEvents Character4 As OverPower.Character
    Friend WithEvents Homebase As OverPower.Location
    Friend WithEvents Battlesite As OverPower.Location
    Friend WithEvents OppDefeated As OverPower.Mission
    Friend WithEvents OppReserve As OverPower.Mission
    Friend WithEvents OppCompleted As OverPower.Mission
    Friend WithEvents OppVentureC As OverPower.Mission
    Friend WithEvents OppVentureR As OverPower.Mission
    Friend WithEvents Completed As OverPower.Mission
    Friend WithEvents Reserve As OverPower.Mission
    Friend WithEvents Defeated As OverPower.Mission
    Friend WithEvents VentureC As OverPower.Mission
    Friend WithEvents VentureR As OverPower.Mission
    Friend WithEvents Event2 As OverPower.MissionEvent
    Friend WithEvents Event1 As OverPower.MissionEvent
    Friend WithEvents Mission1 As OverPower.Mission
    Friend WithEvents Mission2 As OverPower.Mission
    Friend WithEvents Mission3 As OverPower.Mission
    Friend WithEvents Mission4 As OverPower.Mission
    Friend WithEvents Mission5 As OverPower.Mission
    Friend WithEvents Mission6 As OverPower.Mission
    Friend WithEvents Mission7 As OverPower.Mission
    Friend WithEvents DefeatedChars As System.Windows.Forms.PictureBox
    Friend WithEvents OppDefeatedChars As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenGameToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BigCardH As System.Windows.Forms.PictureBox
    Friend WithEvents Phase As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents MyDeckToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadDeckToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DrawCardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RematchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShuffleDeckToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ConnectionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bPhase As System.Windows.Forms.Button
    Friend WithEvents bDiscard As System.Windows.Forms.Button
    Friend WithEvents bPlace As System.Windows.Forms.Button
    Friend WithEvents bPlay As System.Windows.Forms.Button
    Friend WithEvents bD As System.Windows.Forms.Button
    Friend WithEvents bP As System.Windows.Forms.Button
    Friend WithEvents PlaceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PlayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents bCancel As System.Windows.Forms.Button
    Friend WithEvents bAccept As System.Windows.Forms.Button
    Friend WithEvents bChallenge As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents AttackBox As System.Windows.Forms.TextBox
    Friend WithEvents bR As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConnectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents bAttack As System.Windows.Forms.Button
    Friend WithEvents DisconnectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bHits As System.Windows.Forms.Button
    Friend WithEvents bDefend As System.Windows.Forms.Button
    Friend WithEvents bMin As System.Windows.Forms.Button
    Friend WithEvents OpponentDeckToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DonateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LinksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ForumsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OverPowercaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WikiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacebookToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TwitterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YouTubeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AttackPanel As System.Windows.Forms.SplitContainer
    Friend WithEvents DefendBox As System.Windows.Forms.TextBox
    Friend WithEvents AcceptBox As System.Windows.Forms.TextBox
    Friend WithEvents bMinusMe As System.Windows.Forms.Button
    Friend WithEvents bMinusOpp As System.Windows.Forms.Button
    Friend WithEvents bPlusMe As System.Windows.Forms.Button
    Friend WithEvents bPlusOpp As System.Windows.Forms.Button
    Friend WithEvents MyVenture As System.Windows.Forms.Label
    Friend WithEvents OppVenture As System.Windows.Forms.Label
    Friend WithEvents MyTotalV As System.Windows.Forms.Label
    Friend WithEvents OppTotalV As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents b2C As System.Windows.Forms.Button
    Friend WithEvents b2R As System.Windows.Forms.Button
    Friend WithEvents bShift As System.Windows.Forms.Button
    Friend WithEvents bPlusV As System.Windows.Forms.Button
    Friend WithEvents bMinusV As System.Windows.Forms.Button
    Friend WithEvents b2D As System.Windows.Forms.Button
    Friend WithEvents b2P As System.Windows.Forms.Button
    Friend WithEvents bPass As System.Windows.Forms.Button
    Friend WithEvents bConcede As System.Windows.Forms.Button
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents lblOHS As System.Windows.Forms.Label
    Friend WithEvents Mission8 As OverPower.Mission
    Friend WithEvents Mission9 As OverPower.Mission
    Friend WithEvents Mission10 As OverPower.Mission
    Friend WithEvents Mission11 As OverPower.Mission
    Friend WithEvents Mission12 As OverPower.Mission
    Friend WithEvents Mission13 As OverPower.Mission
    Friend WithEvents Mission14 As OverPower.Mission
    Friend WithEvents ShowHandToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cbFacedown As System.Windows.Forms.CheckBox
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents AttackFromLine As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents AttackToLine As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents CharMenu2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CharMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents KOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToReserveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bM As System.Windows.Forms.Button
    Friend WithEvents MoveBox As System.Windows.Forms.TextBox
    Friend WithEvents BSlistbox As System.Windows.Forms.ListBox

End Class
