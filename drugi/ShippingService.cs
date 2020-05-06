using System;
using System.Collections.Generic;
using System.Text;

namespace drugi
{
    class ShippingService
    {
        private double pricePerKg;

        public ShippingService(double pricePerKg)
        {
            this.pricePerKg = pricePerKg;
        }

        public double PricePerKg { get { return this.pricePerKg; } }
        public double deliveryCost(Box box)
        {
            return this.pricePerKg * box.Weight;
        }
    }
}
