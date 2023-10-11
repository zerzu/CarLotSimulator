using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class CarLot
    {
        public List<Car> Inventory { get; set; } = new List<Car>();

        public void CheckInventory()
        {

            foreach (Car car in Inventory)
            {
                Console.WriteLine($"This is a {car.Make} {car.Model}, made in {car.Year}.");
                car.MakeEngineNoise(car.EngineNoise);
                car.MakeHonkNoise(car.HonkNoise);
            }

        }

    }
    
}
