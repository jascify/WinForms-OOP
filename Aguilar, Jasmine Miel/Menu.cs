using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Aguilar__Jasmine_Miel
{
    public partial class Menu : Form
    {
        public static Menu instance;
        public Menu()
        {
            InitializeComponent();
            instance = this;
        }

        private void mySimpleCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculator form3 = new Calculator();
            form3.Show();
        }

        private void minorOrAdultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgeCalculator form4 = new AgeCalculator();
            form4.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void daysOfTheWeekToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DaysOfTheWeek form5 = new DaysOfTheWeek();
            form5.Show();
        }

        private void temperatureToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Temperature form6 = new Temperature();
            form6.Show();
        }

        private void studentGWAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StudentGWA form7 = new StudentGWA();
            form7.Show();
        }

        private void areaOfRectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AreaOfRectangle form8 = new AreaOfRectangle();
            form8.Show();
        }

        private void verifyACharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerifyCharacter form9 = new VerifyCharacter();
            form9.Show();
        }

        private void calculateMyAgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalculateAge form10 = new CalculateAge();
            form10.Show();
        }

        private void formToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrationForm form11 = new RegistrationForm();
            form11.Show();
        }

        private void myResumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyResume form13 = new MyResume();
            form13.Show();
        }

        private void facebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.facebook.com/jasminemiel03",
                UseShellExecute = true
            });
        }

        private void yToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.youtube.com/watch?v=y1cBhJLNNXU",
                UseShellExecute = true
            });
        }

        private void googleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.google.com/",
                UseShellExecute = true
            });
        }

        private void instagramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.instagram.com/jxsmiel?igsh=MTc5b3M5YjZ6OGd4Ng==",
                UseShellExecute = true
            });
        }

        private void spotifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://open.spotify.com/user/h73hcjg9wplwps30doe7kjxry",
                UseShellExecute = true
            });
        }

        private void netflixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.netflix.com/ph-en/",
                UseShellExecute = true
            });
        }

        private void gDriveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://drive.google.com/drive/my-drive",
                UseShellExecute = true
            });
        }

        private void gMeetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://meet.google.com/landing",
                UseShellExecute = true
            });
        }

        private void googleMapsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.google.com/maps",
                UseShellExecute = true
            });
        }

        private void controlToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void daysOfTheWeekToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DaysOfTheWeek form7 = new DaysOfTheWeek();
            form7.Show();
        }

        private void temperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Temperature form8 = new Temperature();
            form8.Show();
        }

        private void studentGWAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentGWA form9 = new StudentGWA();
            form9.Show();
        }

        private void ticTacToeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicTacToe form12 = new TicTacToe();
            form12.Show();
        }
    }
}
