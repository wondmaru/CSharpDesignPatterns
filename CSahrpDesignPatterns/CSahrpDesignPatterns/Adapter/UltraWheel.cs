﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class UltraWheel
    {
        private int _size;
        public int Wheelsize
        {
            get
            {
                return _size;
            }
        }
        public UltraWheel(int size)
        {
            this._size = size;
        }
        public override string ToString()
        {
            return "Ultra Wheel " + _size;
        }

    }
}
