namespace Bakery
{
  public class Bread
  {
    public int LoafNumber { get; set; }

    public int Price { get; private set; }
    public Bread(int loafNumber, int price)
    {
      LoafNumber = loafNumber;
      Price = price;
    }

    public int CalculatePrice()
    {
      int freeLoaves = loafNumber / 3;
      int calculatedPrice = (loafNumber - freeLoaves) * 5;
      return calculatedPrice;
    }
  }
}