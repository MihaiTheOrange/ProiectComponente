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

        public void AddUser(User u, ref int nrUseri)
        {
            u.IdUser = ++nrUseri;
            using (StreamWriter swFisierText = new StreamWriter(numeFisier, true))
                swFisierText.WriteLine(u.conversieLaSir_PentruFisier());
        }

        public List<User> GetUseri(out int nrUseri)
        {
            List<User> useri = new List<User>();

            using (StreamReader sr = new StreamReader(numeFisier))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    useri.Add(new User(line));
                }
            }
            nrUseri = useri.Count;

            return useri;
        }

        public User CautaUserNume(string nume, string prenume)
        {
            User user;
            using (StreamReader sr = new StreamReader(numeFisier))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    user = new User(line);
                    if (user.nume == nume && user.prenume == prenume)
                    {
                        return user;
                    }
                }
            }
            return null;
        }
    }
}
