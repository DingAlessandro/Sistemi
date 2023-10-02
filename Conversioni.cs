using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sis_Conv
{
    internal class Program
    {
        static int Convert_Binario_To_Intero(Boolean[] b) //la conversione avviene dalla fine del vettore fino all'inizio
        {
            int decimale = 0;
            int t = b.Length - 1;
            for (int i = 0; i < b.Length; i++)
            {
                decimale = decimale + Convert.ToInt32(Convert.ToInt32(b[t]) * Math.Pow(2, i));
                t--;
            }
            return decimale;
        }
        static int Convert_Decimale_Puntato_To_Decimale(int[] dp)
        {
            int decimale = 0;
            int t = dp.Length - 1;
            for (int i = 0; i < dp.Length; i++)
            {
                decimale = decimale + Convert.ToInt32((dp[t] * Math.Pow(256, i)));
                t--;
            }
            return decimale;
        }
        static void Main(string[] args)
        {
            int[] numero = new int[] { 10, 10, 10, 10 };
            Console.WriteLine(Convert_Decimale_Puntato_To_Decimale(numero));
            bool[] d = new bool[] { true, true, true, true };
            Console.WriteLine(Convert_Binario_To_Intero(d));

            Console.ReadLine();
        }
    }
}
