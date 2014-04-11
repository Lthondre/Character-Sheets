<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddArmor
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
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.numChk = New System.Windows.Forms.NumericUpDown()
        Me.numArmBon = New System.Windows.Forms.NumericUpDown()
        Me.numWgt = New System.Windows.Forms.NumericUpDown()
        Me.cboClass = New System.Windows.Forms.ComboBox()
        Me.numPrice = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.numStr = New System.Windows.Forms.NumericUpDown()
        Me.numDex = New System.Windows.Forms.NumericUpDown()
        Me.numWis = New System.Windows.Forms.NumericUpDown()
        Me.numCha = New System.Windows.Forms.NumericUpDown()
        Me.numInt = New System.Windows.Forms.NumericUpDown()
        Me.numCon = New System.Windows.Forms.NumericUpDown()
        CType(Me.numChk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numArmBon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numWgt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numStr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numDex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numWis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numInt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboType
        '
        Me.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboType.FormattingEnabled = True
        Me.cboType.Items.AddRange(New Object() {"Helm", "Chest", "Legs", "Arms", "Neck", "Feet", "Wrists", "Hands"})
        Me.cboType.Location = New System.Drawing.Point(151, 164)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(121, 21)
        Me.cboType.TabIndex = 16
        '
        'btnAdd
        '
        Me.btnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAdd.Location = New System.Drawing.Point(12, 366)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 23
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(194, 366)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 24
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Armor Slot"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Weight (lbs)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Armor Bonus"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Class"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Check Modifier"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Price (gold)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Armor Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(152, 138)
        Me.txtName.MaxLength = 50
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(120, 20)
        Me.txtName.TabIndex = 15
        '
        'numChk
        '
        Me.numChk.Location = New System.Drawing.Point(152, 86)
        Me.numChk.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.numChk.Name = "numChk"
        Me.numChk.Size = New System.Drawing.Size(120, 20)
        Me.numChk.TabIndex = 13
        Me.numChk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'numArmBon
        '
        Me.numArmBon.Location = New System.Drawing.Point(152, 33)
        Me.numArmBon.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.numArmBon.Name = "numArmBon"
        Me.numArmBon.Size = New System.Drawing.Size(120, 20)
        Me.numArmBon.TabIndex = 11
        Me.numArmBon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'numWgt
        '
        Me.numWgt.Location = New System.Drawing.Point(152, 7)
        Me.numWgt.Name = "numWgt"
        Me.numWgt.Size = New System.Drawing.Size(120, 20)
        Me.numWgt.TabIndex = 10
        Me.numWgt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cboClass
        '
        Me.cboClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboClass.FormattingEnabled = True
        Me.cboClass.Items.AddRange(New Object() {"Heavy", "Light"})
        Me.cboClass.Location = New System.Drawing.Point(151, 59)
        Me.cboClass.Name = "cboClass"
        Me.cboClass.Size = New System.Drawing.Size(121, 21)
        Me.cboClass.TabIndex = 12
        '
        'numPrice
        '
        Me.numPrice.Location = New System.Drawing.Point(152, 112)
        Me.numPrice.Name = "numPrice"
        Me.numPrice.Size = New System.Drawing.Size(120, 20)
        Me.numPrice.TabIndex = 14
        Me.numPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 193)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Str Mod"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 219)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Dex Mod"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 245)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Wis Mod"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 271)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Cha Mod"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 323)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Con Mod"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 297)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 13)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Int Mod"
        '
        'numStr
        '
        Me.numStr.Location = New System.Drawing.Point(152, 191)
        Me.numStr.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numStr.Minimum = New Decimal(New Integer() {10, 0, 0, -2147483648})
        Me.numStr.Name = "numStr"
        Me.numStr.Size = New System.Drawing.Size(120, 20)
        Me.numStr.TabIndex = 17
        Me.numStr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'numDex
        '
        Me.numDex.Location = New System.Drawing.Point(152, 217)
        Me.numDex.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numDex.Minimum = New Decimal(New Integer() {10, 0, 0, -2147483648})
        Me.numDex.Name = "numDex"
        Me.numDex.Size = New System.Drawing.Size(120, 20)
        Me.numDex.TabIndex = 18
        Me.numDex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'numWis
        '
        Me.numWis.Location = New System.Drawing.Point(152, 243)
        Me.numWis.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numWis.Minimum = New Decimal(New Integer() {10, 0, 0, -2147483648})
        Me.numWis.Name = "numWis"
        Me.numWis.Size = New System.Drawing.Size(120, 20)
        Me.numWis.TabIndex = 19
        Me.numWis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'numCha
        '
        Me.numCha.Location = New System.Drawing.Point(152, 269)
        Me.numCha.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numCha.Minimum = New Decimal(New Integer() {10, 0, 0, -2147483648})
        Me.numCha.Name = "numCha"
        Me.numCha.Size = New System.Drawing.Size(120, 20)
        Me.numCha.TabIndex = 20
        Me.numCha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'numInt
        '
        Me.numInt.Location = New System.Drawing.Point(152, 295)
        Me.numInt.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numInt.Minimum = New Decimal(New Integer() {10, 0, 0, -2147483648})
        Me.numInt.Name = "numInt"
        Me.numInt.Size = New System.Drawing.Size(120, 20)
        Me.numInt.TabIndex = 21
        Me.numInt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'numCon
        '
        Me.numCon.Location = New System.Drawing.Point(152, 321)
        Me.numCon.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numCon.Minimum = New Decimal(New Integer() {10, 0, 0, -2147483648})
        Me.numCon.Name = "numCon"
        Me.numCon.Size = New System.Drawing.Size(120, 20)
        Me.numCon.TabIndex = 22
        Me.numCon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmAddArmor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(284, 401)
        Me.ControlBox = False
        Me.Controls.Add(Me.numCon)
        Me.Controls.Add(Me.numInt)
        Me.Controls.Add(Me.numCha)
        Me.Controls.Add(Me.numWis)
        Me.Controls.Add(Me.numDex)
        Me.Controls.Add(Me.numStr)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.numPrice)
        Me.Controls.Add(Me.cboClass)
        Me.Controls.Add(Me.numWgt)
        Me.Controls.Add(Me.numArmBon)
        Me.Controls.Add(Me.numChk)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.cboType)
        Me.Name = "frmAddArmor"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Add Armor"
        CType(Me.numChk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numArmBon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numWgt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numStr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numDex, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numWis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numInt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboType As System.Windows.Forms.ComboBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents numChk As System.Windows.Forms.NumericUpDown
    Friend WithEvents numArmBon As System.Windows.Forms.NumericUpDown
    Friend WithEvents numWgt As System.Windows.Forms.NumericUpDown
    Friend WithEvents cboClass As System.Windows.Forms.ComboBox
    Friend WithEvents numPrice As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents numStr As System.Windows.Forms.NumericUpDown
    Friend WithEvents numDex As System.Windows.Forms.NumericUpDown
    Friend WithEvents numWis As System.Windows.Forms.NumericUpDown
    Friend WithEvents numCha As System.Windows.Forms.NumericUpDown
    Friend WithEvents numInt As System.Windows.Forms.NumericUpDown
    Friend WithEvents numCon As System.Windows.Forms.NumericUpDown
End Class
