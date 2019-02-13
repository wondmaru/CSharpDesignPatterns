using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSahrpDesignPatterns;
namespace Builder
{
    public abstract class BikeBulder
    {
        public abstract IBycycle Bicycle { get; }
        public virtual void BuildStreetTires() { }
        public virtual void BuildWideTires() { }
        public virtual void BuildHandelBars() { }
    }
}
