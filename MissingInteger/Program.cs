using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 1, 3, 6, 4, 1, 2 };

            Console.WriteLine(Soulution(A));
        }

        public static int Soulution(int[] A)
        {
            const int A_MAX = 100000;
            int[] B = new int[A_MAX];

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] <= 0 || A[i] > A_MAX) continue;
                B[A[i] - 1]++;
            }

            for (int i = 0; i < B.Length; i++)
            {
                if (B[i] == 0) return i + 1;
            }
            return A_MAX + 1;
        }
    }
}
