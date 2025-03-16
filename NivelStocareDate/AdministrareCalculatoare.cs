using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;

namespace NivelStocareDate
{
    public class AdministrareCalculatoare
    {
        public const int NR_MAXIM_CALCULATOARE = 100;
        private int numarCalculatoare;
        private Calculator[] calculatoare;
        public AdministrareCalculatoare()
        {
            calculatoare = new Calculator[NR_MAXIM_CALCULATOARE];
            numarCalculatoare = 0;
        }
        public void AdaugaCalculator(Calculator c)
        {
            calculatoare[numarCalculatoare++] = c;
        }
       

        public Calculator cautaDenumire(string denumire)
        {
            for (int i = 0; i < numarCalculatoare; i++)
            {
                if (calculatoare[i].denumire == denumire)
                {
                    return calculatoare[i];
                }
            }
            return null;
        }

    }
}
