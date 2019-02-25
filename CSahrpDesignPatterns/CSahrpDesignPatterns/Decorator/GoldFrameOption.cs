using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSahrpDesignPatterns;

namespace Decorator
{
    public class GoldFrameOption : AbstractBikeOption
    {
        public override decimal price
        {
            get { return decoratedBike.price + 300.00m; }
        }
        public GoldFrameOption(IBycycle bycycle)
            : base(bycycle) { }
    }
}
