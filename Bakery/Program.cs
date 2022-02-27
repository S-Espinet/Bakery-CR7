using System;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!\n \n###########################\n \nPierre's Prices:\n \n  Bread: $5/Loaf.....Buy 2, get one free!\n \n  Pastries:\n   Single Pastry.....$2\n   Box of 3.....$5");
      Console.WriteLine("Please tell us how many loaves of bread and how many pastries you would like to order.");
      Console.WriteLine(" Loaves of Bread: ");
      string loafNumber = Console.ReadLine();
      int userLoafNumber;
      try
      {
        userLoafNumber = int.Parse(loafNumber);
      }
      catch
      {
        Console.WriteLine("Please enter a numeral (e.g. 4). Exiting program...");
        return;
      }
      if (userLoafNumber < 0)
      {
        Console.WriteLine("Please enter a positive number. Exiting program...");
        return;
      }
      Console.WriteLine(" Pastries: ");
      string pastriesNumber = Console.ReadLine();
      int userPastriesNumber;
      try
      {
        userPastriesNumber = int.Parse(pastriesNumber);
      }
      catch
      {
        Console.WriteLine("Please enter a numeral (e.g. 4). Exiting program...");
        return;
      }
      if (userPastriesNumber < 0)
      {
        Console.WriteLine("Please enter a numeral (e.g. 4). Exiting program...");
        return;
      }
      Bread breadOrder = new Bread(userLoafNumber);
      Pastry pastriesOrder = new Pastry(userPastriesNumber);
      int totalCost = breadOrder.CalculatePrice() + pastriesOrder.CalculatePastryPrice(); 
      Console.WriteLine("The total cost of your order is: " + totalCost);
      return;
    }
  }
}