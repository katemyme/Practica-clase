using System;

namespace PracticaClase.Ejercicios
{
    public static class Ejercicio3
    {
        public static int ContarPalabra(string parrafo, string palabra)
        {
            parrafo = parrafo.ToLower();
            palabra = palabra.ToLower();
            int contador = 0;

            for (int i = 0; i <= parrafo.Length - palabra.Length; i++)
            {
                bool coincide = true;
                for (int j = 0; j < palabra.Length; j++)
                {
                    if (parrafo[i + j] != palabra[j])
                    {
                        coincide = false;
                        break;
                    }
                }
                if (coincide)
                    contador++;
            }
            return contador;
        }

        public static void Ejecutar()
        {
            Console.WriteLine("Ingrese un párrafo:");
            string parrafo = Console.ReadLine();

            Console.WriteLine("Ingrese la palabra a buscar:");
            string palabra = Console.ReadLine();

            int veces = ContarPalabra(parrafo, palabra);
            Console.WriteLine($"La palabra '{palabra}' aparece {veces} veces.");
        }
    }
}
