using System;
using System.Collections.Generic;

namespace PracticaClase.Ejercicios
{
    public static class Ejercicio5
    {
        public static void Ejecutar()
        {
            List<int> numeros = new List<int> { 5, 12, 7, 90, 34, 23, 1, 77, 55, 3 };
            int max = numeros[0];
            int min = numeros[0];
            int iteraciones = 0;

            foreach (var n in numeros)
            {
                iteraciones++;
                if (n > max) max = n;
                if (n < min) min = n;
            }

            Console.WriteLine($"Máximo: {max}, Mínimo: {min}, Iteraciones: {iteraciones}");
        }
    }
}
