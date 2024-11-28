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

namespace Nail
{
    /// <summary>
    /// Логика взаимодействия для ClientsPage.xaml
    /// </summary>
    public partial class ClientsPage : Page
    {
        public ClientsPage()
        {
            InitializeComponent();
        }
        private void StaffButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StaffPage());
        }

        private void ServiseButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ServicePage());
        }

        private void OrdersButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new OrdersPage());
        }
    }
}
