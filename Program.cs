using FileReadingLibrary;
using FileReadingLibrary.Properties;
using System;
using System.IO;
using System.Resources;

class Program
{
    static void Main()
    {
        string textFilePath = Resources.TextFile;
        string xmlFilePath = Resources.TestXML;
        string encryptedTextFilePath = Resources.EncryptedTextFile;

        TextFileReader textFileReader = new();
        textFileReader.ReadFile(textFilePath);

        XMLFileReader xmlFileReader = new();
        xmlFileReader.ReadFile(xmlFilePath);
        
        TextFileEncryption textFileEncryptor = new();
        string encryptedContent = textFileEncryptor.EncryptFile(encryptedTextFilePath);

        TextFileDecryption textFileDecryptor = new();

        Console.WriteLine("Do you need to read the Encrypted File");
        string answerEncryption = Console.ReadLine();

        if(answerEncryption == "yes")
        {
            textFileDecryptor.DecryptFile(encryptedContent);
        }
        else
        {
            Console.WriteLine("Ok, bye");
        }

    }
}