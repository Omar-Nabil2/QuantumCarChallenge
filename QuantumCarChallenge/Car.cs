using System;
using System.Collections.Generic;
using System.Text;

namespace QuantumCarChallenge
{
    internal class Car
    {
        private int _currentSpeed;
        private Engine _engine;

        public Car(Engine engine)
        {
            _engine = engine;
            _currentSpeed = 0;
        }

        public void SetEngine(Engine newEngine)
        {
            if (_currentSpeed == 0)
            {
                _engine = newEngine;
                Console.WriteLine("Engine replaced successfully.");
            }
            else
            {
                Console.WriteLine("Cannot replace engine while the car is moving!");
            }
        }

        public void Start()
        {
            _currentSpeed = 0;
            _engine.UpdateSpeed(0);
            Console.WriteLine("Car started at 0 speed.");
        }

        public void Stop()
        {
            if (_currentSpeed == 0)
            {
                Console.WriteLine("Car stopped.");
            }
            else
            {
                Console.WriteLine("Error: Must slow down to 0 before stopping.");
            }
        }

        public void Accelerate()
        {
            if (_currentSpeed + 20 <= 200)
            {
                _currentSpeed += 20;
                Console.WriteLine($"Accelerating... Car speed: {_currentSpeed} km/h");
                _engine.UpdateSpeed(_currentSpeed);
            }
        }

        public void Brake()
        {
            if (_currentSpeed - 20 >= 0)
            {
                _currentSpeed -= 20;
                Console.WriteLine($"Braking... Car speed: {_currentSpeed} km/h");
                _engine.UpdateSpeed(_currentSpeed);
            }
        }
    }
}
