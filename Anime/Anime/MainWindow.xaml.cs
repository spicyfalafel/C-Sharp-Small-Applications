using AnimeClasses;
using Microsoft.Win32;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Anime
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool favmode = false;
        AnimeList anime;
        public MainWindow()
        {
            InitializeComponent();
            if (File.Exists("anime.xml"))
            {
                string text = File.ReadAllText("anime.xml");
                anime = (AnimeList)AnimeList.Deserialize(text, typeof(AnimeList));
            }
            else
            {
                anime = new AnimeList();
            }
            if(anime==null) anime = new AnimeList();
            dgAnime.ItemsSource = new ObservableCollection<AnimeToWatch>(anime.AllAnime);
        }

      

        private void show_Click(object sender, RoutedEventArgs e)
        {
            string res = "";
            anime.AllAnime.ForEach(e => res += e.ToString() + "\n\n");
            MessageBox.Show(res);
        }

        //https://stackoverflow.com/questions/21881124/how-do-you-get-navigateuri-to-work-in-a-wpf-window
        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            //googled this
            Process.Start("explorer.exe", e.Uri.AbsoluteUri);
            e.Handled = true;
        }

        private void changeToFav_Click(object sender, RoutedEventArgs e)
        {
            if (favmode)
            {
                dgAnime.ItemsSource = new ObservableCollection<AnimeToWatch>(anime.AllAnime);
                changeToFav.Content = "Show all";
            }
            else
            {
                dgAnime.ItemsSource = new ObservableCollection<AnimeToWatch>(anime.FavouriteAnime);
                changeToFav.Content = "Show favs";
            }
            favmode = !favmode;
        }

        private void makeFav_Click(object sender, RoutedEventArgs e)
        {
            anime.FavouriteAnime.Add((AnimeToWatch)dgAnime.SelectedItem);
        }

        private void saveToFile_Click(object sender, RoutedEventArgs e)
        {
            //https://stackoverflow.com/questions/20993630/saving-xml-file-using-save-file-dialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML-File | *.xml";
            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, AnimeList.Serialize(anime));
            }  
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string aniem = AnimeList.Serialize(anime);
            File.WriteAllText("anime.xml", aniem);
        }

        private void deleteFile_Click(object sender, RoutedEventArgs e)
        {
            if (favmode) return;
            //https://stackoverflow.com/questions/11089104/operation-is-not-valid-while-itemssource-is-in-use-access-and-modify-elements-w
            anime.AllAnime.Remove((AnimeToWatch)dgAnime.SelectedItem);

            dgAnime.ItemsSource = new ObservableCollection<AnimeToWatch>(anime.AllAnime); 
        }

        private void showAvailableEnums_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This app saves anime list in anime.xml on close.\n\nAvailable Age Groups: Children, Shonen, Shojo, Seinen, Josei\n\n" +
                "Available Genres: Action, Fantasy, SciFi, Mystery, Josei, Harem, Ecchi, Romance, Comedy, " +
                "School, Drama, Psychological, History, Mecha, Magic, Other, Yuri, Yaoi, Isekai");
        }
    }
}