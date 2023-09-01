using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milioner.Models.ListBoxItems
{
    public class ScoreEntry
    {
        public int Number { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return $"{Number} - ${Price}";
        }
    }
}
