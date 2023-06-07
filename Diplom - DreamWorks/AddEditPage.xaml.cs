using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace DreamsWork
{
    /// <summary>
    /// Логика взаимодействия для AddEditPage.xaml
    /// </summary>
    public partial class AddEditPage : Page
    {
        private Holiday _holidays = new Holiday();
        
        public AddEditPage(Holiday selectedHoliday)
        {
            InitializeComponent();

            if(selectedHoliday != null)
            {
                _holidays = selectedHoliday;
            }

            DataContext = _holidays;
            
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            
            StringBuilder errors = new StringBuilder();
            
            DateTime now = DateTime.Now;
            DateTime oneHourLater = now.AddHours(1);

            if (_holidays.Id_Animator <= 0 && _holidays.Id_Animator > 11)
                errors.AppendLine("Укажите правильно аниматора");
            if (_holidays.Date_Holiday <= DateTime.Today.AddDays(-1))
                errors.AppendLine("Дата не должна быть вчерашней или меньше текущей даты");
            if (_holidays.Date_Holiday < oneHourLater)
                errors.AppendLine("Укажите правильно время");
            if (_holidays.Garland < 0)
                errors.AppendLine("Укажите правильно кол-во гирлянд");
            if (_holidays.PriceGarland <= 0)
                errors.AppendLine("Укажите правильно цену гирлянд");
            if (_holidays.Firework < 0)
                errors.AppendLine("Укажите правильно кол-во фейерверка");
            if (_holidays.PriceFirework <= 0)
                errors.AppendLine("Укажите правильно цену фейерверка");
            if (_holidays.Petard < 0)
                errors.AppendLine("Укажите правильно кол-во хлопушек");
            if (_holidays.PricePetard <= 0)
                errors.AppendLine("Укажите правильно цену хлопушки");
            if (_holidays.Event == null)
                errors.AppendLine("Укажите правильно мероприятие");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_holidays.Id_Holiday == 0)
                DreamsWorksEntities.GetContext().Holidays.Add(_holidays);


            try
            {
                DreamsWorksEntities.GetContext().SaveChanges();
                MessageBox.Show("Заявка добавлена!");
                Manager.MainFrame.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
