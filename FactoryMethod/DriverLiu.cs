using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
   public class DriverLiu : ZongCaiBan
    {

        public  Car Driver(string car) {

            if (car=="奔驰")
            {
                return new BenzCar();
            }
            if (car == "路虎")
            {
                return new RangeRoverCar();
            }


            return new BenzCar();
        
        }


    }
}
