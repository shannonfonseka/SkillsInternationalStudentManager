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
    public partial class frmCreateStudent : Form
    {
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
        
    }
}
