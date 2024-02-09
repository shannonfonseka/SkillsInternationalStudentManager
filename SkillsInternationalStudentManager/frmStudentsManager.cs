using Microsoft.Data.SqlClient;
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
                classPublicVariables.varSqlConnectionString.Close();
                if (lstbxStudentRegNo.Items.Count == 0)
                {
                    btnAddStudent.Enabled = true;
                    btnEditStudent.Enabled = false;
                    btnRemoveStudent.Enabled = false;
                }
                else
                {
                    btnAddStudent.Enabled = true;
                    btnEditStudent.Enabled = true;
                    btnRemoveStudent.Enabled = true;
                }
                lstbxStudentRegNo.SelectedIndex = 0;                 
            }
            catch (Exception ex)
            {
                if (!ex.Message.Contains("Value of '0'"))
                {
                    MessageBox.Show(ex.Message);                    
                }
            }
            finally
            {
                classPublicVariables.varSqlConnectionString.Close();
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
            { }
            catch
            { }
        }

        private void btnRefreshDB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            procedureGetDataAndFillListBox();
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            procedureShowEditStudentsWindow();
        }

        private void lstbxStudentRegNo_DoubleClick(object sender, EventArgs e)
        {
            if (lstbxStudentRegNo.Items.Count !=0)
            {
                procedureShowEditStudentsWindow();
            }            
        }

        private void procedureShowEditStudentsWindow()
        {
            try
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
                    classPublicVariables.varSqlConnectionString.Close();
                    frmEditStudents.communicator.lblTitle.Text = "Edit this student: " + frmEditStudents.communicator.txtbxFName.Text + " " + frmEditStudents.communicator.txtbxLName.Text;
                    frmEditStudents.communicator.lblRegNo.Text = "Registration number: " + lstbxStudentRegNo.GetItemText(lstbxStudentRegNo.SelectedItem);
                    frmEditStudents.communicator.varRegNo = int.Parse(lstbxStudentRegNo.GetItemText(lstbxStudentRegNo.SelectedItem));
                    varFrmEditStudent.MdiParent = Form1.communicator;
                    varFrmEditStudent.Show();
                    varFrmEditStudent.Focus();
                }
                else
                {
                    MessageBox.Show("Record Data not found", "No data");
                }
                classPublicVariables.varSqlConnectionString.Close();
            }
            catch { }
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult varDialogResult = MessageBox.Show("Are you sure you want to delete this record? Please note that this change is irreversible! Be certain.", "Record deletion confirmation dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (varDialogResult == DialogResult.Yes)
                {
                    string varSqlQuery = "DELETE FROM tb_StudentRecords WHERE StudentRegNo='" + lstbxStudentRegNo.GetItemText(lstbxStudentRegNo.SelectedItem) + "';";
                    SqlCommand varSqlCommand = new SqlCommand(varSqlQuery,
                   classPublicVariables.varSqlConnectionString);
                    classPublicVariables.varSqlConnectionString.Open();
                    varSqlCommand.ExecuteNonQuery();
                    MessageBox.Show("One record deleted successfully!", "Database operation message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    classPublicVariables.varSqlConnectionString.Close();
                    procedureGetDataAndFillListBox();
                }
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
