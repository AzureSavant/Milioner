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
        public List<Question> Questions;
        public int QuestionSet = 0;

        public QuizService()
        {
            using (StreamReader r = new StreamReader("../../questions.json"))
            {
                var random = new Random();
                string json = r.ReadToEnd();
                var games = JsonConvert.DeserializeObject<Root>(json).games;
                QuestionSet = random.Next(games.Count);
                Questions = games[QuestionSet].questions;
            }

        }

        public List<int> AskAudience(int questionIndex)
        {
            int correctAnswerIndex = Questions[questionIndex].correct;
            Random r = new Random();
            List<int> audienceResults = new List<int>();
            for (int i = 0; i < 4; i++)
            {
                audienceResults.Add(i == correctAnswerIndex ? r.Next(30, 60) : r.Next(5, 30));
            }

            int totalPercentage = audienceResults.Sum();

            if (totalPercentage > 100)
            {
                int randomIndex;
                do
                {
                    randomIndex = r.Next(0, 3);
                }
                while (audienceResults[randomIndex] <= totalPercentage - 100);
                audienceResults[r.Next(0, 3)] -= totalPercentage - 100;
            }
            else if (totalPercentage < 100)
            {
                audienceResults[r.Next(0, 3)] += 100 - totalPercentage;
            }
            return audienceResults;
        }

        public AskAFriendModel CallAFriend(int questionIndex)
        {
            var question = Questions.ElementAt(questionIndex);
            var r = new Random();
            if (r.Next(0, 10) > 1)
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
            var question = Questions.ElementAt(questionIndex);
            var r = new Random();
            var incorrectAnswers = new List<int> { 0, 1, 2, 3 };
            incorrectAnswers.RemoveAt(question.correct);

            return new List<int>
            {
                question.correct,
                incorrectAnswers.ElementAt(r.Next(incorrectAnswers.Count))
            };

        }

        public Question GetQuestion(int index)
        {
            return Questions.ElementAt(index);
        }

        public bool ValidateAnswer(int questionIndex, int answerIndex)
        {
            return GetQuestion(questionIndex).correct == answerIndex;
        }
    }
}
