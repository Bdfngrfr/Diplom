using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace DreamsWork
{
    /// <summary>
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        public AdminPage()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(AdminPage_Loaded);
            DGridAgencies.ItemsSource = DreamsWorksEntities.GetContext().Holidays.ToList();
        }

        private void AdminPage_Loaded(object sender, RoutedEventArgs e)
        {
            DGridAgencies.ItemsSource = DreamsWorksEntities.GetContext().Holidays.ToList();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage((sender as Button).DataContext as Holiday));
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage(null));
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var holidaysForRemoving = DGridAgencies.SelectedItems.Cast<Holiday>().ToList();

            if(MessageBox.Show($"Вы точно хотить следующие {holidaysForRemoving.Count()} заявок?", "Внимание", 
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    DreamsWorksEntities.GetContext().Holidays.RemoveRange(holidaysForRemoving);
                    DreamsWorksEntities.GetContext().SaveChanges();
                    MessageBox.Show("Заявки удалены");

                    DGridAgencies.ItemsSource = DreamsWorksEntities.GetContext().Holidays.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}
