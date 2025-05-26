using LibrarieModele;
using NivelStocareDate;
using System;
using System.Collections.Generic;

namespace ProiectComponente

{                                                   
    class Program
    {
        static void Main(string[] args)
        {
            string numeFisierUseri = "Useri.txt";
            string numeFisierCalculatoare = "Calculatoare.txt";
            User ex = new User();
            User ex2 = new User("Popescu", "Ion", 1,  "email", "adresa", "nrTel");
            Calculator ex1 = new Calculator();
            Calculator ex3 = new Calculator("Dell", "Dell", "Intel",1 ,"Nvidia", 8, 256, "ATX", "USB3, Jack2_5", 500);
            AdministrareUseri admin = new AdministrareUseri();
            AdministrareCalculatoare admin1 = new AdministrareCalculatoare();
            AdministrareUser_FIsierText adminFisierUseri = new AdministrareUser_FIsierText(numeFisierUseri);
            AdministrareCalculator_FisierText adminFisierCalculatoare = new AdministrareCalculator_FisierText(numeFisierCalculatoare);

            int nrCalculatoare;
            int nrUseri;
            adminFisierCalculatoare.GetCalculatoare(out nrCalculatoare);
            adminFisierUseri.GetUseri(out nrUseri);

            Console.WriteLine(ex2.to_str());
            Console.WriteLine(ex3.to_str());


            Console.WriteLine("\n===Administrare Useri");  //Administrare Useri

            admin.AdaugaUser(ex);
            admin.AdaugaUser(ex2);
            //admin.afisareUseri();

            Console.WriteLine("\n====Administrare Calculatoare"); //Administrare Calculatoare

            admin1.AdaugaCalculator(ex1);
            //admin1.afisareCalculatoare();
            admin1.AdaugaCalculator(ex3);

            Console.WriteLine("\n===Cautare User"); //Cautare User

            User user_cautare = admin.cautaNume("Popescu", "Ion");
            if (user_cautare != null)
                Console.WriteLine(user_cautare.to_str());
            else
                Console.WriteLine("Utilizatorul nu a fost gasit");


            Console.WriteLine("\n===Cautare Calculator"); //Cautare Calculator

            Calculator calculator_cautare = admin1.cautaDenumire("Dell");
            if (calculator_cautare != null)
                Console.WriteLine(calculator_cautare.to_str());
            else
                Console.WriteLine("Calculatorul nu a fost gasit");


            Console.WriteLine("\n===Lucru fisiere"); //Lucru fisiere


            Console.WriteLine(ex3.conversieLaSir_PentruFisier());
            Console.WriteLine(ex1.conversieLaSir_PentruFisier());
            Console.WriteLine(ex2.conversieLaSir_PentruFisier());
            adminFisierCalculatoare.AddCalculator(ex1, ref nrCalculatoare);
            adminFisierCalculatoare.AddCalculator(ex3, ref nrCalculatoare);
            List<Calculator> calculatoare = adminFisierCalculatoare.GetCalculatoare(out nrCalculatoare);

            Console.WriteLine("==== afisare lista calculatoare"); //afisare lista calculatoare

            afisareCalculatoare(calculatoare, nrCalculatoare);


            Console.WriteLine("\n===afisare lista useri"); //afisare lista useri

            adminFisierUseri.AddUser(ex, ref nrUseri);
            adminFisierUseri.AddUser(ex2, ref nrUseri);
           
            Console.WriteLine(ex.to_str());
            Console.WriteLine("TEST");
            List<User> useri = adminFisierUseri.GetUseri(out nrUseri);
            afisareUseri(useri, nrUseri);


            Console.WriteLine("\n===Cautare Calculator in fisier"); //Cautare Calculator in fisier

            Calculator calcCautat = adminFisierCalculatoare.CautaCalculatorDenumire("Dell");
            if (calcCautat != null)
                Console.WriteLine(calcCautat.to_str());
            else
                Console.WriteLine("Calculatorul nu a fost gasit");


            Console.WriteLine("\n===Cautare User in fisier"); //Cautare User in fisier

            User userCautat = adminFisierUseri.CautaUserNume("Popescu", "Ion");
            if (userCautat != null)
                Console.WriteLine(userCautat.to_str());
            else
                Console.WriteLine("Utilizatorul nu a fost gasit");
        }


        public static void afisareCalculatoare(List<Calculator> calculatoare, int nrCalculatoare)
        {
            for (int i = 0; i < nrCalculatoare; i++)
            {
                Console.WriteLine(calculatoare[i].to_str());
            }
        }

        public static void afisareUseri(List<User> useri, int nrUseri)
        {
            for (int i = 0; i < nrUseri; i++)
            {
                Console.WriteLine(useri[i].to_str());
            }
        }
    }
}