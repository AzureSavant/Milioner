namespace Milioner
{
    partial class Form1
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
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.btnAnswerA = new System.Windows.Forms.Button();
            this.btnAnswerB = new System.Windows.Forms.Button();
            this.btnAnswerC = new System.Windows.Forms.Button();
            this.btnAnswerD = new System.Windows.Forms.Button();
            this.lbScore = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // tbQuestion
            // 
            this.tbQuestion.Location = new System.Drawing.Point(164, 44);
            this.tbQuestion.Multiline = true;
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.Size = new System.Drawing.Size(241, 81);
            this.tbQuestion.TabIndex = 0;
            // 
            // btnAnswerA
            // 
            this.btnAnswerA.Location = new System.Drawing.Point(141, 250);
            this.btnAnswerA.Name = "btnAnswerA";
            this.btnAnswerA.Size = new System.Drawing.Size(105, 47);
            this.btnAnswerA.TabIndex = 1;
            this.btnAnswerA.Text = "button1";
            this.btnAnswerA.UseVisualStyleBackColor = true;
            this.btnAnswerA.Click += new System.EventHandler(this.btnAnswerA_Click);
            // 
            // btnAnswerB
            // 
            this.btnAnswerB.Location = new System.Drawing.Point(305, 250);
            this.btnAnswerB.Name = "btnAnswerB";
            this.btnAnswerB.Size = new System.Drawing.Size(121, 47);
            this.btnAnswerB.TabIndex = 2;
            this.btnAnswerB.Text = "button2";
            this.btnAnswerB.UseVisualStyleBackColor = true;
            this.btnAnswerB.Click += new System.EventHandler(this.btnAnswerB_Click);
            // 
            // btnAnswerC
            // 
            this.btnAnswerC.Location = new System.Drawing.Point(141, 323);
            this.btnAnswerC.Name = "btnAnswerC";
            this.btnAnswerC.Size = new System.Drawing.Size(105, 47);
            this.btnAnswerC.TabIndex = 3;
            this.btnAnswerC.Text = "button3";
            this.btnAnswerC.UseVisualStyleBackColor = true;
            this.btnAnswerC.Click += new System.EventHandler(this.btnAnswerC_Click);
            // 
            // btnAnswerD
            // 
            this.btnAnswerD.Location = new System.Drawing.Point(305, 323);
            this.btnAnswerD.Name = "btnAnswerD";
            this.btnAnswerD.Size = new System.Drawing.Size(121, 47);
            this.btnAnswerD.TabIndex = 4;
            this.btnAnswerD.Text = "button4";
            this.btnAnswerD.UseVisualStyleBackColor = true;
            this.btnAnswerD.Click += new System.EventHandler(this.btnAnswerD_Click);
            // 
            // lbScore
            // 
            this.lbScore.Enabled = false;
            this.lbScore.FormattingEnabled = true;
            this.lbScore.Location = new System.Drawing.Point(505, 59);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(256, 344);
            this.lbScore.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.btnAnswerD);
            this.Controls.Add(this.btnAnswerC);
            this.Controls.Add(this.btnAnswerB);
            this.Controls.Add(this.btnAnswerA);
            this.Controls.Add(this.tbQuestion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbQuestion;
        private System.Windows.Forms.Button btnAnswerA;
        private System.Windows.Forms.Button btnAnswerB;
        private System.Windows.Forms.Button btnAnswerC;
        private System.Windows.Forms.Button btnAnswerD;
        private System.Windows.Forms.CheckedListBox lbScore;
    }
}

