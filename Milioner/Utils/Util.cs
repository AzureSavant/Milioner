using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milioner.Utils
{
    internal static class Util
    {
        public static List<Keys> KonamiCode = new List<Keys> { Keys.W, Keys.W, Keys.S, Keys.S, Keys.A, Keys.D, Keys.A, Keys.D, Keys.B, Keys.A };
        static public char GetAnswerLetter(int index)
        {
            switch (index)
            {
                case 0:
                    return 'A';
                case 1:
                    return 'B';
                case 2:
                    return 'C';
                 case 3:
                    return 'D';
            }
            return 'A';
        }
        static public void PlayAudioFile(WMPLib.WindowsMediaPlayer player, string audioFileName)
        {
            player.controls.stop();
            player.URL = Path.Combine(Path.GetFullPath(@"..\..\"), "Resources", "Audio", audioFileName);
            player.controls.play();
        }

        public class AudioFile 
        {
            public static string LetsPlay = "LetsPlay.mp3";
            public static string CorrectAnswer = "CorrectAnswer.mp3";
            public static string WrongAnswer = "WrongAnswer.mp3";
            public static string StartScreen = "StartScreen.mp3";
            public static string StartScreenVariant= "StartScreenEasterEgg.mp3";
            public static string PhoneAFriend = "PhoneAFriend.mp3";
        }
    }
}
