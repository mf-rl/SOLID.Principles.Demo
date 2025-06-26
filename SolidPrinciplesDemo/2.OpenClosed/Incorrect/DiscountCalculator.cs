namespace SOLID.Principles.Demo._2.OpenClosed.Incorrect
{
    public class DiscountCalculator
    {
        public static double CalculateDiscount(string customerType)
        {
            if (customerType == "Regular") return 0.1;
            else if (customerType == "Premium") return 0.2;
            else if (customerType == "VIP") return 0.3;
            else return 0;
        }
    }
}