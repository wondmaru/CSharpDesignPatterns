using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSahrpDesignPatterns;

namespace Decorator
{
    public class CustomerOption : AbstractBikeOption
    {
        public override decimal price
        {
            get { return decoratedBike.price + 20.00m; }
        }
        public CustomerOption(IBycycle bycycle)
            : base(bycycle) { }
    }
}
