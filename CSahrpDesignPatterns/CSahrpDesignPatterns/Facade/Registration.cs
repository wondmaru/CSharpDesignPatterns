using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSahrpDesignPatterns;

namespace Facade
{
    public class Registration
    {
        private IBycycle _bycycle;
        public Registration(IBycycle bycycle)
        {
            this._bycycle = bycycle;
        }
        public void AllocateBikeNumber()
        {
            Console.WriteLine("Allocating Bike Number");
        }

    }
}
