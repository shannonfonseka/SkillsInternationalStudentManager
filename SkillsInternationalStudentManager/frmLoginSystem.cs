namespace SkillsInternationalStudentManager
{
    public partial class frmLoginSystem : Form
    {
        public bool varIsLoggedIn = false;
        public frmLoginSystem()
        {
            InitializeComponent();
        }

        private void btnExitSystem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void frmLoginSystem_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (varIsLoggedIn == false)
            {
                e.Cancel = true;
                Environment.Exit(0);
            }
        }

        private void chkbxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxShowPassword.Checked)
            {
                txtbxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtbxPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtbxUsername.Text == "Admin" && txtbxPassword.Text == "Skills@123")
            {
                Form1.communicator.Enabled = true;
                Form1.communicator.toolbarMain.Enabled = true;
                //Form1.communicator.toolbarMain.Visible = true;
                Form1.communicator.menuMain.Enabled = true;
                Form1.communicator.toolbarbtnNoticeBoard.Checked = true;
                Form1.communicator.menuitemNoticeBoard.Checked = true;
                Form1.communicator.panelNoticeBoard.Visible = true;
                varIsLoggedIn = true;
                Close();
            }
            else
            {
                MessageBox.Show("Invalid password, please re-enter correct credential");
            }
        }
    }
}
