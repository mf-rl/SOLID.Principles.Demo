namespace SOLID.Principles.Demo._2.OpenClosed.Correct
{
    public class DiscountCalculator
    {
        /*
            Definition: Classes should be open for extension, but closed for modification. You should be able to add new behavior without changing existing code.

            Why it respects OCP: You can add new discount types without modifying the DiscountCalculator. You just register new strategies externally.
        */

        private readonly IStrategyProvider _strategyProvider;

        public DiscountCalculator(IStrategyProvider strategyProvider)
        {
            _strategyProvider = strategyProvider;
        }

        public double CalculateDiscount(string customerType)
        {
            if (_strategyProvider.DiscountStrategies.TryGetValue(customerType, out IDiscount? value))
            {
                return value.GetDiscount();
            }

            return 0; // Default if type not found
        }
    }
    public interface IDiscount
    {
        double GetDiscount();
    }

    public interface IStrategyProvider
    {
        IDictionary<string, IDiscount> DiscountStrategies { get; }
    }
    public class StrategyProvider : IStrategyProvider
    {
        public IDictionary<string, IDiscount> DiscountStrategies { get; }
        public StrategyProvider()
        {
            DiscountStrategies = new Dictionary<string, IDiscount>(StringComparer.OrdinalIgnoreCase)
            {
                { "Regular", new RegularCustomerDiscount() },
                { "Premium", new PremiumCustomerDiscount() },
                { "VIP", new VipCustomerDiscount() }
            };
        }
    }
    public class PremiumCustomerDiscount : IDiscount
    {
        public double GetDiscount() => 0.2;
    }
    public class RegularCustomerDiscount : IDiscount
    {
        public double GetDiscount() => 0.1;
    }
    public class VipCustomerDiscount : IDiscount
    {
        public double GetDiscount() => 0.3;
    }
}