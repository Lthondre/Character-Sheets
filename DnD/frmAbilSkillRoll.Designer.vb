<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbilSkillRoll
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnInit = New System.Windows.Forms.Button()
        Me.txtInit = New System.Windows.Forms.TextBox()
        Me.btnOkay = New System.Windows.Forms.Button()
        Me.btnPerception = New System.Windows.Forms.Button()
        Me.txtPerc = New System.Windows.Forms.TextBox()
        Me.btnStrChk = New System.Windows.Forms.Button()
        Me.txtStrChk = New System.Windows.Forms.TextBox()
        Me.btnDexChk = New System.Windows.Forms.Button()
        Me.btnConChk = New System.Windows.Forms.Button()
        Me.btnWisChk = New System.Windows.Forms.Button()
        Me.btnIntChk = New System.Windows.Forms.Button()
        Me.btnChaChk = New System.Windows.Forms.Button()
        Me.txtDexChk = New System.Windows.Forms.TextBox()
        Me.txtConChk = New System.Windows.Forms.TextBox()
        Me.txtWisChk = New System.Windows.Forms.TextBox()
        Me.txtIntChk = New System.Windows.Forms.TextBox()
        Me.txtChaChk = New System.Windows.Forms.TextBox()
        Me.rbtnAbil = New System.Windows.Forms.RadioButton()
        Me.rbtnSkill = New System.Windows.Forms.RadioButton()
        Me.gbxChkType = New System.Windows.Forms.GroupBox()
        Me.gbxChkType.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(118, 304)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnInit
        '
        Me.btnInit.Location = New System.Drawing.Point(12, 65)
        Me.btnInit.Name = "btnInit"
        Me.btnInit.Size = New System.Drawing.Size(75, 23)
        Me.btnInit.TabIndex = 3
        Me.btnInit.Text = "&Initiative"
        Me.btnInit.UseVisualStyleBackColor = True
        '
        'txtInit
        '
        Me.txtInit.Location = New System.Drawing.Point(93, 67)
        Me.txtInit.Name = "txtInit"
        Me.txtInit.Size = New System.Drawing.Size(100, 20)
        Me.txtInit.TabIndex = 4
        Me.txtInit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnOkay
        '
        Me.btnOkay.Location = New System.Drawing.Point(12, 304)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.Size = New System.Drawing.Size(75, 23)
        Me.btnOkay.TabIndex = 5
        Me.btnOkay.Text = "&Okay"
        Me.btnOkay.UseVisualStyleBackColor = True
        '
        'btnPerception
        '
        Me.btnPerception.Location = New System.Drawing.Point(12, 91)
        Me.btnPerception.Name = "btnPerception"
        Me.btnPerception.Size = New System.Drawing.Size(75, 23)
        Me.btnPerception.TabIndex = 6
        Me.btnPerception.Text = "&Perception"
        Me.btnPerception.UseVisualStyleBackColor = True
        '
        'txtPerc
        '
        Me.txtPerc.Location = New System.Drawing.Point(93, 93)
        Me.txtPerc.Name = "txtPerc"
        Me.txtPerc.Size = New System.Drawing.Size(100, 20)
        Me.txtPerc.TabIndex = 7
        Me.txtPerc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnStrChk
        '
        Me.btnStrChk.Location = New System.Drawing.Point(12, 134)
        Me.btnStrChk.Name = "btnStrChk"
        Me.btnStrChk.Size = New System.Drawing.Size(75, 23)
        Me.btnStrChk.TabIndex = 8
        Me.btnStrChk.Text = "&Strength"
        Me.btnStrChk.UseVisualStyleBackColor = True
        '
        'txtStrChk
        '
        Me.txtStrChk.Location = New System.Drawing.Point(93, 136)
        Me.txtStrChk.Name = "txtStrChk"
        Me.txtStrChk.ReadOnly = True
        Me.txtStrChk.Size = New System.Drawing.Size(100, 20)
        Me.txtStrChk.TabIndex = 9
        Me.txtStrChk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnDexChk
        '
        Me.btnDexChk.Location = New System.Drawing.Point(12, 160)
        Me.btnDexChk.Name = "btnDexChk"
        Me.btnDexChk.Size = New System.Drawing.Size(75, 23)
        Me.btnDexChk.TabIndex = 10
        Me.btnDexChk.Text = "&Dexterity"
        Me.btnDexChk.UseVisualStyleBackColor = True
        '
        'btnConChk
        '
        Me.btnConChk.Location = New System.Drawing.Point(12, 186)
        Me.btnConChk.Name = "btnConChk"
        Me.btnConChk.Size = New System.Drawing.Size(75, 23)
        Me.btnConChk.TabIndex = 11
        Me.btnConChk.Text = "&Constitution"
        Me.btnConChk.UseVisualStyleBackColor = True
        '
        'btnWisChk
        '
        Me.btnWisChk.Location = New System.Drawing.Point(12, 212)
        Me.btnWisChk.Name = "btnWisChk"
        Me.btnWisChk.Size = New System.Drawing.Size(75, 23)
        Me.btnWisChk.TabIndex = 12
        Me.btnWisChk.Text = "&Wisdom"
        Me.btnWisChk.UseVisualStyleBackColor = True
        '
        'btnIntChk
        '
        Me.btnIntChk.Location = New System.Drawing.Point(12, 238)
        Me.btnIntChk.Name = "btnIntChk"
        Me.btnIntChk.Size = New System.Drawing.Size(75, 23)
        Me.btnIntChk.TabIndex = 13
        Me.btnIntChk.Text = "&Intelligence"
        Me.btnIntChk.UseVisualStyleBackColor = True
        '
        'btnChaChk
        '
        Me.btnChaChk.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnChaChk.Location = New System.Drawing.Point(12, 264)
        Me.btnChaChk.Name = "btnChaChk"
        Me.btnChaChk.Size = New System.Drawing.Size(75, 23)
        Me.btnChaChk.TabIndex = 14
        Me.btnChaChk.Text = "&Charisma"
        Me.btnChaChk.UseVisualStyleBackColor = True
        '
        'txtDexChk
        '
        Me.txtDexChk.Location = New System.Drawing.Point(93, 162)
        Me.txtDexChk.Name = "txtDexChk"
        Me.txtDexChk.ReadOnly = True
        Me.txtDexChk.Size = New System.Drawing.Size(100, 20)
        Me.txtDexChk.TabIndex = 15
        Me.txtDexChk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtConChk
        '
        Me.txtConChk.Location = New System.Drawing.Point(93, 188)
        Me.txtConChk.Name = "txtConChk"
        Me.txtConChk.ReadOnly = True
        Me.txtConChk.Size = New System.Drawing.Size(100, 20)
        Me.txtConChk.TabIndex = 16
        Me.txtConChk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtWisChk
        '
        Me.txtWisChk.Location = New System.Drawing.Point(93, 214)
        Me.txtWisChk.Name = "txtWisChk"
        Me.txtWisChk.ReadOnly = True
        Me.txtWisChk.Size = New System.Drawing.Size(100, 20)
        Me.txtWisChk.TabIndex = 17
        Me.txtWisChk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIntChk
        '
        Me.txtIntChk.Location = New System.Drawing.Point(93, 240)
        Me.txtIntChk.Name = "txtIntChk"
        Me.txtIntChk.ReadOnly = True
        Me.txtIntChk.Size = New System.Drawing.Size(100, 20)
        Me.txtIntChk.TabIndex = 18
        Me.txtIntChk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtChaChk
        '
        Me.txtChaChk.Location = New System.Drawing.Point(93, 266)
        Me.txtChaChk.Name = "txtChaChk"
        Me.txtChaChk.ReadOnly = True
        Me.txtChaChk.Size = New System.Drawing.Size(100, 20)
        Me.txtChaChk.TabIndex = 19
        Me.txtChaChk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'rbtnAbil
        '
        Me.rbtnAbil.AutoSize = True
        Me.rbtnAbil.Checked = True
        Me.rbtnAbil.Location = New System.Drawing.Point(6, 19)
        Me.rbtnAbil.Name = "rbtnAbil"
        Me.rbtnAbil.Size = New System.Drawing.Size(52, 17)
        Me.rbtnAbil.TabIndex = 20
        Me.rbtnAbil.TabStop = True
        Me.rbtnAbil.Text = "Ability"
        Me.rbtnAbil.UseVisualStyleBackColor = True
        '
        'rbtnSkill
        '
        Me.rbtnSkill.AutoSize = True
        Me.rbtnSkill.Location = New System.Drawing.Point(64, 19)
        Me.rbtnSkill.Name = "rbtnSkill"
        Me.rbtnSkill.Size = New System.Drawing.Size(44, 17)
        Me.rbtnSkill.TabIndex = 21
        Me.rbtnSkill.TabStop = True
        Me.rbtnSkill.Text = "Skill"
        Me.rbtnSkill.UseVisualStyleBackColor = True
        '
        'gbxChkType
        '
        Me.gbxChkType.Controls.Add(Me.rbtnAbil)
        Me.gbxChkType.Controls.Add(Me.rbtnSkill)
        Me.gbxChkType.Location = New System.Drawing.Point(12, 12)
        Me.gbxChkType.Name = "gbxChkType"
        Me.gbxChkType.Size = New System.Drawing.Size(114, 47)
        Me.gbxChkType.TabIndex = 22
        Me.gbxChkType.TabStop = False
        Me.gbxChkType.Text = "Type of Check"
        '
        'frmAbilSkillRoll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(213, 339)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbxChkType)
        Me.Controls.Add(Me.txtChaChk)
        Me.Controls.Add(Me.txtIntChk)
        Me.Controls.Add(Me.txtWisChk)
        Me.Controls.Add(Me.txtConChk)
        Me.Controls.Add(Me.txtDexChk)
        Me.Controls.Add(Me.btnChaChk)
        Me.Controls.Add(Me.btnIntChk)
        Me.Controls.Add(Me.btnWisChk)
        Me.Controls.Add(Me.btnConChk)
        Me.Controls.Add(Me.btnDexChk)
        Me.Controls.Add(Me.txtStrChk)
        Me.Controls.Add(Me.btnStrChk)
        Me.Controls.Add(Me.txtPerc)
        Me.Controls.Add(Me.btnPerception)
        Me.Controls.Add(Me.btnOkay)
        Me.Controls.Add(Me.txtInit)
        Me.Controls.Add(Me.btnInit)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "frmAbilSkillRoll"
        Me.Text = "Ability Check"
        Me.gbxChkType.ResumeLayout(False)
        Me.gbxChkType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnInit As System.Windows.Forms.Button
    Friend WithEvents txtInit As System.Windows.Forms.TextBox
    Friend WithEvents btnOkay As System.Windows.Forms.Button
    Friend WithEvents btnPerception As System.Windows.Forms.Button
    Friend WithEvents txtPerc As System.Windows.Forms.TextBox
    Friend WithEvents btnStrChk As System.Windows.Forms.Button
    Friend WithEvents txtStrChk As System.Windows.Forms.TextBox
    Friend WithEvents btnDexChk As System.Windows.Forms.Button
    Friend WithEvents btnConChk As System.Windows.Forms.Button
    Friend WithEvents btnWisChk As System.Windows.Forms.Button
    Friend WithEvents btnIntChk As System.Windows.Forms.Button
    Friend WithEvents btnChaChk As System.Windows.Forms.Button
    Friend WithEvents txtDexChk As System.Windows.Forms.TextBox
    Friend WithEvents txtConChk As System.Windows.Forms.TextBox
    Friend WithEvents txtWisChk As System.Windows.Forms.TextBox
    Friend WithEvents txtIntChk As System.Windows.Forms.TextBox
    Friend WithEvents txtChaChk As System.Windows.Forms.TextBox
    Friend WithEvents rbtnAbil As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnSkill As System.Windows.Forms.RadioButton
    Friend WithEvents gbxChkType As System.Windows.Forms.GroupBox
End Class
