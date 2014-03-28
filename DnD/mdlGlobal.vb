Module mdlGlobal
    'Public source As String = "Data Source=Database\DnD.accdb;"    'RC
    Public source As String = "Data Source=DnD.accdb;"              'Working directory
    ''' <summary>
    ''' Public string for database connection
    ''' </summary>
    ''' <remarks></remarks>
    ''' 
    Public strConnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;" & source & "Persist Security Info=False;"
    Public theTag As Integer

    ''' <summary>
    ''' an extension for finding the row of a datagrid given the armor/weapon ID
    ''' </summary>
    ''' <param name="dgv">datagrid view object</param>
    ''' <param name="key">the unique armor/weapon ID</param>
    ''' <returns>returns the row that the key was found on</returns>
    ''' <remarks></remarks>
    <System.Runtime.CompilerServices.Extension()> _
    Function FindValue(ByRef dgv As DataGridView, ByVal key As Object, ByRef item As String) As DataGridViewRow
        For Each row As DataGridViewRow In dgv.Rows
            If row.Cells.Item(item).Value = key Then
                Return row
            End If
        Next
        Return Nothing
    End Function
End Module