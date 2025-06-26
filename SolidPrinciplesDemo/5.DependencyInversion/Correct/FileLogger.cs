namespace SolidPrinciplesDemo._5.DependencyInversion.Correct
{
    public class FileLogger : ILogger
    {
        public void Log(string message) { /* log to file */ }
    }
}
