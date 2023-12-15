using FileReadingLibrary.Properties;
using System;
using System.IO;
using System.Resources;

class Program
{
    static void Main()
    {
        string filePath = Resources.TextFile;

        if (filePath != null)
        {
            Console.WriteLine("File Content:");
            Console.WriteLine(Resources.TextFile);
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}