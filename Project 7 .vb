Module Module1

    Sub Main()
        Dim str1, char1, char2 As String

        str1 = ""
        char1 = ""
        char2 = ""

        Console.WriteLine("Enter text to process")
        str1 = Console.ReadLine()
        If Len(str1) >= 2 Then
            char1 = Left(str1, 2)
            char2 = Right(str1, 2)
            Console.WriteLine("Processed text is " & char1 & char2)
        ElseIf Len(str1) < 2 Then
            Console.WriteLine("Processed text is " & str1)
        End If

        Console.ReadKey()
    End Sub

End Module
