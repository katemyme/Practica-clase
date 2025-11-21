using System;
using System.Collections.Generic;

namespace PracticaClase.Ejercicios
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }

    public static class Ejercicio4
    {
        public static void Ejecutar()
        {
            List<Estudiante> estudiantes = new List<Estudiante>
            {
                new Estudiante{Id=1, Nombre="Ana"},
                new Estudiante{Id=2, Nombre="Luis"},
                new Estudiante{Id=3, Nombre="Carlos"},
                new Estudiante{Id=4, Nombre="Marta"},
                new Estudiante{Id=5, Nombre="Sofia"},
                new Estudiante{Id=6, Nombre="Pedro"},
                new Estudiante{Id=7, Nombre="Lucia"},
                new Estudiante{Id=8, Nombre="Diego"},
                new Estudiante{Id=9, Nombre="Laura"},
                new Estudiante{Id=10, Nombre="Jorge"}
            };

            Console.WriteLine("Ingrese ID a buscar:");
            int id = int.Parse(Console.ReadLine());
            Estudiante encontrado = null;

            foreach (var e in estudiantes)
            {
                if (e.Id == id)
                {
                    encontrado = e;
                    break;
                }
            }

            if (encontrado != null)
                Console.WriteLine($"Estudiante encontrado: {encontrado.Nombre}");
            else
                Console.WriteLine("No encontrado");

            estudiantes.Sort((x, y) => x.Nombre.CompareTo(y.Nombre));
            Console.WriteLine("Ingrese nombre a buscar:");
            string nombre = Console.ReadLine();

            int izquierda = 0;
            int derecha = estudiantes.Count - 1;
            encontrado = null;

            while (izquierda <= derecha)
            {
                int medio = (izquierda + derecha) / 2;
                Console.WriteLine($"Comparando con: {estudiantes[medio].Nombre}");

                int cmp = string.Compare(nombre, estudiantes[medio].Nombre, true);
                if (cmp == 0)
                {
                    encontrado = estudiantes[medio];
                    break;
                }
                else if (cmp < 0)
                    derecha = medio - 1;
                else
                    izquierda = medio + 1;
            }

            if (encontrado != null)
                Console.WriteLine($"Estudiante encontrado: {encontrado.Nombre}");
            else
                Console.WriteLine("No encontrado");
        }
    }
}
