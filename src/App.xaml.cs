using System;
using System.Windows;

namespace USBControlApp
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            // Initialize the main window
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            // Perform any necessary cleanup here
            base.OnExit(e);
        }
    }
}