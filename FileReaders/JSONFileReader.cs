using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReadingLibrary.FileReaders
{
    internal class JSONFileReader : IFileReader
    {
        void IFileReader.ReadFile(string filePath)
        {
            if(filePath != null)
            {
                Console.WriteLine("File Content:");
                Console.WriteLine(filePath);
            }
            else
            {
                Console.WriteLine("File not found.");
        }
    }
}
