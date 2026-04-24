using System;
using System.Collections.Generic;
using System.Text;

namespace QuantumCarChallenge
{
    internal class CarFactory
    {
        public Car CreateCar(EngineType engineType)
        {
            Engine engine = engineType switch
            {
                EngineType.Gas => new GasolineEngine(),
                EngineType.Electric => new ElectronicEngine(),
                EngineType.Hybrid => new MixedHybridEngine(),
                _ => throw new ArgumentException("Invalid engine type")
            };

            return new Car(engine);
        }

        public void ReplaceEngine(Car car, EngineType type)
        {
            Engine newEngine = type switch
            {
                EngineType.Gas => new GasolineEngine(),
                EngineType.Electric => new ElectronicEngine(),
                EngineType.Hybrid => new MixedHybridEngine(),
                _ => throw new ArgumentException("Invalid engine type")
            };
            car.SetEngine(newEngine);
        }
    }
}
