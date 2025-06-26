namespace SOLID.Principles.Demo._2.OpenClosed.Correct
{
    public class PremiumCustomerDiscount : IDiscount
    {
        public double GetDiscount() => 0.2;
    }
}
