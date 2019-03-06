using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSahrpDesignPatterns;

namespace Visitor
{
    public class WheelInventory : IWheelVisitor
    {
        int _bearingcount;
        int _spokecount;
        public void Visit(IWheel wheel)
        {
            Console.WriteLine("The wheel has: {0} spokes and {1} bearings ", _spokecount, _bearingcount);
        }

        public void Visit(Spokes spoke)
        {
            _spokecount++;
        }

        public void Visit(Bearings bearing)
        {
            _bearingcount++;
        }
    }
}
