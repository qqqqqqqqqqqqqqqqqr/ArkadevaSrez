using System.Windows;

namespace ArkadevaSrez3.DBConnect
{
    public partial class Toy
    {
        public Visibility BtnVisibility
        {
            get
            {
                if (ArkadevaSrez3.Classes.Users.AuthAdmin == true)
                    return Visibility.Visible;
                else
                    return Visibility.Hidden;
            }
        }
    }
}
