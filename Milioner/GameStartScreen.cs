using Milioner.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Milioner.Utils.Util;

namespace Milioner
{
    public partial class GameStartScreen : Form
    {
        WMPLib.WindowsMediaPlayer wplayer;

        public GameStartScreen()
        {
            wplayer = new WMPLib.WindowsMediaPlayer();
            Util.PlayAudioFile(wplayer, AudioFile.StartScreen);
            wplayer.controls.play();
            InitializeComponent();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            Form form1 = new GameScreen(wplayer);
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

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
