using SOLID.Principles.Demo._3.LiskovSubstitution.Correct;

namespace SolidPrinciplesDemo._3.LiskovSubstitution.Correct
{
    public class Duck : Bird, IFlyingBird
    {
        public void Fly() { /* flying */ }
    }
}
