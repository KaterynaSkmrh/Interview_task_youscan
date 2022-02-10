

namespace PointOfSale
{
   public class VolumeDiscount
    {
        public int Amount { get; set; }
        public double Price { get; set; }
        public VolumeDiscount(int amount, double price)
        {
            Amount = amount;
            Price = price;
        }
    }
}
