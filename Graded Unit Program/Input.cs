using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace Graded_Unit_Program 
{
    public class Input 
    {


        
            public void readXMLAccounts(string fileName, string element, ref string input)
            {
                //gets the current directory
                string path = Directory.GetCurrentDirectory();
                //checks if the filename is in the directory
                //@path being the directory and filename being the filename
                string[] dirs = Directory.GetFiles(@path, fileName);
                //checks if the array length is more than 0 to stop an array out of bounds exception
                if (dirs.Length > 0)
                {
                    //checks if the file actually exists, if it doesn't then the user doesn't exist
                    if (dirs[0] == path + "\\" + fileName)
                    {
                        XDocument xdoc = XDocument.Load(fileName);

                        XmlDocument doc = new XmlDocument();
                        //loads the Xml file
                        doc.Load(fileName);
                        XmlNodeList elementlist = doc.GetElementsByTagName(element);
                        //reads the contents of the xml braces
                        input = elementlist[0].InnerXml;
                        Console.WriteLine(elementlist[0].InnerXml);
                        Console.WriteLine(input);
                    }
                }
            }
        
        }       
    }

