using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSahrpDesignPatterns
{
    public class AbstractWheel : IWheel

    {
        private int _size;
        private bool _isWide;

        public bool IsWide
        {
            get
            {
                return _isWide;
            }

        }

        public int Size
        {
            get
            {
                return _size;
            }

        }

        public AbstractWheel(int size, bool isWide)
        {
            this._size = size;
            this._isWide = isWide;
        }
        public override string ToString()
        {
            return this.GetType().Name + "with a wheel size of " + _size + " inches. ";
        }
    }
}
