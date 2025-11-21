using System;
using System.Collections.Generic;

namespace PracticaClase.Ejercicios
{
    public static class Ejercicio2
    {
        public static void Ejecutar()
        {
            Random rnd = new Random();
            List<int> lista = new List<int>();

            for (int i = 0; i < 30; i++)
                lista.Add(rnd.Next(1, 101));

            lista.Sort();
            Console.WriteLine("Lista ordenada: " + string.Join(", ", lista));

            Console.WriteLine("Ingrese un número a buscar:");
            int numero = int.Parse(Console.ReadLine());

            int izquierda = 0;
            int derecha = lista.Count - 1;
            bool encontrado = false;

            while (izquierda <= derecha)
            {
                int medio = (izquierda + derecha) / 2;
                Console.WriteLine($"Mitad actual: {medio}, valor: {lista[medio]}");

                if (lista[medio] == numero)
                {
                    Console.WriteLine($"Número encontrado en la posición {medio}");
                    encontrado = true;
                    break;
                }
                else if (numero < lista[medio])
                    derecha = medio - 1;
                else
                    izquierda = medio + 1;
            }

            if (!encontrado)
                Console.WriteLine("Número no encontrado");
        }
    }
}
