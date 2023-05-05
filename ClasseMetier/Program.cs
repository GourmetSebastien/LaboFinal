// See https://aka.ms/new-console-template for more information

using ClasseMetier;

SectionLoup sectionLoup=SectionLoup.Instance;

sectionLoup.Load();

sectionLoup.AfficherAllAnimateur();
sectionLoup.AfficherAllAnime();

sectionLoup.Save();