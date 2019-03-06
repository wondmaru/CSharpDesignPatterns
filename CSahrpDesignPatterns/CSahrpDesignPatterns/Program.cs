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
using Facade;
using Iterator;
using System.Collections;
using Observer;
using Visitor;


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
            // DacoratePatternDemo();
            //FacadePatternDemo();
            // IteratorPatternDemo();
            // IteratorPatternDemo2();
            // ObserverPatternDemo();
            VisitorPatternDemo();
        }
        private static void VisitorPatternDemo()
        {
            IWheel wheel = new NarrowWheel(24);
            wheel.AcceptVisitor(new WheelDiagnostics());
            wheel.AcceptVisitor(new WheelInventory());
        }
        private static void ObserverPatternDemo()
        {
            Speedometer myspeedometer = new Speedometer();
            SpeedMonitor monitor = new SpeedMonitor(myspeedometer);
            GearBox gearBox = new GearBox(myspeedometer);
            myspeedometer.CurrentSpeed = 10;
            myspeedometer.CurrentSpeed = 20;
            myspeedometer.CurrentSpeed = 25;
            myspeedometer.CurrentSpeed = 30;
            myspeedometer.CurrentSpeed = 35;


        }
        private static void IteratorPatternDemo2()
        {
            Console.WriteLine("=== Road Bikes ===");
            RoadBikeRange roadBikeRange = new RoadBikeRange();

            foreach (IBycycle bycycle in roadBikeRange.Range)
            {
                Console.WriteLine(bycycle);
            }
            Console.WriteLine("=== Mountain Bikes ===");
            MountainBikeRange mountainBike = new MountainBikeRange();
            foreach (IBycycle bycycle in mountainBike.Range)
            {
                Console.WriteLine(bycycle);
            }
        }


        private static void IteratorPatternDemo()
        {
            Console.WriteLine("=== Road Bikes ===");
            RoadBikeRange roadBikeRange = new RoadBikeRange();
            PrintIterator(roadBikeRange.GetEnumerator());
            Console.WriteLine("=== Mountain Bikes ===");
            MountainBikeRange mountainBike = new MountainBikeRange();
            PrintIterator(mountainBike.GetEnumerator());
        }
        private static void PrintIterator(IEnumerator iter)
        {
            while (iter.MoveNext())
            {
                Console.WriteLine(iter.Current);
            }
        }
        private static void FacadePatternDemo()
        {
            BikeFacade facade = new BikeFacade();
            facade.PrepareForSale(new DownHill(BikecColor.Red, new WideWheel(20)));

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
