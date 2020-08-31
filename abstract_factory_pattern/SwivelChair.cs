using System;

namespace abstract_factory_pattern
{
  // concrete product (B2)
  class SwivelChair : Office
  {
    // Console.WriteLine("Belongs with Desk"); 
    public override void ShowDescription()
    {
      Console.WriteLine("AmazonBasics " + this.GetType().Name + ": a great ergonomic addition to any workspace or home office.\n");
    }
  }
}