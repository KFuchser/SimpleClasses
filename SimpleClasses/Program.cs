using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myNewCar = new Car();

            myNewCar.Color = "Blue";
            myNewCar.Make = "Audi";
            myNewCar.Year = 2016;
            myNewCar.Model = "A4";


            Console.WriteLine("{0} - {1} - {2}", 
                myNewCar.Make, 
                myNewCar.Model, 
                myNewCar.Year );

            double value = myNewCar.DetermineMarketValue();

            Console.WriteLine(value);
                Console.ReadLine();



        }

        private static double determineValue (Car car)
        {
            double carValue = 100;
            return carValue;

        }
    }

    class Car
    {

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        

        public double DetermineMarketValue()

        { 
             double carValue = 100;

            if (this.Year > 2000)
                carValue = 20000;
            else
                carValue = 2000;


            return carValue;
        }
    }



}
