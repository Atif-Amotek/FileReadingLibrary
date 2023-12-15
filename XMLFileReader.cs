using FileReadingLibrary.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReadingLibrary
{
    class XMLFileReader: IFileReader
    {
        public void ReadFile(string xmlFilePath)
        {
            if (xmlFilePath != null)
            {
                Console.WriteLine("XML Content:");
                Console.WriteLine(Resources.TestXML);
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
    }
}
