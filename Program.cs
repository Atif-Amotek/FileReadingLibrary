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

        TextFileReader textFileReader = new TextFileReader();
        textFileReader.ReadFile(textFilePath);

        XMLFileReader xmlFileReader = new XMLFileReader();
        xmlFileReader.ReadFile(xmlFilePath);

        TextFileEncryptor textFileEncryptor = new TextFileEncryptor();
        string encrypted = textFileEncryptor.EncryptFile(encryptedTextFilePath);
        Console.WriteLine(encryptedTextFilePath);

        Console.WriteLine("Do you need to read the Encrypted File");
        string answerEncryption = Console.ReadLine();

        if(answerEncryption == "yes")
        {

        }
        else
        {
            Console.WriteLine("Ok, bye");
        }

    }
}