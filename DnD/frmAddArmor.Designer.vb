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
        CType(Me.numChk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numArmBon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numWgt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPrice, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.cboType.TabIndex = 6
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(15, 191)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(197, 191)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Armor Slot"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Weight (lbs)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Armor Bonus"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Class"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Check Modifier"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Price (gold)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 141)
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
        Me.txtName.TabIndex = 5
        '
        'numChk
        '
        Me.numChk.Location = New System.Drawing.Point(152, 86)
        Me.numChk.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.numChk.Name = "numChk"
        Me.numChk.Size = New System.Drawing.Size(120, 20)
        Me.numChk.TabIndex = 3
        '
        'numArmBon
        '
        Me.numArmBon.Location = New System.Drawing.Point(152, 33)
        Me.numArmBon.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.numArmBon.Name = "numArmBon"
        Me.numArmBon.Size = New System.Drawing.Size(120, 20)
        Me.numArmBon.TabIndex = 1
        '
        'numWgt
        '
        Me.numWgt.Location = New System.Drawing.Point(152, 7)
        Me.numWgt.Name = "numWgt"
        Me.numWgt.Size = New System.Drawing.Size(120, 20)
        Me.numWgt.TabIndex = 0
        '
        'cboClass
        '
        Me.cboClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboClass.FormattingEnabled = True
        Me.cboClass.Items.AddRange(New Object() {"Heavy", "Light"})
        Me.cboClass.Location = New System.Drawing.Point(151, 59)
        Me.cboClass.Name = "cboClass"
        Me.cboClass.Size = New System.Drawing.Size(121, 21)
        Me.cboClass.TabIndex = 2
        '
        'numPrice
        '
        Me.numPrice.Location = New System.Drawing.Point(152, 112)
        Me.numPrice.Name = "numPrice"
        Me.numPrice.Size = New System.Drawing.Size(120, 20)
        Me.numPrice.TabIndex = 4
        '
        'frmAddArmor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 224)
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
End Class
