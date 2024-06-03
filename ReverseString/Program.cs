using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa una palabra: ");
            string palabra = Console.ReadLine();

            string palabraInvertida = InvertirPalabra(palabra);
            Console.WriteLine("Palabra invertida: " + palabraInvertida);

        }
        static string InvertirPalabra(string palabra)
        {
            char[] caracteres = palabra.ToCharArray();
            Array.Reverse(caracteres);
            return new string(caracteres);
        }
    }
}
