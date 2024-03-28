using Laba5;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Laba5
{
    public partial class AdminWindow : Window
    {
        GameStoreEntities7 context = new GameStoreEntities7();

        public AdminWindow()
        {
            InitializeComponent();
            users_datagrid.ItemsSource = context.Users.ToList();
            
            roles_combobox.ItemsSource = context.Roles.ToList();
            roles_combobox.DisplayMemberPath = "roles1";
            roles_datagrid.ItemsSource = context.Roles.ToList();
            games_datagrid.ItemsSource = context.Games.ToList();
            genre_combobox.ItemsSource = context.Genre.ToList();
            genre_combobox.DisplayMemberPath = "names";
            platform_combobox.ItemsSource = context.Platforms.ToList();
            platform_combobox.DisplayMemberPath = "names";
            developer_combobox.ItemsSource = context.Developer.ToList();
            developer_combobox.DisplayMemberPath = "names";
            publisher_combobox.ItemsSource = context.Publisher.ToList();
            publisher_combobox.DisplayMemberPath = "names";

            
        }

        private void users_createbutton_Click(object sender, RoutedEventArgs e)
        {

            Users user = new Users();
            user.firstname = firstnametextbox.Text;
            user.lastname = lastnametextbox.Text;
            user.username = logintextbox.Text;
            user.passwords = passwordtextbox.Text;
            user.shipping_address = shippingaddresstextbox.Text;
            user.users_id = ID_textbox.Text;

            Roles role = roles_combobox.SelectedItem as Roles;
                user.role_id = role.role_id;
                context.Users.Add(user);
            try
            {
                context.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                foreach (var validationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        MessageBox.Show($"Свойство: {validationError.PropertyName} Ошибка: {validationError.ErrorMessage}");
                    }
                }
            }

            users_datagrid.ItemsSource = context.Users.ToList();
        }


        private void savebutton_Click(object sender, RoutedEventArgs e)
        {
            context.SaveChanges();
        }

        private void users_deletebutton_Click(object sender, RoutedEventArgs e)
        {
            if (users_datagrid.SelectedItem != null)
            {
                context.Users.Remove(users_datagrid.SelectedItem as Users);
                context.SaveChanges();
                users_datagrid.ItemsSource = context.Users.ToList();
            }
        }

        private void roles_createbutton_Click(object sender, RoutedEventArgs e)
        {
            Roles role = new Roles();
            role.roles1 = roletextbox.Text;
                context.Roles.Add(role);
                context.SaveChanges();
            roles_datagrid.ItemsSource = context.Roles.ToList();
        }

        private void roles_deletebutton_Click(object sender, RoutedEventArgs e)
        {
            if (roles_datagrid.SelectedItem != null)
            {
                context.Roles.Remove(roles_datagrid.SelectedItem as Roles);
                context.SaveChanges();
                roles_datagrid.ItemsSource = context.Roles.ToList();
            }
        }

        private void games_createbutton_Click(object sender, RoutedEventArgs e)
        {
            Games game = new Games();
            game.game_id = ID_textbox.Text;
            game.title = title_textbox.Text;
            Genre genre = genre_combobox.SelectedItem as Genre;
            game.genre_id = genre.genre_id;
            Platforms platform = platform_combobox.SelectedItem as Platforms;
            game.platform_id = platform.platform_id;
            Developer developer = developer_combobox.SelectedItem as Developer;
            game.developer_id = developer.developer_id;
            Publisher publisher = publisher_combobox.SelectedItem as Publisher;
            game.publisher_id = publisher.publisher_id;
            game.release_year = int.Parse(releaseyeartextbox.Text);
            game.price = decimal.Parse(pricetextbox.Text);
            context.Games.Add(game);
            context.SaveChanges();
            games_datagrid.ItemsSource = context.Games.ToList();
        }

        private void games_deletebutton_Click(object sender, RoutedEventArgs e)
        {
            if (games_datagrid.SelectedItem != null)
            {
                context.Games.Remove(games_datagrid.SelectedItem as Games);
                context.SaveChanges();
                games_datagrid.ItemsSource = context.Games.ToList();
            }
        }

        private void Back_to_login(object sender, RoutedEventArgs e)
        {

            new MainWindow().Show();
            Close();
        }
    }
}
