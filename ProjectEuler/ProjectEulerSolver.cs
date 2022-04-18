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
    }
}