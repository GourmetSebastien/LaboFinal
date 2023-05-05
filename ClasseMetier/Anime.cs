using System.Globalization;
using System.Xml.Serialization;

namespace ClasseMetier
{
    public class Anime:Personne
    {
        private string pere;
        private string gsmpere;
        private string mere;
        private string gsmmere;
        private string sante;
        private bool fichesante;
        private bool ficheinscription;
        private bool gouter;

        public string Pere
        {
            get => pere;
            set => pere = value;
        }

        public string Gsmpere
        {
            get => gsmpere;
            set => gsmpere = value;
        }

        public string Mere
        {
            get => mere;
            set => mere = value;
        }

        public string Gsmmere
        {
            get => gsmmere;
            set => gsmmere = value;
        }

        public string Sante
        {
            get => sante;
            set => sante = value;
        }

        public bool Fichesante
        {
            get => fichesante;
            set => fichesante = value;
        }

        public bool Ficheinscription
        {
            get => ficheinscription;
            set=> ficheinscription = value;
        }

        public bool Gouter
        {
            get=> gouter;
            set => gouter = value;
        }

        public Anime()
        {

        }
        public Anime(string no,string pre,DateTime date,string adress,string pere, string gsmpere, string mere, string gsmmere, string sante):base(no,pre,date,adress)
        {
            Pere = pere;
            Gsmpere = gsmpere;
            Mere = mere;
            Gsmmere = gsmmere;
            Sante = sante;
            Ficheinscription = false;
            Fichesante=false;
            Gouter=false;
        }

        public override string ToString()
        {
            string formatDate = Datenaissance.ToString("dd MMMM yyyy", CultureInfo.CreateSpecificCulture("fr-FR"));

            return  "Nom :" + Nom + "Prenom :" + Prenom + "Date de naissance :" +
                   formatDate + "\nAdresse :" + Adresse + "\nPere :" + Pere +
                   "\nGsm du père:" + Gsmpere + "\nMere :" + Mere + "\nGsm de la mère :" + Gsmmere +
                   "\nParticularité de santé :" + Sante + "\n";
        }

        public override void Affiche()
        {
            Console.WriteLine(ToString());
        }
    }
}