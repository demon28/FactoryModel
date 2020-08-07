using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
   public class DriverZhao: ZongCaiBan
    {
        public  Car Driver(string car)
        {


            if (car == "宝马")
            {
                return new BmwCar();
            }

            if (car == "奥迪")
            {
                return new AudiCar();
            }

            return new BmwCar();

        }

    }
}
