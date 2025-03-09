using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;

namespace NivelStocareDate
{
    public class AdministrareUseri
    {
        private const int NR_MAXIM_USERI = 100;
        private int numarUseri;
        private User[] useri;

        public AdministrareUseri()
        {
            useri = new User[NR_MAXIM_USERI];
            numarUseri = 0;
        }

        public void AdaugaUser(User u)
        {
            useri[numarUseri++] = u;
        }

        public void afisareUseri()
        {
            for (int i = 0; i < numarUseri; i++)
            {
                Console.WriteLine(useri[i].to_str());
            }
        }

        public User cautaNume(string nume, string prenume)
        {
            for (int i = 0; i < numarUseri; i++)
            {
                if (useri[i].nume == nume && useri[i].prenume == prenume)
                {
                    return useri[i];
                }
            }
            return null;
        }
    }
}
