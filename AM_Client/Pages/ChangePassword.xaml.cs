using System;
using System.Collections.Generic;
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
    /// Interaction logic for ChangePassword.xaml
    /// </summary>
    public partial class ChangePassword : Page
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        public ChangePassword(string username)
        {
            InitializeComponent();
            this.txtUsername.Text = username;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GetNavigationService(this).GoBack();
        }

        private void btnChangePassword_Click(object sender, RoutedEventArgs e)
        {
            //verify all fields are filled out
            string username = this.txtUsername.Text;
            string oldPassword = this.txtOldPassword.Password;
            string newPassword = this.txtNewPassword.Password;
            string confirmPassword = this.txtConfirmPassword.Password;

            if (String.IsNullOrWhiteSpace(username))
            {
                SetMessageLabel("Username cannot be blank.");
                return;
            }

            if (String.IsNullOrWhiteSpace(oldPassword))
            {
                SetMessageLabel("Current password cannot be blank");
            }



            AuthService.AuthServiceClient client = new AuthServiceClient();

            ChangePasswordResponse response = client.ChangePassword(new ChangePasswordRequest(username, oldPassword, newPassword, confirmPassword));

            //if successfully, go back
            if (response.ChangePasswordResult.success)
            {
                ClearMessageLabel();

                NavigationService.GetNavigationService(this).GoBack();
            }
            else
            {
                SetMessageLabel("Change Password failed");
            }

            //if not, display error message
        }

        private void txtUsername_TextChanged(object sender, TextChangedEventArgs e)
        {
            ClearMessageLabel();
        }

        private void txtOldPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            ClearMessageLabel();
        }

        private void txtNewPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            ClearMessageLabel();
        }

        private void txtConfirmPassword_PasswordChanged(object sender, RoutedEventArgs e)
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
