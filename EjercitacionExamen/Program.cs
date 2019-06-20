using System;

namespace EjercitacionExamen
{
    class Program
    {
        static void Main(string[] args)
        {
            string option;
            int[] A;
            Console.WriteLine("Ingrese el número del ejercicio que desea ver:");
            option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Este programa recibe caracteres y los combina en una sola variable usando métodos de objetos.\nEste es un ejemplo:");
                    Ejercicio1.Solution();
                    Console.WriteLine("Ahora pruebe usted:");
                    Ejercicio1.Test();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Este programa averigua si el texto ingresado es o no Palíndromo.\nIngrese un texto:");
                    if(Ejercicio2.IsPalindrome(Console.ReadLine()))
                    {
                        Console.WriteLine("Es un palíndromo.");  
                    }else
                    {
                        Console.WriteLine("No es un palíndromo.");
                    }
                    break;
                case "10":
                    Console.Clear();
                    Console.WriteLine("Este programa busca el número positivo menor que no esté en el array indicado.");
                    Console.WriteLine("Array1: {1, 3, 6, 4, 1, 2}");
                    A = new int[]{1, 3, 6, 4, 1, 2};
                    Console.WriteLine($"Output: {Ejercicio10.Solution(A)}");
                    Console.WriteLine("Array2: {1, 2, 3}");
                    A = new int[]{1, 2, 3};
                    Console.WriteLine($"Output: {Ejercicio10.Solution(A)}");
                    Console.WriteLine("Array3: {-1, -3}");
                    A = new int[]{-1, -3};
                    Console.WriteLine($"Output: {Ejercicio10.Solution(A)}");
                    break;
                case "11":
                    Console.Clear();
                    Console.WriteLine("Este programa busca cuantas parejas de (0,1) se forman en un array, pero solo si el 1 aparece luego del 0.\nArray Ejemplo: {0, 1, 0, 1, 1}");
                    A = new int[]{0,1,0,1,1};
                    Console.WriteLine($"Output: {Ejercicio11.Solution(A)}");
                    break;
                default:
                    Console.WriteLine("Opción inexistente, solo hay 1,2,10 u 11.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
