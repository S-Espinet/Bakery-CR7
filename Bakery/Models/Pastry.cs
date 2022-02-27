namespace Bakery
{
  public class Pastry
  {
    public int PastriesNumber { get; set; }
    public int SinglePastryPrice { get; private set; }

    public Pastry(int pastriesNumber)
    {
      PastriesNumber = pastriesNumber;
    }
  }
}