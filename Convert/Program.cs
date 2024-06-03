using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string entrada;

            int num1 = 5, num2, resultado;

            Console.Write("Ingrese un numero:");
            
            entrada = Console.ReadLine();

            num2 = Convert.ToInt32(entrada);

            resultado = num1 + num2;

            Console.WriteLine(resultado);   



            
        }
    }
}
