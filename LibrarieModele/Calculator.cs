using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Calculator
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';

        private const int ID = 0;
        private const int DENUMIRE = 1;
        private const int PRODUCATOR = 2;
        private const int PROCESOR = 3;
        private const int PLACA_VIDEO = 4;
        private const int CAPACITATERAM = 5;
        private const int CAPACITATESTOCARE = 6;
        private const int CARCASA = 7;
        private const int SURSA = 8;

        public static int IdStatic { get; set; } = 0;

        public int IdCalculator { get; set; }
        public string denumire { get; set; }
        public string producator { get; set; }
        public string CPU { get; set; }
        public string GPU { get; set; }
        public int capacitateRAM { get; set; }
        public int capacitateStocare { get; set; }
        public string carcasa { get; set; }
        public int sursa { get; set; }

        public Calculator()
        {
            IdCalculator = IdStatic++;
            capacitateRAM = capacitateStocare = sursa = 0;  
            denumire = producator = CPU = GPU = carcasa = string.Empty;
        }

        public Calculator(string _denumire, string _producator, string _CPU, string _GPU, int _capacitateRAM, int _capacitateStocare, string _carcasa, int _sursa)
        {
            IdCalculator = IdStatic++;
            denumire = _denumire;
            producator = _producator;
            CPU = _CPU;
            GPU = _GPU;
            capacitateRAM = _capacitateRAM;
            capacitateStocare = _capacitateStocare;
            carcasa = _carcasa;
            sursa = _sursa;
        }
        public Calculator(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);
            IdCalculator = Convert.ToInt32(dateFisier[ID]);
            denumire = dateFisier[DENUMIRE];
            producator = dateFisier[PRODUCATOR];
            CPU = dateFisier[PROCESOR];
            GPU = dateFisier[PLACA_VIDEO];
            capacitateRAM = Convert.ToInt32(dateFisier[CAPACITATERAM]);
            capacitateStocare = Convert.ToInt32(dateFisier[CAPACITATESTOCARE]);
            carcasa = dateFisier[CARCASA];
            sursa = Convert.ToInt32(dateFisier[SURSA]);
        }   

        public string to_str()
        {
            return IdCalculator + " " + denumire + " " + producator + " " + CPU + " " + GPU + " " + capacitateRAM + " " + capacitateStocare + " " + carcasa + " " + sursa;
        }

        public string conversieLaSir_PentruFisier()
        {
            string obictCalculatorPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}{8}{0}{9}{0}",
                SEPARATOR_PRINCIPAL_FISIER, //0
                IdCalculator, //1
                (denumire ?? "NECUNOSCUT"), //2
                (producator ?? "NECUNOSCUT"), //3
                (CPU ?? "NECUNOSCUT"), //4
                (GPU ?? "NECUNOSCUT"), //5
                capacitateRAM, //6
                capacitateStocare, //7
                (carcasa ?? "NECUNOSCUT"), //8
                sursa //9
                );
            return obictCalculatorPentruFisier;
        }

       
}
}
