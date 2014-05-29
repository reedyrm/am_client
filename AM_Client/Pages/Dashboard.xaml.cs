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
using AM_Client.Pages;
using AM_Client.RealEstateService;

namespace AM_Client
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Page
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void miExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void miChangePassword_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GetNavigationService(this).Navigate(new ChangePassword());
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string zipCode = this.txtZipCodeSearch.Text;

            if (String.IsNullOrWhiteSpace(zipCode) && zipCode.Length != 5)
            {
                return;
            }

            RealEstateService.RealEstateServiceClient client = new RealEstateServiceClient();
            GetListingsResponse response = client.GetListings(new GetListingsRequest(zipCode));

            this.dgZipCodeSearchResults.ItemsSource = response.GetListingsResult;
        }
    }
}
