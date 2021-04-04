using System;
using System.Collections.Generic;

namespace builder_pattern
{
  // 'Product' class -- Instrument 
  class Instrument
  {
    private string _insType;
    private Dictionary<string, string> _parts =
      new Dictionary<string, string>();

    // Constructor
    public Instrument(string insType)
    {
      this._insType = insType;
    }

    // Indexer
    public string this[string key]
    {
      get { return _parts[key]; }
      set { _parts[key] = value; }
    }

    public void Show()
    {
      Console.WriteLine("\n");
      Console.WriteLine("Instrument Type: {0}", _insType);
      Console.WriteLine("Neck : {0}", _parts["neck"]);
      Console.WriteLine("Body : {0}", _parts["body"]);
      Console.WriteLine("Pickups : {0}", _parts["pickups"]);
      Console.WriteLine("Hardware : {0}", _parts["hardware"]);
    }
  }
}