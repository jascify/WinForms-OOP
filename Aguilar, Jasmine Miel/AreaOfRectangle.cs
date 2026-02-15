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
    public partial class AreaOfRectangle : Form
    {
        public static AreaOfRectangle instance;
        public AreaOfRectangle()
        {
            InitializeComponent();
            instance = this;
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double length = Convert.ToDouble(textBox1.Text);
                double width = Convert.ToDouble(textBox2.Text);

                double area = (length * width);

                MessageBox.Show($"Area of rectangle is {area} cm");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Wrong input\nError info: " + ex.Message);
            }
        }
    }
}
