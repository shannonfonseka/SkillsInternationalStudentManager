﻿using Microsoft.Data.SqlClient;
using System.Data;

namespace SkillsInternationalStudentManager
{
    public partial class frmLoginSystem : Form
    {
        public bool varIsLoggedInSuccessfully = false;
        public frmLoginSystem()
        {
            InitializeComponent();
            radiobtnTeacher.Checked = true;
            Form1.communicator.menuAccessLevel.Text = "Undefined Access Level";
        }

        private void btnExitSystem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult varDialogResult = MessageBox.Show("Are you sure you want to exit this system?","Exit confirmation dialog",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (varDialogResult == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void frmLoginSystem_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (varIsLoggedInSuccessfully == false)
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
            try
            {
                Cursor = Cursors.WaitCursor;
                string varTxtBxUsername = txtbxUsername.Text;
                string varTxtBxPassword = txtbxPassword.Text;
                SqlDataAdapter varSqlAdapter = null;
                if (radiobtnAdmin.Checked)
                {
                    varSqlAdapter = new SqlDataAdapter("SELECT COUNT(*) FROM tb_AdminLogin WHERE Username='" + txtbxUsername.Text + "' AND Password='" + txtbxPassword.Text + "' AND IsAdminRole=1;", classPublicVariables.varSqlConnectionString);
                }
                else
                {
                    varSqlAdapter = new SqlDataAdapter("SELECT COUNT(*) FROM tb_AdminLogin WHERE Username='" + txtbxUsername.Text + "' AND Password='" + txtbxPassword.Text + "' AND IsAdminRole=0;", classPublicVariables.varSqlConnectionString);
                }
                DataTable arrayDataTable = new DataTable();
                varSqlAdapter.Fill(arrayDataTable);
                if (arrayDataTable.Rows[0][0].ToString() == "1")
                {
                    Cursor = Cursors.Default;
                    if (radiobtnAdmin.Checked)
                    {
                        MessageBox.Show("You are now logged as an administrator. You have full access to this system.", "Login information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Form1.communicator.menuAccessLevel.Text = "Administrator Access Mode";
                        Form1.communicator.menuDatabase.Enabled = true;
                        Form1.communicator.menuSchool.Enabled = true;
                        Form1.communicator.menuReports.Enabled = true;
                        Form1.communicator.menuTeachers.Enabled = true;
                        Form1.communicator.menuitemAddStudent.Enabled = true;
                        Form1.communicator.menuitemManageStudents.Enabled = true;
                        Form1.communicator.menuitemManageParents.Enabled = true;
                        Form1.communicator.menuitemStudentHealthRecords.Enabled = true;
                        Form1.communicator.toolbarbtnManageStudents.Enabled = true;
                        Form1.communicator.toolbarbtnManageClassrooms.Enabled = true;
                        Form1.communicator.toolbarbtnManageTeachers.Enabled = true;
                        Form1.communicator.toolbarbtnAddStudent.Enabled = true;
                        Form1.communicator.toolbarbtnManageTimetables.Enabled = true;
                        Form1.communicator.toolbardrpdownbtnReportsWizard.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("You are now logged as a teacher. You have limited access to this system.", "Login information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Form1.communicator.menuAccessLevel.Text = "Teacher Access Mode";
                        Form1.communicator.menuDatabase.Enabled = false;
                        Form1.communicator.menuSchool.Enabled = false;
                        Form1.communicator.menuReports.Enabled=false;
                        Form1.communicator.menuTeachers.Enabled = false;
                        Form1.communicator.menuitemAddStudent.Enabled = false;
                        Form1.communicator.menuitemManageStudents.Enabled = false;
                        Form1.communicator.menuitemManageParents.Enabled = false;
                        Form1.communicator.menuitemStudentHealthRecords.Enabled = false;
                        Form1.communicator.toolbarbtnManageStudents.Enabled = false;
                        Form1.communicator.toolbarbtnManageClassrooms.Enabled = false;
                        Form1.communicator.toolbarbtnManageTeachers.Enabled = false;
                        Form1.communicator.toolbarbtnAddStudent.Enabled = false;
                        Form1.communicator.toolbarbtnManageTimetables.Enabled = false;
                        Form1.communicator.toolbardrpdownbtnReportsWizard.Enabled= false;
                    }
                    Form1.communicator.Enabled = true;
                    Form1.communicator.toolbarMain.Enabled = true;
                    //Form1.communicator.toolbarMain.Visible = true;
                    Form1.communicator.menuMain.Enabled = true;
                    Form1.communicator.toolbarbtnNoticeBoard.Checked = true;
                    Form1.communicator.menuitemNoticeBoard.Checked = true;
                    Form1.communicator.panelNoticeBoard.Visible = true;
                    varIsLoggedInSuccessfully = true;
                    Close();
                }
                else
                {
                    Cursor = Cursors.Default;
                    MessageBox.Show("Invalid username, password or role selected. Use only the administrator and teacher login credentials only.", "Login attempt error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnClearFields_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtbxPassword.Text = string.Empty;
            txtbxUsername.Text = string.Empty;
            radiobtnTeacher.Checked = true;
            txtbxUsername.Focus();
        }

        private void radiobtnAdmin_CheckedChanged(object sender, EventArgs e)
        {
            txtbxUsername.Text = "Admin";
            txtbxUsername.Enabled = false;
            lblUsername.Text = "Administrator username";
            lblPassword.Text = "Enter administrator password below";
            txtbxPassword.Focus();
        }

        private void radiobtnTeacher_CheckedChanged(object sender, EventArgs e)
        {
            txtbxUsername.Text = string.Empty;
            txtbxUsername.Enabled = true;
            lblUsername.Text = "Enter username for teacher below";
            lblPassword.Text = "Enter password for teacher below";
            txtbxUsername.Focus();
        }

        private void btnAboutProgram_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1.communicator.procedureShowAboutProgramMessageBox();
        }
    }
}
