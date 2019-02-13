using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSahrpDesignPatterns;

namespace Builder
{
    public class MountainBikeDirector : BikeDirector
    {
        public override IBycycle Bulid(BikeBulder builder)
        {
            builder.BuildHandelBars();
            builder.BuildStreetTires();
            return builder.Bicycle;
        }
    }
}
