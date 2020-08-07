using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class BenzShangWu : BenzCar
    {
        public BenzShangWu()
        {
        }

        public override string DirverOnHighSpeed()
        {
          return  "我奔驰商户，能上高速";
        }

      

    }
}
