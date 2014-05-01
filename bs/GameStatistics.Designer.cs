namespace bs
{
    partial class frmGameStatistics
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lstGameStats = new System.Windows.Forms.ListView();
            this.colRank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPlayerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLeastNumTurns = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNumWins = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNumLosses = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lstGameStats
            // 
            this.lstGameStats.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colRank,
            this.colPlayerName,
            this.colLeastNumTurns,
            this.colNumWins,
            this.colNumLosses});
            this.lstGameStats.FullRowSelect = true;
            this.lstGameStats.GridLines = true;
            this.lstGameStats.HideSelection = false;
            this.lstGameStats.Location = new System.Drawing.Point(90, 98);
            this.lstGameStats.MultiSelect = false;
            this.lstGameStats.Name = "lstGameStats";
            this.lstGameStats.Size = new System.Drawing.Size(515, 274);
            this.lstGameStats.TabIndex = 14;
            this.lstGameStats.UseCompatibleStateImageBehavior = false;
            this.lstGameStats.View = System.Windows.Forms.View.Details;
            // 
            // colRank
            // 
            this.colRank.Text = "Rank (ID?)";
            this.colRank.Width = 65;
            // 
            // colPlayerName
            // 
            this.colPlayerName.Text = "Player Name";
            this.colPlayerName.Width = 125;
            // 
            // colLeastNumTurns
            // 
            this.colLeastNumTurns.Text = "Least Number of Turns";
            this.colLeastNumTurns.Width = 125;
            // 
            // colNumWins
            // 
            this.colNumWins.Text = "Number of Wins";
            this.colNumWins.Width = 90;
            // 
            // colNumLosses
            // 
            this.colNumLosses.Text = "Number of Losses";
            this.colNumLosses.Width = 110;
            // 
            // frmGameStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 455);
            this.Controls.Add(this.lstGameStats);
            this.Name = "frmGameStatistics";
            this.Text = "Game Statistics";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader colPlayerName;
        private System.Windows.Forms.ColumnHeader colLeastNumTurns;
        private System.Windows.Forms.ColumnHeader colRank;
        private System.Windows.Forms.ColumnHeader colNumWins;
        private System.Windows.Forms.ColumnHeader colNumLosses;
        internal System.Windows.Forms.ListView lstGameStats;
    }
}