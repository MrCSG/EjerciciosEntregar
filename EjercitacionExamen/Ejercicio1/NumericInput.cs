using System;

namespace EjercitacionExamen
{
    public class NumericInput : TextInput
    {
        public override void Add(char c)
        {
            if(Int32.TryParse(c.ToString(), out int aux))
            {
                input += aux.ToString();
            }
        }
    }
}