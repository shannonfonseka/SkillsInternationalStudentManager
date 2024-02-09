using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkillsInternationalStudentManager
{
    public partial class frmEditStudents : Form
    {
        public int varRegNo = 0;
        public static frmEditStudents? communicator;
        public frmEditStudents()
        {
            InitializeComponent();
            communicator = this;
        }
        private void procedureClearForm()
        {
            txtbxFName.Clear();
            txtbxLName.Clear();
            dtpDOB.Value = DateTime.Now;
            txtbxAddress.Clear();
            txtbxEmail.Clear();
            txtbxMPhone.Clear();
            txtbxHPhone.Clear();
            txtbxParentName.Clear();
            txtbxParentNIC.Clear();
            txtbxParentPhone.Clear();
            txtbxFName.Focus();            
        }

        private void btnClearValues_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            procedureClearForm();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                string varFirstName = txtbxFName.Text;
                string varLastName = txtbxLName.Text;
                string varDOB = dtpDOB.Text;
                string varGender;
                if (radiobtnMale.Checked)
                { varGender = "Male"; }
                else
                { varGender = "Female"; }
                string varAddress = txtbxAddress.Text;
                string varEmailAddress = txtbxEmail.Text;
                int varMPhone = int.Parse(txtbxMPhone.Text);
                int varHPhone = int.Parse(txtbxHPhone.Text);
                string varParentName = txtbxParentName.Text;
                string varParentNIC = txtbxParentNIC.Text;
                int varParentPhone = int.Parse(txtbxParentPhone.Text);
                string varSqlQuery = "UPDATE tb_StudentRecords SET " +
                "StudentFirstName = '" + varFirstName + "', " +
                "StudentLastName = '" + varLastName + "', " +
                "StudentDOB = '" + varDOB + "', " +
                "StudentGender = '" + varGender + "', " +
                "StudentAddress = '" + varAddress + "', " +
                "StudentEmail = '" + varEmailAddress + "', " +
                "StudentMobilePhone = '" + varMPhone + "', " +
                "StudentHomePhone = '" + varHPhone + "', " +
                "ParentName = '" + varParentName + "', " +
                "ParentNIC = '" + varParentNIC + "', " +
                "ParentContactNo = '" + varParentPhone + "' " +
                "WHERE StudentRegNo = '" + varRegNo + "';";
                SqlCommand varSqlCommand = new SqlCommand(varSqlQuery,classPublicVariables.varSqlConnectionString);
                classPublicVariables.varSqlConnectionString.Open();
                varSqlCommand.ExecuteNonQuery();
                MessageBox.Show("One record modified successfully!", "Database operation message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                classPublicVariables.varSqlConnectionString.Close();
            }
        }
    }
}
