using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diccionarioss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inicializa el objeto Acciones con nombre y matrícula específicos
            Acciones acciones = new Acciones
            {
                Nombre = "Aldo",
                Matricula = 113512
            };
            // Agrega el estudiante inicial al diccionario
            acciones.Addstudents();

            int opcion;
            do
            {
                opcion = MostrarMenu();
                EjecutarOpcion(opcion, acciones);
            } while (opcion != 0);
        }

        static int MostrarMenu()
        {
            Console.WriteLine("\n--- MENÚ DE OPCIONES ---");
            Console.WriteLine("1. Agregar estudiante");
            Console.WriteLine("2. Eliminar estudiante por matrícula");
            Console.WriteLine("3. Actualizar nombre por matrícula");
            Console.WriteLine("4. Mostrar todos los estudiantes");
            Console.WriteLine("5. Buscar estudiante por matrícula");
            Console.WriteLine("6. Contar estudiantes");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            int opcion;
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Opción inválida. Intente de nuevo.");
                return -1;
            }
            return opcion;
        }
        
        static void EjecutarOpcion(int opcion, Acciones acciones)
        {
            switch (opcion)
            {
                case 1:
                    acciones.Addstudents();
                    break;
                case 2:
                    acciones.Removematricula();
                    break;
                case 3:
                    acciones.ActualizarPorMatricula();
                    break;
                case 4:
                    acciones.MostrarDiccionario();
                    break;
                case 5:
                    acciones.BuscarPorMatricula();
                    break;
                case 6:
                    acciones.ContarEstudiantes();
                    break;
                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        }
    }
}
