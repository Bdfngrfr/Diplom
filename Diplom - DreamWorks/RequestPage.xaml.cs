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

namespace DreamsWork
{
    /// <summary>
    /// Логика взаимодействия для RequestPage.xaml
    /// </summary>
    public partial class RequestPage : Page
    {
        public RequestPage()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(AdminPage_Loaded);
            DGridAgencies.ItemsSource = DreamsWorksEntities.GetContext().Holidays.ToList();
        }

        private void AdminPage_Loaded(object sender, RoutedEventArgs e)
        {
            DGridAgencies.ItemsSource = DreamsWorksEntities.GetContext().Holidays.ToList();
        }
    }
}
