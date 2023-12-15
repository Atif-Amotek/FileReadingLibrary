using FileReadingLibrary.Properties;
using System;
using System.IO;
using System.Resources;

namespace FileReadingLibrary
{
    class TextFileReader: IFileReader
    {

        public void ReadFile(string textFilePath)
        {
            if (textFilePath != null)
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
}
