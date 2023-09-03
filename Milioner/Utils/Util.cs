using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milioner.Utils
{
    internal static class Util
    {
<<<<<<< Updated upstream
=======
        

        public static List<Keys> WASDKonamiCode = new List<Keys> { Keys.W, Keys.W, Keys.S, Keys.S, Keys.A, Keys.D, Keys.A, Keys.D, Keys.B, Keys.A };
        public static List<Keys> CheatCode = new List<Keys> { Keys.T, Keys.R, Keys.E, Keys.N, Keys.D, Keys.O, Keys.M, Keys.E, Keys.P, Keys.R, Keys.A, Keys.T, Keys.I };
>>>>>>> Stashed changes
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
    }
}
