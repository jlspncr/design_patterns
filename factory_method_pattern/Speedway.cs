using System;

namespace factory_method_pattern
{

  // Concrete creator -- Motor Speedway
  class Speedway : Contractor
  {
    // Factory method implementation
    public override void CreateRoad()
    {
      Roads.Add(new RaceTrack());
      Roads.Add(new CallBox());
      Roads.Add(new Pits());
    }
  }
}
