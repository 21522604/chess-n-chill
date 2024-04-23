using System.Windows.Forms;

namespace Chessgame
{
    partial class FindRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindRoom));
            HomeButton = new Button();
            Bar = new PictureBox();
            RankingButton = new Button();
            PlayRankButton = new Button();
            FindRoomButton = new Button();
            BackButton = new Button();
            ChessBoard = new PictureBox();
            RoomListButton = new Button();
            NotFoundLabel = new Label();
            ExitFindButton = new Button();
            FindARoomButton = new Button();
            IDRoomInput = new TextBox();
            IDRoomInputLabel = new Label();
            BackGroundIn = new PictureBox();
            BackGround = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Bar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ChessBoard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BackGroundIn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BackGround).BeginInit();
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
            // PlayRankButton
            // 
            PlayRankButton.FlatAppearance.BorderSize = 0;
            PlayRankButton.FlatAppearance.MouseOverBackColor = Color.DimGray;
            PlayRankButton.FlatStyle = FlatStyle.Flat;
            PlayRankButton.Font = new Font("Segoe UI", 40F);
            PlayRankButton.ForeColor = SystemColors.Window;
            PlayRankButton.Location = new Point(139, 331);
            PlayRankButton.Name = "PlayRankButton";
            PlayRankButton.Size = new Size(600, 111);
            PlayRankButton.TabIndex = 6;
            PlayRankButton.Text = "Đánh xếp hạng";
            PlayRankButton.TextAlign = ContentAlignment.MiddleLeft;
            PlayRankButton.UseVisualStyleBackColor = true;
            // 
            // FindRoomButton
            // 
            FindRoomButton.FlatAppearance.BorderSize = 0;
            FindRoomButton.FlatAppearance.MouseOverBackColor = Color.DimGray;
            FindRoomButton.FlatStyle = FlatStyle.Flat;
            FindRoomButton.Font = new Font("Segoe UI", 40F);
            FindRoomButton.ForeColor = SystemColors.Window;
            FindRoomButton.Location = new Point(139, 436);
            FindRoomButton.Name = "FindRoomButton";
            FindRoomButton.Size = new Size(600, 111);
            FindRoomButton.TabIndex = 7;
            FindRoomButton.Text = "Tìm phòng";
            FindRoomButton.TextAlign = ContentAlignment.MiddleLeft;
            FindRoomButton.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatAppearance.MouseOverBackColor = Color.DimGray;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Segoe UI", 40F);
            BackButton.ForeColor = SystemColors.Window;
            BackButton.Location = new Point(139, 646);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(600, 111);
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
            // RoomListButton
            // 
            RoomListButton.FlatAppearance.BorderSize = 0;
            RoomListButton.FlatAppearance.MouseOverBackColor = Color.DimGray;
            RoomListButton.FlatStyle = FlatStyle.Flat;
            RoomListButton.Font = new Font("Segoe UI", 40F);
            RoomListButton.ForeColor = SystemColors.Window;
            RoomListButton.Location = new Point(139, 541);
            RoomListButton.Name = "RoomListButton";
            RoomListButton.Size = new Size(600, 111);
            RoomListButton.TabIndex = 10;
            RoomListButton.Text = "Danh sách phòng";
            RoomListButton.TextAlign = ContentAlignment.MiddleLeft;
            RoomListButton.UseVisualStyleBackColor = true;
            // 
            // NotFoundLabel
            // 
            NotFoundLabel.AutoSize = true;
            NotFoundLabel.BackColor = Color.FromArgb(43, 43, 43);
            NotFoundLabel.Font = new Font("Segoe UI", 18F);
            NotFoundLabel.ForeColor = SystemColors.Window;
            NotFoundLabel.Location = new Point(727, 520);
            NotFoundLabel.Name = "NotFoundLabel";
            NotFoundLabel.Size = new Size(455, 41);
            NotFoundLabel.TabIndex = 31;
            NotFoundLabel.Text = "Không tìm thấy phòng có ID trên";
            NotFoundLabel.Visible = false;
            // 
            // ExitFindButton
            // 
            ExitFindButton.BackColor = Color.FromArgb(61, 61, 61);
            ExitFindButton.FlatAppearance.BorderSize = 0;
            ExitFindButton.FlatAppearance.MouseOverBackColor = Color.DimGray;
            ExitFindButton.FlatStyle = FlatStyle.Flat;
            ExitFindButton.Font = new Font("Segoe UI", 24F);
            ExitFindButton.ForeColor = SystemColors.Window;
            ExitFindButton.Location = new Point(1036, 580);
            ExitFindButton.Name = "ExitFindButton";
            ExitFindButton.Size = new Size(176, 78);
            ExitFindButton.TabIndex = 30;
            ExitFindButton.Text = "Thoát";
            ExitFindButton.UseVisualStyleBackColor = false;
            ExitFindButton.Click += ExitFindButton_Click;
            // 
            // FindARoomButton
            // 
            FindARoomButton.BackColor = Color.FromArgb(61, 61, 61);
            FindARoomButton.FlatAppearance.BorderSize = 0;
            FindARoomButton.FlatAppearance.MouseOverBackColor = Color.DimGray;
            FindARoomButton.FlatStyle = FlatStyle.Flat;
            FindARoomButton.Font = new Font("Segoe UI", 24F);
            FindARoomButton.ForeColor = SystemColors.Window;
            FindARoomButton.Location = new Point(667, 580);
            FindARoomButton.Name = "FindARoomButton";
            FindARoomButton.Size = new Size(176, 78);
            FindARoomButton.TabIndex = 29;
            FindARoomButton.Text = "Tìm";
            FindARoomButton.UseVisualStyleBackColor = false;
            FindARoomButton.Click += FindARoomButton_Click;
            // 
            // IDRoomInput
            // 
            IDRoomInput.Font = new Font("Segoe UI", 32F);
            IDRoomInput.Location = new Point(611, 439);
            IDRoomInput.Name = "IDRoomInput";
            IDRoomInput.Size = new Size(649, 78);
            IDRoomInput.TabIndex = 28;
            // 
            // IDRoomInputLabel
            // 
            IDRoomInputLabel.AutoSize = true;
            IDRoomInputLabel.BackColor = Color.FromArgb(43, 43, 43);
            IDRoomInputLabel.Font = new Font("Segoe UI", 32F);
            IDRoomInputLabel.ForeColor = SystemColors.Window;
            IDRoomInputLabel.Location = new Point(745, 340);
            IDRoomInputLabel.Name = "IDRoomInputLabel";
            IDRoomInputLabel.Size = new Size(400, 72);
            IDRoomInputLabel.TabIndex = 27;
            IDRoomInputLabel.Text = "Nhập ID phòng";
            // 
            // BackGroundIn
            // 
            BackGroundIn.BackColor = Color.FromArgb(43, 43, 43);
            BackGroundIn.Location = new Point(488, 331);
            BackGroundIn.Name = "BackGroundIn";
            BackGroundIn.Size = new Size(893, 339);
            BackGroundIn.TabIndex = 26;
            BackGroundIn.TabStop = false;
            // 
            // BackGround
            // 
            BackGround.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BackGround.BackColor = Color.FromArgb(230, 0, 0, 0);
            BackGround.Location = new Point(0, 0);
            BackGround.Name = "BackGround";
            BackGround.Size = new Size(1331, 844);
            BackGround.TabIndex = 25;
            BackGround.TabStop = false;
            // 
            // FindRoom
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1331, 844);
            Controls.Add(NotFoundLabel);
            Controls.Add(ExitFindButton);
            Controls.Add(FindARoomButton);
            Controls.Add(IDRoomInput);
            Controls.Add(IDRoomInputLabel);
            Controls.Add(BackGroundIn);
            Controls.Add(BackGround);
            Controls.Add(ChessBoard);
            Controls.Add(BackButton);
            Controls.Add(FindRoomButton);
            Controls.Add(PlayRankButton);
            Controls.Add(RankingButton);
            Controls.Add(HomeButton);
            Controls.Add(Bar);
            Controls.Add(RoomListButton);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FindRoom";
            Text = "PlayModeSub";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)Bar).EndInit();
            ((System.ComponentModel.ISupportInitialize)ChessBoard).EndInit();
            ((System.ComponentModel.ISupportInitialize)BackGroundIn).EndInit();
            ((System.ComponentModel.ISupportInitialize)BackGround).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button HomeButton;
        private PictureBox Bar;
        private Button RankingButton;
        private Button PlayRankButton;
        private Button FindRoomButton;
        private Button BackButton;
        private PictureBox ChessBoard;
        private Button RoomListButton;
        private Label NotFoundLabel;
        private Button ExitFindButton;
        private Button FindARoomButton;
        private TextBox IDRoomInput;
        private Label IDRoomInputLabel;
        private PictureBox BackGroundIn;
        private PictureBox BackGround;
    }
}
