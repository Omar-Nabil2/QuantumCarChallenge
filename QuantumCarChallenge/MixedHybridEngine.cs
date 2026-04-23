using System;
using System.Collections.Generic;
using System.Text;

namespace QuantumCarChallenge
{
    internal class MixedHybridEngine : Engine
    {
        private readonly GasolineEngine _gasPart = new GasolineEngine();
        private readonly ElectronicEngine _electricPart = new ElectronicEngine();

        public override void Increase()
        {
            base.Increase();
            UpdateSpeed(internalSpeed);
        }

        public override void Decrease()
        {
            base.Decrease();
            UpdateSpeed(internalSpeed);
        }

        public override void UpdateSpeed(int currentSpeed)
        {
            internalSpeed = currentSpeed;

            if (currentSpeed < 50)
            {
                Console.WriteLine("[Hybrid Mode] Speed < 50: Running on ELECTRIC engine only (Cost Optimized).");
                _electricPart.UpdateSpeed(currentSpeed);
            }
            else
            {
                Console.WriteLine("[Hybrid Mode] Speed >= 50: Running on GAS engine only.");
                _gasPart.UpdateSpeed(currentSpeed);
            }
        }
    }
}
