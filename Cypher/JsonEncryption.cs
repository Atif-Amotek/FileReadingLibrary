using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FileReadingLibrary.Cypher
{
    internal class JsonEncryption
    {
        public string? EncryptFile(string filePath)
        {
            if (filePath != null)
            {

                string fileJSON = File.ReadAllText(filePath);
                var jsonObject = JsonSerializer.Deserialize<object>(fileJSON);
                string encryptedJSON = Encrypt(jsonObject.ToString());
                return encryptedJSON;
            }
            else
            {
                Console.WriteLine("File not found.");
                return null;
            }
        }

        private static string Encrypt(string text)
        {
            char[] textArray = text.ToCharArray();
            Array.Reverse(textArray);
            return new string(textArray);
        }
    }
}
