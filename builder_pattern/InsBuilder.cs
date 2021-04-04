using System;

namespace builder_pattern
{
  // 'Builder' class -- Instrument Builder
  abstract class InsBuilder
  {
    protected Instrument instrument;

    // Gets Instrument instance. Ha!
    public Instrument Instrument
    {
      get { return instrument; }
    }

    // Abstract build methods
    public abstract void BuildNeck();
    public abstract void BuildBody();
    public abstract void BuildPickups();
    public abstract void BuildHardware();
  }
}