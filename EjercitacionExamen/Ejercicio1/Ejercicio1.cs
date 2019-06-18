using System;

namespace EjercitacionExamen
{
    public class Ejercicio1
    {
        public static void Example()
        {
            TextInput input = new NumericInput();
            Console.WriteLine("Add(\'1\');\nAdd(\'a\');\nAdd(\'0\');");
            input.Add('1');
            input.Add('a');
            input.Add('0');
            Console.WriteLine($"Output: {input.GetValue()}");
        }
    }
}