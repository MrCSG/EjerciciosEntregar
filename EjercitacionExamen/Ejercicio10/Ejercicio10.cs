using System;

namespace EjercitacionExamen
{
    public class Ejercicio10
    {
        public static int Solution(int[] A)
        {
            int solution = 1;

            Array.Sort(A);

            for (int i = 0; i < A.Length; i++)
            {
                if(A[i] > 0 && A[i] == solution)
                {
                    solution++;
                }
            }

            return solution;
        }
    }
}