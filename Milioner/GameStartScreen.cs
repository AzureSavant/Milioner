using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milioner
{
    public partial class GameStartScreen : Form
    {
        public GameStartScreen()
        {
            InitializeComponent();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            Form form1 = new GameScreen();
            form1.Location = this.Location;
            form1.StartPosition = FormStartPosition.Manual;
            form1.FormClosed += delegate { this.Show(); };
            form1.Show();
            this.Hide();
        }

        private void ExitGameButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
