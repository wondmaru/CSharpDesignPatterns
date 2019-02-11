using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSahrpDesignPatterns
{
    public abstract class AbstractRoadBike : AbstractBike

    {
        public AbstractRoadBike(IWheel wheel)
            : this(BikecColor.Chrome, wheel)
        {

        }
        public AbstractRoadBike(BikecColor color, IWheel wheel)
            : base(color, wheel)
        {

        }
    }
}
