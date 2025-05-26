using System.IO;

namespace ComponenteProiect
{
    
    public class StorageFactory
    {
        static string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
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
