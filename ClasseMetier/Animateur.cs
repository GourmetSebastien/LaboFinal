using System.Globalization;

namespace ClasseMetier
{
    public class Animateur:Personne
    {
        private string gsm;
        private bool ars;

        public string Gsm
        {
            get => gsm;
            set => gsm = value;
        }

        public bool Ars
        {
            get => ars;
            set => ars = value;
        }

        public Animateur()
        {
            
        }

        public Animateur(string no, string pre, DateTime date, string address, string gsm) : base(
             no, pre, date, address)
        {
            Gsm = gsm;
            Ars = false;
        }
        public override string ToString()
        {
            string formatDate = Datenaissance.ToString("dd MMMM yyyy",CultureInfo.CreateSpecificCulture("fr-FR"));

            return "Animateur :\n" + "\nNom :" + Nom + "\nPrenom :" + Prenom +
                   "\nDate de naissance :" +
                   formatDate + "\nAdresse :" + Adresse + "\nGsm :" + Gsm + "\n";
        }

        public override void Affiche()
        {
            Console.WriteLine(ToString());
        }
    }
}