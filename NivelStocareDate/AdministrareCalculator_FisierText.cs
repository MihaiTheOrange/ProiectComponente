﻿using System;
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
        public void AddCalculator(Calculator c)
        {
            using (StreamWriter swFisierText = new StreamWriter(numeFisier, true))
                swFisierText.WriteLine(c.conversieLaSir_PentruFisier()); 
        }

        public Calculator[] GetCalculatoare(out int nrCalculatoare)
        {
            Calculator[] calculatoare = new Calculator[NR_MAXIM_CALCULATOARE];
            nrCalculatoare = 0;
                using (StreamReader sr = new StreamReader(numeFisier))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        calculatoare[nrCalculatoare++] = new Calculator(line);
                    }
                }
            
            return calculatoare;
        }
    }
}
