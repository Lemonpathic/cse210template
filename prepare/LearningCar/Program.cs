namespace learningCar;

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        var car = new Car("Honda", "Civic");
        car.PrintDetails();
    }
}

