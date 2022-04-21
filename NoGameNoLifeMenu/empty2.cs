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
    public partial class empty2 : UserControl
    {
        public empty2()
        {
            InitializeComponent();
        }

        private void Playbutton_Click(object sender, EventArgs e)
        {
            LogicGame clickerGame = new LogicGame();
            clickerGame.ShowDialog();
        }
    }
}
