Public Class frmAbilSkillRoll
    'these are public variables so that they can be passed back to the character sheet
    Public initRoll As Integer = -1

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
        Dim dexMod As Integer = frmSelPlayer.Player(frmSelPlayer.lstPlayers.SelectedIndex).moDEX
        Dim hLev As Integer = Math.Floor(0.5 * frmSelPlayer.Player(frmSelPlayer.lstPlayers.SelectedIndex).Level)
        Console.WriteLine("D20: " & d20)
        Console.WriteLine("Dex mod: " & dexMod)
        Console.WriteLine("Half Level: " & hLev)
        initRoll = dexMod + hLev + d20
        txtInit.Text = initRoll
        frmCharSheet.txtInitiative.Text = initRoll
    End Sub

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
    ''' Strength Check
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
            Dim hlev As Integer = Math.Floor(0.5 * .Player(.lstPlayers.SelectedIndex).Level)
            Dim abil As Integer = -99
            Dim txt As New TextBox
            Dim check As Integer = 0

            'find out which ability we're checking
            Select Case sender.name
                Case "btnStrChk"
                    abil = .Player(.lstPlayers.SelectedIndex).moSTR
                    txt = txtStrChk
                Case "btnDexChk"
                    abil = .Player(.lstPlayers.SelectedIndex).moDEX
                    txt = txtDexChk
                Case "btnConChk"
                    abil = .Player(.lstPlayers.SelectedIndex).moCON
                    txt = txtConChk
                Case "btnChaChk"
                    abil = .Player(.lstPlayers.SelectedIndex).moCHA
                    txt = txtChaChk
                Case "btnWisChk"
                    abil = .Player(.lstPlayers.SelectedIndex).moWIS
                    txt = txtWisChk
                Case "btnIntChk"
                    abil = .Player(.lstPlayers.SelectedIndex).moINT
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
        Me.MinimumSize = Me.Size
    End Sub
End Class