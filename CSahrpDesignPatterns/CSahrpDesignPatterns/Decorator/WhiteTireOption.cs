using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSahrpDesignPatterns;

namespace Decorator
{
    public class WhiteTireOption : AbstractBikeOption
    {
        public override decimal price
        {
            get { return decoratedBike.price + 800.00m; }
        }
        public WhiteTireOption(IBycycle bycycle)
            : base(bycycle) { }
    }
}
