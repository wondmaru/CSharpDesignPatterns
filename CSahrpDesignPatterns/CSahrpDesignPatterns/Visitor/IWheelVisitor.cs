using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSahrpDesignPatterns;

namespace Visitor
{
    public interface IWheelVisitor
    {
        void Visit(IWheel wheel);
        void Visit(Spokes spoke);
        void Visit(Bearings bearing);

    }
}
