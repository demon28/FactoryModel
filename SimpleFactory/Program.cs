using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = MishuLi.Driver("奥迪");

            Console.WriteLine(car.DirverOnHighSpeed());

           
        }
    }
}









//留下疑问： 关于工厂模式，遵循了6大原则的哪些原则呢？