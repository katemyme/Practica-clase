using System;

namespace PracticaClase.Ejercicios
{
    public static class Ejercicio1
    {
        public static void Ejecutar()
        {
            Random rnd = new Random();
            int[] arreglo = new int[20];

            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = rnd.Next(1, 101);
                Console.Write(arreglo[i] + " ");
            }

            Console.WriteLine("\nIngrese un número a buscar:");
            int numero = int.Parse(Console.ReadLine());

            int posicion = -1;
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] == numero)
                {
                    posicion = i;
                    break;
                }
            }

            if (posicion != -1)
                Console.WriteLine($"Número encontrado en la posición {posicion}");
            else
                Console.WriteLine("Número no encontrado");
        }
    }
}
