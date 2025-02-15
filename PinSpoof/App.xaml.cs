using System.Windows;

namespace PinSpoof
{
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            PinWindow window = new PinWindow();
            window.Show();
        }
    }
}

