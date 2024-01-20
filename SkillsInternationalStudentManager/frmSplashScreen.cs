namespace SkillsInternationalStudentManager
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }
        private void frmSplashScreen_Shown(object sender, EventArgs e)
        {
            timer1.Interval = 4500;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Form1 varMainForm = new Form1();
            Hide();
            varMainForm.Show();         
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
