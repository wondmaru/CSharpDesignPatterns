﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class RoadFrame : IBikeFrame
    {


        public string BikeFrameParts
        {
            get { return "frame parts for Road Bike"; }
        }

    }
}
