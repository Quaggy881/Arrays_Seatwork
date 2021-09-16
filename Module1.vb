Module Module1




    Sub Main()
        Dim students(3) As String
        Dim gender(3) As String
        Dim marks1(3) As Integer
        Dim marks2(3) As Integer
        Dim x As Integer
        Dim highestmark1 As Integer = 0
        Dim highestmark2 As Integer = 0
        Dim highstudname1 As String
        Dim highstudname2 As String
        Dim lowestmark1 As Integer = 100
        Dim lowestmark2 As Integer = 100
        Dim loweststudname1 As String
        Dim lowestsudname2 As String
        Dim markstotal1 As Integer
        Dim markstotal2 As Integer
        Dim marksavg1 As Integer
        Dim marksavg2 As Integer
        Dim studmales As String = 0
        Dim studfemales As String = 0

        'Change for count and averages in case of increase in num of students

        For count = 0 To 1

            Console.WriteLine("Input the student name")
            students(count) = Console.ReadLine()

            Console.WriteLine(" ")

            Do Until gender(count) = "male" Or gender(count) = "female"

                Console.WriteLine("Input the student gender {male/female}")
                gender(count) = Console.ReadLine()

                If gender(count) = "male" Then

                    studmales += 1

                Else

                    studfemales += 1

                End If

                If gender(count) <> "male" And gender(count) <> "female" Then

                        Console.WriteLine("gender is invalid")

                        Console.WriteLine(" ")

                    End If

            Loop

            Console.WriteLine(" ")


            Do

                Console.WriteLine("Input the student Marks for test 1" & vbNewLine & "Marks should be within the range of 0 to 100")
                marks1(count) = Console.ReadLine()

                markstotal1 += marks1(count)

                If marks1(count) > highestmark1 Then

                    highestmark1 = marks1(count)
                    highstudname1 = students(count)

                End If

                If marks1(count) < lowestmark1 Then

                    lowestmark1 = marks1(count)
                    loweststudname1 = students(count)

                End If

            Loop Until marks1(count) >= 0 And marks1(count) < 101

            marksavg1 = markstotal1 / 2

            Console.WriteLine(" ")

            Do Until marks2(count) > 0 And marks2(count) < 101

                Console.WriteLine("Input the student Marks for test 2" & vbNewLine & "Marks should be within the range of 0 to 100")
                marks2(count) = Console.ReadLine()

                markstotal2 += marks1(count)

                If marks2(count) > highestmark2 Then

                    highestmark2 = marks2(count)
                    highstudname2 = students(count)

                End If

                If marks2(count) < lowestmark2 Then

                    lowestmark2 = marks2(count)
                    lowestsudname2 = students(count)

                End If

                Console.WriteLine(" ")

            Loop

            marksavg2 = markstotal2 / 2

        Next


        Console.WriteLine(" ")

            Console.WriteLine("Input the index number")
            x = Console.ReadLine()

            Console.WriteLine(" ")

        Console.WriteLine("Details :" & vbNewLine & "Index number" & " " & "{" & x & "}" & vbNewLine & "The student name :" & " " & students(x) & vbNewLine & "The student gender :" & " " & gender(x) & vbNewLine & "mark for test 1 :" & " " & marks1(x) & vbNewLine & "mark for test 2 :" & " " & marks2(x))

        Console.WriteLine(" ")

        Console.WriteLine("Press enter key, to view the students with the highest and lowest marks...")
        Console.ReadLine()

        Console.WriteLine(" ")

        Console.WriteLine("The student with the highest mark, for test 1, is " & highstudname1 & " " & "with a mark of " & highestmark1 & vbNewLine & "The student with the highest mark, for test 2, is " & highstudname2 & " " & "with a mark of " & highestmark2)

        Console.WriteLine(" ")

        Console.WriteLine("The student with the lowest mark, for test 1, is " & loweststudname1 & " " & "with a mark of " & lowestmark1 & vbNewLine & "The student with the lowest mark, for test 2, is " & lowestsudname2 & " " & "with a mark of " & lowestmark2)

        Console.WriteLine(" ")

        Console.WriteLine("Press enter key, to view test averages...")
        Console.ReadLine()

        Console.WriteLine(" ")

        Console.WriteLine("The average for test 1 is " & marksavg1 & vbNewLine & "The average for test 2 is " & marksavg2)

        Console.WriteLine(" ")

        Console.WriteLine("Press enter key, to view the number of male & female students... ")
        Console.ReadLine()

        Console.WriteLine("The number of male students is " & studmales & vbNewLine & "The number of female students is " & studfemales)
        Console.ReadLine()


    End Sub

    End Module



