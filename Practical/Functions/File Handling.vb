Imports System.IO
Module File_Handling
    Sub Main()
        Dim FS As FileStream = New FileStream("myFile.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)
        Dim c As Integer

        For c = 0 To 21
            FS.WriteByte(CByte(c))
        Next c
        FS.Position = 0
        Console.WriteLine("Bytes are:")
        For c = 0 To 21
            Console.WriteLine("{0} ", FS.ReadByte())
        Next c
        FS.Close()
        Console.WriteLine(" Press any key to exit...")
        Console.ReadKey()
    End Sub
End Module
