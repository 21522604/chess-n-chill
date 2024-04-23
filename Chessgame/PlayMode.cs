using System.Windows.Forms;

namespace Chessgame
{
    public partial class PlayMode : Form
    {
        public PlayMode()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Dispose();
            this.Close();
        }

        private void HumanPlayButton_Click(object sender, EventArgs e)
        {
            PlayModeSub playModeSub = new PlayModeSub();
            playModeSub.Show();
            this.Dispose();
            this.Close();
        }

        private void AIPlayButton_Click(object sender, EventArgs e)
        {

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
    }
}