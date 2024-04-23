using System.Windows.Forms;

namespace Chessgame
{
    public partial class Friend : Form
    {
        public Friend()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.Show();
            this.Dispose();
            this.Close();
        }

        private void FindFriendButton_Click(object sender, EventArgs e)
        {
            FindFriend popupForm = new FindFriend();
            popupForm.ShowDialog();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Dispose();
            this.Close();
        }

        private void RankingButton_Click(object sender, EventArgs e)
        {
            RankingBoard board = new RankingBoard();
            board.Show();
            this.Dispose();
            this.Close();
        }

        private void DeleteFriendButton_Click(object sender, EventArgs e)
        {

        }
    }
}