namespace SOLID.Principles.Demo._1.SingleResponsibility.Correct
{
    public class InvoiceManager
    {
        /*
            Principle definition: A class should have one and only one reason to change. This means it should only have one job or responsibility.

            Why this class respects SRP: Each responsibility (saving, printing, emailing) is handled by separate classes.
        */
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
}
