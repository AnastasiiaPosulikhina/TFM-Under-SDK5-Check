using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /* TODO (Check that in WPF projects debugger works both with .dll and .exe files in Exe path)
         1. Add a breakpoint to line 35
         2. Debug WpfProject
            EXPECTED: the project runs and stops on a breakpoint
         3. Stop debugging
         4. Change Exe path in Run/Debug Configurations to a .dll file.
         5. Debug WpfProject again
            EXPECTED: the project runs and stops on a breakpoint
        */

        public MainWindow()
        {
            InitializeComponent();
        }

    }
}