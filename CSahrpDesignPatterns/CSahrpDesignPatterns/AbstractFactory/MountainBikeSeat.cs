using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class MountainBikeSeat : IBikeSeat
    {
        public string BikeSeatParts
        {
            get { return "Seat parts for Mountain Bike"; }
        }

    }
}
