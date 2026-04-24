using System;
using System.Collections.Generic;
using System.Text;

namespace QuantumCarChallenge
{
    internal class MixedHybridEngine : Engine
    {
        private GasolineEngine _gasPart;
        private ElectronicEngine _electricPart;

        private GasolineEngine GasPart
        {
            get
            {
                if (_gasPart == null)
                {
                    _gasPart = new GasolineEngine();
                }
                return _gasPart;
            }
        }

        private ElectronicEngine ElectricPart
        {
            get
            {
                if (_electricPart == null)
                {
                    _electricPart = new ElectronicEngine();
                }
                return _electricPart;
            }
        }

        private bool _isRunningElectric = true;

        protected override void Increase()
        {
            base.Increase();
            ApplyHybridLogic();
        }

        protected override void Decrease()
        {
            base.Decrease();
            ApplyHybridLogic();
        }

        public override void UpdateSpeed(int currentSpeed)
        {
            base.UpdateSpeed(currentSpeed);
        }

        private void ApplyHybridLogic()
        {
            if (internalSpeed < 50)
            {
                if (!_isRunningElectric)
                {
                    Console.WriteLine("[Hybrid Mode] Speed < 50: Switching to ELECTRIC engine.");
                    _isRunningElectric = true;
                }

                if (_gasPart != null && _gasPart.internalSpeed != 0) _gasPart.UpdateSpeed(0);
                ElectricPart.UpdateSpeed(internalSpeed);
            }
            else
            {
                if (_isRunningElectric)
                {
                    Console.WriteLine("[Hybrid Mode] Speed >= 50: Switching to GAS engine.");
                    _isRunningElectric = false;
                }

                if (_electricPart != null && _electricPart.internalSpeed != 0) _electricPart.UpdateSpeed(0);
                GasPart.UpdateSpeed(internalSpeed);
            }
        }
    }
}
