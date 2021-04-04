using System;

namespace builder_pattern
{
  class Program
  {
    static void Main(string[] args)
    {
      InsBuilder builder;

      // Create a manufacturer with instruments builders 
      Manufacturer customShop = new Manufacturer();

      // Construct and display instruments
      builder = new GuitarBuilder();
      customShop.Construct(builder);
      builder.Instrument.Show();

      builder = new BassBuilder();
      customShop.Construct(builder);
      builder.Instrument.Show();

      builder = new ViolinBuilder();
      customShop.Construct(builder);
      builder.Instrument.Show();

      // Wait for user input
      Console.ReadKey();
    }
  }
}
