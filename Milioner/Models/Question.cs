using System.Collections.Generic;

namespace Milioner.Models
{
    public class Question
    {
        public string question { get; set; }
        public List<string> content { get; set; }
        public int correct { get; set; }
    }
}
