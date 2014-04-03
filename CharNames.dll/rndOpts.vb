Imports System.IO

Public Class rndOpts
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
End Class
