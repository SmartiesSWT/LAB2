using System;
using NUnit.Framework;

namespace Legacy.test.unit
{
    public class LgacyTest
    {
        private ECS uut;
        public void Setup()
        {
            // Arrange
            uut = new ECS(5);
        }

        [TestCase(4, 0, 4)]
        [TestCase(3, 0, 3)]
        [TestCase(-3, -9, -12)]
        public void Add2Numbers_ReturnSumOfNumbersAdded(double a, double b, double result)
        {
            Assert.That(uut.Regulate(),Is.EqualTo());
            Assert.That(uut.Add(a, b), Is.EqualTo(result));
            Assert.That(uut.Accumulator, Is.EqualTo(result));
        }
    }
}
