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
using ArkadevaSrez3.Classes;
using ArkadevaSrez3.DBConnect;

namespace ArkadevaSrez3.Pagess
{
    /// <summary>
    /// Логика взаимодействия для AddCreatePage.xaml
    /// </summary>
    public partial class AddCreatePage : Page
    {
        public AddCreatePage()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (Users.Add == true)
            {
                if (TbName.Text.Length > 0)
                {
                    

                }
            }
        }
    }
}
