Module Module1
    Sub Main()
        Dim CHAR1 As Char
        Dim STR As String
        Dim digitcount, lettercount, symbolcount, X As Integer

        CHAR1 = ""
        STR = ""
        X = 0
        digitcount = 0
        lettercount = 0
        symbolcount = 0

        Console.WriteLine("Enter text to process ")
        STR = Console.ReadLine
        For X = 1 To Len(STR)
            CHAR1 = Mid(STR, X, 1)
            CHAR1 = UCase(CHAR1)
            If CHAR1 >= "0" And CHAR1 <= "9" Then
                digitcount = digitcount + 1
            ElseIf CHAR1 >= "A" And CHAR1 <= "Z" Then
                lettercount = lettercount + 1
            Else : symbolcount = symbolcount + 1
            End If
        Next
        Console.WriteLine("Number of alphabets are " & lettercount)
        Console.WriteLine("Number of digits are: " & digitcount)
        Console.WriteLine("Number of other characters are: " & symbolcount)
        Console.ReadKey()
    End Sub

End Module
