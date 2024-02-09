using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace SkillsInternationalStudentManager
{
    public partial class frmStudentsManager : Form
    {
        public frmStudentsManager()
        {
            InitializeComponent();
        }

        private void frmStudentsManager_Load(object sender, EventArgs e)
        {
            procedureGetDataAndFillListBox();
        }

        private void procedureGetDataAndFillListBox()
        {
            try
            {
                string varSqlQuery = "SELECT StudentRegNo From tb_StudentRecords";
                SqlDataAdapter varSqlAdapter = new SqlDataAdapter(varSqlQuery, classPublicVariables.varSqlConnectionString);
                classPublicVariables.varSqlConnectionString.Open();
                DataSet arrayDataSet = new DataSet();
                varSqlAdapter.Fill(arrayDataSet, "tb_StudentRecords");
                lstbxStudentRegNo.ValueMember = "StudentRegNo";
                lstbxStudentRegNo.DataSource = arrayDataSet.Tables["tb_StudentRecords"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                classPublicVariables.varSqlConnectionString.Close();
                lstbxStudentRegNo.SelectedIndex = 0;
            }
        }

        private void frmStudentsManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.communicator.varIsManageStudentsWindowOpen = false;
            Form1.communicator.toolbarbtnManageStudents.Checked = false;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            Form1.communicator.procedureShowCreateStudentWindow();
        }

        private void lstbxStudentRegNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                btnAddStudent.Enabled = true;
                btnEditStudent.Enabled = true;
                btnRemoveStudent.Enabled = true;
            }
            catch
            {
                btnAddStudent.Enabled = false;
                btnEditStudent.Enabled = false;
                btnRemoveStudent.Enabled = false;
            }
        }

        private void btnRefreshDB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            procedureGetDataAndFillListBox();
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            string varSqlQuery = "SELECT * FROM tb_StudentRecords WHERE StudentRegNo='" + lstbxStudentRegNo.GetItemText(lstbxStudentRegNo.SelectedItem) + "';";
            SqlCommand varSqlCommand = new SqlCommand(varSqlQuery, classPublicVariables.varSqlConnectionString);
            classPublicVariables.varSqlConnectionString.Open();

            SqlDataReader arrayDataReader;
            string Gender;

            Form varFrmEditStudent = new frmEditStudents();            

            arrayDataReader = varSqlCommand.ExecuteReader();
            if (arrayDataReader.HasRows == true)
            {
                while (arrayDataReader.Read())
                {
                    frmEditStudents.communicator.txtbxFName.Text = arrayDataReader["StudentFirstName"].ToString();
                    frmEditStudents.communicator.txtbxLName.Text = arrayDataReader["StudentLastName"].ToString();
                    frmEditStudents.communicator.dtpDOB.Text = arrayDataReader["StudentDOB"].ToString();
                    Gender = arrayDataReader["StudentGender"].ToString();
                    if (Gender == "Female")
                    {
                        frmEditStudents.communicator.radiobtnFemale.Checked = true;
                        frmEditStudents.communicator.radiobtnMale.Checked = false;
                    }
                    else
                    {
                        frmEditStudents.communicator.radiobtnMale.Checked = true;
                        frmEditStudents.communicator.radiobtnFemale.Checked = false;
                    }
                    frmEditStudents.communicator.txtbxAddress.Text = arrayDataReader["StudentAddress"].ToString();
                    frmEditStudents.communicator.txtbxEmail.Text = arrayDataReader["StudentEmail"].ToString();
                    frmEditStudents.communicator.txtbxMPhone.Text = arrayDataReader["StudentHomePhone"].ToString();
                    frmEditStudents.communicator.txtbxHPhone.Text = arrayDataReader["StudentMobilePhone"].ToString();
                    frmEditStudents.communicator.txtbxParentNIC.Text = arrayDataReader["ParentNIC"].ToString();
                    frmEditStudents.communicator.txtbxParentName.Text = arrayDataReader["ParentName"].ToString();
                    frmEditStudents.communicator.txtbxParentPhone.Text = arrayDataReader["ParentContactNo"].ToString();
                }

                frmEditStudents.communicator.lblTitle.Text = "Edit this student: " + frmEditStudents.communicator.txtbxFName.Text + " "+ frmEditStudents.communicator.txtbxLName.Text;
                frmEditStudents.communicator.lblRegNo.Text = "Registraton number: "+ lstbxStudentRegNo.GetItemText(lstbxStudentRegNo.SelectedItem);
                frmEditStudents.communicator.varRegNo = int.Parse(lstbxStudentRegNo.GetItemText(lstbxStudentRegNo.SelectedItem));
                varFrmEditStudent.MdiParent = Form1.communicator;
                varFrmEditStudent.Show();
                varFrmEditStudent.Focus();
            }            
            else
            {
                MessageBox.Show("Record Data not found", "data");
            }
            classPublicVariables.varSqlConnectionString.Close();
        }
    }
}
