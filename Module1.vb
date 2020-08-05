Module Module1

    Sub Main()

        Dim name As String = " "

        Dim original, reverse As String

        Dim EndOfWord As Integer

        Console.Write("Give me a word to reverse: ")

        original = Console.ReadLine

        EndOfWord = original.Length() - 1

        reverse = ""

        For Counter As Integer = EndOfWord To 0 Step -1

            reverse = reverse & original(Counter)

        Next

        Console.WriteLine("Your reverse word is: " & reverse)

        Console.Read()

    End Sub

End Module
