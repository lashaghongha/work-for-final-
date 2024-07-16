using System;

namespace work_for_final
{
    public class Electronics : Product
    {
        public int WarrantyPeriod { get; set; } // გარანტიის ხანგრძლივობა თვეებში

        public Electronics(string name, decimal price, string category, int warrantyPeriod)
            : base(name, price, category)
        {
            WarrantyPeriod = warrantyPeriod;
        }

        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine($"გარანტიის ხანგრძლივობა: {WarrantyPeriod} თვე");
        }
    }
}
