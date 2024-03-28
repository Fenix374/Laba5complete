using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace Laba5
{
    public partial class MainWindow : Window
    {
        public static GameStoreEntities7 context = new GameStoreEntities7();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var login = usernameTextBox.Text;
            var password = passwordBox.Password;
            var user = context.Users.FirstOrDefault(u => u.username == login && u.passwords == password);
            if (user != null)
            {
                switch (user.role_id)
                {
                    case 1:
                        new AdminWindow().Show();
                        break;
                    case 2:
                        new Cashier().Show();
                        break;
                    default:
                        MessageBox.Show("Для вашей роли нету окна!");
                        break;
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!");
            }
        }
    }
}
