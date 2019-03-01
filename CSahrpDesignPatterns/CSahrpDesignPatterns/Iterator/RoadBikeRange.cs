using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSahrpDesignPatterns;
namespace Iterator
{
    public class RoadBikeRange
    {
        private IList<IBycycle> _bycycles;
        public virtual IList<IBycycle> Range
        { get { return _bycycles; } }
        public RoadBikeRange()
        {
            _bycycles = new List<IBycycle>();
            _bycycles.Add(new Touring(new NarrowWheel(24)));
            _bycycles.Add(new Touring(BikecColor.Blue, new NarrowWheel(22)));
            _bycycles.Add(new Touring(BikecColor.Green, new NarrowWheel(26)));
            _bycycles.Add(new Vintage(new NarrowWheel(24)));
            _bycycles.Add(new Vintage(BikecColor.Red, new NarrowWheel(22)));
        }

        public virtual IEnumerator<IBycycle> GetEnumerator()
        {
            return _bycycles.GetEnumerator();
        }
    }
}
