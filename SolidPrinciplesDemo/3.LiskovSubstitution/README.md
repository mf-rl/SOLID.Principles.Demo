# 🔄 Liskov Substitution Principle (LSP)

> **"Objects of a superclass should be replaceable with objects of subclasses without breaking the application."**

Subclasses must be substitutable for their base classes.

### ❌ [Incorrect Implementation](https://github.com/mf-rl/SOLID.Principles.Demo/edit/master/SolidPrinciplesDemo/3.LiskovSubstitution/Incorrect.cs)
```csharp
public class Bird
{
    public virtual void Fly() { /* flying logic */ }
}

public class Duck : Bird { }

public class Ostrich : Bird
{
    // Problem: Ostrich can't fly but is forced to implement flying
    public override void Fly()
    {
        throw new NotImplementedException(); // Breaks LSP!
    }
}
```

**Problems:**
- Substituting `Bird` with `Ostrich` will cause runtime exceptions
- Violates the "substitutable" contract
- Client code must know implementation details

### ✅ [Correct Implementation](https://github.com/mf-rl/SOLID.Principles.Demo/edit/master/SolidPrinciplesDemo/3.LiskovSubstitution/Correct.cs)
```csharp
public abstract class Bird { }

public interface IFlyingBird
{
    void Fly();
}

public class Duck : Bird, IFlyingBird
{
    public void Fly() { /* flying logic */ }
}

public class Ostrich : Bird
{
    // No flying method - respects the fact that ostriches don't fly
}
```

**Benefits:**
- Any `Bird` can be substituted without breaking functionality
- Only flying birds implement the flying interface
- Clear separation of capabilities
