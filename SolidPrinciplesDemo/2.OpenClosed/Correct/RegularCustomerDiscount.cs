namespace SOLID.Principles.Demo._2.OpenClosed.Correct
{
    public class RegularCustomerDiscount : IDiscount
    {
        public double GetDiscount() => 0.1;
    }
}