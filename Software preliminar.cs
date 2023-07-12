using System;

class Program
{
    static void Main()
    {
        // Imprimir "Hola mundo"
        Console.WriteLine("Hola mundo");

        // Realizar sumas simples
        int num1 = 5;
        int num2 = 3;
        int suma = num1 + num2;

        Console.WriteLine("La suma de {0} y {1} es igual a {2}", num1, num2, suma);

        // Esperar a que el usuario presione una tecla para salir
        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}
