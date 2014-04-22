Public Class frmDiceRoll
#Region "Form Variables"
    Event clearForm As EventHandler 'still being used
    Dim sum As Integer = 0
    Dim total As Integer = 0
#End Region

    ''' <summary>
    ''' toggles the status of the check mark next to the numericUpDown control being changed to on.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub numXd4_ValueChanged(sender As Object, e As EventArgs) Handles numXd4.ValueChanged, numXd6.ValueChanged, numXd8.ValueChanged, numXd10.ValueChanged, numXd12.ValueChanged, numXd20.ValueChanged
        'enable the corresponding checkbox when the value changes
        Select Case sender.name
            Case "numXd4"
                chkD4.Checked = True
            Case "numXd6"
                chkD6.Checked = True
            Case "numXd8"
                chkD8.Checked = True
            Case "numXd10"
                chkD10.Checked = True
            Case "numXd12"
                chkD12.Checked = True
            Case "numXd20"
                chkD20.Checked = True
        End Select
    End Sub

    ''' <summary>
    ''' clears the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnClear_Click(sender As Object, e As EventArgs)
        'clear the form
        numXd4.Value = 0
        numXd6.Value = 0
        numXd8.Value = 0
        numXd10.Value = 0
        numXd12.Value = 0
        numXd20.Value = 0
        chkD4.Checked = False
        chkD6.Checked = False
        chkD8.Checked = False
        chkD10.Checked = False
        chkD12.Checked = False
        chkD20.Checked = False
        rtxtOutCome.Clear()
    End Sub

    ''' <summary>
    ''' calculates values of all fields that have been tickmarked.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        'reset variables
        sum = 0
        total = 0
        'clear out text
        rtxtOutCome.Clear()

        'checks to see if each checkbox is clicked, then generates random number in correct range
        If chkD4.Checked Then
            Call calc(numXd4.Value, 4)
        End If
        If chkD6.Checked Then
            Call calc(numXd6.Value, 6)
        End If
        If chkD8.Checked Then
            Call calc(numXd8.Value, 8)
        End If
        If chkD10.Checked Then
            Call calc(numXd10.Value, 10)
        End If
        If chkD12.Checked Then
            Call calc(numXd12.Value, 12)
        End If
        If chkD20.Checked Then
            Call calc(numXd20.Value, 20)
        End If
        rtxtOutCome.Text += "Grand total: " & vbTab & total
    End Sub

    ''' <summary>
    ''' sub for calculating the random values and adding to the output box
    ''' </summary>
    ''' <param name="val">value of the recieving numericUpDown control</param>
    ''' <param name="num">max number of the current die being thrown (e.g. 4, 20, 12)</param>
    ''' <remarks></remarks>
    Private Sub calc(ByVal val As Integer, ByVal num As Integer)
        sum = 0
        For i As Integer = 1 To val
            Randomize() 'generate new random seed
            Dim r As Integer = CInt(Int((num * Rnd()) + 1))
            rtxtOutCome.Text += i & "d" & num & "  " & vbTab & vbTab & r & vbCrLf
            sum += r
            total += r
        Next
        rtxtOutCome.Text += "Subtotal: " & sum & vbCrLf
        rtxtOutCome.Text += vbCrLf
    End Sub

    ''' <summary>
    ''' closes the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'close form
        Me.Dispose()
    End Sub

    ''' <summary>
    ''' adds btnClear.click handler to sub btnClear_Click. This is for no other reason than an easy example of how to add event handlers.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmDiceRoll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'on the off chance that I may actually use this, leaving it here
        AddHandler btnClear.Click, AddressOf btnClear_Click
        Me.MinimumSize = Me.Size
    End Sub
End Class