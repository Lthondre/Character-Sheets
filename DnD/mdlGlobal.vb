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
End Module