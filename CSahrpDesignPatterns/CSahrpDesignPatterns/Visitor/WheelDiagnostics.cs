using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSahrpDesignPatterns;

namespace Visitor
{
    public class WheelDiagnostics : IWheelVisitor
    {
        public void Visit(IWheel wheel)
        {
            Console.WriteLine("Diagnosing the wheel");
        }



        void IWheelVisitor.Visit(Spokes spoke)
        {
            Console.WriteLine("Diagnosing the spoke");
        }

        void IWheelVisitor.Visit(Bearings bearing)
        {
            Console.WriteLine("Diagnosing the bearing");
        }
    }
}
