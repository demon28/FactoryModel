using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class AudiCar : Car
    {
        public string DirverOnHighSpeed()
        {
            return "我奥迪，能上高速";
        }
    }
}
