using NUnit.Framework;

namespace Calculator.Test
{
    [TestFixture]
    public class Class1
    {
        ICalculator test;

        [SetUp]
        public void Setup()
        {
            test = new Calculator();
        }
        [TestCase(7, 8, 15)]
        [TestCase(11, 22, 33)]
        [TestCase(1, 9, 10)]
        [TestCase(55, 55, 110)]
        public void ShouldAddTwoNumbers(int one, int two, int result)
        {
            int expected = test.Add(one, two);
            Assert.That(expected, Is.EqualTo(result));
        }
        [Test]
        public void ShouldMulTwoNumbers()
        {
            int expected = test.Mul(7, 8);
            Assert.That(expected, Is.EqualTo(56));
        }
        [Test]
        [Ignore("Not working properly")]
        public void ShouldNotMulTwoNumbers()
        {
            int expected = test.Mul(7, 8);
            Assert.That(expected, Is.EqualTo(15));
        }
        [TearDown]
        public void TearDown()
        {
            test = null;
        }
    }
}
