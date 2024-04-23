using System.Windows.Forms;

namespace Chessgame
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            HomeButton = new Button();
            Bar = new PictureBox();
            RankingButton = new Button();
            BackGroundInfo = new PictureBox();
            SignUpLabel = new Label();
            EmailLabel = new Label();
            SignUpButton = new Button();
            EmailSignUpTextbox = new TextBox();
            PasswordLabel = new Label();
            PasswordSignUpTextbox = new TextBox();
            ConfirmPasswordTextbox = new TextBox();
            ConfirmPasswordLabel = new Label();
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
            BackGroundInfo.Size = new Size(300, 600);
            BackGroundInfo.SizeMode = PictureBoxSizeMode.CenterImage;
            BackGroundInfo.TabIndex = 9;
            BackGroundInfo.TabStop = false;
            // 
            // SignUpLabel
            // 
            SignUpLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SignUpLabel.AutoSize = true;
            SignUpLabel.BackColor = Color.FromArgb(43, 43, 43);
            SignUpLabel.FlatStyle = FlatStyle.Flat;
            SignUpLabel.Font = new Font("Segoe UI", 40F);
            SignUpLabel.ForeColor = SystemColors.Window;
            SignUpLabel.Location = new Point(850, 100);
            SignUpLabel.Name = "SignUpLabel";
            SignUpLabel.Size = new Size(279, 89);
            SignUpLabel.TabIndex = 10;
            SignUpLabel.Text = "Đăng ký";
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
            // SignUpButton
            // 
            SignUpButton.BackColor = Color.Gray;
            SignUpButton.FlatAppearance.BorderSize = 0;
            SignUpButton.FlatAppearance.MouseOverBackColor = Color.DimGray;
            SignUpButton.FlatStyle = FlatStyle.Flat;
            SignUpButton.Font = new Font("Segoe UI", 28F);
            SignUpButton.ForeColor = SystemColors.Window;
            SignUpButton.Location = new Point(1050, 800);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(300, 70);
            SignUpButton.TabIndex = 15;
            SignUpButton.Text = "Đăng ký";
            SignUpButton.UseVisualStyleBackColor = false;
            // 
            // EmailSignUpTextbox
            // 
            EmailSignUpTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EmailSignUpTextbox.BackColor = Color.FromArgb(64, 64, 64);
            EmailSignUpTextbox.Font = new Font("Segoe UI", 32F);
            EmailSignUpTextbox.Location = new Point(600, 284);
            EmailSignUpTextbox.Name = "EmailSignUpTextbox";
            EmailSignUpTextbox.Size = new Size(154, 78);
            EmailSignUpTextbox.TabIndex = 17;
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
            // PasswordSignUpTextbox
            // 
            PasswordSignUpTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PasswordSignUpTextbox.BackColor = Color.FromArgb(64, 64, 64);
            PasswordSignUpTextbox.Font = new Font("Segoe UI", 32F);
            PasswordSignUpTextbox.Location = new Point(600, 480);
            PasswordSignUpTextbox.Name = "PasswordSignUpTextbox";
            PasswordSignUpTextbox.Size = new Size(154, 78);
            PasswordSignUpTextbox.TabIndex = 18;
            // 
            // ConfirmPasswordTextbox
            // 
            ConfirmPasswordTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ConfirmPasswordTextbox.BackColor = Color.FromArgb(64, 64, 64);
            ConfirmPasswordTextbox.Font = new Font("Segoe UI", 32F);
            ConfirmPasswordTextbox.Location = new Point(600, 676);
            ConfirmPasswordTextbox.Name = "ConfirmPasswordTextbox";
            ConfirmPasswordTextbox.Size = new Size(154, 78);
            ConfirmPasswordTextbox.TabIndex = 21;
            // 
            // ConfirmPasswordLabel
            // 
            ConfirmPasswordLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ConfirmPasswordLabel.AutoSize = true;
            ConfirmPasswordLabel.BackColor = Color.FromArgb(43, 43, 43);
            ConfirmPasswordLabel.FlatStyle = FlatStyle.Flat;
            ConfirmPasswordLabel.Font = new Font("Segoe UI", 32F);
            ConfirmPasswordLabel.ForeColor = SystemColors.Window;
            ConfirmPasswordLabel.Location = new Point(600, 581);
            ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            ConfirmPasswordLabel.Size = new Size(567, 72);
            ConfirmPasswordLabel.TabIndex = 20;
            ConfirmPasswordLabel.Text = "Xác nhận lại mật khẩu:";
            // 
            // SignUp
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1331, 844);
            Controls.Add(ConfirmPasswordTextbox);
            Controls.Add(ConfirmPasswordLabel);
            Controls.Add(PasswordSignUpTextbox);
            Controls.Add(EmailSignUpTextbox);
            Controls.Add(SignUpButton);
            Controls.Add(PasswordLabel);
            Controls.Add(EmailLabel);
            Controls.Add(SignUpLabel);
            Controls.Add(RankingButton);
            Controls.Add(HomeButton);
            Controls.Add(Bar);
            Controls.Add(BackGroundInfo);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SignUp";
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
        private Label SignUpLabel;
        private Label EmailLabel;
        private Button SignUpButton;
        private TextBox EmailSignUpTextbox;
        private Label PasswordLabel;
        private TextBox PasswordSignUpTextbox;
        private TextBox ConfirmPasswordTextbox;
        private Label ConfirmPasswordLabel;
    }
}
