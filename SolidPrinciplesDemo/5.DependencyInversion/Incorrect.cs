namespace SolidPrinciplesDemo._5.DependencyInversion.Incorrect
{
    /*
        Problem: UserService is tightly coupled to FileLogger.

        Why it breaks DIP: High-level class directly depends on a low-level class instead of an abstraction. 
    */
    public class UserService
    {
        private FileLogger logger = new FileLogger();
        public void RegisterUser() { logger.Log("User Registered"); }
    }
    public class FileLogger
    {
        public void Log(string message) { /* log to file */ }
    }
}
