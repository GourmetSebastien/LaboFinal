namespace ClasseMetier
{
    public abstract class Personne
    {
        
        private string nom;
        private string prenom;
        private DateTime datenaissance;
        private string adresse;
        private bool weekend1;
        private bool weekend2;
        private bool camp;
        private bool cotisation;

        public string Nom
        {
            get => nom;
            set => nom = value;
        }

        public string Prenom
        {
            get => prenom;
            set => prenom = value;
        }

        public DateTime Datenaissance
        {
            get => datenaissance;
            set => datenaissance = value;
        }

        public string Adresse
        {
            get => adresse;
            set => adresse = value;
        }

        public bool Weekend1
        {
            get => weekend1;
            set => weekend1 = value;
        }

        public bool Weekend2
        {
            get=> weekend2; 
            set => weekend2 = value;
        }

        public bool Camp
        {
            get => camp; 
            set => camp = value;
        }

        public bool Cotisation
        {
            get => cotisation;
            set => cotisation = value;
        }
        public Personne(string no, string pre, DateTime date, string address)
        {
            Nom = no;
            Prenom = pre;
            Datenaissance = date;
            Adresse = address;
            Weekend1 = false;
            Weekend2 = false;
            Camp = false;
            Cotisation=false;
        }

        public Personne()
        {
            this.Nom = "Pas de nom";
            this.Prenom = "Pas de prenom";
            this.Datenaissance = new DateTime(1600, 01, 01);
            this.Adresse = "Pas d'adresse";
            this.Weekend1 = false;
            this.Weekend2 = false;
            this.Camp = false;
            this.Cotisation = false;
        }

        public abstract void Affiche();
    }
    
    

}