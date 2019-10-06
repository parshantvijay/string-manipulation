Module Module1

    Sub Main()
        Dim Str1 As String
        Dim str2 As String
        Dim mychar As String
        Dim nextchar As String
        Dim counter As Integer

        Str1 = ""
        str2 = ""
        mychar = ""
        nextchar = ""
        counter = 0

        Console.Write("Enter Text = ")
        Str1 = Console.ReadLine
        Console.Write("Enter Character To Remove From The Text = ")
        mychar = Console.ReadLine

        For counter = 1 To Len(Str1)
            nextchar = Mid(Str1, counter, 1)
            If nextchar <> mychar Then
                str2 = str2 & nextchar
            End If
        Next
        Console.WriteLine("Text After Removal of Unwanted Character = " & str2)

        Console.ReadKey()

    End Sub

End Module
