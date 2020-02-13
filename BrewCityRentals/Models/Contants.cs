using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrewCityRentals.Models
{
    public class Contants
    {
        public static double DAILY_RATE;

        public static double LATE_FEE;

        public Contants()
        {
            DAILY_RATE = 2.5;
            LATE_FEE = 3.0;
        }
    }
}