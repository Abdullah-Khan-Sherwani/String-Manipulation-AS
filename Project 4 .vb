Module Module1

    Sub Main()
        Dim str1, char1, char2, char3 As String
        Dim x, y, total, topcount, length As Integer

        str1 = ""
        x = 0
        y = 0
        char1 = ""
        char2 = ""
        char3 = ""
        total = 0
        topcount = 0
        length = 0

        Console.WriteLine("Enter text to process ")
        str1 = Console.ReadLine
        length = Len(str1)
        For x = 1 To length
            char1 = Mid(str1, x, 1)
            For y = 1 To length
                char2 = Mid(str1, y, 1)
                If char1 = char2 Then
                    total = total + 1
                End If
                If topcount < total Then
                    topcount = total
                    char3 = char1
                End If
            Next
            total = 0
        Next

        Console.WriteLine("Most repeated character is: " & char3)
        Console.ReadLine()
    End Sub

End Module
