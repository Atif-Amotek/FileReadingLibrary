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
                Console.WriteLine("Text File Content:");
                Console.WriteLine(textFilePath);
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
    }
}
