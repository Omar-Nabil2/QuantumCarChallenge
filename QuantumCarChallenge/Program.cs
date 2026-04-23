namespace QuantumCarChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarFactory factory = new CarFactory();

            Console.WriteLine("=== Case 1: Hybrid Switching Logic ===");
            Car hybridCar = factory.CreateCar(EngineType.Hybrid);
            hybridCar.Start();
            hybridCar.Accelerate();
            hybridCar.Accelerate();
            hybridCar.Accelerate();
            hybridCar.Brake();

            Console.WriteLine("\n=== Case 2: Replacement Safety ===");
            factory.ReplaceEngine(hybridCar, new GasolineEngine());

            hybridCar.Brake();
            hybridCar.Brake();
            factory.ReplaceEngine(hybridCar, new ElectronicEngine());
            hybridCar.Accelerate();

            Console.WriteLine("\n=== Case 3: Speed Limits ===");
            Car fastCar = factory.CreateCar(EngineType.Gas);
            fastCar.Start();
            for (int i = 0; i < 12; i++)
            {
                fastCar.Accelerate();
            }

            Console.WriteLine("\n=== Case 4: Stop Condition ===");
            fastCar.Stop();

            Console.WriteLine("\n=== Tests Completed ===");
        }
    }
}
