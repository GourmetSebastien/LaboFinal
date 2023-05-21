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
        private int annee;

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

        public int Annee
        {
            get => annee;
            set => annee = value;
        }
        public Anime(){}

        public Anime(string no,string pre,DateTime date,string adress,string pere, string gsmpere, string mere, string gsmmere, string sante):base(no,pre,date,adress)
        {
            Pere = pere;
            Gsmpere = gsmpere;
            Mere = mere;
            Gsmmere = gsmmere;
            Sante = sante;
            this.annee = annee;
            Ficheinscription = false;
            Fichesante=false;
            Gouter=false;
            Annee = CalculerDifferenceAnnees(date);
        }

        public override string ToString()
        {
            string formatDate = Datenaissance.ToString("dd MMMM yyyy", CultureInfo.CreateSpecificCulture("fr-FR"));

            return  "Nom :" + Nom + "\nPrenom :" + Prenom + "\nAnnée :"+Annee+ "\nDate de naissance :" +
                   formatDate + "\nAdresse :" + Adresse + "\nPere :" + Pere +
                   "\nGsm du père:" + Gsmpere + "\nMere :" + Mere + "\nGsm de la mère :" + Gsmmere +
                   "\nParticularité de santé :" + Sante + "\n";
        }

        public override void Affiche()
        {
            Console.WriteLine(ToString());
        }
        private int CalculerDifferenceAnnees(DateTime dateNaissance)
        {
            switch ((DateTime.Now.Year - dateNaissance.Year) % 4)
            {
                case 0:
                    return 4;
                case 1:
                    return 1;
                case 2:
                    return 2;
                case 3:
                    return 3;
            }
            return -1;
        }
    }
}