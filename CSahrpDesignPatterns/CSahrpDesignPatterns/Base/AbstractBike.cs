using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSahrpDesignPatterns
{
    public abstract class AbstractBike : IBycycle
    {
        private BikecColor _color;
        private IWheel _wheel;

        public BikecColor ColorType
        {
            get
            {
                return _color;
            }
        }

        public IWheel GetWheel
        {
            get
            {
                return _wheel;
            }
        }
        public abstract decimal price { get; }

        public AbstractBike(BikecColor color, IWheel wheel)
        {
            this._wheel = wheel;
            this._color = color;
        }

        public void paint(BikecColor color)
        {
            this._color = color;
        }
        public override string ToString()
        {
            return this.GetType().Name + "Bicycle color is " + _color + " Cost is " + 240.00m;
        }
    }
}
