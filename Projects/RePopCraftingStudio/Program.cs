using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace RePopCraftingStudio
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += Application_ThreadException;
            Application.Run(new MainForm());
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            Debug.WriteLine(e.Exception);
        }
    }
}
