using System.Windows.Forms;

namespace Chessgame
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            
        }

        private void RankingButton_Click(object sender, EventArgs e)
        {
            
        }

        private void SignUpLabel_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}