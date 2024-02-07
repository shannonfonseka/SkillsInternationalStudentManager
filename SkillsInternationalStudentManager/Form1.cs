namespace SkillsInternationalStudentManager
{
    public partial class Form1 : Form
    {
        public static Form1? communicator;
        public bool varIsManageStudentsWindowOpen = false;
        frmStudentsManager varFrmStudentsManager = new frmStudentsManager();
        public bool varIsCreateStudentsWindowOpen = false;
        frmCreateStudent varFrmCreateStudent = new frmCreateStudent();
        public Form1()
        {
            InitializeComponent();
            MinimumSize = new Size(1000, 600);
            Size = new Size(1000, 600);
            foreach (ToolStripItem tsi in toolbarMain.Items)
            {
                tsi.Text = tsi.Text.Replace("|", Environment.NewLine);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            communicator = this;
            WindowState = FormWindowState.Maximized;
            panelNoticeBoard.Visible = false;
            procedureShowLogInWindow();
        }

        private void procedureShowLogInWindow()
        {
            toolbarMain.Enabled = false;
            toolbarbtnNoticeBoard.Checked = false;
            menuMain.Enabled = false;
            frmLoginSystem varFrmLoginSystem = new frmLoginSystem();
            varFrmLoginSystem.ShowDialog();
        }
        private void procedureLogOut()
        {
            string message = "This session and any active windows will close. Make sure you save all information and log out. Do you want to log out?";
            string caption = "Log out system?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            result = MessageBox.Show(message, caption, buttons, icon);
            if (result == DialogResult.Yes)
            {
                Form[] childArray = MdiChildren;
                foreach (Form childform in childArray)
                {
                    childform.Close();
                }
                panelNoticeBoard.Visible = false;
                procedureShowLogInWindow();
            }
        }

        private void procedureShowManageStudentsWindow()
        {
            if (varFrmStudentsManager.WindowState == FormWindowState.Normal)
            {
                varFrmStudentsManager.WindowState = FormWindowState.Minimized;
            }
            else
            {
                varFrmStudentsManager.WindowState = FormWindowState.Normal;
            }
            if (varIsManageStudentsWindowOpen == false)
            {
                varFrmStudentsManager = new frmStudentsManager();
                varFrmStudentsManager.MdiParent = this;
                varFrmStudentsManager.Show();
                varFrmStudentsManager.Focus();
                varIsManageStudentsWindowOpen = true;
            }
            toolbarbtnManageStudents.Checked = true;
            varFrmStudentsManager.Focus();
        }
        private void procedureShowCreateStudentWindow()
        {
            if (varFrmCreateStudent.WindowState == FormWindowState.Normal)
            {
                varFrmCreateStudent.WindowState = FormWindowState.Minimized;
            }
            else
            {
                varFrmCreateStudent.WindowState = FormWindowState.Normal;
            }
            if (varIsCreateStudentsWindowOpen == false)
            {
                varFrmCreateStudent = new frmCreateStudent();
                varFrmCreateStudent.MdiParent = this;
                varFrmCreateStudent.Show();
                varFrmCreateStudent.Focus();
                varIsCreateStudentsWindowOpen = true;
            }
            toolbarbtnAddStudent.Checked = true;
            varFrmCreateStudent.Focus();
        }

        private void procedureShowOrHideNoticeBoard()
        {
            if (panelNoticeBoard.Visible)
            {
                panelNoticeBoard.Visible = false;
                toolbarbtnNoticeBoard.Checked = false;
                menuitemNoticeBoard.Checked = false;
            }
            else
            {
                panelNoticeBoard.Visible = true;
                toolbarbtnNoticeBoard.Checked = true;
                menuitemNoticeBoard.Checked = true;
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
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            procedureLogOut();
        }

        private void menuitemAddStudent_Click(object sender, EventArgs e)
        {
            procedureShowCreateStudentWindow();
        }

        private void toolbarbtnAddStudent_Click(object sender, EventArgs e)
        {
            procedureShowCreateStudentWindow();
        }

        private void toolbarbtnNoticeBoard_Click(object sender, EventArgs e)
        {
            procedureShowOrHideNoticeBoard();

        }

        private void menuitemNoticeBoard_Click(object sender, EventArgs e)
        {
            procedureShowOrHideNoticeBoard();

        }
    }
}
