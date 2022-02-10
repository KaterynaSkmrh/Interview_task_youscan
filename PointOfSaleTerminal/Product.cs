

namespace PointOfSale
{
    public class Product
    {
        public string Code { get; }
        public double Price { get;  }
        public VolumeDiscount VolumeDiscount { get; set; }


        public Product(string code, double price)
        {
            Code = code;
            Price = price;
        }

        public Product(string code, double price, VolumeDiscount volumeDiscount)
        {
            Code = code;
            Price = price;
            VolumeDiscount = volumeDiscount;
        }

        
    }
}
