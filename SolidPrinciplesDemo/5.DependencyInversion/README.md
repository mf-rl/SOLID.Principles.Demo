### 5. ⬇️ Dependency Inversion Principle (DIP)

> **"High-level modules should not depend on low-level modules. Both should depend on abstractions."**

Depend on abstractions, not concretions.

#### ❌ Incorrect Implementation
```csharp
public class UserService
{
    // Problem: Directly depends on concrete FileLogger class
    private FileLogger logger = new FileLogger();
    
    public void RegisterUser() 
    { 
        logger.Log("User Registered"); 
    }
}

public class FileLogger
{
    public void Log(string message) { /* log to file */ }
}
```

**Problems:**
- High-level class directly depends on low-level implementation
- Hard to swap logging strategies
- Difficult to unit test

#### ✅ Correct Implementation
```csharp
public class UserService
{
    private readonly ILogger logger;
    
    // Depends on abstraction, not concrete implementation
    public UserService(ILogger logger) 
    { 
        this.logger = logger; 
    }
    
    public void RegisterUser() 
    { 
        logger.Log("User Registered"); 
    }
}

public interface ILogger 
{ 
    void Log(string message); 
}

public class FileLogger : ILogger
{
    public void Log(string message) { /* log to file */ }
}

public class DatabaseLogger : ILogger
{
    public void Log(string message) { /* log to database */ }
}
```

**Benefits:**
- Easy to swap logging implementations
- Improved testability with mock objects
- Loose coupling between components
