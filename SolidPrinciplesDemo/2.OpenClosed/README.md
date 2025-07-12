# 🔓 Open/Closed Principle (OCP)

> **"Classes should be open for extension, but closed for modification."**

You should be able to add new behavior without changing existing code.

### ❌ [Incorrect Implementation](https://github.com/mf-rl/SOLID.Principles.Demo/blob/master/SolidPrinciplesDemo/1.SingleResponsibility/Incorrect.cs)
```csharp
public class DiscountCalculator
{
    // Problem: Every new customer type requires modifying this method
    public double CalculateDiscount(string customerType)
    {
        if (customerType == "Regular") return 0.1;
        else if (customerType == "Premium") return 0.2;
        else if (customerType == "VIP") return 0.3;
        else return 0;
    }
}
```

**Problems:**
- Adding new customer types requires modifying existing code
- Risk of breaking existing functionality
- Violates the "closed for modification" rule

### ✅ [Correct Implementation](https://github.com/mf-rl/SOLID.Principles.Demo/blob/master/SolidPrinciplesDemo/1.SingleResponsibility/Correct.cs)
```csharp
public class DiscountCalculator
{
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
        return 0;
    }
}

public interface IDiscount
{
    double GetDiscount();
}

public class RegularCustomerDiscount : IDiscount
{
    public double GetDiscount() => 0.1;
}

public class PremiumCustomerDiscount : IDiscount
{
    public double GetDiscount() => 0.2;
}

public class VipCustomerDiscount : IDiscount
{
    public double GetDiscount() => 0.3;
}
```

**Benefits:**
- New discount types can be added without modifying existing code
- Existing code remains untouched and stable
- Easy to extend with new functionality
