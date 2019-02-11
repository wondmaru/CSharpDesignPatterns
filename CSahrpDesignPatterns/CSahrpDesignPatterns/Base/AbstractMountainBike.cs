﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSahrpDesignPatterns
{
    public class AbstractMountainBike : AbstractBike
    {
        public AbstractMountainBike(IWheel wheel)
            : this(BikecColor.Chrome, wheel)
        {

        }
        public AbstractMountainBike(BikecColor color, IWheel wheel)
            : base(color, wheel)
        {

        }
    }
}
