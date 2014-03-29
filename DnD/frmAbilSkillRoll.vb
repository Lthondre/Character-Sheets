Public Class frmAbilSkillRoll
    Public initRoll As Integer
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

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'close the form
        Me.Close()
    End Sub

    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
        'close the form
        Me.Close()
    End Sub
End Class