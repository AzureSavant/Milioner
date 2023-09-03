namespace Milioner
{
    partial class GameScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameScreen));
            this.btnAnswerA = new System.Windows.Forms.Button();
            this.btnAnswerB = new System.Windows.Forms.Button();
            this.btnAnswerC = new System.Windows.Forms.Button();
            this.btnAnswerD = new System.Windows.Forms.Button();
            this.lbScore = new System.Windows.Forms.CheckedListBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.tbQuestion = new System.Windows.Forms.RichTextBox();
            this.AskAudienceButton = new System.Windows.Forms.Button();
            this.AskAFriendButton = new System.Windows.Forms.Button();
            this.FiftyFiftyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAnswerA
            // 
            this.btnAnswerA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(1)))), ((int)(((byte)(110)))));
            this.btnAnswerA.FlatAppearance.BorderSize = 0;
            this.btnAnswerA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnswerA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswerA.ForeColor = System.Drawing.Color.White;
            this.btnAnswerA.Location = new System.Drawing.Point(130, 487);
            this.btnAnswerA.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnswerA.Name = "btnAnswerA";
            this.btnAnswerA.Size = new System.Drawing.Size(344, 28);
            this.btnAnswerA.TabIndex = 1;
            this.btnAnswerA.Text = "button1";
            this.btnAnswerA.UseVisualStyleBackColor = false;
            this.btnAnswerA.Click += new System.EventHandler(this.btnAnswerA_Click);
            // 
            // btnAnswerB
            // 
            this.btnAnswerB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(1)))), ((int)(((byte)(110)))));
            this.btnAnswerB.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnAnswerB.FlatAppearance.BorderSize = 0;
            this.btnAnswerB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnswerB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswerB.ForeColor = System.Drawing.Color.White;
            this.btnAnswerB.Location = new System.Drawing.Point(546, 484);
            this.btnAnswerB.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnswerB.Name = "btnAnswerB";
            this.btnAnswerB.Size = new System.Drawing.Size(344, 34);
            this.btnAnswerB.TabIndex = 2;
            this.btnAnswerB.Text = "button2";
            this.btnAnswerB.UseVisualStyleBackColor = false;
            this.btnAnswerB.Click += new System.EventHandler(this.btnAnswerB_Click);
            // 
            // btnAnswerC
            // 
            this.btnAnswerC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(1)))), ((int)(((byte)(110)))));
            this.btnAnswerC.FlatAppearance.BorderSize = 0;
            this.btnAnswerC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnswerC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswerC.ForeColor = System.Drawing.Color.White;
            this.btnAnswerC.Location = new System.Drawing.Point(130, 526);
            this.btnAnswerC.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnswerC.Name = "btnAnswerC";
            this.btnAnswerC.Size = new System.Drawing.Size(344, 34);
            this.btnAnswerC.TabIndex = 3;
            this.btnAnswerC.Text = "button3";
            this.btnAnswerC.UseVisualStyleBackColor = false;
            this.btnAnswerC.Click += new System.EventHandler(this.btnAnswerC_Click);
            // 
            // btnAnswerD
            // 
            this.btnAnswerD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(1)))), ((int)(((byte)(110)))));
            this.btnAnswerD.FlatAppearance.BorderSize = 0;
            this.btnAnswerD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnswerD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswerD.ForeColor = System.Drawing.Color.White;
            this.btnAnswerD.Location = new System.Drawing.Point(546, 526);
            this.btnAnswerD.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnswerD.Name = "btnAnswerD";
            this.btnAnswerD.Size = new System.Drawing.Size(344, 34);
            this.btnAnswerD.TabIndex = 4;
            this.btnAnswerD.Text = "button4";
            this.btnAnswerD.UseVisualStyleBackColor = false;
            this.btnAnswerD.Click += new System.EventHandler(this.btnAnswerD_Click);
            // 
            // lbScore
            // 
            this.lbScore.BackColor = System.Drawing.Color.DarkBlue;
            this.lbScore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbScore.Enabled = false;
            this.lbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.ForeColor = System.Drawing.Color.White;
            this.lbScore.FormattingEnabled = true;
            this.lbScore.Location = new System.Drawing.Point(335, 29);
            this.lbScore.Margin = new System.Windows.Forms.Padding(2);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(372, 336);
            this.lbScore.TabIndex = 5;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(226, 310);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(90, 43);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Exit To Menu";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // tbQuestion
            // 
            this.tbQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(1)))), ((int)(((byte)(110)))));
            this.tbQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQuestion.ForeColor = System.Drawing.Color.White;
            this.tbQuestion.Location = new System.Drawing.Point(110, 400);
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.ReadOnly = true;
            this.tbQuestion.Size = new System.Drawing.Size(780, 69);
            this.tbQuestion.TabIndex = 7;
            this.tbQuestion.Text = "";
            // 
            // AskAudienceButton
            // 
            this.AskAudienceButton.BackColor = System.Drawing.Color.Transparent;
            this.AskAudienceButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AskAudienceButton.FlatAppearance.BorderSize = 4;
            this.AskAudienceButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AskAudienceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AskAudienceButton.ForeColor = System.Drawing.Color.Transparent;
            this.AskAudienceButton.Location = new System.Drawing.Point(222, 48);
            this.AskAudienceButton.Name = "AskAudienceButton";
            this.AskAudienceButton.Size = new System.Drawing.Size(94, 46);
            this.AskAudienceButton.TabIndex = 8;
            this.AskAudienceButton.Text = "AskAudienceButton";
            this.AskAudienceButton.UseVisualStyleBackColor = false;
            // 
            // AskAFriendButton
            // 
            this.AskAFriendButton.BackColor = System.Drawing.Color.Transparent;
            this.AskAFriendButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AskAFriendButton.FlatAppearance.BorderSize = 4;
            this.AskAFriendButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AskAFriendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AskAFriendButton.ForeColor = System.Drawing.Color.White;
            this.AskAFriendButton.Location = new System.Drawing.Point(222, 117);
            this.AskAFriendButton.Name = "AskAFriendButton";
            this.AskAFriendButton.Size = new System.Drawing.Size(94, 45);
            this.AskAFriendButton.TabIndex = 9;
            this.AskAFriendButton.Text = "AskAFriendButton";
            this.AskAFriendButton.UseVisualStyleBackColor = false;
            // 
            // FiftyFiftyButton
            // 
            this.FiftyFiftyButton.BackColor = System.Drawing.Color.Transparent;
            this.FiftyFiftyButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.FiftyFiftyButton.FlatAppearance.BorderSize = 4;
            this.FiftyFiftyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FiftyFiftyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiftyFiftyButton.ForeColor = System.Drawing.Color.White;
            this.FiftyFiftyButton.Location = new System.Drawing.Point(222, 191);
            this.FiftyFiftyButton.Name = "FiftyFiftyButton";
            this.FiftyFiftyButton.Size = new System.Drawing.Size(94, 41);
            this.FiftyFiftyButton.TabIndex = 10;
            this.FiftyFiftyButton.Text = "FiftyFiftyButton";
            this.FiftyFiftyButton.UseVisualStyleBackColor = false;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(972, 576);
            this.Controls.Add(this.FiftyFiftyButton);
            this.Controls.Add(this.AskAFriendButton);
            this.Controls.Add(this.AskAudienceButton);
            this.Controls.Add(this.tbQuestion);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.btnAnswerD);
            this.Controls.Add(this.btnAnswerC);
            this.Controls.Add(this.btnAnswerB);
            this.Controls.Add(this.btnAnswerA);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAnswerA;
        private System.Windows.Forms.Button btnAnswerB;
        private System.Windows.Forms.Button btnAnswerC;
        private System.Windows.Forms.Button btnAnswerD;
        private System.Windows.Forms.CheckedListBox lbScore;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.RichTextBox tbQuestion;
        private System.Windows.Forms.Button AskAudienceButton;
        private System.Windows.Forms.Button AskAFriendButton;
        private System.Windows.Forms.Button FiftyFiftyButton;
    }
}

