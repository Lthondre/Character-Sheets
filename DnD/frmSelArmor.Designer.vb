<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelArmor
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
        Me.dgvHead = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.tabArmor = New System.Windows.Forms.TabControl()
        Me.tabAll = New System.Windows.Forms.TabPage()
        Me.dgvArmor = New System.Windows.Forms.DataGridView()
        Me.tabHelm = New System.Windows.Forms.TabPage()
        Me.tabNeck = New System.Windows.Forms.TabPage()
        Me.dgvNeck = New System.Windows.Forms.DataGridView()
        Me.tabChest = New System.Windows.Forms.TabPage()
        Me.dgvChest = New System.Windows.Forms.DataGridView()
        Me.tabArms = New System.Windows.Forms.TabPage()
        Me.dgvArms = New System.Windows.Forms.DataGridView()
        Me.tabWrists = New System.Windows.Forms.TabPage()
        Me.dgvWrists = New System.Windows.Forms.DataGridView()
        Me.tabHands = New System.Windows.Forms.TabPage()
        Me.dgvHands = New System.Windows.Forms.DataGridView()
        Me.tabLegs = New System.Windows.Forms.TabPage()
        Me.dgvLegs = New System.Windows.Forms.DataGridView()
        Me.tabFeet = New System.Windows.Forms.TabPage()
        Me.dgvFeet = New System.Windows.Forms.DataGridView()
        Me.allID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.allName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.allWgt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.allArm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.allChk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.allPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.allAC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.allType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.allStr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.allDex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.allWis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.allCha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.allInt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.allCon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.headID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.headName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.headWgt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.headAC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.headChk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.headPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.headClass = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.headType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.headStr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.headDex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.headWis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.headCha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.headInt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.headCon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.neckID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.neckName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.neckWgt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.neckArm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.neckChk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.neckPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.neckAC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.neckType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.neckStr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.neckDex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.neckWis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.neckCha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.neckInt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.neckCon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chestID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chestName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chestWgt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chestArm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chestChk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chestPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chestAC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chestType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chestStr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chestDex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chestWis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chestCha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chestInt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chestCon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.armID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.armName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.armWgt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.armArm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.armChk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.armPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.armAC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.armType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.armStr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.armDex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.armWis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.armCha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.armInt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.armCon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.wristID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.wristName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.wristWgt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.wristArm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.wristChk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.wristPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.wristAC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.wristType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.wristStr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.wristDex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.wristWis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.wristCha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.wristInt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.wristCon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.handID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.handName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.handWgt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.handArm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.handChk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.handPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.handAC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.handType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.handStr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.handDex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.handWis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.handCha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.handInt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.handCon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.legID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.legName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.legWgt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.legArm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.legChk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.legPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.legAC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.legType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.legStr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.legDex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.legWis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.legCha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.legInt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.legCon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.feetID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.feetName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.feetWgt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.feetArm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.feetChk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.feetPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.feetAC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.feetType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.feetStr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.feetDex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.feetWis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.feetCha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.feetInt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.feetCon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvHead, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabArmor.SuspendLayout()
        Me.tabAll.SuspendLayout()
        CType(Me.dgvArmor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabHelm.SuspendLayout()
        Me.tabNeck.SuspendLayout()
        CType(Me.dgvNeck, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabChest.SuspendLayout()
        CType(Me.dgvChest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabArms.SuspendLayout()
        CType(Me.dgvArms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabWrists.SuspendLayout()
        CType(Me.dgvWrists, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabHands.SuspendLayout()
        CType(Me.dgvHands, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabLegs.SuspendLayout()
        CType(Me.dgvLegs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabFeet.SuspendLayout()
        CType(Me.dgvFeet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvHead
        '
        Me.dgvHead.AllowUserToDeleteRows = False
        Me.dgvHead.AllowUserToResizeColumns = False
        Me.dgvHead.AllowUserToResizeRows = False
        Me.dgvHead.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvHead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHead.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.headID, Me.headName, Me.headWgt, Me.headAC, Me.headChk, Me.headPrice, Me.headClass, Me.headType, Me.headStr, Me.headDex, Me.headWis, Me.headCha, Me.headInt, Me.headCon})
        Me.dgvHead.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvHead.Location = New System.Drawing.Point(3, 3)
        Me.dgvHead.MultiSelect = False
        Me.dgvHead.Name = "dgvHead"
        Me.dgvHead.ReadOnly = True
        Me.dgvHead.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvHead.Size = New System.Drawing.Size(1291, 274)
        Me.dgvHead.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(12, 312)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(631, 312)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'tabArmor
        '
        Me.tabArmor.Controls.Add(Me.tabAll)
        Me.tabArmor.Controls.Add(Me.tabHelm)
        Me.tabArmor.Controls.Add(Me.tabNeck)
        Me.tabArmor.Controls.Add(Me.tabChest)
        Me.tabArmor.Controls.Add(Me.tabArms)
        Me.tabArmor.Controls.Add(Me.tabWrists)
        Me.tabArmor.Controls.Add(Me.tabHands)
        Me.tabArmor.Controls.Add(Me.tabLegs)
        Me.tabArmor.Controls.Add(Me.tabFeet)
        Me.tabArmor.Dock = System.Windows.Forms.DockStyle.Top
        Me.tabArmor.HotTrack = True
        Me.tabArmor.Location = New System.Drawing.Point(0, 0)
        Me.tabArmor.Name = "tabArmor"
        Me.tabArmor.SelectedIndex = 0
        Me.tabArmor.Size = New System.Drawing.Size(1305, 306)
        Me.tabArmor.TabIndex = 5
        '
        'tabAll
        '
        Me.tabAll.Controls.Add(Me.dgvArmor)
        Me.tabAll.Location = New System.Drawing.Point(4, 22)
        Me.tabAll.Name = "tabAll"
        Me.tabAll.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAll.Size = New System.Drawing.Size(1297, 280)
        Me.tabAll.TabIndex = 2
        Me.tabAll.Text = "All"
        Me.tabAll.UseVisualStyleBackColor = True
        '
        'dgvArmor
        '
        Me.dgvArmor.AllowUserToDeleteRows = False
        Me.dgvArmor.AllowUserToResizeColumns = False
        Me.dgvArmor.AllowUserToResizeRows = False
        Me.dgvArmor.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvArmor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvArmor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.allID, Me.allName, Me.allWgt, Me.allArm, Me.allChk, Me.allPrice, Me.allAC, Me.allType, Me.allStr, Me.allDex, Me.allWis, Me.allCha, Me.allInt, Me.allCon})
        Me.dgvArmor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvArmor.Location = New System.Drawing.Point(3, 3)
        Me.dgvArmor.MultiSelect = False
        Me.dgvArmor.Name = "dgvArmor"
        Me.dgvArmor.ReadOnly = True
        Me.dgvArmor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvArmor.Size = New System.Drawing.Size(1291, 274)
        Me.dgvArmor.TabIndex = 6
        '
        'tabHelm
        '
        Me.tabHelm.Controls.Add(Me.dgvHead)
        Me.tabHelm.Location = New System.Drawing.Point(4, 22)
        Me.tabHelm.Name = "tabHelm"
        Me.tabHelm.Padding = New System.Windows.Forms.Padding(3)
        Me.tabHelm.Size = New System.Drawing.Size(1297, 280)
        Me.tabHelm.TabIndex = 0
        Me.tabHelm.Text = "Head"
        Me.tabHelm.UseVisualStyleBackColor = True
        '
        'tabNeck
        '
        Me.tabNeck.Controls.Add(Me.dgvNeck)
        Me.tabNeck.Location = New System.Drawing.Point(4, 22)
        Me.tabNeck.Name = "tabNeck"
        Me.tabNeck.Padding = New System.Windows.Forms.Padding(3)
        Me.tabNeck.Size = New System.Drawing.Size(1297, 280)
        Me.tabNeck.TabIndex = 7
        Me.tabNeck.Text = "Neck"
        Me.tabNeck.UseVisualStyleBackColor = True
        '
        'dgvNeck
        '
        Me.dgvNeck.AllowUserToDeleteRows = False
        Me.dgvNeck.AllowUserToResizeColumns = False
        Me.dgvNeck.AllowUserToResizeRows = False
        Me.dgvNeck.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvNeck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNeck.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.neckID, Me.neckName, Me.neckWgt, Me.neckArm, Me.neckChk, Me.neckPrice, Me.neckAC, Me.neckType, Me.neckStr, Me.neckDex, Me.neckWis, Me.neckCha, Me.neckInt, Me.neckCon})
        Me.dgvNeck.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvNeck.Location = New System.Drawing.Point(3, 3)
        Me.dgvNeck.MultiSelect = False
        Me.dgvNeck.Name = "dgvNeck"
        Me.dgvNeck.ReadOnly = True
        Me.dgvNeck.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvNeck.Size = New System.Drawing.Size(1291, 274)
        Me.dgvNeck.TabIndex = 6
        '
        'tabChest
        '
        Me.tabChest.Controls.Add(Me.dgvChest)
        Me.tabChest.Location = New System.Drawing.Point(4, 22)
        Me.tabChest.Name = "tabChest"
        Me.tabChest.Padding = New System.Windows.Forms.Padding(3)
        Me.tabChest.Size = New System.Drawing.Size(1297, 280)
        Me.tabChest.TabIndex = 1
        Me.tabChest.Text = "Chest"
        Me.tabChest.UseVisualStyleBackColor = True
        '
        'dgvChest
        '
        Me.dgvChest.AllowUserToDeleteRows = False
        Me.dgvChest.AllowUserToResizeColumns = False
        Me.dgvChest.AllowUserToResizeRows = False
        Me.dgvChest.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvChest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvChest.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chestID, Me.chestName, Me.chestWgt, Me.chestArm, Me.chestChk, Me.chestPrice, Me.chestAC, Me.chestType, Me.chestStr, Me.chestDex, Me.chestWis, Me.chestCha, Me.chestInt, Me.chestCon})
        Me.dgvChest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvChest.Location = New System.Drawing.Point(3, 3)
        Me.dgvChest.MultiSelect = False
        Me.dgvChest.Name = "dgvChest"
        Me.dgvChest.ReadOnly = True
        Me.dgvChest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvChest.Size = New System.Drawing.Size(1291, 274)
        Me.dgvChest.TabIndex = 6
        '
        'tabArms
        '
        Me.tabArms.Controls.Add(Me.dgvArms)
        Me.tabArms.Location = New System.Drawing.Point(4, 22)
        Me.tabArms.Name = "tabArms"
        Me.tabArms.Padding = New System.Windows.Forms.Padding(3)
        Me.tabArms.Size = New System.Drawing.Size(1297, 280)
        Me.tabArms.TabIndex = 4
        Me.tabArms.Text = "Arms"
        Me.tabArms.UseVisualStyleBackColor = True
        '
        'dgvArms
        '
        Me.dgvArms.AllowUserToDeleteRows = False
        Me.dgvArms.AllowUserToResizeColumns = False
        Me.dgvArms.AllowUserToResizeRows = False
        Me.dgvArms.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvArms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvArms.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.armID, Me.armName, Me.armWgt, Me.armArm, Me.armChk, Me.armPrice, Me.armAC, Me.armType, Me.armStr, Me.armDex, Me.armWis, Me.armCha, Me.armInt, Me.armCon})
        Me.dgvArms.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvArms.Location = New System.Drawing.Point(3, 3)
        Me.dgvArms.MultiSelect = False
        Me.dgvArms.Name = "dgvArms"
        Me.dgvArms.ReadOnly = True
        Me.dgvArms.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvArms.Size = New System.Drawing.Size(1291, 274)
        Me.dgvArms.TabIndex = 7
        '
        'tabWrists
        '
        Me.tabWrists.Controls.Add(Me.dgvWrists)
        Me.tabWrists.Location = New System.Drawing.Point(4, 22)
        Me.tabWrists.Name = "tabWrists"
        Me.tabWrists.Padding = New System.Windows.Forms.Padding(3)
        Me.tabWrists.Size = New System.Drawing.Size(1297, 280)
        Me.tabWrists.TabIndex = 8
        Me.tabWrists.Text = "Wrists"
        Me.tabWrists.UseVisualStyleBackColor = True
        '
        'dgvWrists
        '
        Me.dgvWrists.AllowUserToDeleteRows = False
        Me.dgvWrists.AllowUserToResizeColumns = False
        Me.dgvWrists.AllowUserToResizeRows = False
        Me.dgvWrists.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvWrists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvWrists.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.wristID, Me.wristName, Me.wristWgt, Me.wristArm, Me.wristChk, Me.wristPrice, Me.wristAC, Me.wristType, Me.wristStr, Me.wristDex, Me.wristWis, Me.wristCha, Me.wristInt, Me.wristCon})
        Me.dgvWrists.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvWrists.Location = New System.Drawing.Point(3, 3)
        Me.dgvWrists.MultiSelect = False
        Me.dgvWrists.Name = "dgvWrists"
        Me.dgvWrists.ReadOnly = True
        Me.dgvWrists.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvWrists.Size = New System.Drawing.Size(1291, 274)
        Me.dgvWrists.TabIndex = 7
        '
        'tabHands
        '
        Me.tabHands.Controls.Add(Me.dgvHands)
        Me.tabHands.Location = New System.Drawing.Point(4, 22)
        Me.tabHands.Name = "tabHands"
        Me.tabHands.Padding = New System.Windows.Forms.Padding(3)
        Me.tabHands.Size = New System.Drawing.Size(1297, 280)
        Me.tabHands.TabIndex = 6
        Me.tabHands.Text = "Hands"
        Me.tabHands.UseVisualStyleBackColor = True
        '
        'dgvHands
        '
        Me.dgvHands.AllowUserToDeleteRows = False
        Me.dgvHands.AllowUserToResizeColumns = False
        Me.dgvHands.AllowUserToResizeRows = False
        Me.dgvHands.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvHands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHands.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.handID, Me.handName, Me.handWgt, Me.handArm, Me.handChk, Me.handPrice, Me.handAC, Me.handType, Me.handStr, Me.handDex, Me.handWis, Me.handCha, Me.handInt, Me.handCon})
        Me.dgvHands.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvHands.Location = New System.Drawing.Point(3, 3)
        Me.dgvHands.MultiSelect = False
        Me.dgvHands.Name = "dgvHands"
        Me.dgvHands.ReadOnly = True
        Me.dgvHands.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvHands.Size = New System.Drawing.Size(1291, 274)
        Me.dgvHands.TabIndex = 7
        '
        'tabLegs
        '
        Me.tabLegs.Controls.Add(Me.dgvLegs)
        Me.tabLegs.Location = New System.Drawing.Point(4, 22)
        Me.tabLegs.Name = "tabLegs"
        Me.tabLegs.Padding = New System.Windows.Forms.Padding(3)
        Me.tabLegs.Size = New System.Drawing.Size(1297, 280)
        Me.tabLegs.TabIndex = 3
        Me.tabLegs.Text = "Legs"
        Me.tabLegs.UseVisualStyleBackColor = True
        '
        'dgvLegs
        '
        Me.dgvLegs.AllowUserToDeleteRows = False
        Me.dgvLegs.AllowUserToResizeColumns = False
        Me.dgvLegs.AllowUserToResizeRows = False
        Me.dgvLegs.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvLegs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLegs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.legID, Me.legName, Me.legWgt, Me.legArm, Me.legChk, Me.legPrice, Me.legAC, Me.legType, Me.legStr, Me.legDex, Me.legWis, Me.legCha, Me.legInt, Me.legCon})
        Me.dgvLegs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLegs.Location = New System.Drawing.Point(3, 3)
        Me.dgvLegs.MultiSelect = False
        Me.dgvLegs.Name = "dgvLegs"
        Me.dgvLegs.ReadOnly = True
        Me.dgvLegs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvLegs.Size = New System.Drawing.Size(1291, 274)
        Me.dgvLegs.TabIndex = 7
        '
        'tabFeet
        '
        Me.tabFeet.Controls.Add(Me.dgvFeet)
        Me.tabFeet.Location = New System.Drawing.Point(4, 22)
        Me.tabFeet.Name = "tabFeet"
        Me.tabFeet.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFeet.Size = New System.Drawing.Size(1297, 280)
        Me.tabFeet.TabIndex = 5
        Me.tabFeet.Text = "Feet"
        Me.tabFeet.UseVisualStyleBackColor = True
        '
        'dgvFeet
        '
        Me.dgvFeet.AllowUserToDeleteRows = False
        Me.dgvFeet.AllowUserToResizeColumns = False
        Me.dgvFeet.AllowUserToResizeRows = False
        Me.dgvFeet.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvFeet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFeet.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.feetID, Me.feetName, Me.feetWgt, Me.feetArm, Me.feetChk, Me.feetPrice, Me.feetAC, Me.feetType, Me.feetStr, Me.feetDex, Me.feetWis, Me.feetCha, Me.feetInt, Me.feetCon})
        Me.dgvFeet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvFeet.Location = New System.Drawing.Point(3, 3)
        Me.dgvFeet.MultiSelect = False
        Me.dgvFeet.Name = "dgvFeet"
        Me.dgvFeet.ReadOnly = True
        Me.dgvFeet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvFeet.Size = New System.Drawing.Size(1291, 274)
        Me.dgvFeet.TabIndex = 7
        '
        'allID
        '
        Me.allID.HeaderText = "aID"
        Me.allID.Name = "allID"
        Me.allID.ReadOnly = True
        Me.allID.Visible = False
        '
        'allName
        '
        Me.allName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.allName.HeaderText = "Name"
        Me.allName.Name = "allName"
        Me.allName.ReadOnly = True
        '
        'allWgt
        '
        Me.allWgt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.allWgt.HeaderText = "Weight"
        Me.allWgt.Name = "allWgt"
        Me.allWgt.ReadOnly = True
        Me.allWgt.Width = 66
        '
        'allArm
        '
        Me.allArm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.allArm.HeaderText = "Armor Bonus"
        Me.allArm.Name = "allArm"
        Me.allArm.ReadOnly = True
        Me.allArm.Width = 92
        '
        'allChk
        '
        Me.allChk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.allChk.HeaderText = "Check Modifier"
        Me.allChk.Name = "allChk"
        Me.allChk.ReadOnly = True
        Me.allChk.Width = 95
        '
        'allPrice
        '
        Me.allPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.allPrice.HeaderText = "Price"
        Me.allPrice.Name = "allPrice"
        Me.allPrice.ReadOnly = True
        Me.allPrice.Width = 56
        '
        'allAC
        '
        Me.allAC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.allAC.HeaderText = "Armor Class"
        Me.allAC.Name = "allAC"
        Me.allAC.ReadOnly = True
        Me.allAC.Width = 80
        '
        'allType
        '
        Me.allType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.allType.HeaderText = "Armor Spot"
        Me.allType.Name = "allType"
        Me.allType.ReadOnly = True
        Me.allType.Width = 78
        '
        'allStr
        '
        Me.allStr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.allStr.HeaderText = "Strength"
        Me.allStr.Name = "allStr"
        Me.allStr.ReadOnly = True
        Me.allStr.Width = 72
        '
        'allDex
        '
        Me.allDex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.allDex.HeaderText = "Dexterity"
        Me.allDex.Name = "allDex"
        Me.allDex.ReadOnly = True
        Me.allDex.Width = 73
        '
        'allWis
        '
        Me.allWis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.allWis.HeaderText = "Wisdom"
        Me.allWis.Name = "allWis"
        Me.allWis.ReadOnly = True
        Me.allWis.Width = 70
        '
        'allCha
        '
        Me.allCha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.allCha.HeaderText = "Charisma"
        Me.allCha.Name = "allCha"
        Me.allCha.ReadOnly = True
        Me.allCha.Width = 75
        '
        'allInt
        '
        Me.allInt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.allInt.HeaderText = "Intelligence"
        Me.allInt.Name = "allInt"
        Me.allInt.ReadOnly = True
        Me.allInt.Width = 86
        '
        'allCon
        '
        Me.allCon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.allCon.HeaderText = "Constitution"
        Me.allCon.Name = "allCon"
        Me.allCon.ReadOnly = True
        Me.allCon.Width = 87
        '
        'headID
        '
        Me.headID.HeaderText = "aID"
        Me.headID.Name = "headID"
        Me.headID.ReadOnly = True
        Me.headID.Visible = False
        '
        'headName
        '
        Me.headName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.headName.HeaderText = "Name"
        Me.headName.Name = "headName"
        Me.headName.ReadOnly = True
        '
        'headWgt
        '
        Me.headWgt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.headWgt.HeaderText = "Weight"
        Me.headWgt.Name = "headWgt"
        Me.headWgt.ReadOnly = True
        Me.headWgt.Width = 66
        '
        'headAC
        '
        Me.headAC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.headAC.HeaderText = "Armor Bonus"
        Me.headAC.Name = "headAC"
        Me.headAC.ReadOnly = True
        Me.headAC.Width = 92
        '
        'headChk
        '
        Me.headChk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.headChk.HeaderText = "Check Modifier"
        Me.headChk.Name = "headChk"
        Me.headChk.ReadOnly = True
        Me.headChk.Width = 95
        '
        'headPrice
        '
        Me.headPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.headPrice.HeaderText = "Price"
        Me.headPrice.Name = "headPrice"
        Me.headPrice.ReadOnly = True
        Me.headPrice.Width = 56
        '
        'headClass
        '
        Me.headClass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.headClass.HeaderText = "Armor Class"
        Me.headClass.Name = "headClass"
        Me.headClass.ReadOnly = True
        Me.headClass.Width = 80
        '
        'headType
        '
        Me.headType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.headType.HeaderText = "Armor Spot"
        Me.headType.Name = "headType"
        Me.headType.ReadOnly = True
        Me.headType.Visible = False
        Me.headType.Width = 78
        '
        'headStr
        '
        Me.headStr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.headStr.HeaderText = "Strength"
        Me.headStr.Name = "headStr"
        Me.headStr.ReadOnly = True
        Me.headStr.Width = 72
        '
        'headDex
        '
        Me.headDex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.headDex.HeaderText = "Dexterity"
        Me.headDex.Name = "headDex"
        Me.headDex.ReadOnly = True
        Me.headDex.Width = 73
        '
        'headWis
        '
        Me.headWis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.headWis.HeaderText = "Wisdom"
        Me.headWis.Name = "headWis"
        Me.headWis.ReadOnly = True
        Me.headWis.Width = 70
        '
        'headCha
        '
        Me.headCha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.headCha.HeaderText = "Charisma"
        Me.headCha.Name = "headCha"
        Me.headCha.ReadOnly = True
        Me.headCha.Width = 75
        '
        'headInt
        '
        Me.headInt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.headInt.HeaderText = "Intelligence"
        Me.headInt.Name = "headInt"
        Me.headInt.ReadOnly = True
        Me.headInt.Width = 86
        '
        'headCon
        '
        Me.headCon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.headCon.HeaderText = "Constitution"
        Me.headCon.Name = "headCon"
        Me.headCon.ReadOnly = True
        Me.headCon.Width = 87
        '
        'neckID
        '
        Me.neckID.HeaderText = "aID"
        Me.neckID.Name = "neckID"
        Me.neckID.ReadOnly = True
        Me.neckID.Visible = False
        '
        'neckName
        '
        Me.neckName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.neckName.HeaderText = "Name"
        Me.neckName.Name = "neckName"
        Me.neckName.ReadOnly = True
        '
        'neckWgt
        '
        Me.neckWgt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.neckWgt.HeaderText = "Weight"
        Me.neckWgt.Name = "neckWgt"
        Me.neckWgt.ReadOnly = True
        Me.neckWgt.Width = 66
        '
        'neckArm
        '
        Me.neckArm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.neckArm.HeaderText = "Armor Bonus"
        Me.neckArm.Name = "neckArm"
        Me.neckArm.ReadOnly = True
        Me.neckArm.Width = 92
        '
        'neckChk
        '
        Me.neckChk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.neckChk.HeaderText = "Check Modifier"
        Me.neckChk.Name = "neckChk"
        Me.neckChk.ReadOnly = True
        Me.neckChk.Width = 95
        '
        'neckPrice
        '
        Me.neckPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.neckPrice.HeaderText = "Price"
        Me.neckPrice.Name = "neckPrice"
        Me.neckPrice.ReadOnly = True
        Me.neckPrice.Width = 56
        '
        'neckAC
        '
        Me.neckAC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.neckAC.HeaderText = "Armor Class"
        Me.neckAC.Name = "neckAC"
        Me.neckAC.ReadOnly = True
        Me.neckAC.Width = 80
        '
        'neckType
        '
        Me.neckType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.neckType.HeaderText = "Armor Spot"
        Me.neckType.Name = "neckType"
        Me.neckType.ReadOnly = True
        Me.neckType.Visible = False
        Me.neckType.Width = 78
        '
        'neckStr
        '
        Me.neckStr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.neckStr.HeaderText = "Strength"
        Me.neckStr.Name = "neckStr"
        Me.neckStr.ReadOnly = True
        Me.neckStr.Width = 72
        '
        'neckDex
        '
        Me.neckDex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.neckDex.HeaderText = "Dexterity"
        Me.neckDex.Name = "neckDex"
        Me.neckDex.ReadOnly = True
        Me.neckDex.Width = 73
        '
        'neckWis
        '
        Me.neckWis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.neckWis.HeaderText = "Wisdom"
        Me.neckWis.Name = "neckWis"
        Me.neckWis.ReadOnly = True
        Me.neckWis.Width = 70
        '
        'neckCha
        '
        Me.neckCha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.neckCha.HeaderText = "Charisma"
        Me.neckCha.Name = "neckCha"
        Me.neckCha.ReadOnly = True
        Me.neckCha.Width = 75
        '
        'neckInt
        '
        Me.neckInt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.neckInt.HeaderText = "Intelligence"
        Me.neckInt.Name = "neckInt"
        Me.neckInt.ReadOnly = True
        Me.neckInt.Width = 86
        '
        'neckCon
        '
        Me.neckCon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.neckCon.HeaderText = "Constitution"
        Me.neckCon.Name = "neckCon"
        Me.neckCon.ReadOnly = True
        Me.neckCon.Width = 87
        '
        'chestID
        '
        Me.chestID.HeaderText = "aID"
        Me.chestID.Name = "chestID"
        Me.chestID.ReadOnly = True
        Me.chestID.Visible = False
        '
        'chestName
        '
        Me.chestName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.chestName.HeaderText = "Name"
        Me.chestName.Name = "chestName"
        Me.chestName.ReadOnly = True
        '
        'chestWgt
        '
        Me.chestWgt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.chestWgt.HeaderText = "Weight"
        Me.chestWgt.Name = "chestWgt"
        Me.chestWgt.ReadOnly = True
        Me.chestWgt.Width = 66
        '
        'chestArm
        '
        Me.chestArm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.chestArm.HeaderText = "Armor Bonus"
        Me.chestArm.Name = "chestArm"
        Me.chestArm.ReadOnly = True
        Me.chestArm.Width = 92
        '
        'chestChk
        '
        Me.chestChk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.chestChk.HeaderText = "Check Modifier"
        Me.chestChk.Name = "chestChk"
        Me.chestChk.ReadOnly = True
        Me.chestChk.Width = 95
        '
        'chestPrice
        '
        Me.chestPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.chestPrice.HeaderText = "Price"
        Me.chestPrice.Name = "chestPrice"
        Me.chestPrice.ReadOnly = True
        Me.chestPrice.Width = 56
        '
        'chestAC
        '
        Me.chestAC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.chestAC.HeaderText = "Armor Class"
        Me.chestAC.Name = "chestAC"
        Me.chestAC.ReadOnly = True
        Me.chestAC.Width = 80
        '
        'chestType
        '
        Me.chestType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.chestType.HeaderText = "Armor Spot"
        Me.chestType.Name = "chestType"
        Me.chestType.ReadOnly = True
        Me.chestType.Visible = False
        Me.chestType.Width = 78
        '
        'chestStr
        '
        Me.chestStr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.chestStr.HeaderText = "Strength"
        Me.chestStr.Name = "chestStr"
        Me.chestStr.ReadOnly = True
        Me.chestStr.Width = 72
        '
        'chestDex
        '
        Me.chestDex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.chestDex.HeaderText = "Dexterity"
        Me.chestDex.Name = "chestDex"
        Me.chestDex.ReadOnly = True
        Me.chestDex.Width = 73
        '
        'chestWis
        '
        Me.chestWis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.chestWis.HeaderText = "Wisdom"
        Me.chestWis.Name = "chestWis"
        Me.chestWis.ReadOnly = True
        Me.chestWis.Width = 70
        '
        'chestCha
        '
        Me.chestCha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.chestCha.HeaderText = "Charisma"
        Me.chestCha.Name = "chestCha"
        Me.chestCha.ReadOnly = True
        Me.chestCha.Width = 75
        '
        'chestInt
        '
        Me.chestInt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.chestInt.HeaderText = "Intelligence"
        Me.chestInt.Name = "chestInt"
        Me.chestInt.ReadOnly = True
        Me.chestInt.Width = 86
        '
        'chestCon
        '
        Me.chestCon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.chestCon.HeaderText = "Constitution"
        Me.chestCon.Name = "chestCon"
        Me.chestCon.ReadOnly = True
        Me.chestCon.Width = 87
        '
        'armID
        '
        Me.armID.HeaderText = "aID"
        Me.armID.Name = "armID"
        Me.armID.ReadOnly = True
        Me.armID.Visible = False
        '
        'armName
        '
        Me.armName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.armName.HeaderText = "Name"
        Me.armName.Name = "armName"
        Me.armName.ReadOnly = True
        '
        'armWgt
        '
        Me.armWgt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.armWgt.HeaderText = "Weight"
        Me.armWgt.Name = "armWgt"
        Me.armWgt.ReadOnly = True
        Me.armWgt.Width = 66
        '
        'armArm
        '
        Me.armArm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.armArm.HeaderText = "Armor Bonus"
        Me.armArm.Name = "armArm"
        Me.armArm.ReadOnly = True
        Me.armArm.Width = 92
        '
        'armChk
        '
        Me.armChk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.armChk.HeaderText = "Check Modifier"
        Me.armChk.Name = "armChk"
        Me.armChk.ReadOnly = True
        Me.armChk.Width = 95
        '
        'armPrice
        '
        Me.armPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.armPrice.HeaderText = "Price"
        Me.armPrice.Name = "armPrice"
        Me.armPrice.ReadOnly = True
        Me.armPrice.Width = 56
        '
        'armAC
        '
        Me.armAC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.armAC.HeaderText = "Armor Class"
        Me.armAC.Name = "armAC"
        Me.armAC.ReadOnly = True
        Me.armAC.Width = 80
        '
        'armType
        '
        Me.armType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.armType.HeaderText = "Armor Spot"
        Me.armType.Name = "armType"
        Me.armType.ReadOnly = True
        Me.armType.Visible = False
        Me.armType.Width = 78
        '
        'armStr
        '
        Me.armStr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.armStr.HeaderText = "Strength"
        Me.armStr.Name = "armStr"
        Me.armStr.ReadOnly = True
        Me.armStr.Width = 72
        '
        'armDex
        '
        Me.armDex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.armDex.HeaderText = "Dexterity"
        Me.armDex.Name = "armDex"
        Me.armDex.ReadOnly = True
        Me.armDex.Width = 73
        '
        'armWis
        '
        Me.armWis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.armWis.HeaderText = "Wisdom"
        Me.armWis.Name = "armWis"
        Me.armWis.ReadOnly = True
        Me.armWis.Width = 70
        '
        'armCha
        '
        Me.armCha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.armCha.HeaderText = "Charisma"
        Me.armCha.Name = "armCha"
        Me.armCha.ReadOnly = True
        Me.armCha.Width = 75
        '
        'armInt
        '
        Me.armInt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.armInt.HeaderText = "Intelligence"
        Me.armInt.Name = "armInt"
        Me.armInt.ReadOnly = True
        Me.armInt.Width = 86
        '
        'armCon
        '
        Me.armCon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.armCon.HeaderText = "Constitution"
        Me.armCon.Name = "armCon"
        Me.armCon.ReadOnly = True
        Me.armCon.Width = 87
        '
        'wristID
        '
        Me.wristID.HeaderText = "aID"
        Me.wristID.Name = "wristID"
        Me.wristID.ReadOnly = True
        Me.wristID.Visible = False
        '
        'wristName
        '
        Me.wristName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.wristName.HeaderText = "Name"
        Me.wristName.Name = "wristName"
        Me.wristName.ReadOnly = True
        '
        'wristWgt
        '
        Me.wristWgt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.wristWgt.HeaderText = "Weight"
        Me.wristWgt.Name = "wristWgt"
        Me.wristWgt.ReadOnly = True
        Me.wristWgt.Width = 66
        '
        'wristArm
        '
        Me.wristArm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.wristArm.HeaderText = "Armor Bonus"
        Me.wristArm.Name = "wristArm"
        Me.wristArm.ReadOnly = True
        Me.wristArm.Width = 92
        '
        'wristChk
        '
        Me.wristChk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.wristChk.HeaderText = "Check Modifier"
        Me.wristChk.Name = "wristChk"
        Me.wristChk.ReadOnly = True
        Me.wristChk.Width = 95
        '
        'wristPrice
        '
        Me.wristPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.wristPrice.HeaderText = "Price"
        Me.wristPrice.Name = "wristPrice"
        Me.wristPrice.ReadOnly = True
        Me.wristPrice.Width = 56
        '
        'wristAC
        '
        Me.wristAC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.wristAC.HeaderText = "Armor Class"
        Me.wristAC.Name = "wristAC"
        Me.wristAC.ReadOnly = True
        Me.wristAC.Width = 80
        '
        'wristType
        '
        Me.wristType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.wristType.HeaderText = "Armor Spot"
        Me.wristType.Name = "wristType"
        Me.wristType.ReadOnly = True
        Me.wristType.Visible = False
        Me.wristType.Width = 78
        '
        'wristStr
        '
        Me.wristStr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.wristStr.HeaderText = "Strength"
        Me.wristStr.Name = "wristStr"
        Me.wristStr.ReadOnly = True
        Me.wristStr.Width = 72
        '
        'wristDex
        '
        Me.wristDex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.wristDex.HeaderText = "Dexterity"
        Me.wristDex.Name = "wristDex"
        Me.wristDex.ReadOnly = True
        Me.wristDex.Width = 73
        '
        'wristWis
        '
        Me.wristWis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.wristWis.HeaderText = "Wisdom"
        Me.wristWis.Name = "wristWis"
        Me.wristWis.ReadOnly = True
        Me.wristWis.Width = 70
        '
        'wristCha
        '
        Me.wristCha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.wristCha.HeaderText = "Charisma"
        Me.wristCha.Name = "wristCha"
        Me.wristCha.ReadOnly = True
        Me.wristCha.Width = 75
        '
        'wristInt
        '
        Me.wristInt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.wristInt.HeaderText = "Intelligence"
        Me.wristInt.Name = "wristInt"
        Me.wristInt.ReadOnly = True
        Me.wristInt.Width = 86
        '
        'wristCon
        '
        Me.wristCon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.wristCon.HeaderText = "Constitution"
        Me.wristCon.Name = "wristCon"
        Me.wristCon.ReadOnly = True
        Me.wristCon.Width = 87
        '
        'handID
        '
        Me.handID.HeaderText = "aID"
        Me.handID.Name = "handID"
        Me.handID.ReadOnly = True
        Me.handID.Visible = False
        '
        'handName
        '
        Me.handName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.handName.HeaderText = "Name"
        Me.handName.Name = "handName"
        Me.handName.ReadOnly = True
        '
        'handWgt
        '
        Me.handWgt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.handWgt.HeaderText = "Weight"
        Me.handWgt.Name = "handWgt"
        Me.handWgt.ReadOnly = True
        Me.handWgt.Width = 66
        '
        'handArm
        '
        Me.handArm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.handArm.HeaderText = "Armor Bonus"
        Me.handArm.Name = "handArm"
        Me.handArm.ReadOnly = True
        Me.handArm.Width = 92
        '
        'handChk
        '
        Me.handChk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.handChk.HeaderText = "Check Modifier"
        Me.handChk.Name = "handChk"
        Me.handChk.ReadOnly = True
        Me.handChk.Width = 95
        '
        'handPrice
        '
        Me.handPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.handPrice.HeaderText = "Price"
        Me.handPrice.Name = "handPrice"
        Me.handPrice.ReadOnly = True
        Me.handPrice.Width = 56
        '
        'handAC
        '
        Me.handAC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.handAC.HeaderText = "Armor Class"
        Me.handAC.Name = "handAC"
        Me.handAC.ReadOnly = True
        Me.handAC.Width = 80
        '
        'handType
        '
        Me.handType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.handType.HeaderText = "Armor Spot"
        Me.handType.Name = "handType"
        Me.handType.ReadOnly = True
        Me.handType.Visible = False
        Me.handType.Width = 78
        '
        'handStr
        '
        Me.handStr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.handStr.HeaderText = "Strength"
        Me.handStr.Name = "handStr"
        Me.handStr.ReadOnly = True
        Me.handStr.Width = 72
        '
        'handDex
        '
        Me.handDex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.handDex.HeaderText = "Dexterity"
        Me.handDex.Name = "handDex"
        Me.handDex.ReadOnly = True
        Me.handDex.Width = 73
        '
        'handWis
        '
        Me.handWis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.handWis.HeaderText = "Wisdom"
        Me.handWis.Name = "handWis"
        Me.handWis.ReadOnly = True
        Me.handWis.Width = 70
        '
        'handCha
        '
        Me.handCha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.handCha.HeaderText = "Charisma"
        Me.handCha.Name = "handCha"
        Me.handCha.ReadOnly = True
        Me.handCha.Width = 75
        '
        'handInt
        '
        Me.handInt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.handInt.HeaderText = "Intelligence"
        Me.handInt.Name = "handInt"
        Me.handInt.ReadOnly = True
        Me.handInt.Width = 86
        '
        'handCon
        '
        Me.handCon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.handCon.HeaderText = "Constitution"
        Me.handCon.Name = "handCon"
        Me.handCon.ReadOnly = True
        Me.handCon.Width = 87
        '
        'legID
        '
        Me.legID.HeaderText = "aID"
        Me.legID.Name = "legID"
        Me.legID.ReadOnly = True
        Me.legID.Visible = False
        '
        'legName
        '
        Me.legName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.legName.HeaderText = "Name"
        Me.legName.Name = "legName"
        Me.legName.ReadOnly = True
        '
        'legWgt
        '
        Me.legWgt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.legWgt.HeaderText = "Weight"
        Me.legWgt.Name = "legWgt"
        Me.legWgt.ReadOnly = True
        Me.legWgt.Width = 66
        '
        'legArm
        '
        Me.legArm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.legArm.HeaderText = "Armor Bonus"
        Me.legArm.Name = "legArm"
        Me.legArm.ReadOnly = True
        Me.legArm.Width = 92
        '
        'legChk
        '
        Me.legChk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.legChk.HeaderText = "Check Modifier"
        Me.legChk.Name = "legChk"
        Me.legChk.ReadOnly = True
        Me.legChk.Width = 95
        '
        'legPrice
        '
        Me.legPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.legPrice.HeaderText = "Price"
        Me.legPrice.Name = "legPrice"
        Me.legPrice.ReadOnly = True
        Me.legPrice.Width = 56
        '
        'legAC
        '
        Me.legAC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.legAC.HeaderText = "Armor Class"
        Me.legAC.Name = "legAC"
        Me.legAC.ReadOnly = True
        Me.legAC.Width = 80
        '
        'legType
        '
        Me.legType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.legType.HeaderText = "Armor Spot"
        Me.legType.Name = "legType"
        Me.legType.ReadOnly = True
        Me.legType.Visible = False
        Me.legType.Width = 78
        '
        'legStr
        '
        Me.legStr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.legStr.HeaderText = "Strength"
        Me.legStr.Name = "legStr"
        Me.legStr.ReadOnly = True
        Me.legStr.Width = 72
        '
        'legDex
        '
        Me.legDex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.legDex.HeaderText = "Dexterity"
        Me.legDex.Name = "legDex"
        Me.legDex.ReadOnly = True
        Me.legDex.Width = 73
        '
        'legWis
        '
        Me.legWis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.legWis.HeaderText = "Wisdom"
        Me.legWis.Name = "legWis"
        Me.legWis.ReadOnly = True
        Me.legWis.Width = 70
        '
        'legCha
        '
        Me.legCha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.legCha.HeaderText = "Charisma"
        Me.legCha.Name = "legCha"
        Me.legCha.ReadOnly = True
        Me.legCha.Width = 75
        '
        'legInt
        '
        Me.legInt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.legInt.HeaderText = "Intelligence"
        Me.legInt.Name = "legInt"
        Me.legInt.ReadOnly = True
        Me.legInt.Width = 86
        '
        'legCon
        '
        Me.legCon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.legCon.HeaderText = "Constitution"
        Me.legCon.Name = "legCon"
        Me.legCon.ReadOnly = True
        Me.legCon.Width = 87
        '
        'feetID
        '
        Me.feetID.HeaderText = "aID"
        Me.feetID.Name = "feetID"
        Me.feetID.ReadOnly = True
        Me.feetID.Visible = False
        '
        'feetName
        '
        Me.feetName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.feetName.HeaderText = "Name"
        Me.feetName.Name = "feetName"
        Me.feetName.ReadOnly = True
        '
        'feetWgt
        '
        Me.feetWgt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.feetWgt.HeaderText = "Weight"
        Me.feetWgt.Name = "feetWgt"
        Me.feetWgt.ReadOnly = True
        Me.feetWgt.Width = 66
        '
        'feetArm
        '
        Me.feetArm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.feetArm.HeaderText = "Armor Bonus"
        Me.feetArm.Name = "feetArm"
        Me.feetArm.ReadOnly = True
        Me.feetArm.Width = 92
        '
        'feetChk
        '
        Me.feetChk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.feetChk.HeaderText = "Check Modifier"
        Me.feetChk.Name = "feetChk"
        Me.feetChk.ReadOnly = True
        Me.feetChk.Width = 95
        '
        'feetPrice
        '
        Me.feetPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.feetPrice.HeaderText = "Price"
        Me.feetPrice.Name = "feetPrice"
        Me.feetPrice.ReadOnly = True
        Me.feetPrice.Width = 56
        '
        'feetAC
        '
        Me.feetAC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.feetAC.HeaderText = "Armor Class"
        Me.feetAC.Name = "feetAC"
        Me.feetAC.ReadOnly = True
        Me.feetAC.Width = 80
        '
        'feetType
        '
        Me.feetType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.feetType.HeaderText = "Armor Spot"
        Me.feetType.Name = "feetType"
        Me.feetType.ReadOnly = True
        Me.feetType.Visible = False
        Me.feetType.Width = 78
        '
        'feetStr
        '
        Me.feetStr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.feetStr.HeaderText = "Strength"
        Me.feetStr.Name = "feetStr"
        Me.feetStr.ReadOnly = True
        Me.feetStr.Width = 72
        '
        'feetDex
        '
        Me.feetDex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.feetDex.HeaderText = "Dexterity"
        Me.feetDex.Name = "feetDex"
        Me.feetDex.ReadOnly = True
        Me.feetDex.Width = 73
        '
        'feetWis
        '
        Me.feetWis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.feetWis.HeaderText = "Wisdom"
        Me.feetWis.Name = "feetWis"
        Me.feetWis.ReadOnly = True
        Me.feetWis.Width = 70
        '
        'feetCha
        '
        Me.feetCha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.feetCha.HeaderText = "Charisma"
        Me.feetCha.Name = "feetCha"
        Me.feetCha.ReadOnly = True
        Me.feetCha.Width = 75
        '
        'feetInt
        '
        Me.feetInt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.feetInt.HeaderText = "Intelligence"
        Me.feetInt.Name = "feetInt"
        Me.feetInt.ReadOnly = True
        Me.feetInt.Width = 86
        '
        'feetCon
        '
        Me.feetCon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.feetCon.HeaderText = "Constitution"
        Me.feetCon.Name = "feetCon"
        Me.feetCon.ReadOnly = True
        Me.feetCon.Width = 87
        '
        'frmSelArmor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1305, 347)
        Me.Controls.Add(Me.tabArmor)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "frmSelArmor"
        Me.ShowIcon = False
        Me.Text = "Select Armor"
        CType(Me.dgvHead, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabArmor.ResumeLayout(False)
        Me.tabAll.ResumeLayout(False)
        CType(Me.dgvArmor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabHelm.ResumeLayout(False)
        Me.tabNeck.ResumeLayout(False)
        CType(Me.dgvNeck, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabChest.ResumeLayout(False)
        CType(Me.dgvChest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabArms.ResumeLayout(False)
        CType(Me.dgvArms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabWrists.ResumeLayout(False)
        CType(Me.dgvWrists, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabHands.ResumeLayout(False)
        CType(Me.dgvHands, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabLegs.ResumeLayout(False)
        CType(Me.dgvLegs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabFeet.ResumeLayout(False)
        CType(Me.dgvFeet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvHead As System.Windows.Forms.DataGridView
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents tabArmor As System.Windows.Forms.TabControl
    Friend WithEvents tabHelm As System.Windows.Forms.TabPage
    Friend WithEvents tabChest As System.Windows.Forms.TabPage
    Friend WithEvents tabAll As System.Windows.Forms.TabPage
    Friend WithEvents tabLegs As System.Windows.Forms.TabPage
    Friend WithEvents tabArms As System.Windows.Forms.TabPage
    Friend WithEvents tabFeet As System.Windows.Forms.TabPage
    Friend WithEvents tabHands As System.Windows.Forms.TabPage
    Friend WithEvents tabNeck As System.Windows.Forms.TabPage
    Friend WithEvents dgvNeck As System.Windows.Forms.DataGridView
    Friend WithEvents dgvArmor As System.Windows.Forms.DataGridView
    Friend WithEvents dgvChest As System.Windows.Forms.DataGridView
    Friend WithEvents dgvArms As System.Windows.Forms.DataGridView
    Friend WithEvents dgvHands As System.Windows.Forms.DataGridView
    Friend WithEvents dgvLegs As System.Windows.Forms.DataGridView
    Friend WithEvents dgvFeet As System.Windows.Forms.DataGridView
    Friend WithEvents tabWrists As System.Windows.Forms.TabPage
    Friend WithEvents dgvWrists As System.Windows.Forms.DataGridView
    Friend WithEvents headID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents headName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents headWgt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents headAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents headChk As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents headPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents headClass As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents headType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents headStr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents headDex As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents headWis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents headCha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents headInt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents headCon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents allID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents allName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents allWgt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents allArm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents allChk As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents allPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents allAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents allType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents allStr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents allDex As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents allWis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents allCha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents allInt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents allCon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents neckID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents neckName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents neckWgt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents neckArm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents neckChk As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents neckPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents neckAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents neckType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents neckStr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents neckDex As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents neckWis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents neckCha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents neckInt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents neckCon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chestID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chestName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chestWgt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chestArm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chestChk As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chestPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chestAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chestType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chestStr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chestDex As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chestWis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chestCha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chestInt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chestCon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents armID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents armName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents armWgt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents armArm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents armChk As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents armPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents armAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents armType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents armStr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents armDex As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents armWis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents armCha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents armInt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents armCon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents wristID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents wristName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents wristWgt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents wristArm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents wristChk As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents wristPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents wristAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents wristType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents wristStr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents wristDex As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents wristWis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents wristCha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents wristInt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents wristCon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents handID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents handName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents handWgt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents handArm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents handChk As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents handPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents handAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents handType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents handStr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents handDex As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents handWis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents handCha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents handInt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents handCon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents legID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents legName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents legWgt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents legArm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents legChk As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents legPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents legAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents legType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents legStr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents legDex As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents legWis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents legCha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents legInt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents legCon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents feetID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents feetName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents feetWgt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents feetArm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents feetChk As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents feetPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents feetAC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents feetType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents feetStr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents feetDex As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents feetWis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents feetCha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents feetInt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents feetCon As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
