using System;
namespace IntroSQL
{
    public class Products
    {
        public Products()
        {
        }

        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string CategoryId { get; set; }
        public int OnSale { get; set; }
        public int StockLevel { get; set; }
    }
}
