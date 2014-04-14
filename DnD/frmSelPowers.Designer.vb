<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelPowers
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
        Me.tabPowers = New System.Windows.Forms.TabControl()
        Me.tabCantrip = New System.Windows.Forms.TabPage()
        Me.dgvCantrips = New System.Windows.Forms.DataGridView()
        Me.tabEncs = New System.Windows.Forms.TabPage()
        Me.dgvEncounters = New System.Windows.Forms.DataGridView()
        Me.tabDay = New System.Windows.Forms.TabPage()
        Me.dgvDailies = New System.Windows.Forms.DataGridView()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.tabPowers.SuspendLayout()
        Me.tabCantrip.SuspendLayout()
        CType(Me.dgvCantrips, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabEncs.SuspendLayout()
        CType(Me.dgvEncounters, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDay.SuspendLayout()
        CType(Me.dgvDailies, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabPowers
        '
        Me.tabPowers.Controls.Add(Me.tabCantrip)
        Me.tabPowers.Controls.Add(Me.tabEncs)
        Me.tabPowers.Controls.Add(Me.tabDay)
        Me.tabPowers.Dock = System.Windows.Forms.DockStyle.Top
        Me.tabPowers.Location = New System.Drawing.Point(0, 0)
        Me.tabPowers.Name = "tabPowers"
        Me.tabPowers.SelectedIndex = 0
        Me.tabPowers.Size = New System.Drawing.Size(1248, 377)
        Me.tabPowers.TabIndex = 0
        '
        'tabCantrip
        '
        Me.tabCantrip.Controls.Add(Me.dgvCantrips)
        Me.tabCantrip.Location = New System.Drawing.Point(4, 22)
        Me.tabCantrip.Name = "tabCantrip"
        Me.tabCantrip.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCantrip.Size = New System.Drawing.Size(1240, 351)
        Me.tabCantrip.TabIndex = 0
        Me.tabCantrip.Text = "Cantrips"
        Me.tabCantrip.UseVisualStyleBackColor = True
        '
        'dgvCantrips
        '
        Me.dgvCantrips.AllowUserToAddRows = False
        Me.dgvCantrips.AllowUserToDeleteRows = False
        Me.dgvCantrips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCantrips.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCantrips.Location = New System.Drawing.Point(3, 3)
        Me.dgvCantrips.Name = "dgvCantrips"
        Me.dgvCantrips.ReadOnly = True
        Me.dgvCantrips.Size = New System.Drawing.Size(1234, 345)
        Me.dgvCantrips.TabIndex = 0
        '
        'tabEncs
        '
        Me.tabEncs.Controls.Add(Me.dgvEncounters)
        Me.tabEncs.Location = New System.Drawing.Point(4, 22)
        Me.tabEncs.Name = "tabEncs"
        Me.tabEncs.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEncs.Size = New System.Drawing.Size(1240, 351)
        Me.tabEncs.TabIndex = 1
        Me.tabEncs.Text = "Encounters"
        Me.tabEncs.UseVisualStyleBackColor = True
        '
        'dgvEncounters
        '
        Me.dgvEncounters.AllowUserToAddRows = False
        Me.dgvEncounters.AllowUserToDeleteRows = False
        Me.dgvEncounters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEncounters.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEncounters.Location = New System.Drawing.Point(3, 3)
        Me.dgvEncounters.Name = "dgvEncounters"
        Me.dgvEncounters.ReadOnly = True
        Me.dgvEncounters.Size = New System.Drawing.Size(1234, 345)
        Me.dgvEncounters.TabIndex = 0
        '
        'tabDay
        '
        Me.tabDay.Controls.Add(Me.dgvDailies)
        Me.tabDay.Location = New System.Drawing.Point(4, 22)
        Me.tabDay.Name = "tabDay"
        Me.tabDay.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDay.Size = New System.Drawing.Size(1240, 351)
        Me.tabDay.TabIndex = 2
        Me.tabDay.Text = "Dailies"
        Me.tabDay.UseVisualStyleBackColor = True
        '
        'dgvDailies
        '
        Me.dgvDailies.AllowUserToAddRows = False
        Me.dgvDailies.AllowUserToDeleteRows = False
        Me.dgvDailies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDailies.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDailies.Location = New System.Drawing.Point(3, 3)
        Me.dgvDailies.Name = "dgvDailies"
        Me.dgvDailies.ReadOnly = True
        Me.dgvDailies.Size = New System.Drawing.Size(1234, 345)
        Me.dgvDailies.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(1161, 383)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmSelPowers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(1248, 413)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.tabPowers)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Name = "frmSelPowers"
        Me.ShowIcon = False
        Me.Text = "Powers"
        Me.tabPowers.ResumeLayout(False)
        Me.tabCantrip.ResumeLayout(False)
        CType(Me.dgvCantrips, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabEncs.ResumeLayout(False)
        CType(Me.dgvEncounters, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDay.ResumeLayout(False)
        CType(Me.dgvDailies, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabPowers As System.Windows.Forms.TabControl
    Friend WithEvents tabCantrip As System.Windows.Forms.TabPage
    Friend WithEvents dgvCantrips As System.Windows.Forms.DataGridView
    Friend WithEvents tabEncs As System.Windows.Forms.TabPage
    Friend WithEvents tabDay As System.Windows.Forms.TabPage
    Friend WithEvents dgvEncounters As System.Windows.Forms.DataGridView
    Friend WithEvents dgvDailies As System.Windows.Forms.DataGridView
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
