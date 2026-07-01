using NUnit.Framework;
using CalcLibrary;

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        Calculator calc;

        [SetUp]
        public void Init()
        {
            calc = new Calculator();
        }

        [TearDown]
        public void Cleanup()
        {
            calc = null;
        }

        [TestCase(2, 3, 5)]
        [TestCase(0, 0, 0)]
        [TestCase(-1, 1, 0)]
        [TestCase(100, 200, 300)]
        [TestCase(5, 9, 14)]
        public void AddTest(int a, int b, int expected)
        {
            int result = calc.Add(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(10, 3, 7)]
        [TestCase(5, 5, 0)]
        public void SubtractTest(int a, int b, int expected)
        {
            int result = calc.Subtract(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(3, 4, 12)]
        [TestCase(0, 5, 0)]
        [TestCase(6, 6, 36)]
        public void MultiplyTest(int a, int b, int expected)
        {
            int result = calc.Multiply(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void DivideByZeroTest()
        {
            Assert.That(() => calc.Divide(10, 0), Throws.TypeOf<DivideByZeroException>());
        }

        [TestCase(10, 2, 5.0)]
        [TestCase(7, 2, 3.5)]
        [TestCase(9, 3, 3.0)]
        public void DivideTest(int a, int b, double expected)
        {
            double result = calc.Divide(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Ignore("skipping this for now, will check later")]
        public void AddLargeNumbersTest()
        {
            int result = calc.Add(99999, 1);
            Assert.That(result, Is.EqualTo(100000));
        }
    }
}
