using System;

namespace factory_method_pattern
{
  class Program
  {
    static void Main(string[] args)
    {
      Contractor[] contracts = new Contractor[2];

      contracts[0] = new DoT();
      contracts[1] = new Speedway();

      foreach (Contractor contract in contracts)
      {
        Console.WriteLine("\n" + "A New " + contract.GetType().Name + " project includes the following: ");
        foreach (Road road in contract.Roads)
        {
          Console.WriteLine(" -" + road.GetType().Name);
        }

      }
    }
  }
}
