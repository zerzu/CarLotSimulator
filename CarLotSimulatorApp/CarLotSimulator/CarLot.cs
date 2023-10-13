using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class CarLot
    {
        
        //Inside the CarLot class from the previous exercise, create a static field called numberOfCars. DONE!!
        //Have this number only increment when in our program we create a new Car.  DONE!!
        //From there, use the 3 cars in the Main() (from the previous exercise) and then each time you create a car
        //do a Console.WriteLine() printing the current number of cars in the car lot.
        public List<Car> Inventory { get; set; } = new List<Car>();

        public static int numberOfCars;

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
