Public Class frmSelArmor
    Public dtext As String = ""
    Public dtag As Long
    Public darmBonus As Integer
    Public dcheckMod As Integer
    Public dweight As Integer
    Public dprice As Double
    Public dClass As String
    Public dtype As String
    'ability score modifiers
    Public dCON As Integer
    Public dINT As Integer
    Public dCHA As Integer
    Public dWIS As Integer
    Public dSTR As Integer
    Public dDEX As Integer

    Public tagVal As Integer = mdlGlobal.theTag

    Private Sub frmSelArmor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'I've tried just about every fucking thing to get this to work. tagVal MUST be taken from a module
        'form must also be disposed every time it's called or tagVal will not update to newest value from module
        If tagVal < 1 Or tagVal > 9 Then
            MessageBox.Show("Warning! Selected armor button is not attributed. Default to showing all.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        'select the default tab based on which button the user clicked in the CharSheet form
        Select Case tagVal
            Case 1
                tabArmor.SelectedTab = tabHelm
            Case 2
                tabArmor.SelectedTab = tabNeck
            Case 3
                tabArmor.SelectedTab = tabChest
            Case 4
                tabArmor.SelectedTab = tabArms
            Case 5
                tabArmor.SelectedTab = tabHands
            Case 6
                tabArmor.SelectedTab = tabLegs
            Case 7
                tabArmor.SelectedTab = tabFeet
            Case 8
                tabArmor.SelectedTab = tabWrists
            Case 9
                tabArmor.SelectedTab = tabAll
        End Select

        'fresh datagrids every time
        dgvArmor.Rows.Clear()
        dgvHead.Rows.Clear()
        dgvChest.Rows.Clear()
        dgvArms.Rows.Clear()
        dgvHands.Rows.Clear()
        dgvLegs.Rows.Clear()
        dgvFeet.Rows.Clear()
        dgvNeck.Rows.Clear()

        'loads all armor into all datagrids
        Call loadArmor()
    End Sub

    ''' <summary>
    ''' on doubleclick, adds selected armor to variables, so the can be added back in parent form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dgvWeapons_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvArmor.CellDoubleClick, dgvHead.CellDoubleClick, _
                                                                                                    dgvChest.CellDoubleClick, dgvArms.CellDoubleClick, _
                                                                                                    dgvWrists.CellDoubleClick, dgvHands.CellDoubleClick, _
                                                                                                    dgvLegs.CellDoubleClick, dgvFeet.CellDoubleClick, _
                                                                                                    dgvNeck.CellDoubleClick

        'change the weapon name and tag back in frmCharSheet
        dtag = sender.Item(0, e.RowIndex).Value.ToString
        dtext = sender.Item(1, e.RowIndex).Value.ToString
        dweight = sender.item(2, e.RowIndex).value.ToString
        darmBonus = sender.item(3, e.RowIndex).value.ToString
        dcheckMod = sender.item(4, e.RowIndex).value.ToString
        dprice = sender.item(5, e.RowIndex).value.ToString
        dClass = sender.item(6, e.RowIndex).value.ToString
        dtype = sender.Item(7, e.RowIndex).Value.ToString
        'armor abil mods
        dSTR = sender.item(8, e.RowIndex).value.ToString
        dDEX = sender.item(9, e.RowIndex).value.ToString
        dWIS = sender.item(10, e.RowIndex).value.ToString
        dCHA = sender.item(11, e.RowIndex).value.ToString
        dINT = sender.item(12, e.RowIndex).value.ToString
        dCON = sender.item(13, e.RowIndex).value.ToString

        Console.WriteLine("Str:" & dSTR)
        Console.WriteLine("dex:" & dDEX)
        Console.WriteLine("wis:" & dWIS)
        Console.WriteLine("cha:" & dCHA)
        Console.WriteLine("int:" & dINT)
        Console.WriteLine("con:" & dCON)
        'close the form
        Me.Close()
    End Sub

    ''' <summary>
    ''' closes form making no changes
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'close the form
        Me.Close()
    End Sub

    ''' <summary>
    ''' show dialog for adding new armor
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'add new armor to the datagrid
        frmAddArmor.ShowDialog()
        frmAddArmor.Dispose()
    End Sub

    ''' <summary>
    ''' loads new armor to corresponding armor datagridviews
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub loadArmor()
        dgvHead.Rows.Clear()
        With frmSelPlayer
            'adds all weapons in database to the datagrid view for user output
            For i As Integer = 0 To .Armor.Length - 1
                'add everything to all
                dgvArmor.Rows.Insert(dgvArmor.Rows.Count - 1, New String() {.Armor(i).AID, .Armor(i).name, .Armor(i).wgt, .Armor(i).ACBon, .Armor(i).chkMod, .Armor(i).price, .Armor(i).aClass, .Armor(i).type, .Armor(i).str, .Armor(i).dex, .Armor(i).wis, .Armor(i).cha, .Armor(i).int, .Armor(i).con})
                'add to specific datagrid
                If LCase(.Armor(i).type) = LCase("helm") Then
                    dgvHead.Rows.Insert(dgvHead.Rows.Count - 1, New String() {.Armor(i).AID, .Armor(i).name, .Armor(i).wgt, .Armor(i).ACBon, .Armor(i).chkMod, .Armor(i).price, .Armor(i).aClass, .Armor(i).type, .Armor(i).str, .Armor(i).dex, .Armor(i).wis, .Armor(i).cha, .Armor(i).int, .Armor(i).con})
                ElseIf LCase(.Armor(i).type) = LCase("legs") Then
                    dgvLegs.Rows.Insert(dgvLegs.Rows.Count - 1, New String() {.Armor(i).AID, .Armor(i).name, .Armor(i).wgt, .Armor(i).ACBon, .Armor(i).chkMod, .Armor(i).price, .Armor(i).aClass, .Armor(i).type, .Armor(i).str, .Armor(i).dex, .Armor(i).wis, .Armor(i).cha, .Armor(i).int, .Armor(i).con})
                ElseIf LCase(.Armor(i).type) = LCase("arms") Then
                    dgvArms.Rows.Insert(dgvArms.Rows.Count - 1, New String() {.Armor(i).AID, .Armor(i).name, .Armor(i).wgt, .Armor(i).ACBon, .Armor(i).chkMod, .Armor(i).price, .Armor(i).aClass, .Armor(i).type, .Armor(i).str, .Armor(i).dex, .Armor(i).wis, .Armor(i).cha, .Armor(i).int, .Armor(i).con})
                ElseIf LCase(.Armor(i).type) = LCase("chest") Then
                    dgvChest.Rows.Insert(dgvChest.Rows.Count - 1, New String() {.Armor(i).AID, .Armor(i).name, .Armor(i).wgt, .Armor(i).ACBon, .Armor(i).chkMod, .Armor(i).price, .Armor(i).aClass, .Armor(i).type, .Armor(i).str, .Armor(i).dex, .Armor(i).wis, .Armor(i).cha, .Armor(i).int, .Armor(i).con})
                ElseIf LCase(.Armor(i).type) = LCase("neck") Then
                    dgvNeck.Rows.Insert(dgvNeck.Rows.Count - 1, New String() {.Armor(i).AID, .Armor(i).name, .Armor(i).wgt, .Armor(i).ACBon, .Armor(i).chkMod, .Armor(i).price, .Armor(i).aClass, .Armor(i).type, .Armor(i).str, .Armor(i).dex, .Armor(i).wis, .Armor(i).cha, .Armor(i).int, .Armor(i).con})
                ElseIf LCase(.Armor(i).type) = LCase("feet") Then
                    dgvFeet.Rows.Insert(dgvFeet.Rows.Count - 1, New String() {.Armor(i).AID, .Armor(i).name, .Armor(i).wgt, .Armor(i).ACBon, .Armor(i).chkMod, .Armor(i).price, .Armor(i).aClass, .Armor(i).type, .Armor(i).str, .Armor(i).dex, .Armor(i).wis, .Armor(i).cha, .Armor(i).int, .Armor(i).con})
                ElseIf LCase(.Armor(i).type) = LCase("wrists") Then
                    dgvWrists.Rows.Insert(dgvWrists.Rows.Count - 1, New String() {.Armor(i).AID, .Armor(i).name, .Armor(i).wgt, .Armor(i).ACBon, .Armor(i).chkMod, .Armor(i).price, .Armor(i).aClass, .Armor(i).type, .Armor(i).str, .Armor(i).dex, .Armor(i).wis, .Armor(i).cha, .Armor(i).int, .Armor(i).con})
                ElseIf LCase(.Armor(i).type) = LCase("hands") Then
                    dgvHands.Rows.Insert(dgvHands.Rows.Count - 1, New String() {.Armor(i).AID, .Armor(i).name, .Armor(i).wgt, .Armor(i).ACBon, .Armor(i).chkMod, .Armor(i).price, .Armor(i).aClass, .Armor(i).type, .Armor(i).str, .Armor(i).dex, .Armor(i).wis, .Armor(i).cha, .Armor(i).int, .Armor(i).con})
                ElseIf LCase(.Armor(i).type) = LCase("none") Then
                    'add oddballs to everything (such as unequipped)
                    dgvHead.Rows.Insert(dgvHead.Rows.Count - 1, New String() {.Armor(i).AID, .Armor(i).name, .Armor(i).wgt, .Armor(i).ACBon, .Armor(i).chkMod, .Armor(i).price, .Armor(i).aClass, .Armor(i).type, .Armor(i).str, .Armor(i).dex, .Armor(i).wis, .Armor(i).cha, .Armor(i).int, .Armor(i).con})
                    dgvLegs.Rows.Insert(dgvLegs.Rows.Count - 1, New String() {.Armor(i).AID, .Armor(i).name, .Armor(i).wgt, .Armor(i).ACBon, .Armor(i).chkMod, .Armor(i).price, .Armor(i).aClass, .Armor(i).type, .Armor(i).str, .Armor(i).dex, .Armor(i).wis, .Armor(i).cha, .Armor(i).int, .Armor(i).con})
                    dgvArms.Rows.Insert(dgvArms.Rows.Count - 1, New String() {.Armor(i).AID, .Armor(i).name, .Armor(i).wgt, .Armor(i).ACBon, .Armor(i).chkMod, .Armor(i).price, .Armor(i).aClass, .Armor(i).type, .Armor(i).str, .Armor(i).dex, .Armor(i).wis, .Armor(i).cha, .Armor(i).int, .Armor(i).con})
                    dgvChest.Rows.Insert(dgvChest.Rows.Count - 1, New String() {.Armor(i).AID, .Armor(i).name, .Armor(i).wgt, .Armor(i).ACBon, .Armor(i).chkMod, .Armor(i).price, .Armor(i).aClass, .Armor(i).type, .Armor(i).str, .Armor(i).dex, .Armor(i).wis, .Armor(i).cha, .Armor(i).int, .Armor(i).con})
                    dgvNeck.Rows.Insert(dgvNeck.Rows.Count - 1, New String() {.Armor(i).AID, .Armor(i).name, .Armor(i).wgt, .Armor(i).ACBon, .Armor(i).chkMod, .Armor(i).price, .Armor(i).aClass, .Armor(i).type, .Armor(i).str, .Armor(i).dex, .Armor(i).wis, .Armor(i).cha, .Armor(i).int, .Armor(i).con})
                    dgvFeet.Rows.Insert(dgvFeet.Rows.Count - 1, New String() {.Armor(i).AID, .Armor(i).name, .Armor(i).wgt, .Armor(i).ACBon, .Armor(i).chkMod, .Armor(i).price, .Armor(i).aClass, .Armor(i).type, .Armor(i).str, .Armor(i).dex, .Armor(i).wis, .Armor(i).cha, .Armor(i).int, .Armor(i).con})
                    dgvWrists.Rows.Insert(dgvWrists.Rows.Count - 1, New String() {.Armor(i).AID, .Armor(i).name, .Armor(i).wgt, .Armor(i).ACBon, .Armor(i).chkMod, .Armor(i).price, .Armor(i).aClass, .Armor(i).type, .Armor(i).str, .Armor(i).dex, .Armor(i).wis, .Armor(i).cha, .Armor(i).int, .Armor(i).con})
                    dgvHands.Rows.Insert(dgvHands.Rows.Count - 1, New String() {.Armor(i).AID, .Armor(i).name, .Armor(i).wgt, .Armor(i).ACBon, .Armor(i).chkMod, .Armor(i).price, .Armor(i).aClass, .Armor(i).type, .Armor(i).str, .Armor(i).dex, .Armor(i).wis, .Armor(i).cha, .Armor(i).int, .Armor(i).con})
                End If
            Next
        End With
    End Sub
End Class