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
            txtbxFName.Focus();
        }

        private void btnClearValues_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            procedureClearForm();
        }
    }
}
