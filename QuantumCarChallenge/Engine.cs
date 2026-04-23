using System;
using System.Collections.Generic;
using System.Text;

namespace QuantumCarChallenge
{
    internal abstract class Engine
    {
        public int internalSpeed { get; protected set; }

        public virtual void Increase()
        {
            internalSpeed++;
            Console.WriteLine($"Engine internal speed increased to: {internalSpeed} km/h");
        }

        public virtual void Decrease()
        {
            internalSpeed--;
            Console.WriteLine($"Engine internal speed decreased to: {internalSpeed} km/h");
        }

        public abstract void UpdateSpeed(int currentSpeed);
    }
}
