namespace SOLID.Principles.Demo._1.SingleResponsibility.Correct
{
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
