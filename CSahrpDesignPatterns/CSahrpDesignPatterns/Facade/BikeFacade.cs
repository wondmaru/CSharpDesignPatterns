using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSahrpDesignPatterns;

namespace Facade
{
    public class BikeFacade
    {
        public void PrepareForSale(IBycycle bycycle)
        {
            Registration reg = new Registration(bycycle);
            reg.AllocateBikeNumber();
            Documentation.PrintBrocher(bycycle);
            bycycle.Airtires();
            bycycle.Airtires();
            bycycle.TestRide();


        }
    }
}
