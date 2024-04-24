using System.Windows.Forms;

namespace Chessgame
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();

        }

        private void RankingButton_Click(object sender, EventArgs e)
        {
            /*RankingBoard board = new RankingBoard();
            board.Show();
            this.Dispose();
            this.Close();*/
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            /*Home home = new Home();
            home.Show();
            this.Dispose();
            this.Close();*/
        }

        private void ChatInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReadyButton_Click(object sender, EventArgs e)
        {
            if (ReadyButton.FlatStyle == FlatStyle.Flat)
            {
                ReadyButton.FlatStyle = FlatStyle.System;
            }
            else
            {
                ReadyButton.FlatStyle = FlatStyle.Flat;
            }
        }

        private void GetLoseButton_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Dispose();
            this.Close();
        }
    }
}