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
    }
}
