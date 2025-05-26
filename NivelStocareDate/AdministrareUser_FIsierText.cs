using LibrarieModele;
using System.Collections.Generic;
using System.IO;
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

        public void EditUser(User userNou, int idUser)
        {
            List<User> useri = this.GetUseri(out int nrUseri);
            //rescrie tot fisierul
            using (StreamWriter sw = new StreamWriter(numeFisier))
            {
                foreach (User user in useri)
                {
                    if (user.IdUser == idUser)
                    {
                        sw.WriteLine(userNou.conversieLaSir_PentruFisier());
                    }
                    else
                    {
                        sw.WriteLine(user.conversieLaSir_PentruFisier());
                    }
                }
            }
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
