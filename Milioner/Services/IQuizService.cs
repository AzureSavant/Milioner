
using Milioner.Models;
using System.Collections.Generic;

namespace Milioner.Services
{
    internal interface IQuizService
    {
        Question GetQuestion(int index);
        bool ValidateAnswer(int questionIndex, int answerIndex);
        AskAFriendModel CallAFriend(int questionIndex);

        // [25,25,50,0] = A - 25%, B - 25%, C - 50%, D - 0%
        List<int> AskAudience(int questionIndex);

        // [1,3] = B & D
        List<int> FiftyFifty(int questionIndex);
    }
}
