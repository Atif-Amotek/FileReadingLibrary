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
        public void DecryptFile(string text)
        {
            if (text != null)
            {
                string fileJSON = text;
                string decryptedJSON = Decrypt(fileJSON);
                Console.WriteLine(decryptedJSON);
            }
            else
            {
                Console.WriteLine("File not found.");
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
