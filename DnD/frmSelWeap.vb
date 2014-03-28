Public Class frmSelWeap
    Public dtext As String = ""
    Public dtag As Integer
    Public darmBonus As Integer
    Public dcheckMod As Integer
    Public dweight As Integer
    Public dprice As Integer

    Private Sub frmSelWeap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvWeapons.Rows.Clear() 'fresh datagrid every time
        With frmSelPlayer
            'adds all weapons in database to the datagrid view for user output
            For i As Integer = 0 To .Weapon.Length - 1
                dgvWeapons.Rows.Insert(i, New String() {.Weapon(i).WID, .Weapon(i).name, .Weapon(i).wgt, .Weapon(i).armor, .Weapon(i).check, .Weapon(i).price})
            Next
        End With
    End Sub

    Private Sub dgvWeapons_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvWeapons.CellDoubleClick
        'change the weapon name and tag back in frmCharSheet
        dtag = dgvWeapons.Item(0, e.RowIndex).Value.ToString
        dtext = dgvWeapons.Item(1, e.RowIndex).Value.ToString
        dweight = dgvWeapons.Item(2, e.RowIndex).Value.ToString
        darmBonus = dgvWeapons.Item(3, e.RowIndex).Value.ToString
        dcheckMod = dgvWeapons.Item(4, e.RowIndex).Value.ToString
        dprice = dgvWeapons.Item(5, e.RowIndex).Value.ToString

        'close the form
        Me.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'close the form
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'add a new weapon to the datagrid
        frmAddWeap.ShowDialog()
        frmAddWeap.Dispose()
    End Sub
End Class