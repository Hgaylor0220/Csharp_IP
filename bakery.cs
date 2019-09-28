using System;
namespace Products
{
    class Pastrys 
    {
        private int Price = 2;
        private int PriceBreak = 3;
        private int PriceBreakPrice = 5;

        public Pastrys (int quantity) {
            Console.WriteLine("You want " + quantity + " pastires.");
        }

        public ReturnCost (int quanity){
            int cost = 5;
            return cost;
        }
    
    }
    // class bread
    // {
    //     public int Price { get; set; }
    //     public int Quanity { get; set; }

    // }
}