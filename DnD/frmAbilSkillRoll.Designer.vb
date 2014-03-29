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
        Me.rbtnAbility = New System.Windows.Forms.RadioButton()
        Me.rbtnSkill = New System.Windows.Forms.RadioButton()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnInit = New System.Windows.Forms.Button()
        Me.txtInit = New System.Windows.Forms.TextBox()
        Me.btnOkay = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rbtnAbility
        '
        Me.rbtnAbility.AutoSize = True
        Me.rbtnAbility.Location = New System.Drawing.Point(12, 12)
        Me.rbtnAbility.Name = "rbtnAbility"
        Me.rbtnAbility.Size = New System.Drawing.Size(52, 17)
        Me.rbtnAbility.TabIndex = 0
        Me.rbtnAbility.TabStop = True
        Me.rbtnAbility.Text = "Ability"
        Me.rbtnAbility.UseVisualStyleBackColor = True
        '
        'rbtnSkill
        '
        Me.rbtnSkill.AutoSize = True
        Me.rbtnSkill.Location = New System.Drawing.Point(70, 12)
        Me.rbtnSkill.Name = "rbtnSkill"
        Me.rbtnSkill.Size = New System.Drawing.Size(44, 17)
        Me.rbtnSkill.TabIndex = 1
        Me.rbtnSkill.TabStop = True
        Me.rbtnSkill.Text = "Skill"
        Me.rbtnSkill.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(401, 383)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnInit
        '
        Me.btnInit.Location = New System.Drawing.Point(13, 50)
        Me.btnInit.Name = "btnInit"
        Me.btnInit.Size = New System.Drawing.Size(75, 23)
        Me.btnInit.TabIndex = 3
        Me.btnInit.Text = "&Initiative"
        Me.btnInit.UseVisualStyleBackColor = True
        '
        'txtInit
        '
        Me.txtInit.Location = New System.Drawing.Point(95, 50)
        Me.txtInit.Name = "txtInit"
        Me.txtInit.Size = New System.Drawing.Size(100, 20)
        Me.txtInit.TabIndex = 4
        '
        'btnOkay
        '
        Me.btnOkay.Location = New System.Drawing.Point(12, 383)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.Size = New System.Drawing.Size(75, 23)
        Me.btnOkay.TabIndex = 5
        Me.btnOkay.Text = "&Okay"
        Me.btnOkay.UseVisualStyleBackColor = True
        '
        'frmAbilSkillRoll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 418)
        Me.Controls.Add(Me.btnOkay)
        Me.Controls.Add(Me.txtInit)
        Me.Controls.Add(Me.btnInit)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.rbtnSkill)
        Me.Controls.Add(Me.rbtnAbility)
        Me.Name = "frmAbilSkillRoll"
        Me.Text = "frmAbilSkillRoll"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbtnAbility As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnSkill As System.Windows.Forms.RadioButton
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnInit As System.Windows.Forms.Button
    Friend WithEvents txtInit As System.Windows.Forms.TextBox
    Friend WithEvents btnOkay As System.Windows.Forms.Button
End Class
