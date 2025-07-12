namespace SolidPrinciplesDemo._3.LiskovSubstitution.Incorrect
{
    /*
        Problem: Ostrich can’t fly, but the base class forces it to implement flying.

        Why it breaks LSP: Replacing a Bird with an Ostrich will cause the program to fail if it tries to call Fly().
     */
    public class Duck : Bird { }
    public class Ostrich : Bird
    {
        public override void Fly()
        {
            throw new NotImplementedException();
        }
    }
    public class Bird
    {
        public virtual void Fly() { /* flying */ }
    }
}