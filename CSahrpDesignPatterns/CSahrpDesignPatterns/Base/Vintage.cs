using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSahrpDesignPatterns
{
    public class Vintage : AbstractRoadBike
    {
        public override decimal price { get; } = 570.00m;
        public Vintage(IWheel wheel)
            : this(BikecColor.Black, wheel)
        {

        }
        public Vintage(BikecColor color, IWheel wheel)
            : base(color, wheel)
        {

        }

    }
}
