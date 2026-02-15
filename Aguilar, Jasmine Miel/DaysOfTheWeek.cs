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
    public partial class DaysOfTheWeek : Form
    {
        public static DaysOfTheWeek instance;
        public DaysOfTheWeek()
        {
            InitializeComponent();
            instance = this;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int dayNum = Convert.ToInt32(textBox1.Text);
                switch (dayNum)
                {
                    case 1:
                        MessageBox.Show("It's Sunday today");
                        break;
                    case 2:
                        MessageBox.Show("It's Monday today");
                        break;
                    case 3:
                        MessageBox.Show("It's Tuesday today");
                        break;
                    case 4:
                        MessageBox.Show("It's Wednesday today");
                        break;
                    case 5:
                        MessageBox.Show("It's Thursday today");
                        break;
                    case 6:
                        MessageBox.Show("It's Friday today");
                        break;
                    case 7:
                        MessageBox.Show("It's Saturday today");
                        break;
                    default:
                        MessageBox.Show("Invalid Input. Enter number 1-7 only.");
                        break;
                }
            } catch (FormatException ex) {
                MessageBox.Show("Wrong input\nError info: " + ex.Message);

            }

        }
    }
}
