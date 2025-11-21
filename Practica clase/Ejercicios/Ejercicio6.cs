using System;

namespace PracticaClase.Ejercicios
{
    public static class Ejercicio6
    {
        public static void Ejecutar()
        {
            Random rnd = new Random();
            int[,] matriz = new int[10, 10];

            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                    matriz[i, j] = rnd.Next(1, 101);

            Console.WriteLine("Ingrese un número a buscar:");
            int numero = int.Parse(Console.ReadLine());

            bool encontrado = false;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (matriz[i, j] == numero)
                    {
                        Console.WriteLine($"Número encontrado en [{i},{j}]");
                        encontrado = true;
                    }
                }
            }

            if (!encontrado)
                Console.WriteLine("Número no encontrado");
        }
    }
}
