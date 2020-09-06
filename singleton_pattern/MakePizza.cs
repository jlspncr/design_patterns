using System;
using System.Collections.Generic;
using System.Threading;

namespace singleton_pattern
{
  // The singleton class
  class MakePizza
  {
    private static MakePizza _instance;
    private List<string> _specialty = new List<string>();
    private Random _random = new Random();

    private static object syncLock = new object();

    protected MakePizza()
    {
      _specialty.Add("Meat Lover");
      _specialty.Add("Hawaiian");
      _specialty.Add("Supreme");
      _specialty.Add("Cheese");
      _specialty.Add("Veggie");
    }

    public static MakePizza ServePizza()
    // 'Double checked locking' avoids locking every time the method is invoked
    {
      if (_instance == null)
      {
        lock (syncLock)
        {
          if (_instance == null)
          {
            _instance = new MakePizza();
          }
        }
      }
      return _instance;
    }

    public string Pizza
    {
      get
      {
        int r = _random.Next(_specialty.Count);
        return _specialty[r].ToString();
      }
    }

  }


}

