using System;
using System.Windows;

namespace DreamsWork
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        User _currentUser = new User();
        public MainWindow(User user)
        {
            InitializeComponent();
            _currentUser = user;
            Manager.MainFrame = MainFrame;
            AssessRole();



        }

        private void AssessRole()
        {
            if (_currentUser.Role == "Administrator")
            {

                MainFrame.Navigate(new AdminPage());
            }
            if (_currentUser.Role == "Manager")
            {
                MainFrame.Navigate(new ManagerPage());

            }

            if (_currentUser.Role == "User")
            {
                MainFrame.Navigate(new UserPage());
            }
        }

        private void MenuFrame_ContentRendered(object sender, EventArgs e)
        {
            if (MainFrame.CanGoBack)
            {
                BtnBack.Visibility = Visibility.Visible;
            }
            else
            {
                BtnBack.Visibility = Visibility.Hidden;
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }

    }
}