using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSahrpDesignPatterns
{
    public class CossCountry : AbstractMountainBike
    {
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
