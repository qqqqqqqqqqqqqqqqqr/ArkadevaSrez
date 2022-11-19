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

namespace ArkadevaSrez3.Pagess
{
    /// <summary>
    /// Логика взаимодействия для AuthAdminPage.xaml
    /// </summary>
    public partial class AuthAdminPage : Page
    {
        public AuthAdminPage()
        {
            InitializeComponent();
        }

        private void BtmAuthAdmin_Click(object sender, RoutedEventArgs e)
        {
            if (TbAdminCode.Text == "0000")
            {
                ArkadevaSrez3.Classes.Users.AuthAdmin = true;
                MessageBox.Show("Код введен верно!");
                NavigationService.Navigate(new Service());
            }
        }
    }
}
