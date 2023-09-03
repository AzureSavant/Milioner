using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milioner.Models
{
    public class GameState
    {
        public int GameId { get; set; }
        public int QuestionIndex { get; set; }
        public bool AskAFriendAvailable { get; set; }
        public bool FiftyFiftyAvailable { get; set; }
        public bool AskTheAudienceAvailable { get; set; }

    }
}
