<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCharSheet
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
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtStr = New System.Windows.Forms.TextBox()
        Me.txtDex = New System.Windows.Forms.TextBox()
        Me.txtCon = New System.Windows.Forms.TextBox()
        Me.txtInt = New System.Windows.Forms.TextBox()
        Me.txtWis = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCha = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtHP = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAC = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtMoney = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtInitiative = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCheck = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtAP = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtLevel = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtExp = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cboClass = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cboRace = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cboAlignment = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtCName = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtWepName = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtLoc = New System.Windows.Forms.TextBox()
        Me.ttpHelp = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.btnRandomize = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.pnlCharSheet = New System.Windows.Forms.Panel()
        Me.pbxColor = New System.Windows.Forms.PictureBox()
        Me.btnExp = New System.Windows.Forms.Button()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtCarryCap = New System.Windows.Forms.TextBox()
        Me.btnWrists = New System.Windows.Forms.Button()
        Me.btnFeet = New System.Windows.Forms.Button()
        Me.btnLegs = New System.Windows.Forms.Button()
        Me.btnHands = New System.Windows.Forms.Button()
        Me.btnArms = New System.Windows.Forms.Button()
        Me.btnChest = New System.Windows.Forms.Button()
        Me.btnNeck = New System.Windows.Forms.Button()
        Me.btnHead = New System.Windows.Forms.Button()
        Me.btnSWeap = New System.Windows.Forms.Button()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtWrists = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtFeet = New System.Windows.Forms.TextBox()
        Me.txtLegs = New System.Windows.Forms.TextBox()
        Me.txtHands = New System.Windows.Forms.TextBox()
        Me.txtArms = New System.Windows.Forms.TextBox()
        Me.txtChest = New System.Windows.Forms.TextBox()
        Me.txtNeck = New System.Windows.Forms.TextBox()
        Me.txtHelm = New System.Windows.Forms.TextBox()
        Me.mnuCharSheet = New System.Windows.Forms.MenuStrip()
        Me.mnuChar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWeapon = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuArmor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPowers = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDice = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlCharSheet.SuspendLayout()
        CType(Me.pbxColor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuCharSheet.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCalc
        '
        Me.btnCalc.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCalc.Location = New System.Drawing.Point(15, 566)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 24)
        Me.btnCalc.TabIndex = 40
        Me.btnCalc.Text = "&Save"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(492, 566)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 24)
        Me.btnClose.TabIndex = 44
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'txtStr
        '
        Me.txtStr.Location = New System.Drawing.Point(84, 3)
        Me.txtStr.Name = "txtStr"
        Me.txtStr.Size = New System.Drawing.Size(100, 20)
        Me.txtStr.TabIndex = 2
        Me.txtStr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ttpHelp.SetToolTip(Me.txtStr, "Roll 4d6. Sum the highest three numbers.")
        '
        'txtDex
        '
        Me.txtDex.Location = New System.Drawing.Point(84, 29)
        Me.txtDex.Name = "txtDex"
        Me.txtDex.Size = New System.Drawing.Size(100, 20)
        Me.txtDex.TabIndex = 3
        Me.txtDex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ttpHelp.SetToolTip(Me.txtDex, "Roll 4d6. Sum the highest three numbers.")
        '
        'txtCon
        '
        Me.txtCon.Location = New System.Drawing.Point(84, 55)
        Me.txtCon.Name = "txtCon"
        Me.txtCon.Size = New System.Drawing.Size(100, 20)
        Me.txtCon.TabIndex = 4
        Me.txtCon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ttpHelp.SetToolTip(Me.txtCon, "Roll 4d6. Sum the highest three numbers.")
        '
        'txtInt
        '
        Me.txtInt.Location = New System.Drawing.Point(84, 81)
        Me.txtInt.Name = "txtInt"
        Me.txtInt.Size = New System.Drawing.Size(100, 20)
        Me.txtInt.TabIndex = 5
        Me.txtInt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ttpHelp.SetToolTip(Me.txtInt, "Roll 4d6. Sum the highest three numbers.")
        '
        'txtWis
        '
        Me.txtWis.Location = New System.Drawing.Point(84, 107)
        Me.txtWis.Name = "txtWis"
        Me.txtWis.Size = New System.Drawing.Size(100, 20)
        Me.txtWis.TabIndex = 6
        Me.txtWis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ttpHelp.SetToolTip(Me.txtWis, "Roll 4d6. Sum the highest three numbers.")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Strength"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Dexterity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Constitution"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Intelligence"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Wisdom"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Charisma"
        '
        'txtCha
        '
        Me.txtCha.Location = New System.Drawing.Point(84, 133)
        Me.txtCha.Name = "txtCha"
        Me.txtCha.Size = New System.Drawing.Size(100, 20)
        Me.txtCha.TabIndex = 12
        Me.txtCha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ttpHelp.SetToolTip(Me.txtCha, "Roll 4d6. Sum the highest three numbers.")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 162)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Health"
        '
        'txtHP
        '
        Me.txtHP.Location = New System.Drawing.Point(84, 159)
        Me.txtHP.Name = "txtHP"
        Me.txtHP.Size = New System.Drawing.Size(100, 20)
        Me.txtHP.TabIndex = 14
        Me.txtHP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ttpHelp.SetToolTip(Me.txtHP, "Cleric, Ranger, Rogue, Warlock, Warlord:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Level 1: 12HP" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Gain/level: +5HP" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Figh" & _
        "ter, Paladin: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Level 1: 15HP" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Gain/level: +6HP" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Wizard:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Level 1: 10HP" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Gain/" & _
        "level: +4HP")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 188)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Armor Class"
        '
        'txtAC
        '
        Me.txtAC.Location = New System.Drawing.Point(84, 185)
        Me.txtAC.Name = "txtAC"
        Me.txtAC.Size = New System.Drawing.Size(100, 20)
        Me.txtAC.TabIndex = 16
        Me.txtAC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ttpHelp.SetToolTip(Me.txtAC, "10+(1/2 level) + 1d20 + DexMod")
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 214)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Money(gold)"
        '
        'txtMoney
        '
        Me.txtMoney.Location = New System.Drawing.Point(84, 211)
        Me.txtMoney.MaxLength = 13
        Me.txtMoney.Name = "txtMoney"
        Me.txtMoney.Size = New System.Drawing.Size(100, 20)
        Me.txtMoney.TabIndex = 22
        Me.txtMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 318)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Initiative"
        '
        'txtInitiative
        '
        Me.txtInitiative.Enabled = False
        Me.txtInitiative.Location = New System.Drawing.Point(84, 315)
        Me.txtInitiative.Name = "txtInitiative"
        Me.txtInitiative.Size = New System.Drawing.Size(100, 20)
        Me.txtInitiative.TabIndex = 24
        Me.txtInitiative.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 240)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 13)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Check"
        '
        'txtCheck
        '
        Me.txtCheck.Location = New System.Drawing.Point(84, 237)
        Me.txtCheck.Name = "txtCheck"
        Me.txtCheck.Size = New System.Drawing.Size(100, 20)
        Me.txtCheck.TabIndex = 26
        Me.txtCheck.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(3, 266)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 13)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Action Points"
        '
        'txtAP
        '
        Me.txtAP.Location = New System.Drawing.Point(84, 263)
        Me.txtAP.Name = "txtAP"
        Me.txtAP.Size = New System.Drawing.Size(100, 20)
        Me.txtAP.TabIndex = 28
        Me.txtAP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(263, 240)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(33, 13)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Level"
        '
        'txtLevel
        '
        Me.txtLevel.Location = New System.Drawing.Point(423, 237)
        Me.txtLevel.Name = "txtLevel"
        Me.txtLevel.Size = New System.Drawing.Size(100, 20)
        Me.txtLevel.TabIndex = 38
        Me.txtLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(263, 266)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(60, 13)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "Experience"
        '
        'txtExp
        '
        Me.txtExp.Location = New System.Drawing.Point(423, 263)
        Me.txtExp.Name = "txtExp"
        Me.txtExp.Size = New System.Drawing.Size(100, 20)
        Me.txtExp.TabIndex = 39
        Me.txtExp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(263, 58)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(32, 13)
        Me.Label17.TabIndex = 35
        Me.Label17.Text = "Class"
        Me.ttpHelp.SetToolTip(Me.Label17, "Cleric" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fighter" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Mage" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Thief" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Monk" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Druid" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bard" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Paladin" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ranger" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sorcerer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Barba" & _
        "rian" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Warlock" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Warlord")
        '
        'cboClass
        '
        Me.cboClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboClass.Items.AddRange(New Object() {"Cleric", "Fighter", "Paladin", "Ranger", "Rogue", "Warlock", "Warlord", "Wizard"})
        Me.cboClass.Location = New System.Drawing.Point(423, 55)
        Me.cboClass.MaxLength = 9
        Me.cboClass.Name = "cboClass"
        Me.cboClass.Size = New System.Drawing.Size(100, 21)
        Me.cboClass.TabIndex = 31
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(263, 84)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(33, 13)
        Me.Label18.TabIndex = 37
        Me.Label18.Text = "Race"
        Me.ttpHelp.SetToolTip(Me.Label18, "Human" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Halfling" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Gnome" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Half Orc" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Dwarf" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Half Elf" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Elf")
        '
        'cboRace
        '
        Me.cboRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRace.Items.AddRange(New Object() {"Human", "Halfling", "Gnome", "Half Orc", "Dwarf", "Half Elf", "Elf"})
        Me.cboRace.Location = New System.Drawing.Point(423, 81)
        Me.cboRace.MaxLength = 8
        Me.cboRace.Name = "cboRace"
        Me.cboRace.Size = New System.Drawing.Size(100, 21)
        Me.cboRace.TabIndex = 32
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(263, 110)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(42, 13)
        Me.Label19.TabIndex = 39
        Me.Label19.Text = "Gender"
        Me.ttpHelp.SetToolTip(Me.Label19, "M/F")
        '
        'cboGender
        '
        Me.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGender.Items.AddRange(New Object() {"M", "F"})
        Me.cboGender.Location = New System.Drawing.Point(423, 107)
        Me.cboGender.MaxLength = 1
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(100, 21)
        Me.cboGender.TabIndex = 33
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(263, 136)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(53, 13)
        Me.Label20.TabIndex = 41
        Me.Label20.Text = "Alignment"
        Me.ttpHelp.SetToolTip(Me.Label20, "LG = Lawful Good, TN = True Neutral, CE = Chaotic Evil, etc...")
        '
        'cboAlignment
        '
        Me.cboAlignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAlignment.Items.AddRange(New Object() {"Lawful Good", "Lawful Neutral", "Lawful Evil", "Neutral Good", "True Neutral", "Neutral Evil", "Chaotic Good", "Chaotic Neutral", "Chaotic Evil"})
        Me.cboAlignment.Location = New System.Drawing.Point(423, 133)
        Me.cboAlignment.MaxDropDownItems = 9
        Me.cboAlignment.MaxLength = 15
        Me.cboAlignment.Name = "cboAlignment"
        Me.cboAlignment.Size = New System.Drawing.Size(100, 21)
        Me.cboAlignment.TabIndex = 34
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(263, 6)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(84, 13)
        Me.Label21.TabIndex = 43
        Me.Label21.Text = "Character Name"
        '
        'txtCName
        '
        Me.txtCName.Location = New System.Drawing.Point(353, 3)
        Me.txtCName.MaxLength = 60
        Me.txtCName.Name = "txtCName"
        Me.txtCName.Size = New System.Drawing.Size(170, 20)
        Me.txtCName.TabIndex = 29
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(263, 32)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(79, 13)
        Me.Label22.TabIndex = 45
        Me.Label22.Text = "Weapon Name"
        '
        'txtWepName
        '
        Me.txtWepName.Location = New System.Drawing.Point(353, 29)
        Me.txtWepName.MaxLength = 60
        Me.txtWepName.Name = "txtWepName"
        Me.txtWepName.Size = New System.Drawing.Size(131, 20)
        Me.txtWepName.TabIndex = 30
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(263, 214)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(97, 13)
        Me.Label24.TabIndex = 49
        Me.Label24.Text = "Character Location"
        '
        'txtLoc
        '
        Me.txtLoc.Location = New System.Drawing.Point(423, 211)
        Me.txtLoc.Name = "txtLoc"
        Me.txtLoc.Size = New System.Drawing.Size(100, 20)
        Me.txtLoc.TabIndex = 37
        Me.txtLoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(263, 162)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(31, 13)
        Me.Label25.TabIndex = 51
        Me.Label25.Text = "Color"
        Me.ttpHelp.SetToolTip(Me.Label25, "WUBRG (White, blUe, Black, Red, Green)")
        '
        'txtColor
        '
        Me.txtColor.Location = New System.Drawing.Point(423, 159)
        Me.txtColor.MaxLength = 1
        Me.txtColor.Name = "txtColor"
        Me.txtColor.ReadOnly = True
        Me.txtColor.Size = New System.Drawing.Size(100, 20)
        Me.txtColor.TabIndex = 35
        Me.txtColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ttpHelp.SetToolTip(Me.txtColor, "WUBRG (White, blUe, Black, Red, Green)")
        '
        'btnRandomize
        '
        Me.btnRandomize.Location = New System.Drawing.Point(311, 567)
        Me.btnRandomize.Name = "btnRandomize"
        Me.btnRandomize.Size = New System.Drawing.Size(75, 23)
        Me.btnRandomize.TabIndex = 42
        Me.btnRandomize.Text = "&Randomize"
        Me.ttpHelp.SetToolTip(Me.btnRandomize, "Roll random numbers for your six ability scores")
        Me.btnRandomize.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(172, 567)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 53
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'pnlCharSheet
        '
        Me.pnlCharSheet.Controls.Add(Me.pbxColor)
        Me.pnlCharSheet.Controls.Add(Me.btnExp)
        Me.pnlCharSheet.Controls.Add(Me.Label31)
        Me.pnlCharSheet.Controls.Add(Me.txtCarryCap)
        Me.pnlCharSheet.Controls.Add(Me.btnWrists)
        Me.pnlCharSheet.Controls.Add(Me.btnFeet)
        Me.pnlCharSheet.Controls.Add(Me.btnLegs)
        Me.pnlCharSheet.Controls.Add(Me.btnHands)
        Me.pnlCharSheet.Controls.Add(Me.btnArms)
        Me.pnlCharSheet.Controls.Add(Me.btnChest)
        Me.pnlCharSheet.Controls.Add(Me.btnNeck)
        Me.pnlCharSheet.Controls.Add(Me.btnHead)
        Me.pnlCharSheet.Controls.Add(Me.btnSWeap)
        Me.pnlCharSheet.Controls.Add(Me.Label30)
        Me.pnlCharSheet.Controls.Add(Me.txtWrists)
        Me.pnlCharSheet.Controls.Add(Me.Label29)
        Me.pnlCharSheet.Controls.Add(Me.Label28)
        Me.pnlCharSheet.Controls.Add(Me.Label27)
        Me.pnlCharSheet.Controls.Add(Me.Label26)
        Me.pnlCharSheet.Controls.Add(Me.Label23)
        Me.pnlCharSheet.Controls.Add(Me.Label10)
        Me.pnlCharSheet.Controls.Add(Me.Label9)
        Me.pnlCharSheet.Controls.Add(Me.txtFeet)
        Me.pnlCharSheet.Controls.Add(Me.txtLegs)
        Me.pnlCharSheet.Controls.Add(Me.txtHands)
        Me.pnlCharSheet.Controls.Add(Me.txtArms)
        Me.pnlCharSheet.Controls.Add(Me.txtChest)
        Me.pnlCharSheet.Controls.Add(Me.txtNeck)
        Me.pnlCharSheet.Controls.Add(Me.txtHelm)
        Me.pnlCharSheet.Controls.Add(Me.Label1)
        Me.pnlCharSheet.Controls.Add(Me.txtStr)
        Me.pnlCharSheet.Controls.Add(Me.txtDex)
        Me.pnlCharSheet.Controls.Add(Me.txtCon)
        Me.pnlCharSheet.Controls.Add(Me.txtInt)
        Me.pnlCharSheet.Controls.Add(Me.Label25)
        Me.pnlCharSheet.Controls.Add(Me.txtWis)
        Me.pnlCharSheet.Controls.Add(Me.txtColor)
        Me.pnlCharSheet.Controls.Add(Me.Label2)
        Me.pnlCharSheet.Controls.Add(Me.Label24)
        Me.pnlCharSheet.Controls.Add(Me.Label3)
        Me.pnlCharSheet.Controls.Add(Me.txtLoc)
        Me.pnlCharSheet.Controls.Add(Me.Label4)
        Me.pnlCharSheet.Controls.Add(Me.Label22)
        Me.pnlCharSheet.Controls.Add(Me.Label5)
        Me.pnlCharSheet.Controls.Add(Me.txtWepName)
        Me.pnlCharSheet.Controls.Add(Me.txtCha)
        Me.pnlCharSheet.Controls.Add(Me.Label21)
        Me.pnlCharSheet.Controls.Add(Me.Label6)
        Me.pnlCharSheet.Controls.Add(Me.txtCName)
        Me.pnlCharSheet.Controls.Add(Me.txtHP)
        Me.pnlCharSheet.Controls.Add(Me.Label20)
        Me.pnlCharSheet.Controls.Add(Me.Label7)
        Me.pnlCharSheet.Controls.Add(Me.cboAlignment)
        Me.pnlCharSheet.Controls.Add(Me.txtAC)
        Me.pnlCharSheet.Controls.Add(Me.Label19)
        Me.pnlCharSheet.Controls.Add(Me.Label8)
        Me.pnlCharSheet.Controls.Add(Me.cboGender)
        Me.pnlCharSheet.Controls.Add(Me.txtMoney)
        Me.pnlCharSheet.Controls.Add(Me.Label18)
        Me.pnlCharSheet.Controls.Add(Me.Label11)
        Me.pnlCharSheet.Controls.Add(Me.cboRace)
        Me.pnlCharSheet.Controls.Add(Me.txtInitiative)
        Me.pnlCharSheet.Controls.Add(Me.Label17)
        Me.pnlCharSheet.Controls.Add(Me.Label12)
        Me.pnlCharSheet.Controls.Add(Me.cboClass)
        Me.pnlCharSheet.Controls.Add(Me.txtCheck)
        Me.pnlCharSheet.Controls.Add(Me.Label16)
        Me.pnlCharSheet.Controls.Add(Me.Label13)
        Me.pnlCharSheet.Controls.Add(Me.txtExp)
        Me.pnlCharSheet.Controls.Add(Me.txtAP)
        Me.pnlCharSheet.Controls.Add(Me.Label15)
        Me.pnlCharSheet.Controls.Add(Me.Label14)
        Me.pnlCharSheet.Controls.Add(Me.txtLevel)
        Me.pnlCharSheet.Location = New System.Drawing.Point(16, 27)
        Me.pnlCharSheet.Name = "pnlCharSheet"
        Me.pnlCharSheet.Size = New System.Drawing.Size(552, 520)
        Me.pnlCharSheet.TabIndex = 55
        '
        'pbxColor
        '
        Me.pbxColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxColor.Location = New System.Drawing.Point(391, 159)
        Me.pbxColor.Name = "pbxColor"
        Me.pbxColor.Size = New System.Drawing.Size(26, 20)
        Me.pbxColor.TabIndex = 82
        Me.pbxColor.TabStop = False
        '
        'btnExp
        '
        Me.btnExp.Location = New System.Drawing.Point(379, 261)
        Me.btnExp.Name = "btnExp"
        Me.btnExp.Size = New System.Drawing.Size(38, 23)
        Me.btnExp.TabIndex = 80
        Me.btnExp.Text = "&Exp"
        Me.btnExp.UseVisualStyleBackColor = True
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(3, 292)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(60, 13)
        Me.Label31.TabIndex = 79
        Me.Label31.Text = "Weight(lbs)"
        '
        'txtCarryCap
        '
        Me.txtCarryCap.Location = New System.Drawing.Point(84, 289)
        Me.txtCarryCap.Name = "txtCarryCap"
        Me.txtCarryCap.Size = New System.Drawing.Size(100, 20)
        Me.txtCarryCap.TabIndex = 78
        Me.txtCarryCap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnWrists
        '
        Me.btnWrists.Location = New System.Drawing.Point(492, 471)
        Me.btnWrists.Name = "btnWrists"
        Me.btnWrists.Size = New System.Drawing.Size(32, 19)
        Me.btnWrists.TabIndex = 77
        Me.btnWrists.Tag = "8"
        Me.btnWrists.Text = "Sel"
        Me.btnWrists.UseVisualStyleBackColor = True
        '
        'btnFeet
        '
        Me.btnFeet.Location = New System.Drawing.Point(492, 445)
        Me.btnFeet.Name = "btnFeet"
        Me.btnFeet.Size = New System.Drawing.Size(32, 19)
        Me.btnFeet.TabIndex = 76
        Me.btnFeet.Tag = "7"
        Me.btnFeet.Text = "Sel"
        Me.btnFeet.UseVisualStyleBackColor = True
        '
        'btnLegs
        '
        Me.btnLegs.Location = New System.Drawing.Point(492, 419)
        Me.btnLegs.Name = "btnLegs"
        Me.btnLegs.Size = New System.Drawing.Size(32, 19)
        Me.btnLegs.TabIndex = 75
        Me.btnLegs.Tag = "6"
        Me.btnLegs.Text = "Sel"
        Me.btnLegs.UseVisualStyleBackColor = True
        '
        'btnHands
        '
        Me.btnHands.Location = New System.Drawing.Point(492, 393)
        Me.btnHands.Name = "btnHands"
        Me.btnHands.Size = New System.Drawing.Size(32, 19)
        Me.btnHands.TabIndex = 74
        Me.btnHands.Tag = "5"
        Me.btnHands.Text = "Sel"
        Me.btnHands.UseVisualStyleBackColor = True
        '
        'btnArms
        '
        Me.btnArms.Location = New System.Drawing.Point(492, 367)
        Me.btnArms.Name = "btnArms"
        Me.btnArms.Size = New System.Drawing.Size(32, 19)
        Me.btnArms.TabIndex = 73
        Me.btnArms.Tag = "4"
        Me.btnArms.Text = "Sel"
        Me.btnArms.UseVisualStyleBackColor = True
        '
        'btnChest
        '
        Me.btnChest.Location = New System.Drawing.Point(492, 341)
        Me.btnChest.Name = "btnChest"
        Me.btnChest.Size = New System.Drawing.Size(32, 19)
        Me.btnChest.TabIndex = 72
        Me.btnChest.Tag = "3"
        Me.btnChest.Text = "Sel"
        Me.btnChest.UseVisualStyleBackColor = True
        '
        'btnNeck
        '
        Me.btnNeck.Location = New System.Drawing.Point(492, 315)
        Me.btnNeck.Name = "btnNeck"
        Me.btnNeck.Size = New System.Drawing.Size(32, 19)
        Me.btnNeck.TabIndex = 71
        Me.btnNeck.Tag = "2"
        Me.btnNeck.Text = "Sel"
        Me.btnNeck.UseVisualStyleBackColor = True
        '
        'btnHead
        '
        Me.btnHead.Location = New System.Drawing.Point(492, 288)
        Me.btnHead.Name = "btnHead"
        Me.btnHead.Size = New System.Drawing.Size(32, 19)
        Me.btnHead.TabIndex = 70
        Me.btnHead.Tag = "1"
        Me.btnHead.Text = "Sel"
        Me.btnHead.UseVisualStyleBackColor = True
        '
        'btnSWeap
        '
        Me.btnSWeap.Location = New System.Drawing.Point(491, 29)
        Me.btnSWeap.Name = "btnSWeap"
        Me.btnSWeap.Size = New System.Drawing.Size(32, 19)
        Me.btnSWeap.TabIndex = 69
        Me.btnSWeap.Text = "Sel"
        Me.btnSWeap.UseVisualStyleBackColor = True
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(264, 474)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(36, 13)
        Me.Label30.TabIndex = 68
        Me.Label30.Text = "Wrists"
        '
        'txtWrists
        '
        Me.txtWrists.Location = New System.Drawing.Point(354, 471)
        Me.txtWrists.Name = "txtWrists"
        Me.txtWrists.Size = New System.Drawing.Size(131, 20)
        Me.txtWrists.TabIndex = 67
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(264, 318)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(33, 13)
        Me.Label29.TabIndex = 66
        Me.Label29.Text = "Neck"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(264, 448)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(28, 13)
        Me.Label28.TabIndex = 65
        Me.Label28.Text = "Feet"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(264, 396)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(38, 13)
        Me.Label27.TabIndex = 64
        Me.Label27.Text = "Hands"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(264, 370)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(30, 13)
        Me.Label26.TabIndex = 63
        Me.Label26.Text = "Arms"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(264, 422)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(30, 13)
        Me.Label23.TabIndex = 62
        Me.Label23.Text = "Legs"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(264, 344)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "Chest"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(265, 292)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "Helm"
        '
        'txtFeet
        '
        Me.txtFeet.Location = New System.Drawing.Point(354, 445)
        Me.txtFeet.Name = "txtFeet"
        Me.txtFeet.Size = New System.Drawing.Size(131, 20)
        Me.txtFeet.TabIndex = 59
        '
        'txtLegs
        '
        Me.txtLegs.Location = New System.Drawing.Point(354, 419)
        Me.txtLegs.Name = "txtLegs"
        Me.txtLegs.Size = New System.Drawing.Size(131, 20)
        Me.txtLegs.TabIndex = 58
        '
        'txtHands
        '
        Me.txtHands.Location = New System.Drawing.Point(354, 393)
        Me.txtHands.Name = "txtHands"
        Me.txtHands.Size = New System.Drawing.Size(131, 20)
        Me.txtHands.TabIndex = 57
        '
        'txtArms
        '
        Me.txtArms.Location = New System.Drawing.Point(354, 367)
        Me.txtArms.Name = "txtArms"
        Me.txtArms.Size = New System.Drawing.Size(131, 20)
        Me.txtArms.TabIndex = 56
        '
        'txtChest
        '
        Me.txtChest.Location = New System.Drawing.Point(353, 341)
        Me.txtChest.Name = "txtChest"
        Me.txtChest.Size = New System.Drawing.Size(131, 20)
        Me.txtChest.TabIndex = 55
        '
        'txtNeck
        '
        Me.txtNeck.Location = New System.Drawing.Point(354, 315)
        Me.txtNeck.Name = "txtNeck"
        Me.txtNeck.Size = New System.Drawing.Size(131, 20)
        Me.txtNeck.TabIndex = 54
        '
        'txtHelm
        '
        Me.txtHelm.Location = New System.Drawing.Point(353, 289)
        Me.txtHelm.Name = "txtHelm"
        Me.txtHelm.Size = New System.Drawing.Size(131, 20)
        Me.txtHelm.TabIndex = 53
        '
        'mnuCharSheet
        '
        Me.mnuCharSheet.BackColor = System.Drawing.SystemColors.ControlLight
        Me.mnuCharSheet.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuChar, Me.mnuPrint, Me.mnuHelp})
        Me.mnuCharSheet.Location = New System.Drawing.Point(0, 0)
        Me.mnuCharSheet.Name = "mnuCharSheet"
        Me.mnuCharSheet.Size = New System.Drawing.Size(580, 24)
        Me.mnuCharSheet.TabIndex = 81
        Me.mnuCharSheet.Text = "MenuStrip1"
        '
        'mnuChar
        '
        Me.mnuChar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuWeapon, Me.mnuArmor, Me.mnuPowers, Me.mnuDice, Me.ToolStripSeparator1, Me.mnuSave, Me.mnuClose})
        Me.mnuChar.Name = "mnuChar"
        Me.mnuChar.Size = New System.Drawing.Size(82, 20)
        Me.mnuChar.Text = "&Information"
        '
        'mnuWeapon
        '
        Me.mnuWeapon.Name = "mnuWeapon"
        Me.mnuWeapon.Size = New System.Drawing.Size(152, 22)
        Me.mnuWeapon.Text = "&Weapons"
        '
        'mnuArmor
        '
        Me.mnuArmor.Name = "mnuArmor"
        Me.mnuArmor.Size = New System.Drawing.Size(152, 22)
        Me.mnuArmor.Text = "&Armor"
        '
        'mnuPowers
        '
        Me.mnuPowers.Name = "mnuPowers"
        Me.mnuPowers.Size = New System.Drawing.Size(152, 22)
        Me.mnuPowers.Text = "&Powers"
        '
        'mnuDice
        '
        Me.mnuDice.Name = "mnuDice"
        Me.mnuDice.Size = New System.Drawing.Size(152, 22)
        Me.mnuDice.Text = "Show &Dice"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'mnuSave
        '
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.Size = New System.Drawing.Size(152, 22)
        Me.mnuSave.Text = "&Save"
        '
        'mnuClose
        '
        Me.mnuClose.Name = "mnuClose"
        Me.mnuClose.Size = New System.Drawing.Size(152, 22)
        Me.mnuClose.Text = "&Close"
        '
        'mnuPrint
        '
        Me.mnuPrint.Name = "mnuPrint"
        Me.mnuPrint.Size = New System.Drawing.Size(44, 20)
        Me.mnuPrint.Text = "&Print"
        '
        'mnuHelp
        '
        Me.mnuHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "&Help"
        Me.mnuHelp.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'frmCharSheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 602)
        Me.Controls.Add(Me.pnlCharSheet)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnRandomize)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.mnuCharSheet)
        Me.MainMenuStrip = Me.mnuCharSheet
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCharSheet"
        Me.Text = "Character Sheet"
        Me.pnlCharSheet.ResumeLayout(False)
        Me.pnlCharSheet.PerformLayout()
        CType(Me.pbxColor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuCharSheet.ResumeLayout(False)
        Me.mnuCharSheet.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents ttpHelp As System.Windows.Forms.ToolTip
    Friend WithEvents btnRandomize As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents pnlCharSheet As System.Windows.Forms.Panel
    Public WithEvents txtDex As System.Windows.Forms.TextBox
    Public WithEvents txtCon As System.Windows.Forms.TextBox
    Public WithEvents txtInt As System.Windows.Forms.TextBox
    Public WithEvents txtWis As System.Windows.Forms.TextBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents txtCha As System.Windows.Forms.TextBox
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents txtHP As System.Windows.Forms.TextBox
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents txtAC As System.Windows.Forms.TextBox
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents txtMoney As System.Windows.Forms.TextBox
    Public WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents txtInitiative As System.Windows.Forms.TextBox
    Public WithEvents Label13 As System.Windows.Forms.Label
    Public WithEvents txtCheck As System.Windows.Forms.TextBox
    Public WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents txtAP As System.Windows.Forms.TextBox
    Public WithEvents Label15 As System.Windows.Forms.Label
    Public WithEvents txtLevel As System.Windows.Forms.TextBox
    Public WithEvents Label16 As System.Windows.Forms.Label
    Public WithEvents txtExp As System.Windows.Forms.TextBox
    Public WithEvents Label17 As System.Windows.Forms.Label
    Public WithEvents Label18 As System.Windows.Forms.Label
    Public WithEvents cboRace As System.Windows.Forms.ComboBox
    Public WithEvents Label19 As System.Windows.Forms.Label
    Public WithEvents cboGender As System.Windows.Forms.ComboBox
    Public WithEvents Label20 As System.Windows.Forms.Label
    Public WithEvents cboAlignment As System.Windows.Forms.ComboBox
    Public WithEvents Label21 As System.Windows.Forms.Label
    Public WithEvents txtCName As System.Windows.Forms.TextBox
    Public WithEvents Label22 As System.Windows.Forms.Label
    Public WithEvents Label24 As System.Windows.Forms.Label
    Public WithEvents txtLoc As System.Windows.Forms.TextBox
    Public WithEvents Label25 As System.Windows.Forms.Label
    Public WithEvents txtColor As System.Windows.Forms.TextBox
    Public WithEvents txtWepName As System.Windows.Forms.TextBox
    Public WithEvents txtStr As System.Windows.Forms.TextBox
    Public WithEvents Label29 As System.Windows.Forms.Label
    Public WithEvents Label28 As System.Windows.Forms.Label
    Public WithEvents Label27 As System.Windows.Forms.Label
    Public WithEvents Label26 As System.Windows.Forms.Label
    Public WithEvents Label23 As System.Windows.Forms.Label
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents txtFeet As System.Windows.Forms.TextBox
    Public WithEvents txtLegs As System.Windows.Forms.TextBox
    Public WithEvents txtHands As System.Windows.Forms.TextBox
    Public WithEvents txtArms As System.Windows.Forms.TextBox
    Public WithEvents txtChest As System.Windows.Forms.TextBox
    Public WithEvents txtNeck As System.Windows.Forms.TextBox
    Public WithEvents txtHelm As System.Windows.Forms.TextBox
    Public WithEvents Label30 As System.Windows.Forms.Label
    Public WithEvents txtWrists As System.Windows.Forms.TextBox
    Public WithEvents btnWrists As System.Windows.Forms.Button
    Public WithEvents btnFeet As System.Windows.Forms.Button
    Public WithEvents btnLegs As System.Windows.Forms.Button
    Public WithEvents btnHands As System.Windows.Forms.Button
    Public WithEvents btnArms As System.Windows.Forms.Button
    Public WithEvents btnChest As System.Windows.Forms.Button
    Public WithEvents btnNeck As System.Windows.Forms.Button
    Public WithEvents btnHead As System.Windows.Forms.Button
    Public WithEvents btnSWeap As System.Windows.Forms.Button
    Public WithEvents Label31 As System.Windows.Forms.Label
    Public WithEvents txtCarryCap As System.Windows.Forms.TextBox
    Friend WithEvents btnExp As System.Windows.Forms.Button
    Friend WithEvents pbxColor As System.Windows.Forms.PictureBox
    Public WithEvents cboClass As System.Windows.Forms.ComboBox
    Friend WithEvents mnuCharSheet As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuChar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPowers As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuWeapon As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuArmor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuClose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDice As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator

End Class
