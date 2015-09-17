using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;


namespace Graded_Unit_Program
{
    public class Output
    {
        //creates strings to become the markup boxes in the xml file
        public string username, password, email, addrln1, addrln2, postcode, num, city, ticket;

        //gets and sets the vvariables
        public string Ticket
        {
            get { return ticket; }
            set { ticket = value; }
        }
        
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        
        public string Num
        {
            get { return num; }
            set { num = value; }
        }
        
        public string Postcode
        {
            get { return postcode; }
            set { postcode = value; }
        }
        
        public string Addrln2
        {
            get { return addrln2; }
            set { addrln2 = value; }
        }
       
        public string Addrln1
        {
            get { return addrln1; }
            set { addrln1 = value; }
        }
        
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        //writes all above variables to an XML file
        public void SaveAccount(string fileName)
        {
            using (var stream = new FileStream(fileName, FileMode.Create))
            {
                var XML = new XmlSerializer(typeof(Output));
                XML.Serialize(stream, this);
            }
        }

       
    }
}
