using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
   public class MishuLi
    {

        public static Car Driver(string car) {

            if (car=="奔驰")
            {
                return new BenzCar();
            }

            if (car=="宝马")
            {
                return new BmwCar();
            }

            if (car=="奥迪")
            {
                return new AudiCar();
            }

            return new BenzCar();
        
        }


    }
}
