using System.Windows;

namespace USBControlApp.Views
{
    public partial class PasswordPrompt : Window
    {
        public PasswordPrompt()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            string enteredPassword = PasswordTextBox.Password;

            // Validate the entered password
            if (ValidatePassword(enteredPassword))
            {
                // Proceed with granting access
                this.DialogResult = true;
                this.Close();
            }
            else
            {
                // Show error message
                MessageBox.Show("Invalid password. Please try again.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private bool ValidatePassword(string password)
        {
            // Implement password validation logic here
            // For example, compare with the hashed password stored in the configuration
            return true; // Placeholder for actual validation
        }
    }
}