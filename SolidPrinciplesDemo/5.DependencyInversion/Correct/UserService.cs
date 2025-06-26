namespace SolidPrinciplesDemo._5.DependencyInversion.Correct
{
    /*
        Definition: High-level modules should not depend on low-level modules. Both should depend on abstractions.

        Why it respects DIP: UserService depends on the ILogger abstraction. You can easily swap logging strategies (file, database, console) without changing UserService.
    */
    public class UserService
    {
        private readonly ILogger logger;
        public UserService(ILogger logger) { this.logger = logger; }
        public void RegisterUser() { logger.Log("User Registered"); }
    }
}
