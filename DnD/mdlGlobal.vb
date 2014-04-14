Module mdlGlobal
    'Public source As String = "Data Source=Database\DnD.accdb;"    'Release Candidate
    Public source As String = "Data Source=DnD.accdb;"              'Working directory

    ''' <summary>
    ''' Public string for database connection
    ''' </summary>
    ''' <remarks></remarks>
    ''' 
    Public strConnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;" & source & "Persist Security Info=False;"

    'for some reason I couldn't seem to get these variables to be passed from parent to/from child forms
    'this is the only real workaround I could think of doing
    Public theTag As Integer    'used for selecting the correct armor tab
    Public check As Integer     'public variable holding value of check modifier
    Public ReadOnly badCol As Color = Color.Salmon       'used for datagridview in frmSelPowers
    Public ReadOnly goodCol As Color = Color.LightGreen  'used for datagridview in frmSelPowers

    ''' <summary>
    ''' an extension for finding the row of a datagrid given the armor/weapon ID
    ''' </summary>
    ''' <param name="dgv">datagrid view object</param>
    ''' <param name="key">the unique armor/weapon ID</param>
    ''' <param name="column">name of the column to look for key, in dgv</param>
    ''' <returns>returns the row that the key was found on</returns>
    ''' <remarks>modified from YWE's post: https://stackoverflow.com/questions/4228278/datagridview-programmatically-select-a-row-based-on-values-find-in-the-grid </remarks>
    <System.Runtime.CompilerServices.Extension()> _
    Function FindValue(ByRef dgv As DataGridView, ByVal key As Object, ByRef column As String) As DataGridViewRow
        For Each row As DataGridViewRow In dgv.Rows
            If row.Cells.Item(column).Value = key Then
                Return row
            End If
        Next
        Return Nothing
    End Function
End Module