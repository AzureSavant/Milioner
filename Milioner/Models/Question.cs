using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milioner.Models
{
    public class Question
    {
        public string question { get; set; }
        public List<string> content { get; set; }
        public int correct { get; set; }
    }
}
