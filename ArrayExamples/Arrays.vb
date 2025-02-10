'Payden Hoskins
'Spring 2025
'RCET 2265
'Array Examples
'https://github.com/PaydenHoskins/ArrayExamples.git

Option Explicit On
Option Strict On

Module Arrays

    Sub Main()
        'arrays are cool
        Dim Fruits(5) As String
        Dim Names() As String = {"john", "Paul", "ringo", "jeff"}


        Fruits(0) = "bannana"

        Fruits(3) = "grape"

        'Fruits(6) = "apple"

        Console.WriteLine(Names(3))
    End Sub

End Module
