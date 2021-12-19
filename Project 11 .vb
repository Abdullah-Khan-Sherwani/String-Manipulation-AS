Module Module1

    Sub Main()
        Dim str1, str2, str3, str5, STR4 As String
        Dim locnot, locbad, len1 As Integer

        str1 = ""
        str2 = ""
        str3 = ""
        STR4 = ""
        str5 = ""
        locnot = 0
        locbad = 0
        len1 = 0

        Console.WriteLine("Enter text to process ")
        str1 = Console.ReadLine
        len1 = Len(str1)
        locnot = InStr(str1, "not")
        locbad = InStr(str1, "bad")
        If locnot >= locbad Or locbad = 0 Or locnot = 0 Then
            STR4 = str1
        ElseIf locnot < locbad Then
            str2 = Left(str1, locnot - 1)
            str3 = Right(str1, len1 - locbad - 2)
            STR4 = str2 & "good" & str3
        End If

        Console.WriteLine("Processed text is: " & STR4)
        Console.ReadKey()
    End Sub

End Module
