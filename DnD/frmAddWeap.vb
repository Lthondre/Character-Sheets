﻿Public Class frmAddWeap
    Dim duplicate As Boolean = False

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'close the form
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'add the record to the datagridview
        If txtName.Text = "" Then
            MessageBox.Show("Enter a Weapon Name", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtName.Focus()
        ElseIf txtWgt.Text = "" Then
            MessageBox.Show("Enter a Weapon Weight", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtWgt.Focus()
        ElseIf txtArm.Text = "" Then
            MessageBox.Show("Enter a Weapon Armor Bonus", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtArm.Focus()
        ElseIf txtChk.Text = "" Then
            MessageBox.Show("Enter a Weapon Check Modifier", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtChk.Focus()
        ElseIf txtPrice.Text = "" Then
            MessageBox.Show("Enter a Weapon Price", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPrice.Focus()
        Else
            'add new weapon!
            With frmSelWeap
                'validate not a duplicate entry
                For i As Integer = 0 To .dgvWeapons.Rows(.dgvWeapons.Rows.Count - 2).Index
                    'if the textbox equals a name in the datagrid, then don't add it.
                    If LCase(txtName.Text) = LCase(.dgvWeapons.Rows(i).Cells(1).Value) Then
                        'only need to find one duplicate
                        duplicate = True
                        MessageBox.Show("Duplicate Entry found: " & .dgvWeapons.Rows(i).Cells(1).Value, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Next
                'if no duplicates were found, you can go ahead and add the new weapon
                If duplicate = False Then
                    'index of row after last row in datagrid
                    Dim idx As Integer = .dgvWeapons.Rows(.dgvWeapons.Rows.Count - 2).Index + 1
                    'weapon id of row after last weapon in datagrid
                    Dim tag As Integer = .dgvWeapons.Rows(.dgvWeapons.Rows.Count - 2).Cells(0).Value + 1

                    'increase size of array by one
                    ReDim Preserve frmSelPlayer.Weapon(frmSelPlayer.Weapon.Length)
                    frmSelPlayer.Weapon(frmSelPlayer.Weapon.Length - 1).name = txtName.Text
                    frmSelPlayer.Weapon(frmSelPlayer.Weapon.Length - 1).check = txtChk.Text
                    frmSelPlayer.Weapon(frmSelPlayer.Weapon.Length - 1).armor = txtArm.Text
                    frmSelPlayer.Weapon(frmSelPlayer.Weapon.Length - 1).wgt = txtWgt.Text
                    frmSelPlayer.Weapon(frmSelPlayer.Weapon.Length - 1).price = txtPrice.Text
                    frmSelPlayer.Weapon(frmSelPlayer.Weapon.Length - 1).WID = tag

                    'add new weapon to database
                    'create new instance of class
                    Dim WeaponData As New clsData
                    'pass connection string
                    WeaponData.ConnectionString = mdlGlobal.strConnection
                    'pass SQL command
                    WeaponData.SQL = "SELECT * FROM tblWeaps WHERE wID = 0"
                    'create new row for database
                    Dim dsNewRow As DataRow = WeaponData.ds.Tables(0).NewRow
                    'fill each field based on text boxes
                    With dsNewRow
                        .Item("wName") = txtName.Text
                        .Item("wChkMod") = txtChk.Text
                        .Item("wArmBon") = txtArm.Text
                        .Item("wWgt") = txtWgt.Text
                        .Item("wPrice") = txtPrice.Text
                    End With
                    'add row to dataset
                    WeaponData.ds.Tables(0).Rows.Add(dsNewRow)
                    'update database
                    WeaponData.da.Update(WeaponData.ds)

                    'add values to datagrid
                    .dgvWeapons.Rows.Insert(idx, New String() {tag, txtName.Text, txtWgt.Value, txtArm.Value, txtChk.Value, txtPrice.Value})

                    'close the form after adding a new weapon
                    Me.Close()
                End If
                'reset duplicate value so you can test again
                duplicate = False
            End With
        End If
    End Sub
End Class