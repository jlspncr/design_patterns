using System;

namespace abstract_factory_pattern
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("What a fantastic day for capitalism! Here is what we offer: \n");

      // Create and run Offerman Woodshop
      Vendor offerman = new Offerman();
      Client buyer = new Client(offerman);
      Console.WriteLine("Offerman Wood Shop: \n");
      buyer.GetSuggestion();

      // Create and run Amazon store
      Vendor amazon = new Amazon();
      buyer = new Client(amazon);
      Console.WriteLine("Amazon: \n");
      buyer.GetSuggestion();

      // wait for user input
      Console.ReadKey();
    }
  }
}
