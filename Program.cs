using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MoveDefaultUserFolders
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
        Form mainForm = new Form1();
        Form infoForm = new infoForm();
            
        Application.Run(mainForm);
        infoForm.MdiParent = mainForm;
        }


    }
}
