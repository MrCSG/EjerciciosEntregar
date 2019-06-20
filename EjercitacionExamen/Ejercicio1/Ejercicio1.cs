using System;

namespace EjercitacionExamen
{
    public class Ejercicio1
    {
        public static void Solution()
        {
            TextInput input = new NumericInput();
            Console.WriteLine("Add(\'1\');\nAdd(\'a\');\nAdd(\'0\');");
            input.Add('1');
            input.Add('a');
            input.Add('0');
            Console.WriteLine($"Output: {input.GetValue()}");
        }
        public static void Test()
        {
            TextInput nInput = new NumericInput();
            TextInput tInput = new TextInput();

            Console.WriteLine("Ingrese N para probar \"NumericInput\" (Solo acepta números)\nO ingrese T para probar \"TextInput\" (acepta cualquier caracter)");
            string option = Console.ReadLine();
            if(option =="n"|| option == "N"){
                Console.WriteLine("Ingrese 4 caracteres para probar \"NumericInput\":");
                for (int i = 0; i < 4; i++)
                {
                    nInput.Add(Convert.ToChar(Console.ReadLine()));
                }
                Console.WriteLine($"Output: {nInput.GetValue()}");
            }else if(option == "t" || option == "T"){
                Console.WriteLine("Ingrese 4 caracteres para probar \"TextInput\":");
                for (int i = 0; i < 4; i++)
                {
                    tInput.Add(Convert.ToChar(Console.ReadLine()));
                }
                Console.WriteLine($"Output: {tInput.GetValue()}");
            }
        }
    }
}