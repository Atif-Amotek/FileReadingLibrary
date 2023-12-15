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
        string encryptedJSONContent= jsonEncryptor.EncryptFile(Resources.EncryptedJSONFile);


        Console.WriteLine("Do you need to read the Encrypted Files");
        string answerEncryption = Console.ReadLine();

        Console.WriteLine("Enter the Role");
        string role = Console.ReadLine();

        if(answerEncryption == "yes")
        {
            Console.WriteLine("These are the Encrypted Files");
            Console.WriteLine();
            Console.WriteLine("This is a Text");
            fileDecryptor.DecryptFile(encryptedTextContent);
            Console.WriteLine("This is a XML");
            fileDecryptor.DecryptFile(encryptedXMLContent);
            Console.WriteLine("This is a JSON");   
            jsonDecryptor.DecryptFile(encryptedJSONContent);
            Console.WriteLine();

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