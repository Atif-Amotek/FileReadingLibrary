using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReadingLibrary
{
    internal class TextFileEncryptor
    {
        public void EncryptFile(string textFilePath)
        {
            if (textFilePath != null)
            {
                string encryptedText = Encrypt(textFilePath);
                Console.WriteLine("File Content:");
                Console.WriteLine(encryptedText);
            }
            else
            {
                Console.WriteLine("File not found.");
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
