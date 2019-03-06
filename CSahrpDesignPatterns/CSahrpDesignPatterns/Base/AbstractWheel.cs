using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor;

namespace CSahrpDesignPatterns
{
    public class AbstractWheel : IWheel

    {
        private int _size;
        private bool _isWide;
        private Spokes _spoke;
        private Bearings _bearings;


        public bool IsWide
        {
            get
            {
                return _isWide;
            }

        }

        public int size
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
            _spoke = new Spokes();
            _bearings = new Bearings();
        }


        public override string ToString()
        {
            return this.GetType().Name + "with a wheel size of " + _size + " inches. ";
        }

        public virtual void AcceptVisitor(IWheelVisitor visitor)
        {
            _spoke.AcceptVisitor(visitor);
            _bearings.AcceptVisitor(visitor);
            visitor.Visit(this);
        }
    }
}
