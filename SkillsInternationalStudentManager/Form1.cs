namespace SkillsInternationalStudentManager
{
    public partial class Form1 : Form
    {
        public static Form1? communicator;
        public bool varIsManageStudentsWindowOpen = false;
        Form varFrmStudentsManager = new frmStudentsManager();
        public bool varIsCreateStudentsWindowOpen = false;
        Form varFrmCreateStudent = new frmCreateStudent();
        public bool varIsManageTeachersWindowOpen = false;
        Form varFrmManageTeachers = new frmManageTeachers();
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
            Form varFrmLoginSystem = new frmLoginSystem();
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

        public void procedureShowManageStudentsWindow()
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
        public void procedureShowCreateStudentWindow()
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

        public void procedureShowAboutProgramMessageBox()
        {
            MessageBox.Show("Skills International Student Manager (SISM)" + Environment.NewLine + "Version 01.01" + Environment.NewLine + Environment.NewLine + "(C) 2024 Shannon Fonseka. Made for ESOFT DiTech Final Project.", "About this program");
        }

        public void procedureShowManageTeachersWindow()
        {
            if (varFrmManageTeachers.WindowState == FormWindowState.Normal)
            {
                varFrmManageTeachers.WindowState = FormWindowState.Minimized;
            }
            else
            {
                varFrmManageTeachers.WindowState = FormWindowState.Normal;
            }
            if (varIsManageTeachersWindowOpen == false)
            {
                varFrmManageTeachers = new frmManageTeachers();
                varFrmManageTeachers.MdiParent = this;
                varFrmManageTeachers.Show();
                varFrmManageTeachers.Focus();
                varIsManageTeachersWindowOpen = true;
            }
            toolbarbtnManageTeachers.Checked = true;
            varFrmManageTeachers.Focus();
        }

        public void procedureShowFeatureDeprecation()
        {
            MessageBox.Show("This feature was intended to be coded, but kept for aesthetics.", "Feature Deprecation Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void toolbarbtnManageTeachers_Click(object sender, EventArgs e)
        {
            procedureShowManageTeachersWindow();
        }

        private void menuitemManageAdmins_Click(object sender, EventArgs e)
        {
            procedureShowFeatureDeprecation();
        }

        private void menuitemRefreshDatabase_Click(object sender, EventArgs e)
        {
            procedureShowFeatureDeprecation();
        }

        private void menuitemDbSummary_Click(object sender, EventArgs e)
        {
            procedureShowFeatureDeprecation();
        }

        private void menuitemManageSubjects_Click(object sender, EventArgs e)
        {
            procedureShowFeatureDeprecation();
        }

        private void menuitemManageTimetables_Click(object sender, EventArgs e)
        {
            procedureShowFeatureDeprecation();
        }

        private void menuitemManageClassrooms_Click(object sender, EventArgs e)
        {
            procedureShowFeatureDeprecation();
        }

        private void menuitemManageParents_Click(object sender, EventArgs e)
        {
            procedureShowFeatureDeprecation();
        }

        private void menuitemAttendanceTracking_Click(object sender, EventArgs e)
        {
            procedureShowFeatureDeprecation();
        }

        private void menuitemStudentHealthRecords_Click(object sender, EventArgs e)
        {
            procedureShowFeatureDeprecation();
        }

        private void menuitemFeesPayments_Click(object sender, EventArgs e)
        {
            procedureShowFeatureDeprecation();
        }

        private void menuAddTeacher_Click(object sender, EventArgs e)
        {
            procedureShowFeatureDeprecation();
        }

        private void menuManageTeachers_Click(object sender, EventArgs e)
        {
            procedureShowFeatureDeprecation();
        }

        private void menuitemReportsWizard_Click(object sender, EventArgs e)
        {
            procedureShowFeatureDeprecation();
        }

        private void menuitemStoredReports_Click(object sender, EventArgs e)
        {
            procedureShowFeatureDeprecation();
        }

        private void menuitemAbout_Click(object sender, EventArgs e)
        {
            procedureShowAboutProgramMessageBox();
        }

        private void toolbarbtnManageTimetables_Click(object sender, EventArgs e)
        {
            procedureShowFeatureDeprecation();
        }

        private void toolbarbtnManageClassrooms_Click(object sender, EventArgs e)
        {
            procedureShowFeatureDeprecation();
        }

        private void toolbarbtnAttendanceTracking_Click(object sender, EventArgs e)
        {
            procedureShowFeatureDeprecation();
        }

        private void toolbarbtnFeesPayments_Click(object sender, EventArgs e)
        {
            procedureShowFeatureDeprecation();
        }

        private void toolbarbtnCreateNewReportWizard_Click(object sender, EventArgs e)
        {
            procedureShowFeatureDeprecation();
        }

        private void toolbarbtnStoredReports_Click(object sender, EventArgs e)
        {
            procedureShowFeatureDeprecation();
        }
    }
}
