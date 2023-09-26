Imports System.String
Module Strings
    Sub main()
        Dim str1, str2 As String
        Console.WriteLine("Enter 1st String")
        str1 = Console.ReadLine()
        Console.WriteLine("Enter 2nd String")
        str2 = Console.ReadLine()
        Console.WriteLine("Comparison Result={0}", String.Compare(str1, str2))
        Console.WriteLine("Equality Result={0}", String.Equals(str1, str2))
        Console.WriteLine("Insertion Result of 'Java' into first position in first string={0}", str1.Insert(0, "Java"))
        Console.WriteLine("Concatenation Result={0}", String.Concat(str1, str2))
        Console.WriteLine("First String Contains 'hello'={0}", str1.Contains("hello"))
        Dim str3 As String = String.Copy(str1)
        Console.WriteLine("3rd String(copy of 1st)={0}", str3)
        Console.WriteLine("First String ends with 'hello'={0}", str1.EndsWith("hello"))
        Console.WriteLine("Occurrence of character t  in 1st String in index position {0}", str1.IndexOf("t"))
        Console.ReadKey()
    End Sub
End Module
