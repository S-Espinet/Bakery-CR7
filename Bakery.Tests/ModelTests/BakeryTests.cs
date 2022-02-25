using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreateInstanceOfBread_Bread()
    {
      Bread breadOrder = new Bread(0, 0);
      Assert.AreEqual(typeof(Bread), breadOrder.GetType());
    }

    [TestMethod]
    public void GetLoafNumber_ReturnLoafNumber_Integer()
    {
      int loafNumber = 0;
      Bread breadOrder = new Bread(loafNumber, 0);
      int result = breadOrder.LoafNumber;
      Assert.AreEqual(loafNumber, result);
    }

        [TestMethod]
    public void SetLoafNumber_ReturnUserLoafNumber_Integer()
    {
      int loafNumber = 0;
      Bread breadOrder = new Bread(loafNumber, 0);

      int userLoafNumber = 1;
      breadOrder.LoafNumber = userLoafNumber;
      int result = breadOrder.LoafNumber;
      Assert.AreEqual(userLoafNumber, result);
    }

    [TestMethod]
    public void GetPrice_ReturnPrice_Integer()
    {
      int price = 2;
      Bread breadOrder = new Bread(0, price);
      int result = breadOrder.Price;
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void SetPrice_ReturnPrice_Integer()
    {
      int loafNumber = 0;
      int price = 0;
      Bread breadOrder = new Bread(loafNumber, price);
      int priceResult = breadOrder.Price;
      Assert.AreEqual(price, priceResult);
    }

    [TestMethod]
    public void CalculatePrice_ReturnPrice_Integer()
    {
      Bread breadOrder = new Bread(3, 5);
      int result = breadOrder.CalculatePrice();
      Assert.AreEqual(10, result);
    }
  }



//   [TestClass]
//   public class PastryTests
//   {
//     [TestMethod]
//     public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
//     {
//       //Example: LeapYear testLeapYear = new LeapYear();
//       Assert.AreEqual(ExpectedResult, CodeToTest);
//       //Example CodeToTest: testLeapYear.IsLeapYear(2020)
//     }
//   }
}