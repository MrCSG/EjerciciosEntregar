using System;

namespace EjercitacionExamen
{
    public class Ejercicio2
    {
        public static bool IsPalindrome(string s)
        {
            bool flag = true;
            s = s.ToLower();
            for(int i=0; i<(s.Length+1)/2; i++)
            {
                if(!(s[i]==s[s.Length-1-i]))
                {
                    flag = false;
                }
            }

            return flag;
        }
    }
}