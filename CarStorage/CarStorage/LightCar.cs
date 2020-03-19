using System;
using System.Collections.Generic;
using System.Text;

namespace CarStorage
{
    public class LightCar : Car
    {
        public void Check()
        {
            GetSale();
            isColorValid("Red");
        }

    }
}
