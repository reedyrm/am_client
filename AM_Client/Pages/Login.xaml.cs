using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AM_Client.AuthService;

namespace AM_Client.Pages
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Debug.Print("Login Click");

            string username = this.txtUsername.Text;
            string password = this.txtPassword.Password;

            //verify login
            AuthService.AuthServiceClient client = new AuthServiceClient();
            VerifyUserResponse response = client.VerifyUser(new VerifyUserRequest(username, password));

            if (response.VerifyUserResult.success)
            {
                ClearMessageLabel();

                //transition to main form
                NavigationService.GetNavigationService(this).Navigate(new Dashboard());

            }
            else
            {
                SetMessageLabel("Invalid Username/Password Combination");

            }
        }

        private void txtUsername_TextChanged(object sender, TextChangedEventArgs e)
        {
            ClearMessageLabel();
        }

        private void txtPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            ClearMessageLabel();
        }

        /// <summary>
        /// Sets Message
        /// </summary>
        /// <param name="message"></param>
        private void SetMessageLabel(string message)
        {
            this.lblMessage.Visibility = Visibility.Visible;
            this.lblMessage.Content = message;
        }

        /// <summary>
        /// Clears out lblMessage contents
        /// </summary>
        private void ClearMessageLabel()
        {
            if (this.lblMessage.Visibility != Visibility.Hidden)
            {
                this.lblMessage.Visibility = Visibility.Hidden;
                this.lblMessage.Content = String.Empty;
            }
        }
    }
}
