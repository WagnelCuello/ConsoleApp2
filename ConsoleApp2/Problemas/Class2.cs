using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Problemas
{
    public class Class2
    {
        /// <summary>
        /// este metodo se encarga de calcular la masa del aire
        /// </summary>
        public static void GetProblema2()
        {
            Console.Clear();
            Console.WriteLine("===> CALCULO DE MASA DEL AIRE <===");
            Console.Write("Ingrese la presion: ");
            double presion = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la temperatura: ");
            double temperatura = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el volumen: ");
            double volumen = Convert.ToDouble(Console.ReadLine());

            double masa = (presion * volumen) / (0.37 * (temperatura + 460));

            Console.WriteLine("La masa del aire es de {0}", masa);
            Console.ReadKey();
        }
    }
}
