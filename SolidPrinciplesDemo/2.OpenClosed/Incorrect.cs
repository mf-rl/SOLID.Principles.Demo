namespace SOLID.Principles.Demo._2.OpenClosed.Incorrect
{
    public class DiscountCalculator
    {
        /*
            Problem: Every time you add a new customer type, you have to modify this class.

            Why it breaks OCP: The class is not closed for modification. New conditions require changing existing code. 
        */
        public double CalculateDiscount(string customerType)
        {
            if (customerType == "Regular") return 0.1;
            else if (customerType == "Premium") return 0.2;
            else if (customerType == "VIP") return 0.3;
            else return 0;
        }
    }
}