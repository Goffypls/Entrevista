using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresAritmeticos
{
    internal class OperadoresBinarios
    {
        static void Main(string[] args)
        {
            /*SUMA*/
            int numSum1 = 5;
            int numSum2 = 7;
            float resultadoSum;
            resultadoSum = numSum1 + numSum2;
            Console.WriteLine("El resultado de la suma es: {0}" , resultadoSum);

            /*CONCATENAR*/
            var msgUsername = "Ingrese su nombre...";
            Console.Write(msgUsername);
            string nombre;
            nombre = Console.ReadLine();
            var msgApellido = "Ingrese su apellido...";
            Console.Write(msgApellido);
            string apellido;
            apellido = Console.ReadLine();
            Console.WriteLine(nombre + " " + apellido);

            /*RESTA*/
            int numRes1 = 10;
            int numRes2 = 4;
            float resultadoRes;
            resultadoRes = numRes1 - numRes2;
            Console.WriteLine("El resultado de la resta es: {0}" , resultadoRes);

            /*MULTIPLICACION*/
            int numMult1 = 5;
            int numMult2 = 2;
            float resultadoMult;
            resultadoMult = numMult1 * numMult2;
            Console.WriteLine("El resultado de la multiplicacion es: {0}" , resultadoMult);

            /*DIVISION*/
            /*AGREGAR .0 ASI EL COMPILADOR LO TOMA COMO DECIMAL*/
            /*AL FINAL DEL NUMERO AGREGAR DE SER NECESARIO F/D/M (FLOAT/DECIMAL/DOUBLE)*/
            Console.WriteLine(16.8d / 4.1d);

            /*RESTO*/
            var resultadoResto = 5 % 2;
            Console.WriteLine("El resto es : " + resultadoResto);
            
        }
    }
}
