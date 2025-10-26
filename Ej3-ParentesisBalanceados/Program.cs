namespace VerificadorParentesis
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Para .NET Framework clásico:
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            // Si usas .NET 6+ (WinForms):
            // ApplicationConfiguration.Initialize();
            // Application.Run(new Form1());
        }
    }
}
