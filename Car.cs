using System;

namespace cars
{
    public class Car //what a car would look like if it ever came into existence. blueprint on how instance of the car class behaves
    {
        // internal
        // protected only my subclasses can access this property

        private int _milesDriven = 0; // field ---no one can change this

        // public int TotalMiles
        // {
        //     get
        //     {
        //         return _milesDriven;
        //     }
        // }
        
        //constructor is a method that gets invoked an instance
        public Car(int startingMiles)  //we always want it to be public and the name of the class
        {
           _milesDriven = startingMiles; 
        }

        //properties
        public string Make { get; set; } //public defines accessability-- private means its only available here
        public string Model { get; set; } //get set is the ability to both read and write this property get=read and set= i can set it to something
        public int Year { get; set; } //if you want a read only property you can remove set. Can also say private set;
        public double Price { get; set; }
        public string Description 
        {
            get
            {
                return $"A {Year} {Make} {Model}"; //when you call description it will get the string
            }
        }


        public int Drive(int miles)
        {
            _milesDriven += miles;
            return _milesDriven; //what is it returning
        }

        //define a method that doesn't return anything
        public void Accelerate() //methods
        {
            Console.WriteLine($"The {Make} {Model} Vroom");
        }

        public int GetAge()
        {
            DateTime date =  DateTime.Now;
            int currentYear = date.Year;
            return currentYear - Year; //year refers to this car's year
        }

        //fields are read only. underscore naming convention for readonly

    }
}