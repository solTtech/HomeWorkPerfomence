using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._4
{
    internal class Article
    {
        private string productName;
        private string storeName;
        private double productCost;

        public Article(string productName, string storeName, double price)
        {
            this.productName = productName;
            this.storeName = storeName;
            this.productCost = price;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Product: {productName}, Store: {storeName}, Price: {productCost} UAH");
        }

        public string ProductName => productName;
    }

}
