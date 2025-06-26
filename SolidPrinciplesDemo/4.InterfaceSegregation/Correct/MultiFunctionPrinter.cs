namespace SOLID.Principles.Demo._4.InterfaceSegregation.Correct
{
    /*
        Definition: Clients should not be forced to depend on methods they do not use. Interfaces should be small and focused.

        Why it respects ISP: Classes only implement the interfaces they actually need. No unnecessary method implementations.
    */
    public class MultiFunctionPrinter : IPrinter, IScanner
    {
        public void Print() { /* print */ }
        public void Scan() { /* scan */ }
    }
}
