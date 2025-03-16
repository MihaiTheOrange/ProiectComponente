using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class User
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';

        private const int ID = 0;
        private const int NUME = 1;
        private const int PRENUME = 2;
        private const int EMAIL = 3;
        private const int ADRESA = 4;
        private const int NRTELEFON = 5;


        public static int IdStatic { get; set; } = 0;
        public int IdUser { get; set; }
        public string nume { get; set; }
        public string prenume { get; set; }
        public string email { get; set; }
        public string adresa { get; set; }
        public string nrTelefon { get; set; }

        public User()
        {
            IdUser = IdStatic++;
            nume = prenume = email = adresa = nrTelefon = string.Empty;
        }

        public User(string _nume, string _prenume, string _email, string _adresa, string _nrTelefon)
        {
            IdUser = IdStatic++;
            nume = _nume;
            prenume = _prenume;
            email = _email;
            adresa = _adresa;
            nrTelefon = _nrTelefon;
        }

        public User(string linie)
        {
            string[] date = linie.Split(SEPARATOR_PRINCIPAL_FISIER);
            IdUser = Convert.ToInt32(date[ID]);
            nume = date[NUME];
            prenume = date[PRENUME];
            email = date[EMAIL];
            adresa = date[ADRESA];
            nrTelefon = date[NRTELEFON];
        }

        public string to_str()
        {
            return IdUser + " " + nume + " " + prenume + " " + email + " " + adresa + " " + nrTelefon;
        }


        public string conversieLaSir_PentruFisier()
        {
            string obictUserPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}",
                SEPARATOR_PRINCIPAL_FISIER, //0
                IdUser, //1
                (nume ?? "NECUNOSCUT"), //2
                (prenume ?? "NECUNOSCUT"), //3
                (email ?? "NECUNOSCUT"), //4
                (adresa ?? "NECUNOSCUT"), //5
                (nrTelefon ?? "NECUNOSCUT") //6
                );
            return obictUserPentruFisier;
        }

    }
}
