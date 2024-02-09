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
    public partial class frmManageTeachers : Form
    {
        public frmManageTeachers()
        {
            InitializeComponent();
        }

        private void frmManageTeachers_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.communicator.varIsManageTeachersWindowOpen = false;
            Form1.communicator.toolbarbtnManageTeachers.Checked = false;
        }

        private void frmManageTeachers_Load(object sender, EventArgs e)
        {            
            Form1.communicator.procedureShowFeatureDeprecation();
            Thread.Sleep(900);
            //Close();
        }
    }
}
