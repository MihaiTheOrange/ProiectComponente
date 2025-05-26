using System;

namespace LibrarieModele
{
    public class Calculator
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';

        private const int ID = 0;
        private const int DENUMIRE = 1;
        private const int PRODUCATOR = 2;
        private const int PROCESOR = 3;
        private const int PRODUCATORGPU = 4;
        private const int PLACA_VIDEO = 5;
        private const int CAPACITATERAM = 6;
        private const int CAPACITATESTOCARE = 7;
        private const int CARCASA = 8;
        private const int FRONT_PANEL = 9;
        private const int SURSA = 10;
        private const int ID_USER = 11;




        public int IdCalculator { get; set; }
        public string denumire { get; set; }
        public string producator { get; set; }
        public string CPU { get; set; }
        public ProducatorGPU producatorGPU { get; set; }
        public string GPU { get; set; }
        public int capacitateRAM { get; set; }
        public int capacitateStocare { get; set; }
        public string carcasa { get; set; }
        public FrontPanel frontPanel { get; set; }
        public int sursa { get; set; }
        public int IdUser { get; set; }

        public Calculator()
        {
            IdCalculator = 0;
            capacitateRAM = capacitateStocare = sursa = 0;
            producatorGPU = ProducatorGPU.Other;
            frontPanel = FrontPanel.None;
            denumire = producator = CPU = GPU = carcasa = string.Empty;
            IdUser = -1;
        }

        public Calculator(string _denumire, string _producator, string _CPU, int _producatorGPU, 
            string _GPU, int _capacitateRAM, int _capacitateStocare, string _carcasa, 
            string _frontPanel, int _sursa)
        {
            IdCalculator = 0;
            denumire = _denumire;
            producator = _producator;
            CPU = _CPU;
            producatorGPU = (ProducatorGPU)_producatorGPU;
            GPU = _GPU;
            capacitateRAM = _capacitateRAM;
            capacitateStocare = _capacitateStocare;
            carcasa = _carcasa;
            frontPanel = (FrontPanel)Enum.Parse(typeof(FrontPanel), _frontPanel);
            sursa = _sursa;
            IdUser = -1; 
        }
        public Calculator(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);
            IdCalculator = Convert.ToInt32(dateFisier[ID]);
            denumire = dateFisier[DENUMIRE];
            producator = dateFisier[PRODUCATOR];
            CPU = dateFisier[PROCESOR];
            producatorGPU = (ProducatorGPU)Enum.Parse(typeof(ProducatorGPU), dateFisier[PRODUCATORGPU]);
            GPU = dateFisier[PLACA_VIDEO];
            capacitateRAM = Convert.ToInt32(dateFisier[CAPACITATERAM]);
            capacitateStocare = Convert.ToInt32(dateFisier[CAPACITATESTOCARE]);
            carcasa = dateFisier[CARCASA];
            frontPanel = (FrontPanel)Enum.Parse(typeof(FrontPanel), dateFisier[FRONT_PANEL]);
            sursa = Convert.ToInt32(dateFisier[SURSA]);
            IdUser = Convert.ToInt32(dateFisier[ID_USER]);
        }   

        public string to_str()
        {
            return IdCalculator + " " + denumire + " " + producator + " " + CPU + " " +
                producatorGPU + " " + GPU + " " + capacitateRAM + " " + capacitateStocare + " " +
                carcasa + " " + frontPanel + " " + sursa + " " + IdUser;
        }

        public string conversieLaSir_PentruFisier()
        {
            string obictCalculatorPentruFisier = 
                string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}{8}{0}{9}{0}{10}{0}{11}{0}{12}{0}",
                SEPARATOR_PRINCIPAL_FISIER, //0
                IdCalculator, //1
                (denumire ?? "NECUNOSCUT"), //2
                (producator ?? "NECUNOSCUT"), //3
                (CPU ?? "NECUNOSCUT"), //4
                producatorGPU, //5
                (GPU ?? "NECUNOSCUT"), //6
                capacitateRAM, //7
                capacitateStocare, //8
                (carcasa ?? "NECUNOSCUT"), //9
                frontPanel, //10
                sursa, //11
                IdUser //12
                );
            return obictCalculatorPentruFisier;
        }

       
}
}
