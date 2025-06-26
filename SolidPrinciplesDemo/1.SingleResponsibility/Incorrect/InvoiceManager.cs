namespace SOLID.Principles.Demo._1.SingleResponsibility.Incorrect
{
    public class InvoiceManager
    {
        public static void ProcessInvoice()
        {
            SaveToDatabase();
            PrintInvoice();
            SendInvoiceEmail();
        }
        private static void SaveToDatabase() { /* saving logic */ }
        private static void PrintInvoice() { /* printing logic */ }
        private static void SendInvoiceEmail() { /* emailing logic */ }
    }
}