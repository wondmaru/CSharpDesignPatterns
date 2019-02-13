using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSahrpDesignPatterns;

namespace Builder
{
    public class MountainBiekeBulder : BikeBulder
    {
        private AbstractMountainBike _MountainBikeinProgress;

        public override IBycycle Bicycle

        {
            get
            {
                return _MountainBikeinProgress;
            }
        }

        public MountainBiekeBulder(AbstractMountainBike mountainBike)
        {
            this._MountainBikeinProgress = mountainBike;
        }

        public override void BuildWideTires()
        {
            Console.WriteLine("Bulding MountainBike Wide Tires");
        }

        public override void BuildHandelBars()
        {
            Console.WriteLine("Bulding MountainBike HandleBars");
        }

    }
}
