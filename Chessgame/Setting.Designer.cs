using System.Windows.Forms;

namespace Chessgame
{
    partial class Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            HomeButton = new Button();
            Bar = new PictureBox();
            RankingButton = new Button();
            ExitButton = new Button();
            ChessBoard = new PictureBox();
            SoundSetting = new TrackBar();
            SoundLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)Bar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ChessBoard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SoundSetting).BeginInit();
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
            RankingButton.Click += RankingButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.FlatAppearance.BorderSize = 0;
            ExitButton.FlatAppearance.MouseOverBackColor = Color.DimGray;
            ExitButton.FlatStyle = FlatStyle.Flat;
            ExitButton.Font = new Font("Segoe UI", 40F);
            ExitButton.ForeColor = SystemColors.Window;
            ExitButton.Location = new Point(139, 550);
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
            // SoundSetting
            // 
            SoundSetting.Location = new Point(189, 396);
            SoundSetting.Name = "SoundSetting";
            SoundSetting.Size = new Size(316, 56);
            SoundSetting.TabIndex = 1;
            SoundSetting.Value = 10;
            SoundSetting.ValueChanged += SoundChange;
            // 
            // SoundLabel
            // 
            SoundLabel.AutoSize = true;
            SoundLabel.Font = new Font("Segoe UI", 32F);
            SoundLabel.ForeColor = SystemColors.Window;
            SoundLabel.Location = new Point(139, 283);
            SoundLabel.Name = "SoundLabel";
            SoundLabel.Size = new Size(277, 72);
            SoundLabel.TabIndex = 11;
            SoundLabel.Text = "Âm thanh:";
            // 
            // Setting
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1331, 844);
            Controls.Add(SoundLabel);
            Controls.Add(SoundSetting);
            Controls.Add(ChessBoard);
            Controls.Add(ExitButton);
            Controls.Add(RankingButton);
            Controls.Add(HomeButton);
            Controls.Add(Bar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Setting";
            Text = "PlayMode";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)Bar).EndInit();
            ((System.ComponentModel.ISupportInitialize)ChessBoard).EndInit();
            ((System.ComponentModel.ISupportInitialize)SoundSetting).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button HomeButton;
        private PictureBox Bar;
        private Button RankingButton;
        private Button ExitButton;
        private PictureBox ChessBoard;
        private TrackBar SoundSetting;
        private Label SoundLabel;
    }
}
