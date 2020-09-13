using System;
using System.Collections.Generic;

namespace factory_method_pattern
{
  // CREATOR
  abstract class Contractor
  {
    private List<Road> _roads = new List<Road>();

    public Contractor()
    {
      this.CreateRoad();
    }

    public List<Road> Roads
    {
      get { return _roads; }
    }

    // THE Factory Method
    public abstract void CreateRoad();
  }
}

