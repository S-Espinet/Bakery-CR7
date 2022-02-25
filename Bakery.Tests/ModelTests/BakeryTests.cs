using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    {
      //Example: LeapYear testLeapYear = new LeapYear();
      Assert.AreEqual(ExpectedResult, CodeToTest);
      //Example CodeToTest: testLeapYear.IsLeapYear(2020)
    }
  }



  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    {
      //Example: LeapYear testLeapYear = new LeapYear();
      Assert.AreEqual(ExpectedResult, CodeToTest);
      //Example CodeToTest: testLeapYear.IsLeapYear(2020)
    }
  }
}