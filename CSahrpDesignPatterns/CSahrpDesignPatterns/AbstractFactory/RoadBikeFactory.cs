using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class RoadBikeFactory : AbstractBikeFactory

    {
        public override IBikeFrame CreatBikeFrame()
        {
            return new RoadFrame();
        }


        public override IBikeSeat CreatBikeseat()
        {
            return new RoadSeatParts();
        }
    }
}
