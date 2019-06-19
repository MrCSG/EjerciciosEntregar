using System;

namespace EjercitacionExamen
{
    public class Ejercicio10
    {
        public static int Solution(int[] A)
        {
            int solution = 1;
            for(int i = 0; i < A.Length; i++)
            {
                if(A[i]>0)
                {
                    for (int j = 1; j <= A.Length; j++)
                    {
                        if(A[i] == j && A[i] >= solution)
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