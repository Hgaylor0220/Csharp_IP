using System;
using Products;

public class Program
{
 public static void Main()
  {
   
    Console.WriteLine("Hello! Welcome to Pierre's Bakery! We have Pastries and Bread specials on the daily! We have bread for buy two get one free at $5 per loaf and pastries 3 for $5 or $2 each, would you like to make a purchase? [Y for yes or N for no] ");
    string Lookaround = Console.ReadLine();

    if(Lookaround.ToLower() == "y")
    {
      Console.WriteLine("Wonderful!!! How many loafs of bread would you like,They are Buy 2, get 1 free. A single loaf costs $5?");
      string UserBreadOrder = Console.ReadLine();
      Console.WriteLine("And how many pastries would you like? They are 3 for $5 or $2 each.");
      string UserPastryOrder = Console.ReadLine();

      Pastrys pastry_order = new Products.Pastrys(Convert.ToInt32(UserPastryOrder));
      Bread bread_order = new Products.Bread(Convert.ToInt32(UserBreadOrder));

      int total = pastry_order.ReturnCost() + bread_order.ReturnCost();

      Console.WriteLine("Your total comes to: $" + total);
    }
    else
    {
      Console.WriteLine("Thank you for stopping buy! Please come visit us again");
    }
  }
}
