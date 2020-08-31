using System;

namespace abstract_factory_pattern
{
  // concrete product (B1)
  public class WalnutChair : Office
  {
    public override void ShowDescription()
    {
      Console.WriteLine("OWS " + this.GetType().Name + ": a piece I submitted to the 'Indiana Fine Woodworking Association', who felt it merrited consideration for an award.\n");
    }
  }
}