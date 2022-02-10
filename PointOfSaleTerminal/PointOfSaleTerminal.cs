using System;
using System.Collections.Generic;
using System.Linq;


namespace PointOfSale
{
    public class PointOfSaleTerminal
    {
        private List<Product> Items { get; }
        private DiscountCard Card { get; set; }
        public double Total { get; set; }
        public double TotalWithDiscount { get; set; }

        public PointOfSaleTerminal()
        {
            Items = new List<Product>();
        }
        public void Scan(Product item)
        {
            Items.Add(item);
        }

        public void ApplyDiscountCard(DiscountCard card)
        {
            Card = card;
        }


        public void Close()
        {
            if(Card!=null)
            { 
                Card.AddAmount(Items.Sum(c => c.Price));
            }          
        }

        private double Calculate()
        {
            double total = 0;
            var groupedItems = Items.GroupBy(c => c);
            foreach (var item in groupedItems)
            {
                if (item.Key.VolumeDiscount != null)
                {
                    total += Convert.ToInt32(item.Count() / item.Key.VolumeDiscount.Amount) * item.Key.VolumeDiscount.Price;
                    total += item.Count() % item.Key.VolumeDiscount.Amount * item.Key.Price;                    
                }
                else
                {
                     total += item.Count() * item.Key.Price;               
                }
            }

            return total;
        }
        private double Calculate(DiscountCard card)
        {
            double total = 0;
            var groupedItems = Items.GroupBy(c => c);
            foreach (var item in groupedItems)
            {
                if (item.Key.VolumeDiscount != null)
                {
                    total += Convert.ToInt32(item.Count() / item.Key.VolumeDiscount.Amount) * item.Key.VolumeDiscount.Price;
                    total += (item.Count() % item.Key.VolumeDiscount.Amount * item.Key.Price) * card.ApplyDiscount();
                }
                else
                {
                    total += (item.Count() * item.Key.Price) *card.ApplyDiscount() ;                                      
                }
            }
           return total;
        }


        public double CalculateTotal()
        {
            if (Card != null)
            {
                return Calculate(Card);
            }
            else
            {
                return Calculate();
            }
        }
    }
}
