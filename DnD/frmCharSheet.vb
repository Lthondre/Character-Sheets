﻿Imports CharOptions.rndOpts

Public Class frmCharSheet
    Dim moneyWeight As Long             'holds the weight of all of your coin purse
    Event weapArmor As EventHandler

    Private Sub frmCharSheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'alots for the secod select weapon button
        AddHandler btnSWeap.Click, AddressOf btnSelWeap_Click
        'sends the button clicks of specific buttons to the select armor button
        AddHandler btnHead.Click, AddressOf btnSelArmor_Click
        AddHandler btnChest.Click, AddressOf btnSelArmor_Click
        AddHandler btnArms.Click, AddressOf btnSelArmor_Click
        AddHandler btnWrists.Click, AddressOf btnSelArmor_Click
        AddHandler btnHands.Click, AddressOf btnSelArmor_Click
        AddHandler btnLegs.Click, AddressOf btnSelArmor_Click
        AddHandler btnFeet.Click, AddressOf btnSelArmor_Click
        AddHandler btnNeck.Click, AddressOf btnSelArmor_Click
        AddHandler btnSelArmor.Click, AddressOf btnSelArmor_Click
        'prime the variable
        mdlGlobal.check = Val(txtCheck.Text)
    End Sub

    ''' <summary>
    ''' Closes the form
    ''' </summary>
    ''' <param name="sender">cancel button click</param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Closes the form
        Me.Close()
    End Sub

    ''' <summary>
    ''' Save player information to database based on tag property of txtCName.  The tag property refers to the player id If tag is empty, reference is to new record
    ''' </summary>
    ''' <param name="sender">Save button click</param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        'validate input has been entered
        If txtStr.Text = "" Then
            MessageBox.Show("Please enter Strength", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtStr.Focus()
        ElseIf txtDex.Text = "" Then
            MessageBox.Show("Please enter Dexterity", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDex.Focus()
        ElseIf txtCon.Text = "" Then
            MessageBox.Show("Please enter Constitution", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCon.Focus()
        ElseIf txtInt.Text = "" Then
            MessageBox.Show("Please enter Intelligence", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtInt.Focus()
        ElseIf txtWis.Text = "" Then
            MessageBox.Show("Please enter Wisdom", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtWis.Focus()
        ElseIf txtCha.Text = "" Then
            MessageBox.Show("Please enter Charisma", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCha.Focus()
        ElseIf txtHP.Text = "" Then
            MessageBox.Show("Please enter Health", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtHP.Focus()
        ElseIf txtMoney.Text = "" Then
            MessageBox.Show("Please enter Money", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMoney.Focus()
        ElseIf txtAP.Text = "" Then
            MessageBox.Show("Please enter Action Points", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAP.Focus()
        ElseIf cboClass.Text = "" Then
            MessageBox.Show("Please enter a Class", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboClass.Focus()
        ElseIf cboRace.Text = "" Then
            MessageBox.Show("Please enter a Race", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboRace.Focus()
        ElseIf cboGender.Text = "" Then
            MessageBox.Show("Please enter Gender", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboGender.Focus()
        ElseIf cboAlignment.Text = "" Then
            MessageBox.Show("Please enter Alignment", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboAlignment.Focus()
        ElseIf txtCName.Text = "" Then
            MessageBox.Show("Please enter a Name", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCName.Focus()
        ElseIf txtWepName.Text = "" Then
            MessageBox.Show("Please enter Weapon Name", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtWepName.Focus()
        ElseIf txtColor.Text = "" Then
            MessageBox.Show("Pleae enter a Color", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtColor.Focus()
        ElseIf txtLevel.Text = "" Then
            MessageBox.Show("Please enter Level", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtLevel.Focus()
        ElseIf txtExp.Text = "" Then
            MessageBox.Show("Please enter Experience", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtExp.Focus()
        ElseIf txtLoc.Text = "" Then
            MessageBox.Show("Please enter a Location", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtLoc.Focus()
        ElseIf txtHelm.Text = "" Then
            MessageBox.Show("Please enter a Helmet", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnHead.Focus()
        ElseIf txtChest.Text = "" Then
            MessageBox.Show("Please enter a Chest", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnChest.Focus()
        ElseIf txtArms.Text = "" Then
            MessageBox.Show("Please enter an Arm", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnArms.Focus()
        ElseIf txtWrists.Text = "" Then
            MessageBox.Show("Please enter Wrists", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnWrists.Focus()
        ElseIf txtHands.Text = "" Then
            MessageBox.Show("Please enter Hands", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnHands.Focus()
        ElseIf txtLegs.Text = "" Then
            MessageBox.Show("Please enter Legs", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnLegs.Focus()
        ElseIf txtFeet.Text = "" Then
            MessageBox.Show("Please enter Feet", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnFeet.Focus()
        ElseIf txtNeck.Text = "" Then
            MessageBox.Show("Please enter a Neck", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnNeck.Focus()
        Else
            'validate add/edit
            If txtCName.Tag.ToString <> "" Then
                'create new instance of class
                Dim PlayerData As New clsData
                'pass connection string
                PlayerData.ConnectionString = mdlGlobal.strConnection
                'pass SQL command
                PlayerData.SQL = "SELECT * FROM tblPlayerStats WHERE pID = " & txtCName.Tag
                'fill each field based on text box
                With PlayerData.ds.Tables(0).Rows(0)
                    .Item("pSTR") = txtStr.Text
                    .Item("pDEX") = txtDex.Text
                    .Item("pCON") = txtCon.Text
                    .Item("pINT") = txtInt.Text
                    .Item("pWIS") = txtWis.Text
                    .Item("pCHA") = txtCha.Text
                    .Item("pHealth") = txtHP.Text
                    .Item("pMoney") = Val(txtMoney.Text)
                    .Item("pActionPoints") = txtAP.Text
                    .Item("pName") = txtCName.Text
                    .Item("wID") = txtWepName.Tag
                    .Item("pClass") = cboClass.Text
                    .Item("pRace") = cboRace.Text
                    .Item("pGender") = cboGender.Text
                    .Item("pAlign") = cboAlignment.Text
                    .Item("pColor") = txtColor.Text
                    .Item("pCharLoc") = txtLoc.Text
                    .Item("pLevel") = txtLevel.Text
                    .Item("pExp") = txtExp.Text
                    .Item("modSTR") = txtStr.Tag
                    .Item("modDEX") = txtDex.Tag
                    .Item("modCON") = txtCon.Tag
                    .Item("modINT") = txtInt.Tag
                    .Item("modWIS") = txtWis.Tag
                    .Item("modCHA") = txtCha.Tag
                    'armor
                    .Item("aHead") = txtHelm.Tag
                    .Item("aChest") = txtChest.Tag
                    .Item("aLegs") = txtLegs.Tag
                    .Item("aArms") = txtArms.Tag
                    .Item("aHands") = txtHands.Tag
                    .Item("aFeet") = txtFeet.Tag
                    .Item("aNeck") = txtNeck.Tag
                    .Item("aWrists") = txtWrists.Tag
                End With
                'update database
                PlayerData.da.Update(PlayerData.ds)
            Else
                'create new instance of class
                Dim PlayerData As New clsData
                'pass connection string
                PlayerData.ConnectionString = mdlGlobal.strConnection
                'pass SQL command
                PlayerData.SQL = "SELECT * FROM tblPlayerStats WHERE pID = 0"
                'create new row for database
                Dim dsNewRow As DataRow = PlayerData.ds.Tables(0).NewRow
                'fill each field based on text boxes
                With dsNewRow
                    .Item("pSTR") = txtStr.Text
                    .Item("pDEX") = txtDex.Text
                    .Item("pCON") = txtCon.Text
                    .Item("pINT") = txtInt.Text
                    .Item("pWIS") = txtWis.Text
                    .Item("pCHA") = txtCha.Text
                    .Item("pHealth") = txtHP.Text
                    .Item("pMoney") = Val(txtMoney.Text)
                    .Item("pActionPoints") = txtAP.Text
                    .Item("pName") = txtCName.Text
                    .Item("wID") = txtWepName.Tag
                    .Item("pClass") = cboClass.Text
                    .Item("pRace") = cboRace.Text
                    .Item("pGender") = cboGender.Text
                    .Item("pAlign") = cboAlignment.Text
                    .Item("pColor") = txtColor.Text
                    .Item("pCharLoc") = txtLoc.Text
                    .Item("pLevel") = txtLevel.Text
                    .Item("pExp") = txtExp.Text
                    .Item("modSTR") = 0          'new characters have no ability modifiers. They're new.
                    .Item("modDEX") = 0
                    .Item("modCON") = 0
                    .Item("modINT") = 0
                    .Item("modWIS") = 0
                    .Item("modCHA") = 0
                    'armor
                    .Item("aHead") = txtHelm.Tag
                    .Item("aChest") = txtChest.Tag
                    .Item("aLegs") = txtLegs.Tag
                    .Item("aArms") = txtArms.Tag
                    .Item("aHands") = txtHands.Tag
                    .Item("aFeet") = txtFeet.Tag
                    .Item("aNeck") = txtNeck.Tag
                    .Item("aWrists") = txtWrists.Tag
                End With
                'add row to dataset
                PlayerData.ds.Tables(0).Rows.Add(dsNewRow)
                'update database
                PlayerData.da.Update(PlayerData.ds)
            End If
        End If
    End Sub

    ''' <summary>
    ''' Rolls new stats for a new character
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnRandomize_Click(sender As Object, e As EventArgs) Handles btnRandomize.Click
        'only roll new stats if your character doens't exist
        'else leave him the fuck alone
        If Val(txtCName.Tag).ToString <> "" Then
            'Question saved characters
            Dim result As Integer = MessageBox.Show("I can't let you do that, Dave..." & vbCrLf & "Are you sure you want to randomize your existing character?", "error", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error)
            If result = DialogResult.Yes Then
                'randomize saved characters only if they give consent
                MessageBox.Show("Very well...", "Randomize", MessageBoxButtons.OK, MessageBoxIcon.None)
                Call rStats(txtCName.Text)
            End If
        Else
            'randomize stats for new characters
            Call rStats()
        End If
    End Sub

    Private Sub rStats(Optional ByRef name = "")
        'generate ability scores (STR, DEX, INT, WIS, CON, CHA)
        'using the third method as described in the DnD 4e player handbook #1
        Dim abilArray(5) As Integer 'roll 6*(4d6). Add highest three values. Assign to base ability
        Dim num(3) As Integer       'random numbers, easier to find lowest number if in array
        For i As Integer = 0 To 5 'one per ability
            'four rolls, assign highest three to ability score
            Randomize() 'generate new random seed
            num(0) = CInt(Int((6 * Rnd()) + 1))
            Randomize()
            num(1) = CInt(Int((6 * Rnd()) + 1))
            Randomize()
            num(2) = CInt(Int((6 * Rnd()) + 1))
            Randomize()
            num(3) = CInt(Int((6 * Rnd()) + 1))
            'determine lowest random number
            Dim lowest = num(0)
            For z As Integer = 0 To 3
                If num(z) < lowest Then
                    lowest = num(z)
                End If
            Next
            'assign value less lowest to ability array
            abilArray(i) = num(0) + num(1) + num(2) + num(3) - lowest
        Next
        'assign six ability scores
        txtStr.Text = abilArray(0)
        txtDex.Text = abilArray(1)
        txtCon.Text = abilArray(2)
        txtInt.Text = abilArray(3)
        txtWis.Text = abilArray(4)
        txtCha.Text = abilArray(5)

        'new characters are always level 1, with 0 experience
        txtLevel.Text = 1
        txtExp.Text = 0

        'starting money in units of gold
        txtMoney.Text = "100.00"
        '1silver is .1g
        '1copper is .01g
        '1platinum is 100g
        '1astral diamond is 100,000g

        'random class, race, alignment, and gender
        Randomize()
        cboClass.SelectedIndex = CInt(Int((8 * Rnd()) + 1)) - 1
        Randomize()
        cboRace.SelectedIndex = CInt(Int((7 * Rnd()) + 1)) - 1
        Randomize()
        cboAlignment.SelectedIndex = CInt(Int((9 * Rnd()) + 1)) - 1
        Randomize()
        cboGender.SelectedIndex = CInt(Int((2 * Rnd()) + 1)) - 1

        'testing Information
        txtAC.Text = 10 + Math.Floor(0.5 * Val(txtLevel.Text)) + IIf(Val(txtDex.Tag) > Val(txtInt.Tag), txtDex.Tag, txtInt.Tag)
        txtCheck.Text = "0"
        txtAP.Text = "9"

        'new random name if it's a brand new character
        If name <> "" Then
            Dim newName As New CharOptions.rndOpts
            txtCName.Text = newName.selName
        End If
        txtColor.Text = "R"
        txtLoc.Text = "0,0"
        txtWepName.Text = "None/Unarmed"
        txtWepName.Tag = "1"
        txtCarryCap.Text = Val(txtMoney.Text) * 0.02 'every gp is 1/50lbs. new characters start naked

        'New Armor
        Dim newArmor As String = "Not Yet Changed"
        txtHelm.Text = newArmor
        txtHelm.Tag = "1"
        txtChest.Text = newArmor
        txtChest.Tag = "1"
        txtLegs.Text = newArmor
        txtLegs.Tag = "1"
        txtArms.Text = newArmor
        txtArms.Tag = "1"
        txtHands.Text = newArmor
        txtHands.Tag = "1"
        txtFeet.Text = newArmor
        txtFeet.Tag = "1"
        txtNeck.Text = newArmor
        txtNeck.Tag = "1"
        txtWrists.Text = newArmor
        txtWrists.Tag = "1"

        'Health points
        If LCase(cboClass.Text) = "cleric" Or LCase(cboClass.Text) = "ranger" Or LCase(cboClass.Text) = "rogue" Or LCase(cboClass.Text) = "warlock" Or LCase(cboClass.Text) = "warlord" Then
            txtHP.Text = Val(txtLevel.Text) * 5 - 5 + 12 + Val(txtCon.Text)
        ElseIf LCase(cboClass.Text) = "fighter" Or LCase(cboClass.Text) = "paladin" Then
            txtHP.Text = Val(txtLevel.Text) * 6 - 6 + 15 + Val(txtCon.Text)
        ElseIf LCase(cboClass.Text) = "wizard" Then
            txtHP.Text = Val(txtLevel.Text) * 4 - 4 + 10 + Val(txtCon.Text)
        End If

        'make easier to continue filling out sheets
        txtAC.Focus()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        'toggle editing of character sheet
        cboAlignment.Enabled = IIf(cboAlignment.Enabled = True, False, True)
        cboClass.Enabled = IIf(cboClass.Enabled = True, False, True)
        cboGender.Enabled = IIf(cboGender.Enabled = True, False, True)
        cboRace.Enabled = IIf(cboRace.Enabled = True, False, True)
        txtStr.ReadOnly = IIf(txtStr.ReadOnly = False, True, False)
        txtDex.ReadOnly = IIf(txtDex.ReadOnly = False, True, False)
        txtCha.ReadOnly = IIf(txtCha.ReadOnly = False, True, False)
        txtCon.ReadOnly = IIf(txtCon.ReadOnly = False, True, False)
        txtCName.ReadOnly = IIf(txtCName.ReadOnly = False, True, False)
        txtInt.ReadOnly = IIf(txtInt.ReadOnly = False, True, False)
        txtWis.ReadOnly = IIf(txtWis.ReadOnly = False, True, False)
        txtHP.ReadOnly = IIf(txtHP.ReadOnly = False, True, False)
        'txtAC.ReadOnly = IIf(txtAC.ReadOnly = False, True, False)
        txtMoney.ReadOnly = IIf(txtMoney.ReadOnly = False, True, False)
        'txtCheck.ReadOnly = IIf(txtCheck.ReadOnly = False, True, False)
        txtAP.ReadOnly = IIf(txtAP.ReadOnly = False, True, False)
        txtColor.ReadOnly = IIf(txtColor.ReadOnly = False, True, False)
        'txtWepName.ReadOnly = IIf(txtWepName.ReadOnly = False, True, False)
        txtLevel.ReadOnly = IIf(txtLevel.ReadOnly = False, True, False)
        txtExp.ReadOnly = IIf(txtExp.ReadOnly = False, True, False)
        txtLoc.ReadOnly = IIf(txtLoc.ReadOnly = False, True, False)
        btnCalc.Enabled = IIf(btnCalc.Enabled = False, True, False)
        btnRandomize.Enabled = IIf(btnRandomize.Enabled = False, True, False)
        'armor
        'txtHelm.ReadOnly = IIf(txtHelm.ReadOnly = False, True, False)
        'txtChest.ReadOnly = IIf(txtChest.ReadOnly = False, True, False)
        'txtLegs.ReadOnly = IIf(txtLegs.ReadOnly = False, True, False)
        'txtArms.ReadOnly = IIf(txtArms.ReadOnly = False, True, False)
        'txtHands.ReadOnly = IIf(txtHands.ReadOnly = False, True, False)
        'txtFeet.ReadOnly = IIf(txtFeet.ReadOnly = False, True, False)
        'txtNeck.ReadOnly = IIf(txtNeck.ReadOnly = False, True, False)
        'txtWrists.ReadOnly = IIf(txtWrists.ReadOnly = False, True, False)

        'equipment buttons
        btnSelWeap.Enabled = IIf(btnSelWeap.Enabled = False, True, False)
        btnSWeap.Enabled = IIf(btnSWeap.Enabled = False, True, False)
        btnHead.Enabled = IIf(btnHead.Enabled = False, True, False)
        btnNeck.Enabled = IIf(btnNeck.Enabled = False, True, False)
        btnChest.Enabled = IIf(btnChest.Enabled = False, True, False)
        btnArms.Enabled = IIf(btnArms.Enabled = False, True, False)
        btnHands.Enabled = IIf(btnHands.Enabled = False, True, False)
        btnLegs.Enabled = IIf(btnLegs.Enabled = False, True, False)
        btnFeet.Enabled = IIf(btnFeet.Enabled = False, True, False)
        btnWrists.Enabled = IIf(btnWrists.Enabled = False, True, False)
        btnSelArmor.Enabled = IIf(btnSelArmor.Enabled = False, True, False)
        txtStr.Focus()
    End Sub

    Private Sub btnSelWeap_Click(sender As Object, e As EventArgs) Handles btnSelWeap.Click
        'open frmSelWeap for weapon selection
        With frmSelWeap
            Me.Hide()
            .ShowDialog()
            Me.Show()
            'Only change if the values have changed
            If .dtext <> "" Then
                Console.WriteLine("Prev Chk: " & .dgvWeapons.Item(4, FindValue(.dgvWeapons, Val(txtWepName.Tag), "wID").Index).Value)
                Console.WriteLine("New Chk: " & .dcheckMod)
                txtCarryCap.Text = Val(txtCarryCap.Text) - .dgvWeapons.Item(2, FindValue(.dgvWeapons, Val(txtWepName.Tag), "wID").Index).Value + .dweight
                txtAC.Text = Val(txtAC.Text) - .dgvWeapons.Item(3, FindValue(.dgvWeapons, Val(txtWepName.Tag), "wID").Index).Value + .darmBonus
                txtCheck.Text = Val(txtCheck.Text) - .dgvWeapons.Item(4, FindValue(.dgvWeapons, Val(txtWepName.Tag), "wID").Index).Value + .dcheckMod
                txtWepName.Text = .dtext
                txtWepName.Tag = .dtag
            End If
            .Dispose()
        End With
    End Sub

    Private Sub btnSelArmor_Click(sender As Object, e As EventArgs)
        'based on name of button that called this, update theTag in module
        'this will be used for default selected tabs in frmSelArmor
        Select Case sender.name
            Case "btnHead"
                mdlGlobal.theTag = 1
            Case "btnNeck"
                mdlGlobal.theTag = 2
            Case "btnChest"
                mdlGlobal.theTag = 3
            Case "btnArms"
                mdlGlobal.theTag = 4
            Case "btnHands"
                mdlGlobal.theTag = 5
            Case "btnLegs"
                mdlGlobal.theTag = 6
            Case "btnFeet"
                mdlGlobal.theTag = 7
            Case "btnWrists"
                mdlGlobal.theTag = 8
            Case "btnSelArmor"
                mdlGlobal.theTag = 9
        End Select
        With frmSelArmor
            'open frmSelArmor for armor selection
            Me.Hide()
            .ShowDialog()
            Me.Show()
            If .dtext <> "" Then
                'makes this update MUCH easier. ONLY works because you're only updating one armor at a time
                Dim box As New TextBox
                Select Case LCase(.dtype)
                    Case "helm"
                        box = txtHelm
                    Case "chest"
                        box = txtChest
                    Case "legs"
                        box = txtLegs
                    Case "arms"
                        box = txtArms
                    Case "hands"
                        box = txtHands
                    Case "neck"
                        box = txtNeck
                    Case "feet"
                        box = txtFeet
                    Case "wrists"
                        box = txtwrists
                    Case "none"
                        'catch the oddballs
                        Select Case mdlGlobal.theTag
                            Case 1
                                box = txtHelm
                            Case 2
                                box = txtNeck
                            Case 3
                                box = txtChest
                            Case 4
                                box = txtArms
                            Case 5
                                box = txtHands
                            Case 6
                                box = txtLegs
                            Case 7
                                box = txtFeet
                            Case 8
                                box = txtWrists
                            Case 9
                                MessageBox.Show("Error: To unequip an armor piece, click the button next to the armor you would like to unequip.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Select
                End Select
                'view old armor
                Console.WriteLine("Prev Box: " & box.Name & vbCrLf & vbTab & vbTab & box.Text & vbTab & box.Tag)
                Console.WriteLine("Prev wgt: " & .dgvArmor.Item(2, FindValue(.dgvArmor, Val(box.Tag), "allID").Index).Value)
                Console.WriteLine("Prev AC: " & .dgvArmor.Item(3, FindValue(.dgvArmor, Val(box.Tag), "allID").Index).Value)
                Console.WriteLine("Prev Chk: " & .dgvArmor.Item(4, FindValue(.dgvArmor, Val(box.Tag), "allID").Index).Value)
                'update character sheet using new "box" textbox
                txtCarryCap.Text = Val(txtCarryCap.Text) - .dgvArmor.Item(2, FindValue(.dgvArmor, Val(box.Tag), "allID").Index).Value + .dweight
                txtAC.Text = Val(txtAC.Text) - .dgvArmor.Item(3, FindValue(.dgvArmor, Val(box.Tag), "allID").Index).Value + .darmBonus
                txtCheck.Text = Val(txtCheck.Text) - .dgvArmor.Item(4, FindValue(.dgvArmor, Val(box.Tag), "allID").Index).Value + .dcheckMod
                box.Text = .dtext
                box.Tag = .dtag
                'view new armor information
                Console.WriteLine("New Wgt: " & .dweight)
                Console.WriteLine("New AC: " & .darmBonus)
                Console.WriteLine("New Chk: " & .dcheckMod)
                Console.WriteLine("New Box:" & .dtext & vbTab & vbTab & .dtag)
            End If
            .Dispose()
        End With
    End Sub

    ''' <summary>
    ''' Updates tooltip and weight for character
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtCarryCap_TextChanged(sender As Object, e As EventArgs) Handles txtCarryCap.TextChanged
        Const NORMAL As Integer = 10
        Const HEAVY As Integer = 20
        Const MAXIMUM As Integer = 50

        'weight is never negative
        If Val(txtCarryCap.Text) < 0 Then txtCarryCap.Text = 0

        If Val(txtCarryCap.Text) <= NORMAL * Val(txtStr.Text) Then
            'normal load
            txtCarryCap.BackColor = Color.LightGreen
            Me.ttpHelp.SetToolTip(Me.txtCarryCap, "Normal load" & vbCrLf & "Speed not hampered" & vbCrLf & "Can carry up to: " & NORMAL * Val(txtStr.Text) & "lbs before Heavy load")
        ElseIf Val(txtCarryCap.Text) <= HEAVY * Val(txtStr.Text) Then
            'heavy load
            MsgBox("Your character is slowed due to their carrying load.")
            txtCarryCap.BackColor = Color.Yellow
            Me.ttpHelp.SetToolTip(Me.txtCarryCap, "Heavy load" & vbCrLf & "Speed slightly hampered" & vbCrLf & "Can carry up to: " & HEAVY *(Val(txtStr.Text) & "lbs before maximum dragging load")
        ElseIf (Val(txtCarryCap.Text) > HEAVY * Val(txtStr.Text)) And (Val(txtCarryCap.Text) <= MAXIMUM * Val(txtStr.Text)) Then
            'maximum dragging load
            MsgBox("Your character's movement is severely hampered by their carrying load.")
            txtCarryCap.BackColor = Color.Red
            Me.ttpHelp.SetToolTip(Me.txtCarryCap, "Maximum dragging load" & vbCrLf & "Speed severely hampered")
        ElseIf Val(txtCarryCap.Text) > MAXIMUM * Val(txtStr.Text) Then
            'over capacity
            If Me.Visible = True Then
                'this messagebox can be triggered several times while loading a character into the character sheet
                MsgBox("Your character is over encumbered.")
            End If
            txtCarryCap.BackColor = Color.Black
            txtCarryCap.ForeColor = Color.Yellow
            Me.ttpHelp.SetToolTip(Me.txtCarryCap, "Over encumbered")
        End If
    End Sub

    ''' <summary>
    ''' Update weight of money when money changes
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtMoney_TextChanged(sender As Object, e As EventArgs) Handles txtMoney.TextChanged
        Const GPWEIGHT As Decimal = 0.02
        'remove previous moneyweight first
        txtCarryCap.Text = Val(txtCarryCap.Text) - moneyWeight
        'add new money weight
        moneyWeight = Val(txtMoney.Text) * GPWEIGHT
        Console.WriteLine("Money Wgt: " & moneyWeight)
        txtCarryCap.Text = Val(txtCarryCap.Text) + moneyWeight
    End Sub

    ''' <summary>
    ''' Shows form used for rolling ability/skill rolls
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>does initiative/perception as well</remarks>
    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        'show the form that handles ability/skill checks
        Dim roll As New frmAbilSkillRoll
        With roll
            Console.WriteLine("Level: " & Val(txtLevel.Text))
            .Show()
            'only change if the user actually rolled for initiative
            If .initRoll <> -1 Then
                txtInitiative.Text = .initRoll
            End If
        End With
    End Sub

    ''' <summary>
    ''' updates public variable for check modifier
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtCheck_TextChanged(sender As Object, e As EventArgs) Handles txtCheck.TextChanged
        'update variable as soon as the check mod changes
        mdlGlobal.check = Val(txtCheck.Text)
    End Sub
End Class
