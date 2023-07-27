using Software_de_taquilla.Views.AdminViews;

namespace Software_de_taquilla
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new DashboardAdmin(1));
        }
    }
}