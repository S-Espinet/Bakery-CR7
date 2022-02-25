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
  }
}

//if loapNumber % 1 = 0
//price = 5 * loafNumber

// if loafNumber % 3 = 0
// price = 10 * loafNumber