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
    public partial class ClickerGame : Form
    {
        public ClickerGame()
        {
            InitializeComponent();
            upgradetext();
            


        }

        

        void upgradetext()
        {
            textBox_gloves.Text = gloveslvl.ToString();
            textBox_axe.Text = axelvl.ToString();
            textBox_pick.Text = picklvl.ToString();
            textBox_drill.Text = drilllvl.ToString();
        }

        int drevo = 0;
        int iron = 0;
        int kamen = 0;
        int trava = 0;

        int axelvl = 1;
        int picklvl = 1;
        int drilllvl = 1;
        int gloveslvl = 1;

        


        private void ClickerGame_Load(object sender, EventArgs e)
        {

        }

        private void labelX_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label__Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            trava += 1 * gloveslvl;
            textBox_trava.Text = trava.ToString();
        }

        private void Strom1_Click(object sender, EventArgs e)
        {
            drevo += 1 * axelvl;
            textBox_drevo.Text = drevo.ToString();
        }

        private void Strom2_Click(object sender, EventArgs e)
        {
            drevo += 1 * axelvl;
            textBox_drevo.Text = drevo.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            trava += 1 * gloveslvl;
            textBox_trava.Text = trava.ToString();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            trava += 1 * gloveslvl;
            textBox_trava.Text = trava.ToString();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            trava += 1 * gloveslvl;
            textBox_trava.Text = trava.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            trava += 1 * gloveslvl;
            textBox_trava.Text = trava.ToString();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            trava += 1 * gloveslvl;
            textBox_trava.Text = trava.ToString();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            trava += 1 * gloveslvl;
            textBox_trava.Text = trava.ToString();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            trava += 1 * gloveslvl;
            textBox_trava.Text = trava.ToString();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            trava += 1 * gloveslvl;
            textBox_trava.Text = trava.ToString();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            trava += 1 * gloveslvl;
            textBox_trava.Text = trava.ToString();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            trava += 1 * gloveslvl;
            textBox_trava.Text = trava.ToString();
        }

        private void kamen2_Click(object sender, EventArgs e)
        {
            kamen += 1 * picklvl;
            textBox_kamen.Text = kamen.ToString();
        }

        private void kamen1_Click(object sender, EventArgs e)
        {
            kamen += 1 * picklvl;
            textBox_kamen.Text = kamen.ToString();
        }

        private void zelezo_Click(object sender, EventArgs e)
        {
            iron += 1 * drilllvl;
            textBox_zelezo.Text = iron.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
