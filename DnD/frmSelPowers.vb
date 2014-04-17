Public Class frmSelPowers
    Dim pow(-1) As powers
    Public lev As Integer
    Public pcls As String
    Public pid As Integer

    ''' <summary>
    ''' structure for holding information of powers available to character
    ''' </summary>
    ''' <remarks></remarks>
    Structure powers
        Public id As Long
        Public spClass As String
        Public sName As String
        Public sDesc As String
        Public sLev As String
        Public sType As String
        Public sCaste As String
        Public sC1 As String
        Public sC2 As String
        Public sC3 As String
        Public sRange As String
        Public sRMod As String
        Public sPTar As String
        Public sSTar As String
        Public sPAttack As String
        Public sSAttack As String
        Public sPHit As String
        Public sSHit As String
        Public sPHit21 As String
        Public sSHit21 As String
        Public sMiss As String
    End Structure

    ''' <summary>
    ''' load power table limited by player class and level
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmSelPowers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'reflect form title for player class
        Dim power As String
        Select Case pcls
            Case "fighter", "ranger", "rogue", "warlord"
                power = "Exploits"
            Case "cleric", "paladin"
                power = "Prayers"
            Case "warlock", "wizard"
                power = "Spells"
            Case Else
                power = "Powers"
        End Select
        Me.Text = power & " [" & pcls & "]"

        'declare instance of class
        Dim Cantrips As New clsData
        Dim Encounters As New clsData
        Dim Dailies As New clsData
        'pass connection string from global module
        Cantrips.ConnectionString = mdlGlobal.strConnection
        Encounters.ConnectionString = mdlGlobal.strConnection
        Dailies.ConnectionString = mdlGlobal.strConnection
        'since using three separate objects, hardcode the sCaste value into the WHERE clause
        Cantrips.SQL = "SELECT * FROM tblPowers WHERE sLev<=" & lev & " AND sPClass='" & pcls & "' AND sCaste='cantrip' ORDER BY sLev"
        Encounters.SQL = "SELECT * FROM tblPowers WHERE sLev<=" & lev & " AND sPClass='" & pcls & "' AND sCaste='encounter' ORDER BY sLev"
        Dailies.SQL = "SELECT * FROM tblPowers WHERE sLev<=" & lev & " AND sPClass='" & pcls & "' AND sCaste='daily' ORDER BY sLev"
        'clear out array of powers
        ReDim pow(-1)
        'clear out datagridview
        dgvCantrips.Rows.Clear()
        dgvEncounters.Rows.Clear()
        dgvDailies.Rows.Clear()

        'setup datagrid for user
        dgvCantrips.DataSource = Cantrips.ds.Tables(0)
        dgvEncounters.DataSource = Encounters.ds.Tables(0)
        dgvDailies.DataSource = Dailies.ds.Tables(0)
        Call setupDGV(dgvCantrips, lev)
        Call setupDGV(dgvEncounters, lev)
        Call setupDGV(dgvDailies, lev)

        'determine which dailies have been used already
        Dim powChk As New CharOptions.opts
        Dim i As Integer = 0
        'only check if there IS a player ID
        If pid > 0 Then
            For Each row As DataGridViewRow In dgvDailies.Rows
                Dim used As Boolean = powChk.chkPower(pid, dgvDailies.Rows(i).Cells("sID").Value)
                Console.WriteLine("Used: " & used)
                If used Then
                    dgvDailies.Rows(i).DataGridView.RowsDefaultCellStyle.BackColor = mdlGlobal.badCol
                Else
                    dgvDailies.Rows(i).DataGridView.RowsDefaultCellStyle.BackColor = mdlGlobal.goodCol
                End If
                i += 1
            Next
        End If
    End Sub

    ''' <summary>
    ''' one sub to set up all three datagridviews
    ''' </summary>
    ''' <param name="dgv"></param>
    ''' <remarks></remarks>
    Private Sub setupDGV(ByRef dgv As DataGridView, ByRef lev As Integer)
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        'set sorting column
        dgv.Sort(dgv.Columns("sID"), System.ComponentModel.ListSortDirection.Ascending)
        With dgv.Columns
            'long text columns should use word wrapping mode
            .Item("sDesc").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Item("sDesc").DefaultCellStyle.WrapMode = DataGridViewTriState.True
            .Item("sPHit").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Item("sPHit").DefaultCellStyle.WrapMode = DataGridViewTriState.True
            .Item("sSHit").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Item("sSHit").DefaultCellStyle.WrapMode = DataGridViewTriState.True
            .Item("sPHit21").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Item("sPHit21").DefaultCellStyle.WrapMode = DataGridViewTriState.True
            .Item("sSHit21").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Item("sSHit21").DefaultCellStyle.WrapMode = DataGridViewTriState.True
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

            'user does not need to see this
            .Item("sID").Visible = False
            .Item("sPClass").Visible = False
            .Item("sCaste").Visible = False

            'if all cells in a column are "-", then do not show that column
            Dim c3 As Integer = 0
            Dim reqs As Integer = 0
            Dim sSTar As Integer = 0
            Dim spec As Integer = 0
            Dim satk As Integer = 0
            Dim sHit As Integer = 0
            Dim pHit21 As Integer = 0
            Dim sHit21 As Integer = 0
            Dim miss As Integer = 0
            For i As Integer = 0 To dgv.RowCount - 1
                If dgv.Rows(i).Cells("sC3").Value = "-" Then c3 += 1
                If dgv.Rows(i).Cells("sReqs").Value = "-" Then reqs += 1
                If dgv.Rows(i).Cells("sSTar").Value = "-" Then sSTar += 1
                If dgv.Rows(i).Cells("sSpecial").Value = "-" Then spec += 1
                If dgv.Rows(i).Cells("sSAttack").Value = "-" Then satk += 1
                If dgv.Rows(i).Cells("sSHit").Value = "-" Then sHit += 1
                If dgv.Rows(i).Cells("sPHit21").Value = "-" Then pHit21 += 1
                If dgv.Rows(i).Cells("sSHit21").Value = "-" Then sHit21 += 1
                If dgv.Rows(i).Cells("sMiss").Value = "-" Then miss += 1
            Next
            'if there's only -'s in a whole column, then do not show that column.
            .Item("sC3").Visible = IIf(c3 = dgv.RowCount, False, True)
            .Item("sReqs").Visible = IIf(reqs = dgv.RowCount, False, True)
            .Item("sSTar").Visible = IIf(sSTar = dgv.RowCount, False, True)
            .Item("sSpecial").Visible = IIf(spec = dgv.RowCount, False, True)
            .Item("sSAttack").Visible = IIf(satk = dgv.RowCount, False, True)
            .Item("sSHit").Visible = IIf(sHit = dgv.RowCount, False, True)
            .Item("sPHit21").Visible = IIf(pHit21 = dgv.RowCount, False, True)
            .Item("sSHit21").Visible = IIf(sHit21 = dgv.RowCount, False, True)
            .Item("sMiss").Visible = IIf(miss = dgv.RowCount, False, True)

            'set names
            .Item("sName").HeaderText = "Spell Name"
            .Item("sDesc").HeaderText = "Description"
            .Item("sLev").HeaderText = "Req. Level"
            .Item("sType").HeaderText = "Type"
            .Item("sC1").HeaderText = "Class 1"
            .Item("sC2").HeaderText = "Class 2"
            .Item("sC3").HeaderText = "Class 3"
            .Item("sRange").HeaderText = "Range"
            .Item("sRMod").HeaderText = "Range Mod"
            .Item("sReqs").HeaderText = "Requirements"
            .Item("sPTar").HeaderText = "Primary Target / Trigger"
            .Item("sSTar").HeaderText = "Secondary Target / Trigger"
            .Item("sSpecial").HeaderText = "Special"
            .Item("sPAttack").HeaderText = "Primary Attack Dmg"
            .Item("sSAttack").HeaderText = "Secondary Attack Dmg"
            .Item("sPHit").HeaderText = "Primary Hit / Effect"
            .Item("sSHit").HeaderText = "Secondary Hit / Effect"
            .Item("sPHit21").HeaderText = "Level21, increase to: prim. hit / Effect"
            .Item("sSHit21").HeaderText = "Level21, increase to: sec. hit / Effect"
            .Item("sMiss").HeaderText = "On Miss"
        End With
    End Sub

    ''' <summary>
    ''' closes the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' use the daily on double click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dgvDailies_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDailies.CellDoubleClick
        'only append if it hasn't already been used today
        If sender.rows(e.RowIndex).DataGridView.RowsDefaultCellStyle.BackColor <> mdlGlobal.badCol Then
            Dim powerID As Integer = sender.item(0, e.RowIndex).value.ToString
            Console.WriteLine("Power ID: " & vbTab & powerID)
            Dim opts As New CharOptions.opts
            opts.setPowers(pid, powerID)
            sender.rows(e.RowIndex).DataGridView.RowsDefaultCellStyle.BackColor = mdlGlobal.badCol
        Else
            'throw a message to the user concerning the spell's unavailability
            MessageBox.Show("Spell '" & sender.item(2, e.RowIndex).value.ToString & "' already used today.", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ''' <summary>
    ''' resets the used powers for the user
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'call the file delete function from opts class
        Console.WriteLine("Reset")
        Dim del As New CharOptions.opts
        del.resetPowers(pid)

        'reset colors for the user
        For i As Integer = 0 To dgvDailies.RowCount - 1
            dgvDailies.Rows(i).DataGridView.RowsDefaultCellStyle.BackColor = mdlGlobal.goodCol
        Next
    End Sub
End Class