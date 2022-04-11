using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoGameNoLifeMenu
{
    public partial class empty : UserControl
    {
        public empty()
        {
            InitializeComponent();
        }

        public void Playbutton_Click(object sender, EventArgs e)
        {
            ClickerGame clickerGame = new ClickerGame();
            clickerGame.ShowDialog();
        }
    }
}
