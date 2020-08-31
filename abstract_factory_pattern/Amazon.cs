using System;

namespace abstract_factory_pattern
{
  class Amazon : Vendor
  {
    // Concrete factory (#2) -- creates concrete product objects 
    public override Office CreateOffice()
    {
      return new SwivelChair();
    }

    public override Dining CreateDining()
    {
      return new CompositeTable();
      // Console.WriteLine("hello there dining room");
    }

  }
}