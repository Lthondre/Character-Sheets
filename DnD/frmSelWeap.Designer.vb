﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelWeap
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvWeapons = New System.Windows.Forms.DataGridView()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.wID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.wName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.wWeight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.wArmorBonus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.wCheck = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.wPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvWeapons, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvWeapons
        '
        Me.dgvWeapons.AllowUserToDeleteRows = False
        Me.dgvWeapons.AllowUserToResizeColumns = False
        Me.dgvWeapons.AllowUserToResizeRows = False
        Me.dgvWeapons.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvWeapons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvWeapons.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.wID, Me.wName, Me.wWeight, Me.wArmorBonus, Me.wCheck, Me.wPrice})
        Me.dgvWeapons.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvWeapons.Location = New System.Drawing.Point(0, 0)
        Me.dgvWeapons.MultiSelect = False
        Me.dgvWeapons.Name = "dgvWeapons"
        Me.dgvWeapons.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvWeapons.Size = New System.Drawing.Size(718, 306)
        Me.dgvWeapons.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(631, 312)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(12, 312)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'wID
        '
        Me.wID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.wID.HeaderText = "weapon ID"
        Me.wID.Name = "wID"
        Me.wID.ReadOnly = True
        Me.wID.Visible = False
        Me.wID.Width = 84
        '
        'wName
        '
        Me.wName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.wName.HeaderText = "Weapon Name"
        Me.wName.Name = "wName"
        Me.wName.ReadOnly = True
        '
        'wWeight
        '
        Me.wWeight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.wWeight.DefaultCellStyle = DataGridViewCellStyle1
        Me.wWeight.HeaderText = "Weight (Pounds)"
        Me.wWeight.Name = "wWeight"
        Me.wWeight.ReadOnly = True
        Me.wWeight.Width = 102
        '
        'wArmorBonus
        '
        Me.wArmorBonus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.wArmorBonus.DefaultCellStyle = DataGridViewCellStyle2
        Me.wArmorBonus.HeaderText = "Armor Bonus"
        Me.wArmorBonus.Name = "wArmorBonus"
        Me.wArmorBonus.ReadOnly = True
        Me.wArmorBonus.Width = 85
        '
        'wCheck
        '
        Me.wCheck.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.wCheck.DefaultCellStyle = DataGridViewCellStyle3
        Me.wCheck.HeaderText = "Check Modifier"
        Me.wCheck.Name = "wCheck"
        Me.wCheck.ReadOnly = True
        Me.wCheck.Width = 95
        '
        'wPrice
        '
        Me.wPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.wPrice.DefaultCellStyle = DataGridViewCellStyle4
        Me.wPrice.HeaderText = "Price (Gold)"
        Me.wPrice.Name = "wPrice"
        Me.wPrice.ReadOnly = True
        Me.wPrice.Width = 80
        '
        'frmSelWeap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 347)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.dgvWeapons)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSelWeap"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Select a Weapon"
        CType(Me.dgvWeapons, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvWeapons As System.Windows.Forms.DataGridView
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents wID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents wName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents wWeight As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents wArmorBonus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents wCheck As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents wPrice As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
