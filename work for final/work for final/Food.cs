using System;

namespace work_for_final
{
    public class Food : Product
    {
        public DateTime PurchaseDate { get; set; } // შეძენის თარიღი
        public DateTime ExpiryDate { get; set; } // ვადის გასვლა

        public Food(string name, decimal price, string category, DateTime purchaseDate, DateTime expiryDate)
            : base(name, price, category)
        {
            PurchaseDate = purchaseDate;
            ExpiryDate = expiryDate;
        }

        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine($"შეძენის თარიღი: {PurchaseDate.ToShortDateString()}, ვადის გასვლა: {ExpiryDate.ToShortDateString()}");
        }
    }
}
