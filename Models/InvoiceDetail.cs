namespace DB2EntityFrameworkPractie
{
    public class InvoiceDetail
    {
        public int InvoiceID { get; set; }
        public int ProductID { get; set; }
        public Invoice Invoice { get; set; }
        public Product Product { get; set; }
        public decimal Quantity { get; set; }
        public decimal Tax { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Total { get; set; }
    }
}