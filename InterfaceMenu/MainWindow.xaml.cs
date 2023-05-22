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
using ClasseMetier;

namespace InterfaceMenu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SectionLoup sectionLoup = SectionLoup.Instance;
        public MainWindow()
        {
            InitializeComponent();
            ListViewAnimateur.Visibility=Visibility.Hidden;

            sectionLoup.LoadAnimateur();
            sectionLoup.LoadAnime();

            ListViewAnimateur.ItemsSource = sectionLoup.ListeAnimateurs;
            ListViewAnime.ItemsSource = sectionLoup.ListeAnimes;
        }

        private void ButtonBase_OnClickListeAnime(object sender, RoutedEventArgs e)
        {
            ListViewAnimateur.Visibility = Visibility.Hidden;
            ListViewAnime.Visibility=Visibility.Visible;
            ComboBoxItemAnnee.Visibility=Visibility.Visible;
            ButtonAjout.Content = "Ajouter un animé";
            ComboBoxTrie.SelectedIndex = 0;
            ListViewAnime.ItemsSource = sectionLoup.ListeAnimes;
            ListViewAnime.Items.Refresh();
        }

        private void ButtonBase_OnClickListeAnimateur(object sender, RoutedEventArgs e)
        {
            ListViewAnimateur.Visibility = Visibility.Visible;
            ListViewAnime.Visibility = Visibility.Hidden;
            ComboBoxItemAnnee.Visibility = Visibility.Collapsed;
            ButtonAjout.Content = "Ajouter un animateur";
            ComboBoxTrie.SelectedIndex = 0;
            ListViewAnimateur.ItemsSource = sectionLoup.ListeAnimateurs;
            ListViewAnimateur.Items.Refresh();
        }

        private void ButtonAjout_OnClick(object sender, RoutedEventArgs e)
        {
            if (ButtonAjout.Content == "Ajouter un animateur")
            {
                InterfaceAjoutAnimateur.MainWindow nMainWindow = new InterfaceAjoutAnimateur.MainWindow();
                nMainWindow.ShowDialog();
            }
            else
            {
                InterfaceAjoutAnime.MainWindow neMainWindow = new InterfaceAjoutAnime.MainWindow();
                neMainWindow.ShowDialog();
            }
        }

        private void TrieChange(object sender, SelectionChangedEventArgs e)
        {
            List<Anime> animeTrie=new List<Anime>();
            List<Animateur> animateurTrie=new List<Animateur>();

            string choixTri=ComboBoxTrie.SelectedItem.ToString();

            switch (choixTri)
            {
                case "Aucun":
                    if (ButtonAjout.Content == "Ajouter un animateur")
                    {
                        ListViewAnimateur.ItemsSource = sectionLoup.ListeAnimateurs;
                        ListViewAnimateur.Items.Refresh();
                    }
                    else
                    {
                        ListViewAnime.ItemsSource=sectionLoup.ListeAnimes;
                        ListViewAnime.Items.Refresh();
                    }
                    break;
                case "Nom":
                    if (ButtonAjout.Content == "Ajouter un animateur")
                    {
                        ListViewAnimateur.ItemsSource = sectionLoup.ListeAnimateurs.OrderBy(personne => personne.Nom).ToList();
                        ListViewAnimateur.Items.Refresh();
                    }
                    else
                    {
                        ListViewAnime.ItemsSource = sectionLoup.ListeAnimes.OrderBy(personne => personne.Nom).ToList();
                        ListViewAnime.Items.Refresh();
                    }
                    break;
                case "Année":
                    ListViewAnime.ItemsSource = sectionLoup.ListeAnimes.OrderBy(personne => personne.Annee).ToList();
                    ListViewAnime.Items.Refresh();
                    break;
            }
        }
    }
}
