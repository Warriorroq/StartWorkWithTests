using NUnit.Framework;
using Tsts;

namespace TstsTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
         //working   
        }

        [Test]
        public void CheckCarMethodSubstract()
        {
            double need = 0;
            Car car = new Car(10);
            car.SubtractNumFromPrice(10);
            Assert.AreEqual(need,car.GetPrice());
        }
        [Test]
        public void CheckCarMethodAdd()
        {
            double need = 10;
            Car car = new Car(0);
            car.AddPrice(10);
            Assert.AreEqual(need,car.GetPrice());
        }
        [Test]
        public void CheckCarMethodIncrease()
        {
            double need = 10;
            Car car = new Car(2);
            car.IncreasePrice(5);
            Assert.AreEqual(need,car.GetPrice());
        }
        [Test]
        public void CheckCarMethodShare()
        {
            double need = 10;
            Car car = new Car(20);
            car.SharePrice(2);
            Assert.AreEqual(need,car.GetPrice());
        }
    }
}