using System;
using System.Reflection;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {


            string calssName = "AbstractFactory.BwmSuperCar";

            Car car = (Car)Assembly.Load("AbstractFactory").CreateInstance(calssName);


            Console.WriteLine(car.DirverOnHighSpeed());
        }
    }
}
