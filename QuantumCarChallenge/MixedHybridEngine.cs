using System;
using System.Collections.Generic;
using System.Text;

namespace QuantumCarChallenge
{
    internal class MixedHybridEngine : Engine
    {
        private readonly GasolineEngine _gasPart = new GasolineEngine();
        private readonly ElectronicEngine _electricPart = new ElectronicEngine();

        public override void UpdateSpeed(int currentSpeed)
        {
            base.UpdateSpeed(currentSpeed);

            if (currentSpeed < 50)
            {
                Console.WriteLine("[Hybrid Mode] Speed < 50: Running on ELECTRIC engine only (Cost Optimized).");
                _electricPart.UpdateSpeed(internalSpeed);
                if (_gasPart.internalSpeed != 0) _gasPart.UpdateSpeed(0);
            }
            else
            {
                Console.WriteLine("[Hybrid Mode] Speed >= 50: Running on GAS engine only.");
                _gasPart.UpdateSpeed(internalSpeed);
                if (_electricPart.internalSpeed != 0) _electricPart.UpdateSpeed(0);
            }
        }
    }
}
