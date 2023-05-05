using System.Globalization;

namespace ClasseMetier
{
    public class Animateur:Personne
    {
        private string gsm;
        private string fonction;

        public string Gsm
        {
            get => gsm;
            set => gsm = value;
        }

        public string Fonction
        {
            get => fonction;
            set => fonction = value;
        }

        public Animateur()
        {
            
        }

        public Animateur(string no, string pre, DateTime date, string address, string gsm,string fonction) : base(
             no, pre, date, address)
        {
            Gsm = gsm;
            Fonction= fonction;
        }
        public override string ToString()
        {
            string formatDate = Datenaissance.ToString("dd MMMM yyyy",CultureInfo.CreateSpecificCulture("fr-FR"));

            return "Animateur :\n" + "\nNom :" + Nom + "\nPrenom :" + Prenom + "\nFonction :"+Fonction+
                   "\nDate de naissance :" +
                   formatDate + "\nAdresse :" + Adresse + "\nGsm :" + Gsm + "\n";
        }

        public override void Affiche()
        {
            Console.WriteLine(ToString());
        }
    }
}