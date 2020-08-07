using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class BenzSuperCar : BenzCar
    {
        public BenzSuperCar()
        {
        }

        public override string DirverOnHighSpeed()
        {
           return "我奔驰超跑,我能上高速";
        }

        public string Speed() {

            return "我能跑180码";
        }
    }
}
