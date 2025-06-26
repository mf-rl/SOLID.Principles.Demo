namespace SolidPrinciplesDemo._3.LiskovSubstitution.Incorrect
{
    public class Ostrich : Bird
    {
        public override void Fly()
        {
            throw new NotImplementedException();
        }
    }
}
