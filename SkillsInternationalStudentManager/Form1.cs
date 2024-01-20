namespace SkillsInternationalStudentManager
{
    public partial class Form1 : Form
    {
        public static Form1 communicator;
        public bool varIsManageStudentsWindowOpen = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            communicator = this;
            WindowState = FormWindowState.Maximized;
            procedureShowLogInWindow();
        }

        private void procedureShowLogInWindow()
        {
            toolbarMain.Enabled = false;
            menuMain.Enabled = false;
            frmLoginSystem varFrmLoginSystem = new frmLoginSystem();
            //varFrmLoginSystem.MdiParent = this;
            varFrmLoginSystem.ShowDialog();
        }
        private void procedureLogOut()
        {
            string message = "Are you sure you want to log out? Any active windows will close when you select 'Yes'.";
            string caption = "Log out system";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            MessageBoxIcon icon = MessageBoxIcon.Question;


            result = MessageBox.Show(message, caption, buttons, icon);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Form[] childArray = MdiChildren;
                foreach (Form childform in childArray)
                {
                    childform.Close();
                }
                procedureShowLogInWindow();
            }
        }

        private void procedureShowManageStudentsWindow()
        {
            if (varIsManageStudentsWindowOpen == false)
            {
                frmStudentsManager varFrmStudentsManager = new frmStudentsManager();
                varFrmStudentsManager.MdiParent = this;
                varFrmStudentsManager.Show();
                varFrmStudentsManager.Focus();
                varIsManageStudentsWindowOpen = true;
            }
        }

        private void menuitemLogOutSystem_Click(object sender, EventArgs e)
        {
            procedureLogOut();
        }

        private void toolbarbtnLogOutSystem_Click(object sender, EventArgs e)
        {
            procedureLogOut();
        }

        private void menuitemManageStudents_Click(object sender, EventArgs e)
        {
            procedureShowManageStudentsWindow();
        }

        private void toolbarbtnManageStudents_Click(object sender, EventArgs e)
        {
            procedureShowManageStudentsWindow();
        }

        private void menuitemExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
