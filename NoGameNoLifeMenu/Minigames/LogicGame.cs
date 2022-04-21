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
    public partial class LogicGame : Form
    {
        public LogicGame()
        {
            InitializeComponent();
        }

        public void EmptySpot(Button butt1, Button butt2)
        {
            if (butt2.Text == "")
            {
                butt2.Text = butt1.Text;
                butt1.Text = "";
            }
        }

        public void Checker()
        {
            if (button1.Text == "1" && button2.Text == "2" && button3.Text == "3" && button4.Text == "4" && button5.Text == "5" && button6.Text == "6" &&
                button7.Text == "7" && button8.Text == "8" && button9.Text == "9" && button10.Text == "10" && button11.Text == "11" && button12.Text == "12" &&
                button13.Text == "13" && button14.Text == "14" && button15.Text == "15")
            {
                MessageBox.Show("You Won !!", "Shuffle Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void Shuffle()
        {
            int[] numbers = new int[16];
            int i;
            int j;
            int rowcheck;
            Boolean b = false;
            i = 1;
            do
            {
                Random rnd = new Random();
                rowcheck = Convert.ToInt32((rnd.Next(0, 15)) + 1);

                for (j = 1; j <= i; j++)
                {
                    if (numbers[j] == rowcheck)
                    {
                        b = true;
                        break;
                    }
                }
                if (b == true)
                {
                    b = false;
                }
                else
                {
                    numbers[i] = rowcheck;
                    i = i + 1;
                }
            }
            while (i <= 15);
            button1.Text = Convert.ToString(numbers[1]);
            button2.Text = Convert.ToString(numbers[2]);
            button3.Text = Convert.ToString(numbers[3]);
            button4.Text = Convert.ToString(numbers[4]);
            button5.Text = Convert.ToString(numbers[5]);
            button6.Text = Convert.ToString(numbers[6]);
            button7.Text = Convert.ToString(numbers[7]);
            button8.Text = Convert.ToString(numbers[8]);
            button9.Text = Convert.ToString(numbers[9]);
            button10.Text = Convert.ToString(numbers[10]);
            button11.Text = Convert.ToString(numbers[11]);
            button12.Text = Convert.ToString(numbers[12]);
            button13.Text = Convert.ToString(numbers[13]);
            button14.Text = Convert.ToString(numbers[14]);
            button15.Text = Convert.ToString(numbers[15]);
            button16.Text = "";

        }










        private void button3_Click(object sender, EventArgs e)
        {
            EmptySpot(button3, button7);
            EmptySpot(button3, button2);
            EmptySpot(button3, button4);
            Checker();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmptySpot(button2, button1);
            EmptySpot(button2, button6);
            EmptySpot(button2, button3);
            Checker();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmptySpot(button1, button2);
            EmptySpot(button1, button5);
            Checker();
        }

        private void LogicGame_Load(object sender, EventArgs e)
        {
            Shuffle();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EmptySpot(button4, button3);
            EmptySpot(button4, button8);
            
            Checker();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EmptySpot(button5, button6);
            EmptySpot(button5, button9);
            EmptySpot(button5, button1);
            Checker();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EmptySpot(button6, button5);
            EmptySpot(button6, button7); 
            EmptySpot(button6, button2);
            EmptySpot(button6, button10);
            Checker();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            EmptySpot(button7, button3);
            EmptySpot(button7, button6);
            EmptySpot(button7, button11);
            EmptySpot(button7, button8);
            Checker();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            EmptySpot(button8, button4);
            EmptySpot(button8, button7);
            EmptySpot(button8, button12);
            Checker();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            EmptySpot(button9, button5);
            EmptySpot(button9, button10);
            EmptySpot(button9, button13);
            Checker();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            EmptySpot(button10, button6);
            EmptySpot(button10, button9);
            EmptySpot(button10, button11);
            EmptySpot(button10, button14);
            Checker();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            EmptySpot(button11, button7);
            EmptySpot(button11, button10);
            EmptySpot(button11, button12);
            EmptySpot(button11, button15);
            Checker();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            EmptySpot(button12, button8);
            EmptySpot(button12, button11);
            EmptySpot(button12, button16);
            Checker();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            EmptySpot(button13, button9);
            EmptySpot(button13, button14);
            Checker();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            EmptySpot(button14, button10);
            EmptySpot(button14, button13);
            EmptySpot(button14, button15);
            Checker();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            EmptySpot(button15, button11);
            EmptySpot(button15, button14);
            EmptySpot(button15, button16);
            Checker();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            EmptySpot(button16, button12);
            EmptySpot(button16, button15);
            
            Checker();
        }

        private void labelX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label__Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Shuffle();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
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
    }
}
