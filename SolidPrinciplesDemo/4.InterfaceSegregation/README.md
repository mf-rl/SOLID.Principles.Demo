# 🔌 Interface Segregation Principle (ISP)

> **"Clients should not be forced to depend on methods they do not use."**

Interfaces should be small and focused.

### ❌ [Incorrect Implementation](https://github.com/mf-rl/SOLID.Principles.Demo/blob/master/SolidPrinciplesDemo/4.InterfaceSegregation/Incorrect.cs)
```csharp
public interface IMachine
{
    void Print();
    void Scan();
}

public class OldPrinter : IMachine
{
    public void Print() { /* printing logic */ }
    
    // Problem: Forced to implement scanning even though it can't scan
    public void Scan() 
    { 
        throw new NotImplementedException(); 
    }
}

public class MultiFunctionPrinter : IMachine
{
    public void Print() { /* printing logic */ }
    public void Scan() { /* scanning logic */ }
}
```

**Problems:**
- Classes are forced to implement methods they don't need
- Violates the interface contract with exceptions
- Creates unnecessary dependencies

### ✅ [Correct Implementation](https://github.com/mf-rl/SOLID.Principles.Demo/blob/master/SolidPrinciplesDemo/4.InterfaceSegregation/Correct.cs)
```csharp
public interface IPrinter 
{ 
    void Print(); 
}

public interface IScanner 
{ 
    void Scan(); 
}

public class OldPrinter : IPrinter
{
    public void Print() { /* printing logic */ }
}

public class MultiFunctionPrinter : IPrinter, IScanner
{
    public void Print() { /* printing logic */ }
    public void Scan() { /* scanning logic */ }
}
```

**Benefits:**
- Classes only implement interfaces they actually need
- No unnecessary method implementations
- Clear and focused interfaces
