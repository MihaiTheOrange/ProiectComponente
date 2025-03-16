using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

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

            //ex1.citireTastatura();
            //ex.citireTastatura();

            Console.WriteLine(ex2.to_str());
            Console.WriteLine(ex3.to_str());


            Console.WriteLine("\n===Administrare Useri");
            AdministrareUseri admin = new AdministrareUseri();
            admin.AdaugaUser(ex);
            admin.AdaugaUser(ex2);
            //admin.afisareUseri();

            Console.WriteLine("\n====Administrare Calculatoare");
            AdministrareCalculatoare admin1 = new AdministrareCalculatoare();
            admin1.AdaugaCalculator(ex1);
            //admin1.afisareCalculatoare();
            admin1.AdaugaCalculator(ex3);

            Console.WriteLine("\n===Cautare User");
            User user_cautare = admin.cautaNume("Popescu", "Ion");
            if (user_cautare != null)
                Console.WriteLine(user_cautare.to_str());
            else
                Console.WriteLine("Utilizatorul nu a fost gasit");

            Console.WriteLine("\n===Cautare Calculator");
            Calculator calculator_cautare = admin1.cautaDenumire("Dell");
            if (calculator_cautare != null)
                Console.WriteLine(calculator_cautare.to_str());
            else
                Console.WriteLine("Calculatorul nu a fost gasit");


            Console.WriteLine("\n===Lucru fisiere");
            string numeFisierUseri = "Useri.txt";
            string numeFisierCalculatoare = "Calculatoare.txt";

            Console.WriteLine(ex3.conversieLaSir_PentruFisier());
            Console.WriteLine(ex1.conversieLaSir_PentruFisier());
            Console.WriteLine(ex2.conversieLaSir_PentruFisier());
            AdministrareCalculator_FisierText adminFisierCalculatoare = new AdministrareCalculator_FisierText(numeFisierCalculatoare);
            adminFisierCalculatoare.AddCalculator(ex1);
            adminFisierCalculatoare.AddCalculator(ex3);
            int nrCalculatoare;
            Calculator[] calculatoare = adminFisierCalculatoare.GetCalculatoare(out nrCalculatoare);
            Console.WriteLine("==== afisare lista calculatoare");
            afisareCalculatoare(calculatoare, nrCalculatoare);

            Console.WriteLine("\n===afisare lista useri");
            AdministrareUser_FIsierText adminFisierUseri = new AdministrareUser_FIsierText(numeFisierUseri);
            adminFisierUseri.AddUser(ex);
            adminFisierUseri.AddUser(ex2);
            int nrUseri;
            Console.WriteLine(ex.to_str());
            Console.WriteLine("TEST");
            User[] useri = adminFisierUseri.GetUser(out nrUseri);
            afisareUseri(useri, nrUseri);

        }


        public static void afisareCalculatoare(Calculator[] calculatoare, int nrCalculatoare)
        {
            for (int i = 0; i < nrCalculatoare; i++)
            {
                Console.WriteLine(calculatoare[i].to_str());
            }
        }

        public static void afisareUseri(User[] useri, int nrUseri)
        {
            for (int i = 0; i < nrUseri; i++)
            {
                Console.WriteLine(useri[i].to_str());
            }
        }
    }
}