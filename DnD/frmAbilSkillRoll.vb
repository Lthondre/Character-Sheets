Public Class frmAbilSkillRoll
    'these are public variables so that they can be passed back to the character sheet
    Public initRoll As Integer
    Public percRoll As Integer

    ''' <summary>
    ''' button rolls a random initiative
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnInit_Click(sender As Object, e As EventArgs) Handles btnInit.Click
        'roll 1d20, add dex mod and 1/2 char level
        Randomize()
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

    Private Sub btnPerception_Click(sender As Object, e As EventArgs) Handles btnPerception.Click
        'still need to figure out how exactly to calculate perception
        MessageBox.Show("Developer is working hard on giving this button a purpose!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub
End Class