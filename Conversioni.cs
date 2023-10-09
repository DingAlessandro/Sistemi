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
                decimale = decimale + Convert.ToInt32(Convert.ToInt32(b[b.Length - 1 - i]) * Math.Pow(2, i));
            }
            return decimale;
        }
        static int Convert_Decimale_Puntato_To_Decimale(int[] dp)
        {
            int decimale = 0;
            for (int i = 0; i < dp.Length; i++)
            {
                decimale = decimale + Convert.ToInt32((dp[dp.Length - 1 - i] * Math.Pow(255, i)));
            }
            return decimale;
        }
        static int[] Convert_Binario_To_Decimale_Puntato(Boolean[] b)
        {
            int[] dp = new int[4];
            string bin = "";
            int indice = 0;
            for(int i = 0; i < b.Length; i++)
            {
                bin = bin + Convert.ToString(b[i]);
                if((i + 1) % 8 == 0)
                {
                    for(int p = 0; p < 8; p++)
                    {
                        dp[indice] = dp[indice] + Convert.ToInt32(Convert.ToInt32(bin[p]) * Math.Pow(2, p));
                    }
                    indice++;
                    bin = "";
                }
            }
            return dp;
        }
        static Boolean[] Convert_Decimale_Puntato_To_Binario(int[] dp)
        {
            bool[] b = new Boolean[32];
            int indice = b.Length;
            for(int i = 0; i < dp.Length ; i++) 
            {
                for(int p = 0; p < 8; p++) 
                {
                    b[indice - 1 - p] = Convert.ToBoolean(dp[i] % 2);
                    dp[i] = dp[i] / 2;
                }
                indice = indice - 8;
            }
            return b;
        }
        static int[] Convert_Numero_Decimale_To_Decimale_Puntato(long decimale)
        {
            int[] dp = new int[4];
            for(int i = 0; i < dp.Length; i++)
            {
                dp[dp.Length - 1 - i] = (int)(decimale % 255);
                decimale = decimale / 255;
            }
            return dp;
        }
        static bool[] Convert_Numero_Decimale_To_Binario(long decimale)
        {
            bool[] b = new bool[32];
            for(int i = 0; i < b.Length && decimale > 0; i++) 
            {
                b[b.Length - 1 - i] = Convert.ToBoolean(decimale % 2);
                decimale = decimale / 2;
            }
            return b;
        }
        static void Main(string[] args)
        {
            int[] numero = new int[] { 10, 10, 10, 10 };
            Console.WriteLine(Convert_Decimale_Puntato_To_Decimale(numero));
            bool[] d = new bool[] { true, true, true, true };
            Console.WriteLine(Convert_Binario_To_Intero(d));
            int decimale = Convert_Decimale_Puntato_To_Decimale(numero);
            numero = Convert_Numero_Decimale_To_Decimale_Puntato(decimale);
            foreach(int i in numero) 
            {
                Console.WriteLine($"{i}");
            }
            Console.ReadLine();
        }
    }
}
