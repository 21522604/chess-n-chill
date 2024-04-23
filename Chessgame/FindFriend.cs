using System.Windows.Forms;

namespace Chessgame
{
    public partial class FindFriend : Form
    {
        public FindFriend()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            
        }

        private void FindFriendButton_Click(object sender, EventArgs e)
        {
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {

        }

        private void RankingButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteFriendButton_Click(object sender, EventArgs e)
        {

        }

        private void AddFriendButton_Click(object sender, EventArgs e)
        {
            NotFoundLabel.Visible = true;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.Show();
            this.Dispose();
            this.Close();
        }
    }
}