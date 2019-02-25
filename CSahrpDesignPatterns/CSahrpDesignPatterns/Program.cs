using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory;
using Builder;
using Singleton;
using Adapter;
using Decorator;


namespace CSahrpDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // AbstractFactoryDemo();
            // BuilderPatternDemo();
            //SingltonPatternDemo();

            // AdapterPatternDemo();
            DacoratePatternDemo();
        }
        private static void DacoratePatternDemo()
        {
            IBycycle myTorBike = new Touring(new NarrowWheel(24));
            Console.WriteLine(myTorBike);
            myTorBike = new CustomerOption(myTorBike);
            Console.WriteLine(myTorBike);
        }
        private static void AdapterPatternDemo()
        {
            IList<IWheel> wheels = new List<IWheel>();
            wheels.Add(new NarrowWheel(24));
            wheels.Add(new WideWheel(24));
            wheels.Add(new NarrowWheel(26));
            wheels.Add(new UltraWheeelAdapter(new UltraWheel(28)));
            foreach (IWheel wheel in wheels)
            {
                Console.WriteLine(wheel);
            }
        }
        private static void SingltonPatternDemo()
        {
            SerialNumberGenerator generator = SerialNumberGenerator.Instance;
            Console.WriteLine("Next Serial" + generator.NextSerial);
            Console.WriteLine("Next Serial" + generator.NextSerial);
            Console.WriteLine("Next Serial" + generator.NextSerial);
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
