using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class BenzCar : Car
    {
        public string DirverOnHighSpeed()
        {
            return "奔驰，我能上高速";
        }
    }
}
