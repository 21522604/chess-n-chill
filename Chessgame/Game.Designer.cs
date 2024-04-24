using System.Windows.Forms;

namespace Chessgame
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            HomeButton = new Button();
            Bar = new PictureBox();
            RankingButton = new Button();
            ChessBoard = new PictureBox();
            StepListPlayer2 = new ListBox();
            StepListPlayer1 = new ListBox();
            EnemyStepLabel = new Label();
            StepLabel = new Label();
            YourStepLabel = new Label();
            ChatInput = new TextBox();
            ChatLabel = new Label();
            ChatList = new ListBox();
            Player1Time = new Label();
            Player1Name = new Label();
            Player1Avatar = new PictureBox();
            Player2Time = new Label();
            Player2Name = new Label();
            Player2Avatar = new PictureBox();
            GetLoseButton = new Button();
            ExitButton = new Button();
            ReadyButton = new Button();
            ((System.ComponentModel.ISupportInitialize)Bar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ChessBoard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Player1Avatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Player2Avatar).BeginInit();
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
            Bar.Size = new Size(1450, 93);
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
            // ChessBoard
            // 
            ChessBoard.Image = Properties.Resources.ChessBoard;
            ChessBoard.Location = new Point(156, 267);
            ChessBoard.Name = "ChessBoard";
            ChessBoard.Size = new Size(564, 592);
            ChessBoard.TabIndex = 9;
            ChessBoard.TabStop = false;
            // 
            // StepListPlayer2
            // 
            StepListPlayer2.Anchor = AnchorStyles.None;
            StepListPlayer2.BackColor = Color.FromArgb(64, 64, 64);
            StepListPlayer2.BorderStyle = BorderStyle.FixedSingle;
            StepListPlayer2.Font = new Font("Segoe UI", 18F);
            StepListPlayer2.ForeColor = SystemColors.Window;
            StepListPlayer2.FormattingEnabled = true;
            StepListPlayer2.ItemHeight = 41;
            StepListPlayer2.Items.AddRange(new object[] { "G5 - H1", "H1 - J1" });
            StepListPlayer2.Location = new Point(1092, 241);
            StepListPlayer2.Margin = new Padding(0);
            StepListPlayer2.Name = "StepListPlayer2";
            StepListPlayer2.RightToLeft = RightToLeft.Yes;
            StepListPlayer2.Size = new Size(358, 289);
            StepListPlayer2.TabIndex = 25;
            // 
            // StepListPlayer1
            // 
            StepListPlayer1.Anchor = AnchorStyles.None;
            StepListPlayer1.BackColor = Color.FromArgb(64, 64, 64);
            StepListPlayer1.BorderStyle = BorderStyle.FixedSingle;
            StepListPlayer1.Font = new Font("Segoe UI", 18F);
            StepListPlayer1.ForeColor = SystemColors.Window;
            StepListPlayer1.FormattingEnabled = true;
            StepListPlayer1.ItemHeight = 41;
            StepListPlayer1.Items.AddRange(new object[] { "G5 - H1", "H1 - J1" });
            StepListPlayer1.Location = new Point(750, 241);
            StepListPlayer1.Margin = new Padding(0);
            StepListPlayer1.Name = "StepListPlayer1";
            StepListPlayer1.Size = new Size(342, 289);
            StepListPlayer1.TabIndex = 26;
            // 
            // EnemyStepLabel
            // 
            EnemyStepLabel.Anchor = AnchorStyles.None;
            EnemyStepLabel.AutoSize = true;
            EnemyStepLabel.Font = new Font("Segoe UI", 24F);
            EnemyStepLabel.ForeColor = SystemColors.Window;
            EnemyStepLabel.Location = new Point(1295, 187);
            EnemyStepLabel.Name = "EnemyStepLabel";
            EnemyStepLabel.Size = new Size(155, 54);
            EnemyStepLabel.TabIndex = 24;
            EnemyStepLabel.Text = "Đối thủ";
            // 
            // StepLabel
            // 
            StepLabel.Anchor = AnchorStyles.None;
            StepLabel.AutoSize = true;
            StepLabel.Font = new Font("Segoe UI", 24F);
            StepLabel.ForeColor = SystemColors.Window;
            StepLabel.Location = new Point(1003, 184);
            StepLabel.Name = "StepLabel";
            StepLabel.Size = new Size(164, 54);
            StepLabel.TabIndex = 23;
            StepLabel.Text = "Nước đi";
            // 
            // YourStepLabel
            // 
            YourStepLabel.Anchor = AnchorStyles.None;
            YourStepLabel.AutoSize = true;
            YourStepLabel.Font = new Font("Segoe UI", 24F);
            YourStepLabel.ForeColor = SystemColors.Window;
            YourStepLabel.Location = new Point(750, 184);
            YourStepLabel.Name = "YourStepLabel";
            YourStepLabel.Size = new Size(89, 54);
            YourStepLabel.TabIndex = 23;
            YourStepLabel.Text = "Bạn";
            // 
            // ChatInput
            // 
            ChatInput.Anchor = AnchorStyles.None;
            ChatInput.BackColor = Color.FromArgb(64, 64, 64);
            ChatInput.BorderStyle = BorderStyle.FixedSingle;
            ChatInput.Font = new Font("Segoe UI", 18F);
            ChatInput.ForeColor = SystemColors.Window;
            ChatInput.Location = new Point(750, 917);
            ChatInput.Margin = new Padding(0);
            ChatInput.Name = "ChatInput";
            ChatInput.PlaceholderText = "Nhập gì đó ....";
            ChatInput.Size = new Size(689, 47);
            ChatInput.TabIndex = 2;
            ChatInput.TextChanged += ChatInput_TextChanged;
            // 
            // ChatLabel
            // 
            ChatLabel.Anchor = AnchorStyles.None;
            ChatLabel.AutoSize = true;
            ChatLabel.Font = new Font("Segoe UI", 24F);
            ChatLabel.ForeColor = SystemColors.Window;
            ChatLabel.Location = new Point(750, 543);
            ChatLabel.Name = "ChatLabel";
            ChatLabel.Size = new Size(105, 54);
            ChatLabel.TabIndex = 1;
            ChatLabel.Text = "Chat";
            // 
            // ChatList
            // 
            ChatList.Anchor = AnchorStyles.None;
            ChatList.BackColor = Color.FromArgb(64, 64, 64);
            ChatList.BorderStyle = BorderStyle.FixedSingle;
            ChatList.Font = new Font("Segoe UI", 18F);
            ChatList.ForeColor = SystemColors.Window;
            ChatList.FormattingEnabled = true;
            ChatList.ItemHeight = 41;
            ChatList.Items.AddRange(new object[] { "Bạn: lmao", "Tên đối thủ: lmao", "\u2028Hệ thống: Bạn đã thua Tên đối thủ" });
            ChatList.Location = new Point(750, 597);
            ChatList.Margin = new Padding(0);
            ChatList.Name = "ChatList";
            ChatList.Size = new Size(689, 330);
            ChatList.TabIndex = 27;
            // 
            // Player1Time
            // 
            Player1Time.AutoSize = true;
            Player1Time.Font = new Font("Segoe UI", 28F);
            Player1Time.ForeColor = SystemColors.Window;
            Player1Time.Location = new Point(580, 186);
            Player1Time.Name = "Player1Time";
            Player1Time.Size = new Size(137, 62);
            Player1Time.TabIndex = 30;
            Player1Time.Text = "00:00";
            // 
            // Player1Name
            // 
            Player1Name.AutoSize = true;
            Player1Name.Font = new Font("Segoe UI", 24F);
            Player1Name.ForeColor = SystemColors.Window;
            Player1Name.Location = new Point(273, 193);
            Player1Name.Name = "Player1Name";
            Player1Name.Size = new Size(128, 54);
            Player1Name.TabIndex = 29;
            Player1Name.Text = "Name";
            // 
            // Player1Avatar
            // 
            Player1Avatar.BackColor = Color.White;
            Player1Avatar.Location = new Point(156, 175);
            Player1Avatar.Name = "Player1Avatar";
            Player1Avatar.Size = new Size(93, 86);
            Player1Avatar.TabIndex = 28;
            Player1Avatar.TabStop = false;
            // 
            // Player2Time
            // 
            Player2Time.AutoSize = true;
            Player2Time.Font = new Font("Segoe UI", 28F);
            Player2Time.ForeColor = SystemColors.Window;
            Player2Time.Location = new Point(580, 876);
            Player2Time.Name = "Player2Time";
            Player2Time.Size = new Size(137, 62);
            Player2Time.TabIndex = 33;
            Player2Time.Text = "00:00";
            // 
            // Player2Name
            // 
            Player2Name.AutoSize = true;
            Player2Name.Font = new Font("Segoe UI", 24F);
            Player2Name.ForeColor = SystemColors.Window;
            Player2Name.Location = new Point(273, 883);
            Player2Name.Name = "Player2Name";
            Player2Name.Size = new Size(128, 54);
            Player2Name.TabIndex = 32;
            Player2Name.Text = "Name";
            // 
            // Player2Avatar
            // 
            Player2Avatar.Anchor = AnchorStyles.None;
            Player2Avatar.BackColor = Color.White;
            Player2Avatar.Location = new Point(156, 865);
            Player2Avatar.Name = "Player2Avatar";
            Player2Avatar.Size = new Size(93, 86);
            Player2Avatar.TabIndex = 31;
            Player2Avatar.TabStop = false;
            // 
            // GetLoseButton
            // 
            GetLoseButton.Anchor = AnchorStyles.None;
            GetLoseButton.BackColor = Color.DimGray;
            GetLoseButton.FlatAppearance.BorderSize = 0;
            GetLoseButton.FlatAppearance.MouseOverBackColor = Color.DimGray;
            GetLoseButton.FlatStyle = FlatStyle.Flat;
            GetLoseButton.Font = new Font("Segoe UI", 18F);
            GetLoseButton.ForeColor = SystemColors.Window;
            GetLoseButton.Location = new Point(750, 990);
            GetLoseButton.Name = "GetLoseButton";
            GetLoseButton.Size = new Size(181, 63);
            GetLoseButton.TabIndex = 34;
            GetLoseButton.Text = "Đầu hàng";
            GetLoseButton.UseVisualStyleBackColor = false;
            GetLoseButton.Click += GetLoseButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Anchor = AnchorStyles.None;
            ExitButton.BackColor = Color.DimGray;
            ExitButton.FlatAppearance.BorderSize = 0;
            ExitButton.FlatAppearance.MouseOverBackColor = Color.DimGray;
            ExitButton.FlatStyle = FlatStyle.Flat;
            ExitButton.Font = new Font("Segoe UI", 18F);
            ExitButton.ForeColor = SystemColors.Window;
            ExitButton.Location = new Point(1258, 990);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(181, 63);
            ExitButton.TabIndex = 35;
            ExitButton.Text = "Thoát";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // ReadyButton
            // 
            ReadyButton.Anchor = AnchorStyles.None;
            ReadyButton.BackColor = Color.DimGray;
            ReadyButton.FlatAppearance.BorderSize = 0;
            ReadyButton.FlatAppearance.MouseOverBackColor = Color.DimGray;
            ReadyButton.FlatStyle = FlatStyle.Flat;
            ReadyButton.Font = new Font("Segoe UI", 18F);
            ReadyButton.ForeColor = SystemColors.Window;
            ReadyButton.Location = new Point(1003, 990);
            ReadyButton.Name = "ReadyButton";
            ReadyButton.Size = new Size(181, 63);
            ReadyButton.TabIndex = 36;
            ReadyButton.Text = "Sẵn sàng";
            ReadyButton.UseVisualStyleBackColor = false;
            ReadyButton.Click += ReadyButton_Click;
            // 
            // Game
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1448, 1101);
            Controls.Add(ReadyButton);
            Controls.Add(ExitButton);
            Controls.Add(GetLoseButton);
            Controls.Add(Player2Time);
            Controls.Add(Player2Name);
            Controls.Add(Player2Avatar);
            Controls.Add(Player1Time);
            Controls.Add(Player1Name);
            Controls.Add(Player1Avatar);
            Controls.Add(ChatList);
            Controls.Add(ChatLabel);
            Controls.Add(ChatInput);
            Controls.Add(StepListPlayer2);
            Controls.Add(StepListPlayer1);
            Controls.Add(EnemyStepLabel);
            Controls.Add(StepLabel);
            Controls.Add(YourStepLabel);
            Controls.Add(ChessBoard);
            Controls.Add(RankingButton);
            Controls.Add(HomeButton);
            Controls.Add(Bar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Game";
            Text = "PlayMode";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)Bar).EndInit();
            ((System.ComponentModel.ISupportInitialize)ChessBoard).EndInit();
            ((System.ComponentModel.ISupportInitialize)Player1Avatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Player2Avatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button HomeButton;
        private PictureBox Bar;
        private Button RankingButton;
        private PictureBox ChessBoard;
        private ListBox StepListPlayer2;
        private ListBox StepListPlayer1;
        private Label EnemyStepLabel;
        private Label StepLabel;
        private Label YourStepLabel;
        private TextBox ChatInput;
        private Label ChatLabel;
        private ListBox ChatList;
        private Label Player1Time;
        private Label Player1Name;
        private PictureBox Player1Avatar;
        private Label Player2Time;
        private Label Player2Name;
        private PictureBox Player2Avatar;
        private Button GetLoseButton;
        private Button ExitButton;
        private Button ReadyButton;
    }
}
