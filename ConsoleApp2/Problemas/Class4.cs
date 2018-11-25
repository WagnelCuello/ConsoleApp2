using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Problemas
{
    class Class4
    {
        /// <summary>
        /// este metodo se encarga de convertir pesos en dolares
        /// </summary>
        public static void GetProblema4()
        {
            Console.WriteLine("===> CONVERSOR DE MONEDAS <===");
            Console.Write("¿Cuántos pesos cuesta un dolar?: ");
            double precio_del_dolar = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese cuantos cuantos pesos quiere convertir a dolar: ");
            double pesos = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("-----------------------------");
            double equivalencia = pesos / precio_del_dolar;
            Console.WriteLine("La equivalencia en dolares es de US${0}", equivalencia);
            Console.ReadKey();
        }
    }
}
