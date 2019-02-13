using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSahrpDesignPatterns;

namespace Builder
{
    public abstract class BikeDirector
    {
        public abstract IBycycle Bulid(BikeBulder builder);
    }
}
