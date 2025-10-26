using System;
using System.Windows.Forms;

namespace PilaDePalabras
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // .NET Framework clásico
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            // .NET 6+ (opcional):
            // ApplicationConfiguration.Initialize();
            // Application.Run(new Form1());
        }
    }
}
