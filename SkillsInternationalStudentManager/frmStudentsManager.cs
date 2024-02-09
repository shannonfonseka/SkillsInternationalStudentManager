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
                string varSqlQuery = "SELECT StudentFirstName From tb_StudentRecords";
                SqlDataAdapter varSqlAdapter = new SqlDataAdapter(varSqlQuery, classPublicVariables.varSqlConnectionString);
                classPublicVariables.varSqlConnectionString.Open();
                DataSet arrayDataSet = new DataSet();
                varSqlAdapter.Fill(arrayDataSet, "tb_StudentRecords");
                lstbxStudentName.ValueMember = "StudentFirstName";
                lstbxStudentName.DataSource = arrayDataSet.Tables["tb_StudentRecords"];
                classPublicVariables.varSqlConnectionString.Close();

                string varSqlQuery2 = "SELECT StudentRegNo From tb_StudentRecords";
                SqlDataAdapter varSqlAdapter2 = new SqlDataAdapter(varSqlQuery2, classPublicVariables.varSqlConnectionString);
                classPublicVariables.varSqlConnectionString.Open();
                DataSet arrayDataSet2 = new DataSet();
                varSqlAdapter2.Fill(arrayDataSet2, "tb_StudentRecords");
                lstbxStudentRegNo.ValueMember = "StudentRegNo";
                lstbxStudentRegNo.DataSource = arrayDataSet2.Tables["tb_StudentRecords"];

                lstbxStudentName.SelectedIndex = 0;
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

        private void frmStudentsManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.communicator.varIsManageStudentsWindowOpen = false;
            Form1.communicator.toolbarbtnManageStudents.Checked = false;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            Form1.communicator.procedureShowCreateStudentWindow();
        }

        private void lstbxStudentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lstbxStudentRegNo.SelectedIndex = lstbxStudentName.SelectedIndex;
                btnAddStudent.Enabled = true;
                btnEditStudent.Enabled = true;
                btnRemoveStudent.Enabled = true;
            }
            catch {
                btnAddStudent.Enabled = false;
                btnEditStudent.Enabled = false;
                btnRemoveStudent.Enabled = false;
            }
        }
    }
}
