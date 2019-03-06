using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSahrpDesignPatterns;

namespace Visitor
{
    public interface IVisitable
    {
        void AcceptVisitor(IWheelVisitor visitor);

    }
}
