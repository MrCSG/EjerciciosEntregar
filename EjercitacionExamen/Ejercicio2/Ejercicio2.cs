/* Ejercicio 2

A palindrome is a word that reads the same backward or forward.

Write a function that checks if a given word is a palindrome. Character case should be
ignored.

For example, IsPalindrome("Deleveled") should return true as character case
should be ignored, resulting in "deleveled", which is a palindrome since it reads
the same backward and forward. */

using System;

namespace EjercitacionExamen
{
    public class Ejercicio2
    {
        public static bool IsPalindrome(string s)
        {
            bool flag = true;
            s = s.ToLower();
            for(int i=0; i<s.Length-1; i++)
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