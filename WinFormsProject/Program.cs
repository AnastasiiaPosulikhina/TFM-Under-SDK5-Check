using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsProject
{
    static class Program
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /* TODO (Check that in WinForms projects debugger works both with .dll and .exe files in Exe path)
             1. Add a breakpoint to line 31
             2. Debug WinFormsProject
                EXPECTED: the project runs and stops on a breakpoint
             3. Stop debugging
             4. Change Exe path in Run/Debug Configurations to a .dll file.
             5. Debug WpfProject again
                EXPECTED: the project runs and stops on a breakpoint
            */
            
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

    }
}