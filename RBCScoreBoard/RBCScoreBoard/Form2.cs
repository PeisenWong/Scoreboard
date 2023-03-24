using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace RBCScoreBoard
{
    public partial class Form2 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllips
            );

        public Form2()
        {
            InitializeComponent();
            System.Drawing.Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
    
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            lblDateTime.Text = now.ToString();

            string minSec = string.Format("{0} : {1:00}", Form1.displayCounter / 60, Form1.displayCounter % 60);
            lblMinutes.Text = minSec;
            
            statusDisp.Text = Form1.dispTest;
            ScoreA.Text = Form1.scoreA.ToString();
            ScoreB.Text = Form1.scoreB.ToString();

            if(Form1.turn >= Form1.Namelist.Count)
            {
                Form1.turn = 0;
            }
            
            if(Form1.turn < 1)
            {
                NameA.Text = Form1.Namelist[Form1.turn].ToString();
                NameB.Text = Form1.Namelist[Form1.turn + 1].ToString();
            }
            



            string timeA = string.Format("{0} : {1:00}", Form1.timeA / 60, Form1.timeA % 60);
            TimeA.Text = timeA;

            string timeB = string.Format("{0} : {1:00}", Form1.timeB / 60, Form1.timeB % 60);
            TimeB.Text = timeB;


        }

        private void MainLabel_Click(object sender, EventArgs e)
        {

        }

        private void Timer_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void lblLaghoriPickup_Click(object sender, EventArgs e)
        {

        }

        private void lblMinutes_Click(object sender, EventArgs e)
        {

        }

        private void R2A_Click(object sender, EventArgs e)
        {

        }

        private void laghoriShotDisp_Click(object sender, EventArgs e)
        {

        }

        private void lblDateTime_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void statusDisp_Click(object sender, EventArgs e)
        {

        }

        private void NameA_Click(object sender, EventArgs e)
        {

        }

        private void TimeB_Click(object sender, EventArgs e)
        {

        }

        private void ScoreB_Click(object sender, EventArgs e)
        {

        }

        private void lblScoreB_Click(object sender, EventArgs e)
        {

        }

        private void ScoreA_Click(object sender, EventArgs e)
        {

        }
    }
}
