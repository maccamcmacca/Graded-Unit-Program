using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graded_Unit_Program
{
    public partial class ticketOrder : Form
    {
        public static string theEvent;
           
        public ticketOrder()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //tests if the textboxes have sufficient information
            if (textBox1.Text.Length > 1 && textBox2.Text.Length > 1 && textBox3.Text.Length > 0 && textBox4.Text.Length > 1 && textBox5.Text.Length > 1)
            {
                Output o = new Output();
                //sets the data to be written to the XML file
                o.Username = textBox1.Text;
                o.Password = textBox2.Text;
                o.Postcode = textBox3.Text;
                o.Email = textBox4.Text;
                o.Addrln1 = dateTimePicker1.Text;
                o.ticket = textBox5.Text;
                //writes the data to an XML file
                o.SaveAccount(textBox1.Text + ".xml");
                theEvent = textBox1.Text;
                //notifies the user that 
                MessageBox.Show("Event Successfully Created");
                AccountForm a = new AccountForm();
                this.Hide();
                a.Show();
            }
            else MessageBox.Show("One or more textboxes is empty");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //form switching
            AccountForm a = new AccountForm();
            this.Hide();
            a.Show();
        }

        private void ticketOrder_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
