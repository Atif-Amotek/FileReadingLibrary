using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReadingLibrary
{
    internal class FileDecryption
    {
        public void DecryptFile(string text)
        {
            if (text != null)
            {
                string decryptedText = Decrypt(text);
                Console.WriteLine(decryptedText);
                Console.WriteLine();
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
