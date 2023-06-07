using System.Linq;
using System.Windows.Controls;

namespace DreamsWork
{
    /// <summary>
    /// Логика взаимодействия для UserPage.xaml
    /// </summary>
    public partial class UserPage : Page
    {
        public UserPage()
        {
            InitializeComponent();
            DGridHolidays.ItemsSource = DreamsWorksEntities.GetContext().Types_Events.ToList();

        }

        
    }
}
