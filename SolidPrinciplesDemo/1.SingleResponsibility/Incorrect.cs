namespace SOLID.Principles.Demo._1.SingleResponsibility.Incorrect
{
    public class InvoiceManager
    {
        /*
            Problem: This class is responsible for data persistence, printing, and emailing — multiple responsibilities.

            Why it breaks SRP: Any change in database logic, printing format, or email functionality would force changes in the same class.
        */
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