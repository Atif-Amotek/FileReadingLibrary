using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FileReadingLibrary.FileReaders
{
    class JSONFileReader
    {
        public void ReadFile(string filePath)
        {
            string fileJSON = File.ReadAllText(filePath);
            var jsonObject = JsonSerializer.Deserialize<object>(fileJSON);
            Console.WriteLine("JSON Content:");
            Console.WriteLine(jsonObject);
        }
    }
}
