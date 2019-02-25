using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSahrpDesignPatterns
{
    public class DownHill : AbstractMountainBike
    {
        public override decimal price { get; } = 840.00m;
        public DownHill(IWheel wheel)
            : this(BikecColor.Green, wheel)
        {

        }
        public DownHill(BikecColor color, IWheel wheel)
            : base(color, wheel)
        {

        }
    }
}
