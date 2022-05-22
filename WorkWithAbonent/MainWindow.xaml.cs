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

namespace WorkWithAbonent
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void UsersComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (userList[UsersComboBox.SelectedIndex].Роль)
            {
                case "Руководитель отдела по работе с клиентами":
                    SubsTextBox.Visibility = Visibility.Visible;
                    EquipTextBox.Visibility = Visibility.Collapsed;
                    AssetsTextBox.Visibility = Visibility.Collapsed;
                    BillingTextBox.Visibility = Visibility.Visible;
                    SupprtTextBox.Visibility = Visibility.Collapsed;
                    crmTextBox.Visibility = Visibility.Visible;

                    break;

                case "Менеджер по работе с клиентами\r\n":
                    SubsTextBox.Visibility = Visibility.Visible;
                    EquipTextBox.Visibility = Visibility.Collapsed;
                    AssetsTextBox.Visibility = Visibility.Collapsed;
                    BillingTextBox.Visibility = Visibility.Collapsed;
                    SupprtTextBox.Visibility = Visibility.Collapsed;
                    crmTextBox.Visibility = Visibility.Visible;

                    break;

                case "Руководитель отдела технической поддержки\r\n":
                    SubsTextBox.Visibility = Visibility.Visible;
                    EquipTextBox.Visibility = Visibility.Visible;
                    AssetsTextBox.Visibility = Visibility.Collapsed;
                    BillingTextBox.Visibility = Visibility.Collapsed;
                    SupprtTextBox.Visibility = Visibility.Visible;
                    crmTextBox.Visibility = Visibility.Visible;

                    break;

                case "Специалист ТП (выездной инженер)\r\n":
                    SubsTextBox.Visibility = Visibility.Visible;
                    EquipTextBox.Visibility = Visibility.Visible;
                    AssetsTextBox.Visibility = Visibility.Collapsed;
                    BillingTextBox.Visibility = Visibility.Collapsed;
                    SupprtTextBox.Visibility = Visibility.Visible;
                    crmTextBox.Visibility = Visibility.Visible;

                    break;

                case "Бухгалтер\r\n":
                    SubsTextBox.Visibility = Visibility.Visible;
                    EquipTextBox.Visibility = Visibility.Collapsed;
                    AssetsTextBox.Visibility = Visibility.Visible;
                    BillingTextBox.Visibility = Visibility.Visible;
                    SupprtTextBox.Visibility = Visibility.Collapsed;
                    crmTextBox.Visibility = Visibility.Collapsed;

                    break;

                case "Директор по развитию\r\n":
                    SubsTextBox.Visibility = Visibility.Visible;
                    EquipTextBox.Visibility = Visibility.Visible;
                    AssetsTextBox.Visibility = Visibility.Visible;
                    BillingTextBox.Visibility = Visibility.Visible;
                    SupprtTextBox.Visibility = Visibility.Visible;
                    crmTextBox.Visibility = Visibility.Visible;

                    break;

                case "Технический департамент\r\n":
                    SubsTextBox.Visibility = Visibility.Visible;
                    EquipTextBox.Visibility = Visibility.Visible;
                    AssetsTextBox.Visibility = Visibility.Visible;
                    BillingTextBox.Visibility = Visibility.Collapsed;
                    SupprtTextBox.Visibility = Visibility.Visible;
                    crmTextBox.Visibility = Visibility.Visible;

                    break;
            }
        }
    }
}
