Imports System

Module Program
    Dim str_phrase As String = "The quick brown fox jumps over the lazy dog"
    Dim menu As Integer
    Sub Main()
        Console.WriteLine($"1. Simple Cycle {vbCrLf}2. Colour cycle {vbCrLf}3. Capital Cycle {vbCrLf}4. Exit") '$ allows use of vbCrLf

        menu = Console.ReadLine()
        Select Case menu
            Case 1
                For count1 = 0 To str_phrase.Length - 1
                    If count1 Mod 1 = 0 Then
                        Console.ForegroundColor = GetRandomColour()
                    End If
                    Console.Write(str_phrase(count1))
                Next
            Case 2
                Do
                    For count1 = 0 To str_phrase.Length - 1
                        If count1 Mod 1 = 0 Then
                            Console.ForegroundColor = GetRandomColour()
                        End If
                        Console.Write(str_phrase(count1))
                    Next
                    Threading.Thread.Sleep(10)
                    Console.Clear()
                Loop
            Case 3
                Do
                    str_phrase = "the quick brown fox jumps over the lazy dog"
                    RandomCapital()
                    Threading.Thread.Sleep(1000)
                    Console.Clear()
                Loop
            Case 4
                End
        End Select
        'John Calverley
    End Sub
    Dim colcount As Integer = 2
    Function GetRandomColour() As ConsoleColor
        Dim c As ConsoleColor
        c = colcount
        colcount += 1
        If colcount = 16 Then
            colcount = 2
        End If
        Return c
    End Function

    Dim capcount As Integer
    Function RandomCapital()
        Dim capital, noncapital As Char

        Randomize(0 - 42) ' 0 - 42, 0 = 1 first number
        capcount = Math.Truncate(Rnd() * str_phrase.Length) '43 was the length do not add + 1 to length or it will
        capital = UCase(str_phrase(Mid(capcount, 1)))

        If capital = " " Then 'Check for spaces and defaults to first letter
            capital = UCase(str_phrase.Substring(0, 1))
        End If
        noncapital = str_phrase(Mid(capcount, 1))

        If noncapital = " " Then 'Check for spaces and defaults to first letter
            noncapital = str_phrase.Substring(0, 1)
        End If

        Console.WriteLine(str_phrase.Replace(noncapital, capital)) 'Repleaces non capital with capital
        Console.WriteLine("The capital letter is currently ")

        Console.ForegroundColor = ConsoleColor.Red 'Displays current capital letter
        Console.Write(capital)
        Console.ForegroundColor = ConsoleColor.White
        Return capcount
    End Function
End Module
