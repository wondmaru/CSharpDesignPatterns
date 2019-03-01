using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSahrpDesignPatterns;

namespace Iterator
{
    public class MountainBikeRange
    {
        private IBycycle[] _bycycles;
        public virtual IBycycle[] Range
        {
            get { return _bycycles; }
        }
        public MountainBikeRange()
        {
            _bycycles = new IBycycle[5];
            _bycycles[0] = new DownHill(new WideWheel(22));
            _bycycles[1] = new DownHill(BikecColor.Blue, new WideWheel(24));
            _bycycles[2] = new DownHill(BikecColor.Black, new WideWheel(26));
            _bycycles[3] = new CossCountry(new WideWheel(22));
            _bycycles[4] = new CossCountry(BikecColor.Green, new WideWheel(22));
        }

        public virtual IEnumerator<IBycycle> GetEnumerator()
        {
            return ((IEnumerable<IBycycle>)_bycycles).GetEnumerator();
        }
    }
}
