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
    public partial class frmLoginSystem : Form
    {
        public bool varIsLoggedIn = false;
        public frmLoginSystem()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form1.communicator.Enabled = true;
            Form1.communicator.toolbarMain.Enabled = true;
            Form1.communicator.toolbarMain.Visible = true;
            Form1.communicator.menuMain.Enabled = true;
            Form1.communicator.panelNoticeBoard.Visible= true;
            varIsLoggedIn= true;
            Close();
        }

        private void btnExitSystem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void frmLoginSystem_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (varIsLoggedIn==false)
            {
                e.Cancel = true;
                Environment.Exit(0);
            }            
        }
    }
}
