using System.Threading;

namespace SkillsInternationalStudentManager
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        // Mutex can be made static so that GC doesn't recycle
        // same effect with GC.KeepAlive(mutex) at the end of main
        static Mutex mutex = new Mutex(false, "some-unique-id");

        [STAThread]
        static void Main()
        {
            // if you like to wait a few seconds in case that the instance is just 
            // shutting down
            if (!mutex.WaitOne(TimeSpan.FromSeconds(2), false))
            {
                MessageBox.Show("Application already started!", "", MessageBoxButtons.OK);
                return;
            }

            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(true);
                ApplicationConfiguration.Initialize();
                Application.Run(new frmSplashScreen());
            }
            finally { mutex.ReleaseMutex(); } // I find this more explicit

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new frmSplashScreen());
        }
    }
}