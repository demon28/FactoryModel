using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class BwmSuperCar : BwmCar
    {
        public BwmSuperCar()
        {
        }

        public override string DirverOnHighSpeed()
        {
           return "我宝马，超跑上高速";
        }

      
    }
}
