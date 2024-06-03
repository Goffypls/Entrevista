using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoReadLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            Console.Write("Ingrese su nombre : ");
            nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre + " bienvenido a Antonsich S.A");
        }
    }
}
