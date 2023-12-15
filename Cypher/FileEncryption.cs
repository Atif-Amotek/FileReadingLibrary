using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReadingLibrary
{
    internal class FileEncryption
    {
        public string? EncryptFile(string filePath)
        {
            if (filePath != null)
            {
                string encryptedFile = Encrypt(filePath);
                return encryptedFile;
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
