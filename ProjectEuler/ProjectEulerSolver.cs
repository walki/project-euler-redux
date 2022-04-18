using System;
using System.Linq;

namespace ProjectEuler
{
    internal class ProjectEulerSolver
    {
        internal int Problem1(int n)
        {
            return Enumerable.Range(0, n)
                        .Where(curr => curr % 3 == 0 || curr % 5 == 0)
                        .Sum();
        }

        internal int Problem2(int max)
        {
            int curr = 0;
            int term1 = 0;
            int term2 = 1;
            int sum = 0;

            do
            {
                curr = term1 + term2;
                term1 = term2;
                term2 = curr;

                if (curr % 2 == 0)
                {
                    sum += curr;
                }
            } while (curr < max);

            return sum;
        }
    }
}