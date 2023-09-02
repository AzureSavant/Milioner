using Milioner.Models.ListBoxItems;
using Milioner.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Milioner
{
    public partial class GameScreen : Form
    {
        QuizService quizService = new QuizService();
        int questionIndex = 0;
        public GameScreen()
        {
            InitializeComponent();
            loadQuestion();
            for(var a = 14; a >= 0; a--)
            {
                if(a >= 10)
                lbScore.Items.Add(new ScoreEntry
                {
                    Number = a + 1,
                    Price = (a + 1) * 1000
                });
                if(a < 10 && a > 5)
                    lbScore.Items.Add(new ScoreEntry
                    {
                        Number = a + 1,
                        Price = (a + 1) * 500
                    });
                if (a <= 5)
                {
                    lbScore.Items.Add(new ScoreEntry
                    {
                        Number = a + 1,
                        Price = (a + 1) * 100
                    });
                }
            }
            lbScore.SelectedIndex = 14-questionIndex;
        }

        private void loadQuestion()
        {
            tbQuestion.Text = quizService.GetQuestion(questionIndex).question;
            btnAnswerA.Text = quizService.GetQuestion(questionIndex).content[0];
            btnAnswerB.Text = quizService.GetQuestion(questionIndex).content[1];
            btnAnswerC.Text = quizService.GetQuestion(questionIndex).content[2];
            btnAnswerD.Text = quizService.GetQuestion(questionIndex).content[3];
        }

        private void selectAnswer(int answer) {
            var question = quizService.GetQuestion(questionIndex);
            if (answer == question.correct)
            {
                //lbScore.Items[questionIndex].
                
                if(questionIndex == 14)
                {
                    MessageBox.Show($"You won. You are now a millionaire.");
                    Close();
                }
                else
                {
                lbScore.SetItemChecked(13 - questionIndex + 1, true);
                lbScore.SelectedItems.Add(lbScore.Items[13 - questionIndex]);
                questionIndex++;
                loadQuestion();
                }
            }
            else
            {
                MessageBox.Show($"You lost. The correct answer was {question.content[question.correct]}");
                Close();
            }
        }

        private void btnAnswerA_Click(object sender, EventArgs e)
        {
            selectAnswer(0);
        }

        private void btnAnswerB_Click(object sender, EventArgs e)
        {
            selectAnswer(1);

        }

        private void btnAnswerC_Click(object sender, EventArgs e)
        {
            selectAnswer(2);

        }

        private void btnAnswerD_Click(object sender, EventArgs e)
        {
            selectAnswer(3);
        }
    }
}
