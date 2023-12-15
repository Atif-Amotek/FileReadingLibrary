using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReadingLibrary.FileReaders
{
    class JSONFileReader : IFileReader
    {
        public void ReadFile(string filePath)
        {
            if (filePath != null)
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
}
