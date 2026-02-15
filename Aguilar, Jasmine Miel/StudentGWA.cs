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
    public partial class StudentGWA : Form
    {
        public static StudentGWA instance;

        public StudentGWA()
        {
            InitializeComponent();
            instance = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                int gwa = Convert.ToInt32(textBox1.Text);
                if (gwa >= 90)
                {
                    MessageBox.Show("Excellent Student");
                }
                else if (gwa >= 80)
                {
                    MessageBox.Show("Average Student");
                }
                else if (gwa >= 75)
                {
                    MessageBox.Show("Satisfactory Student");
                }
                else if (gwa < 75)
                {
                    MessageBox.Show("Need to study more...");
                }
                else
                {
                    MessageBox.Show("Invalid Input");
                }
            } catch (FormatException ex) {
                MessageBox.Show("Wrong input\nError info: " + ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StudentGWA_Load(object sender, EventArgs e)
        {

        }
    }
}
