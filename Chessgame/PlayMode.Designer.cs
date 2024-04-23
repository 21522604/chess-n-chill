using System.Windows.Forms;

namespace Chessgame
{
    partial class PlayMode
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayMode));
            HomeButton = new Button();
            Bar = new PictureBox();
            RankingButton = new Button();
            HumanPlayButton = new Button();
            AIPlayButton = new Button();
            BackButton = new Button();
            ChessBoard = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Bar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ChessBoard).BeginInit();
            SuspendLayout();
            // 
            // HomeButton
            // 
            HomeButton.BackColor = Color.DimGray;
            HomeButton.FlatAppearance.BorderSize = 0;
            HomeButton.FlatAppearance.MouseOverBackColor = Color.DimGray;
            HomeButton.FlatStyle = FlatStyle.Flat;
            HomeButton.Image = Properties.Resources.logo;
            HomeButton.Location = new Point(34, 14);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(256, 68);
            HomeButton.TabIndex = 2;
            HomeButton.UseVisualStyleBackColor = false;
            HomeButton.Click += HomeButton_Click;
            // 
            // Bar
            // 
            Bar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Bar.BackColor = Color.DimGray;
            Bar.BackgroundImageLayout = ImageLayout.None;
            Bar.Location = new Point(0, 0);
            Bar.Name = "Bar";
            Bar.Size = new Size(1333, 93);
            Bar.SizeMode = PictureBoxSizeMode.CenterImage;
            Bar.TabIndex = 3;
            Bar.TabStop = false;
            // 
            // RankingButton
            // 
            RankingButton.BackColor = Color.DimGray;
            RankingButton.FlatAppearance.BorderSize = 0;
            RankingButton.FlatAppearance.MouseOverBackColor = Color.DimGray;
            RankingButton.FlatStyle = FlatStyle.Flat;
            RankingButton.Image = Properties.Resources.Ranking;
            RankingButton.Location = new Point(345, 10);
            RankingButton.Name = "RankingButton";
            RankingButton.Size = new Size(239, 72);
            RankingButton.TabIndex = 4;
            RankingButton.UseMnemonic = false;
            RankingButton.UseVisualStyleBackColor = false;
            RankingButton.Click += RankingButton_Click;
            // 
            // HumanPlayButton
            // 
            HumanPlayButton.FlatAppearance.BorderSize = 0;
            HumanPlayButton.FlatAppearance.MouseOverBackColor = Color.DimGray;
            HumanPlayButton.FlatStyle = FlatStyle.Flat;
            HumanPlayButton.Font = new Font("Segoe UI", 40F);
            HumanPlayButton.ForeColor = SystemColors.Window;
            HumanPlayButton.Location = new Point(139, 331);
            HumanPlayButton.Name = "HumanPlayButton";
            HumanPlayButton.Size = new Size(545, 111);
            HumanPlayButton.TabIndex = 6;
            HumanPlayButton.Text = "Đánh với người";
            HumanPlayButton.TextAlign = ContentAlignment.MiddleLeft;
            HumanPlayButton.UseVisualStyleBackColor = true;
            HumanPlayButton.Click += HumanPlayButton_Click;
            // 
            // AIPlayButton
            // 
            AIPlayButton.FlatAppearance.BorderSize = 0;
            AIPlayButton.FlatAppearance.MouseOverBackColor = Color.DimGray;
            AIPlayButton.FlatStyle = FlatStyle.Flat;
            AIPlayButton.Font = new Font("Segoe UI", 40F);
            AIPlayButton.ForeColor = SystemColors.Window;
            AIPlayButton.Location = new Point(139, 436);
            AIPlayButton.Name = "AIPlayButton";
            AIPlayButton.Size = new Size(545, 111);
            AIPlayButton.TabIndex = 7;
            AIPlayButton.Text = "Đánh với máy";
            AIPlayButton.TextAlign = ContentAlignment.MiddleLeft;
            AIPlayButton.UseVisualStyleBackColor = true;
            AIPlayButton.Click += AIPlayButton_Click;
            // 
            // BackButton
            // 
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatAppearance.MouseOverBackColor = Color.DimGray;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Segoe UI", 40F);
            BackButton.ForeColor = SystemColors.Window;
            BackButton.Location = new Point(139, 541);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(545, 111);
            BackButton.TabIndex = 8;
            BackButton.Text = "Quay lại";
            BackButton.TextAlign = ContentAlignment.MiddleLeft;
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // ChessBoard
            // 
            ChessBoard.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ChessBoard.Image = Properties.Resources.ChessBoard;
            ChessBoard.Location = new Point(650, 264);
            ChessBoard.Name = "ChessBoard";
            ChessBoard.Size = new Size(564, 592);
            ChessBoard.TabIndex = 9;
            ChessBoard.TabStop = false;
            // 
            // PlayMode
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1331, 844);
            Controls.Add(ChessBoard);
            Controls.Add(BackButton);
            Controls.Add(AIPlayButton);
            Controls.Add(HumanPlayButton);
            Controls.Add(RankingButton);
            Controls.Add(HomeButton);
            Controls.Add(Bar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PlayMode";
            Text = "Home";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)Bar).EndInit();
            ((System.ComponentModel.ISupportInitialize)ChessBoard).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button HomeButton;
        private PictureBox Bar;
        private Button RankingButton;
        private Button HumanPlayButton;
        private Button AIPlayButton;
        private Button BackButton;
        private PictureBox ChessBoard;
    }
}
