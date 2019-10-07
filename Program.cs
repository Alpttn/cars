using System;
using System.Collections.Generic;

namespace cars
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(50000); //creates an instance, for starting miles we need to say the parameter.
            car1.Make = "Ford"; //line by line updating the properties of the object
            car1.Model = "Explorer";
            car1.Year = 1999;
            car1.Price = 1000.50;

            Car car2 = new Car(80000) //we are creating this car in one go and initializing. parens optional 
            {
                Make = "Mazda",
                Model = "B2500",
                Price = 115.99,
                Year = 1999
            };

            Car car3 = new Car(10000)
            {
                Make = "Nissan",
                Model = "GTR", //if you leave this out, the value will be null
                Price = 79999.99,
                Year = 2018
            };

            List<Car> garage = new List<Car>();
            garage.Add(car1);
            garage.Add(car2);
            garage.Add(car3);

            foreach (Car car in garage)
            {
                Console.WriteLine("Let's make the car go vroom!");
                car.Accelerate();
                Console.WriteLine();

                Console.WriteLine("How old is the car?");
                int age = car.GetAge();
                Console.WriteLine(age);

                Console.WriteLine(car.Description); //computed property, runs some logic

                car.Drive(1000); //I just drove this car 1000 miles
            }











            //stringly typed
            // Dictionary<string, string> car1 = new Dictionary<string, string>() {
            //     { "make", "kia"},
            //     { "model", "optima"},
            //     { "year", "2013"},
            //     { "price", "500"}
            // };

            

            // Dictionary<string, string> car2 = new Dictionary<string, string>() {
            //     { "make", "kia"},
            //     { "model", "sorento"},
            //     { "year", "2014"},
            //     { "price", "600"}
            // };
            // Dictionary<string, string> car3 = new Dictionary<string, string>() {
            //     { "make", "kia"},
            //     { "model", "sedona"},
            //     { "year", "2019"},
            //     { "price", "700"}
            // };

            // List<Dictionary<string, string>> garage = new List<Dictionary<string, string>>();
            
            // garage.Add(car1);
            // garage.Add(car2);
            // garage.Add(car3);

        }
    }
}
