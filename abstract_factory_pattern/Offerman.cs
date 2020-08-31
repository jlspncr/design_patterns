using System;

namespace abstract_factory_pattern
{
  class Offerman : Vendor
  {
    // Concrete factory (#1) -- creates concrete product objects
    public override Office CreateOffice()
    {
      return new WalnutChair();
    }

    public override Dining CreateDining()
    {
      return new OakTable();
      // Console.WriteLine("hello there dining room");
    }

  }
}