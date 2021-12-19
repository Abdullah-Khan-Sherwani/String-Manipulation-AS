Module Module1

    Sub Main()
        Dim STR As String
        Dim char1 As Char
        Dim acount, ecount, icount, ocount, ucount, x As Integer

        STR = ""
        char1 = ""
        acount = 0
        ecount = 0
        icount = 0
        ocount = 0
        ucount = 0
        x = 0

        Console.WriteLine("Enter text to process ")
        STR = Console.ReadLine
        For x = 1 To Len(STR)
            char1 = Mid(STR, x, 1)
            char1 = LCase(char1)
            If char1 = "a" Then
                acount = acount + 1
            ElseIf char1 = "e" Then
                ecount = ecount + 1
            ElseIf char1 = "i" Then
                icount = icount + 1
            ElseIf char1 = "o" Then
                ocount = ocount + 1
            ElseIf char1 = "u" Then
                ucount = ucount + 1
            End If
        Next
        Console.WriteLine("Number of 'a' in text is " & acount)
        Console.WriteLine("Number of 'e' in text is " & ecount)
        Console.WriteLine("Number of 'i' in text is " & icount)
        Console.WriteLine("Number of 'o' in text is " & ocount)
        Console.WriteLine("Number of 'u' in text is " & ucount)

        Console.ReadKey()
    End Sub

End Module
