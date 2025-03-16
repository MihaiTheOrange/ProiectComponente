using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using LibrarieModele;
namespace NivelStocareDate
{

    public class AdministrareUser_FIsierText
    {
        public int NR_MAXIM_USERI = 100;
        public string numeFisier { get; set; }

        public AdministrareUser_FIsierText(string numeFisier)
        {
            this.numeFisier = numeFisier;
            Stream streamFisier = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisier.Close();
        }

        public void AddUser(User u)
        {
            using (StreamWriter swFisierText = new StreamWriter(numeFisier, true))
                swFisierText.WriteLine(u.conversieLaSir_PentruFisier());
        }

        public User[] GetUser(out int nrUseri)
        {
            User[] useri = new User[NR_MAXIM_USERI];
            nrUseri = 0;
            using (StreamReader sr = new StreamReader(numeFisier))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    useri[nrUseri++] = new User(line);
                }
            }
            return useri;
        }
    }
}
