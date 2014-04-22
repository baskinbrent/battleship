namespace bs
{
    partial class GameControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.brdComputer = new Battleship.BoardControl();
            this.brdPlayer = new Battleship.BoardControl();
            this.SuspendLayout();
            // 
            // brdComputer
            // 
            this.brdComputer.BackColor = System.Drawing.Color.Black;
            this.brdComputer.Board = null;
            this.brdComputer.IsPlayer = false;
            this.brdComputer.Location = new System.Drawing.Point(4, 4);
            this.brdComputer.Name = "brdComputer";
            this.brdComputer.Size = new System.Drawing.Size(200, 200);
            this.brdComputer.TabIndex = 0;
            // 
            // brdPlayer
            // 
            this.brdPlayer.BackColor = System.Drawing.Color.Black;
            this.brdPlayer.Board = null;
            this.brdPlayer.IsPlayer = false;
            this.brdPlayer.Location = new System.Drawing.Point(4, 211);
            this.brdPlayer.Name = "brdPlayer";
            this.brdPlayer.Size = new System.Drawing.Size(200, 200);
            this.brdPlayer.TabIndex = 1;
            // 
            // GameControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.brdPlayer);
            this.Controls.Add(this.brdComputer);
            this.Name = "GameControl";
            this.Size = new System.Drawing.Size(210, 418);
            this.ResumeLayout(false);

        }

        #endregion

        private Battleship.BoardControl brdComputer;
        private Battleship.BoardControl brdPlayer;
    }
}
