using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace Graded_Unit_Program
{
    public partial class Login : Form
    {
        Output o = new Output();
        Input i = new Input();
        AccountForm tick = new AccountForm();
        public static string User;


        public Login()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = "password";
            string thepassword = "";
            //reads the password to check if the username matches the password
            i.readXMLAccounts(textBox1.Text + ".xml", password, ref thepassword);
            //checks if the password is correct and checks if the textboxes have credentials in them
            if (thepassword == textBox2.Text && textBox1.Text.Length > 5 && textBox2.Text.Length > 1)
            {
                //sets user to 
                User = textBox1.Text + ".xml";
                MessageBox.Show("Login Successful!");
                this.Hide();
                tick.Show();
                
            }
                //if credentials don't match notify the user
            else MessageBox.Show("Invalid username or password");
            


        }


    }
}
