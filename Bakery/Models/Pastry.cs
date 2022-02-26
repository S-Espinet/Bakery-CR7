namespace Bakery
{
  public class Pastry
  {
    public int PastriesNumber { get; set; }

    public int PastryPrice { get; set; }

    public Pastry(int pastriesNumber, int pastryPrice)
    {
      PastriesNumber = pastriesNumber;
      PastryPrice = pastryPrice;
    }
  }
}