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

<<<<<<< Updated upstream
=======
        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void GameStartScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == WASDKonamiCode.ElementAt(keyBuffer.Count))
            {
                keyBuffer.Add(e.KeyCode);
            }
            else
            {
                keyBuffer = new List<Keys>();
            }
            if(Enumerable.SequenceEqual(keyBuffer, WASDKonamiCode))
            {
                PlayAudioFile(wplayer, AudioFile.StartScreenVariant);
                keyBuffer = new List<Keys>();

            }
        }
>>>>>>> Stashed changes
    }
}
