
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
            this.ExitGameButton = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.StartScreenBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // StartScreenBackground
            // 
            this.StartScreenBackground.Image = ((System.Drawing.Image)(resources.GetObject("StartScreenBackground.Image")));
            this.StartScreenBackground.Location = new System.Drawing.Point(0, 0);
            this.StartScreenBackground.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartScreenBackground.Name = "StartScreenBackground";
            this.StartScreenBackground.Size = new System.Drawing.Size(1080, 636);
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
            this.PlayButton.Location = new System.Drawing.Point(171, 366);
            this.PlayButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(739, 48);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.Text = "START GAME";
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // ExitGameButton
            // 
            this.ExitGameButton.BackColor = System.Drawing.Color.Navy;
            this.ExitGameButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ExitGameButton.FlatAppearance.BorderSize = 2;
            this.ExitGameButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.ExitGameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.ExitGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitGameButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ExitGameButton.Location = new System.Drawing.Point(171, 421);
            this.ExitGameButton.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.ExitGameButton.Name = "ExitGameButton";
            this.ExitGameButton.Padding = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.ExitGameButton.Size = new System.Drawing.Size(739, 54);
            this.ExitGameButton.TabIndex = 2;
            this.ExitGameButton.Text = "EXIT";
            this.ExitGameButton.UseVisualStyleBackColor = false;
            this.ExitGameButton.Click += new System.EventHandler(this.ExitGameButton_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // GameStartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ExitGameButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.StartScreenBackground);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GameStartScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Milioner";
            ((System.ComponentModel.ISupportInitialize)(this.StartScreenBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox StartScreenBackground;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button ExitGameButton;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}