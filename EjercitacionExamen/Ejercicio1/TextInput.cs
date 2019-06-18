using System;

namespace EjercitacionExamen
{
    public class TextInput
    {
        protected string input;
        public virtual void Add(char c)
        {
            input += c.ToString();
        }

        public string GetValue()
        {
            return input;
        }
    }
}