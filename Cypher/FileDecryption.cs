using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReadingLibrary
{
    internal class FileDecryption
    {
        public string DecryptFile(string text)
        {
            if (text != null)
            {
                string decryptedText = Decrypt(text);
                Console.WriteLine("File Content:");
                Console.WriteLine(decryptedText);
                Console.WriteLine();
                return decryptedText;
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
