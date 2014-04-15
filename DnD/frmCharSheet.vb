Imports System.Drawing
Imports CharOptions.opts

Public Class frmCharSheet
    Dim moneyWeight As Long             'holds the weight of all of your coin purse
    Dim allCols() As Color = New Color() {} 'array that holds all colors
    Public cantrips = 0                   'holds number of cantrips available to current character
    Public encounters = 0
    Public dailies = 0
    Public lvls(30) As Int64
    Event weapArmor As EventHandler

    ''' <summary>
    ''' add event handlers on formload and set the value of check in mdlGlobal
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmCharSheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'add initial modifiers to ability scores
        txtStr.Text = Val(txtStr.Text) + Val(txtStr.Tag)
        txtDex.Text = Val(txtDex.Text) + Val(txtDex.Tag)
        txtWis.Text = Val(txtWis.Text) + Val(txtWis.Tag)
        txtCon.Text = Val(txtCon.Text) + Val(txtCon.Tag)
        txtInt.Text = Val(txtInt.Text) + Val(txtInt.Tag)
        txtCha.Text = Val(txtCha.Text) + Val(txtCha.Tag)

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
        'menu strip
        AddHandler mnuArmor.Click, AddressOf btnSelArmor_Click
        'prime the variable
        mdlGlobal.check = Val(txtCheck.Text)
        'load level threshholds
        Try
            Dim sr As New System.IO.StreamReader("levels.txt")
            For j As Integer = 2 To 30
                lvls(j) = Convert.ToInt64(sr.ReadLine())
            Next
            sr.Close()
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            MessageBox.Show("Could not open up levels file.")
        End Try
    End Sub

    ''' <summary>
    ''' Closes the form
    ''' </summary>
    ''' <param name="sender">cancel button click</param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click, mnuClose.Click
        'Closes the form
        Me.Close()
    End Sub

    ''' <summary>
    ''' Save player information to database based on tag property of txtCName.  The tag property refers to the player id If tag is empty, reference is to new record
    ''' </summary>
    ''' <param name="sender">Save button click</param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click, mnuSave.Click
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
            MessageBox.Show("Pleae enter a Color (click the color box)", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            'return to base stats before saving to database
            txtStr.Text = Val(txtStr.Text) - Val(txtStr.Tag)
            txtDex.Text = Val(txtDex.Text) - Val(txtDex.Tag)
            txtWis.Text = Val(txtWis.Text) - Val(txtWis.Tag)
            txtCha.Text = Val(txtCha.Text) - Val(txtCha.Tag)
            txtInt.Text = Val(txtInt.Text) - Val(txtInt.Tag)
            txtCon.Text = Val(txtCon.Text) - Val(txtCon.Tag)

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
                    'save ability modifiers
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
                    'save ability modifiers
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
        'only roll new stats if your character doesn't exist
        If txtCName.Tag.ToString <> "" Then
            'Question saved characters
            Dim result As Integer = MessageBox.Show("I can't let you do that, Dave..." & vbCrLf & "Are you sure you want to randomize your existing character?", "error", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error)
            If result = DialogResult.Yes Then
                'randomize saved characters only if they give consent
                MessageBox.Show("Very well...", "Randomize", MessageBoxButtons.OK, MessageBoxIcon.None)
                Call rStats(txtCName.Text, txtCName.Tag)
            End If
        Else
            'randomize stats for new characters
            Call rStats()
        End If
    End Sub

    ''' <summary>
    ''' Sub that randomizes stats for the user
    ''' </summary>
    ''' <param name="name">name of the character</param>
    ''' <param name="tag">unique character ID</param>
    ''' <remarks></remarks>
    Private Sub rStats(Optional ByRef name = "", Optional ByRef tag = "")
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

        'new random name and color if it's a brand new character
        If name = "" Or tag = "" Then
            Dim newName As New CharOptions.opts
            txtCName.Text = newName.selName
            'if genColors has been ran, then just select a color from allCols at random, else generate the colors and then select a random color
            If allCols.Length <= 0 Then
                genColors()
                rColor()
            Else
                rColor()
            End If
        End If

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
        txtAC.Text = 10 + Math.Floor(0.5 * Val(txtLevel.Text)) + IIf(Val(txtDex.Tag) > Val(txtInt.Tag), Val(txtDex.Tag), Val(txtInt.Tag))
        txtCheck.Text = "0"
        txtAP.Text = "9"
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
        If LCase(cboClass.Text) = "cleric" Then
            'page 60
            txtHP.Text = Val(txtLevel.Text) * 5 - 5 + 12 + Val(txtCon.Text)
        ElseIf LCase(cboClass.Text) = "ranger" Then
            'page 103
            txtHP.Text = Val(txtLevel.Text) * 5 - 5 + 12 + Val(txtCon.Text)
        ElseIf LCase(cboClass.Text) = "rogue" Then
            'page 116
            txtHP.Text = Val(txtLevel.Text) * 5 - 5 + 12 + Val(txtCon.Text)
        ElseIf LCase(cboClass.Text) = "warlock" Then
            'page 129
            txtHP.Text = Val(txtLevel.Text) * 5 - 5 + 12 + Val(txtCon.Text)
        ElseIf LCase(cboClass.Text) = "warlord" Then
            'page 143
            txtHP.Text = Val(txtLevel.Text) * 5 - 5 + 12 + Val(txtCon.Text)
        ElseIf LCase(cboClass.Text) = "fighter" Then
            'page 75
            txtHP.Text = Val(txtLevel.Text) * 6 - 6 + 15 + Val(txtCon.Text)
        ElseIf LCase(cboClass.Text) = "paladin" Then
            'page 89
            txtHP.Text = Val(txtLevel.Text) * 6 - 6 + 15 + Val(txtCon.Text)
        ElseIf LCase(cboClass.Text) = "wizard" Then
            'page 156
            txtHP.Text = Val(txtLevel.Text) * 4 - 4 + 10 + Val(txtCon.Text)
        End If

        'make easier to continue filling out sheets
        txtHP.Focus()
    End Sub

    ''' <summary>
    ''' toggles readonly/enabled mode for the form, allowing or disallowing the user to edit their character sheet
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        'toggle editing of character sheet
        If txtCName.Tag = Nothing Then
            'only toggle these if character has not finished creating
            cboAlignment.Enabled = IIf(cboAlignment.Enabled = True, False, True)
            cboClass.Enabled = IIf(cboClass.Enabled = True, False, True)
            cboGender.Enabled = IIf(cboGender.Enabled = True, False, True)
            cboRace.Enabled = IIf(cboRace.Enabled = True, False, True)
            txtCName.ReadOnly = IIf(txtCName.ReadOnly = False, True, False)
            'only newbies should have this power
            txtStr.ReadOnly = IIf(txtStr.ReadOnly = False, True, False)
            txtDex.ReadOnly = IIf(txtDex.ReadOnly = False, True, False)
            txtCha.ReadOnly = IIf(txtCha.ReadOnly = False, True, False)
            txtCon.ReadOnly = IIf(txtCon.ReadOnly = False, True, False)
            txtInt.ReadOnly = IIf(txtInt.ReadOnly = False, True, False)
            txtWis.ReadOnly = IIf(txtWis.ReadOnly = False, True, False)
        End If
        txtHP.ReadOnly = IIf(txtHP.ReadOnly = False, True, False)
        txtMoney.ReadOnly = IIf(txtMoney.ReadOnly = False, True, False)
        txtAP.ReadOnly = IIf(txtAP.ReadOnly = False, True, False)
        txtLoc.ReadOnly = IIf(txtLoc.ReadOnly = False, True, False)
        btnCalc.Enabled = IIf(btnCalc.Enabled = False, True, False)
        btnRandomize.Enabled = IIf(btnRandomize.Enabled = False, True, False)
        'equipment buttons
        btnSWeap.Enabled = IIf(btnSWeap.Enabled = False, True, False)
        btnHead.Enabled = IIf(btnHead.Enabled = False, True, False)
        btnNeck.Enabled = IIf(btnNeck.Enabled = False, True, False)
        btnChest.Enabled = IIf(btnChest.Enabled = False, True, False)
        btnArms.Enabled = IIf(btnArms.Enabled = False, True, False)
        btnHands.Enabled = IIf(btnHands.Enabled = False, True, False)
        btnLegs.Enabled = IIf(btnLegs.Enabled = False, True, False)
        btnFeet.Enabled = IIf(btnFeet.Enabled = False, True, False)
        btnWrists.Enabled = IIf(btnWrists.Enabled = False, True, False)
        'menu strip
        mnuWeapon.Enabled = IIf(mnuWeapon.Enabled = False, True, False)
        mnuArmor.Enabled = IIf(mnuArmor.Enabled = False, True, False)
        mnuSave.Enabled = IIf(mnuSave.Enabled = False, True, False)
        txtHP.Focus()
    End Sub

    ''' <summary>
    ''' sub for selecting/equipping new weapon. updates corresponding text control/tag
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnSelWeap_Click(sender As Object, e As EventArgs) Handles mnuWeapon.Click
        'open frmSelWeap for weapon selection
        With frmSelWeap
            Me.Hide()
            .ShowDialog()
            Me.Show()
            'Only change if the values have changed
            If .dtext <> "" Then
                'Console.WriteLine("Prev Chk: " & .dgvWeapons.Item(4, FindValue(.dgvWeapons, Val(txtWepName.Tag), "wID").Index).Value)
                'Console.WriteLine("New Chk: " & .dcheckMod)
                txtCarryCap.Text = Val(txtCarryCap.Text) - .dgvWeapons.Item(2, FindValue(.dgvWeapons, Val(txtWepName.Tag), "wID").Index).Value + .dweight
                txtAC.Text = Val(txtAC.Text) - .dgvWeapons.Item(3, FindValue(.dgvWeapons, Val(txtWepName.Tag), "wID").Index).Value + .darmBonus
                txtCheck.Text = Val(txtCheck.Text) - .dgvWeapons.Item(4, FindValue(.dgvWeapons, Val(txtWepName.Tag), "wID").Index).Value + .dcheckMod
                'ability mods
                txtStr.Tag = Val(txtStr.Tag) - .dgvWeapons.Item(8, FindValue(.dgvWeapons, Val(txtStr.Tag), "allID").Index).Value + .dSTR
                txtDex.Tag = Val(txtDex.Tag) - .dgvWeapons.Item(9, FindValue(.dgvWeapons, Val(txtDex.Tag), "allID").Index).Value + .dDEX
                txtWis.Tag = Val(txtWis.Tag) - .dgvWeapons.Item(10, FindValue(.dgvWeapons, Val(txtWis.Tag), "allID").Index).Value + .dWIS
                txtCha.Tag = Val(txtCha.Tag) - .dgvWeapons.Item(11, FindValue(.dgvWeapons, Val(txtCha.Tag), "allID").Index).Value + .dCHA
                txtInt.Tag = Val(txtInt.Tag) - .dgvWeapons.Item(12, FindValue(.dgvWeapons, Val(txtInt.Tag), "allID").Index).Value + .dINT
                txtCon.Tag = Val(txtCon.Tag) - .dgvWeapons.Item(13, FindValue(.dgvWeapons, Val(txtCon.Tag), "allID").Index).Value + .dCON
                txtWepName.Text = .dtext
                txtWepName.Tag = .dtag
            End If
            .Dispose()
        End With
    End Sub

    ''' <summary>
    ''' sub for selecting/equipping new armor. updates corresponding text control and it's tag
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
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
            Case "btnSelArmor", "mnuArmor"
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
                        box = txtWrists
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
                'update character sheet using new "box" textbox
                txtCarryCap.Text = Val(txtCarryCap.Text) - .dgvArmor.Item(2, FindValue(.dgvArmor, Val(box.Tag), "allID").Index).Value + .dweight
                txtAC.Text = Val(txtAC.Text) - .dgvArmor.Item(3, FindValue(.dgvArmor, Val(box.Tag), "allID").Index).Value + .darmBonus
                txtCheck.Text = Val(txtCheck.Text) - .dgvArmor.Item(4, FindValue(.dgvArmor, Val(box.Tag), "allID").Index).Value + .dcheckMod
                'ability mods
                txtStr.Tag = Val(txtStr.Tag) - .dgvArmor.Item(8, FindValue(.dgvArmor, Val(box.Tag), "allID").Index).Value + .dSTR
                txtDex.Tag = Val(txtDex.Tag) - .dgvArmor.Item(9, FindValue(.dgvArmor, Val(box.Tag), "allID").Index).Value + .dDEX
                txtWis.Tag = Val(txtWis.Tag) - .dgvArmor.Item(10, FindValue(.dgvArmor, Val(box.Tag), "allID").Index).Value + .dWIS
                txtCha.Tag = Val(txtCha.Tag) - .dgvArmor.Item(11, FindValue(.dgvArmor, Val(box.Tag), "allID").Index).Value + .dCHA
                txtInt.Tag = Val(txtInt.Tag) - .dgvArmor.Item(12, FindValue(.dgvArmor, Val(box.Tag), "allID").Index).Value + .dINT
                txtCon.Tag = Val(txtCon.Tag) - .dgvArmor.Item(13, FindValue(.dgvArmor, Val(box.Tag), "allID").Index).Value + .dCON
                box.Text = .dtext
                box.Tag = .dtag
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
            Me.ttpHelp.SetToolTip(Me.txtCarryCap, "Heavy load" & vbCrLf & "Speed slightly hampered" & vbCrLf & "Can carry up to: " & HEAVY * (Val(txtStr.Text) & "lbs before maximum dragging load"))
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
    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles mnuDice.Click
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

    ''' <summary>
    ''' updates racial ability modifiers. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>should only ever fire on character creation (when stat mods are 0, minus equipment, anyways)</remarks>
    Private Sub cboRace_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRace.SelectedIndexChanged
        'should only fire on a new character
        If txtCName.Tag = Nothing Then
            Dim newEquip As String = "Unequipped"
            Dim newTag As String = "1"
            'remove existing racial bonus
            txtDex.Tag = 0
            txtCha.Tag = 0
            txtInt.Tag = 0
            txtStr.Tag = 0
            txtCon.Tag = 0
            txtWis.Tag = 0

            'I have no idea how else to do this, armor must come off if you're going to change your race
            txtHelm.Text = newEquip
            txtHelm.Tag = newTag
            txtArms.Text = newEquip
            txtArms.Tag = newTag
            txtWrists.Text = newEquip
            txtWrists.Tag = newTag
            txtHands.Text = newEquip
            txtHands.Tag = newTag
            txtNeck.Text = newEquip
            txtNeck.Tag = newTag
            txtChest.Text = newEquip
            txtChest.Tag = newTag
            txtLegs.Text = newEquip
            txtLegs.Tag = newTag
            txtFeet.Text = newEquip
            txtFeet.Tag = newTag
            txtWepName.Text = newEquip
            txtWepName.Tag = newTag

            'add new racials
            If LCase(cboRace.Text) = "human" Then
                '+2 to any one ability
                Dim goodIn As Boolean
                'could search string for first three letters at beginning of string to make this easier
                Do
                    Dim res = InputBox("Enter ability to modify: ", "Human Racial Modifier", 0)
                    goodIn = True
                    'increase stats and mods by their increment value, difference is the base ability
                    Select Case LCase(res)
                        Case "dex", "dexterity"
                            txtDex.Tag = Val(txtDex.Tag) + 2
                            txtDex.Text = Val(txtDex.Text) + 2
                        Case "str", "strength"
                            txtStr.Tag = Val(txtStr.Tag) + 2
                            txtStr.Text = Val(txtStr.Text) + 2
                        Case "cha", "charisma"
                            txtCha.Tag = Val(txtCha.Tag) + 2
                            txtCha.Text = Val(txtCha.Text) + 2
                        Case "int", "intelligence", "intellect"
                            txtInt.Tag = Val(txtInt.Tag) + 2
                            txtInt.Text = Val(txtInt.Text) + 2
                        Case "wis", "wisdom"
                            txtWis.Tag = Val(txtWis.Tag) + 2
                            txtWis.Text = Val(txtWis.Text) + 2
                        Case "con", "constitution"
                            txtCon.Tag = Val(txtCon.Tag) + 2
                            txtCon.Text = Val(txtCon.Text) + 2
                        Case 0
                            'Default to Strength modifer
                            txtStr.Tag = Val(txtStr.Tag) + 2
                            txtStr.Text = Val(txtStr.Text) + 2
                        Case Else
                            'Nice output for user
                            MessageBox.Show("That is not a valid ability to modify" & vbCrLf & "Choose DEX, STR, CHA, INT, WIS, or CON", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            goodIn = False
                    End Select
                Loop While goodIn = False
            ElseIf LCase(cboRace.Text) = "halfling" Then
                txtDex.Tag = Val(txtDex.Tag) + 2
                txtDex.Text = Val(txtDex.Text) + 2
                txtCha.Tag = Val(txtCha.Tag) + 2
                txtCha.Text = Val(txtCha.Text) + 2
            ElseIf LCase(cboRace.Text) = "gnome" Then
                'book two
                txtInt.Tag = Val(txtInt.Tag) + 2
                txtInt.Text = Val(txtInt.Text) + 2
                txtCha.Tag = Val(txtCha.Tag) + 2
                txtCha.Text = Val(txtCha.Text) + 2
            ElseIf LCase(cboRace.Text) = "half orc" Then
                txtStr.Tag = Val(txtStr.Tag) + 2
                txtStr.Text = Val(txtStr.Text) + 2
                txtDex.Tag = Val(txtDex.Tag) + 2
                txtDex.Text = Val(txtDex.Text) + 2
            ElseIf LCase(cboRace.Text) = "dwarf" Then
                txtCon.Tag = Val(txtCon.Tag) + 2
                txtCon.Text = Val(txtCon.Text) + 2
                txtWis.Tag = Val(txtWis.Tag) + 2
                txtWis.Text = Val(txtWis.Text) + 2
            ElseIf LCase(cboRace.Text) = "half elf" Then
                txtCon.Tag = Val(txtCon.Tag) + 2
                txtCon.Text = Val(txtCon.Text) + 2
                txtCha.Tag = Val(txtCha.Tag) + 2
                txtCha.Text = Val(txtCha.Text) + 2
            ElseIf LCase(cboRace.Text) = "elf" Then
                txtDex.Tag = Val(txtDex.Tag) + 2
                txtDex.Text = Val(txtDex.Text) + 2
                txtWis.Tag = Val(txtWis.Tag) + 2
                txtWis.Text = Val(txtWis.Text) + 2
            End If
            Console.WriteLine(LCase(cboRace.Text))
            Console.WriteLine("Dex: " & txtDex.Tag)
            Console.WriteLine("Str: " & txtStr.Tag)
            Console.WriteLine("Con: " & txtCon.Tag)
            Console.WriteLine("Int: " & txtInt.Tag)
            Console.WriteLine("Wis: " & txtWis.Tag)
            Console.WriteLine("Cha: " & txtCha.Tag)
        End If
    End Sub

#Region "Levels/Exp"
    ''' <summary>
    ''' update experience
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnExp_Click(sender As Object, e As EventArgs) Handles btnExp.Click
        Dim res = InputBox("Enter a number to change your experience by: ", "Experience Gain/Loss", 0)
        Dim goodInt As Boolean
        Do
            'assigns goodInt as true/false based on whether or not it's a number
            Integer.TryParse(res, goodInt)
            If goodInt Then
                'parse to integer
                'if it's a good integer, add it to your existing experience
                txtExp.Text = Val(txtExp.Text) + res
            Else
                'tell the user what they did wrong
                MessageBox.Show("Input must be a positive or negative number", "error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                res = InputBox("Enter a number to change your experience by: ", "Experience Gain/Loss", 0)
            End If
        Loop Until goodInt = True
    End Sub

    ''' <summary>
    ''' updates character level based on experience
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtExp_TextChanged(sender As Object, e As EventArgs) Handles txtExp.TextChanged
        'no negative experience allowed
        If Val(txtExp.Text) < 0 Then txtExp.Text = 0
        'find out if you've leveled up
        Call levelUp(Val(txtExp.Text))
    End Sub

    ''' <summary>
    ''' sub that increments levels
    ''' </summary>
    ''' <param name="xp">current exp</param>
    ''' <remarks></remarks>
    Private Sub levelUp(ByRef xp As Integer)
        'automates the checking procedure of experience versus level thresholds
        Dim start As Integer = IIf((txtLevel.Text IsNot Nothing And txtLevel.Text <> ""), Val(txtLevel.Text), 29)
        For i As Integer = start To 29
            If xp >= lvls(i + 1) Then
                'need this line so that leveling isn't calculated on formLoad.
                'also counters the fact that lvls(0) and lvls(1) are both integer of 0, which can be obnoxious.
                If txtLevel.Text <> "" Then
                    txtLevel.Text = Val(txtLevel.Text) + 1
                    'increase health accordingly
                    Select Case LCase(cboClass.Text)
                        Case "cleric", "ranger", "rogue", "warlock", "warlord"
                            txtHP.Text = Val(txtHP.Text) + 5
                        Case "fighter", "paladin"
                            txtHP.Text = Val(txtHP.Text) + 6
                        Case "wizard"
                            txtHP.Text = Val(txtHP.Text) + 4
                    End Select
                End If
            Else
                'don't check for loop more than you have to
                Exit For
            End If
        Next
    End Sub

    ''' <summary>
    ''' tracks character progress (level)
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtLevel_TextChanged(sender As Object, e As EventArgs) Handles txtLevel.TextChanged
        'add some stat mods to your character when you level up some times
        Select Case Val(txtLevel.Text)
            Case 1
                'racials are applied
                'can know 2 cantrips
                '           1 encounter
                '           1 daily
                '           0 utility
                cantrips = 2
                encounters = 1
                dailies = 1
            Case 2
                'can know 2 cantrips
                '           1 encounter
                '           1 daily
                '           1 utility
                cantrips = 2
                encounters = 1
                dailies = 1
            Case 3
                'can know 2 cantrips
                '           2 encounter
                '           1 daily
                '           1 utility
                cantrips = 2
                encounters = 2
                dailies = 1
            Case 4
                '+1 to two abilities
                cantrips = 2
                encounters = 2
                dailies = 1
            Case 5
                'can know 2 cantrips
                '           2 encounter
                '           2 daily
                '           1 utility
                cantrips = 2
                encounters = 2
                dailies = 2
            Case 6
                'can know 2 cantrips
                '           2 encounter
                '           2 daily
                '           2 utility
                cantrips = 2
                encounters = 2
                dailies = 2
            Case 7
                'can know 2 cantrips
                '           3 encounter
                '           2 daily
                '           2 utility
                cantrips = 2
                encounters = 3
                dailies = 2
            Case 8
                '+1 to two abilities
                cantrips = 2
                encounters = 3
                dailies = 2
            Case 9
                'can know 2 cantrips
                '           3 encounter
                '           3 daily
                '           2 utility
                cantrips = 2
                encounters = 3
                dailies = 3
            Case 10
                'can know 2 cantrips
                '           3 encounter
                '           3 daily
                '           3 utility
                cantrips = 2
                encounters = 3
                dailies = 3


            Case 11
                '+1 to ALL abilities
                'paragon path features
                'can know 2 cantrips
                '           3 encounter
                '               1 paragon 
                '           3 daily
                '           3 utility
            Case 12
                'can know 2 cantrips
                '           3 encounter
                '               1 paragon 
                '           3 daily
                '           3 utility
                '               1 paragon
            Case 13
                'can know 2 cantrips
                '           3 encounter
                '               1 paragon 
                '           3 daily
                '           3 utility
                '               1 paragon
                'replace 1 encounter
            Case 14
                '+1 to two abilities
            Case 15
                'can know 2 cantrips
                '           3 encounter
                '               1 paragon 
                '           3 daily
                '           3 utility
                '               1 paragon
                'replace 1 daily
            Case 16
                'paragon path feature
                'can know 2 cantrips
                '           3 encounter
                '               1 paragon 
                '           3 daily
                '           4 utility
                '               1 paragon
            Case 17
                'can know 2 cantrips
                '           3 encounter
                '               1 paragon 
                '           3 daily
                '           4 utility
                '               1 paragon
                'replace 1 encounter
            Case 18
                '+1 to two abilities
            Case 19
                'can know 2 cantrips
                '           3 encounter
                '               1 paragon 
                '           3 daily
                '           4 utility
                '               1 paragon
                'replace 1 daily
            Case 20
                'can know 2 cantrips
                '           3 encounter
                '               1 paragon 
                '           3 daily
                '               1 paragon
                '           4 utility
                '               1 paragon



            Case 21
                '+1 to ALL abilities
                'epic destiny feature
            Case 22
                'can know 2 cantrips
                '           3 encounter
                '               1 paragon 
                '           3 daily
                '               1 paragon
                '           5 utility
                '               1 paragon
            Case 23
                'can know 2 cantrips
                '           3 encounter
                '               1 paragon 
                '           3 daily
                '               1 paragon
                '           5 utility
                '               1 paragon
                'replace 1 encounter
            Case 24
                '+1 to two abilities
                'epic destiny feature
            Case 25
                'can know 2 cantrips
                '           3 encounter
                '               1 paragon 
                '           3 daily
                '               1 paragon
                '           5 utility
                '               1 paragon
                'replace 1 daily
            Case 26
                'can know 2 cantrips
                '           3 encounter
                '               1 paragon 
                '           3 daily
                '               1 paragon
                '           5 utility
                '               1 paragon
                '               1 epic
            Case 27
                'can know 2 cantrips
                '           3 encounter
                '               1 paragon 
                '           3 daily
                '               1 paragon
                '           5 utility
                '               1 paragon
                '               1 epic
                'replace 1 encounter
            Case 28
                '+1 to two abilities
            Case 29
                'can know 2 cantrips
                '           3 encounter
                '               1 paragon 
                '           3 daily
                '               1 paragon
                '           5 utility
                '               1 paragon
                '               1 epic
                'replace 1 daily
            Case 30
                'epic destiny feature



            Case Is > 30
                'do nothing
            Case Is < 1
                'levels start at 1, and are never negative
                txtLevel.Text = "1"
        End Select
    End Sub
#End Region

    ''' <summary>
    ''' updates tooltip to show the modifier of each ability score
    ''' </summary>
    ''' <param name="sender">ability text control</param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub abilMod_TextChanged(sender As Object, e As EventArgs) Handles txtStr.TextChanged, txtDex.TextChanged, txtWis.TextChanged, txtCha.TextChanged, txtInt.TextChanged, txtCon.TextChanged
        'everytime the ability score changes, update the tooltip
        Me.ttpHelp.SetToolTip(sender, "Roll 4d6. Take sum minus lowest result" & vbCrLf & "Modifier: " & vbTab & Val(sender.tag))
        'Console.WriteLine(sender.name & vbTab & CInt(sender.tag))
    End Sub

#Region "Colors"
    ''' <summary>
    ''' sets new random color on click of picturebox
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub pbxColor_Click(sender As Object, e As EventArgs) Handles pbxColor.MouseDown
        'if genColors has been ran, then just select a color from allCols at random, else generate the colors and then select a random color
        If allCols.Length <= 0 Then
            genColors()
            rColor()
        Else
            rColor()
        End If
    End Sub

    ''' <summary>
    ''' generates an array that holds all colors in it
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub genColors()
        'credit to: andrepeters.co.uk/?p=142
        Dim colType As Type = GetType(Color)
        Dim colInfo() As System.Reflection.PropertyInfo = colType.GetProperties
        Dim conv As New ColorConverter
        allCols = New Color() {}
        Dim i As Integer = 0
        Dim c As Color = Nothing
        Dim o As Object = Nothing
        For Each pi As System.Reflection.PropertyInfo In colInfo
            If pi.PropertyType.Name = "Color" And pi.Name <> "Transparent" Then
                o = conv.ConvertFromString(pi.Name)
                c = CType(o, Color)
                ReDim Preserve allCols(i)
                allCols(i) = c
                i += 1
            End If
        Next
    End Sub

    ''' <summary>
    ''' takes all colors into an array only if their of type Color
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub rColor()
        'select random index of allcols and assign that to the textbox
        Randomize()
        Dim r As New Random
        Dim rCol = allCols(r.Next(0, allCols.Length - 1))
        txtColor.Text = rCol.Name.ToString
        pbxColor.BackColor = rCol
    End Sub
#End Region

    ''' <summary>
    ''' opens frmSelPowers for power selection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnPowers_Click(sender As Object, e As EventArgs) Handles mnuPowers.Click
        Dim pow As New frmSelPowers
        If cboClass.Text = "" Then
            MessageBox.Show("You must select a class to see its powers", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If txtLevel.Text = "" Then
                txtLevel.Text = "1"
            End If
            'set values for powers and show form
            With pow
                .lev = Val(txtLevel.Text)
                .pcls = cboClass.Text
                .pid = Val(txtCName.Tag)
                .ShowDialog()
                .Dispose()
            End With
        End If
    End Sub

#Region "Printing"
    ''' <summary>
    ''' show print dialog for user and allow them to print out their character sheet
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub mnuPrint_Click(sender As Object, e As EventArgs) Handles mnuPrint.Click
        Dim res As Integer = MessageBox.Show("Print Character Sheet?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'opens a print inquiry
        If res = DialogResult.Yes Then
            pdDialog.Document = pdCharSheet
            pdDialog.PrinterSettings = pdCharSheet.PrinterSettings
            pdDialog.AllowSomePages = True
            'open printer dialog for user to select correct printer
            If pdDialog.ShowDialog = DialogResult.OK Then
                pdCharSheet.PrinterSettings = pdDialog.PrinterSettings
                pdCharSheet.Print()
            End If
        End If
    End Sub

    ''' <summary>
    ''' format of the output for the user when they print their character sheets
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub pdCharSheet_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pdCharSheet.PrintPage
        'must print a saved character
        If Val(txtCName.Tag) >= 0 Then
            Try
                'code for creating the invoice for the customer
                Dim intX As Integer = 10
                Dim intY As Integer = 10
                Dim chk As String = IIf(Val(txtCheck.Text) > 0, "+" & txtCheck.Text, txtCheck.Text)
                Dim strmod As String = IIf(Val(txtStr.Tag) > 0, "+" & txtStr.Tag, txtStr.Tag)
                Dim dexmod As String = IIf(Val(txtDex.Tag) > 0, "+" & txtDex.Tag, txtDex.Tag)
                Dim conmod As String = IIf(Val(txtCon.Tag) > 0, "+" & txtCon.Tag, txtCon.Tag)
                Dim intmod As String = IIf(Val(txtInt.Tag) > 0, "+" & txtInt.Tag, txtInt.Tag)
                Dim wismod As String = IIf(Val(txtWis.Tag) > 0, "+" & txtWis.Tag, txtWis.Tag)
                Dim chamod As String = IIf(Val(txtCha.Tag) > 0, "+" & txtCha.Tag, txtCha.Tag)

                Dim str As Integer = frmSelPlayer.Player(frmSelPlayer.lstPlayers.SelectedIndex).STR
                Dim dex As Integer = frmSelPlayer.Player(frmSelPlayer.lstPlayers.SelectedIndex).DEX
                Dim con As Integer = frmSelPlayer.Player(frmSelPlayer.lstPlayers.SelectedIndex).CON
                Dim int As Integer = frmSelPlayer.Player(frmSelPlayer.lstPlayers.SelectedIndex).INT
                Dim wis As Integer = frmSelPlayer.Player(frmSelPlayer.lstPlayers.SelectedIndex).WIS
                Dim cha As Integer = frmSelPlayer.Player(frmSelPlayer.lstPlayers.SelectedIndex).CHA
                Dim gender As String = IIf(LCase(cboGender.Text = "M"), "Male", "Female")

                Dim myFont As New System.Drawing.Font("Comic Sans MS", 12)
                Dim strCustomerLine As String = vbTab & vbTab & txtCName.Text & vbCrLf & _
                                                vbTab & vbTab & "Level " & txtLevel.Text & vbCrLf & _
                                                "   Base Stats" & vbTab & vbTab & "   Modifiers" & vbCrLf & _
                                                "Strength:" & vbTab & str & vbTab & vbTab & strmod & vbCrLf & _
                                                "Dexterity:" & vbTab & dex & vbTab & vbTab & dexmod & vbCrLf & _
                                                "Constitution:" & vbTab & con & vbTab & vbTab & conmod & vbCrLf & _
                                                "Intelligence:" & vbTab & int & vbTab & vbTab & intmod & vbCrLf & _
                                                "Wisdom:" & vbTab & wis & vbTab & vbTab & wismod & vbCrLf & _
                                                "Charisma:" & vbTab & cha & vbTab & vbTab & chamod & vbCrLf & _
                                                vbCrLf & vbCrLf & _
                                                "Class:" & vbTab & vbTab & cboClass.Text & vbCrLf & _
                                                "Race:" & vbTab & vbTab & cboRace.Text & vbCrLf & _
                                                "Gender:" & vbTab & vbTab & gender & vbCrLf & _
                                                "Alignment:" & vbTab & cboAlignment.Text & vbCrLf & _
                                                "Location:" & vbTab & txtLoc.Text & vbCrLf & _
                                                "Experience:" & vbTab & txtExp.Text & vbCrLf & _
                                                vbCrLf & _
                                                vbTab & "Weapon:" & vbTab & txtWepName.Text & vbCrLf & vbCrLf & _
                                                vbTab & "Helmet:" & vbTab & vbTab & txtHelm.Text & vbCrLf & _
                                                vbTab & "Necklace:" & vbTab & txtNeck.Text & vbCrLf & _
                                                vbTab & "Chestpiece:" & vbTab & txtChest.Text & vbCrLf & _
                                                vbTab & "Arms: " & vbTab & vbTab & txtArms.Text & vbCrLf & _
                                                vbTab & "Gloves:" & vbTab & vbTab & txtHands.Text & vbCrLf & _
                                                vbTab & "Bracers:" & vbTab & txtWrists.Text & vbCrLf & _
                                                vbTab & "Legs:" & vbTab & vbTab & txtLegs.Text & vbCrLf & _
                                                vbTab & "Feet:" & vbTab & vbTab & txtFeet.Text & vbCrLf & _
                                                vbCrLf & _
                                                 "Health:" & vbTab & vbTab & txtHP.Text & vbCrLf & _
                                                "Armor Class:" & vbTab & txtAC.Text & vbCrLf & _
                                                "Action Points:" & vbTab & txtAP.Text & vbCrLf & _
                                                "Money:" & vbTab & vbTab & txtMoney.Text & "gp" & vbCrLf & _
                                                "Weight:" & vbTab & vbTab & txtCarryCap.Text & "lbs" & vbCrLf & _
                                                "Check Mod:" & vbTab & chk

                e.Graphics.DrawString(strCustomerLine, myFont, Brushes.Black, intX, intY)
                intY += 16
            Catch ex As Exception
                MessageBox.Show("An error occurred during printing.")
            End Try
        End If
    End Sub
#End Region
End Class