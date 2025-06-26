namespace SOLID.Principles.Demo._2.OpenClosed.Correct
{
    public class DiscountCalculator
    {
        private static readonly Dictionary<string, IDiscount> _discountStrategies = new(StringComparer.OrdinalIgnoreCase)
        {
            { "Regular", new RegularCustomerDiscount() },
            { "Premium", new PremiumCustomerDiscount() },
            { "VIP", new VipCustomerDiscount() }
        };
        public static double CalculateDiscount(string customerType)
        {
            if (_discountStrategies.TryGetValue(customerType, out IDiscount? value))
            {
                return value.GetDiscount();
            }

            return 0; // Default if type not found
        }
    }
}