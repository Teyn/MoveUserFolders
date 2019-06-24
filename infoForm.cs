using System;
using System.Windows.Forms;

namespace MoveDefaultUserFolders
{
    public partial class infoForm : Form
    {
        public infoForm()
        {
            InitializeComponent();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Teyn/MoveDefaultUserFolders/blob/master/README.md");
        }

        private void GitHubLabel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Teyn/");
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
             System.Diagnostics.Process.Start("https://www.linkedin.com/in/gabor-k/");
        }

        private void LinkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paypal.me/teyn");
        }
    }
}
