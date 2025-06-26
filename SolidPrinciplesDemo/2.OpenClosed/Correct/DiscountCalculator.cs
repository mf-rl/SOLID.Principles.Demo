namespace SOLID.Principles.Demo._2.OpenClosed.Correct
{
    /*
        Definition: Classes should be open for extension, but closed for modification. You should be able to add new behavior without changing existing code.
        
        Why it respects OCP: You can add new discount types without modifying the DiscountCalculator. You just register new strategies externally.
    */
    public class DiscountCalculator
    {
        private readonly IDictionary<string, IDiscount> _discountStrategies;

        /*Values for _discountStrategies can be set externally in a different class, like:.
         
            private static readonly Dictionary<string, IDiscount> _discountStrategies = new(StringComparer.OrdinalIgnoreCase)
            {
                { "Regular", new RegularCustomerDiscount() },
                { "Premium", new PremiumCustomerDiscount() },
                { "VIP", new VipCustomerDiscount() }
            };

         , and passed via dependency injection */

        public DiscountCalculator(IDictionary<string, IDiscount> discountStrategies)
        {
            _discountStrategies = discountStrategies;
        }

        public double CalculateDiscount(string customerType)
        {
            if (_discountStrategies.TryGetValue(customerType, out IDiscount? value))
            {
                return value.GetDiscount();
            }

            return 0; // Default if type not found
        }
    }
}