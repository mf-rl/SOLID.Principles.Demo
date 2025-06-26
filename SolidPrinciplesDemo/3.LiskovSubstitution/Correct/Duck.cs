using SOLID.Principles.Demo._3.LiskovSubstitution.Correct;

namespace SolidPrinciplesDemo._3.LiskovSubstitution.Correct
{
    /*
        Definition: Objects of a superclass should be replaceable with objects of subclasses without breaking the application.

        Why it respects LSP: You can substitute any Bird without worrying about unsupported operations. Only flying birds implement IFlyingBird interface.
    */
    public class Duck : Bird, IFlyingBird
    {
        public void Fly() { /* flying */ }
    }
}
