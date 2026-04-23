using System;
using System.Collections.Generic;
using System.Text;

namespace QuantumCarChallenge
{
    internal class GasolineEngine : Engine
    {
        public override void UpdateSpeed(int currentSpeed)
        {
            internalSpeed = currentSpeed;
            Console.WriteLine($"Gasoline Engine updated. Internal speed is now: {internalSpeed}");
        }
    }
}
