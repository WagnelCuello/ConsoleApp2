using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Problemas
{
    class Class3
    {
        /// <summary>
        /// este metodo se encarga de calcular el nuevo salario de un empleado
        /// </summary>
        public static void GetProblema3()
        {
            int salario = 0, opcion = 0;
            string nombre = string.Empty, titulo = "===> NOMINA DE EMPLEADOS <===";
            
            do
            {
                Console.Clear();
                Console.WriteLine(titulo);
                Console.WriteLine("[1] Nuevo Empleado");
                Console.WriteLine("[2] Listar Empleados");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("--------------------");
                Console.Write("Ingrese una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine(titulo);
                        Console.Write("Ingrese el nombre del empleado: ");
                        nombre = Console.ReadLine();
                        Console.Write("Ingrese el nuevo salario del empleado: ");
                        salario = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("----------------------------");
                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine(titulo);
                        Console.WriteLine("Nombre del Empleado: {0}", nombre);
                        Console.WriteLine("Salario: {0}", salario);

                        if (nombre != string.Empty && salario > 0)
                        {
                            Console.WriteLine("\n[1] Modificar salario");
                            Console.WriteLine("[0] Atras");

                            int opcion2 = Convert.ToInt32(Console.ReadLine());
                            if (opcion2 == 1)
                            {
                                Console.WriteLine("Ingrese el nuevo salario de {0}: ", nombre);
                                int salario2 = Convert.ToInt32(Console.ReadLine());
                                if ((salario * 1.4) == salario2)
                                {
                                    Console.WriteLine("*****************************************************");
                                    Console.WriteLine("Felicidades, usted obtuvo un aumento de un 40%");
                                    Console.WriteLine("*****************************************************");
                                }
                                salario = salario2;
                            }
                            else
                            {
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("----------------------------");
                            Console.WriteLine("Presione una tecla para continuar...");
                        }
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            } while (opcion != 0);
        }
    }
}
