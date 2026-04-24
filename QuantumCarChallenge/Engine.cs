using System;
using System.Collections.Generic;
using System.Text;

namespace QuantumCarChallenge
{
    internal abstract class Engine
    {
        public int internalSpeed { get; protected set; }

        protected virtual void Increase()
        {
            internalSpeed++;
        }

        protected virtual void Decrease()
        {
            internalSpeed--;
        }

        public virtual void UpdateSpeed(int currentSpeed)
        {
            while (internalSpeed < currentSpeed) Increase();
            while (internalSpeed > currentSpeed) Decrease();
        }
    }
}
