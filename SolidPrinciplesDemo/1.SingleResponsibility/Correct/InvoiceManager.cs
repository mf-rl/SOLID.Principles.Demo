namespace SOLID.Principles.Demo._1.SingleResponsibility.Correct
{
    /*
        Principle definition: A class should have one and only one reason to change. This means it should only have one job or responsibility.

        Why this class respects SRP: Each responsibility (saving, printing, emailing) is handled by separate classes.
    */
    public class InvoiceManager
    {
        public static void ProcessInvoice()
        {
            InvoiceRepository.SaveToDatabase();
            InvoicePrinter.PrintInvoice();
            InvoiceEmailSender.SendInvoiceEmail();
        }
    }
}
