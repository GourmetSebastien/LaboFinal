// See https://aka.ms/new-console-template for more information

using System.Collections.ObjectModel;
using ClasseMetier;

SectionLoup sectionLoup=SectionLoup.Instance;

ObservableCollection<Anime> trie;

sectionLoup.LoadAnimateur();
sectionLoup.LoadAnime();

//sectionLoup.SupprimerAnime("Nahum", "Manu");
//sectionLoup.SupprimerAnimateur("Gourmet", "Sebastien");

/*
Animateur animateur = new Animateur("Gourmet", "Sebastien", new DateTime(2002, 01, 03), "Rue des grands champs 85/23 4000 Liège", "0470866366",
    "Comptable");

Animateur animateur2 =
    new Animateur("Reuter", "Ylenia", new DateTime(2000, 09, 05), "Verviers", "04859652", "Sista Besta");

Anime anime = new Anime("Nahum", "Manu", new DateTime(2013, 04, 01), "Bang cock", "Mr Nahum", "04526541",
    "Ms Nahum", "068541441", "Japan");

Anime anime2 = new Anime("Geuzaine", "Niels", new DateTime(2011, 07, 21), "Hollywood", "Mr Geuzaine", "05745563",
    "Ms Geuzaine", "015241852", "Quoicoubait");

sectionLoup.AjouterAnimateur(animateur);
sectionLoup.AjouterAnime(anime);
sectionLoup.AjouterAnimateur(animateur2);
sectionLoup.AjouterAnime(anime2);

sectionLoup.SaveAnimateur();
sectionLoup.SaveAnime();
*/

trie=new ObservableCollection<Anime>(sectionLoup.ListeAnimes.OrderBy(p=>p.Nom));

foreach (var anime in trie)
{
    anime.Affiche();
}
trie = new ObservableCollection<Anime>(sectionLoup.ListeAnimes.OrderBy(p => p.Annee));

foreach (var anime in trie)
{
    anime.Affiche();
}
//sectionLoup.AfficherAllAnimateur();
//sectionLoup.AfficherAllAnime();

