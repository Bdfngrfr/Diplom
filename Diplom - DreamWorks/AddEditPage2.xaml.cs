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
    /// Логика взаимодействия для AddEditPage2.xaml
    /// </summary>
    public partial class AddEditPage2 : Page
    {
        private Agency _agency = new Agency();
        public AddEditPage2(Agency agency)
        {
            InitializeComponent();

            if (agency != null)
            {
                _agency = agency;
            }

            DataContext = _agency;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (_agency.Price <= 0)
                errors.AppendLine("Укажите правильно среднее значение");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            try
            {
                DreamsWorksEntities.GetContext().SaveChanges();
                MessageBox.Show("Средние расходы изменены!");
                Manager.MainFrame.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
