using System;

namespace EjercitacionExamen
{
    public class Ejercicio11
    {
        public static int Solution(int[] A)
        {
            int solution = 0;
            for (int i = 0; i < A.Length-1; i++)
            {
                if(A[i] == 0)
                {
                    for (int j = i+1; j < A.Length; j++)
                    {
                        if(A[j]==1)
                        {
                            solution++;
                        }
                    }
                }
            }
            return solution;
        }
    }
}