using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Aguilar__Jasmine_Miel
{
    public partial class Temperature : Form
    {
        public static Temperature instance;
        public Temperature()
        {
            InitializeComponent();
            instance = this;
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            try
            {
                double temperature = Convert.ToDouble(textBox1.Text);
                if (temperature < 20)
                {
                    MessageBox.Show("It's Cold");
                }
                else if (temperature > 25)
                {
                    MessageBox.Show("It's Hot");
                }
                else if (temperature >= 20 && temperature <= 25)
                {
                    MessageBox.Show("It's Warm");
                }
                else
                {
                    MessageBox.Show("Invalid Input");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Wrong input\nError info: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
