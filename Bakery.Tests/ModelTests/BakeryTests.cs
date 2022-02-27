using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreateInstanceOfBread_Bread()
    {
      Bread breadOrder = new Bread(0);
      Assert.AreEqual(typeof(Bread), breadOrder.GetType());
    }

    [TestMethod]
    public void GetLoafNumber_ReturnLoafNumber_Integer()
    {
      int loafNumber = 0;
      Bread breadOrder = new Bread(loafNumber);
      int result = breadOrder.LoafNumber;
      Assert.AreEqual(loafNumber, result);
    }

    [TestMethod]
    public void SetLoafNumber_ReturnUserLoafNumber_Integer()
    {
      int loafNumber = 0;
      Bread breadOrder = new Bread(loafNumber);

      int userLoafNumber = 1;
      breadOrder.LoafNumber = userLoafNumber;
      int result = breadOrder.LoafNumber;
      Assert.AreEqual(userLoafNumber, result);
    }

    [TestMethod]
    public void GetPrice_ReturnPrice_Integer()
    {
      int price = 5;
      Bread breadOrder = new Bread(0);
      int result = breadOrder.Price;
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void CalculatePrice_ReturnPrice_Integer10()
    {
      int loafNumber = 3;
      Bread breadOrder = new Bread(loafNumber);
      int result = breadOrder.CalculatePrice();
      Assert.AreEqual(10, result);
    }

    [TestMethod]
    public void CalculatePrice_ReturnPrice_Integer5()
    {
      int loafNumber = 1;
      Bread breadOrder = new Bread(loafNumber);
      int result = breadOrder.CalculatePrice();
      Assert.AreEqual(5, result);
    }

    [TestMethod]
    public void CalculatePrice_ReturnPrice_Integer15()
    {
      int loafNumber = 4;
      Bread breadOrder = new Bread(loafNumber);
      int result = breadOrder.CalculatePrice();
      Assert.AreEqual(15, result);
    }
  }

  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreateInstanceOfPastry_Pastry()
    {
      Pastry pastryOrder = new Pastry(0);
      Assert.AreEqual(typeof(Pastry), pastryOrder.GetType());
    }

    [TestMethod]
    public void GetPastriesNumber_ReturnPastriesNumber_Integer()
    {
      int pastriesNumber = 0;
      Pastry pastryOrder = new Pastry(pastriesNumber);
      int result = pastryOrder.PastriesNumber;
      Assert.AreEqual(pastriesNumber, result);
    }

    [TestMethod]
    public void SetPastriesNumber_ReturnUserPastriesNumber_Integer()
    {
      int pastriesNumber = 0;
      Pastry pastriesOrder = new Pastry(pastriesNumber);
      int userPastriesNumber = 1;
      pastriesOrder.PastriesNumber = userPastriesNumber;
      int result = pastriesOrder.PastriesNumber;
      Assert.AreEqual(userPastriesNumber, result);
    }

    [TestMethod]
    public void GetSinglePastryPrice_ReturnSinglePastryPrice_Integer()
    {
      int singlePastryprice = 2;
      Pastry pastriesOrder = new Pastry(0);
      int result = pastriesOrder.SinglePastryPrice;
      Assert.AreEqual(singlePastryprice, result);
    }

        [TestMethod]
    public void GetBoxedPastryPrice_ReturnBoxedPastryPrice_Integer()
    {
      int boxedPastryprice = 5;
      Pastry pastriesOrder = new Pastry(0);
      int result = pastriesOrder.BoxedPastryPrice;
      Assert.AreEqual(boxedPastryprice, result);
    }
  }
}