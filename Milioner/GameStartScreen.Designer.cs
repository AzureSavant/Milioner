
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameStartScreen));
            this.StartScreenBackground = new System.Windows.Forms.PictureBox();
            this.PlayButton = new System.Windows.Forms.Button();
            this.ExitGameButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StartScreenBackground)).BeginInit();
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
            this.PlayButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.PlayButton.FlatAppearance.BorderSize = 2;
            this.PlayButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.PlayButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayButton.Location = new System.Drawing.Point(128, 297);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(554, 39);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.Text = "START GAME";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // ExitGameButton
            // 
            this.ExitGameButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ExitGameButton.FlatAppearance.BorderSize = 2;
            this.ExitGameButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.ExitGameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ExitGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitGameButton.Location = new System.Drawing.Point(128, 342);
            this.ExitGameButton.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.ExitGameButton.Name = "ExitGameButton";
            this.ExitGameButton.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.ExitGameButton.Size = new System.Drawing.Size(554, 44);
            this.ExitGameButton.TabIndex = 2;
            this.ExitGameButton.Text = "EXIT";
            this.ExitGameButton.UseVisualStyleBackColor = true;
            this.ExitGameButton.Click += new System.EventHandler(this.ExitGameButton_Click);
            // 
            // GameStartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitGameButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.StartScreenBackground);
            this.Name = "GameStartScreen";
            this.Text = "Milioner";
            ((System.ComponentModel.ISupportInitialize)(this.StartScreenBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox StartScreenBackground;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button ExitGameButton;
    }
}