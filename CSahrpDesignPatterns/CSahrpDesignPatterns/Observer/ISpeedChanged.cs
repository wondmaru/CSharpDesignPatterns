using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSahrpDesignPatterns;

namespace Observer
{
    public interface ISpeedChanged
    {
        void ValueHasChanged(object sender, EventArgs args);
    }
}
