using System.Xml.Serialization;

namespace ClasseMetier
{
    public class SectionLoup
    {
        private static SectionLoup instance;
        private List<Anime> listeAnimes;
        private List<Animateur> listeAnimateurs;
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

        public List<Anime> ListeAnimes
        {
            get=> listeAnimes; 
            set => listeAnimes = value;
        }

        public List<Animateur> ListeAnimateurs
        {
            get=>listeAnimateurs; 
            set => listeAnimateurs = value;
        }
        private SectionLoup()
        {
            ListeAnimes = new List<Anime>();
            ListeAnimateurs = new List<Animateur>();
            PathAnimes = "F:\\Programme\\Data\\SectionLoup\\ListeAnime.xml";
            PathAnimateurs = "F:\\Programme\\Data\\SectionLoup\\ListeAnimateur.xml";
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
            Anime anime = listeAnimes.Find(a => a.Nom == nom && a.Prenom == prenom);
            if (anime == null)
                Console.WriteLine(nom + " " + prenom + " pas trouver");
            else
                Console.WriteLine(nom + " " + prenom + " trouver");
            return anime;
        }

        public Animateur RechercherAnimateur(string nom, string prenom)
        {
            Animateur animateur = listeAnimateurs.Find(a => a.Nom == nom && a.Prenom == prenom);
            if (animateur == null)
                Console.WriteLine(nom + " " + prenom + " pas trouver");
            else
                Console.WriteLine(nom + " " + prenom + " trouver");
            return animateur;
        }

        public void SupprimerAnime(string nom, string prenom)
        {
            listeAnimes.RemoveAll(a => a.Nom == nom && a.Prenom == prenom);
        }

        public void SupprimerAnimateur(string nom, string prenom)
        {
            listeAnimateurs.RemoveAll(a => a.Nom == nom && a.Prenom == prenom);
        }
        public void SaveAnime()
        {
            var serializer = new XmlSerializer(typeof(List<Anime>));
            using (var stream = new FileStream(pathAnimes, FileMode.Create))
            {
                serializer.Serialize(stream, listeAnimes);
            }
        }
        public void SaveAnimateur()
        {
            var serializer = new XmlSerializer(typeof(List<Animateur>));
            using (var stream = new FileStream(pathAnimateurs, FileMode.Create))
            {
                serializer.Serialize(stream, listeAnimateurs);
            }
        }

        public void LoadAnime()
        {
            var serializer = new XmlSerializer(typeof(List<Anime>));
            using (var stream = new FileStream(pathAnimes, FileMode.Open))
            {
                listeAnimes = (List<Anime>)serializer.Deserialize(stream);
            }
        }
        public void LoadAnimateur()
        {
            var serializer = new XmlSerializer(typeof(List<Animateur>));
            using (var stream = new FileStream(pathAnimateurs, FileMode.Open))
            {
                listeAnimateurs = (List<Animateur>)serializer.Deserialize(stream);
            }
        }

        public void AfficherAllAnime()
        {
            foreach (Anime anime in listeAnimes)
            {
                anime.Affiche();
            }
        }

        public void AfficherAllAnimateur()
        {
            foreach (Animateur animateur in listeAnimateurs)
            {
                animateur.Affiche();
            }
        }

        private bool AnimateurPresent(string nom, string prenom)
        {
            bool personneTrouvee = ListeAnimateurs.Any(p => p.Nom.Equals(nom) && p.Prenom.Equals(prenom));
            return personneTrouvee;
        }
        private bool AnimePresent(string nom, string prenom)
        {
            bool personneTrouvee = ListeAnimes.Any(p => p.Nom.Equals(nom) && p.Prenom.Equals(prenom));
            return personneTrouvee;
        }
    }
}