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

namespace InterfaceMenu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ListViewAnimateur.Visibility=Visibility.Hidden;
        }

        private void ButtonBase_OnClickListeAnime(object sender, RoutedEventArgs e)
        {
            ListViewAnimateur.Visibility = Visibility.Hidden;
            ListViewAnime.Visibility=Visibility.Visible;
            ButtonAjout.Content = "Ajouter un animé";
        }

        private void ButtonBase_OnClickListeAnimateur(object sender, RoutedEventArgs e)
        {
            ListViewAnimateur.Visibility = Visibility.Visible;
            ListViewAnime.Visibility = Visibility.Hidden;
            ButtonAjout.Content = "Ajouter un animateur";
        }
    }
}
