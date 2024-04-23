using System.Windows.Forms;

namespace Chessgame
{
    partial class Account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account));
            HomeButton = new Button();
            Bar = new PictureBox();
            RankingButton = new Button();
            ChangeInfoAccountButton = new Button();
            FriendListButton = new Button();
            BackButton = new Button();
            BackGroundInfo = new PictureBox();
            AccountInfoLabel = new Label();
            AccountNameLabel = new Label();
            AgeLabel = new Label();
            RatingLabel = new Label();
            RankLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)Bar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BackGroundInfo).BeginInit();
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
            // 
            // ChangeInfoAccountButton
            // 
            ChangeInfoAccountButton.FlatAppearance.BorderSize = 0;
            ChangeInfoAccountButton.FlatAppearance.MouseOverBackColor = Color.DimGray;
            ChangeInfoAccountButton.FlatStyle = FlatStyle.Flat;
            ChangeInfoAccountButton.Font = new Font("Segoe UI", 40F);
            ChangeInfoAccountButton.ForeColor = SystemColors.Window;
            ChangeInfoAccountButton.Location = new Point(139, 331);
            ChangeInfoAccountButton.Name = "ChangeInfoAccountButton";
            ChangeInfoAccountButton.Size = new Size(650, 111);
            ChangeInfoAccountButton.TabIndex = 6;
            ChangeInfoAccountButton.Text = "Chỉnh sửa thông tin";
            ChangeInfoAccountButton.TextAlign = ContentAlignment.MiddleLeft;
            ChangeInfoAccountButton.UseVisualStyleBackColor = true;
            ChangeInfoAccountButton.Click += ChangeInfoAccountButton_Click;
            // 
            // FriendListButton
            // 
            FriendListButton.FlatAppearance.BorderSize = 0;
            FriendListButton.FlatAppearance.MouseOverBackColor = Color.DimGray;
            FriendListButton.FlatStyle = FlatStyle.Flat;
            FriendListButton.Font = new Font("Segoe UI", 40F);
            FriendListButton.ForeColor = SystemColors.Window;
            FriendListButton.Location = new Point(139, 436);
            FriendListButton.Name = "FriendListButton";
            FriendListButton.Size = new Size(650, 111);
            FriendListButton.TabIndex = 7;
            FriendListButton.Text = "Danh sách bạn bè";
            FriendListButton.TextAlign = ContentAlignment.MiddleLeft;
            FriendListButton.UseVisualStyleBackColor = true;
            FriendListButton.Click += FriendListButton_Click;
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
            BackButton.Size = new Size(650, 111);
            BackButton.TabIndex = 8;
            BackButton.Text = "Quay lại";
            BackButton.TextAlign = ContentAlignment.MiddleLeft;
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // BackGroundInfo
            // 
            BackGroundInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            BackGroundInfo.BackColor = Color.FromArgb(43, 43, 43);
            BackGroundInfo.BackgroundImageLayout = ImageLayout.None;
            BackGroundInfo.ForeColor = SystemColors.Window;
            BackGroundInfo.Location = new Point(530, 91);
            BackGroundInfo.Name = "BackGroundInfo";
            BackGroundInfo.Size = new Size(800, 758);
            BackGroundInfo.SizeMode = PictureBoxSizeMode.CenterImage;
            BackGroundInfo.TabIndex = 9;
            BackGroundInfo.TabStop = false;
            // 
            // AccountInfoLabel
            // 
            AccountInfoLabel.Anchor = AnchorStyles.Right;
            AccountInfoLabel.AutoSize = true;
            AccountInfoLabel.BackColor = Color.FromArgb(43, 43, 43);
            AccountInfoLabel.FlatStyle = FlatStyle.Flat;
            AccountInfoLabel.Font = new Font("Segoe UI", 40F);
            AccountInfoLabel.ForeColor = SystemColors.Window;
            AccountInfoLabel.Location = new Point(650, 0);
            AccountInfoLabel.Name = "AccountInfoLabel";
            AccountInfoLabel.Size = new Size(613, 89);
            AccountInfoLabel.TabIndex = 10;
            AccountInfoLabel.Text = "Thông tin tài khoản";
            // 
            // AccountNameLabel
            // 
            AccountNameLabel.Anchor = AnchorStyles.Right;
            AccountNameLabel.AutoSize = true;
            AccountNameLabel.BackColor = Color.FromArgb(43, 43, 43);
            AccountNameLabel.FlatStyle = FlatStyle.Flat;
            AccountNameLabel.Font = new Font("Segoe UI", 40F);
            AccountNameLabel.ForeColor = SystemColors.Window;
            AccountNameLabel.Location = new Point(550, 175);
            AccountNameLabel.Name = "AccountNameLabel";
            AccountNameLabel.Size = new Size(154, 89);
            AccountNameLabel.TabIndex = 11;
            AccountNameLabel.Text = "Tên:";
            // 
            // AgeLabel
            // 
            AgeLabel.Anchor = AnchorStyles.Right;
            AgeLabel.AutoSize = true;
            AgeLabel.BackColor = Color.FromArgb(43, 43, 43);
            AgeLabel.FlatStyle = FlatStyle.Flat;
            AgeLabel.Font = new Font("Segoe UI", 40F);
            AgeLabel.ForeColor = SystemColors.Window;
            AgeLabel.Location = new Point(550, 284);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(181, 89);
            AgeLabel.TabIndex = 12;
            AgeLabel.Text = "Tuổi:";
            // 
            // RatingLabel
            // 
            RatingLabel.Anchor = AnchorStyles.Right;
            RatingLabel.AutoSize = true;
            RatingLabel.BackColor = Color.FromArgb(43, 43, 43);
            RatingLabel.FlatStyle = FlatStyle.Flat;
            RatingLabel.Font = new Font("Segoe UI", 40F);
            RatingLabel.ForeColor = SystemColors.Window;
            RatingLabel.Location = new Point(550, 393);
            RatingLabel.Name = "RatingLabel";
            RatingLabel.Size = new Size(209, 89);
            RatingLabel.TabIndex = 13;
            RatingLabel.Text = "Điểm:";
            // 
            // RankLabel
            // 
            RankLabel.Anchor = AnchorStyles.Right;
            RankLabel.AutoSize = true;
            RankLabel.BackColor = Color.FromArgb(43, 43, 43);
            RankLabel.FlatStyle = FlatStyle.Flat;
            RankLabel.Font = new Font("Segoe UI", 40F);
            RankLabel.ForeColor = SystemColors.Window;
            RankLabel.Location = new Point(550, 502);
            RankLabel.Name = "RankLabel";
            RankLabel.Size = new Size(334, 89);
            RankLabel.TabIndex = 14;
            RankLabel.Text = "Xếp hạng:";
            // 
            // Account
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1331, 844);
            Controls.Add(RankLabel);
            Controls.Add(RatingLabel);
            Controls.Add(AgeLabel);
            Controls.Add(AccountNameLabel);
            Controls.Add(AccountInfoLabel);
            Controls.Add(RankingButton);
            Controls.Add(HomeButton);
            Controls.Add(Bar);
            Controls.Add(BackGroundInfo);
            Controls.Add(ChangeInfoAccountButton);
            Controls.Add(FriendListButton);
            Controls.Add(BackButton);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Account";
            Text = "Account";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)Bar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BackGroundInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button HomeButton;
        private PictureBox Bar;
        private Button RankingButton;
        private Button ChangeInfoAccountButton;
        private Button FriendListButton;
        private Button BackButton;
        private PictureBox BackGroundInfo;
        private Label AccountInfoLabel;
        private Label AccountNameLabel;
        private Label AgeLabel;
        private Label RatingLabel;
        private Label RankLabel;
    }
}
