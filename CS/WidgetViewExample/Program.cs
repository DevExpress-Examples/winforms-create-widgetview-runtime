// Developer Express Code Central Example:
// How To: Create WidgetView at runtime
// 
// This example demonstrates how to create and customize WidgetView with 2
// StackGroups at runtime.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E5003

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WidgetViewExample {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
