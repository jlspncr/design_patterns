using System;

namespace abstract_factory_pattern
{
  // concrete product (A1)
  public class OakTable : Dining
  {
    public override void ShowDescription()
    {
      Console.WriteLine(this.GetType().Name + ", a great piece to eat, work, read, or all of the above.");
    }
  }
}