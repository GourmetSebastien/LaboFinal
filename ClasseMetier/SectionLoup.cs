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

        private SectionLoup()
        {
            listeAnimes=new List<Anime>();
            listeAnimateurs=new List<Animateur>();
            pathAnimes = "C:\\CreationProg\\Data\\SectionLoup\\ListeAnime.xml";
            pathAnimateurs = "C:\\CreationProg\\Data\\SectionLoup\\ListeAnimateur.xml";
        }

        public static SectionLoup Instance
        {
            get
            {
                if(instance == null)
                    instance=new SectionLoup();
                return instance;
            }
        }

        public void AjouterAnime(Anime anime)
        {
            listeAnimes.Add(anime);
        }

        public void AjouterAnimateur(Animateur animateur)
        {
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
        public void Save()
        {
            var serializer = new XmlSerializer(typeof(List<Anime>));
            using (var stream = new FileStream(pathAnimes, FileMode.Create))
            {
                serializer.Serialize(stream, listeAnimes);
            }

            serializer = new XmlSerializer(typeof(List<Animateur>));
            using (var stream = new FileStream(pathAnimateurs, FileMode.Create))
            {
                serializer.Serialize(stream, listeAnimateurs);
            }
        }

        public void Load()
        {
            var serializer = new XmlSerializer(typeof(List<Anime>));
            using (var stream = new FileStream(pathAnimes, FileMode.Open))
            {
                listeAnimes = (List<Anime>)serializer.Deserialize(stream);
            }

            serializer = new XmlSerializer(typeof(List<Animateur>));
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
    }
}