Public Class frmDiceRoll
    Event clearForm As EventHandler 'still being used

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

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        'clear out text
        rtxtOutCome.Clear()
        Dim sum As Integer = 0
        Dim total As Integer = 0

        'checks to see if each checkbox is clicked
        'if it is, add the roll one at a time in the format of XdY  (1-Y)
        If chkD4.Checked Then
            sum = 0
            For i As Integer = 1 To numXd4.Value
                Randomize() 'generate new random seed
                Dim r As Integer = CInt(Int((4 * Rnd()) + 1))
                rtxtOutCome.Text += i & "d4  " & vbTab & vbTab & r & vbCrLf
                sum += r
                total += r
            Next
            rtxtOutCome.Text += "Subtotal: " & sum & vbCrLf
            rtxtOutCome.Text += vbCrLf
        End If

        If chkD6.Checked Then
            sum = 0
            For i As Integer = 1 To numXd6.Value
                Randomize()
                Dim r As Integer = CInt(Int((4 * Rnd()) + 1))
                rtxtOutCome.Text += i & "d6  " & vbTab & vbTab & r & vbCrLf
                sum += r
                total += r
            Next
            rtxtOutCome.Text += "Subtotal: " & sum & vbCrLf
            rtxtOutCome.Text += vbCrLf
        End If

        If chkD8.Checked Then
            sum = 0
            For i As Integer = 1 To numXd8.Value
                Randomize()
                Dim r As Integer = CInt(Int((4 * Rnd()) + 1))
                rtxtOutCome.Text += i & "d8  " & vbTab & vbTab & r & vbCrLf
                sum += r
                total += r
            Next
            rtxtOutCome.Text += "Subtotal: " & sum & vbCrLf
            rtxtOutCome.Text += vbCrLf
        End If

        If chkD10.Checked Then
            sum = 0
            For i As Integer = 1 To numXd10.Value
                Randomize()
                Dim r As Integer = CInt(Int((4 * Rnd()) + 1))
                rtxtOutCome.Text += i & "d10  " & vbTab & vbTab & r & vbCrLf
                sum += r
                total += r
            Next
            rtxtOutCome.Text += "Subtotal: " & sum & vbCrLf
            rtxtOutCome.Text += vbCrLf
        End If

        If chkD12.Checked Then
            sum = 0
            For i As Integer = 1 To numXd12.Value
                Randomize()
                Dim r As Integer = CInt(Int((4 * Rnd()) + 1))
                rtxtOutCome.Text += i & "d12  " & vbTab & vbTab & r & vbCrLf
                sum += r
                total += r
            Next
            rtxtOutCome.Text += "Subtotal: " & sum & vbCrLf
            rtxtOutCome.Text += vbCrLf
        End If

        If chkD20.Checked Then
            sum = 0
            For i As Integer = 1 To numXd20.Value
                Randomize()
                Dim r As Integer = CInt(Int((4 * Rnd()) + 1))
                rtxtOutCome.Text += i & "d20  " & vbTab & vbTab & r & vbCrLf
                sum += r
                total += r
            Next
            rtxtOutCome.Text += "Subtotal: " & sum & vbCrLf
            rtxtOutCome.Text += vbCrLf
        End If
        rtxtOutCome.Text += "Grand total: " & vbTab & total
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'close form
        Me.Dispose()
    End Sub

    Private Sub frmDiceRoll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'on the off chance that I may actually use this, leaving it here
        AddHandler btnClear.Click, AddressOf btnClear_Click
    End Sub
End Class