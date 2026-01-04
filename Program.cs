using Learning_Tracker.Forms;
using System.Diagnostics;
namespace Learning_Tracker
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
            Debug.WriteLine("【DEBUG】LoginForm 构造函数被调用");
            Application.Run(new LoginForm());
        }
    }
}