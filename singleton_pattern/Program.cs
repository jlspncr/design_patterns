using System;

namespace singleton_pattern
{
  class Program
  {
    static void Main(string[] args)
    {
      MakePizza p1 = MakePizza.ServePizza();
      MakePizza p2 = MakePizza.ServePizza();
      MakePizza p3 = MakePizza.ServePizza();
      MakePizza p4 = MakePizza.ServePizza();

      if (p1 == p2 && p2 == p3 && p3 == p4)
      {
        Console.WriteLine("Same Instance\n");
      }

      // Serve 10 pizzas 
      MakePizza pizzaria = MakePizza.ServePizza();
      for (int i = 0; i < 10; i++)
      {
        string specialty = pizzaria.Pizza;
        Console.WriteLine("Order Up! One " + specialty + " pizza!");
      }

      // Wait for user input
      Console.ReadKey();

    }
  }
}
