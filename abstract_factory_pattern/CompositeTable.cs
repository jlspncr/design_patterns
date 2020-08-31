using System;

namespace abstract_factory_pattern
{
  // concrete product (A2)
  public class CompositeTable : Dining
  {
    public override void ShowDescription()
    {
      Console.WriteLine("AmazonBasics " + this.GetType().Name + ": perfect for a small kitchen");
    }
  }
}