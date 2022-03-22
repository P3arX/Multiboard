using System.Windows;
using MultiboardClient.ViewModels;

namespace MultiboardClient.Windows
{


    /// <summary>
    /// Interaction logic for AuthenticationWindow.xaml
    /// </summary>
    public partial class AuthenticationWindow : Window
    {
        private AuthenticationWindowViewModel _authenticationWindowViewModel;

        private MainWindow _mainWindow;

        public AuthenticationWindow()
        {
            InitializeComponent();
            _authenticationWindowViewModel = new AuthenticationWindowViewModel();
            _mainWindow = new MainWindow();
        }

        public async void LoginButtonClick(object obj, RoutedEventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(UsernameTextBox.Text) || UsernameTextBox.Text == string.Empty ||
               string.IsNullOrWhiteSpace(PasswordTextBox.Password) || PasswordTextBox.Password == string.Empty))
            {
                bool result = await _authenticationWindowViewModel.Login(UsernameTextBox.Text, PasswordTextBox.Password);
                if (!result)
                    ErrorTextBlock.Text = "Hmmm, something is wrong... Try again (later).";

                else
                {
                    ErrorTextBlock.Text = "Loading...";
                    _mainWindow.Show();
                    this.Close();
                }
            }

            else
                ErrorTextBlock.Text = "Invalid credentials.";
        }
    }
}
