using System;
using System.ComponentModel;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var carLot = new CarLot();
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            

            var navigator = new Car();
            navigator.Make = "Lincoln";
            navigator.Model = "Navigator";
            navigator.Year = 2005;
            navigator.EngineNoise = "Purr";
            navigator.HonkNoise = "Honk";
            navigator.IsDriveable = true;

            carLot.Inventory.Add(navigator);

            var beetle = new Car
            {
                Make = "Volkswagon",
                Model = "Beetle",
                Year = 1976,
                EngineNoise = "Buzz",
                HonkNoise = "Aaaaroogah",
                IsDriveable = true
            };

            carLot.Inventory.Add(beetle);

            var gremlin = new Car(1970, "AMC", "Gremlin", "Clonk", "None", false);

            carLot.Inventory.Add(beetle);

            carLot.CheckInventory();
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
