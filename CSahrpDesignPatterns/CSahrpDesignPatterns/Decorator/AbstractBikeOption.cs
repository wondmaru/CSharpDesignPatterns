using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSahrpDesignPatterns;



namespace Decorator
{
    public abstract class AbstractBikeOption : AbstractBike
    {


        protected internal IBycycle decoratedBike;
        public AbstractBikeOption(IBycycle bycycle)
            : base(BikecColor.Chrome, bycycle.GetWheel)
        {
            this.decoratedBike = bycycle;
        }


    }
}
