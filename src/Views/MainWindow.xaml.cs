using System.Windows;

namespace USBControlApp.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadDeviceList();
        }

        private void LoadDeviceList()
        {
            // Logic to load and display connected USB devices
        }

        private void ChangePasswordButton_Click(object sender, RoutedEventArgs e)
        {
            // Logic to open the password prompt window
            PasswordPrompt passwordPrompt = new PasswordPrompt();
            passwordPrompt.ShowDialog();
        }

        private void ManageWhitelistButton_Click(object sender, RoutedEventArgs e)
        {
            // Logic to open the settings window for managing the whitelist
            SettingsWindow settingsWindow = new SettingsWindow();
            settingsWindow.ShowDialog();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}