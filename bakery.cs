using System;
namespace Products
{
    class Pastrys 
    {
        private int Price = 2;
        private int PriceBreakAmount = 3;
        private int PriceBreakPrice = 5;

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
            // taking the price break and dividing it by the quantity of bread req. to calculate cost
            int priceBreakTotal = Decimal.ToInt32(
                quantity / PriceBreakAmount);
            int regularTotal = 
            quantity - (priceBreakTotal * PriceBreakAmount);

            int cost = (regularTotal * 
            Price) + (priceBreakTotal * 
            PriceBreakPrice); // calculating the total cost
            return cost;
        }

    }
}