using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// These using lines are at the top of every code file.They tell
/// C# to use all of those .NET Framework classes. Each one tells
/// your program that the classes in this particular.cs file will use all
/// of the classes in one specific .NET Framework namespace.
    /// </summary>
namespace Contact
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
