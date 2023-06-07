using System.Linq;
using System.Text;
using System.Windows;

namespace DreamsWork
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        readonly Registration registration= new Registration();

        private void Login_Click(object sender, RoutedEventArgs e)
        {


            StringBuilder errors = new StringBuilder();


            using (var D_b = new DreamsWorksEntities())
            {
                var mail = D_b.Users.AsNoTracking().FirstOrDefault(i => i.Mail == textBoxEmail.Text);
                var pass = D_b.Users.AsNoTracking().FirstOrDefault(i => i.Mail == textBoxEmail.Text && i.Password == TxbPassword.Password);
                if (mail == null)
                {
                    errors.AppendLine("Почта не найдена!");
                }
                if (pass == null)
                {
                    errors.AppendLine("Неверный пароль");
                }
                if (errors.Length > 0)
                {
                    MessageBox.Show(errors.ToString());
                }

                if (errors.Length == 0)
                {
                    MainWindow main = new MainWindow(pass);
                    main.Show();
                    this.Close();
                }
            }

        }
        private void ButtonRegister_Click(object sender, RoutedEventArgs e)
        {
            registration.Show();
            Close();
        }
    }
}