using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaES2
{
    public class Utilità
    {
        public static bool VerificaInteri(double n)
        {
            int n1 = (int)n;
            if (n1 == n)
                return true;
            else
                return false;
        }
        public static int Arrotonda(double n)
        {
           int n1 = (int)(n + 0.5);
            return n1;
        }
        public static bool Pari_Dispari(int n)
        {
            if (n % 2 == 0)
                return true;
            else
                return false;
        }
    }
}
