namespace Bakery
{
  public class Bread
  {
    public int LoafNumber { get; set; }

    public int Price { get; }
    public Bread(int loafNumber, int price)
    {
      LoafNumber = loafNumber;
      Price = price;
    }
  }
}