#define morning

using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WMPLib;
using Excel = Microsoft.Office.Interop.Excel;

namespace RBCScoreBoard
{
    public partial class Form1 : Form
    {
        #region Variables
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        static public int counter1 = 0, preparationTarget = 60, gameTarget = 0,
                          countdownTarget = 30, displayCounter = 30, startFlag = 0, endBttnFlag = 0, RBallPick, LBallPick;

        static public int totalScore, totalBallShot, totalLaghoriShot, totalLaghoriPickUp,R1Retry,R1Violate,R2Retry,R2Violate,BOHSHOT,
                          RetryCountR1, ViolationCountR1, RetryCountR2, ViolationCountR2 ;

        static public int R1Time, R2Time, EXTRAROUNDTime, R2ABOHV, R2BBOHV;

        static public string statusDispText = "Preparation", dispTest = "Preparation";

        static public int scoreA, scoreB, timeA = 0, timeB = 0, endA = 0, endB = 0, turn = 0;

        int mode = 0, Session = 0, Round = 0, team, row_offset, column_offset, BOH_Shot_Click = 0, Ball_Load_Clicks = 0, Lagori_Pile_Click = 0;
        int[,] ball_loads_time = new int[5, 6];
        int[,] ball_shot_time = new int[5, 4];
        int[,] lagori_pile_time = new int[5, 5];
        int[] BOH_Shot = new int[5];
        int[] Ball_Load = new int[5];
        int[] Lagori_Pile = new int[5];
        string round_string, status_string;

        struct R1
        {
            // determine shoot lagori data
            public int logari_shot;
            public bool lagori_shot_down; 
            public int lagori_shot_time;

            public int shot_all_time;
            public int violation;
        
        };

        struct R2
        {
            // determine lagori pile data
            public int lagori_pile;

            // determine ball loading data

            public int pile_all_time;
            public int load_all_time;

            public int violation;
            public int BOH_fell;
        };

        struct Player
        {
            public string name;
            public int score;
            public int time;
        };

        Player playerA = new Player();
        Player playerB = new Player();
        List<Player> PlayerList = new List<Player>();

        

        static public List<string> Namelist = new List<string>();

        R1 r1 = new R1();
        R2 r2 = new R2();

        private void END1_Click(object sender, EventArgs e)
        {
            timeA = counter1;
            endA = 1;
        }


        private void END2_Click(object sender, EventArgs e)
        {
            timeB = counter1;
            endB = 1;
        }

        List<R1> R1List = new List<R1>();
        List<R2> R2List = new List<R2>();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblRound_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Timer_Click(object sender, EventArgs e)
        {

        }     

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllips
            );
        #endregion

        private void Countdown_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
         {}

