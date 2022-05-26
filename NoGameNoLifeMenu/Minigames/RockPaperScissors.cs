using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoGameNoLifeMenu.Minigames
{
    public partial class RockPaperScissors : UserControl
    {
        public RockPaperScissors()      // 1 rock
                                        // 2 paper
                                        // 3 scissors
        {
            InitializeComponent();
        }

        private void button_rock_Click(object sender, EventArgs e)
        {
            
            button1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.noto_rock));
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            Random rd = new Random();
            int pcchoice = rd.Next(1, 4);
            if (pcchoice == 1)
            {
                button2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.noto_rock));
                button2.BackgroundImageLayout = ImageLayout.Zoom;
                label1.Text = "DRAW";
            }
            if (pcchoice == 3)
            {
                button2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.noto_v1_scissors));
                button2.BackgroundImageLayout = ImageLayout.Zoom;
                label1.Text = "YOU WON";
            }
            if (pcchoice == 2)
            {
                button2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.noto_roll_of_paper));
                button2.BackgroundImageLayout = ImageLayout.Zoom;
                label1.Text = "YOU LOST";
            }
        }

        private void button_paper_Click(object sender, EventArgs e)
        {
            button1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.noto_roll_of_paper));
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            Random rd = new Random();
            int pcchoice = rd.Next(1, 4);
            if (pcchoice == 1)
            {
                button2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.noto_rock));
                button2.BackgroundImageLayout = ImageLayout.Zoom;
                label1.Text = "YOU WON";
            }
            if (pcchoice == 3)
            {
                button2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.noto_v1_scissors));
                button2.BackgroundImageLayout = ImageLayout.Zoom;
                label1.Text = "YOU LOST";
            }
            if (pcchoice == 2)
            {
                button2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.noto_roll_of_paper));
                button2.BackgroundImageLayout = ImageLayout.Zoom;
                label1.Text = "DRAW";
            }
        }

        private void button_scissors_Click(object sender, EventArgs e)
        {
            button1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.noto_v1_scissors));
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            Random rd = new Random();
            int pcchoice = rd.Next(1, 4);
            if (pcchoice == 1)
            {
                button2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.noto_rock));
                button2.BackgroundImageLayout = ImageLayout.Zoom;
                label1.Text = "YOU LOST";
            }
            if (pcchoice == 3)
            {
                button2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.noto_v1_scissors));
                button2.BackgroundImageLayout = ImageLayout.Zoom;
                label1.Text = "DRAW";
            }
            if (pcchoice == 2)
            {
                button2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.noto_roll_of_paper));
                button2.BackgroundImageLayout = ImageLayout.Zoom;
                label1.Text = "YOU WON";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RockPaperScissors_Load(object sender, EventArgs e)
        {

        }
    }
}
