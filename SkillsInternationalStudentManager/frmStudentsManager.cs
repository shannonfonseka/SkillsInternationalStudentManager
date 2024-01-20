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
        }
    }
}
