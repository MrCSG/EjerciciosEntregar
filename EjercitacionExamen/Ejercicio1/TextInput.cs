using System;

namespace EjercitacionExamen
{
    public class TextInput
    {
        protected string text;
        public virtual void Add(char c)
        {
            text += c;
        }

        public string GetValue()
        {
            return text;
        }
    }
}