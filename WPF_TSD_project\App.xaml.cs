using System; 
using System.Windows;

namespace WPF_TSD_project
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Console.WriteLine("Application démarre !");
        }
    }
}
