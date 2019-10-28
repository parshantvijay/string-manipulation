Module Module1

    Sub Main()
        Dim STR As String
        Dim COUNT As Integer
        Dim NEXTCHAR As Char
        Dim validBinaryString As Boolean

        STR = ""
        COUNT = 0
        NEXTCHAR = ""
        validBinaryString = True

        Console.Write("enter binary number: ")
        STR = Console.ReadLine

        If Len(STR) <= 1 And Len(STR) >= 8 Then
            validBinaryString = False

            Console.Write("NOT A VALID BINARY NUMBER: ")

            If validBinaryString = True Then
                For COUNT = 1 To 8
                    NEXTCHAR = Mid(STR, COUNT, 1)
                    If NEXTCHAR = '0'  OR NEXTCHAR = '1' then 
                        validBinaryString = True
                    End If
                Next
            End If
        End If
        If validBinaryString = True Then
            Console.Write("it is a valid binary string")

        Else
            Console.WriteLine("not a valid binary number")
        End If

        Console.ReadKey()


    End Sub

End Module
