### 1. 🎯 Single Responsibility Principle (SRP)

> **"A class should have one and only one reason to change."**

A class should only have one job or responsibility.

#### ❌ Incorrect Implementation
```csharp
public class InvoiceManager
{
    // Problem: This class handles saving, printing, AND emailing
    public static void ProcessInvoice()
    {
        SaveToDatabase();    // Responsibility 1: Data persistence
        PrintInvoice();      // Responsibility 2: Printing
        SendInvoiceEmail();  // Responsibility 3: Email communication
    }
    
    private static void SaveToDatabase() { /* saving logic */ }
    private static void PrintInvoice() { /* printing logic */ }
    private static void SendInvoiceEmail() { /* emailing logic */ }
}
```

**Problems:**
- Changes in database logic affect the same class as printing changes
- Violates the "single reason to change" rule
- Hard to test individual responsibilities

#### ✅ Correct Implementation
```csharp
public class InvoiceManager
{
    // Each responsibility is handled by separate classes
    public static void ProcessInvoice()
    {
        InvoiceRepository.SaveToDatabase();
        InvoicePrinter.PrintInvoice();
        InvoiceEmailSender.SendInvoiceEmail();
    }
}

public class InvoiceRepository
{
    public static void SaveToDatabase() { /* saving logic */ }
}

public class InvoicePrinter
{
    public static void PrintInvoice() { /* printing logic */ }
}

public class InvoiceEmailSender
{
    public static void SendInvoiceEmail() { /* emailing logic */ }
}
```

**Benefits:**
- Each class has a single responsibility
- Changes in one area don't affect others
- Easy to test and maintain

---
