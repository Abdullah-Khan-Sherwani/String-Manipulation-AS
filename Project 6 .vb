Module Module1

    Sub Main()
        Dim donut As Integer

        donut = 0

        Console.WriteLine("How many donuts? ")
        donut = Console.ReadLine
        If donut < 10 And donut > 0 Then
            Console.WriteLine("Number of donuts: " & donut)
        ElseIf donut >= 10 Then
            Console.WriteLine("Number of donuts: Many")
        End If

        Console.ReadKey()
    End Sub

End Module
