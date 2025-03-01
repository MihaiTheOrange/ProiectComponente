using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectComponente
{
    class User
    {
        string nume;
        string prenume;
        string email;
        string adresa;
        string nrTelefon;

        public User(string _nume="", string _prenume = "", string _email = "", string _adresa = "", string _nrTelefon = "")
        {
            nume = _nume;
            prenume = _prenume;
            email = _email;
            adresa = _adresa;
            nrTelefon = _nrTelefon;
        }

    }
}
