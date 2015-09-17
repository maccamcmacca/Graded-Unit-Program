using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graded_Unit_Program
{
    public partial class AccountForm : Form
    {
       
        public AccountForm()
        {
            InitializeComponent();
            
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //swaps forms
            ticketOrder t = new ticketOrder();
            this.Hide();
            t.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //defines the current path
            string path = Directory.GetCurrentDirectory();
            
            OpenFileDialog f = new OpenFileDialog();
            //ensures that the filedialog only sees xml files unless specified otherwise
            f.Filter = "XML Files (.xml)|*.xml|All Files (*.*)|*.*";
            f.FilterIndex = 1;
            //makes it so that only 1 file can be selected
            f.Multiselect = false;
            //sets the directory the filedialog opens in
            f.InitialDirectory = path;
            //shows the filedialog and sets the filedialog to the result of the selection inside the filedialog
            DialogResult dia = f.ShowDialog();
            if (dia == DialogResult.OK)
            {
                //sets the path to delete
                string delpath = f.FileName;
            
            //deletes the file
            if (f.CheckFileExists == true)
            {
                File.Delete(delpath);
                MessageBox.Show("File Removed");
            }
            }
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            PrintTicket pr = new PrintTicket();
            this.Hide();
            pr.Show();
        }
    }
}
