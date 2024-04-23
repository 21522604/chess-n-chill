using System.Windows.Forms;

namespace Chessgame
{
    partial class RankingBoard
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "godonii", "21", "1999", "Mã" }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "HGBao", "21", "2001", "Tượng" }, -1);
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "90d0n11", "21", "2000", "Tượng" }, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RankingBoard));
            HomeButton = new Button();
            Bar = new PictureBox();
            RankingButton = new Button();
            BackButton = new Button();
            BackGroundInfo = new PictureBox();
            RankingBoardLabel = new Label();
            RankingBoardListView = new ListView();
            NameColumn = new ColumnHeader();
            Age = new ColumnHeader();
            Rating = new ColumnHeader();
            Rank = new ColumnHeader();
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
            BackButton.Text = "Quay lại trang chủ";
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
            BackGroundInfo.Location = new Point(567, 91);
            BackGroundInfo.Name = "BackGroundInfo";
            BackGroundInfo.Size = new Size(763, 758);
            BackGroundInfo.SizeMode = PictureBoxSizeMode.CenterImage;
            BackGroundInfo.TabIndex = 9;
            BackGroundInfo.TabStop = false;
            // 
            // RankingBoardLabel
            // 
            RankingBoardLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            RankingBoardLabel.AutoSize = true;
            RankingBoardLabel.BackColor = Color.FromArgb(43, 43, 43);
            RankingBoardLabel.FlatStyle = FlatStyle.Flat;
            RankingBoardLabel.Font = new Font("Segoe UI", 40F);
            RankingBoardLabel.ForeColor = SystemColors.Window;
            RankingBoardLabel.Location = new Point(711, 96);
            RankingBoardLabel.Name = "RankingBoardLabel";
            RankingBoardLabel.Size = new Size(477, 89);
            RankingBoardLabel.TabIndex = 10;
            RankingBoardLabel.Text = "Bảng xếp hạng";
            // 
            // RankingBoardListView
            // 
            RankingBoardListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            RankingBoardListView.Columns.AddRange(new ColumnHeader[] { NameColumn, Age, Rating, Rank });
            RankingBoardListView.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3 });
            RankingBoardListView.Location = new Point(567, 185);
            RankingBoardListView.Name = "RankingBoardListView";
            RankingBoardListView.Size = new Size(756, 628);
            RankingBoardListView.TabIndex = 11;
            RankingBoardListView.UseCompatibleStateImageBehavior = false;
            RankingBoardListView.View = View.Details;
            // 
            // NameColumn
            // 
            NameColumn.Text = "Tên";
            NameColumn.Width = 300;
            // 
            // Age
            // 
            Age.Text = "Tuổi";
            Age.Width = 100;
            // 
            // Rating
            // 
            Rating.Text = "Điểm";
            Rating.Width = 180;
            // 
            // Rank
            // 
            Rank.Text = "Xếp hạng";
            Rank.Width = 180;
            // 
            // RankingBoard
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1331, 844);
            Controls.Add(RankingBoardListView);
            Controls.Add(RankingBoardLabel);
            Controls.Add(RankingButton);
            Controls.Add(HomeButton);
            Controls.Add(Bar);
            Controls.Add(BackGroundInfo);
            Controls.Add(BackButton);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RankingBoard";
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
        private Button BackButton;
        private PictureBox BackGroundInfo;
        private Label RankingBoardLabel;
        private ListView RankingBoardListView;
        private ColumnHeader NameColumn;
        private ColumnHeader Age;
        private ColumnHeader Rating;
        private ColumnHeader Rank;
    }
}
