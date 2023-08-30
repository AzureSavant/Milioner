using Milioner.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace Milioner.Services
{
    internal class QuizService : IQuizService
    {
        List<Question> questions;

        public QuizService()
        {
            using (StreamReader r = new StreamReader("../../questions.json"))
            {
                var random = new Random();
                string json = r.ReadToEnd();
                var games = JsonConvert.DeserializeObject<Root>(json).games;
                questions = games[random.Next(games.Count)].questions;
            }

        }

        public List<int> AskAudience(int questionIndex)
        {
            //TODO: Figure out how to generate the percentages so they 
            // the real life answers (they are not always correct)
            throw new NotImplementedException();
        }

        public AskAFriendModel CallAFriend(int questionIndex)
        {
            var question = questions.ElementAt(questionIndex);
            var r = new Random();
           if(r.Next(0, 10) > 1)
            {
                return new AskAFriendModel
                {
                    AnswerIndex = question.correct,
                    Confidence = r.Next(40, 90)
                };
            }
            var incorrectAnswers = new List<int> { 0, 1, 2, 3 };
            incorrectAnswers.RemoveAt(question.correct);
           return new AskAFriendModel
           {
               AnswerIndex = incorrectAnswers.ElementAt(r.Next(incorrectAnswers.Count)),
               Confidence = r.Next(10, 60)
           };
        }

        public List<int> FiftyFifty(int questionIndex)
        {
            var question = questions.ElementAt(questionIndex);
            var r = new Random();
            var incorrectAnswers = new List<int> { 0, 1, 2, 3 };
            incorrectAnswers.RemoveAt(question.correct);

            var leftAnswers = new List<int>();
            leftAnswers.Add(question.correct);
            leftAnswers.Add(incorrectAnswers.ElementAt(r.Next(incorrectAnswers.Count)));
            return leftAnswers;

        }

        public Question GetQuestion(int index)
        {
            return questions.ElementAt(index);
        }

        public bool ValidateAnswer(int questionIndex, int answerIndex)
        {
            return GetQuestion(questionIndex).correct == answerIndex;
        }
    }
}
