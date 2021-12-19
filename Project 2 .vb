Module Module1

    Sub Main()
        Dim str1, str2 As String
        Dim char1, char2, char3 As Char
        Dim x As Integer

        str1 = ""
        str2 = ""
        char1 = ""
        char2 = ""
        char3 = ""
        x = 0

        Console.WriteLine("Enter text to process ")
        str1 = Console.ReadLine
        Console.WriteLine("Enter character that is to be replaced ")
        char1 = Console.ReadLine
        Console.WriteLine("Enter character that will replace previous character ")
        char2 = Console.ReadLine
        For x = 1 To Len(str1)
            char3 = Mid(str1, x, 1)
            If char1 <> char3 Then
                str2 = str2 & char3
            Else
                str2 = str2 & char2
            End If
        Next
        Console.WriteLine("The new text is: " & str2)
        Console.ReadKey()
    End Sub

End Module
