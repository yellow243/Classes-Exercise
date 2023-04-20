using System.Collections.Generic;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Ford";
            myCar.Model = "Fusion";
            myCar.Year = 2017;


            var mazda = new Car()
            {
                Make = "Mazda",
                Model = "CX-5",
                Year = 2016
            };

            var chevy = new Car("Chevy", "Impala", 1987);
            
            var carList = new List<Car>();
            carList.Add(myCar);
            carList.Add(chevy);
            carList.Add(mazda);
            foreach (var car in carList)
            {
                Console.WriteLine(car.Make);
                Console.WriteLine(car.Model);
                Console.WriteLine(car.Year);

                Console.WriteLine();
            }



        }
    }
}
