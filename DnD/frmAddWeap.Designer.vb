<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddWeap
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtWgt = New System.Windows.Forms.NumericUpDown()
        Me.txtArm = New System.Windows.Forms.NumericUpDown()
        Me.txtChk = New System.Windows.Forms.NumericUpDown()
        Me.txtPrice = New System.Windows.Forms.NumericUpDown()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.numStr = New System.Windows.Forms.NumericUpDown()
        Me.numDex = New System.Windows.Forms.NumericUpDown()
        Me.numWis = New System.Windows.Forms.NumericUpDown()
        Me.numCha = New System.Windows.Forms.NumericUpDown()
        Me.numInt = New System.Windows.Forms.NumericUpDown()
        Me.numCon = New System.Windows.Forms.NumericUpDown()
        CType(Me.txtWgt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtArm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numStr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numDex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numWis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numInt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Weight(lbs)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Armor Bonus"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Check Modifier"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Price(Gold)"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(172, 12)
        Me.txtName.MaxLength = 30
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 0
        '
        'txtWgt
        '
        Me.txtWgt.Location = New System.Drawing.Point(172, 38)
        Me.txtWgt.Name = "txtWgt"
        Me.txtWgt.Size = New System.Drawing.Size(100, 20)
        Me.txtWgt.TabIndex = 1
        Me.txtWgt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtArm
        '
        Me.txtArm.Location = New System.Drawing.Point(172, 64)
        Me.txtArm.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.txtArm.Name = "txtArm"
        Me.txtArm.Size = New System.Drawing.Size(100, 20)
        Me.txtArm.TabIndex = 2
        Me.txtArm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtChk
        '
        Me.txtChk.Location = New System.Drawing.Point(172, 90)
        Me.txtChk.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.txtChk.Name = "txtChk"
        Me.txtChk.Size = New System.Drawing.Size(100, 20)
        Me.txtChk.TabIndex = 3
        Me.txtChk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(172, 116)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 4
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(197, 298)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "&Cancel"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(12, 298)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Str Mod"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 170)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Dex Mod"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 196)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Wis Mod"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 222)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Cha Mod"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 248)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Int Mod"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 274)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Con Mod"
        '
        'numStr
        '
        Me.numStr.Location = New System.Drawing.Point(172, 142)
        Me.numStr.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numStr.Minimum = New Decimal(New Integer() {10, 0, 0, -2147483648})
        Me.numStr.Name = "numStr"
        Me.numStr.Size = New System.Drawing.Size(100, 20)
        Me.numStr.TabIndex = 13
        Me.numStr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'numDex
        '
        Me.numDex.Location = New System.Drawing.Point(172, 168)
        Me.numDex.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numDex.Minimum = New Decimal(New Integer() {10, 0, 0, -2147483648})
        Me.numDex.Name = "numDex"
        Me.numDex.Size = New System.Drawing.Size(100, 20)
        Me.numDex.TabIndex = 14
        Me.numDex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'numWis
        '
        Me.numWis.Location = New System.Drawing.Point(172, 194)
        Me.numWis.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numWis.Minimum = New Decimal(New Integer() {10, 0, 0, -2147483648})
        Me.numWis.Name = "numWis"
        Me.numWis.Size = New System.Drawing.Size(100, 20)
        Me.numWis.TabIndex = 15
        Me.numWis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'numCha
        '
        Me.numCha.Location = New System.Drawing.Point(172, 220)
        Me.numCha.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numCha.Minimum = New Decimal(New Integer() {10, 0, 0, -2147483648})
        Me.numCha.Name = "numCha"
        Me.numCha.Size = New System.Drawing.Size(100, 20)
        Me.numCha.TabIndex = 16
        Me.numCha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'numInt
        '
        Me.numInt.Location = New System.Drawing.Point(172, 246)
        Me.numInt.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numInt.Minimum = New Decimal(New Integer() {10, 0, 0, -2147483648})
        Me.numInt.Name = "numInt"
        Me.numInt.Size = New System.Drawing.Size(100, 20)
        Me.numInt.TabIndex = 17
        Me.numInt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'numCon
        '
        Me.numCon.Location = New System.Drawing.Point(172, 272)
        Me.numCon.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numCon.Minimum = New Decimal(New Integer() {10, 0, 0, -2147483648})
        Me.numCon.Name = "numCon"
        Me.numCon.Size = New System.Drawing.Size(100, 20)
        Me.numCon.TabIndex = 18
        Me.numCon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmAddWeap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 334)
        Me.Controls.Add(Me.numCon)
        Me.Controls.Add(Me.numInt)
        Me.Controls.Add(Me.numCha)
        Me.Controls.Add(Me.numWis)
        Me.Controls.Add(Me.numDex)
        Me.Controls.Add(Me.numStr)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtChk)
        Me.Controls.Add(Me.txtArm)
        Me.Controls.Add(Me.txtWgt)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmAddWeap"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Add A Weapon"
        CType(Me.txtWgt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtArm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numStr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numDex, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numWis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numInt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtWgt As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtArm As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtChk As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtPrice As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents numStr As System.Windows.Forms.NumericUpDown
    Friend WithEvents numDex As System.Windows.Forms.NumericUpDown
    Friend WithEvents numWis As System.Windows.Forms.NumericUpDown
    Friend WithEvents numCha As System.Windows.Forms.NumericUpDown
    Friend WithEvents numInt As System.Windows.Forms.NumericUpDown
    Friend WithEvents numCon As System.Windows.Forms.NumericUpDown
End Class
