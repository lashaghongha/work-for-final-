using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_for_final
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }

        public Product(string name, decimal price, string category)
        {
            Name = name;
            Price = price;
            Category = category;
        }

        public virtual void PrintDetails()
        {
            Console.WriteLine($"დასახელება: {Name}, ფასი: {Price}, კატეგორია: {Category}");
        }

        public virtual decimal CalculateDiscount(decimal percentage)
        {
            return Price - (Price * percentage / 100);
        }
    }
}
