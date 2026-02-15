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
    public partial class TicTacToe : Form
    {
        int nr = 0;
        public TicTacToe()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            nr++;
            Button b = (Button)sender;
            if (nr % 2 != 0)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }
            b.Enabled = false;

            if ((button1.Text==button2.Text && button2.Text==button3.Text && button1.Enabled==false) ||
               (button4.Text == button5.Text && button5.Text == button6.Text && button4.Enabled == false) ||
               (button7.Text == button8.Text && button8.Text == button9.Text && button7.Enabled == false) ||
               (button1.Text == button4.Text && button4.Text == button7.Text && button1.Enabled == false) ||
               (button2.Text == button5.Text && button5.Text == button8.Text && button2.Enabled == false) ||
               (button3.Text == button6.Text && button6.Text == button9.Text && button3.Enabled == false) ||
               (button1.Text == button5.Text && button5.Text == button9.Text && button1.Enabled == false) ||
               (button3.Text == button5.Text && button5.Text == button7.Text && button3.Enabled == false))
               {

                if (nr % 2 != 0)
                {
                    MessageBox.Show("X WINS");
                }
                else
                {
                    MessageBox.Show("O WINS");
                }
            }
        }

       
    }
}
