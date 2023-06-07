using System.Linq;
using System.Net.Cache;
using System.Windows;
using System.Windows.Controls;

namespace DreamsWork
{
    /// <summary>
    /// Логика взаимодействия для ManagerPage.xaml
    /// </summary>
    public partial class ManagerPage : Page
    {
        public ManagerPage()
        {
            InitializeComponent();
            DGridHolidays.ItemsSource = DreamsWorksEntities.GetContext().Users.ToList();
            
        }

        private void BtnOtchet1_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Otchet1());
        }

        private void Request_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new RequestPage());
        }
    }
}
