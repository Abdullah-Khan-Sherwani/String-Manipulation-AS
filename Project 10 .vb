Module Module1

    Sub Main()
        Dim str1, str2, str3 As String
        Dim lenth As Integer

        str1 = ""
        str2 = ""
        str3 = ""
        lenth = 0

        Console.WriteLine("Enter text to process ")
        str1 = Console.ReadLine
        lenth = Len(str1)
        If lenth < 3 Then
            str3 = str1
        Else : str2 = Right(str1, 3)
            If str2 = "ing" Then
                str3 = str1 & "ly"
            Else
                str3 = str1 & "ing"
            End If
        End If

        Console.WriteLine("Processed text is " & str3)
        Console.ReadKey()
    End Sub

End Module
