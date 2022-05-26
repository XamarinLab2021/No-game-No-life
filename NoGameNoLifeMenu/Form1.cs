using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoGameNoLifeMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            button1.ForeColor = Color.FromArgb(235, 94, 40);
            button2.ForeColor = Color.White;
            tictactoe1.BringToFront();


        }

        private void LogoPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LogoPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label__Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LogoPanel_MouseMove(object sender, MouseEventArgs e)
        {
            Move_Form(Handle, e);
        }

        public void Move_Form(IntPtr Handle, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            button1.ForeColor = Color.FromArgb(235, 94, 40);
            button2.ForeColor = Color.White;
            button5.ForeColor = Color.White;
            button4.ForeColor = Color.White;
            tictactoe1.BringToFront();
            ColorchangeTicTacToe();
            button3.ForeColor = Color.White;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            button2.ForeColor = Color.FromArgb(235, 94, 40);
            button1.ForeColor = Color.White;
            button5.ForeColor = Color.White;
            button4.ForeColor = Color.White;
            empty1.BringToFront();
            ColorchangeClicker();
            button3.ForeColor = Color.White;
        }

        private void empty1_Load(object sender, EventArgs e)
        {

        }

        void ColorchangeClicker()
        {
            LogoPanel.BackColor = Color.ForestGreen;
            button2.ForeColor = Color.ForestGreen;
            SidePanel.BackColor = Color.ForestGreen;
        }
        void ColorchangeTicTacToe()
        {
            LogoPanel.BackColor = Color.FromArgb(235, 94, 40);
            button1.ForeColor = Color.FromArgb(235, 94, 40);
            SidePanel.BackColor = Color.FromArgb(235, 94, 40);
        }

        void ColorchangeLOGICGAME()
        {
            LogoPanel.BackColor = Color.FromArgb(63, 83, 164);
            button3.ForeColor = Color.FromArgb(63, 83, 164);
            SidePanel.BackColor = Color.FromArgb(63, 83, 164);
        }

        void ColorchangeNEWGAME1()
        {
            LogoPanel.BackColor = Color.FromArgb(100, 0, 100);
            button4.ForeColor = Color.FromArgb(100, 0, 100);
            SidePanel.BackColor = Color.FromArgb(100, 0, 100);
        }

        void ColorchangeNEWGAME2()
        {
            LogoPanel.BackColor = Color.Crimson;
            button5.ForeColor = Color.Crimson;
            SidePanel.BackColor = Color.Crimson;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            button3.ForeColor = Color.FromArgb(63, 83, 164);
            button1.ForeColor = Color.White;
            button2.ForeColor = Color.White;
            button5.ForeColor = Color.White;
            button4.ForeColor = Color.White;
            empty21.BringToFront();

            ColorchangeLOGICGAME();
        }

        private void empty21_Load(object sender, EventArgs e)
        {

        }

        private void empty22_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            button4.ForeColor = Color.FromArgb(100, 0, 100);
            button1.ForeColor = Color.White;
            button2.ForeColor = Color.White;
            button5.ForeColor = Color.White;
            button3.ForeColor = Color.White;
            ColorchangeNEWGAME1();
            rockPaperScissors1.BringToFront();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button5.Height;
            SidePanel.Top = button5.Top;
            button5.ForeColor = Color.Crimson;
            button1.ForeColor = Color.White;
            button2.ForeColor = Color.White;
            button4.ForeColor = Color.White;
            button3.ForeColor = Color.White;
            ColorchangeNEWGAME2();
        }
    }
}
