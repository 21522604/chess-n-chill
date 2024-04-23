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
            this.Close();
        }

        private void HumanPlayButton_Click(object sender, EventArgs e)
        {
            PlayModeSub playModeSub = new PlayModeSub();
            playModeSub.Show();
            this.Hide();
        }

        private void AIPlayButton_Click(object sender, EventArgs e)
        {

        }
    }
}