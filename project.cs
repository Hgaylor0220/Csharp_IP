using System;
using Bakery;

public class Program
{
 public static void Main()
  {
    Bread customerBreadOrder = new Bread(price,quanity);
    Pastry customerPastryOrder = new Pastry(Predicate,quanity);

    Console.WriteLine("Hello! Welcome to Pierre's Bakery! Wye have Pastries and Bread specials on the daily! would you like to take a look around? [Y for yes or N for no] ");
    string Lookaround = Console.ReadLine();
      if(Lookaround.ToLower == "y")
      {
        Console.WriteLine("Wonderful!!! Let me tell you about my specials while I have you! We have a great deal going on for our Pastries one for $2 or 3 for $5!! our bread is going for buy two get on at a whomping price of just $5 per loaf!");
        Console.WriteLine("Would you like to buy any bread or Pastries? maybe both?");
        string UserOrder = Console.ReadLine();
          if(UserOrder.ToLower == "bread")
          {
            customerBreadOrder.calculateCost;
            
          }
          if (UserOrder.ToLower == "pastry")
          {
            Console.WriteLine("Great Choice! We have lots of selections heres a few: Croissants, Danishes, Cannoli, Strudels and Eclairs");
            customerPastryOrder.calculateCost;
            
          }
          if (UserOrder.ToLower == "both")
          {
              customerBreadOrder.calculateCost;
              customerPastryOrder.calculateCost;
          }
      }
      else 
      [
        Console.WriteLine("Thank you for stopping buy! Please come visit us again");
      ]
  }
}
