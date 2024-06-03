using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion2 /*Nombre del Espacio Seccion2*/
{
    internal class Program /*Clase Program*/
    {
        static void Main(string[] args) /*Metodo main*/
        {
            Console.WriteLine("1. Precalentar el Horno..");
            Console.WriteLine("2. Mezclar harina y mantequilla..");
            Console.WriteLine("3. Agregar azúcar y un huevo..");
            Console.WriteLine("4. Amasar la mezcla..");
            Console.WriteLine("5. Darles forma y colocar en recipiente..");
            Console.WriteLine("6. Hornear durante 10 minutos..");
            //Invoco 6 veces el metodo Writeline de la clase Console, que pertenece a la Clase Program


            //DECLARACION E INICIALIZACION DE VARIABLES
            int numeroLibros, librosNiños, librosMatematicas;

            double promedioFinal;

            numeroLibros = 100;
            librosNiños = 20;
            librosMatematicas = 80;

            char salon;
            salon = 'A';

            string saludo = "Hola";

            bool x = true;

            /*PONER M AL FINAL PARA QUE EL COMPILADOR TOME UN DECIMAL EN VEZ DE DOUBLE*/
            decimal promedioExamenes = 8.5M;

            /*PONER M AL FINAL PARA QUE EL COMPILADOR TOME UN FLOAT EN VEZ DE DOUBLE*/
            float promedioFloat = 8.5F;
        }
    }
}
