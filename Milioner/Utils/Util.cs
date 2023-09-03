using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milioner.Utils
{
    internal static class Util
    {
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
