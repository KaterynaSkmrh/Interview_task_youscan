using NUnit.Framework;
using PointOfSale;

namespace Interview_task_youscan.Tests
{
    public class Tests
    {
        Product productA = new Product("A", 1.25, new VolumeDiscount(3, 3.0));
        Product productB = new Product("B", 4.25);
        Product productC = new Product("C", 1.0, new VolumeDiscount(6, 5.0));
        Product productD = new Product("D", 0.75);
        DiscountCard card = new DiscountCard(3000);


        [Test]

        public void CalculateTotal_ReturnCorrectValue1()
        {

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
            double result = terminal.CalculateTotal();
            double expected = 13.25;

            Assert.AreEqual(expected, result, message: "CalculateTotal method works incorrectly");


        }
        [Test]
        public void CalculateTotal_ReturnCorrectValue2()
        {

            PointOfSaleTerminal terminal = new PointOfSaleTerminal();
            terminal.Scan(productC);
            terminal.Scan(productC);
            terminal.Scan(productC);
            terminal.Scan(productC);
            terminal.Scan(productC);
            terminal.Scan(productC);
            terminal.Scan(productC);
            double result = terminal.CalculateTotal();
            double expected = 6.0;

            Assert.AreEqual(expected, result, message: "CalculateTotal method works incorrectly");


        }
        [Test]
        public void CalculateTotal_ReturnCorrectValue3()
        {

            PointOfSaleTerminal terminal = new PointOfSaleTerminal();
            terminal.Scan(productA);
            terminal.Scan(productB);
            terminal.Scan(productC);
            terminal.Scan(productD);

            double result = terminal.CalculateTotal();
            double expected = 7.25;

            Assert.AreEqual(expected, result, message: "CalculateTotal method works incorrectly");


        }
        [Test]
        public void CalculateTotal_ReturnCorrectValueWithDiscount()
        {

            PointOfSaleTerminal terminal = new PointOfSaleTerminal();
            terminal.Scan(productC);
            terminal.Scan(productC);
            terminal.Scan(productC);
            terminal.Scan(productC);
            terminal.Scan(productC);
            terminal.Scan(productC);
            terminal.Scan(productC);
            terminal.ApplyDiscountCard(card);
            double result = terminal.CalculateTotal();
            double expected = 5.97;

            Assert.AreEqual(expected, result, message: "CalculateTotal method works incorrectly");


        }
    }
}