
namespace PointOfSale
{
    public class DiscountCard
    {
        private double Amount { get; set; }

        public DiscountCard(double amount)
        {
            Amount = amount;
        }

        public int GetDiscountPercent()
        {
            int percent = 0;
            if (Amount >= 1000 && Amount <= 1999)
            {
                percent = 1;
            }
            if (Amount >= 2000 && Amount <= 4999)
            {
                percent = 3;
            }
            if (Amount >= 5000 && Amount <= 9999)
            {
                percent = 5;
            }
            if (Amount >= 10000)
            {
                percent = 7;
            }
            return percent;

        }

        public void AddAmount(double total)
        {
            Amount += total;
        }
        public double ApplyDiscount()
        {
            return (100 - GetDiscountPercent()) / 100d;
        }
    }
}
