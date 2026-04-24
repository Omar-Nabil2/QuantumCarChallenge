namespace QuantumCarChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarFactory factory = new CarFactory();

            Console.WriteLine("=== Case 1: Hybrid Switching Logic (Threshold 50) ===");
            Car hybridCar = factory.CreateCar(EngineType.Hybrid);
            hybridCar.Start();
            hybridCar.Accelerate();
            hybridCar.Accelerate();
            hybridCar.Accelerate();
            hybridCar.Brake();

            Console.WriteLine("\n=== Case 2: Engine Replacement Safety ===");
            Console.WriteLine("Attempting to replace engine while moving (40 km/h):");
            factory.ReplaceEngine(hybridCar, EngineType.Gas);

            Console.WriteLine("Slowing down to 0 to replace engine:");
            hybridCar.Brake();
            hybridCar.Brake();
            factory.ReplaceEngine(hybridCar, EngineType.Electric);

            Console.WriteLine("\n=== Case 3: Speed Boundaries (0 to 200) ===");
            Car fastCar = factory.CreateCar(EngineType.Gas);
            fastCar.Start();

            Console.WriteLine("Attempting to exceed 200 km/h:");
            for (int i = 0; i < 11; i++)
            {
                fastCar.Accelerate();
            }

            Console.WriteLine("Attempting to brake below 0 km/h:");
            fastCar.Brake();
            for (int i = 0; i < 10; i++)
            {
                fastCar.Brake();
            }

            Console.WriteLine("\n=== Case 4: Stop Constraints ===");
            Car testStopCar = factory.CreateCar(EngineType.Electric);
            testStopCar.Start();
            testStopCar.Accelerate();
            Console.WriteLine("Attempting to stop while speed is 20:");
            testStopCar.Stop();

            testStopCar.Brake();
            Console.WriteLine("Attempting to stop while speed is 0:");
            testStopCar.Stop();

            Console.WriteLine("\n=== Case 5: Hybrid Cost Optimization (Simultaneous Check) ===");

            Car costCar = factory.CreateCar(EngineType.Hybrid);
            costCar.Start();
            costCar.Accelerate();
            costCar.Accelerate();
            costCar.Accelerate();

            Console.WriteLine("\n=== All Tests Completed Successfully ===");
            Console.ReadLine();
        }
    }
}
