using System;
using PointOfSale;

namespace Interview_task_youscan
{
    class Program
    {
        static void Main(string[] args)
        {

            var productA = new Product("A", 1.25, new VolumeDiscount(3, 3.0));
            var productB = new Product("B", 4.25);
            var productC = new Product("C", 1.0, new VolumeDiscount(6, 5.0));
            var productD = new Product("D", 0.75);
            var card = new DiscountCard(3000);

            PointOfSaleTerminal terminal = new PointOfSaleTerminal();
            terminal.Scan(productA);
            terminal.Scan(productA);
            terminal.Scan(productA);
            terminal.Scan(productA);
            terminal.Scan(productB);
            terminal.Scan(productC);
            terminal.Scan(productD);
            terminal.Scan(productA);
            terminal.Scan(productA);
            terminal.Scan(productA);

            //terminal.Scan(prodA);
            //terminal.Scan(prodA);
            //terminal.Scan(prodA);
            //terminal.Scan(prodA);
            //terminal.Scan(prodB);
            //terminal.Scan(prodC);
            //terminal.Scan(prodD);
            //terminal.Scan(prodA);
            //terminal.Scan(prodA);
            //terminal.Scan(prodA);
            //terminal.Scan(prodB);
            //terminal.Scan(prodD);
            double result = terminal.CalculateTotal();
            terminal.ApplyDiscountCard(card);
            double resultWithDiscount = terminal.CalculateTotal();
            Console.WriteLine(result + "  " + resultWithDiscount);
        }
    }
}
