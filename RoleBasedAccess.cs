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
                TextFileReader textFileReader = new();
                textFileReader.ReadFile(textFilePath);

                XMLFileReader xmlFileReader = new();
                xmlFileReader.ReadFile(xmlFilePath);
            }
            else if (role == "User")
            {
                TextFileReader textFileReader = new();
                textFileReader.ReadFile(textFilePath);
            }
        }
    }
}
