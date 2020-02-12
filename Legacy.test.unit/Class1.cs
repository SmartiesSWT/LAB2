using System;
using NUnit.Framework;

namespace Legacy.test.unit
{
    public class LegacyTest
    {
        private ECS uut;
        private FakeTempSensor uutsensor;
        private FakeHeater uutHeater;
        
        [SetUp]
        public void Setup()
        {
            // Arrange


            uutsensor = new FakeTempSensor();
            uutHeater = new FakeHeater();

            uut = new ECS(5, uutsensor, uutHeater);
        }

        [Test]
        public void regulate_When_Temp_Is_Beyond_Threshold()
        {
            uutsensor.Number = 10;
            uut.Regulate();
            Assert.That(uutHeater.CounterOff, Is.EqualTo(1));
        }











    }
}
