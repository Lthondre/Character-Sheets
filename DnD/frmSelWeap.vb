Public Class frmSelWeap
#Region "Form Variables"
    Public dtext As String = ""
    Public dtag As Integer
    Public darmBonus As Integer
    Public dcheckMod As Integer
    Public dweight As Integer
    Public dprice As Integer
    Public dSTR As Integer
    Public dDEX As Integer
    Public dWIS As Integer
    Public dCHA As Integer
    Public dINT As Integer
    Public dCON As Integer
#End Region

    ''' <summary>
    ''' load weapons on form load
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmSelWeap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvWeapons.Rows.Clear() 'fresh datagrid every time
        With frmSelPlayer
            'adds all weapons in database to the datagrid view for user output
            For i As Integer = 0 To .Weapon.Length - 1
                dgvWeapons.Rows.Insert(i, New String() {.Weapon(i).WID, .Weapon(i).name, .Weapon(i).wgt, .Weapon(i).armor, .Weapon(i).check, .Weapon(i).price, .Weapon(i).str, .Weapon(i).dex, .Weapon(i).wis, .Weapon(i).cha, .Weapon(i).int, .Weapon(i).con})
            Next
        End With
    End Sub

    ''' <summary>
    ''' set corresponding variables on cell double click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dgvWeapons_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvWeapons.CellDoubleClick
        'change the weapon name and tag back in frmCharSheet
        dtag = dgvWeapons.Item(0, e.RowIndex).Value.ToString
        dtext = dgvWeapons.Item(1, e.RowIndex).Value.ToString
        dweight = dgvWeapons.Item(2, e.RowIndex).Value.ToString
        darmBonus = dgvWeapons.Item(3, e.RowIndex).Value.ToString
        dcheckMod = dgvWeapons.Item(4, e.RowIndex).Value.ToString
        dprice = dgvWeapons.Item(5, e.RowIndex).Value.ToString
        'armor abil mods
        dSTR = sender.item(6, e.RowIndex).value.ToString
        dDEX = sender.item(7, e.RowIndex).value.ToString
        dWIS = sender.item(8, e.RowIndex).value.ToString
        dCHA = sender.item(9, e.RowIndex).value.ToString
        dINT = sender.item(10, e.RowIndex).value.ToString
        dCON = sender.item(11, e.RowIndex).value.ToString

        'close the form
        Me.Close()
    End Sub

    ''' <summary>
    ''' close the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'close the form
        Me.Close()
    End Sub

    ''' <summary>
    ''' add new weapon
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'add a new weapon to the datagrid
        frmAddWeap.ShowDialog()
        frmAddWeap.Dispose()
    End Sub
End Class