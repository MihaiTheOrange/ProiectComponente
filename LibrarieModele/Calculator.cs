using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Calculator
    {
        public string denumire { get; set; }
        public string producator { get; set; }
        public string CPU { get; set; }
        public string GPU { get; set; }
        public int capacitateRAM { get; set; }
        public int capacitateStocare { get; set; }
        public string carcasa { get; set; }
        public int sursa { get; set; }

        public Calculator(string _denumire = "", string _producator = "", string _CPU = "", string _GPU = "", int _capacitateRAM = 0, int _capacitateStocare = 0, string _carcasa = "", int _sursa = 0)
        {
            denumire = _denumire;
            producator = _producator;
            CPU = _CPU;
            GPU = _GPU;
            capacitateRAM = _capacitateRAM;
            capacitateStocare = _capacitateStocare;
            carcasa = _carcasa;
            sursa = _sursa;
        }

        public string to_str()
        {
            return denumire + " " + producator + " " + CPU + " " + GPU + " " + capacitateRAM + " " + capacitateStocare + " " + carcasa + " " + sursa;
        }

        public void citireTastatura()
        {
            Console.WriteLine("Introduceti denumirea calculatorului: ");
            denumire = Console.ReadLine();

            Console.WriteLine("Introduceti producatorul calculatorului: ");
            producator = Console.ReadLine();

            Console.WriteLine("Introduceti CPU-ul calculatorului: ");
            CPU = Console.ReadLine();

            Console.WriteLine("Introduceti GPU-ul calculatorului: ");
            GPU = Console.ReadLine();

            Console.WriteLine("Introduceti capacitatea de RAM a calculatorului: ");
            capacitateRAM = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduceti capacitatea de stocare a calculatorului: ");
            capacitateStocare = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduceti carcasa calculatorului: ");
            carcasa = Console.ReadLine();

            Console.WriteLine("Introduceti sursa calculatorului: ");
            sursa = Convert.ToInt32(Console.ReadLine());

        }
    }
}
