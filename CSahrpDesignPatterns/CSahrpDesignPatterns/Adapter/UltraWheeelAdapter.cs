using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSahrpDesignPatterns;

namespace Adapter
{
    class UltraWheeelAdapter : AbstractWheel

    {
        public UltraWheeelAdapter(UltraWheel ultraWheel)

            : base(ultraWheel.Wheelsize, false)
        {

        }
    }
}
