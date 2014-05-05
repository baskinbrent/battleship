namespace Battleship
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
            this.btnHowToPlay = new System.Windows.Forms.Button();
            this.gameViewer = new bs.GameControl();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGameStatistics
            // 
            this.btnGameStatistics.Location = new System.Drawing.Point(57, 485);
            this.btnGameStatistics.Name = "btnGameStatistics";
            this.btnGameStatistics.Size = new System.Drawing.Size(111, 23);
            this.btnGameStatistics.TabIndex = 1;
            this.btnGameStatistics.Text = "Game Statistics";
            this.btnGameStatistics.UseVisualStyleBackColor = true;
            this.btnGameStatistics.Click += new System.EventHandler(this.btnGameStatistics_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(57, 456);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(111, 23);
            this.btnNewGame.TabIndex = 2;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnHowToPlay
            // 
            this.btnHowToPlay.Location = new System.Drawing.Point(57, 514);
            this.btnHowToPlay.Name = "btnHowToPlay";
            this.btnHowToPlay.Size = new System.Drawing.Size(111, 23);
            this.btnHowToPlay.TabIndex = 3;
            this.btnHowToPlay.Text = "How To Play";
            this.btnHowToPlay.UseVisualStyleBackColor = true;
            this.btnHowToPlay.Click += new System.EventHandler(this.btnHowToPlay_Click);
            // 
            // gameViewer
            // 
            this.gameViewer.Game = null;
            this.gameViewer.Location = new System.Drawing.Point(13, 13);
            this.gameViewer.Name = "gameViewer";
            this.gameViewer.Size = new System.Drawing.Size(210, 418);
            this.gameViewer.TabIndex = 0;
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(57, 430);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(111, 20);
            this.txtPlayerName.TabIndex = 5;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(12, 433);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(41, 13);
            this.lblPlayerName.TabIndex = 6;
            this.lblPlayerName.Text = "Name :";
            // 
            // Battleship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 545);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.btnHowToPlay);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnGameStatistics);
            this.Controls.Add(this.gameViewer);
            this.Name = "Battleship";
            this.Text = "BATTLESHIP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Battleship_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bs.GameControl gameViewer;
        private System.Windows.Forms.Button btnGameStatistics;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnHowToPlay;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label lblPlayerName;
    }
}

