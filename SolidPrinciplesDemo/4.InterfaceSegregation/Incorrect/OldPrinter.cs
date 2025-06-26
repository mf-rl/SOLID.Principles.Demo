namespace SOLID.Principles.Demo._4.InterfaceSegregation.Incorrect
{
    /*
        Problem: OldPrinter only prints, but is forced to implement scanning.

        Why it breaks ISP: The class is forced to depend on a method it doesn't support.
    */
    public class OldPrinter : IMachine
    {
        public void Print() { /* print */ }
        public void Scan() { throw new NotImplementedException(); }
    }
}
