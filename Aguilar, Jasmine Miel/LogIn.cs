using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aguilar__Jasmine_Miel
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                string username = textBox1.Text;
                int password = Convert.ToInt32(textBox2.Text);

                if (username == "admin" && password == 123456)
                {
                    MessageBox.Show("\nSuccessful Login...Welcome Admin");
                    Menu form2 = new Menu();
                    form2.Show();
            }
                else
                {
                    MessageBox.Show("\nAccess Denied");
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
