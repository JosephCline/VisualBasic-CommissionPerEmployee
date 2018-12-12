Module Module1

    Sub Main()
        Dim Countf As Decimal
        Dim Countp As Decimal
        Dim dCommissioncount As Decimal
        Dim iAmountsold As Integer
        Dim sEmployeename As String
        Dim dTotal As Decimal
        Dim dTotal2 As Decimal
        Dim iNumber As Decimal
        Dim iEmployeestatus As Integer

        Console.WriteLine("Employee        Status        Sales   Commission")
        While iAmountsold > -1

            Console.Write("Please enter the amount sold for the period: ")
            iAmountsold = Console.ReadLine
            Console.Write("Please enter if you are full time or part time, 1 for full or 2 for part: ")
            iEmployeestatus = Console.ReadLine
            Console.Write("Please enter your name: ")
            sEmployeename = Console.ReadLine
            If iAmountsold < -1 Then
                Exit While
            End If
            If sEmployeestatus = 1 Then
                dCommissionf = iAmountsold * 0.03
                Console.WriteLine("sEmployeename & "        " & sEmployeestatus & "        " & iAmountsold & "        " & dCommissionf: ")
                Countf = Countf + 1
                If dCommissionf > dCommissioncount Then
                    dCommissioncount = dCommissionf
                    sHighest = sEmployeename
                End If
                dTotal = dCommissionf + dTotal
            End If
            If sEmployeestatus = 2 Then
                dCommissionp = iAmountsold * 0.03
                Console.WriteLine(sEmployeename & "        " & sEmployeestatus & "        " & iAmountsold & "        " & dCommissionp)
                Countp = Countp + 1
                If dCommissionp > dCommissioncount Then
                    dCommissioncount = dCommissionp
                    sHighest = sEmployeename
                    dTotal2 = dCommissionp + dTotal2
                End If
            End If
        End While
        Console.WriteLine("Total number of full-time staff is " & Countf)
        Console.WriteLine("Total number of part-time staff is " & Countp)
        Console.Writeline("The total commission for fulltime is: " & FormatCurrency(dTotal))
        Console.Writeline("The total commission for part-time is: " & FormatCurrency(dTotal2))






    End Sub

End Module
