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
            for (int i = 0; i < b.Length; i++)
            {
                decimale = decimale + Convert.ToInt32(Convert.ToInt32(b[b.Lenght - 1 - i]) * Math.Pow(2, i));
            }
            return decimale;
        }
        static int Convert_Decimale_Puntato_To_Decimale(int[] dp)
        {
            int decimale = 0;
            int t = dp.Length - 1;
            for (int i = 0; i < dp.Length; i++)
            {
                decimale = decimale + Convert.ToInt32((dp[dp.Lenght - 1 - i] * Math.Pow(256, i)));
            }
            return decimale;
        }
        static int[] Convert_Binario_To_Decimale_Puntato(Boolean[] b)
        {
        }
        static Boolean[] Convert_Decimale_Puntato_To_Binario(int[] dp)
        {
        }
        static int[] Convert_Numero_Decimale_To_Decimale_Puntato(//tipo d)
        { 
        }
        static int[] Convert_Numero_Decimale_To_Binario(//tipo d)
        { 
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
