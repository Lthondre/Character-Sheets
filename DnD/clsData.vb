Imports System.Data.OleDb

''' <summary>
''' This class connects to the database and gathers info based on connection strings and SQL statements passed to it
''' </summary>
''' <remarks></remarks>
Public Class clsData

    ''' <summary>
    ''' Connection to database
    ''' </summary>
    ''' <remarks></remarks>
    Dim conn As New OleDbConnection

    ''' <summary>
    ''' String to store SQL statement
    ''' </summary>
    ''' <remarks></remarks>
    Dim strSQL As String

    ''' <summary>
    ''' Data adapter (converts from database to vb code)
    ''' </summary>
    ''' <remarks></remarks>
    Public da As OleDbDataAdapter

    ''' <summary>
    ''' Data set (snapshot of database or query)
    ''' </summary>
    ''' <remarks></remarks>
    Public ds As New DataSet

    ''' <summary>
    ''' Allows update of records for dataset
    ''' </summary>
    ''' <remarks></remarks>
    Dim cb As OleDbCommandBuilder

    ''' <summary>
    ''' Property to set/view connection string
    ''' </summary>
    ''' <value>String pass from calling procedure</value>
    ''' <returns>Connection string as string</returns>
    ''' <remarks></remarks>
    Public Property ConnectionString As String
        Get
            Return conn.ConnectionString.ToString
        End Get
        Set(ByVal value As String)
            conn.ConnectionString = value
        End Set
    End Property

    ''' <summary>
    ''' Property to set/view SQL command
    ''' </summary>
    ''' <value>SQL as string</value>
    ''' <returns>SQL statement as string</returns>
    ''' <remarks></remarks>
    Public Property SQL As String
        Get
            Return strSQL
        End Get
        Set(ByVal value As String)
            strSQL = value
            Call SetDataAdapter()
        End Set
    End Property

    ''' <summary>
    ''' If connection and SQL are established, fill dataset after connecting to database
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetDataAdapter()
        If strSQL <> "" And conn.ConnectionString <> "" Then
            da = New OleDbDataAdapter(strSQL, conn)
            ds = New DataSet
            da.Fill(ds)
            cb = New OleDb.OleDbCommandBuilder(da)
        End If
    End Sub
End Class
