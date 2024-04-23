using System.Windows.Forms;

namespace Chessgame
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            HomeButton = new Button();
            Bar = new PictureBox();
            RankingButton = new Button();
            PlayButton = new Button();
            SettingButton = new Button();
            AccountButton = new Button();
            ExitButton = new Button();
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
            // PlayButton
            // 
            PlayButton.FlatAppearance.BorderSize = 0;
            PlayButton.FlatAppearance.MouseOverBackColor = Color.DimGray;
            PlayButton.FlatStyle = FlatStyle.Flat;
            PlayButton.Font = new Font("Segoe UI", 40F);
            PlayButton.ForeColor = SystemColors.Window;
            PlayButton.Location = new Point(139, 331);
            PlayButton.Name = "PlayButton";
            PlayButton.Size = new Size(405, 111);
            PlayButton.TabIndex = 5;
            PlayButton.Text = "Chơi";
            PlayButton.TextAlign = ContentAlignment.MiddleLeft;
            PlayButton.UseVisualStyleBackColor = true;
            PlayButton.Click += PlayButton_Click;
            // 
            // SettingButton
            // 
            SettingButton.FlatAppearance.BorderSize = 0;
            SettingButton.FlatAppearance.MouseOverBackColor = Color.DimGray;
            SettingButton.FlatStyle = FlatStyle.Flat;
            SettingButton.Font = new Font("Segoe UI", 40F);
            SettingButton.ForeColor = SystemColors.Window;
            SettingButton.Location = new Point(139, 436);
            SettingButton.Name = "SettingButton";
            SettingButton.Size = new Size(405, 111);
            SettingButton.TabIndex = 6;
            SettingButton.Text = "Cài đặt";
            SettingButton.TextAlign = ContentAlignment.MiddleLeft;
            SettingButton.UseVisualStyleBackColor = true;
            SettingButton.Click += SettingButton_Click;
            // 
            // AccountButton
            // 
            AccountButton.FlatAppearance.BorderSize = 0;
            AccountButton.FlatAppearance.MouseOverBackColor = Color.DimGray;
            AccountButton.FlatStyle = FlatStyle.Flat;
            AccountButton.Font = new Font("Segoe UI", 40F);
            AccountButton.ForeColor = SystemColors.Window;
            AccountButton.Location = new Point(139, 541);
            AccountButton.Name = "AccountButton";
            AccountButton.Size = new Size(405, 111);
            AccountButton.TabIndex = 7;
            AccountButton.Text = "Tài khoản";
            AccountButton.TextAlign = ContentAlignment.MiddleLeft;
            AccountButton.UseVisualStyleBackColor = true;
            AccountButton.Click += AccountButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.FlatAppearance.BorderSize = 0;
            ExitButton.FlatAppearance.MouseOverBackColor = Color.DimGray;
            ExitButton.FlatStyle = FlatStyle.Flat;
            ExitButton.Font = new Font("Segoe UI", 40F);
            ExitButton.ForeColor = SystemColors.Window;
            ExitButton.Location = new Point(139, 646);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(405, 111);
            ExitButton.TabIndex = 8;
            ExitButton.Text = "Thoát";
            ExitButton.TextAlign = ContentAlignment.MiddleLeft;
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
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
            // Home
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1331, 844);
            Controls.Add(ChessBoard);
            Controls.Add(ExitButton);
            Controls.Add(AccountButton);
            Controls.Add(SettingButton);
            Controls.Add(PlayButton);
            Controls.Add(RankingButton);
            Controls.Add(HomeButton);
            Controls.Add(Bar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Home";
            Text = "PlayMode";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)Bar).EndInit();
            ((System.ComponentModel.ISupportInitialize)ChessBoard).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button HomeButton;
        private PictureBox Bar;
        private Button RankingButton;
        private Button PlayButton;
        private Button SettingButton;
        private Button AccountButton;
        private Button ExitButton;
        private PictureBox ChessBoard;
    }
}
