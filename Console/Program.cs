using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite um número: ");
            int numero = Convert.ToInt32(System.Console.ReadLine());
            List<int> numerosPrimos2 = new List<int>();
            string numerosDivisores = string.Empty;
            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    numerosDivisores += i.ToString() + ", ";
                    numerosPrimos2.Add(i);
                }
            }
            numerosDivisores = numerosDivisores.Remove(numerosDivisores.Length - 2, 2);

            string numerosPrimos = string.Empty;
            foreach (int i in numerosPrimos2)
            {
                if (ePrimo(i))
                    numerosPrimos += i.ToString() + ", ";
            }
            numerosPrimos = numerosPrimos.Remove(numerosPrimos.Length - 2, 2);

            System.Console.WriteLine("Número de Entrada: " + numero.ToString());
            System.Console.WriteLine("Números Divisores: " + numerosDivisores.Replace(',', ' '));
            System.Console.WriteLine("Números Divisores: " + numerosPrimos.Replace(',', ' '));

            System.Console.Write("Pressione 'Enter' tecla para fechar.");
            if (System.Console.ReadLine() == "n") Environment.Exit(0);
        }

        public static bool ePrimo(int num)
        {
            bool isPrimo = true;
            for (int j = 2; j < num; j++)
            {
                if (num % j == 0)
                {
                    isPrimo = false;
                    break;
                }
            }
            return isPrimo;
        }
    }
}
