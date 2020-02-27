using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_6._Speed_Racing
{
    class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var cars = new HashSet<Car>();

            for (int i = 0; i < n; i++)
            {
                var carArguments = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                //"{model} {engineSpeed} {enginePower} 
                //{cargoWeight} {cargoType} {tire1Pressure} 
                //{tire1Age} {tire2Pressure} {tire2Age} 
                //{tire3Pressure} {tire3Age} {tire4Pressure} 
                //{tire4Age}"


                var model = carArguments[0];
                var engineSpeed = int.Parse(carArguments[1]);
                var enginePower = int.Parse(carArguments[2]);
                var cargoWeight = int.Parse(carArguments[3]);
                var cargoType = carArguments[4];
                var tire1Pressure = double.Parse(carArguments[5]);
                var tire1Age = int.Parse(carArguments[6]);
                var tire2Pressure = double.Parse(carArguments[7]);
                var tire2Age = int.Parse(carArguments[8]);
                var tire3Pressure = double.Parse(carArguments[9]);
                var tire3Age = int.Parse(carArguments[10]);
                var tire4Pressure = double.Parse(carArguments[11]);
                var tire4Age = int.Parse(carArguments[12]);

                var car = new Car(model,
             engineSpeed, enginePower,
             cargoWeight, cargoType,
             tire1Pressure, tire1Age,
             tire2Pressure, tire2Age,
             tire3Pressure, tire3Age,
             tire4Pressure, tire4Age);

                cars.Add(car);

            }


            string command = Console.ReadLine();

            if (command == "fragile")
            {
                var result = cars.Where(c => c.Cargo.Type == "fragile" && c.Tires.Any(t => t.Pressure < 1)).ToHashSet();

                Console.WriteLine(string.Join(Environment.NewLine, result));
            }
            else if( command == "flamable")
            {
                var result = cars.Where(c => c.Cargo.Type == "flamable" && c.Engine.Power > 250).ToHashSet();

                Console.WriteLine(string.Join(Environment.NewLine, result));
            }
        }
    }
}
