using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSahrpDesignPatterns;
namespace Builder
{
    public class RoadBikeBuilder : BikeBulder

    {
        private AbstractRoadBike _roadBikeinProgress;

        public override IBycycle Bicycle

        {
            get
            {
                return _roadBikeinProgress;
            }
        }

        public RoadBikeBuilder(AbstractRoadBike roadBike)
        {
            this._roadBikeinProgress = roadBike;
        }

        public override void BuildStreetTires()
        {
            Console.WriteLine("Bulding RoadBike Street Tires");
        }

        public override void BuildHandelBars()
        {
            Console.WriteLine("Bulding RoadBike HandleBars");
        }

    }


}
