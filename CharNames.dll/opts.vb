Imports System.IO

Public Class opts
    ''' <summary>
    ''' public sub that selects a random name (for new characters) from the names.txt file
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function selName() As String
        Dim randInt As Integer
        Dim nameList(-1) As String
        Dim sr As New StreamReader("names.txt")
        Dim i As Integer = 0

        'reads all names until end of file into array
        Do While sr.Peek() >= 0
            ReDim Preserve nameList(nameList.Length)
            nameList(i) = sr.ReadLine()
            i += 1
        Loop
        'random integer from 0 to end of array
        Randomize()
        randInt = CInt(Int((nameList.Length - 1) * Rnd()))
        Return nameList(randInt)
    End Function

    ''' <summary>
    ''' sub that tracks spell usage
    ''' </summary>
    ''' <param name="pID"></param>
    ''' <param name="sID"></param>
    ''' <remarks></remarks>
    Public Sub chkPower(ByVal pID As Integer, ByVal sID As Integer)
        Dim path As String = System.AppDomain.CurrentDomain.BaseDirectory & pID & ".pow"
        Dim i As Integer = 0
        Dim pwrs(-1) As String

        'check to see if file exists, else create one and store into it the correct information
        If File.Exists(path) Then
            Dim sr As New StreamReader(path)
            'read whole file into pwrs array
            Do While sr.Peek() >= 0
                ReDim Preserve pwrs(pwrs.Length)
                pwrs(i) = sr.ReadLine()
                i += 1
            Loop

            'search array for spell id
            Dim fsID As Integer 'file spell id
            Dim fsLeft As Integer   'file spells left
            For j As Integer = 0 To pwrs.Length - 1
                If pwrs(i) = sID.ToString Then
                    fsID = pwrs(i)
                    fsLeft = pwrs(i + 1)
                    Console.WriteLine("FSID:" & vbTab & fsID)
                    Console.WriteLine("SLEFT: " & vbTab & fsLeft)
                End If
            Next
            'close the file
            sr.Close()
        Else
            'create the file and store:
            'player id
            'spell id
            'spells left today
            Console.WriteLine("File does not exist!")
            File.Create(path).Dispose()
            Console.WriteLine(path)
            Dim sw As New StreamWriter(path)
            sw.WriteLine(sID)
            sw.WriteLine(0)
            sw.WriteLine()
            sw.Close()
        End If
    End Sub
End Class
