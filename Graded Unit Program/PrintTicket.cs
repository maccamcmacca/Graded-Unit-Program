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
using System.Drawing.Printing;

namespace Graded_Unit_Program
{
    public partial class PrintTicket : Form
    {
        Input i = new Input();
        Login l = new Login();
        PrintDocument print = new PrintDocument();
        //creates all the strings to read from the xml file
        string adr1 = "", adr2 = "", post = "", num = "", user = "", city = "";
        string tempadr1 = "addrln1", tempadr2 = "addrln2", temppost = "Postcode", tempnum = "Num", tempuser = "username", tempcity = "city";
        static string ev = "", art = "", date = "", price = "", ven = "", tick;
        static string tempev = "username", tempven = "password", tempart = "email", tempdate = "addrln1", tempprice = "postcode", temptick = "ticket";
        //creates an array for the dropdown menu to use
        string[] cardtypes = new string[] { "Mastercard", "American Express", "Visa Delta", "Visa Electron"};

        
        public PrintTicket()
        {
            InitializeComponent();
            //defines the dropdown menu contents
            comboBox1.Items.AddRange(cardtypes);
            
        }
         

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
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

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //writes all of the user info to the user boxes
            i.readXMLAccounts(Login.User, tempuser, ref user);
            textBox1.Text = user;
            i.readXMLAccounts(Login.User, tempadr1, ref adr1);
            textBox2.Text = adr1;
            i.readXMLAccounts(Login.User, tempadr2, ref adr2);
            textBox5.Text = adr2;
            i.readXMLAccounts(Login.User, temppost, ref post);
            textBox3.Text = post;
            i.readXMLAccounts(Login.User, tempnum, ref num);
            textBox4.Text = num;
            i.readXMLAccounts(Login.User, tempcity, ref city);
            textBox11.Text = city;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this opens the file dialogue to allow you to pick your event
            OpenFileDialog o = new OpenFileDialog();
            o.InitialDirectory = Directory.GetCurrentDirectory();
            o.Filter = "XML Files (.xml)|*.xml|All Files (*.*)|*.*";
            o.FilterIndex = 1;
            o.Multiselect = false;
            DialogResult dial = o.ShowDialog();
            if (dial == DialogResult.OK)
            {
                //this gets the directory then extracts the filename into the string path
                string path = Path.GetFileName(@o.FileName);
                //writes the event info to the event fields
                i.readXMLAccounts(path, tempev, ref ev);
                textBox6.Text = ev;
                i.readXMLAccounts(path, tempart, ref art);
                textBox7.Text = art;
                i.readXMLAccounts(path, tempdate, ref date);
                textBox8.Text = date;
                i.readXMLAccounts(path, tempven, ref ven);
                textBox10.Text = ven;
                i.readXMLAccounts(path, tempprice, ref price);
                textBox9.Text = "£" + price;
                //converts temp to a double
                double temp = Convert.ToDouble(price) + 1.75 + 1.50;
                textBox15.Text = temp.ToString();
            }
            

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //switches forms
            AccountForm acc = new AccountForm();
            this.Hide();
            acc.Show();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void CaptureScreen(object o, PrintPageEventArgs e)
        {
            //sets variables equals to the co-ordinates of the size of the window to be captured
            int y = SystemInformation.WorkingArea.Y, x = SystemInformation.WorkingArea.X, width = this.Width, height = this.Height;
            //sets the border to the window rectangles width and height
            Rectangle border = new Rectangle(x, y, width, height);
            //Creates a bitmap of the window
            Bitmap window = new Bitmap(width, height);
            //draws the butmap of the form 
            DrawToBitmap(window, border);

            Point point = new Point();
            //draws the image
            e.Graphics.DrawImage(window, point);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox6.Text.Length > 0 && comboBox1.Text.Length > 0 && textBox12.Text.Length == 16 && textBox13.Text.Length == 4 && textBox14.Text.Length == 3)
            {
                Output ou = new Output();
                PrintDocument print = new PrintDocument();
                //defines the landscape of the program
                i.readXMLAccounts(textBox6.Text, temptick, ref tick);
                int temp = Convert.ToInt32(tick) - 1;
                print.DefaultPageSettings.Landscape = true;
                print.PrintPage += new PrintPageEventHandler(CaptureScreen);
                print.Print();
            }
            else MessageBox.Show("Invalid Credentials");
        }
        


        Bitmap memoryImage;

        

       

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrintTicket_Load(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
