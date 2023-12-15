using FileReadingLibrary.FileReaders;
using FileReadingLibrary.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReadingLibrary
{
    public class RoleBasedAccess
    {
        private readonly string textFilePath = Resources.TextFile;
        private readonly string xmlFilePath = Resources.TestXML;
        public void RoleAccess(string role)
        {
            if (role == "Admin")
            {
                Console.WriteLine("Admin Access Granted");
                TextFileReader textFileReader = new();
                textFileReader.ReadFile(textFilePath);

                XMLFileReader xmlFileReader = new();
                xmlFileReader.ReadFile(xmlFilePath);

                JsonFileReader jsonFileReader = new();
                jsonFileReader.ReadFile(Resources.JSONFile);
            }
            else if (role == "User")
            {
                Console.WriteLine("User Access Granted");
                TextFileReader textFileReader = new();
                textFileReader.ReadFile(textFilePath);

                JsonFileReader jsonFileReader = new();
                jsonFileReader.ReadFile(Resources.JSONFile);
            }
            else
            {
                throw new ArgumentException("Invalid Role: Can't Read Files", nameof(role));
            }
        }
    }
}
