using System;

namespace builder_pattern
{
  // 'Concrete Builder' class -- ViolinBuilder
  class ViolinBuilder : InsBuilder
  {
    public ViolinBuilder()
    {
      instrument = new Instrument("Electrified Violin");
    }

    public override void BuildNeck()
    {
      instrument["neck"] = "Maple";
    }

    public override void BuildBody()
    {
      instrument["body"] = "Hollow, Maple Top, Spruce Back & Sides";
    }

    public override void BuildPickups()
    {
      instrument["pickups"] = "Acoustic Pickup";
    }

    public override void BuildHardware()
    {
      instrument["hardware"] = "None";
    }
  }
}