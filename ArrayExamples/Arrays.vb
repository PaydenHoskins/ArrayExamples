﻿'Payden Hoskins
'Spring 2025
'RCET 2265
'Array Examples
'https://github.com/PaydenHoskins/ArrayExamples.git

Option Explicit On
Option Strict On

Module Arrays

    Sub Main()

        MultiDimentionalArrays()


    End Sub

    Sub SimpleArray()
        'arrays are cool
        Dim Fruits(5) As String
        Dim Names() As String = {"john", "Paul", "ringo", "jeff"}
        Dim Beancounts = New Integer() {12342, 343, 1234, 4567}

        Fruits(0) = "bannana"

        Fruits(3) = "grape"

        'Fruits(6) = "apple"

        'won't work.
        'For i = 0 To 10
        '    Console.WriteLine(Names(i))

        'Next

        For i = LBound(Names) To UBound(Names)
            Console.WriteLine(Names(i))
        Next


    End Sub

    Sub MultiDimentionalArrays()
        Dim Students(14, 2) As Single

        Students(0, 0) = 34
        Students(0, 1) = 67
        Students(0, 2) = 94

        Console.WriteLine(Students(0, 0))
        Console.WriteLine(Students(0, 1))
        Console.WriteLine(Students(0, 2))
    End Sub


End Module
