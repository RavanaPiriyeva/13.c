using System;

namespace ClassLibrary1
{
    public class Product

    {
        public int No { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double DiscountPercent { get; set; }

        public virtual string GetInfo()
        {
            return $"No: {No}    Name: {Name}   Price: {Price}  Discout percent: {DiscountPercent}";
        }
    }
}
