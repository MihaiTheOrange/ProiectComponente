using System;

namespace LibrarieModele
{
    public class User
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';

        private const int ID = 0;
        private const int NUME = 1;
        private const int PRENUME = 2;
        private const int GEN = 3;
        private const int EMAIL = 4;
        private const int ADRESA = 5;
        private const int NRTELEFON = 6;


        public int IdUser { get; set; }
        public string nume { get; set; }
        public string prenume { get; set; }
        public GenUser gen { get; set; }
        public string email { get; set; }
        public string adresa { get; set; }
        public string nrTelefon { get; set; }

        public User()
        {
            IdUser = 0;
            gen = GenUser.Altul;
            nume = prenume = email = adresa = nrTelefon = string.Empty;
        }

        public User(string _nume, string _prenume,int _gen ,string _email, string _adresa, string _nrTelefon)
        {
            IdUser = 0;
            nume = _nume;
            prenume = _prenume;
            this.gen = (GenUser)_gen;
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
            gen = (GenUser)Enum.Parse(typeof(GenUser), date[GEN]);
            email = date[EMAIL];
            adresa = date[ADRESA];
            nrTelefon = date[NRTELEFON];
        }

        public string to_str()
        {
            return IdUser + " " + nume + " " + prenume + " "+ gen + " " + email + " " + adresa + " " + nrTelefon;
        }


        public string conversieLaSir_PentruFisier()
        {
            string obictUserPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}",
                SEPARATOR_PRINCIPAL_FISIER, //0
                IdUser, //1
                (nume ?? "NECUNOSCUT"), //2
                (prenume ?? "NECUNOSCUT"), //3
                gen, //4
                (email ?? "NECUNOSCUT"), //5
                (adresa ?? "NECUNOSCUT"), //6
                (nrTelefon ?? "NECUNOSCUT") //7
                );
            return obictUserPentruFisier;
        }

    }
}
