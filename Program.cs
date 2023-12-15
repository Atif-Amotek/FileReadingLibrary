using FileReadingLibrary;
using FileReadingLibrary.Cypher;
using FileReadingLibrary.Properties;
using System;
using System.IO;
using System.Resources;

class Program
{
    static void Main()
    {

        FileEncryption fileEncryptor = new();
        FileDecryption fileDecryptor = new();
        JsonEncryption jsonEncryptor = new();
        JsonDecryption jsonDecryptor = new();
        RoleBasedAccess roleBasedAccess = new();

        string encryptedTextFilePath = Resources.EncryptedTextFile;
        string encryptedTextContent = fileEncryptor.EncryptFile(encryptedTextFilePath);
        string encryptedXMLFilePath = Resources.EncryptedXMLFile;
        string encryptedXMLContent = fileEncryptor.EncryptFile(encryptedXMLFilePath);
        string encryptedJSONContent= jsonEncryptor.EncryptFile("Resources/JSONFile?json");


        Console.WriteLine("Do you need to read the Encrypted File");
        string answerEncryption = Console.ReadLine();

        Console.WriteLine("Enter the Role");
        string role = Console.ReadLine();

        if(answerEncryption == "yes")
        {
            fileDecryptor.DecryptFile(encryptedTextContent);
            fileDecryptor.DecryptFile(encryptedXMLContent);
            fileDecryptor.DecryptFile(encryptedJSONContent);
            jsonDecryptor.DecryptFile(encryptedJSONContent);

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