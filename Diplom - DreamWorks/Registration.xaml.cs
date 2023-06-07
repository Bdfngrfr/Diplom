using System;
using System.Text.RegularExpressions;
using System.Windows;

namespace DreamsWork
{
    public partial class Registration : Window
    {
        User user;
        public Registration()
        {
            InitializeComponent();
            user = new User();
            DataContext = user;
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            Close();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Reset();
        }

        public void Reset()
        {
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxEmail.Text = "";
            passwordBox1.Password = "";
            passwordBoxConfirm.Password = "";
            textBoxRole.Text = "";
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxEmail.Text.Length == 0)
            {
                errormessage.Text = "Enter an email.";
                textBoxEmail.Focus();
            }
            else if (!Regex.IsMatch(textBoxEmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                errormessage.Text = "Enter a valid email.";
                textBoxEmail.Select(0, textBoxEmail.Text.Length);
                textBoxEmail.Focus();
            }
            else
            {
                if (passwordBox1.Password.Length == 0)
                {
                    errormessage.Text = "Enter password.";
                    passwordBox1.Focus();
                }
                else if (passwordBoxConfirm.Password.Length == 0)
                {
                    errormessage.Text = "Enter Confirm password.";
                    passwordBoxConfirm.Focus();
                }
                else if (passwordBox1.Password != passwordBoxConfirm.Password)
                {
                    errormessage.Text = "Confirm password must be same as password.";
                    passwordBoxConfirm.Focus();
                }
                else
                {
                    user.Password = passwordBox1.Password;
                    switch (textBoxRole.SelectedIndex)
                    {
                        case 0:
                            {
                                user.Role = "Administrator";
                                break;
                            }
                        case 1:
                            {
                                user.Role = "Manager";
                                break;
                            }
                        case 2:
                            {
                                user.Role = "User";
                                break;
                            }
                    }

                    DreamsWorksEntities.GetContext().Users.Add(user);
                    try
                    {
                        DreamsWorksEntities.GetContext().SaveChanges();
                        errormessage.Text = "";
                        MainWindow mainWindow = new MainWindow(user);
                        mainWindow.Show();
                        Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                    Reset();
                }
            }
        }
    }
}
