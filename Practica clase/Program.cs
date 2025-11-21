using System;
using PracticaClase.Ejercicios;

class Program
{
    static void Main()
    {
        Console.WriteLine("Seleccione un ejercicio (1-6):");
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1: Ejercicio1.Ejecutar(); break;
            case 2: Ejercicio2.Ejecutar(); break;
            case 3: Ejercicio3.Ejecutar(); break;
            case 4: Ejercicio4.Ejecutar(); break;
            case 5: Ejercicio5.Ejecutar(); break;
            case 6: Ejercicio6.Ejecutar(); break;
            default: Console.WriteLine("Opción no válida"); break;
        }

        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}
