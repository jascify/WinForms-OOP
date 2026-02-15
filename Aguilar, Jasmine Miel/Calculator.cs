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
    public partial class Calculator : Form
    {
        public static Calculator instance;
        public Calculator()
        {
            InitializeComponent();
            instance = this;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double firstNum = Convert.ToDouble(textBox1.Text);
                double secondNum = Convert.ToDouble(textBox2.Text);
                double output = firstNum + secondNum;

                textBox3.Text = output.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Wrong input\nError info: " + ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double firstNum = Convert.ToDouble(textBox1.Text);
                double secondNum = Convert.ToDouble(textBox2.Text);
                double output = firstNum - secondNum;

                textBox3.Text = output.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Wrong input\nError info: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double firstNum = Convert.ToDouble(textBox1.Text);
                double secondNum = Convert.ToDouble(textBox2.Text);
                double output = firstNum * secondNum;

                textBox3.Text = output.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Wrong input\nError info: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try {
                double firstNum = Convert.ToDouble(textBox1.Text);
                double secondNum = Convert.ToDouble(textBox2.Text);
                double output = firstNum / secondNum;

                textBox3.Text = output.ToString();
            } catch (FormatException ex) {
                MessageBox.Show("Wrong input\nError info: " + ex.Message);
            }

        }
    }
}
