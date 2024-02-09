using Microsoft.Data.SqlClient;

namespace SkillsInternationalStudentManager
{
    public partial class frmCreateStudent : Form
    {
        SqlConnection varSqlConnectionString = new SqlConnection(@"Data Source=MARIE-DELL-PC;Initial Catalog=db_SkillsStudentManager;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
        public frmCreateStudent()
        {
            InitializeComponent();
        }

        private void frmCreateStudent_Load(object sender, EventArgs e)
        {

        }

        private void frmCreateStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.communicator.varIsCreateStudentsWindowOpen = false;
            Form1.communicator.toolbarbtnAddStudent.Checked = false;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbxRegNo.Text != "" && txtbxFName.Text != "" && txtbxLName.Text != "" && txtbxAddress.Text != "" && txtbxMPhone.Text != "" && txtbxHPhone.Text != "" && txtbxParentName.Text != "" && txtbxParentNIC.Text != "" && txtbxParentPhone.Text != "")
                {
                    int varRegNo = int.Parse(txtbxRegNo.Text.ToString());
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
                    string varSqlQuery = "INSERT INTO tb_StudentRecords VALUES('" +
                    varRegNo + "','" +
                    varFirstName + "','" +
                    varLastName + "','" +
                    varDOB + "','" +
                    varGender + "','" +
                    varAddress + "','" +
                    varEmailAddress + "','" +
                    varMPhone + "','" +
                    varHPhone + "','" +
                    varParentName + "','" +
                    varParentNIC + "','" +
                    varParentPhone + "');";
                    SqlCommand varSqlCommand = new SqlCommand(varSqlQuery,
                   varSqlConnectionString);
                    varSqlConnectionString.Open();
                    varSqlCommand.ExecuteNonQuery();
                    MessageBox.Show("One record added successfully!", "Database operation message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    procedureClearForm();
                }
                else
                {
                    MessageBox.Show("All required fields have not been entered! Please review the fields again.", "Missing fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                varSqlConnectionString.Close();
            }
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

        private void btnManageStudents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1.communicator.procedureShowManageStudentsWindow();
        }
    }
}
