using Milioner.Models;
using Milioner.Models.ListBoxItems;
using Milioner.Services;
using Milioner.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static Milioner.Utils.Util;

namespace Milioner
{
    public partial class GameScreen : Form
    {
        readonly QuizService quizService = new QuizService();
        GameState gameState;
        
        WMPLib.WindowsMediaPlayer _wPlayer;

        List<Keys> keyBuffer = new List<Keys>();

        public GameScreen(WMPLib.WindowsMediaPlayer wplayer)
        {
            WMPLib.WindowsMediaPlayer _wPlayer;
            List<Keys> keyBuffer = new List<Keys>();
            this._wPlayer = wplayer;
            Util.PlayAudioFile(this._wPlayer, Util.AudioFile.LetsPlay);
            InitializeComponent();
            gameState = new GameState
            {
                AskAFriendAvailable = true,
                FiftyFiftyAvailable = true,
                AskTheAudienceAvailable = true,
                QuestionIndex = 0,
                GameId = quizService.QuestionSet
            };
            loadQuestion();
            for (var a = 14; a >= 0; a--)
            {
                if (a >= 10)
                    addEntry(a, 100);
                if (a < 10 && a > 5)
                    addEntry(a, 500);
                if (a <= 5)
                    addEntry(a, 1000);
            }

            void addEntry(int index, int multiplier)
            {
                lbScore.Items.Add(new ScoreEntry
                {
                    Number = index + 1,
                    Price = (index + 1) * multiplier
                });
            }

            lbScore.SelectedIndex = 14 - gameState.QuestionIndex;
        }

        private void loadQuestion()
        {
            tbQuestion.Text = quizService.GetQuestion(gameState.QuestionIndex).question;
            btnAnswerA.Text = quizService.GetQuestion(gameState.QuestionIndex).content[0];
            btnAnswerB.Text = quizService.GetQuestion(gameState.QuestionIndex).content[1];
            btnAnswerC.Text = quizService.GetQuestion(gameState.QuestionIndex).content[2];
            btnAnswerD.Text = quizService.GetQuestion(gameState.QuestionIndex).content[3];
            btnAnswerA.Enabled = true;
            btnAnswerB.Enabled = true;
            btnAnswerC.Enabled = true;
            btnAnswerD.Enabled = true;
        }

        private void selectAnswer(int answer)
        {
            var question = quizService.GetQuestion(gameState.QuestionIndex);
            if (answer == question.correct)
            {
                //lbScore.Items[questionIndex].

                if (gameState.QuestionIndex == 14)
                {
                    MessageBox.Show($"You won. You are now a millionaire.");
                    Close();
                }
                else
                {
                    PlayAudioFile(_wPlayer, AudioFile.CorrectAnswer);
                    lbScore.SetItemChecked(13 - gameState.QuestionIndex + 1, true);
                    lbScore.SelectedItems.Add(lbScore.Items[13 - gameState.QuestionIndex]);
                    gameState.QuestionIndex++;
                    loadQuestion();
                }
            }
            else
            {
                PlayAudioFile(_wPlayer, AudioFile.WrongAnswer);
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

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AskAudienceButton_Click(object sender, EventArgs e)
        {
            quizService.AskAudience(gameState.QuestionIndex);
            Form chartForm = new ChartForm(quizService.AskAudience(gameState.QuestionIndex));
            chartForm.Location = this.Location;
            chartForm.StartPosition = FormStartPosition.Manual;
            chartForm.FormClosed += delegate { this.Show(); };
            chartForm.Show();
            btnAskAudience.Enabled = false;
            gameState.AskTheAudienceAvailable = false;
        }

        private void AskAFriendButton_Click(object sender, EventArgs e)
        {
            PlayAudioFile(_wPlayer, AudioFile.PhoneAFriend);
            var answer = quizService.CallAFriend(gameState.QuestionIndex);
            MessageBox.Show($"I believe the correct answer is {GetAnswerLetter(answer.AnswerIndex)}, {quizService.GetQuestion(gameState.QuestionIndex).content[answer.AnswerIndex]}, I am {answer.Confidence}% sure");
            btnAskAFriend.Enabled = false;
            gameState.AskAFriendAvailable = false;
            _wPlayer.controls.stop();
        }

        private void FiftyFiftyButton_Click(object sender, EventArgs e)
        {
            var answer = quizService.FiftyFifty(gameState.QuestionIndex);
            if (!answer.Contains(0))
            {
                btnAnswerA.Text = "";
                btnAnswerA.Enabled = false;
            }
            if (!answer.Contains(1))
            {
                btnAnswerB.Text = "";
                btnAnswerB.Enabled = false;
            }
            if (!answer.Contains(2))
            {
                btnAnswerC.Text = "";
                btnAnswerC.Enabled = false;
            }
            if (!answer.Contains(3))
            {
                btnAnswerD.Text = "";
                btnAnswerD.Enabled = false;
            }
            gameState.FiftyFiftyAvailable = false;
            btnFiftyFifty.Enabled = false;
        }

        private void GameScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == CheatCode.ElementAt(keyBuffer.Count))
            {
                keyBuffer.Add(e.KeyCode);
            }
            else
            {
                keyBuffer = new List<Keys>();
            }
            if (Enumerable.SequenceEqual(keyBuffer, CheatCode))
            {
                selectAnswer(quizService.Questions[gameState.QuestionIndex].correct);
                keyBuffer = new List<Keys>();

            }
        }
    }
}
