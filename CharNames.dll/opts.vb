Imports System.IO
Public Class opts
    ''' <summary>
    ''' public sub that selects a random name (for new characters) from the names.txt file
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function selName() As String
        Dim nameList() As String = IO.File.ReadAllLines("names.txt")
        'random integer from 0 to end of array
        Randomize()
        Dim randInt As Integer = CInt(Int((nameList.Length - 1) * Rnd()))
        Return nameList(randInt)
    End Function

    ''' <summary>
    ''' sub that tracks spell usage
    ''' </summary>
    ''' <param name="pID"></param>
    ''' <param name="sID"></param>
    ''' <remarks></remarks>
    Public Function chkPower(ByVal pID As Integer, Optional ByVal sID As Integer = 0) As Boolean
        Dim path As String = System.AppDomain.CurrentDomain.BaseDirectory & "Powers\" & pID & ".pow"
        'check to see if file exists, else create one and store into it the correct information
        If File.Exists(path) Then
            'read whole file into pwrs array
            Dim pwrs() As String = IO.File.ReadAllLines(path)
            Console.WriteLine("Powers' cache exists for this character!")
            'search array for spell id
            Dim fsID As Integer 'file spell id
            For j As Integer = 0 To pwrs.Length - 1 Step 2
                If pwrs(j) = sID Then
                    fsID = pwrs(j)
                    Return True
                End If
            Next
            Return False
        Else
            If Not File.Exists(path) Then
                'create directory if not exists
                If (Not System.IO.Directory.Exists(System.AppDomain.CurrentDomain.BaseDirectory & "Powers\")) Then
                    Console.WriteLine("Creating 'Powers\' subdirectory")
                    System.IO.Directory.CreateDirectory(System.AppDomain.CurrentDomain.BaseDirectory & "Powers\")
                    'give any tinkerers a warning
                    Dim readme As New StreamWriter(System.AppDomain.CurrentDomain.BaseDirectory & "Powers\" & "Readme.txt")
                    readme.WriteLine("Do not modify any files in this folder. They are sensitive to change and could mess up the whole program!")
                    readme.Close()
                End If
                'create the file and store spell id
                Console.WriteLine("Powers file does not exist! Creating at: " & path)
                File.Create(path).Dispose()
            End If
            Return False
        End If
    End Function

    ''' <summary>
    ''' append spell to powers file, create if not exist
    ''' </summary>
    ''' <param name="pid"></param>
    ''' <param name="sid"></param>
    ''' <remarks></remarks>
    Public Sub setPowers(ByVal pid As Integer, ByVal sid As Integer)
        Dim path As String = System.AppDomain.CurrentDomain.BaseDirectory & "Powers\" & pid & ".pow"
        If Not File.Exists(path) Then
            'create directory if not exists
            If (Not System.IO.Directory.Exists(System.AppDomain.CurrentDomain.BaseDirectory & "Powers\")) Then
                Console.WriteLine("Creating 'Powers\' subdirectory")
                System.IO.Directory.CreateDirectory(System.AppDomain.CurrentDomain.BaseDirectory & "Powers\")
            End If
            'create the file and store:
            '   spell id
            Console.WriteLine("Powers file does not exist! Creating at: " & path)
            File.Create(path).Dispose()
            Dim sw As New StreamWriter(path)
            sw.WriteLine(sid)
            sw.Close()
        Else
            Dim sa As New StreamWriter(path, True)  '"true" appends to file
            'create the file and store spell id
            Console.WriteLine("Appending power #" & sid & " to: " & path)
            sa.WriteLine(sid)
            sa.Close()
        End If
    End Sub

    ''' <summary>
    ''' resets the [pid].pow file per user
    ''' </summary>
    ''' <param name="pid"></param>
    ''' <remarks></remarks>
    Public Sub resetPowers(ByVal pid As Integer)
        Dim path As String = System.AppDomain.CurrentDomain.BaseDirectory & "Powers\" & pid & ".pow"
        If Not File.Exists(path) Then
            'create directory if not exists
            If (Not System.IO.Directory.Exists(System.AppDomain.CurrentDomain.BaseDirectory & "Powers\")) Then
                Console.WriteLine("Creating 'Powers\' subdirectory")
                System.IO.Directory.CreateDirectory(System.AppDomain.CurrentDomain.BaseDirectory & "Powers\")
            End If
            'create the file and store spell id
            Console.WriteLine("Powers file does not exist! Creating at: " & path)
            File.Create(path).Dispose()
        Else
            Console.WriteLine("Deleting file: " & path)
            'if file exists, delete it. it can be created next time powers are loaded
            File.Delete(path)
        End If
    End Sub
End Class
