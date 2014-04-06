Public Class frmSelPlayer
    'declare empty array of customer info
    Public Player(-1) As PlayerStats
    Public Weapon(-1) As WeapStats
    Public Armor(-1) As ArmorStats
    Dim TextBox As Control
    Event editPhone As EventHandler

    ''' <summary>
    ''' Structure to hold contact information
    ''' </summary>
    ''' <remarks>This will be implemented in an array</remarks>
    Structure PlayerStats
        Public ID As Long
        Public STR As String
        Public DEX As String
        Public CON As String
        Public INT As String
        Public WIS As String
        Public CHA As String
        Public Health As String
        Public Money As String
        Public AP As String
        Public pClass As String
        Public Race As String
        Public Gender As String
        Public Align As String
        Public Name As String
        Public Color As String
        Public WepID As String
        Public Level As String
        Public Exp As String
        Public Loc As String
        Public moSTR As String
        Public moDEX As String
        Public moCON As String
        Public moINT As String
        Public moWIS As String
        Public moCHA As String
        Public helm As Long
        Public chest As Long
        Public legs As Long
        Public arms As Long
        Public hands As Long
        Public feet As Long
        Public necklace As Long
        Public wrists As Long
    End Structure

    Structure WeapStats
        Public WID As Long
        Public wgt As Long
        Public armor As Long
        Public check As Long
        Public price As Double
        Public name As String
    End Structure

    Structure ArmorStats
        Public AID As Long
        Public wgt As Integer
        Public ACBon As Integer
        Public aClass As String
        Public chkMod As Integer
        Public price As Double
        Public name As String
        Public type As String
        'abil mods
        Public str As Integer
        Public dex As Integer
        Public wis As Integer
        Public cha As Integer
        Public int As Integer
        Public con As Integer
    End Structure

    ''' <summary>
    ''' Load customer information to structure using clsData
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadPlayerStats()
        'declare instance of class
        Dim PlayerData As New clsData
        Dim WeaponData As New clsData
        Dim ArmorData As New clsData
        'pass connection string from global module
        PlayerData.ConnectionString = mdlGlobal.strConnection
        WeaponData.ConnectionString = mdlGlobal.strConnection
        ArmorData.ConnectionString = mdlGlobal.strConnection
        'pass SQL command .... This triggers data fill in class object
        PlayerData.SQL = "SELECT * FROM tblPlayerStats ORDER BY pName, pLevel"
        WeaponData.SQL = "SELECT * FROM tblWeaps"
        ArmorData.SQL = "SELECT * FROM tblArmor"
        'clear out array of players
        ReDim Player(-1)
        ReDim Weapon(-1)
        ReDim Armor(-1)
        'clear out list box
        lstPlayers.Items.Clear()
        'string used for listbox formatting
        Dim fmtString As String = "{0,-40} {1,0}"
        Dim fmtString2 As String = "{0,-40} {1,10} {2,10}"
        'loop through each record, store in structure, display names in list box
        For i As Integer = 0 To PlayerData.ds.Tables(0).Rows.Count - 1
            ReDim Preserve Player(Player.Length)
            With Player(Player.Length - 1)
                .ID = PlayerData.ds.Tables(0).Rows(i).Item("pID").ToString
                .STR = PlayerData.ds.Tables(0).Rows(i).Item("pStr").ToString
                .DEX = PlayerData.ds.Tables(0).Rows(i).Item("pDEX").ToString
                .CON = PlayerData.ds.Tables(0).Rows(i).Item("pCON").ToString
                .INT = PlayerData.ds.Tables(0).Rows(i).Item("pINT").ToString
                .WIS = PlayerData.ds.Tables(0).Rows(i).Item("pWIS").ToString
                .CHA = PlayerData.ds.Tables(0).Rows(i).Item("pCHA").ToString
                .Health = PlayerData.ds.Tables(0).Rows(i).Item("pHealth").ToString
                .Money = PlayerData.ds.Tables(0).Rows(i).Item("pMoney").ToString
                .AP = PlayerData.ds.Tables(0).Rows(i).Item("pActionPoints").ToString
                .pClass = PlayerData.ds.Tables(0).Rows(i).Item("pClass").ToString
                .Race = PlayerData.ds.Tables(0).Rows(i).Item("pRace").ToString
                .Gender = PlayerData.ds.Tables(0).Rows(i).Item("pGender").ToString
                .Align = PlayerData.ds.Tables(0).Rows(i).Item("pAlign").ToString
                .Name = PlayerData.ds.Tables(0).Rows(i).Item("pName").ToString
                .Color = PlayerData.ds.Tables(0).Rows(i).Item("pColor").ToString
                .WepID = PlayerData.ds.Tables(0).Rows(i).Item("wID").ToString
                .Level = PlayerData.ds.Tables(0).Rows(i).Item("pLevel").ToString
                .Exp = PlayerData.ds.Tables(0).Rows(i).Item("pExp").ToString
                .Loc = PlayerData.ds.Tables(0).Rows(i).Item("pCharLoc").ToString
                .moSTR = PlayerData.ds.Tables(0).Rows(i).Item("modSTR").ToString
                .moDEX = PlayerData.ds.Tables(0).Rows(i).Item("modDEX").ToString
                .moCON = PlayerData.ds.Tables(0).Rows(i).Item("modCON").ToString
                .moINT = PlayerData.ds.Tables(0).Rows(i).Item("modINT").ToString
                .moWIS = PlayerData.ds.Tables(0).Rows(i).Item("modWIS").ToString
                .moCHA = PlayerData.ds.Tables(0).Rows(i).Item("modCHA").ToString
                .helm = PlayerData.ds.Tables(0).Rows(i).Item("aHead").ToString
                .chest = PlayerData.ds.Tables(0).Rows(i).Item("aChest").ToString
                .legs = PlayerData.ds.Tables(0).Rows(i).Item("aLegs").ToString
                .arms = PlayerData.ds.Tables(0).Rows(i).Item("aArms").ToString
                .hands = PlayerData.ds.Tables(0).Rows(i).Item("aHands").ToString
                .feet = PlayerData.ds.Tables(0).Rows(i).Item("aFeet").ToString
                .wrists = PlayerData.ds.Tables(0).Rows(i).Item("aWrists").ToString
                .necklace = PlayerData.ds.Tables(0).Rows(i).Item("aNeck").ToString
                lstPlayers.Items.Add(String.Format(fmtString, .Name, .Level))
                Console.WriteLine(String.Format(fmtString2, .Name, .Level, .ID))
            End With
        Next
        'weapons
        For i As Integer = 0 To WeaponData.ds.Tables(0).Rows.Count - 1
            ReDim Preserve Weapon(Weapon.Length)
            With Weapon(Weapon.Length - 1)
                .WID = WeaponData.ds.Tables(0).Rows(i).Item("wID").ToString
                .wgt = WeaponData.ds.Tables(0).Rows(i).Item("wWgt").ToString
                .armor = WeaponData.ds.Tables(0).Rows(i).Item("wArmBon").ToString
                .check = WeaponData.ds.Tables(0).Rows(i).Item("wChkMod").ToString
                .price = WeaponData.ds.Tables(0).Rows(i).Item("wPrice").ToString
                .name = WeaponData.ds.Tables(0).Rows(i).Item("wName").ToString
            End With
        Next
        'armor
        For i As Integer = 0 To ArmorData.ds.Tables(0).Rows.Count - 1
            ReDim Preserve Armor(Armor.Length)
            With Armor(Armor.Length - 1)
                .AID = ArmorData.ds.Tables(0).Rows(i).Item("aID").ToString
                .wgt = ArmorData.ds.Tables(0).Rows(i).Item("aWgt").ToString
                .ACBon = ArmorData.ds.Tables(0).Rows(i).Item("aACBon").ToString
                .aClass = ArmorData.ds.Tables(0).Rows(i).Item("aClass").ToString
                .chkMod = ArmorData.ds.Tables(0).Rows(i).Item("aChkMod").ToString
                .price = ArmorData.ds.Tables(0).Rows(i).Item("aPrice").ToString
                .name = ArmorData.ds.Tables(0).Rows(i).Item("aName").ToString
                .type = ArmorData.ds.Tables(0).Rows(i).Item("aType").ToString
                'abil mods
                .str = ArmorData.ds.Tables(0).Rows(i).Item("aSTR").ToString
                .dex = ArmorData.ds.Tables(0).Rows(i).Item("aDEX").ToString()
                .wis = ArmorData.ds.Tables(0).Rows(i).Item("aWIS").ToString()
                .cha = ArmorData.ds.Tables(0).Rows(i).Item("aCHA").ToString()
                .int = ArmorData.ds.Tables(0).Rows(i).Item("aINT").ToString()
                .con = ArmorData.ds.Tables(0).Rows(i).Item("aCON").ToString()
            End With
        Next
    End Sub

    ''' <summary>
    ''' Load customer information to program and screen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmSelPlayer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'load all players into list box on startup
        Call LoadPlayerStats()
        'select the listbox on loadup of form
        lstPlayers.Select()
        'Add a handler for doubleclicking the a person on the list box and clicking edit on form load
        AddHandler lstPlayers.DoubleClick, AddressOf btnEdit_Click
        AddHandler btnEdit.Click, AddressOf btnEdit_Click
    End Sub

    ''' <summary>
    ''' If user has selected customer, validate desire to delete, and delete from database
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        'validate Player has been selected
        If lstPlayers.SelectedIndex > -1 Then
            'validate desire to delete Player
            If MessageBox.Show("Are you sure you want to delete this Player?", "Delete Player", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                'create instance of class
                Dim CallData As New clsData
                Dim delID As Integer = Player(lstPlayers.SelectedIndex).ID
                'pass connection string
                CallData.ConnectionString = mdlGlobal.strConnection
                'pass SQL command
                CallData.SQL = "SELECT * FROM tblPlayerStats WHERE pID = " & delID
                'delete row from dataset
                CallData.ds.Tables(0).Rows(0).Delete()
                'update database
                CallData.da.Update(CallData.ds)
                'refresh screen and structure
                Call LoadPlayerStats()
            End If
        Else
            MessageBox.Show("Please select a player to delete", "Delete Player")
        End If
    End Sub

    ''' <summary>
    ''' If customer is selected, display customer information in frmCustomerReceord
    ''' Once complete with edit, refresh this form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If lstPlayers.SelectedIndex > -1 Then
            Dim c As Color = Color.FromName(Player(lstPlayers.SelectedIndex).Color)
            Dim PlayerRecord As New frmCharSheet
            With PlayerRecord
                .txtCName.Tag = Player(lstPlayers.SelectedIndex).ID
                .txtStr.Text = Player(lstPlayers.SelectedIndex).STR
                .txtDex.Text = Player(lstPlayers.SelectedIndex).DEX
                .txtCon.Text = Player(lstPlayers.SelectedIndex).CON
                .txtInt.Text = Player(lstPlayers.SelectedIndex).INT
                .txtWis.Text = Player(lstPlayers.SelectedIndex).WIS
                .txtCha.Text = Player(lstPlayers.SelectedIndex).CHA
                .txtHP.Text = Player(lstPlayers.SelectedIndex).Health
                .txtMoney.Text = Player(lstPlayers.SelectedIndex).Money
                .txtAP.Text = Player(lstPlayers.SelectedIndex).AP
                .cboClass.Text = Player(lstPlayers.SelectedIndex).pClass
                .cboRace.Text = Player(lstPlayers.SelectedIndex).Race
                .cboGender.Text = Player(lstPlayers.SelectedIndex).Gender
                .cboAlignment.Text = Player(lstPlayers.SelectedIndex).Align
                .txtCName.Text = Player(lstPlayers.SelectedIndex).Name
                .txtColor.Text = Player(lstPlayers.SelectedIndex).Color
                .pbxColor.BackColor = c
                .txtWepName.Tag = Player(lstPlayers.SelectedIndex).WepID
                .txtHelm.Tag = Player(lstPlayers.SelectedIndex).helm
                .txtChest.Tag = Player(lstPlayers.SelectedIndex).chest
                .txtLegs.Tag = Player(lstPlayers.SelectedIndex).legs
                .txtArms.Tag = Player(lstPlayers.SelectedIndex).arms
                .txtHands.Tag = Player(lstPlayers.SelectedIndex).hands
                .txtFeet.Tag = Player(lstPlayers.SelectedIndex).feet
                .txtNeck.Tag = Player(lstPlayers.SelectedIndex).necklace
                .txtWrists.Tag = Player(lstPlayers.SelectedIndex).wrists
                .txtAC.Text = 10 + Math.Floor(0.5 * Player(lstPlayers.SelectedIndex).Level)

                'find weapon name based on weapon ID
                For j As Integer = 0 To (Weapon.Length - 1)
                    If Weapon(j).WID = .txtWepName.Tag Then
                        .txtWepName.Text = Weapon(j).name
                        loadStat(Val(Weapon(j).wgt), "weight", PlayerRecord)
                        loadStat(Val(Weapon(j).armor), "ac", PlayerRecord)
                        loadStat(Val(Weapon(j).check), "chk", PlayerRecord)
                    End If
                Next

                .txtLevel.Text = Player(lstPlayers.SelectedIndex).Level
                .txtExp.Text = Player(lstPlayers.SelectedIndex).Exp
                .txtLoc.Text = Player(lstPlayers.SelectedIndex).Loc

                'mod ability scores
                .txtStr.Tag = Player(lstPlayers.SelectedIndex).moSTR
                .txtDex.Tag = Player(lstPlayers.SelectedIndex).moDEX
                .txtCon.Tag = Player(lstPlayers.SelectedIndex).moCON
                .txtInt.Tag = Player(lstPlayers.SelectedIndex).moINT
                .txtWis.Tag = Player(lstPlayers.SelectedIndex).moWIS
                .txtCha.Tag = Player(lstPlayers.SelectedIndex).moCHA

                'load armor based on armor IDs
                For j As Integer = 0 To (Armor.Length - 1)
                    'headpiece
                    If Armor(j).AID = .txtHelm.Tag Then
                        .txtHelm.Text = Armor(j).name
                        loadStat(Armor(j).wgt, "weight", PlayerRecord)
                        loadStat(Armor(j).ACBon, "ac", PlayerRecord, Armor(j).aClass)
                        loadStat(Val(Armor(j).chkMod), "chk", PlayerRecord)
                        loadStat(Armor(j).str, "str", PlayerRecord)
                        loadStat(Armor(j).dex, "dex", PlayerRecord)
                        loadStat(Armor(j).wis, "wis", PlayerRecord)
                        loadStat(Armor(j).cha, "cha", PlayerRecord)
                        loadStat(Armor(j).int, "int", PlayerRecord)
                        loadStat(Armor(j).con, "con", PlayerRecord)
                    End If
                    'chestpiece
                    If Armor(j).AID = .txtChest.Tag Then
                        .txtChest.Text = Armor(j).name
                        loadStat(Armor(j).wgt, "weight", PlayerRecord)
                        loadStat(Armor(j).ACBon, "ac", PlayerRecord, Armor(j).aClass)
                        loadStat(Val(Armor(j).chkMod), "chk", PlayerRecord)
                        loadStat(Armor(j).str, "str", PlayerRecord)
                        loadStat(Armor(j).dex, "dex", PlayerRecord)
                        loadStat(Armor(j).wis, "wis", PlayerRecord)
                        loadStat(Armor(j).cha, "cha", PlayerRecord)
                        loadStat(Armor(j).int, "int", PlayerRecord)
                        loadStat(Armor(j).con, "con", PlayerRecord)
                    End If
                    'leg armor
                    If Armor(j).AID = .txtLegs.Tag Then
                        .txtLegs.Text = Armor(j).name
                        loadStat(Armor(j).wgt, "weight", PlayerRecord)
                        loadStat(Armor(j).ACBon, "ac", PlayerRecord, Armor(j).aClass)
                        loadStat(Val(Armor(j).chkMod), "chk", PlayerRecord)
                        loadStat(Armor(j).str, "str", PlayerRecord)
                        loadStat(Armor(j).dex, "dex", PlayerRecord)
                        loadStat(Armor(j).wis, "wis", PlayerRecord)
                        loadStat(Armor(j).cha, "cha", PlayerRecord)
                        loadStat(Armor(j).int, "int", PlayerRecord)
                        loadStat(Armor(j).con, "con", PlayerRecord)
                    End If
                    'arm armor
                    If Armor(j).AID = .txtArms.Tag Then
                        .txtArms.Text = Armor(j).name
                        loadStat(Armor(j).wgt, "weight", PlayerRecord)
                        loadStat(Armor(j).ACBon, "ac", PlayerRecord, Armor(j).aClass)
                        loadStat(Val(Armor(j).chkMod), "chk", PlayerRecord)
                        loadStat(Armor(j).str, "str", PlayerRecord)
                        loadStat(Armor(j).dex, "dex", PlayerRecord)
                        loadStat(Armor(j).wis, "wis", PlayerRecord)
                        loadStat(Armor(j).cha, "cha", PlayerRecord)
                        loadStat(Armor(j).int, "int", PlayerRecord)
                        loadStat(Armor(j).con, "con", PlayerRecord)
                    End If
                    'gloves
                    If Armor(j).AID = .txtHands.Tag Then
                        .txtHands.Text = Armor(j).name
                        loadStat(Armor(j).wgt, "weight", PlayerRecord)
                        loadStat(Armor(j).ACBon, "ac", PlayerRecord, Armor(j).aClass)
                        loadStat(Val(Armor(j).chkMod), "chk", PlayerRecord)
                        loadStat(Armor(j).str, "str", PlayerRecord)
                        loadStat(Armor(j).dex, "dex", PlayerRecord)
                        loadStat(Armor(j).wis, "wis", PlayerRecord)
                        loadStat(Armor(j).cha, "cha", PlayerRecord)
                        loadStat(Armor(j).int, "int", PlayerRecord)
                        loadStat(Armor(j).con, "con", PlayerRecord)
                    End If
                    'shoes
                    If Armor(j).AID = .txtFeet.Tag Then
                        .txtFeet.Text = Armor(j).name
                        loadStat(Armor(j).wgt, "weight", PlayerRecord)
                        loadStat(Armor(j).ACBon, "ac", PlayerRecord, Armor(j).aClass)
                        loadStat(Val(Armor(j).chkMod), "chk", PlayerRecord)
                        loadStat(Armor(j).str, "str", PlayerRecord)
                        loadStat(Armor(j).dex, "dex", PlayerRecord)
                        loadStat(Armor(j).wis, "wis", PlayerRecord)
                        loadStat(Armor(j).cha, "cha", PlayerRecord)
                        loadStat(Armor(j).int, "int", PlayerRecord)
                        loadStat(Armor(j).con, "con", PlayerRecord)
                    End If
                    'necklace
                    If Armor(j).AID = .txtNeck.Tag Then
                        .txtNeck.Text = Armor(j).name
                        loadStat(Armor(j).wgt, "weight", PlayerRecord)
                        loadStat(Armor(j).ACBon, "ac", PlayerRecord, Armor(j).aClass)
                        loadStat(Val(Armor(j).chkMod), "chk", PlayerRecord)
                        loadStat(Armor(j).str, "str", PlayerRecord)
                        loadStat(Armor(j).dex, "dex", PlayerRecord)
                        loadStat(Armor(j).wis, "wis", PlayerRecord)
                        loadStat(Armor(j).cha, "cha", PlayerRecord)
                        loadStat(Armor(j).int, "int", PlayerRecord)
                        loadStat(Armor(j).con, "con", PlayerRecord)
                    End If
                    'bracers
                    If Armor(j).AID = .txtWrists.Tag Then
                        .txtWrists.Text = Armor(j).name
                        loadStat(Armor(j).wgt, "weight", PlayerRecord)
                        loadStat(Armor(j).ACBon, "ac", PlayerRecord, Armor(j).aClass)
                        loadStat(Val(Armor(j).chkMod), "chk", PlayerRecord)
                        loadStat(Armor(j).str, "str", PlayerRecord)
                        loadStat(Armor(j).dex, "dex", PlayerRecord)
                        loadStat(Armor(j).wis, "wis", PlayerRecord)
                        loadStat(Armor(j).cha, "cha", PlayerRecord)
                        loadStat(Armor(j).int, "int", PlayerRecord)
                        loadStat(Armor(j).con, "con", PlayerRecord)
                    End If
                Next

                'lock the Character sheet until explicitly stated to edit it
                .cboAlignment.Enabled = False
                .cboClass.Enabled = False
                .cboGender.Enabled = False
                .cboRace.Enabled = False
                .txtStr.ReadOnly = True
                .txtDex.ReadOnly = True
                .txtCha.ReadOnly = True
                .txtCon.ReadOnly = True
                .txtInt.ReadOnly = True
                .txtWis.ReadOnly = True
                .txtCName.ReadOnly = True
                .txtHP.ReadOnly = True
                .txtAC.ReadOnly = True
                .txtMoney.ReadOnly = True
                .txtInitiative.ReadOnly = True
                .txtCheck.ReadOnly = True
                .txtAP.ReadOnly = True
                .txtColor.ReadOnly = True
                .txtCarryCap.ReadOnly = True
                .txtWepName.ReadOnly = True
                .txtLevel.ReadOnly = True
                .txtExp.ReadOnly = True
                .txtLoc.ReadOnly = True
                .btnCalc.Enabled = False
                .btnRandomize.Enabled = False
                'armor
                .txtHelm.ReadOnly = True
                .txtChest.ReadOnly = True
                .txtLegs.ReadOnly = True
                .txtArms.ReadOnly = True
                .txtHands.ReadOnly = True
                .txtFeet.ReadOnly = True
                .txtNeck.ReadOnly = True
                .txtWrists.ReadOnly = True
                'equipment buttons
                .btnSelWeap.Enabled = False
                .btnSWeap.Enabled = False
                .btnHead.Enabled = False
                .btnNeck.Enabled = False
                .btnChest.Enabled = False
                .btnArms.Enabled = False
                .btnHands.Enabled = False
                .btnLegs.Enabled = False
                .btnFeet.Enabled = False
                .btnWrists.Enabled = False
                .btnSelArmor.Enabled = False
            End With
            Me.Hide()
            PlayerRecord.ShowDialog()
            Me.Show()
            Call LoadPlayerStats()
        End If
    End Sub

    ''' <summary>
    ''' Load frmCustomerRecord and refresh this screen upon return
    ''' </summary>
    ''' <param name="sender">Add button click</param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim PlayerRecord As New frmCharSheet
        PlayerRecord.txtCName.Tag = ""
        Me.Hide()
        PlayerRecord.ShowDialog()
        Me.Show()
        Call LoadPlayerStats()
    End Sub

    ''' <summary>
    ''' Ends the program
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>completely ends the program</remarks>
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Ends the program entirely
        Me.Close()
    End Sub

    ''' <summary>
    ''' creates instance of frmDiceRoll. need to search strings, "1d4" is going to be 1 roll between 1+4
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnRollDice_Click(sender As Object, e As EventArgs) Handles btnRollDice.Click
        'open a form for rolling a bunch of dice
        Me.Hide()
        frmDiceRoll.ShowDialog()
        Me.Show()
    End Sub

    ''' <summary>
    ''' sub that makes adding armor/weapon stats easier
    ''' </summary>
    ''' <param name="arr">a player stat property of an array</param>
    ''' <param name="stat">the type of stat arr refers to</param>
    ''' <remarks></remarks>
    Private Sub loadStat(ByVal arr, ByVal stat, ByVal pRec, Optional ByVal type = "")
        With pRec
            Select Case stat
                Case "weight"
                    .txtCarryCap.Text = Val(.txtCarryCap.Text) + arr
                    Console.WriteLine("Weight: " & vbTab & Val(.txtCarryCap.Text))
                Case "ac"
                    'AC is 10+ 1/2level + weapon/armor AC bonuses
                    '(10+ 1/2level) is taken care of outside of this subprocedure as it should only be called once
                    .txtAC.Text = Val(.txtAC.Text) + arr
                    Console.WriteLine("AC: " & vbTab & vbTab & Val(.txtAC.Text))
                    If LCase(type) = "light" Or LCase(type) = "none" Then
                        If Val(.txtDex.tag) > 0 Or Val(.txtint.tag) Then
                            .txtAC.Text += IIf(Val(.txtDex.Tag) > Val(.txtInt.Tag), Val(.txtDex.Tag), Val(.txtInt.Tag))
                            Console.WriteLine("AC After Mod: " & Val(.txtAC.Text))
                        End If
                    End If
                Case "chk"
                    'sum all check mods
                    .txtCheck.text = Val(.txtCheck.text) + arr
                    Console.WriteLine("Check: " & vbTab & Val(.txtCheck.text))
                Case "str"
                    'add strength modifer
                    .txtStr.tag = Val(.txtStr.tag) + arr
                Case "dex"
                    'add dex mod
                    .txtDex.tag = Val(.txtDex.tag) + arr
                Case "wis"
                    'add wis mod
                    .txtWis.tag = Val(.txtWis.tag) + arr
                Case "cha"
                    'add cha mod
                    .txtCha.tag = Val(.txtCha.tag) + arr
                Case "int"
                    'add int mod
                    .txtInt.tag = Val(.txtInt.tag) + arr
                Case "con"
                    'add con mod
                    .txtCon.tag = Val(.txtCon.tag) + arr
            End Select
        End With
    End Sub
End Class