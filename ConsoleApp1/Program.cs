using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion2Parte2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*MOSTRAR VALOR DE VARIABLE POR CONSOLA*/
            string saludo = "Hola";
            char caractér = 'M';
            double i = 8.9;
            int numero1 = 1;

            //Console.WriteLine(numero1);


            /*CADENA DE FORMATO CON LISTADO DE VARIABLES. INDICAMOS INDICE EJEMPLO*/

            double precioDeLaCamisa = 399;
            string colorDeLaCamisa = "Azul";

            Console.WriteLine("El precio de la camisa sera de : {0} y su color es : {1} " , precioDeLaCamisa , colorDeLaCamisa);
        }
    }
}
