﻿namespace Battleship
{
    partial class Battleship
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
            this.btnGameStatistics = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
<<<<<<< HEAD
            this.btnHowToPlay = new System.Windows.Forms.Button();
            this.gameViewer = new bs.GameControl();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
=======
            this.gameViewer = new bs.GameControl();
            this.btnHowToPlay = new System.Windows.Forms.Button();
>>>>>>> 44fce8be4505a9e9b72fb8466776dab1ff2fa948
            this.SuspendLayout();
            // 
            // btnGameStatistics
            // 
<<<<<<< HEAD
            this.btnGameStatistics.Location = new System.Drawing.Point(57, 536);
=======
            this.btnGameStatistics.Location = new System.Drawing.Point(57, 497);
>>>>>>> 44fce8be4505a9e9b72fb8466776dab1ff2fa948
            this.btnGameStatistics.Name = "btnGameStatistics";
            this.btnGameStatistics.Size = new System.Drawing.Size(111, 23);
            this.btnGameStatistics.TabIndex = 1;
            this.btnGameStatistics.Text = "Game Statistics";
            this.btnGameStatistics.UseVisualStyleBackColor = true;
            this.btnGameStatistics.Click += new System.EventHandler(this.btnGameStatistics_Click);
            // 
            // btnNewGame
            // 
<<<<<<< HEAD
            this.btnNewGame.Location = new System.Drawing.Point(57, 498);
=======
            this.btnNewGame.Location = new System.Drawing.Point(57, 456);
>>>>>>> 44fce8be4505a9e9b72fb8466776dab1ff2fa948
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(111, 23);
            this.btnNewGame.TabIndex = 2;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            // 
<<<<<<< HEAD
            // btnHowToPlay
            // 
            this.btnHowToPlay.Location = new System.Drawing.Point(57, 575);
            this.btnHowToPlay.Name = "btnHowToPlay";
            this.btnHowToPlay.Size = new System.Drawing.Size(111, 23);
            this.btnHowToPlay.TabIndex = 3;
            this.btnHowToPlay.Text = "How To Play";
            this.btnHowToPlay.UseVisualStyleBackColor = true;
            this.btnHowToPlay.Click += new System.EventHandler(this.btnHowToPlay_Click);
            // 
=======
>>>>>>> 44fce8be4505a9e9b72fb8466776dab1ff2fa948
            // gameViewer
            // 
            this.gameViewer.Game = null;
            this.gameViewer.Location = new System.Drawing.Point(13, 13);
            this.gameViewer.Name = "gameViewer";
            this.gameViewer.Size = new System.Drawing.Size(210, 418);
            this.gameViewer.TabIndex = 0;
            // 
<<<<<<< HEAD
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(59, 460);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(100, 20);
            this.txtPlayerName.TabIndex = 5;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(12, 463);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(41, 13);
            this.lblPlayerName.TabIndex = 6;
            this.lblPlayerName.Text = "Name :";
=======
            // btnHowToPlay
            // 
            this.btnHowToPlay.Location = new System.Drawing.Point(57, 535);
            this.btnHowToPlay.Name = "btnHowToPlay";
            this.btnHowToPlay.Size = new System.Drawing.Size(111, 23);
            this.btnHowToPlay.TabIndex = 3;
            this.btnHowToPlay.Text = "How To Play";
            this.btnHowToPlay.UseVisualStyleBackColor = true;
            this.btnHowToPlay.Click += new System.EventHandler(this.btnHowToPlay_Click);
>>>>>>> 44fce8be4505a9e9b72fb8466776dab1ff2fa948
            // 
            // Battleship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(229, 610);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.txtPlayerName);
=======
            this.ClientSize = new System.Drawing.Size(229, 581);
>>>>>>> 44fce8be4505a9e9b72fb8466776dab1ff2fa948
            this.Controls.Add(this.btnHowToPlay);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnGameStatistics);
            this.Controls.Add(this.gameViewer);
            this.Name = "Battleship";
            this.Text = "BATTLESHIP";
            this.ResumeLayout(false);
<<<<<<< HEAD
            this.PerformLayout();
=======
>>>>>>> 44fce8be4505a9e9b72fb8466776dab1ff2fa948

        }

        #endregion

        private bs.GameControl gameViewer;
        private System.Windows.Forms.Button btnGameStatistics;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnHowToPlay;
<<<<<<< HEAD
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label lblPlayerName;
=======
>>>>>>> 44fce8be4505a9e9b72fb8466776dab1ff2fa948
    }
}

