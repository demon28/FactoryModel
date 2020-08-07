using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class BmwCar : Car
    {
        public string DirverOnHighSpeed()
        {
            return "我宝马，能上高速";
        }
    }
}
