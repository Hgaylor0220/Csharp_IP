using System;
namespace Products
{
    class Pastrys 
    {
        public int Price {get; set;} = 2;
        public int PriceBreakAmount{get; set;} = 3;
        public int PriceBreakPrice{get; set;} = 5;

        public int quantity;

        public Pastrys (int orderQuantity) {
            
            quantity = orderQuantity;
            Console.WriteLine("You want " + orderQuantity + " pastries.");
        }

        public int ReturnCost (){
            int priceBreakTotal = Decimal.ToInt32(
                quantity / PriceBreakAmount);
            Console.WriteLine("priceBreakTotal: " + priceBreakTotal);
            int regularTotal = 
            quantity - (priceBreakTotal * PriceBreakAmount);
            Console.WriteLine("regularTotal: " + regularTotal);

            int cost = (regularTotal * 
            Price) + (priceBreakTotal * 
            PriceBreakPrice);
            Console.WriteLine("cost: " + cost);
            return cost;
        }
    
    }
    class Bread
    {
        private int Price = 5;
        private int PriceBreakAmount = 3;
        private int PriceBreakPrice = 10;

        public int quantity;

        public Bread(int orderQuantity)
        {
            
            quantity = orderQuantity;
            Console.WriteLine("You want " + orderQuantity + " loaves of bread.");
        }

        public int ReturnCost()
        {
            
            int priceBreakTotal = Decimal.ToInt32(
                quantity / PriceBreakAmount);
            int regularTotal = 
            quantity - (priceBreakTotal * PriceBreakAmount);

            int cost = (regularTotal * 
            Price) + (priceBreakTotal * 
            PriceBreakPrice);
            return cost;
        }

    }
}