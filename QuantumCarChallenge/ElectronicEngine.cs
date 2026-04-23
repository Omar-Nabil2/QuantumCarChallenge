using System;
using System.Collections.Generic;
using System.Text;

namespace QuantumCarChallenge
{
    internal class ElectronicEngine : Engine
    {
        public override void UpdateSpeed(int currentSpeed)
        {
            internalSpeed = currentSpeed;
            Console.WriteLine($"Electronic Engine updated. Internal speed is now: {internalSpeed}");
        }
    }
}
