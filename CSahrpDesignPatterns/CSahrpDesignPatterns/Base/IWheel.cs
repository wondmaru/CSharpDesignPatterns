﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor;

namespace CSahrpDesignPatterns
{
    public interface IWheel
    {
        int size { get; }
        bool IsWide { get; }
        void AcceptVisitor(IWheelVisitor visitor);
    }
}
