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

            using (var db = new )
            {
                var user = db.User
                    .AsNotracking()
                    .FirstOrDefault(using -> u.Login == login.Text && u.password == password.Text)
                if (user == null)
                {
                    MessageBox.Show("Пользователь с такими данными не найден!");
                    return;
                }
                MessageBox.Show(user.Role)
                    {
                    case "Руководитель отдела по работе с клиентами":
                        NavigationService?.Navigate(new Menu());
                    break;

                    case "Менеджер по работе с клиентами":
                        NavigationService?.Navigate(new Menu());
                    break;

                    case "Руководитель отдела технической поддержки":
                        NavigationService?.Navigate(new Menu());
                    break;

                    case "Специалист технической поддержки":
                        NavigationService?.Navigate(new Menu());
                    break;

                    case "Бухгалтер":
                        NavigationService?.Navigate(new Menu());
                    break;

                    case "Директор по развитию":
                        NavigationService?.Navigate(new Menu());
                    break;

                    case "Сотрудник технического департамента":
                        NavigationService?.Navigate(new Menu());
                    break;

                }
            }
        }
    }
}
