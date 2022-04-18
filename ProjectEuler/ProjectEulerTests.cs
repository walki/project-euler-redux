using NUnit.Framework;

namespace ProjectEuler
{
    public class Tests
    {
        ProjectEulerSolver solver;

        [SetUp]
        public void Setup()
        {
            solver = new ProjectEulerSolver();
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(4, 3)]
        [TestCase(6, 8)]
        [TestCase(10,23)]
        [TestCase(1000, 233168)]
        public void ReturnsSumOfMultiplesThreeAndFiveBelowN(int n, int expected)
        {
            int sum = solver.Problem1(n);
            Assert.AreEqual(expected, sum);
        }
    }
}