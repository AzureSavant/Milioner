
namespace Milioner
{
    partial class GameStartScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameStartScreen));
            this.StartScreenBackground = new System.Windows.Forms.PictureBox();
            this.PlayButton = new System.Windows.Forms.Button();
            this.btnLoadGame = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StartScreenBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // StartScreenBackground
            // 
            this.StartScreenBackground.Image = ((System.Drawing.Image)(resources.GetObject("StartScreenBackground.Image")));
            this.StartScreenBackground.Location = new System.Drawing.Point(0, 0);
            this.StartScreenBackground.Name = "StartScreenBackground";
            this.StartScreenBackground.Size = new System.Drawing.Size(810, 517);
            this.StartScreenBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.StartScreenBackground.TabIndex = 0;
            this.StartScreenBackground.TabStop = false;
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.Navy;
            this.PlayButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.PlayButton.FlatAppearance.BorderSize = 2;
            this.PlayButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.PlayButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayButton.ForeColor = System.Drawing.SystemColors.Control;
            this.PlayButton.Location = new System.Drawing.Point(126, 296);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(284, 44);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.Text = "START GAME";
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // btnLoadGame
            // 
            this.btnLoadGame.BackColor = System.Drawing.Color.Navy;
            this.btnLoadGame.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnLoadGame.FlatAppearance.BorderSize = 2;
            this.btnLoadGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.btnLoadGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnLoadGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadGame.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLoadGame.Location = new System.Drawing.Point(410, 296);
            this.btnLoadGame.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.btnLoadGame.Name = "btnLoadGame";
            this.btnLoadGame.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnLoadGame.Size = new System.Drawing.Size(277, 44);
            this.btnLoadGame.TabIndex = 2;
            this.btnLoadGame.Text = "LOAD GAME";
            this.btnLoadGame.UseVisualStyleBackColor = false;
            this.btnLoadGame.Click += new System.EventHandler(this.btnLoadGame_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(126, 346);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.button1.Size = new System.Drawing.Size(561, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GameStartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLoadGame);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.StartScreenBackground);
            this.KeyPreview = true;
            this.Name = "GameStartScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Milioner";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameStartScreen_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.StartScreenBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox StartScreenBackground;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button btnLoadGame;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button1;
    }
}