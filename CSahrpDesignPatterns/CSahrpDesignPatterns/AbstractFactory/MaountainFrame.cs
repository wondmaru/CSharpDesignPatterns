using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class MaountainFrame : IBikeFrame
    {

        public string BikeFrameParts
        {
            get { return "frame parts for Mountain Bike"; }
        }

    }
}
