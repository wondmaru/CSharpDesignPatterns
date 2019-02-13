using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory;
using Builder;

namespace CSahrpDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // AbstractFactoryDemo();
            BuilderPatternDemo();
        }

        private static void BuilderPatternDemo()
        {
            AbstractMountainBike mountainBike = new DownHill(BikecColor.Green, new WideWheel(24));
            BikeBulder builder = new MountainBiekeBulder(mountainBike);
            BikeDirector director = new MountainBikeDirector();
            IBycycle bycycle = director.Bulid(builder);
            Console.WriteLine(bycycle);
        }
        private static void AbstractFactoryDemo()
        {
            AbstractBikeFactory factory = new RoadBikeFactory();
            AbstractBikeFactory factory1 = new MountainBikeFactory();

            IBikeFrame bikeFrame = factory.CreatBikeFrame();
            IBikeSeat bikeSeat = factory.CreatBikeseat();
            IBikeFrame bikeframe = factory1.CreatBikeFrame();
            IBikeSeat bikeseat = factory1.CreatBikeseat();

            Console.WriteLine(bikeFrame.BikeFrameParts);
            Console.WriteLine(bikeSeat.BikeSeatParts);
            Console.WriteLine(bikeframe.BikeFrameParts);
            Console.WriteLine(bikeseat.BikeSeatParts);

        }
    }
}
