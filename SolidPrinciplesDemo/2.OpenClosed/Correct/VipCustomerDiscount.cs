namespace SOLID.Principles.Demo._2.OpenClosed.Correct
{
    public class VipCustomerDiscount : IDiscount
    {
        public double GetDiscount() => 0.3;
    }
}
