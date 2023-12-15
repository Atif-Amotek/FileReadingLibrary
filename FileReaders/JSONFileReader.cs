using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FileReadingLibrary.FileReaders
{
    class JsonFileReader
    {
        public void ReadFile(byte[] filePath)
        {
            string fileJSON = Encoding.UTF8.GetString(filePath);
            var jsonObject = JsonSerializer.Deserialize<object>(fileJSON);
            Console.WriteLine("JSON Content:");
            Console.WriteLine(jsonObject.ToString());
        }
    }
}
