using System.Windows.Forms;
using WMPLib;
namespace Chessgame
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            PlayMode playMode = new PlayMode();
            playMode.Show();
            this.Hide();
        }

        private void AccountButton_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.Show();
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            Application.Exit();
        }

        private void RankingButton_Click(object sender, EventArgs e)
        {
            RankingBoard board = new RankingBoard();
            board.Show();
            this.Hide();
        }

        private void SoundChange(object sender, EventArgs e)
        {
            AudioManager.SetVolume(SoundSetting.Value*10);
        }
    }
}