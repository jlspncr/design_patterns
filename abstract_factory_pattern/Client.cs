using System;

namespace abstract_factory_pattern
{
  // Client -- uses interfaces declared by Abstract Factory & Abstract Product
  public class Client
  {
    private Dining _dining;
    private Office _office;

    // Constructor
    public Client(Vendor factory)
    {
      _office = factory.CreateOffice();
      _dining = factory.CreateDining();
    }

    // Vendor shopdining = new Offerman();
    public void GetSuggestion()
    {
      _dining.ShowDescription();
      _office.ShowDescription();
    }

  }
}