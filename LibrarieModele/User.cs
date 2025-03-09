using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class User
    {
        public string nume { get; set; }
        public string prenume { get; set; }
        public string email { get; set; }
        public string adresa { get; set; }
        public string nrTelefon { get; set; }

        public User(string _nume = "", string _prenume = "", string _email = "", string _adresa = "", string _nrTelefon = "")
        {
            nume = _nume;
            prenume = _prenume;
            email = _email;
            adresa = _adresa;
            nrTelefon = _nrTelefon;
        }

        public void citireTastatura()
        {
            Console.WriteLine("Introduceti numele: ");
            nume = Console.ReadLine();
            Console.WriteLine("Introduceti prenumele: ");
            prenume = Console.ReadLine();
            Console.WriteLine("Introduceti email-ul: ");
            email = Console.ReadLine();
            Console.WriteLine("Introduceti adresa: ");
            adresa = Console.ReadLine();
            Console.WriteLine("Introduceti numarul de telefon: ");
            nrTelefon = Console.ReadLine();
        }

        public string to_str()
        {
            return nume + " " + prenume + " " + email + " " + adresa + " " + nrTelefon;
        }
    }
}
