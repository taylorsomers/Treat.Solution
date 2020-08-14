namespace Treats.Models
{
  public class FlavorTreat
  {
    public int FlavorId { get; set; }

    public int FlavorTreatId { get; set; }

    public int TreatId { get; set; }

    public Flavor Flavor { get; set; }

    public Treat Treat { get; set; }
  }
}