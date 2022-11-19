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
using ArkadevaSrez3.Pagess;

namespace ArkadevaSrez3.Pagess
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void BTNAdmin_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate( new AuthAdminPage());
        }

        private void BTNClient_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Service());
        }
    }
}
