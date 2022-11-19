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
using ArkadevaSrez3.DBConnect;
using ArkadevaSrez3.Classes;

namespace ArkadevaSrez3.Pagess
{
    /// <summary>
    /// Логика взаимодействия для Service.xaml
    /// </summary>
    public partial class Service : Page
    {
        IEnumerable<Toy> filter = Connect.db.Toy;
       

        public Service()
        {
            InitializeComponent();
            Services.ItemsSource = Connect.db.Toy.ToList();
            if (Users.AuthAdmin == true)
            {
                BtnAdd.Visibility = Visibility.Visible;
            }
         
        }

        private void CbSortCost_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();  
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Refresh();

        }
        public void Refresh()
        {
           
            if (CbSortCost.SelectedIndex == 2)
            {
                filter = filter.OrderByDescending(x => x.Cost);
            }
            else if (CbSortCost.SelectedIndex == 1)
            {
                filter = filter.OrderBy(x => x.Cost);

            }
            else
            {
                filter = Connect.db.Toy.ToList();
            }

            if(TbSearch.Text.Length > 0)
            {
                filter = filter.Where(x => (x.Name != null && x.Name.ToLower().StartsWith(TbSearch.Text.ToLower()) )
                || ( x.Description != null && x.Description.ToLower().StartsWith(TbSearch.Text.ToLower())));
            }


            Services.ItemsSource = filter.ToList();

        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var select = (sender as Button).DataContext as Toy;
            if (MessageBox.Show("Вы действительно хотите удалить? Восстановить эти данные невозможно","Удаление",MessageBoxButton.YesNo) == MessageBoxResult.Yes) 
            {
                Connect.db.Toy.Remove(select);
                Connect.db.SaveChanges();
                MessageBox.Show("Удалено без возможности восстановления");
                
            }
            else
            {
                MessageBox.Show("Вы отменили удаление");
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Users.Add = true;
            NavigationService.Navigate(new AddCreatePage());
        }
    }
}
