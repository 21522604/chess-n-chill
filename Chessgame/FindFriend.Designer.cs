﻿using System.Windows.Forms;

namespace Chessgame
{
    partial class FindFriend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindFriend));
            HomeButton = new Button();
            Bar = new PictureBox();
            RankingButton = new Button();
            BackButton = new Button();
            BackGroundInfo = new PictureBox();
            FriendListLabel = new Label();
            DeleteFriendButton = new Button();
            FindFriendButton = new Button();
            FriendListBox = new ListBox();
            BackGround = new PictureBox();
            BackGroundIn = new PictureBox();
            PlayerNameInputLabel = new Label();
            PlayerNameInput = new TextBox();
            AddFriendButton = new Button();
            ExitButton = new Button();
            NotFoundLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)Bar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BackGroundInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BackGround).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BackGroundIn).BeginInit();
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
            // BackButton
            // 
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatAppearance.MouseOverBackColor = Color.DimGray;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Segoe UI", 40F);
            BackButton.ForeColor = SystemColors.Window;
            BackButton.Location = new Point(139, 331);
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
            // FriendListLabel
            // 
            FriendListLabel.Anchor = AnchorStyles.Right;
            FriendListLabel.AutoSize = true;
            FriendListLabel.BackColor = Color.FromArgb(43, 43, 43);
            FriendListLabel.FlatStyle = FlatStyle.Flat;
            FriendListLabel.Font = new Font("Segoe UI", 40F);
            FriendListLabel.ForeColor = SystemColors.Window;
            FriendListLabel.Location = new Point(650, 0);
            FriendListLabel.Name = "FriendListLabel";
            FriendListLabel.Size = new Size(565, 89);
            FriendListLabel.TabIndex = 10;
            FriendListLabel.Text = "Danh sách bạn bè";
            // 
            // DeleteFriendButton
            // 
            DeleteFriendButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DeleteFriendButton.BackColor = Color.FromArgb(43, 43, 43);
            DeleteFriendButton.FlatAppearance.BorderSize = 0;
            DeleteFriendButton.FlatAppearance.MouseOverBackColor = Color.DimGray;
            DeleteFriendButton.FlatStyle = FlatStyle.Flat;
            DeleteFriendButton.Font = new Font("Segoe UI", 40F);
            DeleteFriendButton.ForeColor = SystemColors.Window;
            DeleteFriendButton.Location = new Point(746, 695);
            DeleteFriendButton.Name = "DeleteFriendButton";
            DeleteFriendButton.Size = new Size(160, 90);
            DeleteFriendButton.TabIndex = 15;
            DeleteFriendButton.Text = "Xóa";
            DeleteFriendButton.TextAlign = ContentAlignment.MiddleLeft;
            DeleteFriendButton.UseVisualStyleBackColor = false;
            DeleteFriendButton.Click += DeleteFriendButton_Click;
            // 
            // FindFriendButton
            // 
            FindFriendButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            FindFriendButton.BackColor = Color.FromArgb(43, 43, 43);
            FindFriendButton.FlatAppearance.BorderSize = 0;
            FindFriendButton.FlatAppearance.MouseOverBackColor = Color.DimGray;
            FindFriendButton.FlatStyle = FlatStyle.Flat;
            FindFriendButton.Font = new Font("Segoe UI", 40F);
            FindFriendButton.ForeColor = SystemColors.Window;
            FindFriendButton.Location = new Point(1047, 695);
            FindFriendButton.Name = "FindFriendButton";
            FindFriendButton.Size = new Size(160, 90);
            FindFriendButton.TabIndex = 16;
            FindFriendButton.Text = "Tìm";
            FindFriendButton.TextAlign = ContentAlignment.MiddleLeft;
            FindFriendButton.UseVisualStyleBackColor = false;
            FindFriendButton.Click += FindFriendButton_Click;
            // 
            // FriendListBox
            // 
            FriendListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            FriendListBox.BackColor = Color.FromArgb(43, 43, 43);
            FriendListBox.BorderStyle = BorderStyle.None;
            FriendListBox.Font = new Font("Segoe UI", 32F);
            FriendListBox.ForeColor = SystemColors.Window;
            FriendListBox.FormattingEnabled = true;
            FriendListBox.ItemHeight = 71;
            FriendListBox.Items.AddRange(new object[] { "sample", "sample", "sample", "sample", "sample", "sample", "sample", "sample", "sample", "sample", "sample", "sample", "sample", "sample", "sample", "sample", "sample", "sample", "sample", "sample", "sample", "sample", "sample", "sample", "sample", "sample", "sample" });
            FriendListBox.Location = new Point(530, 223);
            FriendListBox.Name = "FriendListBox";
            FriendListBox.Size = new Size(800, 426);
            FriendListBox.TabIndex = 17;
            // 
            // BackGround
            // 
            BackGround.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BackGround.BackColor = Color.FromArgb(230, 0, 0, 0);
            BackGround.Location = new Point(0, 0);
            BackGround.Name = "BackGround";
            BackGround.Size = new Size(1331, 844);
            BackGround.TabIndex = 18;
            BackGround.TabStop = false;
            // 
            // BackGroundIn
            // 
            BackGroundIn.BackColor = Color.FromArgb(43, 43, 43);
            BackGroundIn.Location = new Point(488, 331);
            BackGroundIn.Name = "BackGroundIn";
            BackGroundIn.Size = new Size(893, 339);
            BackGroundIn.TabIndex = 19;
            BackGroundIn.TabStop = false;
            // 
            // PlayerNameInputLabel
            // 
            PlayerNameInputLabel.AutoSize = true;
            PlayerNameInputLabel.BackColor = Color.FromArgb(43, 43, 43);
            PlayerNameInputLabel.Font = new Font("Segoe UI", 32F);
            PlayerNameInputLabel.ForeColor = SystemColors.Window;
            PlayerNameInputLabel.Location = new Point(667, 344);
            PlayerNameInputLabel.Name = "PlayerNameInputLabel";
            PlayerNameInputLabel.Size = new Size(523, 72);
            PlayerNameInputLabel.TabIndex = 20;
            PlayerNameInputLabel.Text = "Nhập tên người chơi";
            // 
            // PlayerNameInput
            // 
            PlayerNameInput.Font = new Font("Segoe UI", 32F);
            PlayerNameInput.Location = new Point(611, 439);
            PlayerNameInput.Name = "PlayerNameInput";
            PlayerNameInput.Size = new Size(649, 78);
            PlayerNameInput.TabIndex = 21;
            // 
            // AddFriendButton
            // 
            AddFriendButton.BackColor = Color.FromArgb(61, 61, 61);
            AddFriendButton.FlatAppearance.BorderSize = 0;
            AddFriendButton.FlatAppearance.MouseOverBackColor = Color.DimGray;
            AddFriendButton.FlatStyle = FlatStyle.Flat;
            AddFriendButton.Font = new Font("Segoe UI", 24F);
            AddFriendButton.ForeColor = SystemColors.Window;
            AddFriendButton.Location = new Point(667, 580);
            AddFriendButton.Name = "AddFriendButton";
            AddFriendButton.Size = new Size(176, 78);
            AddFriendButton.TabIndex = 22;
            AddFriendButton.Text = "Kết bạn";
            AddFriendButton.UseVisualStyleBackColor = false;
            AddFriendButton.Click += AddFriendButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.FromArgb(61, 61, 61);
            ExitButton.FlatAppearance.BorderSize = 0;
            ExitButton.FlatAppearance.MouseOverBackColor = Color.DimGray;
            ExitButton.FlatStyle = FlatStyle.Flat;
            ExitButton.Font = new Font("Segoe UI", 24F);
            ExitButton.ForeColor = SystemColors.Window;
            ExitButton.Location = new Point(1036, 580);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(176, 78);
            ExitButton.TabIndex = 23;
            ExitButton.Text = "Thoát";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // NotFoundLabel
            // 
            NotFoundLabel.AutoSize = true;
            NotFoundLabel.BackColor = Color.FromArgb(43, 43, 43);
            NotFoundLabel.Font = new Font("Segoe UI", 18F);
            NotFoundLabel.ForeColor = SystemColors.Window;
            NotFoundLabel.Location = new Point(727, 520);
            NotFoundLabel.Name = "NotFoundLabel";
            NotFoundLabel.Size = new Size(422, 41);
            NotFoundLabel.TabIndex = 24;
            NotFoundLabel.Text = "Không tìm thấy tên người chơi";
            NotFoundLabel.Visible = false;
            // 
            // FindFriend
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1331, 844);
            Controls.Add(NotFoundLabel);
            Controls.Add(ExitButton);
            Controls.Add(AddFriendButton);
            Controls.Add(PlayerNameInput);
            Controls.Add(PlayerNameInputLabel);
            Controls.Add(BackGroundIn);
            Controls.Add(BackGround);
            Controls.Add(FindFriendButton);
            Controls.Add(DeleteFriendButton);
            Controls.Add(FriendListLabel);
            Controls.Add(RankingButton);
            Controls.Add(HomeButton);
            Controls.Add(Bar);
            Controls.Add(FriendListBox);
            Controls.Add(BackButton);
            Controls.Add(BackGroundInfo);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FindFriend";
            Text = "Account";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)Bar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BackGroundInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)BackGround).EndInit();
            ((System.ComponentModel.ISupportInitialize)BackGroundIn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button HomeButton;
        private PictureBox Bar;
        private Button RankingButton;
        private Button BackButton;
        private PictureBox BackGroundInfo;
        private Label FriendListLabel;
        private Button DeleteFriendButton;
        private Button FindFriendButton;
        private ListBox FriendListBox;
        private PictureBox BackGround;
        private PictureBox BackGroundIn;
        private Label PlayerNameInputLabel;
        private TextBox PlayerNameInput;
        private Button AddFriendButton;
        private Button ExitButton;
        private Label NotFoundLabel;
    }
}
