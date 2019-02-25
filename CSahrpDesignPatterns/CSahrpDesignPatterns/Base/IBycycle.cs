using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSahrpDesignPatterns
{
    public interface IBycycle
    {
        IWheel GetWheel { get; }
        BikecColor ColorType { get; }
        decimal price { get; }
        void paint(BikecColor color);

    }
}
