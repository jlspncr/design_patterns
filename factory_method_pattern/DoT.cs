using System;

namespace factory_method_pattern
{

  // Concrete creator -- DoT (Department of Transportation)
  class DoT : Contractor
  {
    // Factory method implementation
    public override void CreateRoad()
    {
      Roads.Add(new ConcreteRoad());
      Roads.Add(new Highway());
      Roads.Add(new GuardRail());
    }
  }
}
