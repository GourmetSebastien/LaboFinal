using Microsoft.VisualBasic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace ClasseMetier
{
    public class SectionLoup
    {
        private static SectionLoup instance;
        private ObservableCollection<Anime> listeAnimes;
        private ObservableCollection<Animateur> listeAnimateurs;
        private string pathAnimes;
        private string pathAnimateurs;

        public static SectionLoup Instance
        {
            get
            {
                if(instance == null)
                    instance=new SectionLoup();
                return instance;
            }
        }
        public string PathAnimes
        {
            get => pathAnimes;
            set => pathAnimes = value;
        }

        public string PathAnimateurs
        {
            get=> pathAnimateurs;
            set => pathAnimateurs = value;
        }

        public ObservableCollection<Anime> ListeAnimes
        {
            get=> listeAnimes; 
            set => listeAnimes = value;
        }

        public ObservableCollection<Animateur> ListeAnimateurs
        {
            get=>listeAnimateurs; 
            set => listeAnimateurs = value;
        }
        private SectionLoup()
        {
            ListeAnimes = new ObservableCollection<Anime>();
            ListeAnimateurs = new ObservableCollection<Animateur>();
            PathAnimes = "F:\\Programme\\C#\\LaboFinal\\data\\ListeAnime.xml";
            PathAnimateurs = "F:\\Programme\\C#\\LaboFinal\\data\\ListeAnimateur.xml";
        }
        public void AjouterAnime(Anime anime)
        {
            if(AnimePresent(anime.Nom,anime.Prenom) == false)
                listeAnimes.Add(anime);
        }

        public void AjouterAnimateur(Animateur animateur)
        {
            if(AnimateurPresent(animateur.Nom,animateur.Prenom) == false)
                listeAnimateurs.Add(animateur);
        }

        public Anime RechercherAnime(string nom, string prenom)
        {
            Anime anime = listeAnimes.FirstOrDefault(personne => personne.Nom == nom && personne.Prenom == prenom);
            if (anime == null)
                Console.WriteLine(nom + " " + prenom + " pas trouver");
            else
                Console.WriteLine(nom + " " + prenom + " trouver");
            return anime;
        }

        public Animateur RechercherAnimateur(string nom, string prenom)
        {
            Animateur animateur = listeAnimateurs.FirstOrDefault(personne => personne.Nom == nom && personne.Prenom == prenom);
            if (animateur == null)
                Console.WriteLine(nom + " " + prenom + " pas trouver");
            else
                Console.WriteLine(nom + " " + prenom + " trouver");
            return animateur;
        }

        public void SupprimerAnime(string nom, string prenom)
        {
            Anime anime = listeAnimes.FirstOrDefault(personne => personne.Nom == nom && personne.Prenom == prenom);
            if(anime != null)
                ListeAnimes.Remove(anime);
        }

        public void SupprimerAnimateur(string nom, string prenom)
        {
            Animateur animateur = listeAnimateurs.FirstOrDefault(personne => personne.Nom == nom && personne.Prenom == prenom);
            if(animateur != null)
                ListeAnimateurs.Remove(animateur);
        }
        public void SaveAnime()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<Anime>));

            using (FileStream fileStream = new FileStream(pathAnimes, FileMode.Create))
            {
                serializer.Serialize(fileStream, ListeAnimes);
            }
        }
        public void SaveAnimateur()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<Animateur>));

            using (FileStream fileStream = new FileStream(pathAnimateurs, FileMode.Create))
            {
                serializer.Serialize(fileStream, ListeAnimateurs);
            }
        }

        public void LoadAnime()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<Anime>));

            using (FileStream fileStream = new FileStream(pathAnimes, FileMode.Open))
            {
                ListeAnimes= (ObservableCollection<Anime>)serializer.Deserialize(fileStream);
            }
        }
        public void LoadAnimateur()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<Animateur>));

            using (FileStream fileStream = new FileStream(pathAnimateurs, FileMode.Open))
            {
                ListeAnimateurs = (ObservableCollection<Animateur>)serializer.Deserialize(fileStream);
            }
        }

        public void AfficherAllAnime()
        {
            foreach (Anime anime in ListeAnimes)
            {
                anime.Affiche();
            }
        }

        public void AfficherAllAnimateur()
        {
            foreach (Animateur animateur in ListeAnimateurs)
            {
                animateur.Affiche();
            }
        }

        private bool AnimateurPresent(string nom, string prenom)
        {
            return  ListeAnimateurs.Any(p => p.Nom.Equals(nom) && p.Prenom.Equals(prenom));
        }
        private bool AnimePresent(string nom, string prenom)
        {
            return ListeAnimes.Any(p => p.Nom.Equals(nom) && p.Prenom.Equals(prenom));
        }
    }
}