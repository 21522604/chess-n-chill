using System.Windows.Forms;

namespace Chessgame
{
    public partial class PlayModeSub : Form
    {
        public PlayModeSub()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            PlayMode playMode = new PlayMode();
            playMode.Show();
            this.Dispose();
            this.Close();
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

        private void RoomListButton_Click(object sender, EventArgs e)
        {

        }

        private void FindRoomButton_Click(object sender, EventArgs e)
        {
            FindRoom findRoom = new FindRoom();
            findRoom.Show();
            this.Close();
        }
    }
}