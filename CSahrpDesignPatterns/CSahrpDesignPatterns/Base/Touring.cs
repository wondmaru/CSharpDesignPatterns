using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSahrpDesignPatterns
{
    class Touring : AbstractRoadBike
    {
        public override decimal price { get; } = 600.00m;
        public Touring(IWheel wheel)
            : this(BikecColor.Blue, wheel)
        {

        }
        public Touring(BikecColor color, IWheel wheel)
            : base(color, wheel)
        {

        }
    }
}
