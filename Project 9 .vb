Module Module1

    Sub Main()
        Dim str1, str2, str3, STR4, STR5, str6, str7, str8, str9 As String
        Dim lenth1, lenth2 As Integer

        str1 = ""
        str2 = ""
        str3 = ""
        STR4 = ""
        STR5 = ""
        str6 = ""
        str7 = ""
        str8 = ""
        str9 = ""
        lenth1 = 0
        lenth2 = 0

        Console.WriteLine("Enter first word ")
        str1 = Console.ReadLine
        Console.WriteLine("Enter second word ")
        str2 = Console.ReadLine
        lenth1 = Len(str1)
        lenth2 = Len(str2)
        str3 = str1 & " " & str2
        STR4 = Left(str1, 2)
        STR5 = Left(str2, 2)
        str6 = Mid(str1, 3, lenth1 - 2)
        str7 = Mid(str2, 3, lenth2 - 2)
        str8 = STR5 & str6
        str9 = STR4 & str7


        Console.WriteLine("Procesed text is " & str8 & " " & str9)
        Console.ReadKey()
    End Sub

End Module
