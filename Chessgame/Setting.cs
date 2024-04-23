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

        private void ExitButton_Click(object sender, EventArgs e)
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

        private void SoundChange(object sender, EventArgs e)
        {
            AudioManager.SetVolume(SoundSetting.Value * 10);
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Dispose();
            this.Close();
        }
    }
}