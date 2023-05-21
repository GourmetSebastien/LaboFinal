// See https://aka.ms/new-console-template for more information

using ClasseMetier;

SectionLoup sectionLoup=SectionLoup.Instance;

sectionLoup.LoadAnimateur();
sectionLoup.LoadAnime();

//sectionLoup.SupprimerAnime("Nahum", "Manu");
//sectionLoup.SupprimerAnimateur("Gourmet", "Sebastien");

//Animateur animateur = new Animateur("Gourmet", "Sebastien", new DateTime(2002, 01, 03), "Rue des grands champs 85/23 4000 Liège", "0470866366",
//    "Comptable");

//Anime anime = new Anime("Nahum", "Manu", new DateTime(2013, 04, 01), "Bang cock", "Mr Nahum", "04526541",
//    "Ms Nahum", "068541441", "Japan");

//sectionLoup.AjouterAnimateur(animateur);
//sectionLoup.AjouterAnime(anime);

//sectionLoup.SaveAnimateur();
//sectionLoup.SaveAnime();

sectionLoup.AfficherAllAnimateur();
sectionLoup.AfficherAllAnime();

