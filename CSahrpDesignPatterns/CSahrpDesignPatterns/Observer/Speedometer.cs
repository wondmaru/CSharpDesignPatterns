using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSahrpDesignPatterns;

namespace Observer
{
    public class Speedometer
    {
        public EventHandler ValueChanged;
        private int _currentSpeed;
        public int CurrentSpeed
        {
            set
            {
                this._currentSpeed = value;
                OnValueChanged();
            }
            get
            {
                return _currentSpeed;
            }
        }

        public Speedometer() { _currentSpeed = 0; }
        protected void OnValueChanged()
        {
            if (ValueChanged != null)
            {
                ValueChanged(this, EventArgs.Empty);
            }

        }
    }
}
