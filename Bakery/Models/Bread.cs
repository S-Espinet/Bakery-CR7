namespace Bakery.Models
{
  public class Bread
  {
    public int LoafNumber { get; set; }

    public int Price { get; private set; }
    public Bread(int loafNumber)
    {
      LoafNumber = loafNumber;
      Price = 5;
    }

    public int CalculatePrice()
    {
      int freeLoafCounter = 3;
      int freeLoaves = LoafNumber / freeLoafCounter;
      int calculatedPrice = (LoafNumber - freeLoaves) * Price;
      return calculatedPrice;
    }
  }
}