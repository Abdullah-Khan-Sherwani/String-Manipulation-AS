Module Module1

    Sub Main()
        Dim str1, str2, char1, char2 As String
        Dim x As Integer

        str1 = ""
        char1 = ""
        char2 = ""
        str2 = ""

        Console.WriteLine("Enter text to process ")
        str1 = Console.ReadLine
        char1 = Left(str1, 1)
        For x = 2 To Len(str1)
            char2 = Mid(str1, x, 1)
            If char2 = char1 Then
                str2 = str2 & "*"
            ElseIf char1 <> char2 Then
                str2 = str2 & char2
            End If
        Next

        Console.WriteLine("Processed text is " & char1 & str2)

        Console.ReadKey()
    End Sub

End Module
