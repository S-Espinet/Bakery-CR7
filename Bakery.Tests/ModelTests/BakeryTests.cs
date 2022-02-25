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
      int loafNumber = 1;
      Bread breadLoaf = new Bread(loafNumber);
      int result = breadLoaf.LoafNumber;
      Assert.AreEqual(loafNumber, result);
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