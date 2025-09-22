using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diccionarioss
{
    internal class Acciones
    {
        public string Nombre { get; set; }
        public int Matricula { get; set; }

        private Dictionary<string, string> diccionario = new Dictionary<string, string>();  

        public void Addstudents ()
        {
            Console.WriteLine("Ingrese el nombre del estudiante:");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la matricula del estudiante:");
            Matricula = int.Parse(Console.ReadLine());
            diccionario.Add(Nombre, Matricula.ToString());
        }   

        public void Removematricula()
        {
            Console.WriteLine("Ingrese la matricula del estudiante a eliminar:");
            Matricula = int.Parse(Console.ReadLine());
            var item = diccionario.FirstOrDefault(x => x.Value == Matricula.ToString());
            if (!item.Equals(default(KeyValuePair<string, string>)))
            {
                diccionario.Remove(item.Key);
                Console.WriteLine("Estudiante eliminado.");
            }
            else
            {
                Console.WriteLine("Matricula no encontrada.");  
            }
        }   

        // Método para actualizar el nombre por matrícula
        public void ActualizarPorMatricula()
        {
            Console.WriteLine("Ingrese la matrícula del estudiante a actualizar:");
            string matriculaBuscar = Console.ReadLine();
            var item = diccionario.FirstOrDefault(x => x.Value == matriculaBuscar);
            if (!item.Equals(default(KeyValuePair<string, string>)))
            {
                Console.WriteLine("Ingrese el nuevo nombre:");
                string nuevoNombre = Console.ReadLine();
                diccionario.Remove(item.Key);
                diccionario.Add(nuevoNombre, matriculaBuscar);
                Console.WriteLine("Nombre actualizado correctamente.");
            }
            else
            {
                Console.WriteLine("Matrícula no encontrada.");
            }
        }

        // Método para mostrar el diccionario completo
        public void MostrarDiccionario()
        {
            Console.WriteLine("Listado de estudiantes:");
            foreach (var kvp in diccionario)
            {
                Console.WriteLine($"Nombre: {kvp.Key}, Matrícula: {kvp.Value}");
            }
        }

        // Método para buscar estudiante por matrícula
        public void BuscarPorMatricula()
        {
            Console.WriteLine("Ingrese la matrícula a buscar:");
            string matriculaBuscar = Console.ReadLine();
            var item = diccionario.FirstOrDefault(x => x.Value == matriculaBuscar);
            if (!item.Equals(default(KeyValuePair<string, string>)))
            {
                Console.WriteLine($"Estudiante encontrado: Nombre: {item.Key}, Matrícula: {item.Value}");
            }
            else
            {
                Console.WriteLine("Matrícula no encontrada.");
            }
        }

        // Método para contar estudiantes
        public void ContarEstudiantes()
        {
            Console.WriteLine($"Total de estudiantes: {diccionario.Count}");
        }
    }
}
