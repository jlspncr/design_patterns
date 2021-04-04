using System;

namespace builder_pattern
{
  // 'Concrete Builder' class -- BassBuilder


  class BassBuilder : InsBuilder
  {
    public BassBuilder()
    {
      instrument = new Instrument("Bass Guitar");
    }

    public override void BuildNeck()
    {
      instrument["neck"] = "Full Rosewood Jazz Bass";
    }

    public override void BuildBody()
    {
      instrument["body"] = "Maple, Satin finish";
    }

    public override void BuildPickups()
    {
      instrument["pickups"] = "Jazz Bass Pickups";
    }

    public override void BuildHardware()
    {
      instrument["hardware"] = "Jazz Bass Tuners with gold controls & plating";
    }
  }
}