        public Form1()
        {
            InitializeComponent();

            readData();
            ChallengerA.Text = Namelist[turn];
            ChallengerB.Text = Namelist[turn + 1];

            System.Drawing.Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
            Form2 secondForm = new Form2();
            int numofMon = Screen.AllScreens.Length;
            if(numofMon > 1) 
                secondForm.Location = Screen.AllScreens[1].WorkingArea.Location;
            secondForm.Show();
            panel2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 50, 50));
        }
        


        #region ButtonClickEvent

        private void bttnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void lblR1Ctrl_Click(object sender, EventArgs e)
        {

        }

        private void lblLagoriPick_Click(object sender, EventArgs e)
        {

        }

        private void LaghoriShot_Click(object sender, EventArgs e)
        {

        }

        private void laghoriPickUpNum_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        public void readData()
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Excel.Range range;

            string str;
            int rCnt;
            int cCnt;
            int rw = 0;
            int cl = 0;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(@"d:\User\Downloads\RBCScoreBoard2022-20220424T111616Z-001\RBCScoreBoard2022\RBCScoreBoard\test_2.xlsx", 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            range = xlWorkSheet.UsedRange;
            rw = range.Rows.Count;
            cl = range.Columns.Count;

            for (rCnt = 1; rCnt <= rw; rCnt++)
            {
                for (cCnt = 1; cCnt <= cl; cCnt++)
                {
                    str = (string)(range.Cells[rCnt, cCnt] as Excel.Range).Value2;
                    Namelist.Add(str);
                }
            }

            xlWorkBook.Close(true, null, null);
            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);

        }

        public void Save()
        {
            playerA.name = Namelist[turn];
            playerA.score = scoreA;
            playerA.time = timeA;

            playerB.name = Namelist[turn + 1];
            playerB.score = scoreB;
            playerB.time = timeB;

            PlayerList.Add(playerA);
            PlayerList.Add(playerB);

            timeA = 0;
            timeB = 0;
            endA = 0;
            endB = 0;
            ScoreA.Value = 0;
            ScoreB.Value = 0;

            string test = "Session: {0} PlayerA: {1}, ScoreA: {2}, TimeA: {3}, PlayerB: {4}, ScoreB: {5}, TimeB: {6}";
            test = string.Format(test, Session, PlayerList[turn].name, PlayerList[turn].score, PlayerList[turn].time,
                PlayerList[turn + 1].name, PlayerList[turn + 1].score, PlayerList[turn + 1].time);

            //MessageBox.Show(test);
        }

        private void bttnFinish_Click(object sender, EventArgs e)
        {
            /*
             * 4 modes
             * Preparation 60s
             * Autocar 3min
             * Preparation 60s
             * Manual 90s
             */
            mode++;
            timer1.Enabled = false;
            counter1 = 0;

            if (mode % 4 == 0)
            {
                countdownTarget = 30;
                RoundNew.Text = "Preparation";
                Save();
                Session++;
                turn += 2;
                //MessageBox.Show(turn.ToString());
                if (turn >= Namelist.Count)
                {
                    turn = 0;
                    Export();
                }
                ChallengerA.Text = Namelist[turn];
                ChallengerB.Text = Namelist[turn + 1];
                
            }

            else if (mode % 4 == 1)
            {
                countdownTarget = 180;
                RoundNew.Text = "Autocar";
            }

            else if (mode % 4 == 2)
            {
                countdownTarget = 30;
                RoundNew.Text = "Preparation";
            }

            else
            {
                countdownTarget = 90;
                RoundNew.Text = "Soccer Time";
            }
            Countdown.Text = countdownTarget.ToString();
            displayCounter = countdownTarget;
            dispTest = RoundNew.Text;
        }
        
        public void Export()
        {
            Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            string fileName = "D:\\User\\Downloads\\RBCScoreBoard2022-20220424T111616Z-001\\RBCScoreBoard2022\\RBCScoreBoard\\Exported\\{0}.xls";
            string fileNameInput;

            DateTime now = DateTime.Now;

            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }

            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            row_offset = 28;
            column_offset = 5;
            int column_offset_const = 2;

            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            xlWorkSheet.Cells[1, 1] = "UTM ROBOCON AUTOCAR DAY!";
            xlWorkSheet.Cells[2, 1] = "Date/Time:";
            xlWorkSheet.Cells[2, 2] = now.ToString("MM'-'dd'---'HH': 'mm");

            xlWorkSheet.Cells[4, 1] = "Name";
            xlWorkSheet.Cells[4, 2] = "Score";
            xlWorkSheet.Cells[4, 3] = "Time";

            for (int i = 0; i < PlayerList.Count(); i++)
            {
                xlWorkSheet.Cells[5 + i, 1] = PlayerList[i].name;
                xlWorkSheet.Cells[5 + i, 2] = PlayerList[i].score;
                xlWorkSheet.Cells[5 + i, 3] = PlayerList[i].time;
            }

            fileNameInput = now.ToString("MM'-'dd'T'HH''mm");

            if (fileNameInput != "")
            {
                fileName = string.Format(fileName, fileNameInput);

                xlWorkBook.SaveAs(fileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                MessageBox.Show("File at D:\\User\\Downloads\\RBCScoreBoard2022-20220424T111616Z-001\\RBCScoreBoard2022\\RBCScoreBoard\\Exported");
            }
            else
            {
                MessageBox.Show("Please put file name");
            }
            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);
        }
        
        private void bttnExport_Click(object sender, EventArgs e)
        {
            Export();
        }

        private void bttnReset_Click(object sender, EventArgs e)
        {
            if (mode % 4 == 0)
            {
                Session -= 1;
                if (Session < 0)
                    Session = 0;

                turn -= 2;
                if (turn < 0)
                    turn = 0;

                PlayerList.RemoveRange(turn, 2);

                ChallengerA.Text = Namelist[turn];
                ChallengerB.Text = Namelist[turn + 1];
            }

            mode--;

            if (mode < 0)
                mode = 0;

            timer1.Enabled = false;
            counter1 = 0;

            if (mode % 4 == 0)
            {
                countdownTarget = 30;
                RoundNew.Text = "Preparation";

            }

            else if (mode % 4 == 1)
            {
                countdownTarget = 180;
                RoundNew.Text = "Autocar";

                timeA = 0;
                timeB = 0;
                endA = 0;
                endB = 0;
                ScoreA.Value = 0;
                ScoreB.Value = 0;
            }

            else if (mode % 4 == 2)
            {
                countdownTarget = 30;
                RoundNew.Text = "Preparation";
            }

            else
            {
                countdownTarget = 90;
                RoundNew.Text = "Soccer Time";
            }
            Countdown.Text = countdownTarget.ToString();
            displayCounter = countdownTarget;
            dispTest = RoundNew.Text;
        }
        private void bttnPause_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
        }
        private void bttnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Scroll_ValueChanged(object sender, EventArgs e)
        {
            scoreA = (int)ScoreA.Value;
            scoreB = (int)ScoreB.Value;

            totalScore = totalLaghoriShot * 5 + totalLaghoriPickUp * 10;

            r1.logari_shot = totalLaghoriShot;
            r1.violation = R1Violate;

            r2.violation = R2Violate;
            r2.lagori_pile = totalLaghoriPickUp;
          
        }

        private void Form1_MouseDown(object sender,
        System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
#endregion

#region Timer1
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter1 += 1;
            if (mode % 4 == 1)
            {
                if (endA == 0)
                {
                    timeA += 1;
                    if (timeA > 180) timeA = 180;
                }
                if (endB == 0)
                {
                    timeB += 1;
                    if (timeB > 180) timeB = 180;
                }

            }

            displayCounter = countdownTarget - counter1;
            /*
            if (displayCounter == 3)
            {
                //player.URL = "C:/Users/User/Downloads/RBCScoreBoard2022-20220424T111616Z-001/RBCScoreBoard2022/5s_beep.mp3";
                player.URL = "D:\\User\\Downloads\\RBCScoreBoard2022-20220424T111616Z-001\\RBCScoreBoard2022\\count_3(3).wav";
                player.controls.play();
            }
            if (displayCounter == 0)
            {
                player.URL = "D:\\User\\Downloads\\RBCScoreBoard2022-20220424T111616Z-001\\RBCScoreBoard2022\\air_horn.mp3";
                player.controls.play();
            }
            */

            if (displayCounter < 0)
                displayCounter = 0;

            Countdown.Text = displayCounter.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

#endregion

#region Other Objects
        private void Reset()
        {
             
            counter1 = 0; 
            preparationTarget = 60; 
            gameTarget = 90;
            mode = 0;
            Round = 0;
            Session = 0;
            countdownTarget = 0;
            startFlag = 0;
            displayCounter = 60;
             statusDispText = "PREPARATION";


            timer1.Enabled = false;
            timer2.Enabled = false;

            ScoreA.Value = 0;

            totalScore = 0;

            mode = 0;

            Countdown.Text = displayCounter.ToString();

            R1List.Clear();
            R2List.Clear();

            BOH_Shot_Click = 0;
            Ball_Load_Clicks = 0;
        }

        

        private void CheckMode()
        {

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case (Keys.F1 | Keys.Up):
                    {
                        if (ScoreA.Value >= 5)
                            return false;
                        else
                        {
                            ScoreA.Value += 1;
                        }
                        return true;
                    }
                case (Keys.F2 | Keys.Up):
                    return true;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }
    }
}

#endregion
