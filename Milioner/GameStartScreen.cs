using Milioner.Models;
using Milioner.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static Milioner.Utils.Util;

namespace Milioner
{
    public partial class GameStartScreen : Form
    {
        WMPLib.WindowsMediaPlayer wplayer;
        List<Keys> keyBuffer = new List<Keys>();
        Helper helper;
        public GameStartScreen()
        {
            wplayer = new WMPLib.WindowsMediaPlayer();
            PlayAudioFile(wplayer, AudioFile.StartScreen);
            wplayer.controls.play();
            helper = new Helper();
            InitializeComponent();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            GameState gameState = helper.LoadGameStateFromFile();
            Form form1 = new GameScreen(wplayer, gameState);
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
    }
}
