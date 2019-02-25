using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSahrpDesignPatterns
{
    public class CossCountry : AbstractMountainBike
    {
        public override decimal price { get; } = 870.00m;
        public CossCountry(IWheel wheel)
            : this(BikecColor.Red, wheel)
        {

        }
        public CossCountry(BikecColor color, IWheel wheel)
            : base(color, wheel)
        {

        }
    }
}
