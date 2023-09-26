Module CallByValue
    Function valref(ByVal x As Integer)
        Console.WriteLine("Before change X= {0}", x)
        x += 150
        Console.WriteLine("After change X= {0}", x)
        Return x
    End Function
    Sub main()
        Dim x As Integer = 500
        Console.WriteLine("Before Function Call x= {0}", x)
        valref(x)
        Console.WriteLine("After Function Call x={0}", x)
        Console.ReadKey()
    End Sub
End Module
