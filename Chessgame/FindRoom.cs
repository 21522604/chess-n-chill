using System.Windows.Forms;

namespace Chessgame
{
    public partial class FindRoom : Form
    {
        public FindRoom()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {

        }

        private void HomeButton_Click(object sender, EventArgs e)
        {

        }

        private void RankingButton_Click(object sender, EventArgs e)
        {

        }

        private void FindARoomButton_Click(object sender, EventArgs e)
        {
            NotFoundLabel.Visible = true;
        }

        private void ExitFindButton_Click(object sender, EventArgs e)
        {
            PlayModeSub playModeSub = new PlayModeSub();
            playModeSub.Show();
            this.Dispose();
            this.Close();
        }
    }
}