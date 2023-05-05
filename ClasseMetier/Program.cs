// See https://aka.ms/new-console-template for more information

using ClasseMetier;

SectionLoup sectionLoup=SectionLoup.Instance;

Animateur animateur = new Animateur("Petinoir", "Valentine", new DateTime(2002, 02, 25), "Las Vegas", "0452852",
    "ARS(suce des bites");

sectionLoup.Load();

sectionLoup.AfficherAllAnimateur();
sectionLoup.AfficherAllAnime();



sectionLoup.Save();