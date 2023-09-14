using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mehran.Institute
{
    internal static class Program
    {
        public static ApplicationContext AppContext { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Program.AppContext = new ApplicationContext(new frmLogin());
            Application.Run(AppContext);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fa-IR"); Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fa-IR");
        }

        public static void SwitchMainForm(Form newForm)
        {
            var oldMainForm = AppContext.MainForm;
            AppContext.MainForm = newForm;
            oldMainForm?.Close();
            newForm?.Show();
        }
    }
}
