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
      Bread breadLoaf = new Bread(0);
      Assert.AreEqual(typeof(Bread), breadLoaf.GetType());
    }

    [TestMethod]
    public void GetLoafNumber_ReturnLoafNumber_Integer()
    {
      int loafNumber = 0;
      Bread breadLoaf = new Bread(loafNumber);
      int result = breadLoaf.LoafNumber;
      Assert.AreEqual(loafNumber, result);
    }

        [TestMethod]
    public void SetLoafNumber_ReturnUserLoafNumber_Integer()
    {
      int loafNumber = 0;
      Bread breadLoaf = new Bread(loafNumber);

      int userLoafNumber = 1;
      breadLoaf.LoafNumber = userLoafNumber;
      int result = breadLoaf.LoafNumber;
      Assert.AreEqual(userLoafNumber, result);
    }

    [TestMethod]
    public void GetPrice_ReturnPrice_Integer()
    {
      int price = 2;
      Bread breadLoaf = new Bread(price);
      int result = breadLoaf.Price;
      Assert.AreEqual(price, result);
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