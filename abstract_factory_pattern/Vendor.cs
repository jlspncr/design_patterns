using System;

namespace abstract_factory_pattern
{
  // Abstract Factory -- declares an interface to create abstract producs
  public abstract class Vendor
  {
    public abstract Office CreateOffice();
    // CreateProductA()
    public abstract Dining CreateDining();
    // CreateProductB()
  }
}