using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2_Semana_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingresa el coeficiente: ");
            int coef = int.Parse(Console.ReadLine());
            Console.WriteLine("ingresa el exponente: ");
            int expo = int.Parse(Console.ReadLine());
            int result = 1;
            for (int i = 0; i < expo; i++)
            {
                result *= coef;
            }

            Console.WriteLine("la potencia es " + result);
            Console.ReadLine();
        }
    }
}
