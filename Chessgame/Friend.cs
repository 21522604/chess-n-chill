using System.Windows.Forms;

namespace Chessgame
{
    /*public partial class PopupUserControl : UserControl
    {
        public PopupUserControl()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(100, Color.Black);
            this.Visible = false;
        }
    }*/
    public partial class Friend : Form
    {
        //PopupUserControl popup = new PopupUserControl();
        public Friend()
        {
            InitializeComponent();
            //this.Controls.Add(popup);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.Show();
            this.Close();
        }

        private void FindFriendButton_Click(object sender, EventArgs e)
        {

        }
    }
}