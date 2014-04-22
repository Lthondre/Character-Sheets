Public Class frmAbilSkillRoll
#Region "Form Variables"
    'these are public variables so that they can be passed back to the character sheet
    Public initRoll As Integer = -1
    Public mstr As Integer
    Public mcon As Integer
    Public mdex As Integer
    Public mint As Integer
    Public mwis As Integer
    Public mcha As Integer
    Public ac As Integer
    Public lev As Integer
#End Region

    ''' <summary>
    ''' button rolls a random initiative
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnInit_Click(sender As Object, e As EventArgs) Handles btnInit.Click
        'roll 1d20, add dex mod and 1/2 char level, always round down (truncate)
        Randomize() 'reseed the RNG
        Dim d20 As Integer = CInt(Int((Rnd() * 20) + 1))
        Dim hLev As Integer = Math.Floor(0.5 * lev)
        Console.WriteLine("D20: " & d20)
        Console.WriteLine("Dex mod: " & mdex)
        Console.WriteLine("Half Level: " & hLev)
        initRoll = mdex + hLev + d20
        txtInit.Text = initRoll
        frmCharSheet.txtInitiative.Text = initRoll
    End Sub

    ''' <summary>
    ''' Roll active perception check
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnPerception_Click(sender As Object, e As EventArgs) Handles btnPerception.Click
        'looks like 4e active perception checks are just 1d20
        Randomize()
        txtPerc.Text = CInt(Int((Rnd() * 20) + 1))
    End Sub

    ''' <summary>
    ''' Ability/Skill Check
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnStrChk_Click(sender As Object, e As EventArgs) Handles btnStrChk.Click, btnDexChk.Click, btnConChk.Click, btnWisChk.Click, btnIntChk.Click, btnChaChk.Click
        With frmSelPlayer
            '1d20 + 1/2 level + ability mod
            'they're all the same
            Randomize()
            Dim r As Integer = CInt(Int((Rnd() * 20) + 1))
            Dim hlev As Integer = Math.Floor(0.5 * lev)
            Dim abil As Integer = -99
            Dim txt As New TextBox
            Dim check As Integer = 0

            'find out which ability we're checking
            Select Case sender.name
                Case "btnStrChk"
                    abil = mstr
                    txt = txtStrChk
                Case "btnDexChk"
                    abil = mdex
                    txt = txtDexChk
                Case "btnConChk"
                    abil = mcon
                    txt = txtConChk
                Case "btnChaChk"
                    abil = mcha
                    txt = txtChaChk
                Case "btnWisChk"
                    abil = mwis
                    txt = txtWisChk
                Case "btnIntChk"
                    abil = mint
                    txt = txtIntChk
                Case Else
                    'not sure how you got here, but here's a nice error message for the user
                    MessageBox.Show("That is not a valid check button", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select

            'show values in console and send sum to sender
            Console.WriteLine("1d20: " & vbTab & vbTab & r)
            Console.WriteLine("1/2Level: " & vbTab & hlev)
            Console.WriteLine("Abil mod: " & vbTab & abil)
            txt.Text = r + hlev + abil
            'add check modifiers to roll if it is skill based
            If rbtnSkill.Checked = True Then
                Console.WriteLine("Chk mod: " & vbTab & Val(mdlGlobal.check))
                txt.Text = Val(txt.Text) + Val(mdlGlobal.check)
            End If
        End With
    End Sub

    ''' <summary>
    ''' sets minimum size on form load
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmAbilSkillRoll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'set minimum size for form
        Me.MinimumSize = Me.Size
        'reset defense textbox so as not to confuse user with incorrect numbers
        txtDef.Text = ""
    End Sub

    ''' <summary>
    ''' updates the textbox with current defense score
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub rbtnAC_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnAC.CheckedChanged, rbtnFort.CheckedChanged, rbtnRef.CheckedChanged, rbtnWill.CheckedChanged
        With frmSelPlayer
            '10 + 1/2lev + one of the following + class mods + racial
            txtDef.Text = 10 + Math.Floor(0.5 * lev)
            Console.WriteLine(mstr)
            Console.WriteLine(mcon)
            Console.WriteLine(mdex)
            Console.WriteLine(mint)
            Console.WriteLine(mwis)
            Console.WriteLine(mcha)
            Dim fort As Integer = IIf((mstr > mcon), mstr, mcon)
            Dim ref As Integer = IIf((mdex > mint), mdex, mint)
            Dim will As Integer = IIf((mwis > mcha), mwis, mcha)
            'class mods
            Select Case LCase(.Player(.lstPlayers.SelectedIndex).pClass)
                Case "cleric"
                    will += 2
                Case "ranger"
                    fort += 1
                    ref += 1
                Case "rogue"
                    ref += 2
                Case "warlock"
                    ref += 1
                    will += 1
                Case "warlord"
                    fort += 1
                    will += 1
                Case "fighter"
                    fort += 2
                Case "paladin"
                    fort += 1
                    ref += 1
                    will += 1
                Case "wizard"
                    will += 2
            End Select

            If rbtnAC.Checked Then
                'add AC
                Console.WriteLine("AC: " & vbTab & ac)
                txtDef.Text = Val(txtDef.Text) + ac
            End If

            If rbtnFort.Checked Then
                'add higher of the two: strength mod/constitution mod
                Console.WriteLine("Fort: " & vbTab & fort)
                txtDef.Text = Val(txtDef.Text) + fort
            End If

            If rbtnRef.Checked Then
                'add dex/int mod. whichever is higher
                Console.WriteLine("Ref: " & vbTab & ref)
                txtDef.Text = Val(txtDef.Text) + ref
            End If

            If rbtnWill.Checked Then
                'add wis/cha mod. whichever is higher
                Console.WriteLine("Will: " & vbTab & will)
                txtDef.Text = Val(txtDef.Text) + will
            End If
        End With
    End Sub

#Region "Close form"
    ''' <summary>
    ''' Closes the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'close the form
        Me.Close()
    End Sub

    ''' <summary>
    ''' closes the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>this button exists solely for the user, all calculations are done in the parent form</remarks>
    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
        'close the form
        Me.Close()
    End Sub
#End Region
End Class