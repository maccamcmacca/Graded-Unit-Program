using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;


namespace Graded_Unit_Program
{
    public partial class Registration : Form
    {

        Output o = new Output();


        public Registration()
        {
            InitializeComponent();
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            //switches forms
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //sets the max length of the textbox to 20
            textBox1.MaxLength = 20;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            //sets the visual characters inputted 
            textBox3.PasswordChar = '*';
            textBox3.MaxLength = 20;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //checks if all required textboxes are occupied
            if (textBox1.Text.Length > 5 && textBox2.Text.Length > 5 && textBox3.Text.Length > 1 && textBox4.Text.Length > 1 && textBox6.Text.Length > 1 && textBox7.Text.Length > 1 && textBox8.Text.Length > 1)
            {
                //makes all of the textboxes occupy variables in the output class
                //so that the content of the textboxes can be written to an XML file
                o.username = textBox1.Text;
                o.email = textBox2.Text;
                o.password = textBox3.Text;
                o.addrln1 = textBox4.Text;
                o.addrln2 = textBox5.Text;
                o.postcode = textBox6.Text;
                o.Num = textBox7.Text;
                o.City = textBox8.Text;
                o.SaveAccount(textBox1.Text + ".xml");
                MessageBox.Show("Account Created");
                Form1 form = new Form1();
                this.Hide();
                form.Show();
            }
            else MessageBox.Show("One or more textboxes are empty or the username or password isn't 6 characters: addressLine 2 need not be occupied");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
