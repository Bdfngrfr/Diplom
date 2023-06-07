using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace DreamsWork
{
    /// <summary>
    /// Логика взаимодействия для Otchet1.xaml
    /// </summary>
    public partial class Otchet1 : Page
    {
        public Otchet1()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(Otchet1_Loaded);
        }

        private void Otchet1_Loaded(object sender, RoutedEventArgs e)
        {
            DGridAgencies.ItemsSource = DreamsWorksEntities.GetContext().Agencies.ToList();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage2((sender as Button).DataContext as Agency));
        }
    }
}

