using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            ZongCaiBan zongCaiBan = new DriverLiu();

            Car car= zongCaiBan.Driver("路虎");


            Console.WriteLine(car.DirverOnHighSpeed());
        }
    }
}
