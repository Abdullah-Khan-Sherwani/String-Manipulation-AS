Module Module1

    Sub Main()
        Dim STR, alphabet As String
        Dim pangram As Boolean
        Dim x As Integer
        Dim CHAR1 As Char

        STR = ""
        alphabet = "abcdefghijklmnopqrstuvwxyz"
        pangram = True
        x = 0
        CHAR1 = ""

        Console.Write("enter text ")
        STR = Console.ReadLine

        STR = LCase(STR)

        For x = 1 To Len(alphabet)
            CHAR1 = Mid(alphabet, x, 1)
            If InStr(STR, CHAR1) = 0 Then pangram = False
            If pangram = False Then Exit For

        Next x
        If pangram = True Then
            Console.WriteLine("entered text contains all alphabets")
        Else
            Console.WriteLine("entered text does not contain all alphabets")

        End If
        Console.ReadKey()


    End Sub

End Module
