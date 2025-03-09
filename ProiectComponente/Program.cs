using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibrarieModele;
using NivelStocareDate;

namespace ProiectComponente

{
    class Program
    {
        static void Main(string[] args)
        {
            User ex = new User();
            User ex2 = new User("Popescu", "Ion", "email", "adresa", "nrTel");
            Calculator ex1 = new Calculator();
            Calculator ex3 = new Calculator("Dell", "Dell", "Intel", "Nvidia", 8, 256, "ATX", 500);

            ex1.citireTastatura();
            ex.citireTastatura();

            Console.WriteLine(ex.to_str());
            Console.WriteLine(ex1.to_str());


            Console.WriteLine("Administrare Useri");
            AdministrareUseri admin = new AdministrareUseri();
            admin.AdaugaUser(ex);
            admin.AdaugaUser(ex2);
            admin.afisareUseri();

            Console.WriteLine("Administrare Calculatoare");
            AdministrareCalculatoare admin1 = new AdministrareCalculatoare();
            admin1.AdaugaCalculator(ex1);
            admin1.afisareCalculatoare();
            admin1.AdaugaCalculator(ex3);

            Console.WriteLine("Cautare User");
            Console.WriteLine(admin.cautaNume("Popescu", "Ion").to_str());

            Console.WriteLine("Cautare Calculator");
            Console.WriteLine(admin1.cautaDenumire("Dell").to_str());
        }

        
    }
}
