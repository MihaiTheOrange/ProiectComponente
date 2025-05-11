using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;

namespace NivelStocareDate
{
    public class AdministrareCalculator_FisierText
    {
        public int NR_MAXIM_CALCULATOARE = 100;
        public string numeFisier { get; set; }

        public AdministrareCalculator_FisierText(string numeFisier)
        {
            this.numeFisier = numeFisier;
            Stream streamFisier = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisier.Close();
        }
        public void AddCalculator(Calculator c, ref int nrCalculatoare)
        {
            c.IdCalculator = ++nrCalculatoare;
            using (StreamWriter swFisierText = new StreamWriter(numeFisier, true))
                swFisierText.WriteLine(c.conversieLaSir_PentruFisier()); 
        }

        public void EditCalculator(Calculator calcNou)
        {
            int nrCalc = 0;
            List<Calculator> calculatoare = this.GetCalculatoare(out nrCalc);

            //rescrie tot fisierul
            using (StreamWriter sw = new StreamWriter(numeFisier))
            {
                foreach (Calculator calc in calculatoare)
                {
                    if (calc.IdCalculator == calcNou.IdCalculator)
                    {
                        sw.WriteLine(calcNou.conversieLaSir_PentruFisier());
                    }
                    else
                    {
                        sw.WriteLine(calc.conversieLaSir_PentruFisier());
                    }
                }
            }
        }

        public List<Calculator> GetCalculatoare(out int nrCalculatoare)
        {
            List<Calculator> calculatoare = new List<Calculator>();
            nrCalculatoare = 0;
                using (StreamReader sr = new StreamReader(numeFisier))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                    //Console.WriteLine(line);
                    calculatoare.Add(new Calculator(line));

                    }
                }
            nrCalculatoare = calculatoare.Count;
            return calculatoare;
        }

        public Calculator CautaCalculatorDenumire(string denumire)
        {
            Calculator calculator;
            using (StreamReader sr = new StreamReader(numeFisier))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    calculator = new Calculator(line);
                    if (calculator.denumire == denumire)
                    {
                        return calculator;
                    }
                }
            }
            return null;
        }
    }
}
