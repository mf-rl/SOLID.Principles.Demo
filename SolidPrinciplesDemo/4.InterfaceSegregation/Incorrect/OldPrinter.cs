namespace SOLID.Principles.Demo._4.InterfaceSegregation.Incorrect
{
    public class OldPrinter : IMachine
    {
        public void Print() { /* print */ }
        public void Scan() { throw new NotImplementedException(); }
    }
}
