'Payden Hoskins
'Spring 2025
'RCET 2265
'Array Examples
'https://github.com/PaydenHoskins/ArrayExamples.git

Option Explicit On
Option Strict On

Module Arrays

    Sub Main()
        Dim UserInput As String
        UserInput = "Again"
        Do While UserInput = "Again"
            UserInput = "No"
            'MultiDimentionalArrays()
            TestRandomness()
            Console.WriteLine("type ""Again"" to run again. ")
            UserInput = Console.ReadLine()
        Loop

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
        Dim classes() As String = {"math", "history", "art"}
        Dim SomethingElse(,) As Integer = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}}
        Dim ThreeDimensonalArray(,,) As Integer = {{{1, 2, 3}, {4, 5, 6}, {7, 8, 9}}}

        Students(0, 0) = 34
        Students(0, 1) = 67
        Students(0, 2) = 94

        Console.WriteLine(Students(0, 0))
        Console.WriteLine(Students(0, 1))
        Console.WriteLine(Students(0, 2))
    End Sub

    Function RandomNumberGenerator(Max As Integer, min As Integer) As Integer
        Dim temp As Single
        Randomize()
        temp = Rnd()
        temp *= Max - min
        temp += min - 1
        'Math.
        Return CInt(Math.Floor(temp))
    End Function

    Sub TestRandomness()
        Dim BeanCounter(20) As Integer
        For i = 1 To 10000
            BeanCounter(RandomNumberGenerator(10, 3)) += 1

        Next

        For i = LBound(BeanCounter) To UBound(BeanCounter)
            Console.WriteLine($"{CStr(i).PadLeft(4)} Hit {CStr(BeanCounter(i)).PadLeft(4)} Many times!")
        Next
        Console.WriteLine()
    End Sub

    Sub SplittingStringIntoArrays()
        Dim LotsOFruits As String = "grape,coconut,apple,pear,peach,banana,tomato "
        Dim Fruits() As String
        Fruits = Split(LotsOFruits, ",")
        For Each ThingyDoodle In Fruits
            Console.WriteLine(Trim(ThingyDoodle))
        Next
    End Sub
End Module
