using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Aguilar__Jasmine_Miel
{
    public partial class AgeCalculator : Form
    {
        public static AgeCalculator instance;
        public AgeCalculator()
        {
            InitializeComponent();
            instance = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int age = Convert.ToInt32(textBox1.Text);

                if (age >= 60)
                {
                    MessageBox.Show("You're a Senior Citizen");
                }
                else if (age >= 18)
                {
                    MessageBox.Show("You're an Adult");
                }
                else if (age < 18)
                {
                    MessageBox.Show("You're a Minor");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Wrong input\nError info: " + ex.Message);
            }
        }
    }
}
