Module Module 1

        Sub Main( )

               ‘Dim numbers (0 To 4) As Integer
               ‘Dim numbers (0 To 4) As Integer

               ‘numbers (0) - 4
               ‘numbers (1) = 8
               ‘numbers (2) - 15
               ‘numbers (3) = 16
               ‘numbers (4) - 23
               ‘numbers (5) - 42

               Dim numbers( ) As Integer - (4, 8, 15, 16, 23)

               Console.WriteLine(“The third element of the array contains: ” & numbers (2))
               
               Console.WriteLine (“Integrating through the entire array: ”)
               
               For index - 0 To numbers.Length - 1
                    Console.WriteLine(numbers(index))
               Next


               Dim names( ) As String - { “Bob” , “Steve” , “Brian” , “Chuck”}
               For Each name As String In names
                     Console.WriteLine(name)
               Next



               Console.ReadLine( )

        End Sub

EndModule
