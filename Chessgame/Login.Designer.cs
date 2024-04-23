using System.Windows.Forms;

namespace Chessgame
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            HomeButton = new Button();
            Bar = new PictureBox();
            RankingButton = new Button();
            BackGroundInfo = new PictureBox();
            LoginLabel = new Label();
            EmailLabel = new Label();
            LoginButton = new Button();
            EmailLoginTextbox = new TextBox();
            PasswordLabel = new Label();
            PasswordLoginTextbox = new TextBox();
            SignUpLabel = new Label();
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
            // BackGroundInfo
            // 
            BackGroundInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BackGroundInfo.BackColor = Color.FromArgb(43, 43, 43);
            BackGroundInfo.BackgroundImageLayout = ImageLayout.None;
            BackGroundInfo.ForeColor = SystemColors.Window;
            BackGroundInfo.Location = new Point(530, 91);
            BackGroundInfo.Name = "BackGroundInfo";
            BackGroundInfo.Size = new Size(300, 400);
            BackGroundInfo.SizeMode = PictureBoxSizeMode.CenterImage;
            BackGroundInfo.TabIndex = 9;
            BackGroundInfo.TabStop = false;
            // 
            // LoginLabel
            // 
            LoginLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LoginLabel.AutoSize = true;
            LoginLabel.BackColor = Color.FromArgb(43, 43, 43);
            LoginLabel.FlatStyle = FlatStyle.Flat;
            LoginLabel.Font = new Font("Segoe UI", 40F);
            LoginLabel.ForeColor = SystemColors.Window;
            LoginLabel.Location = new Point(800, 100);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(363, 89);
            LoginLabel.TabIndex = 10;
            LoginLabel.Text = "Đăng nhập";
            // 
            // EmailLabel
            // 
            EmailLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EmailLabel.AutoSize = true;
            EmailLabel.BackColor = Color.FromArgb(43, 43, 43);
            EmailLabel.FlatStyle = FlatStyle.Flat;
            EmailLabel.Font = new Font("Segoe UI", 32F);
            EmailLabel.ForeColor = SystemColors.Window;
            EmailLabel.Location = new Point(600, 189);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(169, 72);
            EmailLabel.TabIndex = 11;
            EmailLabel.Text = "Email:";
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.Gray;
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.FlatAppearance.MouseOverBackColor = Color.DimGray;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Segoe UI", 28F);
            LoginButton.ForeColor = SystemColors.Window;
            LoginButton.Location = new Point(600, 600);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(300, 70);
            LoginButton.TabIndex = 15;
            LoginButton.Text = "Đăng nhập";
            LoginButton.UseVisualStyleBackColor = false;
            // 
            // EmailLoginTextbox
            // 
            EmailLoginTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EmailLoginTextbox.BackColor = Color.FromArgb(64, 64, 64);
            EmailLoginTextbox.Font = new Font("Segoe UI", 32F);
            EmailLoginTextbox.Location = new Point(600, 284);
            EmailLoginTextbox.Name = "EmailLoginTextbox";
            EmailLoginTextbox.Size = new Size(154, 78);
            EmailLoginTextbox.TabIndex = 17;
            // 
            // PasswordLabel
            // 
            PasswordLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PasswordLabel.AutoSize = true;
            PasswordLabel.BackColor = Color.FromArgb(43, 43, 43);
            PasswordLabel.FlatStyle = FlatStyle.Flat;
            PasswordLabel.Font = new Font("Segoe UI", 32F);
            PasswordLabel.ForeColor = SystemColors.Window;
            PasswordLabel.Location = new Point(600, 385);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(266, 72);
            PasswordLabel.TabIndex = 12;
            PasswordLabel.Text = "Mật khẩu:";
            // 
            // PasswordLoginTextbox
            // 
            PasswordLoginTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PasswordLoginTextbox.BackColor = Color.FromArgb(64, 64, 64);
            PasswordLoginTextbox.Font = new Font("Segoe UI", 32F);
            PasswordLoginTextbox.Location = new Point(600, 480);
            PasswordLoginTextbox.Name = "PasswordLoginTextbox";
            PasswordLoginTextbox.Size = new Size(154, 78);
            PasswordLoginTextbox.TabIndex = 18;
            // 
            // SignUpLabel
            // 
            SignUpLabel.AutoSize = true;
            SignUpLabel.BackColor = Color.FromArgb(43, 43, 43);
            SignUpLabel.Font = new Font("Segoe UI", 24F, FontStyle.Underline);
            SignUpLabel.ForeColor = SystemColors.Window;
            SignUpLabel.Location = new Point(940, 610);
            SignUpLabel.Name = "SignUpLabel";
            SignUpLabel.Size = new Size(430, 54);
            SignUpLabel.TabIndex = 19;
            SignUpLabel.Text = "Bạn chưa có tài khoản?";
            // 
            // Login
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1331, 844);
            Controls.Add(SignUpLabel);
            Controls.Add(PasswordLoginTextbox);
            Controls.Add(EmailLoginTextbox);
            Controls.Add(LoginButton);
            Controls.Add(PasswordLabel);
            Controls.Add(EmailLabel);
            Controls.Add(LoginLabel);
            Controls.Add(RankingButton);
            Controls.Add(HomeButton);
            Controls.Add(Bar);
            Controls.Add(BackGroundInfo);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
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
        private PictureBox BackGroundInfo;
        private Label LoginLabel;
        private Label EmailLabel;
        private Button LoginButton;
        private TextBox EmailLoginTextbox;
        private Label PasswordLabel;
        private TextBox PasswordLoginTextbox;
        private Label SignUpLabel;
    }
}
