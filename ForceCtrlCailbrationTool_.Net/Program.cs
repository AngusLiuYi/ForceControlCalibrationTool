using System.Security.Cryptography.X509Certificates;

namespace ForceCtrlCailbrationTool_.Net_x._0_
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Frm_Main frm_Main = new();
            Application.Run(frm_Main);
            switch (frm_Main.IsStartGuide)
            {
                case 2:
                    Application.Run(new Frm_Basic(2));break;
                default:
                    break;
            }

        }
    }
}