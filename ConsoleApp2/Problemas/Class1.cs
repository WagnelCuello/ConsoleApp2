using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Problemas
{
    public class Class1
    {
        /// <summary>
        /// este metodo se encarga de mostrar el calculo de un perimetro de un cuadrado calculando sus lados
        /// </summary>
        public static void GetProblema1()
        {
            Console.WriteLine("===> CALCULO DE LADOS DE UN CUADRADO <===");
            Console.Write("Ingrese el lado del cuadrado: ");
            double lado = Convert.ToDouble(Console.ReadLine());

            double perimetro = lado + 4;

            Console.WriteLine("El perimetro del cuadrado es de {}", perimetro);
            Console.ReadKey();
        }
    }
}
