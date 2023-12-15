using FileReadingLibrary;
using FileReadingLibrary.Properties;
using System;
using System.IO;
using System.Resources;

class Program
{
    static void Main()
    {

        TextFileEncryption textFileEncryptor = new();
        TextFileDecryption textFileDecryptor = new();
        RoleBasedAccess roleBasedAccess = new();

        string encryptedTextFilePath = Resources.EncryptedTextFile;
        string encryptedTextContent = textFileEncryptor.EncryptFile(encryptedTextFilePath);
        string encryptedXMLFilePath = Resources.EncryptedXMLFile;
        string encryptedXMLContent = textFileEncryptor.EncryptFile(encryptedXMLFilePath);


        Console.WriteLine("Do you need to read the Encrypted File");
        string answerEncryption = Console.ReadLine();

        Console.WriteLine("Enter the Role");
        string role = Console.ReadLine();

        if(answerEncryption == "yes")
        {
            textFileDecryptor.DecryptFile(encryptedTextContent);
            textFileDecryptor.DecryptFile(encryptedXMLContent);

            if(role != null)
            {
                roleBasedAccess.RoleAccess(role);
            }
            else
            {
                throw new ArgumentNullException(nameof(role), "Input cannot be null.");
            }
        }
        else
        {
            if (role != null)
            {
                roleBasedAccess.RoleAccess(role);
            }
            else
            {
                throw new ArgumentNullException(nameof(role), "Input cannot be null.");
            }
        }

    }
}