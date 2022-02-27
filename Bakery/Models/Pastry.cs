namespace Bakery
{
  public class Pastry
  {
    public int PastriesNumber { get; set; }
    public int SinglePastryPrice { get; private set; }
    public int BoxedPastryPrice { get; private set; }

    public Pastry(int pastriesNumber)
    {
      PastriesNumber = pastriesNumber;
      SinglePastryPrice = 2;
      BoxedPastryPrice = 5;
    }

    public int CalculatePastryPrice()
    {
      int boxedPastryTotalPrice = PastriesNumber / 3 * BoxedPastryPrice;
      int singlePastryTotalPrice = PastriesNumber % 3 * SinglePastryPrice;
      int calculatedPastryPrice = boxedPastryTotalPrice + singlePastryTotalPrice;
      return calculatedPastryPrice;
    }
  }
}