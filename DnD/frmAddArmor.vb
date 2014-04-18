Public Class frmAddArmor
    Dim duplicate As Boolean = False

    ''' <summary>
    ''' Closes the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'close form
        Me.Close()
    End Sub

    ''' <summary>
    ''' adds the new armor piece
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'only thing need to check on the form, since everything else is self-validating
        If txtName.Text = "" Then
            MessageBox.Show("Enter an armor Name", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtName.Focus()
        Else
            'add new armor piece!
            With frmSelArmor
                'validate not a duplicate entry
                For i As Integer = 0 To .dgvArmor.Rows(.dgvArmor.Rows.Count - 2).Index
                    'if the textbox equals a name in the all datagrid, then don't add it.
                    If LCase(txtName.Text) = LCase(.dgvArmor.Rows(i).Cells(1).Value) Then
                        'only need to find one duplicate
                        duplicate = True
                        MessageBox.Show("Duplicate Entry found: " & .dgvArmor.Rows(i).Cells(1).Value, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Next
                'if no duplicates were found, you can go ahead and add the new armor
                If duplicate = False Then
                    'index of row after last row in datagrid
                    Dim idx As Integer = .dgvArmor.Rows(.dgvArmor.Rows.Count - 2).Index + 1
                    'find highest AID in table
                    Dim highest = frmSelPlayer.Armor(0).AID
                    For i As Integer = 0 To .dgvArmor.Rows.Count - 2
                        Console.WriteLine(.dgvArmor.Rows(i).Cells(0).Value.ToString)
                        If .dgvArmor.Rows(i).Cells(0).Value.ToString > highest Then
                            highest = .dgvArmor.Rows(i).Cells(0).Value.ToString
                        End If
                    Next
                    Console.WriteLine("Highest AID in table: " & highest)
                    highest += 1

                    'increase size of array by one and add new armor
                    ReDim Preserve frmSelPlayer.Armor(frmSelPlayer.Armor.Length)
                    frmSelPlayer.Armor(frmSelPlayer.Armor.Length - 1).wgt = numArmBon.Value
                    frmSelPlayer.Armor(frmSelPlayer.Armor.Length - 1).ACBon = numArmBon.Value
                    frmSelPlayer.Armor(frmSelPlayer.Armor.Length - 1).aClass = cboClass.Text
                    frmSelPlayer.Armor(frmSelPlayer.Armor.Length - 1).chkMod = numChk.Value
                    frmSelPlayer.Armor(frmSelPlayer.Armor.Length - 1).price = numPrice.Value
                    frmSelPlayer.Armor(frmSelPlayer.Armor.Length - 1).name = txtName.Text
                    frmSelPlayer.Armor(frmSelPlayer.Armor.Length - 1).type = cboType.Text
                    'ability mods
                    frmSelPlayer.Armor(frmSelPlayer.Armor.Length - 1).str = numStr.Value
                    frmSelPlayer.Armor(frmSelPlayer.Armor.Length - 1).dex = numDex.Value
                    frmSelPlayer.Armor(frmSelPlayer.Armor.Length - 1).wis = numWis.Value
                    frmSelPlayer.Armor(frmSelPlayer.Armor.Length - 1).cha = numCha.Value
                    frmSelPlayer.Armor(frmSelPlayer.Armor.Length - 1).int = numInt.Value
                    frmSelPlayer.Armor(frmSelPlayer.Armor.Length - 1).con = numCon.Value
                    frmSelPlayer.Armor(frmSelPlayer.Armor.Length - 1).AID = highest

                    'add new armor to database
                    'create new instance of class
                    Dim ArmorData As New clsData
                    'pass connection string
                    ArmorData.ConnectionString = mdlGlobal.strConnection
                    'pass SQL command
                    ArmorData.SQL = "SELECT * FROM tblArmor WHERE aID = 0"
                    'create new row for database
                    Dim dsNewRow As DataRow = ArmorData.ds.Tables(0).NewRow
                    'fill each field based on text boxes
                    With dsNewRow
                        .Item("aWgt") = numWgt.Value
                        .Item("aACBon") = numArmBon.Value
                        .Item("aClass") = cboClass.Text
                        .Item("aChkMod") = numChk.Value
                        .Item("aPrice") = numPrice.Value
                        .Item("aName") = txtName.Text
                        .Item("aType") = cboType.Text
                        'abil mods
                        .Item("aSTR") = numStr.Value
                        .Item("aDEX") = numDex.Value
                        .Item("aWIS") = numWis.Value
                        .Item("aCHA") = numCha.Value
                        .Item("aINT") = numInt.Value
                        .Item("aCON") = numCon.Value
                    End With
                    'add row to dataset
                    ArmorData.ds.Tables(0).Rows.Add(dsNewRow)
                    'update database
                    ArmorData.da.Update(ArmorData.ds)

                    'add values to datagrid
                    .dgvArmor.Rows.Insert(.dgvArmor.Rows(.dgvArmor.Rows.Count - 2).Index + 1, New String() {highest, txtName.Text, numWgt.Value, numArmBon.Value, numChk.Value, numPrice.Value, cboClass.Text, LCase(cboType.Text)})
                    'add to specific datagrid
                    If LCase(cboType.Text) = "head" Then
                        .dgvHead.Rows.Insert(.dgvHead.Rows.Count - 2, New String() {highest, txtName.Text, numWgt.Value, numArmBon.Value, numChk.Value, numPrice.Value, cboClass.Text, LCase(cboType.Text), numStr.Value, numDex.Value, numWis.Value, numCha.Value, numInt.Value, numCon.Value})
                    ElseIf LCase(cboType.Text) = "chest" Then
                        .dgvChest.Rows.Insert(.dgvChest.Rows.Count - 2, New String() {highest, txtName.Text, numWgt.Value, numArmBon.Value, numChk.Value, numPrice.Value, cboClass.Text, LCase(cboType.Text), numStr.Value, numDex.Value, numWis.Value, numCha.Value, numInt.Value, numCon.Value})
                    ElseIf LCase(cboType.Text) = "arms" Then
                        .dgvArms.Rows.Insert(.dgvArms.Rows.Count - 2, New String() {highest, txtName.Text, numWgt.Value, numArmBon.Value, numChk.Value, numPrice.Value, cboClass.Text, LCase(cboType.Text), numStr.Value, numDex.Value, numWis.Value, numCha.Value, numInt.Value, numCon.Value})
                    ElseIf LCase(cboType.Text) = "wrists" Then
                        .dgvWrists.Rows.Insert(.dgvWrists.Rows.Count - 2, New String() {highest, txtName.Text, numWgt.Value, numArmBon.Value, numChk.Value, numPrice.Value, cboClass.Text, LCase(cboType.Text), numStr.Value, numDex.Value, numWis.Value, numCha.Value, numInt.Value, numCon.Value})
                    ElseIf LCase(cboType.Text) = "hands" Then
                        .dgvHands.Rows.Insert(.dgvHands.Rows.Count - 2, New String() {highest, txtName.Text, numWgt.Value, numArmBon.Value, numChk.Value, numPrice.Value, cboClass.Text, LCase(cboType.Text), numStr.Value, numDex.Value, numWis.Value, numCha.Value, numInt.Value, numCon.Value})
                    ElseIf LCase(cboType.Text) = "legs" Then
                        .dgvLegs.Rows.Insert(.dgvLegs.Rows.Count - 2, New String() {highest, txtName.Text, numWgt.Value, numArmBon.Value, numChk.Value, numPrice.Value, cboClass.Text, LCase(cboType.Text), numStr.Value, numDex.Value, numWis.Value, numCha.Value, numInt.Value, numCon.Value})
                    ElseIf LCase(cboType.Text) = "feet" Then
                        .dgvFeet.Rows.Insert(.dgvFeet.Rows.Count - 2, New String() {highest, txtName.Text, numWgt.Value, numArmBon.Value, numChk.Value, numPrice.Value, cboClass.Text, LCase(cboType.Text), numStr.Value, numDex.Value, numWis.Value, numCha.Value, numInt.Value, numCon.Value})
                    ElseIf LCase(cboType.Text) = "neck" Then
                        .dgvNeck.Rows.Insert(.dgvNeck.Rows.Count - 2, New String() {highest, txtName.Text, numWgt.Value, numArmBon.Value, numChk.Value, numPrice.Value, cboClass.Text, LCase(cboType.Text), numStr.Value, numDex.Value, numWis.Value, numCha.Value, numInt.Value, numCon.Value})
                    ElseIf LCase(cboType.Text) = LCase("none") Then
                        'add oddballs to everything (such as unequipped)
                        .dgvHead.Rows.Insert(.dgvHead.Rows.Count - 1, New String() {highest, txtName.Text, numWgt.Value, numArmBon.Value, numChk.Value, numPrice.Value, cboClass.Text, LCase(cboType.Text), numStr.Value, numDex.Value, numWis.Value, numCha.Value, numInt.Value, numCon.Value})
                        .dgvChest.Rows.Insert(.dgvChest.Rows.Count - 1, New String() {highest, txtName.Text, numWgt.Value, numArmBon.Value, numChk.Value, numPrice.Value, cboClass.Text, LCase(cboType.Text), numStr.Value, numDex.Value, numWis.Value, numCha.Value, numInt.Value, numCon.Value})
                        .dgvArms.Rows.Insert(.dgvArms.Rows.Count - 1, New String() {highest, txtName.Text, numWgt.Value, numArmBon.Value, numChk.Value, numPrice.Value, cboClass.Text, LCase(cboType.Text), numStr.Value, numDex.Value, numWis.Value, numCha.Value, numInt.Value, numCon.Value})
                        .dgvWrists.Rows.Insert(.dgvWrists.Rows.Count - 1, New String() {highest, txtName.Text, numWgt.Value, numArmBon.Value, numChk.Value, numPrice.Value, cboClass.Text, LCase(cboType.Text), numStr.Value, numDex.Value, numWis.Value, numCha.Value, numInt.Value, numCon.Value})
                        .dgvHands.Rows.Insert(.dgvHands.Rows.Count - 1, New String() {highest, txtName.Text, numWgt.Value, numArmBon.Value, numChk.Value, numPrice.Value, cboClass.Text, LCase(cboType.Text), numStr.Value, numDex.Value, numWis.Value, numCha.Value, numInt.Value, numCon.Value})
                        .dgvLegs.Rows.Insert(.dgvLegs.Rows.Count - 1, New String() {highest, txtName.Text, numWgt.Value, numArmBon.Value, numChk.Value, numPrice.Value, cboClass.Text, LCase(cboType.Text), numStr.Value, numDex.Value, numWis.Value, numCha.Value, numInt.Value, numCon.Value})
                        .dgvFeet.Rows.Insert(.dgvFeet.Rows.Count - 1, New String() {highest, txtName.Text, numWgt.Value, numArmBon.Value, numChk.Value, numPrice.Value, cboClass.Text, LCase(cboType.Text), numStr.Value, numDex.Value, numWis.Value, numCha.Value, numInt.Value, numCon.Value})
                        .dgvNeck.Rows.Insert(.dgvNeck.Rows.Count - 1, New String() {highest, txtName.Text, numWgt.Value, numArmBon.Value, numChk.Value, numPrice.Value, cboClass.Text, LCase(cboType.Text), numStr.Value, numDex.Value, numWis.Value, numCha.Value, numInt.Value, numCon.Value})
                    End If
                    'close the form after adding a new armor
                    Me.Close()
                End If
                'reset duplicate value so you can test again
                duplicate = False
            End With
        End If
    End Sub

    ''' <summary>
    ''' loads the form to a usable state for the user
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmAddArmor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'sets combo boxes. Helps with validation
        cboClass.SelectedIndex = 0
        cboType.SelectedIndex = 0
    End Sub
End Class