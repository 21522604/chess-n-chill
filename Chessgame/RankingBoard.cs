using System.Data;
namespace Chessgame
{
    public partial class RankingBoard : Form
    {
        public RankingBoard()
        {
            InitializeComponent();
        }
        
        private void BackButton_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }
    }
}