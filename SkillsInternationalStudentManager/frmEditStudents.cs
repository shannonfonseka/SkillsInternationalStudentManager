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
    }
}
