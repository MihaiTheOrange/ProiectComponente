using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponenteProiect
{
    
    public class StorageFactory
    {
        static string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        //const string numeFisierCalc = "C:\\Users\\Mihai\\source\\repos\\ProiectComponente\\ProiectComponente\\bin\\Debug\\Calculatoare.txt";
        //const string numeFisierUser = "C:\\Users\\Mihai\\source\\repos\\ProiectComponente\\ProiectComponente\\bin\\Debug\\Useri.txt";
        static string numeFisierCalc = Path.Combine(locatieFisierSolutie, "Calculatoare.txt");
        static string numeFisierUser = Path.Combine(locatieFisierSolutie, "Useri.txt");
        public StorageFactory()
        { 
        
        }
        public static string getNumFisCalc() 
        {
            return numeFisierCalc;
        }

        public static string getNumFisUser()
        {
            return numeFisierUser;
        }
    }
}
