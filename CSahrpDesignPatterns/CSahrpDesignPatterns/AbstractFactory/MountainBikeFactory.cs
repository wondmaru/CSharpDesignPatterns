using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class MountainBikeFactory : AbstractBikeFactory
    {
        public override IBikeFrame CreatBikeFrame()
        {
            return new MaountainFrame();
        }


        public override IBikeSeat CreatBikeseat()
        {
            return new MountainBikeSeat();
        }
    }
}
