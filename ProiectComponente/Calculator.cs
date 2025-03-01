using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectComponente
{
    class Calculator
    {
        string denumire;
        string producator;
        string CPU; 
        string GPU;
        int capacitateRAM;
        int capacitateStocare;
        string carcasa;
        int sursa;

        public Calculator(string _denumire="", string _producator = "", string _CPU = "", string _GPU = "", int _capacitateRAM = 0, int _capacitateStocare = 0, string _carcasa = "", int _sursa = 0)
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
    }
}
