using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Laba5
{
    public partial class Cashier : Window
    { 
        GameStoreEntities7 context = new GameStoreEntities7();
        public Cashier()
        {
            InitializeComponent();
            dataGridAllCheck.ItemsSource = context.Rating.ToList();
        }
        private void File_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new CommonOpenFileDialog
            {       
                IsFolderPicker = true
            };

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                string selectedFolder = dialog.FileName;
            }

            var ord = dataGridAllCheck.SelectedItem as Games;

            string filename = dialog.FileName + $"\\{ord.game_id}.txt";
            var genre = context.Genre.FirstOrDefault(b => b.genre_id == ord.genre_id);
            var plat = context.Platforms.FirstOrDefault(b => b.platform_id == ord.platform_id);
            var develop = context.Developer.FirstOrDefault(b => b.developer_id == ord.developer_id);
            var publ = context.Publisher.FirstOrDefault(b => b.publisher_id == ord.publisher_id);
            string ch = "\t\t\t Чек \n" +
                           $"\t\t\t\tЧек №{ord.game_id}\n" +
                           $"\n" +
                           $"Игра: {ord.title}" +
                           $"Жанр: {genre.names}\n" +
                           $"Платформа: {plat.names}\n" +
                           $"Разработчик: {develop.names}" +
                           $"Издатель: {publ.names}" +
                           $"Цена: {ord.price}" +
                           $"Дата выхода: {ord.release_year}";
            if (!File.Exists(filename))
            {
                using (File.Create(filename)) { };
            }
            File.WriteAllText(filename, ch);
            System.Windows.MessageBox.Show($"Чек был сохранен в {filename}!");

        }

        private void Back_to_login(object sender, RoutedEventArgs e)
        {

            new MainWindow().Show();
            Close();
        }

    }
}
