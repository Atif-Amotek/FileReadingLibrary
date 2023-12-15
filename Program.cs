using FileReadingLibrary.Properties;
using System;
using System.IO;
using System.Resources;

class Program
{
    static void Main()
    {
        string textFilePath = Resources.TextFile;
        string xmlFilePath = Resources.TestXML;

        if (textFilePath != null && xmlFilePath != null)
        {
            Console.WriteLine("File Content:");
            Console.WriteLine(Resources.TextFile);

            Console.WriteLine("XML Content:");
            Console.WriteLine(Resources.TestXML);
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}