using System;
namespace Tsts
{
    public class Car
    {
        private double price;
        public Car(double price)
        {
            this.price = price;
        }
        
        public double GetPrice()
        {
            return price;
        }
        public void IncreasePrice(double count)
            => price *= count;

        public void AddPrice(double count)
            => price += count;
        
        public void SharePrice(double count)
            => price /= count;

        public void SubtractNumFromPrice(double count)
            => price -= count;
    }
}