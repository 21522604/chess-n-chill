using System.Windows.Forms;

namespace Chessgame
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void FriendListButton_Click(object sender, EventArgs e)
        {
            Friend friend = new Friend();
            friend.Show();
            this.Hide();
        }

        private void ChangeInfoAccountButton_Click(object sender, EventArgs e)
        {
            ChangeInfoAccount changeInfoAccount = new ChangeInfoAccount();
            changeInfoAccount.Show();
            this.Hide();
        }
    }
}