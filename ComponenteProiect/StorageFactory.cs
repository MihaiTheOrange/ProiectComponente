using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponenteProiect
{
    
    public class StorageFactory
    {
        const string numeFisierCalc = "C:\\Users\\Mihai\\source\\repos\\ProiectComponente\\ProiectComponente\\bin\\Debug\\Calculatoare.txt";
        const string numeFisierUser = "C:\\Users\\Mihai\\source\\repos\\ProiectComponente\\ProiectComponente\\bin\\Debug\\Useri.txt";
        
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
