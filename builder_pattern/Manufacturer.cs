using System;

namespace builder_pattern
{
  // 'Director' class -- Manufacturer
  class Manufacturer
  {
    // Constructs objects using the builder interface
    public void Construct(InsBuilder instrumentBuilder)
    {
      instrumentBuilder.BuildNeck();
      instrumentBuilder.BuildBody();
      instrumentBuilder.BuildPickups();
      instrumentBuilder.BuildHardware();
    }

  }
}