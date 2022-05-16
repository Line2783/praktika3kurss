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

namespace ses1
{
    /// <summary>
    /// Логика взаимодействия для auth1.xaml
    /// </summary>
    public partial class auth1 : Page
    {
        public auth1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(login.Text) || string.IsNullOrEmpty(password.Text))
            {
                MessageBox.Show("Введите номер и пароль!!!");
                return;
            }
        }
    }
}
