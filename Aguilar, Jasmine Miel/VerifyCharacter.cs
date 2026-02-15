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
    public partial class VerifyCharacter : Form
    {
        public static VerifyCharacter instance;
        public VerifyCharacter()
        {
            InitializeComponent();
            instance = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                char character = Convert.ToChar(textBox1.Text);

                if (Char.IsLetter(character))
                {
                    if (character == 'a' || character == 'A' || character == 'e' || character == 'E' || character == 'i' ||
                        character == 'I' || character == 'o' || character == 'O' || character == 'u' || character == 'U')
                    {
                        MessageBox.Show($"{character} is a Vowel");
                    }
                    else
                    {
                        MessageBox.Show($"{character} is a Consonant");
                    }
                }
                else if (Char.IsDigit(character))
                {
                    MessageBox.Show($"{character} is a Number");
                }
                else
                {
                    MessageBox.Show($"{character} is a Symbol");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("\nInvalid Input from user...\nError info: " + ex.Message);
            }
        }

        private void VerifyCharacter_Load(object sender, EventArgs e)
        {

        }
    }
}
