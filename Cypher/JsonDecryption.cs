using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FileReadingLibrary.Cypher
{
    internal class JsonDecryption
    {
        public string DecryptFile(string filePath)
        {
            if (filePath != null)
            {
                string fileJSON = File.ReadAllText(filePath);
                var jsonObject = JsonSerializer.Deserialize<object>(fileJSON);
                string encryptedJSON = Decrypt(jsonObject.ToString());
                return encryptedJSON;
            }
            else
            {
                Console.WriteLine("File not found.");
                return null;
            }
        }

        private static string Decrypt(string text)
        {
            char[] textArray = text.ToCharArray();
            Array.Reverse(textArray);
            return new string(textArray);
        }
    }
}
