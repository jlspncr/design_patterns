using System;

namespace builder_pattern
{
  // 'Concrete Builder' class -- GuitarBuilder
  class GuitarBuilder : InsBuilder
  {
    public GuitarBuilder()
    {
      instrument = new Instrument("Guitar");
    }

    public override void BuildNeck()
    {
      instrument["neck"] = "Tele Maple with Rosewood Fingerboard";
    }

    public override void BuildBody()
    {
      instrument["body"] = "Telecaster, Lake Placid Blue";
    }

    public override void BuildPickups()
    {
      instrument["pickups"] = "Dual Single Coil";
    }

    public override void BuildHardware()
    {
      instrument["hardware"] = "Classic Tuners & Chrome plating";
    }
  }
}